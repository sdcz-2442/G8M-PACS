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

namespace G8_Starship
{
    public partial class frm_spaceship : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        Thread checkNetwork;

        UnicodeEncoding ByteConverter = new UnicodeEncoding();

        public frm_spaceship()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void frm_spaceship_Load(object sender, EventArgs e)
        {
            checkNetwork = new Thread(ComprobarRed);
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
            checkNetwork.Start();
        }

        public void ComprobarRed()
        {
            bool networkStatus = false;
            int pingCount = 0;
            string ipPing = "192.168.1.1"; //get ping from database


            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
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
                Thread.Sleep(500);
            }

            //si hay alguna interfaz wifi o ethernet activo y se ha recibido respuesta de al menos la mitad de los pings
            if (!networkStatus)
            {
                lbl_networkstatus.Text = "KO";
            }
            else if (pingCount < 5)
            {

                lbl_networkstatus.Text = "Waiting...";
            }
            else
            {
                lbl_networkstatus.Text = "OK";

            }


        }
    }
}
