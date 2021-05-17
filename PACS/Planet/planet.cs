using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Planet
{
    public partial class planet : Form
    {

        public string ProjectName = "Planet";
        public string nameOwnPlanet;
        public string idOwnPlanet;
        public string codeOwnPlanet;
        public string idInnerEncryption;
        public string validationCode;
        public string keyName;
        public byte[] decryptedData;

        private ArrayList nSockets;

        G8_DataAccess.DataAccess dataAccess = new G8_DataAccess.DataAccess();

        RSACryptoServiceProvider rsa;
        RSACryptoServiceProvider rsad;
        UnicodeEncoding ByteConverter = new UnicodeEncoding();

        public byte[] rawData;

        string docSuma = "";
        string defaultPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Planet\\bin\\Debug\\_docs";

        //new
        private const int BufferSize = 1024;
        public string Status = string.Empty;
        public Thread T = null;

        Boolean IsConnected;
        TcpClient client;
        TcpListener Listener = null;
        NetworkStream ns;
        Thread comprobarConexion;
        Thread recibirArchivos;
        public bool boolForFiles = false;
        public bool boolForEncrypt = false;
        byte[] encryptedData;

        public planet()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void planet_Load(object sender, EventArgs e)
        {
            DataSet dts;

            dataAccess.connectToDDBB(ProjectName);
            dts = dataAccess.getByQuery("SELECT * FROM Planets ORDER BY DescPlanet ASC", "Planets", ProjectName);
            cbx_selectplanet.DisplayMember = "DescPlanet";
            cbx_selectplanet.ValueMember = "idPlanet";
            cbx_selectplanet.DataSource = dts.Tables["Planets"];

            //borrar archivos antiguos
            //System.IO.DirectoryInfo di = new DirectoryInfo(defaultPath);

            //foreach (FileInfo file in di.GetFiles())
            //{
            //    file.Delete();
            //}

            //System.IO.DirectoryInfo diExtracted = new DirectoryInfo(defaultPath + "\\extractedDocs");
            //foreach (FileInfo file in diExtracted.GetFiles())
            //{
            //    file.Delete();
            //}

        }

        private void btn_selectplanet_Click(object sender, EventArgs e)
        {
            nameOwnPlanet = cbx_selectplanet.Text;

            DataSet dts;

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
                MessageBox.Show("This planet doesn't contain a ValidationCode. Please generate one.");
            } else
            {
                validationCode = dts.Tables[0].Rows[0]["ValidationCode"].ToString();
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (!IsConnected)
            {
                comprobarConexion = new Thread(conectarServer);
                comprobarConexion.Start();
                IsConnected = true;
            }
            //ThreadStart Ts = new ThreadStart(StartReceiving);
            //T = new Thread(Ts);
            //T.Start();
        }

        private void btn_desconnect_Click(object sender, EventArgs e)
        {
            closeServer();
        }

        private void btn_answerTCP_Click(object sender, EventArgs e)
        {
            string messagetype = cbx_selectmessage.Text;

            //TODO: coger los datos de la nave desde la BBDD, ahora están harcodeados

            string messageToSpaceship = "";

            if (messagetype.Contains("Validation in Progress"))
            {
                messageToSpaceship = "VR-VP";
            }
            else if (messagetype.Contains("Access Denied"))
            {
                messageToSpaceship = "VR-AD";
            }
            else
            {
                messageToSpaceship = "Others";
            }

            try
            {
                TcpClient client = new TcpClient("127.0.0.1", 4000);

                if (cbx_selectmessage.Text == "")
                {
                    MessageBox.Show("Introducir mensaje");
                }
                else
                {
                    Byte[] dades = Encoding.ASCII.GetBytes(messageToSpaceship);
                    NetworkStream ns = client.GetStream();
                    ns.Write(dades, 0, dades.Length);
                }
            }
            catch
            {
                MessageBox.Show("Servidor inaccesible");
            }
        }

        private void btn_sendfile_Click(object sender, EventArgs e)
        {
            string fileName;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = defaultPath;
                openFileDialog.ShowDialog();
                fileName = openFileDialog.FileName;
            }

            try
            {
                Stream fileStream = File.OpenRead(fileName);
                // Alocate memory space for the file
                byte[] fileBuffer = new byte[fileStream.Length];
                fileStream.Read(fileBuffer, 0, (int)fileStream.Length);
                // Open a TCP/IP Connection and send the data
                TcpClient clientSocket = new TcpClient("127.0.0.1", 4000);
                NetworkStream networkStream = clientSocket.GetStream();
                networkStream.Write(fileBuffer, 0, fileBuffer.GetLength(0));
                networkStream.Close();

                MessageBox.Show("File Send");
            } catch
            {
                return;
            }
        }

        private void btn_generarIdentificador_Click(object sender, EventArgs e)
        {
            G8_Methods.KeyGenerator vkg = new G8_Methods.KeyGenerator();
            G8_Methods.Methods methods = new G8_Methods.Methods();

            //Genero innerEncryptionCode
            string validationCode = vkg.GetUniqueKey(); //codi de validació
            idInnerEncryption = "";

            DataSet dts;

            //coger id del registro, mirar si existe
            //checkIfIdExidts()
            dts = dataAccess.getByQuery("SELECT * FROM InnerEncryption WHERE idPlanet = '" + idOwnPlanet + "'", ProjectName);

            if (dts.Tables[0].Rows.Count == 0)
            {
                dts = dataAccess.getByQuery("INSERT INTO InnerEncryption(idPlanet, ValidationCode) VALUES(" + Int32.Parse(idOwnPlanet) + ", '" + validationCode + "')", ProjectName);
            } else
            {
                idInnerEncryption = dts.Tables[0].Rows[0]["idInnerEncryption"].ToString();
            }
            //Inserto innerEncriptionCode en BBDD
            //insertEncriptionCode
            dataAccess.connectToDDBB(ProjectName);
            dts = dataAccess.getByQuery("SELECT * FROM InnerEncryption WHERE idPlanet = '" + idOwnPlanet + "'", ProjectName);
            if (dts.Tables[0].Rows.Count == 0)
            {
                //NO DEJAR UTILIZAR EL BOTÓN PORQUE LA MAC NO EXISTE EN LA BASE DE DATOS
                dts = dataAccess.getByQuery("INSERT INTO InnerEncryption(idPlanet, ValidationCode) VALUES(" + Int32.Parse(idOwnPlanet) + ", '" + validationCode + "')", ProjectName);
            }
            else
            {
                //BORRAR EL REGISTRO DE LA BASE DE DATOS
                dts = dataAccess.getByQuery("DELETE FROM InnerEncryptionData WHERE IdInnerEncryption = '" + idInnerEncryption + "'", ProjectName);
                dts = dataAccess.getByQuery("DELETE FROM InnerEncryption WHERE idPlanet = '" + idOwnPlanet + "'", ProjectName);
                dts = dataAccess.getByQuery("INSERT INTO InnerEncryption(idPlanet, ValidationCode) VALUES(" + Int32.Parse(idOwnPlanet) + ", '" + validationCode + "')", ProjectName);
            }

            //coger id del nuevo registro
            dts = dataAccess.getByQuery("SELECT * FROM InnerEncryption WHERE ValidationCode = '" + validationCode + "'", ProjectName);

            if (dts.Tables[0].Rows.Count == 0)
            {
                return;
            }
            idInnerEncryption = dts.Tables[0].Rows[0]["idInnerEncryption"].ToString();

            //Generar coordenades
            Dictionary<String, String> coordenades = methods.generateDictionary();

            //Insertar coordenades en la BBDD
            dts = dataAccess.getByQuery("SELECT * FROM InnerEncryptionData WHERE IdInnerEncryption = '" + idInnerEncryption + "'", ProjectName);

            if (dts.Tables[0].Rows.Count == 0)
            {
                //NO DEJAR UTILIZAR EL BOTÓN PORQUE LA MAC NO EXISTE EN LA BASE DE DATOS
                for (int index = 0; index < coordenades.Count; index++)
                {
                    var item = coordenades.ElementAt(index);
                    string itemKey = item.Key;
                    string itemValue = item.Value;

                    dts = dataAccess.getByQuery("INSERT INTO InnerEncryptionData(IdInnerEncryption, Word, Numbers) VALUES (" + idInnerEncryption + ", '" + item.Key.ToString() + "', '" + item.Value.ToString() + "')", ProjectName);

                }
            }
            else
            {
                //BORRAR EL REGISTRO DE LA BASE DE DATOS
                dts = dataAccess.getByQuery("DELETE FROM InnerEncryptionData WHERE IdInnerEncryption = '" + idInnerEncryption + "'", ProjectName);
                for (int index = 0; index < coordenades.Count; index++)
                {
                    var item = coordenades.ElementAt(index);
                    string itemKey = item.Key;
                    string itemValue = item.Value;

                    dts = dataAccess.getByQuery("INSERT INTO InnerEncryptionData(IdInnerEncryption, Word, Numbers) VALUES (" + idInnerEncryption + ", '" + item.Key.ToString() + "', '" + item.Value.ToString() + "')", ProjectName);

                }

                idInnerEncryption = "";
                idOwnPlanet = "";
                validationCode = "";
                cbx_selectplanet.SelectedItem = "";
            }
        }

        private void btn_generarclaus_Click(object sender, EventArgs e)
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
            keyName = InnerEncryptionCode;
            cspp.KeyContainerName = keyName;
            rsa = new RSACryptoServiceProvider(cspp);
            string publicKey = rsa.ToXmlString(false);
            rsa.PersistKeyInCsp = true;
            //rsa.Clear();

            dts = dataAccess.getByQuery("SELECT * FROM PlanetKeys WHERE idPlanet = " + idOwnPlanet, ProjectName);
            if (dts.Tables[0].Rows.Count == 0)
            {
                dts = dataAccess.getByQuery("INSERT INTO PlanetKeys(idPlanet, XMLKey) VALUES(" + idOwnPlanet + ", '" + publicKey + "')", ProjectName);
            }
            else
            {
                dts = dataAccess.getByQuery("DELETE FROM PlanetKeys WHERE idPlanet = " + idOwnPlanet, ProjectName);
                dts = dataAccess.getByQuery("INSERT INTO PlanetKeys(idPlanet, XMLKey) VALUES(" + idOwnPlanet + ", '" + publicKey + "')", ProjectName);
            }
        }

        private void btn_checkERmessage_Click(object sender, EventArgs e)
        {
            string deliveryData = lbx_Missatges.Items[lbx_Missatges.Items.Count - 1].ToString();

            //string prueba = "ER00000FC-G1SPL63OHPMXXHNC";

            string messagetype = deliveryData.Substring(0,2);
            string spaceship12char = deliveryData.Substring(2, 12);
            string codeDelivery = deliveryData.Substring(14, 12);

            int substringSpaceship = 0;

            string idSpaceshipDDBB = "";


            if (spaceship12char.StartsWith("0"))
            {
                foreach (char letter in spaceship12char)
                {
                    if (letter == '0')
                    {
                        substringSpaceship++;
                    }
                }
            }

            string spaceship = spaceship12char.Substring(substringSpaceship, (spaceship12char.Length-substringSpaceship));

            DataSet dts;
            dataAccess.connectToDDBB(ProjectName);

            dts = dataAccess.getByQuery("SELECT * FROM SpaceShips WHERE CodeSpaceShip = '" + spaceship + "'", ProjectName);
            if (dts.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No Spaceships Found");
            }
            else
            {
                idSpaceshipDDBB = dts.Tables[0].Rows[0]["idSpaceShip"].ToString();
            }

            dts = dataAccess.getByQuery("SELECT * FROM DeliveryData WHERE idPlanet = " + idOwnPlanet + " AND CodeDelivery = '" + codeDelivery + "' AND idSpaceShip = " + Int32.Parse(idSpaceshipDDBB), ProjectName);
            if (dts.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No deliveries Found");
            }
            else
            {
                MessageBox.Show("OK");
            }
        }

        private void btn_checkvalidationCodes_Click(object sender, EventArgs e)
        {
            DataSet dts;
            dataAccess.connectToDDBB(ProjectName);
            dts = dataAccess.getByQuery("SELECT * FROM InnerEncryption WHERE idPlanet = '" + idOwnPlanet + "'", ProjectName);

            if (dts.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No codes found. Please generate codes.");
            }
            else
            {
                MessageBox.Show("Codes found.");
            }

            dts = dataAccess.getByQuery("SELECT * FROM InnerEncryption WHERE idPlanet = '" + idOwnPlanet + "'", ProjectName);

            if (dts.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No InnerEncryption code found. Please generate code.");
            }
            else
            {
                idInnerEncryption = dts.Tables[0].Rows[0]["idInnerEncryption"].ToString();
            }
        }

        private void btn_checkpublickey_Click(object sender, EventArgs e)
        {
            //TODO IF NOT IN LINE 153:
            //RECIEVE ENCRYPTED STRING, DECRYPT AND CHECK IF IT'S THE SAME PLANETKEY

            G8_Methods.Methods mt = new G8_Methods.Methods();
            byte[] encryptedText = Encoding.ASCII.GetBytes(tbx_rawdata.Text);
            byte[] decryptedData;
            //convertir array de bytes en string

            decryptedData = rsa.Decrypt(encryptedData, false);

            textBox1.Text = ByteConverter.GetString(decryptedData);
        }

        private void btn_createfiles_Click(object sender, EventArgs e)
        {
            G8_Methods.FileCheck fc = new G8_Methods.FileCheck();

            string doc1 = "", doc2 = "", doc3 = "";

            //Genero letras al azar

            doc1 = fc.generarLetras(doc1);
            doc2 = fc.generarLetras(doc2);
            doc3 = fc.generarLetras(doc3);
            docSuma = doc1 + doc2 + doc3;

            MessageBox.Show("Documentos generados");

            fc.generarArchivos(doc1, "PACS1", defaultPath + "\\generatedDocs\\PACS1-LLETRES.txt");
            fc.generarArchivos(doc2, "PACS2", defaultPath + "\\generatedDocs\\PACS2-LLETRES.txt");
            fc.generarArchivos(doc3, "PACS3", defaultPath + "\\generatedDocs\\PACS3-LLETRES.txt");

            //Paso letras a números
            doc1 = fc.traducirArchivos(doc1, ProjectName, idInnerEncryption);
            doc2 = fc.traducirArchivos(doc2, ProjectName, idInnerEncryption);
            doc3 = fc.traducirArchivos(doc3, ProjectName, idInnerEncryption);
            MessageBox.Show("Documentos traducidos");

            //Genero archivos a partir de las strings de números
            fc.generarArchivos(doc1, "PACS1", defaultPath + "\\PACS1.txt");
            fc.generarArchivos(doc2, "PACS2", defaultPath + "\\PACS2.txt");
            fc.generarArchivos(doc3, "PACS3", defaultPath + "\\PACS3.txt");

            //Creo zip //Descomprimo en \extractedDocs
            fc.zippearArchivos(defaultPath, defaultPath + "\\PACS.zip");
            fc.desZippearArchivos(defaultPath + "\\PACS.zip", defaultPath + "\\extractedDocs");

            MessageBox.Show("Documents guardats");

        }

        private void btn_checkfiles_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deleting...");
            System.IO.DirectoryInfo di = new DirectoryInfo(defaultPath);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }

            System.IO.DirectoryInfo diExtracted = new DirectoryInfo(defaultPath+"\\extractedDocs");
            foreach (FileInfo file in diExtracted.GetFiles())
            {
                file.Delete();
            }

            System.IO.DirectoryInfo diGenerated = new DirectoryInfo(defaultPath + "\\generatedDocs");
            foreach (FileInfo file in diExtracted.GetFiles())
            {
                file.Delete();
            }
        }

        private void btn_checkPACSSOL_Click(object sender, EventArgs e)
        {
            G8_Methods.FileCheck fc = new G8_Methods.FileCheck();

            string doc1 = "", doc2 = "", doc3 = "";

            fc.desZippearArchivos(defaultPath + "\\PACSSOL.zip", defaultPath + "\\extractedDocs");

            string pacssol = File.ReadAllText(defaultPath + "\\extractedDocs\\PACSSOL.txt");

            doc1 = File.ReadAllText(defaultPath + "\\generatedDocs\\PACS1-LLETRES.txt");
            doc2 = File.ReadAllText(defaultPath + "\\generatedDocs\\PACS2-LLETRES.txt");
            doc3 = File.ReadAllText(defaultPath + "\\generatedDocs\\PACS3-LLETRES.txt");

            string pacsSolstring = doc1 + doc2 + doc3;

            if (pacssol.Equals(pacsSolstring))
            {
                MessageBox.Show(":D");
            } else
            {
                MessageBox.Show(":(");
            }
        }

        //pruebas
        public void RecibirArchivos()
        {
            bool ZipFileExists = false;

            string[] ExistingFiles;

            TcpListener Listener = null;

            try
            {
                Listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
                Listener.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            byte[] RecData = new byte[BufferSize];
            int RecBytes;

            //Loop infinito (while)

            for (; ; )
            {
                TcpClient Archivos = null;
                NetworkStream netstream = null;
                Status = string.Empty;
                try
                {
                    string message = "Desea aceptar y recibir los archivos del planeta correspondiente?";
                    string caption = "Petición de inserción de archivos";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    if (Listener.Pending())
                    {
                        Archivos = Listener.AcceptTcpClient();
                        netstream = Archivos.GetStream();
                        Status = "Connected to a client\n";
                        result = MessageBox.Show(message, caption, buttons);
                        string path = defaultPath + "\\PACSSOL.txt";

                        if (result == DialogResult.Yes)
                        {
                            int totalrecbytes = 0;
                            FileStream Fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

                            while ((RecBytes = netstream.Read(RecData, 0, RecData.Length)) > 0)
                            {
                                Fs.Write(RecData, 0, RecBytes);
                                totalrecbytes += RecBytes;
                            }
                            Fs.Close();

                            netstream.Close();
                            Archivos.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        public void conectarServer()
        {
            try
            {
                Listener = new TcpListener(IPAddress.Any, 8080);
                Listener.Start();

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

                        if (data.StartsWith("ER"))
                        {
                            lbx_Missatges.Items.Add(data);
                            MessageBox.Show("Please check Entry Requirement");
                            boolForEncrypt = false;
                        }
                        else if (data.StartsWith("VK"))
                        {
                            lbx_Missatges.Items.Add(data);
                            boolForEncrypt = true;
                        }
                        else if (boolForEncrypt)
                        {
                            //MessageBox.Show("Please check Decryption");
                            encryptedData = buffer;

                            //Recieve string
                            boolForEncrypt = false;
                            
                            tbx_rawdata.Text = data;


                        }
                        else
                        {
                            //recieve files
                            boolForEncrypt = false;
                            RecibirArchivos();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void closeServer()
        {
            IsConnected = false;
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
    }
}
