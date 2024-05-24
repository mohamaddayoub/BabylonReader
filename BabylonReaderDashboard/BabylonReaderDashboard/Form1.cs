using Guna.UI2.WinForms;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

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
                btnKeys.Text = btnLanguage.Text = btnExit.Text = "";
                pnl_language.Visible = false;
            }else
            {
                pnl_SideBar.Width = 300;
                btnKeys.Text = btnKeys.Tag.ToString();
                btnLanguage.Text = btnLanguage.Tag.ToString();
                btnExit.Text = btnExit.Tag.ToString();
            }
        }

        private void hideForms()
        {
            frmKeys1.Visible = false;
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
    }
}
