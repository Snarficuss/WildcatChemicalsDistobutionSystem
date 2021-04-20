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
    public partial class frmDynamicScheduler : Form
    {
        public frmDynamicScheduler()
        {
            InitializeComponent();
        }

        private static bool isResizeMode;
        private void DynamicDayDisplay_Load(object sender, EventArgs e)
        {

        }

        private void ResizablePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isResizeMode = true;
            }
        }

        private void ResizablePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isResizeMode)
            {
                this.Size = new Size(e.X, e.Y);
            }
        }

        private void ResizablePanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isResizeMode = false;
            }
        }
    }
}
