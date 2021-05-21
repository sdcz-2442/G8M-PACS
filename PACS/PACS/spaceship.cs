using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G8_DataAccess;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Net.NetworkInformation;
using System.IO;
using System.Collections;
using System.Security.Cryptography;
using Planet;

namespace PACS
{
    public partial class spaceship : Form
    {
        public string ProjectName = "PACS";
        G8_DataAccess.DataAccess dataAccess = new G8_DataAccess.DataAccess();
        RSACryptoServiceProvider rsaEnc = new RSACryptoServiceProvider();

        string defaultPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\PACS\\bin\\Debug\\_docs";

        Thread checkNetwork;
        Boolean IsConnected;
        Thread comprobarConexion;
        TcpClient client;
        TcpListener Listener = null;
        NetworkStream ns;

        private ArrayList nSockets;
        public string spaceshipIdSelected;
        public string spaceshipIP;
        public string spaceshipPort1;
        public string spaceshipPort2;
        public string codeSpaceship;

        public string idPlanet;
        public string namePlanet;
        public string planetValidationCode;
        public string planetIdInnerEncryption;

        public byte[] encryptedArray;
        public string encryptedArrayString;
        public byte[] encryptedData = new byte[128];

        public bool boolForFiles;
        private const int BufferSize = 1024;
        public string Status = string.Empty;
        public Thread T = null;

        public spaceship()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void spaceship_Load(object sender, EventArgs e)
        {
            lbl_spaceshipname.Text = codeSpaceship;

            DataSet dts;

            dataAccess.connectToDDBB(ProjectName);
            dts = dataAccess.getByQuery("SELECT * FROM Planets ORDER BY DescPlanet ASC", "Planets", ProjectName);
            cbx_selectplanet.DisplayMember = "DescPlanet";
            cbx_selectplanet.ValueMember = "idPlanet";
            cbx_selectplanet.DataSource = dts.Tables["Planets"];

            dts = dataAccess.getByQuery("SELECT * FROM DeliveryData ORDER BY CodeDelivery ASC", "DeliveryData", ProjectName);
            cbx_codedelivery.DisplayMember = "CodeDelivery";
            cbx_codedelivery.ValueMember = "idDeliveryData";
            cbx_codedelivery.DataSource = dts.Tables["DeliveryData"];

            dts = dataAccess.getByQuery("SELECT * FROM DeliveryData ORDER BY CodeDelivery ASC", "DeliveryData", ProjectName);
            cbx_deliverydate.DisplayMember = "DeliveryDate";
            cbx_deliverydate.ValueMember = "idDeliveryData";
            cbx_deliverydate.DataSource = dts.Tables["DeliveryData"];

            //borrar archivos guardados
            //MessageBox.Show("Deleting...");
            //System.IO.DirectoryInfo di = new DirectoryInfo(defaultPath);

            //foreach (FileInfo file in di.GetFiles())
            //{
            //    file.Delete();
            //}

            //System.IO.DirectoryInfo diex = new DirectoryInfo(defaultPath + "\\extractedDocs");

            //foreach (FileInfo file in di.GetFiles())
            //{
            //    file.Delete();
            //}
        }

        private void btn_networkrequest_Click(object sender, EventArgs e)
        {
            checkNetwork = new Thread(ComprobarRed);
            checkNetwork.Start();
        }

        public void ComprobarRed()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            lbx_console.Items.Clear();

            bool networkStatus = false;
            int pingCount = 0;
            string ipPing = tbx_ipplanet.Text; //get ping from planet

            try
            {
                if (String.IsNullOrEmpty(tbx_ipplanet.Text))
                {
                    MessageBox.Show("Error: please insert ping");
                    if (checkNetwork.IsAlive)
                    {
                        tbx_ipplanet.Enabled = true;
                        tbx_port.Enabled = true;
                        lbl_networkstatus.Visible = false;
                    }
                }
                else
                {

                    NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

                    lbl_networkstatus.Text = "Pending";

                    foreach (NetworkInterface adapter in nics)
                    {
                        //si las redes son válidas
                        if ((adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet || adapter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211) && adapter.OperationalStatus == OperationalStatus.Up)
                        {
                            networkStatus = true;
                        }
                    }

                    for (int i = 1; i <= 10; i++)
                    {
                        Ping myPing = new Ping();
                        PingReply reply = myPing.Send(ipPing, 1000);

                        if (reply != null)
                        {

                            lbx_console.Items.Add("Ping number " + i + ": " + reply.Status);
                            if (reply.Status == IPStatus.Success)
                            {
                                pingCount++;
                            }
                        }
                        Thread.Sleep(100); //Debe ser 2000 cada dos secs
                    }

                    if (!networkStatus)
                    {
                        lbl_networkstatus.Text = "KO";
                        tbx_port.Enabled = true;
                        tbx_ipplanet.Enabled = true;
                    }
                    else if (pingCount < 5)
                    {

                        lbl_networkstatus.Text = "Waiting...";
                        tbx_ipplanet.Enabled = true;
                        tbx_port.Enabled = true;
                    }
                    else
                    {
                        lbl_networkstatus.Text = "OK";
                        tbx_port.Enabled = true;
                        tbx_ipplanet.Enabled = true;
                    }

                }
            }
            catch (System.Threading.ThreadStateException)
            {
                MessageBox.Show("Error");
            }
        }

        private void btn_sendmessage_Click(object sender, EventArgs e)
        {
            string messagetype = cbx_messages.Text;
            string spaceshipCode = codeSpaceship;
            int codeSpaceshiplength = codeSpaceship.Length;
            string adding = "0";

            int howManyZeros = 12 - codeSpaceship.Length;

            while (howManyZeros != 0)
            {
                spaceshipCode = spaceshipCode.Insert(0, "0");
                howManyZeros--;
            }

            string messageToPlanet = "";

            if (messagetype.Contains("ER"))
            {

                messageToPlanet = "ER" + spaceshipCode + cbx_codedelivery.Text;

            } else if (messagetype.Contains("VK"))
            {
                messageToPlanet = "VK" + spaceshipCode + cbx_codedelivery.Text; ;
            } else
            {
                messageToPlanet = "Files";
            }

            try
            {
                TcpClient client = new TcpClient(tbx_ipplanet.Text, 8080);

                if (cbx_messages.Text == "")
                {
                    MessageBox.Show("Introducir mensaje");
                }
                else if (messageToPlanet.Contains("VK"))
                {
                    Byte[] dades = Encoding.ASCII.GetBytes(messageToPlanet);
                    NetworkStream ns = client.GetStream();
                    ns.Write(dades, 0, dades.Length);
                } else
                {
                Byte[] dades = Encoding.ASCII.GetBytes(messageToPlanet);
                NetworkStream ns = client.GetStream();
                ns.Write(dades, 0, dades.Length);
                }
            }
            catch
            {
                MessageBox.Show("Servidor inaccesible");
            }
        }
        private void btn_sendfiles_Click(object sender, EventArgs e)
        {
            string fileName;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.ShowDialog();
                fileName = openFileDialog.FileName;
            }

            Stream fileStream = File.OpenRead(fileName);
            // Alocate memory space for the file
            byte[] fileBuffer = new byte[fileStream.Length];
            fileStream.Read(fileBuffer, 0, (int)fileStream.Length);
            // Open a TCP/IP Connection and send the data
            TcpClient clientSocket = new TcpClient(tbx_ipplanet.Text, 8080);
            NetworkStream networkStream = clientSocket.GetStream();
            networkStream.Write(fileBuffer, 0, fileBuffer.GetLength(0));
            networkStream.Close();

            lbl_events.Items.Add("File send");
        }
        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (!IsConnected)
            {
                comprobarConexion = new Thread(conectarServer);
                comprobarConexion.Start();
                IsConnected = true;
            }
        }
        private void btn_encryptpublickey_Click(object sender, EventArgs e)
        {
            DataSet dts;

            dataAccess.connectToDDBB(ProjectName);

            dts = dataAccess.getByQuery("SELECT * FROM Planets WHERE DescPlanet = '" + cbx_selectplanet.Text + "'", ProjectName);

            idPlanet = dts.Tables[0].Rows[0]["idPlanet"].ToString();
            namePlanet = dts.Tables[0].Rows[0]["DescPlanet"].ToString();

            //Bajar código de validación del planeta destino
            dts = dataAccess.getByQuery("SELECT * FROM InnerEncryption WHERE idPlanet = '" + idPlanet + "'", ProjectName);

            planetValidationCode = dts.Tables[0].Rows[0]["ValidationCode"].ToString();
            planetIdInnerEncryption = dts.Tables[0].Rows[0]["idInnerEncryption"].ToString();

            dts = dataAccess.getByQuery("SELECT * FROM PlanetKeys WHERE idPlanet = '" + idPlanet + "'", ProjectName);

            string publicKey = dts.Tables[0].Rows[0]["XMLKey"].ToString();

            G8_Methods.Methods enc = new G8_Methods.Methods();

            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes(planetValidationCode);

            byte[] decryptedData;

            encryptedData = Encryption(dataToEncrypt, rsaEnc.ExportParameters(false), false);

            //textcryptosend = encryptedData;
            //encryptedArrayString = ByteConverter.GetString(encryptedData);

            MessageBox.Show("Validation Key successful. Send Validation Key Message");
        }
        static public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        private void btn_decomp_Click(object sender, EventArgs e)
        {
            G8_Methods.FileCheck fc = new G8_Methods.FileCheck();

            string doc1 = "", doc2 = "", doc3 = "";
            //planetIdInnerEncryption = "1092";

            //Descomprimo archivos
            fc.desZippearArchivos(defaultPath + "\\PACS.zip", defaultPath + "\\extractedDocs");

            ////Paso archivos a string
            //System.IO.DirectoryInfo di = new DirectoryInfo(defaultPath);

            doc1 = File.ReadAllText(defaultPath + "\\extractedDocs\\PACS1.txt");
            doc2 = File.ReadAllText(defaultPath + "\\extractedDocs\\PACS2.txt");
            doc3 = File.ReadAllText(defaultPath + "\\extractedDocs\\PACS3.txt");

            ////Paso números a letras
            doc1 = fc.desTraducirArchivos(doc1, planetIdInnerEncryption, ProjectName);
            doc2 = fc.desTraducirArchivos(doc2, planetIdInnerEncryption, ProjectName);
            doc3 = fc.desTraducirArchivos(doc3, planetIdInnerEncryption, ProjectName);
            lbl_events.Items.Add("Documentos traducidos");

            //Genero un nuevo archivo con las tres strings.
            fc.generarArchivos(doc1, "PACS1", defaultPath + "\\extractedDocs\\PACS1-decoded.txt");
            fc.generarArchivos(doc2, "PACS2", defaultPath + "\\extractedDocs\\PACS2-decoded.txt");
            fc.generarArchivos(doc3, "PACS3", defaultPath + "\\extractedDocs\\PACS3-decoded.txt");

            string pacsSolstring = doc1 + doc2 + doc3;

            fc.generarArchivos(pacsSolstring, "PACSSOL", defaultPath + "\\PACSSOL\\PACSSOL.txt");

            fc.zippearArchivoPACSSOL(defaultPath + "\\PACSSOL", defaultPath + "\\PACSSOL");

            lbl_events.Items.Add("PACCSOL created");
        }
        private void btn_sendvalidationcode_Click(object sender, EventArgs e)
        {
            string messagetype = cbx_messages.Text;
            string spaceshipCode = codeSpaceship;
            int codeSpaceshiplength = codeSpaceship.Length;
            DataSet dts;

            dataAccess.connectToDDBB(ProjectName);

            dts = dataAccess.getByQuery("SELECT * FROM Planets WHERE DescPlanet = '" + cbx_selectplanet.Text + "'", ProjectName);

            idPlanet = dts.Tables[0].Rows[0]["idPlanet"].ToString();
            namePlanet = dts.Tables[0].Rows[0]["DescPlanet"].ToString();

            //Bajar código de validación del planeta destino
            dts = dataAccess.getByQuery("SELECT * FROM InnerEncryption WHERE idPlanet = '" + idPlanet + "'", ProjectName);

            planetValidationCode = dts.Tables[0].Rows[0]["ValidationCode"].ToString();
            planetIdInnerEncryption = dts.Tables[0].Rows[0]["idInnerEncryption"].ToString();

            dts = dataAccess.getByQuery("SELECT * FROM PlanetKeys WHERE idPlanet = '" + idPlanet + "'", ProjectName);

            string publicKey = dts.Tables[0].Rows[0]["XMLKey"].ToString();

            rsaEnc.FromXmlString(publicKey);

            G8_Methods.Methods enc = new G8_Methods.Methods();

            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes(planetValidationCode);

            encryptedData = rsaEnc.Encrypt(dataToEncrypt, false);

            //textcryptosend = encryptedData;
            encryptedArrayString = ByteConverter.GetString(encryptedData);

            try
            {
                TcpClient client = new TcpClient(tbx_ipplanet.Text, 8080);
                //Byte[] dades = Encoding.ASCII.GetBytes(System.Text.Encoding.UTF8.GetString(encryptedData).ToCharArray());
                NetworkStream ns = client.GetStream();
                ns.Write(encryptedData, 0, encryptedData.Length);
            }
            catch
            {
                MessageBox.Show("Servidor inaccesible");
            }
        }
        public void conectarServer()
        {
            try
            {
                Listener = new TcpListener(IPAddress.Any, 4000);
                Listener.Start();

                while (IsConnected)
                {
                    if (Listener.Pending())
                    {
                        client = Listener.AcceptTcpClient();
                        ns = client.GetStream();
                        byte[] buffer = new byte[1024];
                        byte[] encryptionbuffer = new byte[128];

                        if (boolForFiles)
                        {
                            
                            RecieveFiles(boolForFiles);
                            boolForFiles = false;
                        }
                        {
                            string data = "";
                            ns.Read(buffer, 0, buffer.Length);

                            data = Encoding.ASCII.GetString(buffer, 0, buffer.Length);

                            if (data.StartsWith("VR"))
                            {
                                lbl_events.Items.Add(data);
                                if (data.Contains("VP"))
                                {
                                    lbl_events.Items.Add("Validation in Progress");
                                }
                                else if (data.Contains("AD"))
                                {
                                    lbl_events.Items.Add("Acces Denied");
                                } else if (data.Contains("AG"))
                                {
                                    lbl_events.Items.Add("Acces Granted");
                                }
                                boolForFiles = false;
                            }
                            else
                            {
                                lbl_events.Items.Add("Files coming");
                                boolForFiles = true;
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //MÉTODOS Y FUNCIONES 
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
        public void RecieveFiles(bool boolForfiles)
        {

            if (boolForfiles == false)
            {
                return;
            } else
            {
                bool ZipFileExists = false;

                string[] ExistingFiles;

                TcpListener Listener = null;

                try
                {
                    Listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 4000);
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
                        string message = "¿Desea aceptar y recibir los archivos del planeta?";
                        string caption = "Warning";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;

                        if (Listener.Pending())
                        {
                            Archivos = Listener.AcceptTcpClient();
                            netstream = Archivos.GetStream();
                            Status = "Connected to a client\n";
                            result = MessageBox.Show(message, caption, buttons);
                            string path = defaultPath + "\\PACS.zip";

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
                                boolForFiles = false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
    }
}
