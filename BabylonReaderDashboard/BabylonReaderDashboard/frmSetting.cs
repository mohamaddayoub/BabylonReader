using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace BabylonReaderDashboard
{
    public partial class frmSetting : UserControl
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void frmSetting_Resize(object sender, EventArgs e)
        {
            int x = this.Width/2 + btnSubmit.Width;
            btnSubmit.Location = new Point(x, btnSubmit.Location.Y);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("SERVERIP", txtServerIP.Text);
            Environment.SetEnvironmentVariable("DATABASENAME", txtDataBaseName.Text);
            Environment.SetEnvironmentVariable("USERID", txtUserID.Text);
            Environment.SetEnvironmentVariable("PASSWORD", txtPassword.Text);

            string msg, title;
            if (Thread.CurrentThread.CurrentUICulture.ToString() == "en")
            {
                title = "Done";
                msg = "The data has been recorded.";
            }
            else
            {
                title = "تم";
                msg = ".تم تسجيل البيانات";
            }
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information) ;
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            if (BabylonReaderDashboard.Properties.Resources.SERVERIP != "")
            {
                txtServerIP.Text = Environment.GetEnvironmentVariable("SERVERIP");
                txtDataBaseName.Text = Environment.GetEnvironmentVariable("DATABASENAME");
                txtUserID.Text = Environment.GetEnvironmentVariable("USERID");
                txtPassword.Text = Environment.GetEnvironmentVariable("PASSWORD");
            }   
        }

        private void frmSetting_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible) frmSetting_Load(sender, e);
        }
    }
}
