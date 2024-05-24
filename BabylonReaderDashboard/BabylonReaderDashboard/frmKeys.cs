using System;
using System.Data;
using System.Threading;
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
            DataTable dt = db.searchAboutKey(txtKey.Text);
            if (dt != null)
            {
                string msg, title;
                if (dt.Rows.Count > 0)
                {
                    if (Thread.CurrentThread.CurrentUICulture.ToString() == "en")
                    {
                        title = "Done";
                        msg = "The key is found.";
                    }
                    else
                    {
                        title = "تم";
                        msg = ".المفتاح موجود";
                    }
                }
                else
                {
                    if (Thread.CurrentThread.CurrentUICulture.ToString() == "en")
                    {
                        title = "Sorry";
                        msg = "The key is not found.";
                    }
                    else
                    {
                        title = "عذرا";
                        msg = ".المفتاح غير موجود";
                    }
                }
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            string msg, title = "";
            if (db.generateNewKey(cmbPeriod.SelectedIndex + 1))
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString() == "en")
                {
                    title = "Done";
                    msg = "A new key has been generated.";
                }
                else
                {
                    title = "تم";
                    msg = "تم توليد مفتاح جديد";
                }
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString() == "en")
                {
                    title = "Sorry";
                    msg = "A new key was not generated.";
                }
                else
                {
                    title = "عذرا";
                    msg = "لم يتم توليد مفتاح جديد";
                }
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.frmKeys_Load(sender, e);
        }

        private void frmKeys_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible) frmKeys_Load(sender, e);
        }
    }
}
