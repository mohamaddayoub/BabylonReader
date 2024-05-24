namespace BabylonReaderDashboard
{
    partial class frmSetting
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblServerIP = new System.Windows.Forms.Label();
            this.lblDataBaseName = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtServerIP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDataBaseName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtUserID, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDataBaseName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblServerIP, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDataBaseName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUserID, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPassword, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtServerIP, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(824, 443);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServerIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblServerIP.Location = new System.Drawing.Point(3, 0);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(241, 110);
            this.lblServerIP.TabIndex = 0;
            this.lblServerIP.Text = "Server ip";
            this.lblServerIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDataBaseName
            // 
            this.lblDataBaseName.AutoSize = true;
            this.lblDataBaseName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataBaseName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDataBaseName.Location = new System.Drawing.Point(3, 110);
            this.lblDataBaseName.Name = "lblDataBaseName";
            this.lblDataBaseName.Size = new System.Drawing.Size(241, 110);
            this.lblDataBaseName.TabIndex = 1;
            this.lblDataBaseName.Text = "DataBase Name";
            this.lblDataBaseName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserID.Location = new System.Drawing.Point(3, 220);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(241, 110);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "User ID";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPassword.Location = new System.Drawing.Point(3, 330);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(241, 113);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtServerIP
            // 
            this.txtServerIP.AutoRoundedCorners = true;
            this.txtServerIP.BorderRadius = 24;
            this.txtServerIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServerIP.DefaultText = "";
            this.txtServerIP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtServerIP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtServerIP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServerIP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServerIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServerIP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServerIP.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerIP.ForeColor = System.Drawing.Color.Black;
            this.txtServerIP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServerIP.Location = new System.Drawing.Point(251, 30);
            this.txtServerIP.Margin = new System.Windows.Forms.Padding(4, 30, 4, 30);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.PasswordChar = '\0';
            this.txtServerIP.PlaceholderText = "";
            this.txtServerIP.SelectedText = "";
            this.txtServerIP.Size = new System.Drawing.Size(569, 50);
            this.txtServerIP.TabIndex = 4;
            // 
            // txtDataBaseName
            // 
            this.txtDataBaseName.AutoRoundedCorners = true;
            this.txtDataBaseName.BorderRadius = 24;
            this.txtDataBaseName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDataBaseName.DefaultText = "";
            this.txtDataBaseName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDataBaseName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDataBaseName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDataBaseName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDataBaseName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDataBaseName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDataBaseName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataBaseName.ForeColor = System.Drawing.Color.Black;
            this.txtDataBaseName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDataBaseName.Location = new System.Drawing.Point(251, 140);
            this.txtDataBaseName.Margin = new System.Windows.Forms.Padding(4, 30, 4, 30);
            this.txtDataBaseName.Name = "txtDataBaseName";
            this.txtDataBaseName.PasswordChar = '\0';
            this.txtDataBaseName.PlaceholderText = "";
            this.txtDataBaseName.SelectedText = "";
            this.txtDataBaseName.Size = new System.Drawing.Size(569, 50);
            this.txtDataBaseName.TabIndex = 5;
            // 
            // txtUserID
            // 
            this.txtUserID.AutoRoundedCorners = true;
            this.txtUserID.BorderRadius = 24;
            this.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserID.DefaultText = "";
            this.txtUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.ForeColor = System.Drawing.Color.Black;
            this.txtUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.Location = new System.Drawing.Point(251, 250);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4, 30, 4, 30);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PasswordChar = '\0';
            this.txtUserID.PlaceholderText = "";
            this.txtUserID.SelectedText = "";
            this.txtUserID.Size = new System.Drawing.Size(569, 50);
            this.txtUserID.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoRoundedCorners = true;
            this.txtPassword.BorderRadius = 25;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(251, 360);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 30, 4, 30);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(569, 53);
            this.txtPassword.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoRoundedCorners = true;
            this.btnSubmit.BorderRadius = 21;
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(302, 518);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(180, 45);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmSetting";
            this.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.Size = new System.Drawing.Size(824, 566);
            this.Resize += new System.EventHandler(this.frmSetting_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.Label lblDataBaseName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtServerIP;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUserID;
        private Guna.UI2.WinForms.Guna2TextBox txtDataBaseName;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
    }
}
