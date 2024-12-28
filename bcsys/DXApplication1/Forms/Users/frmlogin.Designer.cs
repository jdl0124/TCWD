namespace bcsys.Forms
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.tbpwd = new System.Windows.Forms.TextBox();
            this.btnok = new DevExpress.XtraEditors.SimpleButton();
            this.btncancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.mqbar1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.hyperLinkEdit1 = new DevExpress.XtraEditors.HyperLinkEdit();
            this.hyperLinkEdit2 = new DevExpress.XtraEditors.HyperLinkEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mqbar1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpwd
            // 
            this.tbpwd.Location = new System.Drawing.Point(199, 42);
            this.tbpwd.Name = "tbpwd";
            this.tbpwd.Size = new System.Drawing.Size(133, 21);
            this.tbpwd.TabIndex = 1;
            this.tbpwd.TextChanged += new System.EventHandler(this.tbpwd_TextChanged);
            this.tbpwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbpwd_KeyPress);
            // 
            // btnok
            // 
            this.btnok.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnok.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnok.ImageOptions.SvgImage")));
            this.btnok.Location = new System.Drawing.Point(132, 69);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(90, 37);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "Login";
            this.btnok.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btncancel
            // 
            this.btncancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btncancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btncancel.ImageOptions.SvgImage")));
            this.btncancel.Location = new System.Drawing.Point(230, 69);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(109, 37);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(138, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Username :";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(140, 45);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Password :";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // tbuser
            // 
            this.tbuser.Location = new System.Drawing.Point(199, 14);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(133, 21);
            this.tbuser.TabIndex = 0;
            this.tbuser.TextChanged += new System.EventHandler(this.tbuser_TextChanged);
            this.tbuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbuser_KeyPress);
            // 
            // mqbar1
            // 
            this.mqbar1.EditValue = "Please wait...";
            this.mqbar1.Location = new System.Drawing.Point(14, 135);
            this.mqbar1.Name = "mqbar1";
            this.mqbar1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mqbar1.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.mqbar1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.mqbar1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.mqbar1.Properties.MarqueeAnimationSpeed = 10;
            this.mqbar1.Properties.ProgressAnimationMode = DevExpress.Utils.Drawing.ProgressAnimationMode.Cycle;
            this.mqbar1.Properties.ShowTitle = true;
            this.mqbar1.Size = new System.Drawing.Size(338, 13);
            this.mqbar1.TabIndex = 8;
            this.mqbar1.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.mqbar1.Visible = false;
            // 
            // hyperLinkEdit1
            // 
            this.hyperLinkEdit1.EditValue = "Register";
            this.hyperLinkEdit1.Location = new System.Drawing.Point(93, 112);
            this.hyperLinkEdit1.Name = "hyperLinkEdit1";
            this.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.hyperLinkEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hyperLinkEdit1.Size = new System.Drawing.Size(100, 18);
            this.hyperLinkEdit1.TabIndex = 9;
            this.hyperLinkEdit1.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.hyperLinkEdit1_OpenLink);
            // 
            // hyperLinkEdit2
            // 
            this.hyperLinkEdit2.EditValue = "Forgot Password?";
            this.hyperLinkEdit2.Location = new System.Drawing.Point(199, 112);
            this.hyperLinkEdit2.Name = "hyperLinkEdit2";
            this.hyperLinkEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.hyperLinkEdit2.Size = new System.Drawing.Size(100, 18);
            this.hyperLinkEdit2.TabIndex = 10;
            this.hyperLinkEdit2.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.hyperLinkEdit2_OpenLink);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(311, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pb
            // 
            this.pb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb.BackgroundImage")));
            this.pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb.InitialImage = null;
            this.pb.Location = new System.Drawing.Point(1, 11);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(128, 106);
            this.pb.TabIndex = 12;
            this.pb.TabStop = false;
            // 
            // frmlogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 151);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hyperLinkEdit2);
            this.Controls.Add(this.hyperLinkEdit1);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.mqbar1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.tbpwd);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmlogin.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing & Collection - LOGIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmlogin_FormClosing);
            this.Load += new System.EventHandler(this.frmlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mqbar1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.MarqueeProgressBarControl mqbar1;
        private System.Windows.Forms.TextBox tbpwd;
        private DevExpress.XtraEditors.SimpleButton btnok;
        private DevExpress.XtraEditors.SimpleButton btncancel;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox tbuser;
        private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEdit1;
        private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEdit2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pb;
	}
}