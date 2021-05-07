using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using G8_DataAccess;

namespace G8_Planet
{
    public partial class frm_planet : Form
    {
        public string ProjectName = "G8_Planet";
        public string nameOwnPlanet;
        public string idOwnPlanet;
        public string codeOwnPlanet;

        public string ipMissatge = "192.168.1.1";

        string fileName = "";
        string filePath = @"C:\";
        string fileContent = "";

        string docSuma = "";
        string defaultPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\_docs";
        private ArrayList nSockets;

        RSACryptoServiceProvider rsa;
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        G8_DataAccess.DataAccess dataAccess = new G8_DataAccess.DataAccess();

       // byte[] encryptedText;

        public frm_planet()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        Thread comprobarConexion;
        Boolean IsConnected;
        TcpClient client;
        TcpListener Listener = null;
        NetworkStream ns;

        public void conectarServer()
        {
            try
            {
                Listener = new TcpListener(IPAddress.Any, 4000);
                Listener.Start();
                TcpClient client = new TcpClient();
                client = null;
                while (IsConnected)
                {

                    if (Listener.Pending())
                    {

                        client = Listener.AcceptTcpClient();
                        ns = client.GetStream();

                        Byte[] buffer = new byte[1024];

                        string data = "";
                        ns.Read(buffer, 0, buffer.Length);
                        data = Encoding.ASCII.GetString(buffer, 0, buffer.Length);

                        string[] ExistingFiles;
                        bool ZipFileExists = false;
                        byte[] RecData = new byte[buffer.Length];
                        int RecBytes;
                        string path = defaultPath + "\\_receivedDocs";


                        if (data.Contains("VR"))
                        {
                            lbx_Missatges.Items.Add("La IP " + ipMissatge + " ha enviado: " + data);

                        } else
                        {
                            Directory.CreateDirectory(path);

                            ZipFileExists = File.Exists(path + "\\pacs.zip");

                            if (ZipFileExists) //Si el archivo comprimido existe, eliminalo junto a sus elementos extraidos en la carpeta seleccionada.
                            {
                                File.Delete(path + "\\pacs.zip");

                                ExistingFiles = Directory.GetFiles(path + "\\pacs.zip");

                                foreach (string file in ExistingFiles)
                                {
                                    File.Delete(file);
                                }
                            }

                            int totalrecbytes = 0;
                            FileStream Fs = new FileStream(path + "\\pacs.zip", FileMode.OpenOrCreate, FileAccess.Write);

                            while ((RecBytes = ns.Read(RecData, 0, RecData.Length)) > 0)
                            {
                                Fs.Write(RecData, 0, RecBytes);
                                totalrecbytes += RecBytes;
                            }
                            Fs.Close();
                            ns.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_desconnect_Click(object sender, EventArgs e)
        {
            lbx_Missatges.Items.Clear();
            closeServer();
        }

        private void frmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeServer();
        }

        public void closeServer()
        {
            IsConnected = false;
            if (this.comprobarConexion != null)
            {
                comprobarConexion.Abort();
            }

            if (this.Listener != null)
            {
                Listener.Stop();
            }

            if (this.client != null)
            {
                client.Close();
            }

            if (this.ns != null)
            {
                ns.Close();
            }
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            DataSet dts;
            dataAccess.connectToDDBB(ProjectName);
            dts = dataAccess.getByQuery("SELECT * FROM InnerEncryption WHERE idPlanet = " + idOwnPlanet, ProjectName);


            if (dts.Tables[0].Rows.Count == 0)
            {
                return;
            }
            string InnerEncryptionCode = dts.Tables[0].Rows[0]["ValidationCode"].ToString();

            CspParameters cspp = new CspParameters();
            string keyName = InnerEncryptionCode;
            cspp.KeyContainerName = keyName;
            rsa = new RSACryptoServiceProvider(cspp);
            string publicKey = rsa.ToXmlString(false);
            rsa.PersistKeyInCsp = false;
            rsa.Clear();

            dts = dataAccess.getByQuery("INSERT INTO PlanetKeys(idPlanet, XMLKey) VALUES(" + idOwnPlanet + ", '" + publicKey + "')", ProjectName);
        }

        private void btn_routeXML_Click(object sender, EventArgs e)
        {
            //establecer una ruta

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\";
                openFileDialog.Filter = "Xml files (*.xml)|*.xml" + "|" + "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    fileName = openFileDialog.SafeFileName;
                    Stream fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }

                    tbx_routeXML.Text = filePath;
                    //MessageBox.Show("File " + fileName + " on hold.");
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dts;

            lbl_identificadorplaneta.Text = "";

            nameOwnPlanet = comboBox1.Text;

            dataAccess.connectToDDBB(ProjectName);
            dts = dataAccess.getByQuery("SELECT * FROM Planets WHERE DescPlanet = '" + nameOwnPlanet + "'", ProjectName);

            if (dts.Tables[0].Rows.Count == 0)
            {
                return;
            }
            idOwnPlanet = dts.Tables[0].Rows[0]["idPlanet"].ToString();
            codeOwnPlanet = dts.Tables[0].Rows[0]["CodePlanet"].ToString();


            dts = dataAccess.getByQuery("SELECT * FROM InnerEncryption WHERE idPlanet = '" + idOwnPlanet + "'", ProjectName);

            if (dts.Tables[0].Rows.Count == 0)
            {
                return;
            }

            lbl_identificadorplaneta.Text = dts.Tables[0].Rows[0]["ValidationCode"].ToString();
        }



        private void frm_planet_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'secureCoreDataSet.Planets' Puede moverla o quitarla según sea necesario.
            DataSet dts;

            dataAccess.connectToDDBB(ProjectName);
            dts = dataAccess.getByQuery("SELECT * FROM Planets ORDER BY DescPlanet ASC","Planets", ProjectName);
            comboBox1.DisplayMember = "DescPlanet";
            comboBox1.ValueMember = "idPlanet";
            comboBox1.DataSource = dts.Tables["Planets"];


            IPHostEntry IPHost = Dns.GetHostByName(Dns.GetHostName());
            //lblStatus.Text = "My IP address is " + IPHost.AddressList[0].ToString(); //ShowIP
            nSockets = new ArrayList();
            Thread thdListener = new Thread(new ThreadStart(listenerThread));
            thdListener.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Genero innerEncryptionCode
            string validationCode = GetRandom();
            string idInnerEncryption;

            DataSet dts;

            //Inserto innerEncriptionCode en BBDD
            dataAccess.connectToDDBB(ProjectName);
            dts = dataAccess.getByQuery("INSERT INTO InnerEncryption(idPlanet, ValidationCode) VALUES("+idOwnPlanet+", "+ validationCode + ")", ProjectName);


            //coger id del nuevo registro
            dts = dataAccess.getByQuery("SELECT * FROM InnerEncryption WHERE ValidationCode = '" + validationCode + "'", ProjectName);

            if (dts.Tables[0].Rows.Count == 0)
            {
                return;
            }
            idInnerEncryption = dts.Tables[0].Rows[0]["idInnerEncryption"].ToString();


            //Generar coordenades
            Dictionary<String, String> coordenades = generateDictionary();

            //Insertar coordenades en la BBDD

            for (int index = 0; index < coordenades.Count; index++)
            {
                var item = coordenades.ElementAt(index);
                string itemKey = item.Key;
                string itemValue = item.Value;

                //lbx_mostrarletras.Items.Add(itemKey);
                //lbx_mostrarnumeros.Items.Add(itemValue.ToString().PadLeft(5, '0'));

                dts = dataAccess.getByQuery("INSERT INTO InnerEncryptionData(IdInnerEncryption, Word, Numbers) VALUES ("+idInnerEncryption+", '"+ item.Key.ToString()+ "', '"+item.Value.ToString()+"')", ProjectName);
            }
            
        }

        private static string GetRandom()
        {
            int min = 0;
            int max = 9;
            int currentDigit = 0;
            string numberCode = "";

            for (int i = 0; i < 12; i++)
            {
                using (System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
                {
                    byte[] randomNumber = new byte[4];
                    rng.GetBytes(randomNumber);
                    int value = BitConverter.ToInt32(randomNumber, 0);
                    currentDigit = Math.Abs(value % max + min);
                    numberCode = numberCode + currentDigit;
                }

            }

            return numberCode;
        }

        static Dictionary<string, string> generateDictionary()
        {
            Dictionary<String, String> coordenades = new Dictionary<string, string>();
            List<string> alphabet = new List<string>();
            Queue<int> numeros_aleatorios = new Queue<int>();

            var rnd = new Random();
            int numero;

            for (char c = 'A'; c <= 'Z'; c++)
            {
                alphabet.Add("" + c);
            }

            while (numeros_aleatorios.Count() < 26)
            {
                numero = rnd.Next(1000);

                if (!numeros_aleatorios.Contains(numero))
                {
                    numeros_aleatorios.Enqueue(numero);
                }

            }

            foreach (String leter in alphabet)
            {
                coordenades.Add(leter, numeros_aleatorios.Dequeue().ToString().PadLeft(3, '0'));
            }

            return coordenades;

        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Listener Connected");

            if (!IsConnected)
            {
                comprobarConexion = new Thread(conectarServer);
                comprobarConexion.Start();
                IsConnected = true;
            }
        }
    
        private void btn_genArc_Click(object sender, EventArgs e)
        {
            string doc1 = "", doc2 = "", doc3 = "";

            doc1 = generarLetras(doc1);
            doc2 = generarLetras(doc2);
            doc3 = generarLetras(doc3);
            docSuma = doc1 + doc2 + doc3;
            //MessageBox.Show("Documentos generados");

            //doc1 = traducirArchivos(doc1);
            //doc2 = traducirArchivos(doc2);
            //doc3 = traducirArchivos(doc3);
            //MessageBox.Show("Documentos traducidos");

            generarArchivos(doc1, "doc1", defaultPath + "\\generatedDocs");
            generarArchivos(doc2, "doc2", defaultPath + "\\generatedDocs");
            generarArchivos(doc3, "doc3", defaultPath + "\\generatedDocs");

            zippearArchivos(defaultPath + "\\generatedDocs", defaultPath + "\\zipDocs.zip");
            desZippearArchivos(defaultPath + "\\zipDocs.zip", defaultPath + "\\extractedDocs");

            MessageBox.Show("Documents guardats");
        }
        string generarLetras(string doc)
        {
            Random rand = new Random();
            for (int i = 0; i < 100000; i++)
            {
                int numero = rand.Next(26);
                char letra = (char)(((int)'A') + numero);
                doc += letra;
            }
            return doc;
        }
        string traducirArchivos(string doc)
        {
            string docTraducido = "";

            DataSet dts;
            dataAccess.connectToDDBB(ProjectName);
            dts = dataAccess.getByQuery("SELECT * FROM InnerEncryptionData ORDER BY Word ASC", "InnerEncryptionData", ProjectName);
            Dictionary<string, string> dict = dts.Tables[0].AsEnumerable()
            .ToDictionary<DataRow, string, string>(row => row[2].ToString(),
                                       row => row[3].ToString());

            for (int i = 0; i < doc.Length; i++)
            {
                string letra = doc[i].ToString();
                docTraducido += dict[letra];
            }

            return docTraducido;
        }
        string desTraducirArchivos(string doc)
        {
            string docDestraducido = "";

            DataSet dts;
            dataAccess.connectToDDBB(ProjectName);
            dts = dataAccess.getByQuery("SELECT * FROM InnerEncryptionData ORDER BY Word ASC", "InnerEncryptionData", ProjectName);
            Dictionary<string, string> dict = dts.Tables[0].AsEnumerable()
            .ToDictionary<DataRow, string, string>(row => row[3].ToString(),
                                       row => row[2].ToString());

            for (int i = 0; i < doc.Length; i += 3)
            {
                string code = doc[i].ToString() + doc[i + 1].ToString() + doc[i + 2].ToString();
                docDestraducido += dict[code].ToString();
            }

            return docDestraducido;
        }
        void generarArchivos(string doc, string nombreDocumento, string path)
        {
            path += "\\" + nombreDocumento + ".txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write(doc);
                }
            }
        }

        void zippearArchivos(string pathDirectory, string zipDirectory) {
            ZipFile.CreateFromDirectory(pathDirectory, zipDirectory);
        } void desZippearArchivos(string zipDirectory, string extractDirectory) {
            ZipFile.ExtractToDirectory(zipDirectory, extractDirectory);
        }

        private void btn_desconnect_Click_1(object sender, EventArgs e)
        {
            closeServer();
        }

        private void btn_sendmessages_Click_1(object sender, EventArgs e)
        {
            try
            {
                TcpClient client = new TcpClient(tbx_ipspaceship.Text, Convert.ToInt32(tbx_port2.Text));
                Byte[] dades = Encoding.ASCII.GetBytes("Prueba");
                NetworkStream ns = client.GetStream();
                ns.Write(dades, 0, dades.Length);
            }
            catch
            {
                MessageBox.Show("Servidor inaccesible");
            }
        }

        private void btn_sendfile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\_docs\\";

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = path;
                    //openFileDialog.Filter = "Xml files (*.xml)|*.xml" + "|" + "All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openFileDialog.FileName;
                        fileName = openFileDialog.SafeFileName;
                        Stream fileStream = openFileDialog.OpenFile();

                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            fileContent = reader.ReadToEnd();
                        }

                        MessageBox.Show("File " + fileName + " on hold.");

                        TcpClient client = new TcpClient(tbx_ipspaceship.Text, Convert.ToInt32(tbx_port2.Text));

                        Byte[] dades = Encoding.ASCII.GetBytes(openFileDialog.FileName);
                        NetworkStream ns = client.GetStream();
                        ns.Write(dades, 0, dades.Length);
                    }
                }


            }
            catch
            {
                MessageBox.Show("Servidor inaccesible");
            }
        }

        public void listenerThread()
        {
            TcpListener tcpListener = new TcpListener(8080);
            tcpListener.Start();
            while (true)
            {
                Socket handlerSocket = tcpListener.AcceptSocket();
                if (handlerSocket.Connected)
                {
                    Control.CheckForIllegalCrossThreadCalls = false;
                    //lbConnections.Items.Add(handlerSocket.RemoteEndPoint.ToString() + " connected."); //Show connected
                    lock (this)
                    {
                        nSockets.Add(handlerSocket);
                    }
                    ThreadStart thdstHandler = new
                    ThreadStart(handlerThread);
                    Thread thdHandler = new Thread(thdstHandler);
                    thdHandler.Start();
                }
            }
        }
        public void handlerThread()
        {
            Socket handlerSocket = (Socket)nSockets[nSockets.Count - 1];
            NetworkStream networkStream = new NetworkStream(handlerSocket);
            int thisRead = 0;
            int blockSize = 1024;
            Byte[] dataByte = new Byte[blockSize];

            //Convert byteArray to string to check
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < dataByte.Length; i++)
            {
                builder.Append(dataByte[i].ToString("x2"));
            }
            string strBuilder = builder.ToString();

            //Check string
            if (strBuilder.Substring(0, 2) == "VK")
            {
                MessageBox.Show("Received VK");
            }
            else
            {
                lock (this)
                {
                    // Only one process can access the same file at any given time

                    Stream fileStream = File.OpenWrite(defaultPath + "\\receivedFiles\\prueba.zip");

                    while (true)
                    {
                        thisRead = networkStream.Read(dataByte, 0, blockSize);
                        fileStream.Write(dataByte, 0, thisRead);
                        if (thisRead == 0) break;
                    }
                    fileStream.Close();
                }
                //lbConnections.Items.Add("File Written"); //Show received
                MessageBox.Show("File received at: " + defaultPath + "\\receivedFiles");
                handlerSocket = null;
            }
        }
    }

}
