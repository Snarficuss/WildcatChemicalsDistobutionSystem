using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WildcatChemicalsDistrobutionAndTrackingSystem.View
{
    public partial class frmShipmentView : Form
    {
        public frmShipmentView()
        {
            InitializeComponent();
        }

        private void frmNewEvent_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelShipment_Click(object sender, EventArgs e)
        {
            frmManagerMenu usrmnu = new frmManagerMenu();
            usrmnu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectTime_Click(object sender, EventArgs e)
        {
            frmCalendar cal = new frmCalendar(); 
            cal.Show();
        }

        private void txtShipmentDate_TextChanged(object sender, EventArgs e)
        {
            btnSubmit.Visible = true;
        }


    }
}
