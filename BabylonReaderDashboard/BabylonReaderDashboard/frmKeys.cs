using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabylonReaderDashboard
{
    public partial class frmKeys : UserControl
    {
        public frmKeys()
        {
            InitializeComponent();
            setPeriods();
        }
        private void setPeriods()
        {
            cmbPeriod.Items.Clear();
            string[] period;

            if (Thread.CurrentThread.CurrentCulture.ToString() == "en")
                period = new string[]{ "1 Month", "2 Month", "3 Month", "4 Month", "5 Month", "6 Month", "7 Month", "8 Month", "9 Month" };                
            else
                 period = new string[]{ "شهر", "شهرين", "ثلاثة اشهر", "اربعة اشهر", "خمسة اشهر", "ستة اشهر", "سبع اشهر", "ثمان اشهر", "تسعة اشهر" };
            
            cmbPeriod.DataSource = period;
            cmbPeriod.SelectedIndex = 5;
        }

        private void tglSwitch_Toggled(object sender, EventArgs e)
        {
            if (tglSwitch.IsOn)
            {
                pnl_Generate.Visible = true;
                pnl_Search.Visible = false;
            }else
            {
                pnl_Search.Visible = true;
                pnl_Generate.Visible = false;
            }
        }

        private void frmKeys_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            DataTable dt = db.getKeys();
            if (dt != null)
                dgv_Keys.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            db.searchAboutKey(txtKey.Text);
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            db.generateNewKey(cmbPeriod.SelectedIndex + 1);
        }
    }
}
