using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WildcatChemicalsDistrobutionAndTrackingSystem.Model;

namespace WildcatChemicalsDistrobutionAndTrackingSystem.View
{
    public partial class frmManagerMenu : Form
    {
        public frmManagerMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCalendar frmCal = new frmCalendar();
            frmCal.Show();
           // this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmShipmentView nshipment = new frmShipmentView();
            nshipment.Show();
            this.Close();
        }

        private void frmManagerMenu_Load(object sender, EventArgs e)
        {
            lblSignedIn.Text = $"Signed in as: {clsUsers.username}";
        }
    }
}
