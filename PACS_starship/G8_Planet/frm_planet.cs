using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G8_Planet
{
    public partial class frm_planet : Form
    {

        public string ipMissatge = "192.168.1.1";
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
    }
}
