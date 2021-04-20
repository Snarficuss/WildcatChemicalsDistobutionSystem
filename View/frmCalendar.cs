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
    public partial class frmCalendar : Form
    {
        public static int[] listFlDay;
        public frmCalendar()
        {
            InitializeComponent();
        }

        private static DateTime selectedDateTime { get; set; }
        public static string selectedDay { get; set; }
        public static string selectedTime { get; set; }

        public static bool dateSelected = false;
        private void frmCalendar_Load(object sender, EventArgs e)
        {
            //flpEventDayDisplay.VerticalScroll.Enabled;
            GenerateDayPanels(5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmManagerMenu usrmnu = new frmManagerMenu();
            usrmnu.Show();
            this.Close();
        }

        public static void GenerateDayPanels(int dayNum)
        {
            try
            {
                for (int i = 1; i <= dayNum; i++) // For each day in the month (Or assigned value for testing)
                {
                    int weeks = dayNum / 7; // Number of weeks in the month. Tells us rows needed
                    FlowLayoutPanel fl = new FlowLayoutPanel();
                    
                    fl.Name = $"flDay{i}"; // Creates a dynamically created name value for the i'th day in the month
                    //fl.Location = new Point((129 * dayNum + 2),);
                    fl.Size = new Size(126, 92);
                    fl.BackColor = Color.LightBlue;
                    fl.Visible = true;
                    fl.BorderStyle = BorderStyle.FixedSingle;
                    frmCalendar cl = new frmCalendar();
                    cl.fpnlMonthDays.Controls.Add(fl);
                    fl.BringToFront();
                    fl.Show();
                    //PopulateDays(fl.Name, dayNum);
                    fl.Controls.Clear();
                    //MessageBox.Show(fl.Name);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        //public static void GenerateDayEvents(int day)
        //{
        //    try
        //    {
        //        for (int i = 1; i <= dayNum; i++)
        //        {
        //            int weeks = dayNum / 7;
        //            FlowLayoutPanel fl = new FlowLayoutPanel();
        //            fl.Name = $"flDay{i}";
        //            //fl.Location = new Point((129 * dayNum + 2),);
        //            fl.Size = new Size(126, 92);
        //            fl.BackColor = Color.LightBlue;
        //            fl.Visible = true;
        //            //fl.BorderStyle = BorderStyle.FixedSingle;
        //            frmCalendar cl = new frmCalendar();
        //            cl.fpnlMonthDays.Controls.Add(fl);
        //            fl.BringToFront();
        //            fl.Show();
        //            //PopulateDays(fl.Name, dayNum);
        //            fl.Controls.Clear();
        //            //MessageBox.Show(fl.Name);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.ToString());
        //    }
        //}

        private void button5_Click(object sender, EventArgs e)
        {
            frmDynamicScheduler ddd = new frmDynamicScheduler();
            ddd.Show();
        }

        private void PopulateDays(string panelName, int dayNum)
        {
            string name = panelName;
            int day = dayNum;

            LinkLabel llblDayNum = new LinkLabel();
                llblDayNum.Text = dayNum.ToString();
            //    llblDayNum.Name = "$"
            LinkLabel llblShipmentCount = new LinkLabel();

            LinkLabel llblAvailibleHours = new LinkLabel();

            Label lblShipments = new Label();
                lblShipments.Text = "Shipments:";
                
            Label lblHouse_Availible = new Label();
                lblHouse_Availible.Text = "Availible Hours:";
        }

        private void dtpckDateTime_ValueChanged(object sender, EventArgs e)
        {
            selectedDateTime = dtpckDateTime.Value;
            string[] date = dtpckDateTime.ToString().Split(' ');
            selectedDay = date[0];
            selectedTime = date[1];

            dateSelected = true;
        }
    }
}
