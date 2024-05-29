namespace DXApplication4
{
    partial class frmActivate
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivate));
            this.txtKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnl_Activate = new Guna.UI2.WinForms.Guna2Panel();
            this.btnActivate = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_ActivateInformation = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblProdutKey = new System.Windows.Forms.Label();
            this.lblValidity = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_Activate.SuspendLayout();
            this.pnl_ActivateInformation.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.SystemColors.Control;
            this.txtKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKey.DefaultText = "";
            this.txtKey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            resources.ApplyResources(this.txtKey, "txtKey");
            this.txtKey.FillColor = System.Drawing.SystemColors.Control;
            this.txtKey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKey.ForeColor = System.Drawing.Color.Black;
            this.txtKey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKey.MaxLength = 19;
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '\0';
            this.txtKey.PlaceholderText = "Enter your key";
            this.txtKey.SelectedText = "";
            // 
            // pnl_Activate
            // 
            this.pnl_Activate.Controls.Add(this.btnActivate);
            this.pnl_Activate.Controls.Add(this.txtKey);
            resources.ApplyResources(this.pnl_Activate, "pnl_Activate");
            this.pnl_Activate.Name = "pnl_Activate";
            // 
            // btnActivate
            // 
            this.btnActivate.AutoRoundedCorners = true;
            this.btnActivate.BorderRadius = 21;
            this.btnActivate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActivate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActivate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActivate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.btnActivate, "btnActivate");
            this.btnActivate.ForeColor = System.Drawing.Color.White;
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // pnl_ActivateInformation
            // 
            this.pnl_ActivateInformation.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.pnl_ActivateInformation, "pnl_ActivateInformation");
            this.pnl_ActivateInformation.Name = "pnl_ActivateInformation";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.lblProdutKey, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblValidity, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCreationDate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSerialNumber, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // lblProdutKey
            // 
            resources.ApplyResources(this.lblProdutKey, "lblProdutKey");
            this.lblProdutKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProdutKey.Name = "lblProdutKey";
            // 
            // lblValidity
            // 
            resources.ApplyResources(this.lblValidity, "lblValidity");
            this.lblValidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValidity.Name = "lblValidity";
            // 
            // lblCreationDate
            // 
            resources.ApplyResources(this.lblCreationDate, "lblCreationDate");
            this.lblCreationDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCreationDate.Name = "lblCreationDate";
            // 
            // lblSerialNumber
            // 
            resources.ApplyResources(this.lblSerialNumber, "lblSerialNumber");
            this.lblSerialNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSerialNumber.Name = "lblSerialNumber";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // frmActivate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_ActivateInformation);
            this.Controls.Add(this.pnl_Activate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActivate";
            this.ShowIcon = false;
            this.pnl_Activate.ResumeLayout(false);
            this.pnl_ActivateInformation.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtKey;
        private Guna.UI2.WinForms.Guna2Panel pnl_Activate;
        private Guna.UI2.WinForms.Guna2Button btnActivate;
        private Guna.UI2.WinForms.Guna2Panel pnl_ActivateInformation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblProdutKey;
        private System.Windows.Forms.Label lblValidity;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}