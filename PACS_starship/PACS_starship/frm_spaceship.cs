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

namespace G8_Starship
{
    public partial class frm_spaceship : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        string xmlPath = @"C:\TCP-pruebas\TCPSettings.xml";

        Thread checkNetwork;

        UnicodeEncoding ByteConverter = new UnicodeEncoding();

        public frm_spaceship()
        {
            InitializeComponent();
            //Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void frm_spaceship_Load(object sender, EventArgs e)
        {
            lbl_networkstatus.Visible = false;
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
                    }
                    else if (pingCount < 5)
                    {

                        lbl_networkstatus.Text = "Waiting...";
                        btn_sendping.Enabled = true;
                        tbx_ipplanet.Enabled = true;
                        cbx_messages.Enabled = true;
                        btn_sendmessages.Enabled = true;
                        tbx_port.Enabled = true;
                    }
                    else
                    {
                        lbl_networkstatus.Text = "OK";
                        btn_sendping.Enabled = true;
                        tbx_ipplanet.Enabled = true;
                        cbx_messages.Enabled = true;
                        btn_sendmessages.Enabled = true;
                        tbx_port.Enabled = true;
                    }

                }
            } catch (System.Threading.ThreadStateException)
            {
                MessageBox.Show("Error2");
            }
        }
    }
}
