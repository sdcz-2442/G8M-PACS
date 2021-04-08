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
using G8_Starship;

namespace PACS_starship
{
    public partial class frm_selectspaceship : Form
    {
        public string projectName = "PACS_starship";
        public string spaceshipCode;
        public string spaceshipIdSelected;
        public string spaceshipIP;
        public string spaceshipPort1;
        public string spaceshipPort2;

        public frm_selectspaceship()
        {
            InitializeComponent();
        }

        private void frm_selectspaceship_Load(object sender, EventArgs e)
        {

        }

        private void btn_selectspaceship_Click(object sender, EventArgs e)
        {
            G8_DataAccess.DataAccess dataAccess = new G8_DataAccess.DataAccess();
            DataSet dts;

            dataAccess.connectToDDBB(projectName);

            spaceshipCode = tbx_spaceshipname.Text;

            dts = dataAccess.getByQuery("SELECT * FROM SpaceShips WHERE CodeSpaceShip = '" + spaceshipCode+"'", "Spaceships", projectName);

            spaceshipIdSelected = dts.Tables[0].Rows[0]["idSpaceShip"].ToString();
            spaceshipIP = dts.Tables[0].Rows[0]["IPSpaceShip"].ToString();
            spaceshipPort1 = dts.Tables[0].Rows[0]["PortSpaceShip"].ToString();
            spaceshipPort2 = dts.Tables[0].Rows[0]["PortSpaceship1"].ToString();


            this.Hide();
            new frm_spaceship().Show();
        }
    }
}
