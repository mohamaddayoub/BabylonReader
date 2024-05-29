using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace DXApplication4
{
    public partial class frmDigitalSignature : DevExpress.XtraEditors.XtraForm
    {
        public frmDigitalSignature()
        {
            if (Form1.Language == "en") Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            else Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar");
            InitializeComponent();
        }
        float pointX;
        float pointY;

        float point2X;
        float point2Y;

        bool painted = false;
        public static bool Success = false;

        private void pnl_Paint_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = imgSignature.CreateGraphics();
            g.DrawLine(Pens.Black, pointX, pointY, point2X, point2Y);
            point2X = pointX;
            point2Y = pointY;
            painted = true;
        }
        private void pnl_Paint_MouseDown(object sender, MouseEventArgs e)
        {
            point2X = e.X;
            point2Y = e.Y;
        }
        private void pnl_Paint_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pointX = e.X;
                pointY = e.Y;
                pnl_Paint_Paint(this, null);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = "";
            painted = false;
            imgSignature.Image = null;
        }
        private void btnDraw_CheckedChanged(object sender, EventArgs e)
        {
            if (btnDraw.Checked)
            {
                pnl_name.Visible = false;
                pnl_LoadImage.Visible = true;
            }
        }
        private void btnGenerate_CheckedChanged(object sender, EventArgs e)
        {
            if (btnGenerate.Checked)
            {
                pnl_LoadImage.Visible = false;
                pnl_name.Visible = true;
            }
        }
        private void btnLoadSignature_CheckedChanged(object sender, EventArgs e)
        {
            if (btnLoadSignature.Checked)
            {
                pnl_name.Visible = false;
                pnl_LoadImage.Visible = true;
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
                    ofd.Multiselect = false;
                    ofd.Title = "Choose a signature";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        imgSignature.Load(ofd.FileName);
                    }
                }
            }
        }
        private void btnFinish_Click(object sender, EventArgs e)
        {
            Bitmap image = null;
            if (btnGenerate.Checked && guna2TextBox1.Text.Trim().Length > 0)
            {
                image = new Bitmap(guna2TextBox1.Width, guna2TextBox1.Height);
                guna2TextBox1.DrawToBitmap(image, guna2TextBox1.ClientRectangle);
            }
            else if (btnDraw.Checked && painted)
            {
                image = new Bitmap(imgSignature.Width, imgSignature.Height);
                imgSignature.DrawToBitmap(image, imgSignature.ClientRectangle);
            }
            else if (btnLoadSignature.Checked && imgSignature.Image!= null)
            {
                image = new Bitmap(imgSignature.Image);
            }
            else
            {
                string msg = "", title = "";
                CultureInfo currentCulture = CultureInfo.CurrentCulture;
                if (currentCulture.Name == "en-US")
                {
                    msg = "Please generate or draw a signature";
                    title = "Warning";
                }else
                {
                    msg = "يرحى توليد توقيع او رسمه";
                    title = "تحذير";
                }
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Success = false;
            }
            if (image != null)
            {
                Form1.Signature = image;
                Success = true;
                this.Close();
            }
        }

        private void frmDigitalSignature_Resize(object sender, EventArgs e)
        {
            int x, y;
            x = this.Width / 2 + imgSignature.Width;
            y = this.Height / 2 + imgSignature.Height;
            imgSignature.Location = new Point(x, y);
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Thread.CurrentThread.CurrentCulture.Name) ;
            
            this.Controls.Clear();
            InitializeComponent();
        }
    }
}