using System;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace DXApplication4
{
    public partial class Introduction : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public static string SelectedPathFile = "";
        private void Inital()
        {
            // Check on Language before initialize component
            if (DXApplication4.Properties.Settings.Default.Language == "en")
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            else
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
            this.Controls.Clear();
            InitializeComponent();
        }
        public Introduction()
        {
            Inital();
        }
        private void Introduction_Load(object sender, EventArgs e)
        {
            // add Columns 
            DataTable files = new DataTable();
            if (Thread.CurrentThread.CurrentUICulture.ToString() == "en")
            {
                files.Columns.Add("File Name");
                files.Columns.Add("Creation time");
                files.Columns.Add("Length");
                files.Columns.Add("Path");
            }
            else
            {
                files.Columns.Add("اسم الملف");
                files.Columns.Add("تاريخ الانشاء");
                files.Columns.Add("الحجم");
                files.Columns.Add("المسار");
            }
            // add recent files
            fill(files);
            if (files.Rows.Count > 0)
                guna2DataGridView1.DataSource = files;
        }
        private void fill(DataTable files)
        {
            fillDataGridViewRecent(DXApplication4.Properties.Settings.Default.RT_One, files);
            fillDataGridViewRecent(DXApplication4.Properties.Settings.Default.RT_Two, files);
            fillDataGridViewRecent(DXApplication4.Properties.Settings.Default.RT_Three, files);
            fillDataGridViewRecent(DXApplication4.Properties.Settings.Default.RT_Four, files);
            fillDataGridViewRecent(DXApplication4.Properties.Settings.Default.RT_Five, files);
            fillDataGridViewRecent(DXApplication4.Properties.Settings.Default.RT_Six, files);
            fillDataGridViewRecent(DXApplication4.Properties.Settings.Default.RT_Seven, files);
            fillDataGridViewRecent(DXApplication4.Properties.Settings.Default.RT_Eight, files);
            fillDataGridViewRecent(DXApplication4.Properties.Settings.Default.RT_Nine, files);
            fillDataGridViewRecent(DXApplication4.Properties.Settings.Default.RT_Ten, files);
        }
        private void fillDataGridViewRecent(string path, DataTable files)
        {
            if (File.Exists(path))
            {
                FileInfo fi = new FileInfo(path);
                files.Rows.Add(fi.Name, fi.CreationTime, (fi.Length / 1000).ToString() + " KB",fi.FullName );
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pdf Files|*.pdf"; 
            ofd.Multiselect = false;
            ofd.Title = "Choose Pdf File";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                openFile(ofd.FileName);
            }
        }
        private void openFile(string path)
        {
            SelectedPathFile = path;
            this.Hide();
            Form1 frm = new Form1();
            frm.ShowDialog();
            frm = null;
            this.Show();
            Inital();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnl_Menu.Width > 100)
            {
                btnRecentFiles.Text = btnOpenFile.Text = btnExit.Text = "";
                pnl_Menu.Width = 70;
            }
            else
            {
                btnRecentFiles.Text = btnRecentFiles.Tag.ToString();
                btnOpenFile.Text = btnOpenFile.Tag.ToString();
                //btnSetting.Text = btnSetting.Tag.ToString();
                btnExit.Text = btnExit.Tag.ToString();
                pnl_Menu.Width = 250;
            }
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string path = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                openFile(path);
            }
        }
    }
}