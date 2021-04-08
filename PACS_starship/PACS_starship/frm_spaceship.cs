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

        public frm_spaceship()
        {
            InitializeComponent();
            //Control.CheckForIllegalCrossThreadCalls = false;
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

            //ER - Entry Requirement
            //(missatge VK- Validation Key)


            ///mensajes del planeta 
            /////(missatge VR - Validation Result)
            ///(missatge VR - Validation Result)
            ///(missatge VR - Validation Result)
            //

            string messagetype = cbx_messages.Text; //seleccion de la combobox???
            if (messagetype == "ER - Entry Requirement") //PONER TIPO DE MENSAJE QUE ENVÍA NAVE A PLANETA, OBTIENE CLAVES ETC
            {
                //Select planet
                string entryRequirementMessage = "ER" + spaceshipCode;

                DataSet dts;

                //Selecciono planeta
                namePlanetDelivery = cbx_selectplanet.Text;

                dataAccess.connectToDDBB(ProjectName);
                dts = dataAccess.getByQuery("SELECT * FROM Planets WHERE DescPlanet = '" + namePlanetDelivery + "'", "Planets", ProjectName);

                if (dts.Tables[0].Rows.Count == 0)
                {
                    return;
                }
                idPlanetDelivery = dts.Tables[0].Rows[0]["idPlanet"].ToString();

                //Selecciono delivery SELECT * FROM DeliveryData WHERE idSpaceShip = 4 AND idPlanet = 1
                dts = dataAccess.getByQuery("SELECT * FROM DeliveryData WHERE idSpaceShip = " + idOwnSpaceship + " AND idPlanet = "+idPlanetDelivery, "Planets", ProjectName);

                if (dts.Tables[0].Rows.Count == 0)
                {
                    return;
                }
                idPlanetDelivery = dts.Tables[0].Rows[0]["idPlanet"].ToString();

                //SELECT * FROM DeliveryData WHERE idSpaceShip = 4 AND idPlanet = 1


                //DataSet dts;

                //dataAccess.connectToDDBB(ProjectName);
                //dts = dataAccess.getByQuery("SELECT * FROM Planets ORDER BY DescPlanet ASC", "Planets", ProjectName);
                //cbx_selectplanet.DisplayMember = "DescPlanet";
                //cbx_selectplanet.ValueMember = "idPlanet";
                //cbx_selectplanet.DataSource = dts.Tables["Planets"];

                //codeOwnPlanet = dts.Tables[0].Rows[0]["CodePlanet"].ToString();

                //ERSSSSSSSSSSSSCCCCCCCCCCCC
                //                On
                //                ER Tipus de missatge(Entry Requirement).És un literal(2 caràcters ER)
                //SSSSSSSSSSSS representa l’identificador de la nau(12 caràcters)
                //CCCCCCCCCCCC representa l’identificador de l’entrega(12 caràcters)
            }
            else if (messagetype ==  "VK - Validation Key")
            {


            } else
            {
                MessageBox.Show("Error");
            }

            //TODO: casos IF para cada tipo de mensaje
        }

        private void btn_steps_Click(object sender, EventArgs e)
        {
            //            //La nau es baixa de la BBDD (taula InnerEncryption) el codi de validació del planeta de
            //            destí i l’encripta amb la clau pública del planeta que s’haurà descarregat de Secure
            //Core en format XML(la descarrega de la clau pública es pot haver fet amb
            //anterioritat)
            //lbx_events.Items.Add("Hola");


            //bajarse codigo validacion planeta
            //SELECT * FROM InnerEncryption
            DataSet dts;
            dataAccess.connectToDDBB(ProjectName);
            dts = dataAccess.getByQuery("SELECT * FROM DeliveryData WHERE idPlanet = " + idPlanetDelivery + "AND idPlanet = "+idOwnSpaceship, ProjectName);
            //SELECT * FROM DeliveryData WHERE idSpaceShip = 4 AND idPlanet = 1


            //bajarse clave publica planeta

            //encriptar codigo validacion planeta

            //poner mensaje para enviar VK
        }

        private void tbx_pubkey_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
