using G8_Planet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using G8_DataAccess;
using PACS_starship;
using System.Net.Sockets;
using System.Net;

namespace G8_Starship
{
    public partial class frm_spaceship : Form
    {

        public string spaceshipCode = "FC-G1SP";
        public int spaceshipId = 4;
        public string spaceshipIP = "";
        public string spaceshipPort1 = "";
        public string spaceshipPort2 = "";


        private bool mouseDown;
        private Point lastLocation;
        public string ProjectName = "PACS_starship";
        string xmlPath = @"C:\TCP-pruebas\TCPSettings.xml";

        Thread checkNetwork;

        G8_DataAccess.DataAccess dataAccess = new G8_DataAccess.DataAccess();
        UnicodeEncoding ByteConverter = new UnicodeEncoding();

        string fileName = "";
        string filePath = @"C:\";
        string fileContent = "";

        public static string encryptedMessage;
        public static byte[] encryptedArray;
        public string namePlanetDelivery;
        public string idPlanetDelivery;
        public string idOwnSpaceship;

        RSACryptoServiceProvider rsaEnc = new RSACryptoServiceProvider();
        RSACryptoServiceProvider Rsaencrypt = new RSACryptoServiceProvider();

        byte[] encryptedText;

        /// <summary>
        /// /
        /// 
        /// 
        /// </summary>
        /// 

        public string ipMissatge = "192.168.1.1";

        string docSuma = "";

        RSACryptoServiceProvider rsa;
        Thread comprobarConexion;
        Boolean IsConnected;
        TcpClient client;
        TcpListener Listener = null;
        NetworkStream ns;

        public frm_spaceship()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void frm_spaceship_Load(object sender, EventArgs e)
        {
            lbl_networkstatus.Visible = false;
            tbx_pubkey.Enabled = false;

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

        }

        private void close_click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_click_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximize_click_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            } else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void topbar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void topbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void topbar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        private void btn_sendping_Click(object sender, EventArgs e)
        {
            checkNetwork = new Thread(ComprobarRed);
            checkNetwork.Start();
        }

        public void ComprobarRed()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            lbx_console.Items.Clear();
            btn_sendping.Enabled = false;
            tbx_ipplanet.Enabled = false;
            lbl_networkstatus.Visible = true;
            cbx_messages.Enabled = false;
            btn_sendmessages.Enabled = false;
            tbx_port.Enabled = false;
            btn_sendmessages.Enabled = false;
            cbx_messages.Enabled = false;

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
                        btn_sendping.Enabled = true;
                        tbx_ipplanet.Enabled = true;
                        lbl_networkstatus.Visible = false;
                        cbx_messages.Enabled = true;
                        btn_sendmessages.Enabled = true;
                        tbx_port.Enabled = true;
                        btn_sendmessages.Enabled = true;
                        cbx_messages.Enabled = true;
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
                        Thread.Sleep(2000);
                    }

                    if (!networkStatus)
                    {
                        lbl_networkstatus.Text = "KO";
                        btn_sendping.Enabled = true;
                        tbx_ipplanet.Enabled = true;
                        cbx_messages.Enabled = true;
                        btn_sendmessages.Enabled = true;
                        tbx_port.Enabled = true;
                        btn_sendmessages.Enabled = false;
                        cbx_messages.Enabled = false;
                    }
                    else if (pingCount < 5)
                    {

                        lbl_networkstatus.Text = "Waiting...";
                        btn_sendping.Enabled = true;
                        tbx_ipplanet.Enabled = true;
                        cbx_messages.Enabled = true;
                        btn_sendmessages.Enabled = true;
                        tbx_port.Enabled = true;
                        btn_sendmessages.Enabled = false;
                        cbx_messages.Enabled = false;
                    }
                    else
                    {
                        lbl_networkstatus.Text = "OK";
                        btn_sendping.Enabled = true;
                        tbx_ipplanet.Enabled = true;
                        cbx_messages.Enabled = true;
                        btn_sendmessages.Enabled = true;
                        tbx_port.Enabled = true;
                        btn_sendmessages.Enabled = true;
                        cbx_messages.Enabled = true;
                    }

                }
            } catch (System.Threading.ThreadStateException)
            {
                MessageBox.Show("Error2");
            }
        }

        private void btn_sendmessages_Click(object sender, EventArgs e)
        {
            //TODO: TIPOS DE MENSAJES
            string messagetype = cbx_messages.Text; //seleccion de la combobox???


            try
            {
                TcpClient client = new TcpClient(tbx_ipplanet.Text, Convert.ToInt32(tbx_port.Text));
                //if (txb_message.Text == "")
                //{
                //    MessageBox.Show("Introducir mensaje");
                //}
                //else
                //{
                    Byte[] dades = Encoding.ASCII.GetBytes("Prueba");
                    NetworkStream ns = client.GetStream();
                    ns.Write(dades, 0, dades.Length);
                //}
            }
            catch
            {
                MessageBox.Show("Servidor inaccesible");
            }

            //try
            //{
            //    TcpClient client = new TcpClient(tbx_ipplanet.Text, 4000);
            //    if (messagetype == "")
            //    {
            //        MessageBox.Show("El missatge no ha de estar buit");
            //    }
            //    else
            //    {

            //        if (messagetype == "ER - Entry Requirement") //PONER TIPO DE MENSAJE QUE ENVÍA NAVE A PLANETA, OBTIENE CLAVES ETC
            //        {
            //            //Select planet
            //            string entryRequirementMessage = "ER" + spaceshipCode;

            //            DataSet dts;

            //            //Selecciono planeta
            //            namePlanetDelivery = cbx_selectplanet.Text;

            //            dataAccess.connectToDDBB(ProjectName);
            //            dts = dataAccess.getByQuery("SELECT * FROM Planets WHERE DescPlanet = '" + namePlanetDelivery + "'", "Planets", ProjectName);

            //            if (dts.Tables[0].Rows.Count == 0)
            //            {
            //                return;
            //            }
            //            idPlanetDelivery = dts.Tables[0].Rows[0]["idPlanet"].ToString();

            //            //Selecciono delivery SELECT * FROM DeliveryData WHERE idSpaceShip = 4 AND idPlanet = 1
            //            dts = dataAccess.getByQuery("SELECT * FROM DeliveryData WHERE idSpaceShip = " + spaceshipId + " AND idPlanet = " + idPlanetDelivery, "Planets", ProjectName);

            //            if (dts.Tables[0].Rows.Count == 0)
            //            {
            //                return;
            //            }
            //            idPlanetDelivery = dts.Tables[0].Rows[0]["idPlanet"].ToString();

            //            Byte[] dades = Encoding.ASCII.GetBytes("Prueba");
            //            NetworkStream ns = client.GetStream();
            //            ns.Write(dades, 0, dades.Length);

            //            MessageBox.Show("asfasd");
            //        }
            //        else if (messagetype == "VK - Validation Key")
            //        {


            //        }
            //        else
            //        {
            //            MessageBox.Show("Error");
            //        }
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Servidor no accessible");
            //}



            //if (messagetype == "ER - Entry Requirement") //PONER TIPO DE MENSAJE QUE ENVÍA NAVE A PLANETA, OBTIENE CLAVES ETC
            //{
            //    //Select planet
            //    string entryRequirementMessage = "ER" + spaceshipCode;

            //    DataSet dts;

            //    //Selecciono planeta
            //    namePlanetDelivery = cbx_selectplanet.Text;

            //    dataAccess.connectToDDBB(ProjectName);
            //    dts = dataAccess.getByQuery("SELECT * FROM Planets WHERE DescPlanet = '" + namePlanetDelivery + "'", "Planets", ProjectName);

            //    if (dts.Tables[0].Rows.Count == 0)
            //    {
            //        return;
            //    }
            //    idPlanetDelivery = dts.Tables[0].Rows[0]["idPlanet"].ToString();

            //    //Selecciono delivery SELECT * FROM DeliveryData WHERE idSpaceShip = 4 AND idPlanet = 1
            //    dts = dataAccess.getByQuery("SELECT * FROM DeliveryData WHERE idSpaceShip = " + spaceshipId + " AND idPlanet = "+idPlanetDelivery, "Planets", ProjectName);

            //    if (dts.Tables[0].Rows.Count == 0)
            //    {
            //        return;
            //    }
            //    idPlanetDelivery = dts.Tables[0].Rows[0]["idPlanet"].ToString();

            //    //SELECT * FROM DeliveryData WHERE idSpaceShip = 4 AND idPlanet = 1


            //    //DataSet dts;

            //    //dataAccess.connectToDDBB(ProjectName);
            //    //dts = dataAccess.getByQuery("SELECT * FROM Planets ORDER BY DescPlanet ASC", "Planets", ProjectName);
            //    //cbx_selectplanet.DisplayMember = "DescPlanet";
            //    //cbx_selectplanet.ValueMember = "idPlanet";
            //    //cbx_selectplanet.DataSource = dts.Tables["Planets"];

            //    //codeOwnPlanet = dts.Tables[0].Rows[0]["CodePlanet"].ToString();

            //    //ERSSSSSSSSSSSSCCCCCCCCCCCC
            //    //                On
            //    //                ER Tipus de missatge(Entry Requirement).És un literal(2 caràcters ER)
            //    //SSSSSSSSSSSS representa l’identificador de la nau(12 caràcters)
            //    //CCCCCCCCCCCC representa l’identificador de l’entrega(12 caràcters)
            //}
            //else if (messagetype ==  "VK - Validation Key")
            //{


            //} else
            //{
            //    MessageBox.Show("Error");
            //}

            //TODO: casos IF para cada tipo de mensaje
        }

        private void btn_steps_Click(object sender, EventArgs e)
        {

            //lbx_events.Items.Add("Hola");

            //bajarse codigo validacion planeta
            DataSet dts;
            dataAccess.connectToDDBB(ProjectName);
            dts = dataAccess.getByQuery("SELECT * FROM InnerEncryption WHERE idPlanet = " + idPlanetDelivery, ProjectName);

            if (dts.Tables[0].Rows.Count == 0)
            {
                return;
            }
            string ValidationCode = dts.Tables[0].Rows[0]["ValidationCode"].ToString();

            //bajarse clave publica planeta
            dts = dataAccess.getByQuery("SELECT * FROM PlanetKeys WHERE idPlanet = " + idPlanetDelivery, ProjectName);

            if (dts.Tables[0].Rows.Count == 0)
            {
                return;
            }
            string publicKeyXML = dts.Tables[0].Rows[0]["XMLKey"].ToString();


            //encriptar codigo validacion planeta
            //MessageBox.Show(publicKeyXML);
            rsaEnc.FromXmlString(publicKeyXML);
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] plaintext;
            byte[] encryptedtext;

            //tbx_original - mensaje a encriptar 
            //tbx_crypted - mensaje encriptado

            //convertir el texto plano en un un array de bytes 
            plaintext = ByteConverter.GetBytes(ValidationCode);
            //encriptar
            encryptedtext = Encryption(plaintext, rsaEnc.ExportParameters(false), false);
            encryptedArray = encryptedtext;
            //convertir a texto para mostrarlo en textbox
            string cryptedValidacionCode = ByteConverter.GetString(encryptedtext);

            MessageBox.Show(cryptedValidacionCode);


            //poner mensaje para enviar VK
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

        private void tbx_pubkey_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_port_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_connectTCPIP2_Click(object sender, EventArgs e)
        {
            if (!IsConnected)
            {
                comprobarConexion = new Thread(conectarServer);
                comprobarConexion.Start();
                IsConnected = true;
            }
        }

        public void conectarServer()
        {
            try
            {
                Listener = new TcpListener(IPAddress.Any, 8000);
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
                        lbx_events.Items.Add("La IP " + ipMissatge + " ha enviado: " + data);
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

        private void button1_Click(object sender, EventArgs e)
        {
            closeServer();
        }

        private void btn_sendfile_Click(object sender, EventArgs e)
        {
                        string messagetype = cbx_messages.Text; //seleccion de la combobox???


            try
            {

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = @"C:\";
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

                        //tbx_routeXML.Text = filePath;
                        MessageBox.Show("File " + fileName + " on hold.");
                    }
                }
                TcpClient client = new TcpClient(tbx_ipplanet.Text, Convert.ToInt32(tbx_port.Text));
                //if (txb_message.Text == "")
                //{
                //    MessageBox.Show("Introducir mensaje");
                //}
                //else
                //{

                    Byte[] dades = Encoding.ASCII.GetBytes(fileName);
                    NetworkStream ns = client.GetStream();
                    ns.Write(dades, 0, dades.Length);
                //}
            }
            catch
            {
                MessageBox.Show("Servidor inaccesible");
            }
        }
    }
}
