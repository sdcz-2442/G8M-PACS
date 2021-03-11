using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G8_Planet
{
    public partial class frm_planet : Form
    {

        public string ipMissatge = "192.168.1.1";


        string fileName = "";
        string filePath = @"C:\";
        string fileContent = "";

        RSACryptoServiceProvider rsa;
        UnicodeEncoding ByteConverter = new UnicodeEncoding();

        byte[] encryptedText;

        public frm_planet()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        Thread comprobarConexion;

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (!IsConnected)
            {
                comprobarConexion = new Thread(conectarServer);
                comprobarConexion.Start();
                IsConnected = true;
            }

        }
        Boolean IsConnected;
        TcpClient client;
        TcpListener Listener = null;
        NetworkStream ns;

        public void conectarServer()
        {
            try
            {
                Listener = new TcpListener(IPAddress.Any, Convert.ToInt32(txb_port.Text));
                Listener.Start();

                while (IsConnected)
                {
                    if (Listener.Pending())
                    {
                        client = Listener.AcceptTcpClient();
                        ns = client.GetStream();
                        Byte[] buffer = new byte[256];

                        string data = "";
                        ns.Read(buffer, 0, buffer.Length);
                        data = Encoding.ASCII.GetString(buffer, 0, buffer.Length);
                        lbx_Missatges.Items.Add("La IP " + ipMissatge + " ha enviado: " + data);
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
            string TextKeyName = tbx_container.Text;
            CspParameters cspp = new CspParameters();
            string keyName = TextKeyName;
            cspp.KeyContainerName = keyName;
            rsa = new RSACryptoServiceProvider(cspp);
            string publicKey = rsa.ToXmlString(false);
            string pathfinal = @filePath + @"\Clau.xml";
            File.WriteAllText(pathfinal, publicKey);


            //TODO: crear clave planeta

            //TODO: guardar claves en BBDD!!!!
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

        private void lbl_port_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
