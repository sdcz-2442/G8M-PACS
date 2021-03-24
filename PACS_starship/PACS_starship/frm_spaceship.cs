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


namespace G8_Starship
{
    public partial class frm_spaceship : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public string projectName = "PACS_starship";
        string xmlPath = @"C:\TCP-pruebas\TCPSettings.xml";

        Thread checkNetwork;

        UnicodeEncoding ByteConverter = new UnicodeEncoding();

        string fileName = "";
        string filePath = @"C:\";
        string fileContent = "";

        public static string encryptedMessage;
        public static byte[] encryptedArray;

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
                //TODO: obtener xml de la bbdd

                //                En aquest cas la tripulació de la nau es connectarà a la base de dades Secure Core i obtindrà
                //per una banda el codi de validació del planeta destí del proper viatge interestel·lar(taula
                //InnerEncryption) i per altra banda la clau pública del planeta en format XML(taula PlanetKeys)
                //Un cop es disposa d’aquestes dades, cal encriptar el codi de validació utilitzant RSA i la clau
                //pública del planeta.
                //Aquest codi encriptat s’enviarà posteriorment per TCP-IP al planeta. Ara es pot fer amb una
                //propietat tal i com s’ha fet en els exercicis d’entrenament previs.

                G8_DataAccess.DataAccess dataAccess = new G8_DataAccess.DataAccess();
                DataSet dts;

                dataAccess.connectToDDBB(projectName);
                dts = dataAccess.getByQuery("SELECT ValidationCode FROM InnerEncryption", projectName);

                //using (OpenFileDialog openFileDialog = new OpenFileDialog())
                //{
                //    openFileDialog.InitialDirectory = @"C:\";
                //    openFileDialog.Filter = "Xml files (*.xml)|*.xml" + "|" + "All files (*.*)|*.*";
                //    openFileDialog.FilterIndex = 2;
                //    openFileDialog.RestoreDirectory = true;

                //    if (openFileDialog.ShowDialog() == DialogResult.OK)
                //    {
                //        filePath = openFileDialog.FileName;
                //        fileName = openFileDialog.SafeFileName;
                //        Stream fileStream = openFileDialog.OpenFile();

                //        using (StreamReader reader = new StreamReader(fileStream))
                //        {
                //            fileContent = reader.ReadToEnd();
                //        }

                //        //MessageBox.Show("File " + fileName + " on hold.");
                //    }
                //}

                //DESENCRIPTAR CON CLAVE PRIVADA
                string cryptedText = ""; //TODO: poner una textbox para mostrar el mensaje al usuario?
                //tbx_crypted.Text = frmEncriptar.encryptedMessage;
                //TODO: cambiar en la siguiente línea el array de bytes encriptado
                //encryptedText = frmEncriptar.encryptedArray;
                //desencriptar el mensaje cifrado
                //byte[] decryptedtex = Decryption(encryptedText,
                //rsa.ExportParameters(true), false);
                //convertir array de bytes en string
                //tbx_decrypted.Text = ByteConverter.GetString(decryptedtex);
            } else if (messagetype ==  "VK - Validation Key")
            {
                string validationkey = "";
                string encrpyted_validationkey = "";
                //una vez recibido el mensaje de VR-Validation result
                //Bajar validationkey de BBDD

                //encriptar validationkey con la clave pública

                UnicodeEncoding ByteConverter = new UnicodeEncoding();
                byte[] dataToEncrypt = ByteConverter.GetBytes(validationkey);
                byte[] encryptedData;
                byte[] decryptedData;

                encryptedData = Rsaencrypt.Encrypt(dataToEncrypt, false);

                //textcryptosend = encryptedData;
                encrpyted_validationkey = ByteConverter.GetString(encryptedData);

                //TODO: enviar clave encriptada al planeta vía TCP-IP

                MessageBox.Show("OK");
                //encriptado el código de validación, enviar al planeta para que lo desencripte utilizando su clave privada
                //La nau es baixa de la BBDD(taula InnerEncryption) el codi de validació del planeta de
                //destí i l’encripta amb la clau pública del planeta que s’haurà descarregat de Secure
                //Core en format XML(la descarrega de la clau pública es pot haver fet amb
                //anterioritat)
                //7.Un cop encriptat el codi de validació, l’envia al planeta per tal que aquest es
                //desencripti utilitzant la seva clau privada. (missatge VK - Validation Key)


                //l’encripta amb la clau pública del planeta que s’haurà descarregat de Secure
                //Core en format XML(la descarrega de la clau pública es pot haver fet amb
                //anterioritat)

            } else
            {
                MessageBox.Show("Error");
            }

            //TODO: casos IF para cada tipo de mensaje
        }

        private void btn_steps_Click(object sender, EventArgs e)
        {
            //La nau descomprimirà el fitxer i utilitzarà la codificació obtinguda de Secure Core per
            //transformar les seqüències de números en seqüencies de lletres, convertirà les tres
            //cadenes de lletres en una de sola, i ho guardarà en un fitxer anomenat PACSSOL.txt
            //15.Ho reenviarà cap el planeta.
            lbx_events.Items.Add("Hola");
        }

        private void tbx_pubkey_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
