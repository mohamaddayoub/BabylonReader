namespace DXApplication4
{
    partial class frmDigitalSignature
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDigitalSignature));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoadSignature = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnDraw = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnGenerate = new Guna.UI2.WinForms.Guna2RadioButton();
            this.pnl_name = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_LoadImage = new Guna.UI2.WinForms.Guna2Panel();
            this.imgSignature = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnl_Finish = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnFinish = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnl_name.SuspendLayout();
            this.pnl_LoadImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSignature)).BeginInit();
            this.pnl_Finish.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            resources.ApplyResources(this.guna2Panel1, "guna2Panel1");
            this.guna2Panel1.Controls.Add(this.tableLayoutPanel2);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.guna2Panel1.Name = "guna2Panel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.Controls.Add(this.btnLoadSignature, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDraw, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGenerate, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // btnLoadSignature
            // 
            resources.ApplyResources(this.btnLoadSignature, "btnLoadSignature");
            this.btnLoadSignature.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnLoadSignature.CheckedState.BorderThickness = 0;
            this.btnLoadSignature.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnLoadSignature.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btnLoadSignature.CheckedState.InnerOffset = -4;
            this.btnLoadSignature.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadSignature.Name = "btnLoadSignature";
            this.btnLoadSignature.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnLoadSignature.UncheckedState.BorderThickness = 2;
            this.btnLoadSignature.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnLoadSignature.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.btnLoadSignature.CheckedChanged += new System.EventHandler(this.btnLoadSignature_CheckedChanged);
            // 
            // btnDraw
            // 
            resources.ApplyResources(this.btnDraw, "btnDraw");
            this.btnDraw.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDraw.CheckedState.BorderThickness = 0;
            this.btnDraw.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDraw.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btnDraw.CheckedState.InnerOffset = -4;
            this.btnDraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnDraw.UncheckedState.BorderThickness = 2;
            this.btnDraw.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnDraw.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.btnDraw.CheckedChanged += new System.EventHandler(this.btnDraw_CheckedChanged);
            // 
            // btnGenerate
            // 
            resources.ApplyResources(this.btnGenerate, "btnGenerate");
            this.btnGenerate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnGenerate.CheckedState.BorderThickness = 0;
            this.btnGenerate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnGenerate.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btnGenerate.CheckedState.InnerOffset = -4;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnGenerate.UncheckedState.BorderThickness = 2;
            this.btnGenerate.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnGenerate.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.btnGenerate.CheckedChanged += new System.EventHandler(this.btnGenerate_CheckedChanged);
            // 
            // pnl_name
            // 
            resources.ApplyResources(this.pnl_name, "pnl_name");
            this.pnl_name.Controls.Add(this.guna2TextBox1);
            this.pnl_name.Controls.Add(this.label1);
            this.pnl_name.Name = "pnl_name";
            // 
            // guna2TextBox1
            // 
            resources.ApplyResources(this.guna2TextBox1, "guna2TextBox1");
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pnl_LoadImage
            // 
            resources.ApplyResources(this.pnl_LoadImage, "pnl_LoadImage");
            this.pnl_LoadImage.Controls.Add(this.imgSignature);
            this.pnl_LoadImage.FillColor = System.Drawing.Color.Transparent;
            this.pnl_LoadImage.Name = "pnl_LoadImage";
            // 
            // imgSignature
            // 
            resources.ApplyResources(this.imgSignature, "imgSignature");
            this.imgSignature.ImageRotate = 0F;
            this.imgSignature.Name = "imgSignature";
            this.imgSignature.TabStop = false;
            this.imgSignature.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Paint_Paint);
            this.imgSignature.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Paint_MouseDown);
            this.imgSignature.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Paint_MouseMove);
            // 
            // pnl_Finish
            // 
            resources.ApplyResources(this.pnl_Finish, "pnl_Finish");
            this.pnl_Finish.Controls.Add(this.tableLayoutPanel1);
            this.pnl_Finish.Name = "pnl_Finish";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFinish, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.AutoRoundedCorners = true;
            this.btnClear.BorderRadius = 24;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(55)))), ((int)(((byte)(167)))));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Name = "btnClear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFinish
            // 
            resources.ApplyResources(this.btnFinish, "btnFinish");
            this.btnFinish.AutoRoundedCorners = true;
            this.btnFinish.BorderRadius = 24;
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFinish.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFinish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFinish.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(55)))), ((int)(((byte)(167)))));
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // guna2Button1
            // 
            resources.ApplyResources(this.guna2Button1, "guna2Button1");
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // frmDigitalSignature
            // 
            resources.ApplyResources(this, "$this");
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.pnl_Finish);
            this.Controls.Add(this.pnl_LoadImage);
            this.Controls.Add(this.pnl_name);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmDigitalSignature";
            this.Resize += new System.EventHandler(this.frmDigitalSignature_Resize);
            this.guna2Panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnl_name.ResumeLayout(false);
            this.pnl_name.PerformLayout();
            this.pnl_LoadImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgSignature)).EndInit();
            this.pnl_Finish.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2RadioButton btnDraw;
        private Guna.UI2.WinForms.Guna2RadioButton btnGenerate;
        private Guna.UI2.WinForms.Guna2Panel pnl_name;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2RadioButton btnLoadSignature;
        private Guna.UI2.WinForms.Guna2Panel pnl_LoadImage;
        private Guna.UI2.WinForms.Guna2PictureBox imgSignature;
        private Guna.UI2.WinForms.Guna2Panel pnl_Finish;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnFinish;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}