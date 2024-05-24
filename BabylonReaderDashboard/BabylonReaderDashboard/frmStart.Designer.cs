namespace BabylonReaderDashboard
{
    partial class frmStart
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
            this.frmSetting1 = new BabylonReaderDashboard.frmSetting();
            this.SuspendLayout();
            // 
            // frmSetting1
            // 
            this.frmSetting1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.frmSetting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmSetting1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmSetting1.Location = new System.Drawing.Point(0, 0);
            this.frmSetting1.Margin = new System.Windows.Forms.Padding(5);
            this.frmSetting1.Name = "frmSetting1";
            this.frmSetting1.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.frmSetting1.Size = new System.Drawing.Size(952, 570);
            this.frmSetting1.TabIndex = 0;
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 570);
            this.Controls.Add(this.frmSetting1);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "set Setting";
            this.ResumeLayout(false);

        }

        #endregion

        private frmSetting frmSetting1;
    }
}