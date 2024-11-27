namespace eguidanceV2.Forms
{
    partial class frmloading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmloading));
            this.pgbar1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.labeloading = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pgbar1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pgbar1
            // 
            this.pgbar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbar1.EditValue = 0;
            this.pgbar1.Location = new System.Drawing.Point(4, 24);
            this.pgbar1.Name = "pgbar1";
            this.pgbar1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgbar1.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.Gold;
            this.pgbar1.Properties.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.pgbar1.Properties.LookAndFeel.SkinName = "Office 2019 Colorful";
            this.pgbar1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pgbar1.Properties.MarqueeAnimationSpeed = 10;
            this.pgbar1.Properties.MarqueeWidth = 150;
            this.pgbar1.Size = new System.Drawing.Size(332, 14);
            this.pgbar1.TabIndex = 9;
            // 
            // labeloading
            // 
            this.labeloading.Location = new System.Drawing.Point(132, 5);
            this.labeloading.Name = "labeloading";
            this.labeloading.Size = new System.Drawing.Size(66, 13);
            this.labeloading.TabIndex = 10;
            this.labeloading.Text = "Please wait...";
            // 
            // frmloading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 49);
            this.Controls.Add(this.labeloading);
            this.Controls.Add(this.pgbar1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmloading";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.SplashImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmloading.SplashImageOptions.Image")));
            this.Text = "Please wait loading request...";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmloading_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pgbar1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.MarqueeProgressBarControl pgbar1;
        public DevExpress.XtraEditors.LabelControl labeloading;
    }
}
