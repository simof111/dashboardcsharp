using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav3.Height = BtnDashboard.Height;
            PnlNav3.Top = BtnDashboard.Top;
            PnlNav3.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
                int nHeightEllipse

         );


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            PnlNav3.Height = BtnDashboard.Height;
            PnlNav3.Top = BtnDashboard.Top;
            PnlNav3.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnAnalytics_Click(object sender, EventArgs e)
        {
            PnlNav3.Height = BtnAnalytics.Height;
            PnlNav3.Top = BtnAnalytics.Top;
            PnlNav3.Left = BtnAnalytics.Left;
            BtnAnalytics.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnCalendar_Click(object sender, EventArgs e)
        {
            PnlNav3.Height = BtnCalendar.Height;
            PnlNav3.Top = BtnCalendar.Top;
            PnlNav3.Left = BtnCalendar.Left;
            BtnCalendar.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnContactUs_Click(object sender, EventArgs e)
        {
            PnlNav3.Height = BtnContactUs.Height;
            PnlNav3.Top = BtnContactUs.Top;
            PnlNav3.Left = BtnContactUs.Left;
            BtnContactUs.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            PnlNav3.Height = BtnSettings.Height;
            PnlNav3.Top = BtnSettings.Top;
            PnlNav3.Left = BtnSettings.Left;
            BtnSettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnAnalytics_Leave(object sender, EventArgs e)
        {
            BtnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnCalendar_Leave(object sender, EventArgs e)
        {
            BtnCalendar.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnContactUs_Leave(object sender, EventArgs e)
        {
            BtnContactUs.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnSettings_Leave(object sender, EventArgs e)
        {
            BtnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
