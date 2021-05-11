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

namespace PACS
{
    public partial class frm_selectStarship : Form
    {
        public string projectName = "PACS_starship";


        public frm_selectStarship()
        {
            InitializeComponent();
        }

        private void btn_selectspaceship_Click(object sender, EventArgs e)
        {

        string spaceshipCode;
        string spaceshipIdSelected;
        string spaceshipIP;
        string spaceshipPort1;
        string spaceshipPort2;
        string codeSpaceShip;

        G8_DataAccess.DataAccess dataAccess = new G8_DataAccess.DataAccess();
            DataSet dts;

            dataAccess.connectToDDBB(projectName);

            spaceshipCode = tbx_spaceshipname.Text;

            dts = dataAccess.getByQuery("SELECT * FROM SpaceShips WHERE CodeSpaceShip = '" + spaceshipCode + "'", "Spaceships", projectName);

            spaceshipIdSelected = dts.Tables[0].Rows[0]["idSpaceShip"].ToString();
            spaceshipIP = dts.Tables[0].Rows[0]["IPSpaceShip"].ToString();
            spaceshipPort1 = dts.Tables[0].Rows[0]["PortSpaceShip"].ToString();
            spaceshipPort2 = dts.Tables[0].Rows[0]["PortSpaceship1"].ToString();
            codeSpaceShip = dts.Tables[0].Rows[0]["CodeSpaceShip"].ToString();


            spaceship ss = new spaceship();
            ss.codeSpaceship = tbx_spaceshipname.Text;
            ss.spaceshipIdSelected = spaceshipIdSelected;
            ss.spaceshipIP = spaceshipIP;
            ss.spaceshipPort1 = spaceshipPort1;
            ss.spaceshipPort2 = spaceshipPort2;

            this.Hide();
            ss.Show();
        }
    }
}
