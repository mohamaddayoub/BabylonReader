using DevExpress.XtraBars;
using Guna.UI2.WinForms;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using static DevExpress.Utils.Frames.FrameHelper;

namespace BabylonReaderDashboard
{
    public partial class Form1 : Form
    {
        static string Language = "en";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            pnl_language.Visible = !(pnl_language.Visible);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnl_SideBar.Width > 100)
            {
                pnl_SideBar.Width = 60;
                btnKeys.Tag = btnKeys.Text;
                btnLanguage.Tag = btnLanguage.Text;
                btnSetting.Tag = btnSetting.Text;
                btnExit.Tag = btnExit.Text;
                btnKeys.Text = btnLanguage.Text = btnSetting.Text = btnExit.Text = "";
                pnl_language.Visible = false;
            }else
            {
                pnl_SideBar.Width = 300;
                btnKeys.Text = btnKeys.Tag.ToString();
                btnSetting.Text = btnSetting.Tag.ToString();
                btnLanguage.Text = btnLanguage.Tag.ToString();
                btnExit.Text = btnExit.Tag.ToString();
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            if (btn == btnKeys)
            {
                frmSetting1.Visible = false;
                frmKeys1.Visible = true;
            }else
            {
                frmSetting1.Visible = true;
                frmKeys1.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Environment.GetEnvironmentVariable("SERVERIP") == "test")
            {
                frmStart frm = new frmStart();
                frm.ShowDialog();
            }
        }
        private void setLanguage()
        {
            if (Form1.Language == "en") Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            else Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar");
        }
        private bool Confirm_SwitchLanguage(string msg, string title, bool IsEnglish)
        {
            if (MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (IsEnglish)
                    Language = "en";
                else
                    Language = "ar";
                this.Controls.Clear();
                setLanguage();
                InitializeComponent();
                return true;
            }return false;
        }
        private void btnEnglishLanguage_Click(object sender, EventArgs e)
        {
            string msg = "";
            string title = "";
            msg = "هل انت تريد تبديل لغة التطبيق الى اللغة الانكليزية ؟";
            title = "تبديل اللغة";
            if (Confirm_SwitchLanguage(msg, title, true)) btnEnglishLanguage.Checked = true;
            else btnArabicLanguage.Checked = true;
        }
        private void btnArabicLanguage_Click(object sender, EventArgs e)
        {
            string msg = "";
            string title = "";
            msg = "Are you want to switch the language of the application to Arabic ?";
            title = "Switch Language";
            if (Confirm_SwitchLanguage(msg, title, false)) btnArabicLanguage.Checked = true;
            else btnEnglishLanguage.Checked = true;
        }
    }
}