namespace BabylonReaderDashboard
{
    partial class frmKeys
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGenerate = new System.Windows.Forms.Label();
            this.tglSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.lblSearch = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnl_Search = new Guna.UI2.WinForms.Guna2Panel();
            this.txtKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_Generate = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNewKey = new System.Windows.Forms.Label();
            this.cmbPeriod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.Generate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_Keys = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglSwitch.Properties)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.pnl_Generate.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Keys)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoSize = true;
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1000, 45);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.tableLayoutPanel1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1000, 45);
            this.guna2Panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.lblGenerate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tglSwitch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSearch, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 45);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblGenerate
            // 
            this.lblGenerate.AutoSize = true;
            this.lblGenerate.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGenerate.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerate.Location = new System.Drawing.Point(603, 0);
            this.lblGenerate.Name = "lblGenerate";
            this.lblGenerate.Size = new System.Drawing.Size(194, 45);
            this.lblGenerate.TabIndex = 6;
            this.lblGenerate.Text = "Generate a new key";
            this.lblGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tglSwitch
            // 
            this.tglSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tglSwitch.Location = new System.Drawing.Point(403, 3);
            this.tglSwitch.Name = "tglSwitch";
            this.tglSwitch.Properties.ContentAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tglSwitch.Properties.OffText = "";
            this.tglSwitch.Properties.OnText = "";
            this.tglSwitch.Size = new System.Drawing.Size(194, 39);
            this.tglSwitch.TabIndex = 7;
            this.tglSwitch.Toggled += new System.EventHandler(this.tglSwitch_Toggled);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSearch.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(219, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(178, 45);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search for the key";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.AutoSize = true;
            this.guna2Panel3.Controls.Add(this.pnl_Generate);
            this.guna2Panel3.Controls.Add(this.pnl_Search);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 45);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1000, 196);
            this.guna2Panel3.TabIndex = 1;
            // 
            // pnl_Search
            // 
            this.pnl_Search.Controls.Add(this.txtKey);
            this.pnl_Search.Controls.Add(this.guna2Panel4);
            this.pnl_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Search.Location = new System.Drawing.Point(0, 0);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Padding = new System.Windows.Forms.Padding(25, 60, 25, 0);
            this.pnl_Search.Size = new System.Drawing.Size(1000, 98);
            this.pnl_Search.TabIndex = 10;
            // 
            // txtKey
            // 
            this.txtKey.AutoRoundedCorners = true;
            this.txtKey.BorderRadius = 18;
            this.txtKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKey.DefaultText = "";
            this.txtKey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKey.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKey.Location = new System.Drawing.Point(25, 60);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKey.MaxLength = 19;
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '\0';
            this.txtKey.PlaceholderText = "Enter the key for search";
            this.txtKey.SelectedText = "";
            this.txtKey.Size = new System.Drawing.Size(674, 38);
            this.txtKey.TabIndex = 2;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.btnSearch);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel4.Location = new System.Drawing.Point(699, 60);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.guna2Panel4.Size = new System.Drawing.Size(276, 38);
            this.guna2Panel4.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoRoundedCorners = true;
            this.btnSearch.BorderRadius = 18;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(50, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(226, 38);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnl_Generate
            // 
            this.pnl_Generate.Controls.Add(this.lblNewKey);
            this.pnl_Generate.Controls.Add(this.cmbPeriod);
            this.pnl_Generate.Controls.Add(this.guna2Panel5);
            this.pnl_Generate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Generate.Location = new System.Drawing.Point(0, 98);
            this.pnl_Generate.Name = "pnl_Generate";
            this.pnl_Generate.Padding = new System.Windows.Forms.Padding(25, 60, 25, 0);
            this.pnl_Generate.Size = new System.Drawing.Size(1000, 98);
            this.pnl_Generate.TabIndex = 12;
            this.pnl_Generate.Visible = false;
            // 
            // lblNewKey
            // 
            this.lblNewKey.AutoSize = true;
            this.lblNewKey.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNewKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNewKey.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewKey.Location = new System.Drawing.Point(25, 60);
            this.lblNewKey.Name = "lblNewKey";
            this.lblNewKey.Size = new System.Drawing.Size(61, 28);
            this.lblNewKey.TabIndex = 10;
            this.lblNewKey.Text = "Key : ";
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.AutoRoundedCorners = true;
            this.cmbPeriod.BackColor = System.Drawing.Color.Transparent;
            this.cmbPeriod.BorderRadius = 17;
            this.cmbPeriod.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmbPeriod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriod.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPeriod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPeriod.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPeriod.ItemHeight = 30;
            this.cmbPeriod.Location = new System.Drawing.Point(539, 60);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.Size = new System.Drawing.Size(160, 36);
            this.cmbPeriod.TabIndex = 5;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Controls.Add(this.Generate);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel5.Location = new System.Drawing.Point(699, 60);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.guna2Panel5.Size = new System.Drawing.Size(276, 38);
            this.guna2Panel5.TabIndex = 1;
            // 
            // Generate
            // 
            this.Generate.AutoRoundedCorners = true;
            this.Generate.BorderRadius = 18;
            this.Generate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Generate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Generate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Generate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Generate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Generate.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate.ForeColor = System.Drawing.Color.White;
            this.Generate.Location = new System.Drawing.Point(50, 0);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(226, 38);
            this.Generate.TabIndex = 2;
            this.Generate.Text = "Search";
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.Controls.Add(this.dgv_Keys);
            this.guna2Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel6.Location = new System.Drawing.Point(0, 241);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.guna2Panel6.Size = new System.Drawing.Size(1000, 311);
            this.guna2Panel6.TabIndex = 2;
            // 
            // dgv_Keys
            // 
            this.dgv_Keys.AllowUserToAddRows = false;
            this.dgv_Keys.AllowUserToDeleteRows = false;
            this.dgv_Keys.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Keys.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Keys.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Keys.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Keys.ColumnHeadersHeight = 4;
            this.dgv_Keys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Keys.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Keys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Keys.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Keys.Location = new System.Drawing.Point(0, 50);
            this.dgv_Keys.Name = "dgv_Keys";
            this.dgv_Keys.ReadOnly = true;
            this.dgv_Keys.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Keys.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Keys.RowHeadersVisible = false;
            this.dgv_Keys.RowHeadersWidth = 51;
            this.dgv_Keys.RowTemplate.Height = 26;
            this.dgv_Keys.Size = new System.Drawing.Size(1000, 261);
            this.dgv_Keys.TabIndex = 0;
            this.dgv_Keys.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Keys.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgv_Keys.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv_Keys.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Keys.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Keys.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Keys.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Keys.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Keys.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Keys.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgv_Keys.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Keys.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Keys.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_Keys.ThemeStyle.ReadOnly = true;
            this.dgv_Keys.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Keys.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Keys.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgv_Keys.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Keys.ThemeStyle.RowsStyle.Height = 26;
            this.dgv_Keys.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Keys.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frmKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.guna2Panel6);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmKeys";
            this.Size = new System.Drawing.Size(1000, 552);
            this.Load += new System.EventHandler(this.frmKeys_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglSwitch.Properties)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.pnl_Search.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.pnl_Generate.ResumeLayout(false);
            this.pnl_Generate.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Keys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblGenerate;
        private DevExpress.XtraEditors.ToggleSwitch tglSwitch;
        private System.Windows.Forms.Label lblSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel pnl_Generate;
        private System.Windows.Forms.Label lblNewKey;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPeriod;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Button Generate;
        private Guna.UI2.WinForms.Guna2Panel pnl_Search;
        private Guna.UI2.WinForms.Guna2TextBox txtKey;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Keys;
    }
}
