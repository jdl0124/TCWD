namespace eguidanceV2.Forms
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hyperLinkEdit1 = new DevExpress.XtraEditors.HyperLinkEdit();
            this.hyperLinkEdit2 = new DevExpress.XtraEditors.HyperLinkEdit();
            ((System.ComponentModel.ISupportInitialize)(this.mqbar1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpwd
            // 
            this.tbpwd.Location = new System.Drawing.Point(83, 105);
            this.tbpwd.Name = "tbpwd";
            this.tbpwd.Size = new System.Drawing.Size(217, 21);
            this.tbpwd.TabIndex = 1;
            this.tbpwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbpwd_KeyPress);
            // 
            // btnok
            // 
            this.btnok.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnok.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnok.ImageOptions.SvgImage")));
            this.btnok.Location = new System.Drawing.Point(83, 131);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(97, 38);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "Login";
            this.btnok.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btncancel
            // 
            this.btncancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btncancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btncancel.ImageOptions.SvgImage")));
            this.btncancel.Location = new System.Drawing.Point(186, 131);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(114, 38);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Username :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 108);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Password :";
            // 
            // tbuser
            // 
            this.tbuser.Location = new System.Drawing.Point(83, 77);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(217, 21);
            this.tbuser.TabIndex = 0;
            this.tbuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbuser_KeyPress);
            // 
            // mqbar1
            // 
            this.mqbar1.EditValue = "Please wait...";
            this.mqbar1.Location = new System.Drawing.Point(1, 198);
            this.mqbar1.Name = "mqbar1";
            this.mqbar1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mqbar1.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.mqbar1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.mqbar1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.mqbar1.Properties.MarqueeAnimationSpeed = 10;
            this.mqbar1.Properties.ProgressAnimationMode = DevExpress.Utils.Drawing.ProgressAnimationMode.Cycle;
            this.mqbar1.Properties.ShowTitle = true;
            this.mqbar1.Size = new System.Drawing.Size(323, 13);
            this.mqbar1.TabIndex = 8;
            this.mqbar1.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.mqbar1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::eguidanceV2.Properties.Resources.eguidancelogo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // hyperLinkEdit1
            // 
            this.hyperLinkEdit1.EditValue = "Register";
            this.hyperLinkEdit1.Location = new System.Drawing.Point(80, 175);
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
            this.hyperLinkEdit2.Location = new System.Drawing.Point(186, 175);
            this.hyperLinkEdit2.Name = "hyperLinkEdit2";
            this.hyperLinkEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.hyperLinkEdit2.Size = new System.Drawing.Size(100, 18);
            this.hyperLinkEdit2.TabIndex = 10;
            this.hyperLinkEdit2.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.hyperLinkEdit2_OpenLink);
            // 
            // frmlogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 211);
            this.Controls.Add(this.hyperLinkEdit2);
            this.Controls.Add(this.hyperLinkEdit1);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.mqbar1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.tbpwd);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::eguidanceV2.Properties.Resources.egadmin;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eGuidanceV2 - LOGIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmlogin_FormClosing);
            this.Load += new System.EventHandler(this.frmlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mqbar1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.MarqueeProgressBarControl mqbar1;
        private System.Windows.Forms.TextBox tbpwd;
        private DevExpress.XtraEditors.SimpleButton btnok;
        private DevExpress.XtraEditors.SimpleButton btncancel;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox tbuser;
        private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEdit1;
        private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEdit2;
    }
}