using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            DataBase db = new DataBase(txtServerIP.Text, txtDataBaseName.Text, txtUserID.Text, txtPassword.Text);
        }
    }
}
