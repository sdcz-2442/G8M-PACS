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

        private ArrayList nSockets;
        //spaship values
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
        public byte[] encryptedData;

        public spaceship()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void spaceship_Load(object sender, EventArgs e)
        {
            //frm_selectStarship selection = new frm_selectStarship();

            //spaceshipIdSelected = selection.spaceshipIdSelected;
            //spaceshipIP = selection.spaceshipIP;
            //spaceshipPort1 = selection.spaceshipPort1;
            //spaceshipPort2 = selection.spaceshipPort2;
            //codeSpaceship = selection.codeSpaceShip;

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
            //btn_sendping.Enabled = false;
            //tbx_ipplanet.Enabled = false;
            //lbl_networkstatus.Visible = true;
            //cbx_messages.Enabled = false;
            //btn_sendmessages.Enabled = false;
            //tbx_port.Enabled = false;
            //btn_sendmessages.Enabled = false;
            //cbx_messages.Enabled = false;

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
                        //cbx_messages.Enabled = true;
                        //btn_sendmessages.Enabled = true;
                        //btn_sendping.Enabled = true;
                        //btn_sendmessages.Enabled = true;
                        //cbx_messages.Enabled = true;
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
                        //cbx_messages.Enabled = true;
                        //btn_sendmessages.Enabled = true;
                        //btn_sendmessages.Enabled = false;
                        //cbx_messages.Enabled = false;
                        //btn_sendping.Enabled = true;
                    }
                    else if (pingCount < 5)
                    {

                        lbl_networkstatus.Text = "Waiting...";
                        tbx_ipplanet.Enabled = true;
                        tbx_port.Enabled = true;
                        //btn_sendmessages.Enabled = false;
                        //cbx_messages.Enabled = false;
                        //btn_sendping.Enabled = true;
                        //cbx_messages.Enabled = true;
                        //btn_sendmessages.Enabled = true;
                    }
                    else
                    {
                        lbl_networkstatus.Text = "OK";
                        tbx_port.Enabled = true;
                        tbx_ipplanet.Enabled = true;
                        //btn_sendping.Enabled = true;
                        //cbx_messages.Enabled = true;
                        //btn_sendmessages.Enabled = true;
                        //btn_sendmessages.Enabled = true;
                        //cbx_messages.Enabled = true;
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
                messageToPlanet = "VK" + encryptedArrayString;
            } else
            {
                messageToPlanet = "Others";
            }

            //MIRAR QUE ESTE PUERTO SEA DE LA BBDD O DE DONDE SEA??
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
                    
                    //envio cadena
                    //dades = encryptedArray;
                    //ns = client.GetStream();
                    //ns.Write(dades, 0, dades.Length);
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
            TcpClient clientSocket = new TcpClient(tbx_ipplanet.Text, Int32.Parse(tbx_port.Text));
            NetworkStream networkStream = clientSocket.GetStream();
            networkStream.Write(fileBuffer, 0, fileBuffer.GetLength(0));
            networkStream.Close();

            MessageBox.Show("File Send");
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            recieve_Load();
        }

        private void recieve_Load()
        {
            IPHostEntry IPHost = Dns.GetHostByName(Dns.GetHostName());
            //lblStatus.Text = "My IP address is " + IPHost.AddressList[0].ToString();
            nSockets = new ArrayList();
            Thread thdListener = new Thread(new ThreadStart(listenerThread));
            thdListener.Start();
        }

        public void listenerThread()
        {
            //TODO ESCUCHAR PUERTO ESCRITO EN LA BBDD
            try
            {
                TcpListener tcpListener = new TcpListener(4000);
                tcpListener.Start();
                while (true)
                {
                    Socket handlerSocket = tcpListener.AcceptSocket();
                    if (handlerSocket.Connected)
                    {
                        lbl_events.Items.Add(

                        handlerSocket.RemoteEndPoint.ToString() + " connected.");
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
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void handlerThread()
        {
            Socket handlerSocket = (Socket)nSockets[nSockets.Count - 1];
            NetworkStream networkStream = new NetworkStream(handlerSocket);
            int thisRead = 0;
            int blockSize = 1024;
            Byte[] dataByte = new Byte[blockSize];
            string data = "";

            try
            {
                lock (this)
                {
                    // Only one process can access
                    // the same file at any given time
                    Stream fileStream = File.OpenWrite(defaultPath + "\\PACS.zip");

                    while (true)
                    {
                        thisRead = networkStream.Read(dataByte, 0, blockSize);
                        data = Encoding.ASCII.GetString(dataByte, 0, dataByte.Length);

                        if (data.StartsWith("VR"))
                        {
                            //do stuff
                            lbl_events.Items.Add(data);
                            if (data.Contains("VP"))
                            {
                                MessageBox.Show("Validation in Progress");
                            }
                            else if (data.Contains("AD"))
                            {
                                MessageBox.Show("Acces Denied");
                            }
                        }
                        else
                        {
                            //fileStream.Write(dataByte, 0, thisRead);
                            lbl_events.Items.Add("File Written...");
                            //if (thisRead == 0) break;
                            //fileStream.Close();
                        }

                        fileStream.Write(dataByte, 0, thisRead);
                        if (thisRead == 0) break;
                    }
                    fileStream.Close();
                }
                lbl_events.Items.Add("File Written");
                handlerSocket = null;
            } catch (Exception ex)
            {
                return;
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

            encryptedData = rsaEnc.Encrypt(dataToEncrypt, false);

            //textcryptosend = encryptedData;
            encryptedArrayString = ByteConverter.GetString(encryptedData);


        //    UnicodeEncoding ByteConverter = new UnicodeEncoding();
        //    byte[] plaintext;
        //    byte[] encryptedtext;


        //plaintext = ByteConverter.GetBytes(planetValidationCode);
        //    encryptedtext = enc.Encryption(plaintext, rsaEnc.ExportParameters(false), false);
        //    encryptedArray = encryptedtext;

        //    //Planet.planet() = new Planet.planet();
        //    Planet.planet planet = planet();

        //    planet.rawData = encryptedArray;

        //    //ByteConverter.GetString(encryptedtext);        
        //    //MessageBox.Show(ByteConverter.GetString(encryptedtext));
            MessageBox.Show("Validation Key successful. Send Validation Key Message");
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
            MessageBox.Show("Documentos traducidos");

            //Genero un nuevo archivo con las tres strings.
            fc.generarArchivos(doc1, "PACS1", defaultPath + "\\extractedDocs\\PACS1-decoded.txt");
            fc.generarArchivos(doc2, "PACS2", defaultPath + "\\extractedDocs\\PACS2-decoded.txt");
            fc.generarArchivos(doc3, "PACS3", defaultPath + "\\extractedDocs\\PACS3-decoded.txt");

            string pacsSolstring = doc1 + doc2 + doc3;

            fc.generarArchivos(pacsSolstring, "PACSSOL", defaultPath + "\\PACSSOL\\PACSSOL.txt");

            fc.zippearArchivoPACSSOL(defaultPath + "\\PACSSOL", defaultPath + "\\PACSSOL");
        }

        private void btn_sendvalidationcode_Click(object sender, EventArgs e)
        {
            string messagetype = cbx_messages.Text;
            string spaceshipCode = codeSpaceship;
            int codeSpaceshiplength = codeSpaceship.Length;

            //MIRAR QUE ESTE PUERTO SEA DE LA BBDD O DE DONDE SEA??
            try
            {
                TcpClient client = new TcpClient(tbx_ipplanet.Text, 8080);
                Byte[] dades = Encoding.ASCII.GetBytes(System.Text.Encoding.UTF8.GetString(encryptedData).ToCharArray());
                NetworkStream ns = client.GetStream();
                ns.Write(dades, 0, dades.Length);
            }
            catch
            {
                MessageBox.Show("Servidor inaccesible");
            }
        }
    }
}
