namespace bcsys.Forms.EntryForms
{
    partial class summaryReports
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(summaryReports));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gbClass = new System.Windows.Forms.GroupBox();
			this.xtc = new DevExpress.XtraTab.XtraTabControl();
			this.xtp1 = new DevExpress.XtraTab.XtraTabPage();
			this.rmv = new RowMergeView();
			this.xtp2 = new DevExpress.XtraTab.XtraTabPage();
			this.rmvactive = new RowMergeView();
			this.xtp3 = new DevExpress.XtraTab.XtraTabPage();
			this.rmvinactive = new RowMergeView();
			this.gbbillsum = new System.Windows.Forms.GroupBox();
			this.rmvbilling = new RowMergeView();
			this.Label1 = new System.Windows.Forms.Label();
			this.dtpBP = new System.Windows.Forms.DateTimePicker();
			this.tsMenu = new System.Windows.Forms.ToolStrip();
			this.btnGo = new System.Windows.Forms.ToolStripButton();
			this.btnDPrint = new System.Windows.Forms.ToolStripDropDownButton();
			this.DisconnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CurrentCollectiblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ConsumerIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnPrint = new System.Windows.Forms.ToolStripButton();
			this.btnClose = new System.Windows.Forms.ToolStripButton();
			this.gbClass.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.xtc)).BeginInit();
			this.xtc.SuspendLayout();
			this.xtp1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rmv)).BeginInit();
			this.xtp2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rmvactive)).BeginInit();
			this.xtp3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rmvinactive)).BeginInit();
			this.gbbillsum.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rmvbilling)).BeginInit();
			this.tsMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbClass
			// 
			this.gbClass.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.gbClass.Controls.Add(this.xtc);
			this.gbClass.Location = new System.Drawing.Point(5, 298);
			this.gbClass.Name = "gbClass";
			this.gbClass.Size = new System.Drawing.Size(786, 326);
			this.gbClass.TabIndex = 45;
			this.gbClass.TabStop = false;
			this.gbClass.Text = "Consumer Classification List";
			// 
			// xtc
			// 
			this.xtc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xtc.Location = new System.Drawing.Point(3, 16);
			this.xtc.MaxTabPageWidth = 50;
			this.xtc.Name = "xtc";
			this.xtc.SelectedTabPage = this.xtp1;
			this.xtc.Size = new System.Drawing.Size(780, 307);
			this.xtc.TabIndex = 47;
			this.xtc.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtp1,
            this.xtp2,
            this.xtp3});
			// 
			// xtp1
			// 
			this.xtp1.Controls.Add(this.rmv);
			this.xtp1.MaxTabPageWidth = 50;
			this.xtp1.Name = "xtp1";
			this.xtp1.Size = new System.Drawing.Size(778, 282);
			this.xtp1.Text = "All";
			// 
			// rmv
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.rmv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.rmv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.rmv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rmv.Location = new System.Drawing.Point(0, 0);
			this.rmv.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
			this.rmv.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("rmv.MergeColumnNames")));
			this.rmv.Name = "rmv";
			this.rmv.ReadOnly = true;
			this.rmv.RowHeadersWidth = 20;
			this.rmv.RowTemplate.Height = 23;
			this.rmv.Size = new System.Drawing.Size(778, 282);
			this.rmv.TabIndex = 47;
			// 
			// xtp2
			// 
			this.xtp2.Controls.Add(this.rmvactive);
			this.xtp2.Name = "xtp2";
			this.xtp2.Size = new System.Drawing.Size(778, 282);
			this.xtp2.Text = "Active";
			// 
			// rmvactive
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.rmvactive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.rmvactive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.rmvactive.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rmvactive.Location = new System.Drawing.Point(0, 0);
			this.rmvactive.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
			this.rmvactive.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("rmvactive.MergeColumnNames")));
			this.rmvactive.Name = "rmvactive";
			this.rmvactive.ReadOnly = true;
			this.rmvactive.RowHeadersWidth = 20;
			this.rmvactive.RowTemplate.Height = 23;
			this.rmvactive.Size = new System.Drawing.Size(778, 282);
			this.rmvactive.TabIndex = 47;
			// 
			// xtp3
			// 
			this.xtp3.Controls.Add(this.rmvinactive);
			this.xtp3.Name = "xtp3";
			this.xtp3.Size = new System.Drawing.Size(778, 282);
			this.xtp3.Text = "InActive";
			// 
			// rmvinactive
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F);
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.rmvinactive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.rmvinactive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.rmvinactive.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rmvinactive.Location = new System.Drawing.Point(0, 0);
			this.rmvinactive.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
			this.rmvinactive.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("rmvinactive.MergeColumnNames")));
			this.rmvinactive.Name = "rmvinactive";
			this.rmvinactive.ReadOnly = true;
			this.rmvinactive.RowHeadersWidth = 20;
			this.rmvinactive.RowTemplate.Height = 23;
			this.rmvinactive.Size = new System.Drawing.Size(778, 282);
			this.rmvinactive.TabIndex = 47;
			// 
			// gbbillsum
			// 
			this.gbbillsum.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.gbbillsum.Controls.Add(this.rmvbilling);
			this.gbbillsum.Location = new System.Drawing.Point(6, 31);
			this.gbbillsum.Name = "gbbillsum";
			this.gbbillsum.Size = new System.Drawing.Size(786, 261);
			this.gbbillsum.TabIndex = 46;
			this.gbbillsum.TabStop = false;
			this.gbbillsum.Text = "Billing Summary";
			// 
			// rmvbilling
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F);
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.rmvbilling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.rmvbilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.rmvbilling.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rmvbilling.Location = new System.Drawing.Point(3, 16);
			this.rmvbilling.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
			this.rmvbilling.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("rmvbilling.MergeColumnNames")));
			this.rmvbilling.Name = "rmvbilling";
			this.rmvbilling.ReadOnly = true;
			this.rmvbilling.RowHeadersWidth = 20;
			this.rmvbilling.RowTemplate.Height = 23;
			this.rmvbilling.Size = new System.Drawing.Size(780, 242);
			this.rmvbilling.TabIndex = 48;
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(5, 8);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(70, 13);
			this.Label1.TabIndex = 228;
			this.Label1.Text = "Billing Period:";
			// 
			// dtpBP
			// 
			this.dtpBP.Checked = false;
			this.dtpBP.CustomFormat = "MMMMyyyy";
			this.dtpBP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpBP.Location = new System.Drawing.Point(80, 5);
			this.dtpBP.Name = "dtpBP";
			this.dtpBP.ShowCheckBox = true;
			this.dtpBP.Size = new System.Drawing.Size(132, 20);
			this.dtpBP.TabIndex = 227;
			// 
			// tsMenu
			// 
			this.tsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tsMenu.Dock = System.Windows.Forms.DockStyle.None;
			this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGo,
            this.btnDPrint,
            this.btnPrint,
            this.btnClose});
			this.tsMenu.Location = new System.Drawing.Point(244, 5);
			this.tsMenu.Name = "tsMenu";
			this.tsMenu.Size = new System.Drawing.Size(264, 25);
			this.tsMenu.TabIndex = 229;
			this.tsMenu.TabStop = true;
			this.tsMenu.Text = "Receiving Menu";
			// 
			// btnGo
			// 
			this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
			this.btnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(42, 22);
			this.btnGo.Text = "&Go";
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// btnDPrint
			// 
			this.btnDPrint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DisconnectionToolStripMenuItem,
            this.CurrentCollectiblesToolStripMenuItem,
            this.ConsumerIndexToolStripMenuItem});
			this.btnDPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnDPrint.Image")));
			this.btnDPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDPrint.Name = "btnDPrint";
			this.btnDPrint.Size = new System.Drawing.Size(71, 22);
			this.btnDPrint.Text = "Listing";
			this.btnDPrint.Visible = false;
			// 
			// DisconnectionToolStripMenuItem
			// 
			this.DisconnectionToolStripMenuItem.Name = "DisconnectionToolStripMenuItem";
			this.DisconnectionToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.DisconnectionToolStripMenuItem.Text = "Disconnection";
			// 
			// CurrentCollectiblesToolStripMenuItem
			// 
			this.CurrentCollectiblesToolStripMenuItem.Name = "CurrentCollectiblesToolStripMenuItem";
			this.CurrentCollectiblesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.CurrentCollectiblesToolStripMenuItem.Text = "Current Collectibles";
			// 
			// ConsumerIndexToolStripMenuItem
			// 
			this.ConsumerIndexToolStripMenuItem.Name = "ConsumerIndexToolStripMenuItem";
			this.ConsumerIndexToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.ConsumerIndexToolStripMenuItem.Text = "Consumer Index";
			// 
			// btnPrint
			// 
			this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
			this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(52, 22);
			this.btnPrint.Text = "&Print";
			this.btnPrint.Visible = false;
			// 
			// btnClose
			// 
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(56, 22);
			this.btnClose.Text = "&Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// summaryReports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(798, 627);
			this.Controls.Add(this.tsMenu);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.dtpBP);
			this.Controls.Add(this.gbbillsum);
			this.Controls.Add(this.gbClass);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "summaryReports";
			this.Text = "Summary";
			this.Load += new System.EventHandler(this.summaryreports_Load);
			this.gbClass.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.xtc)).EndInit();
			this.xtc.ResumeLayout(false);
			this.xtp1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.rmv)).EndInit();
			this.xtp2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.rmvactive)).EndInit();
			this.xtp3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.rmvinactive)).EndInit();
			this.gbbillsum.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.rmvbilling)).EndInit();
			this.tsMenu.ResumeLayout(false);
			this.tsMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.GroupBox gbClass;
		private DevExpress.XtraTab.XtraTabControl xtc;
		private DevExpress.XtraTab.XtraTabPage xtp1;
		private RowMergeView rmv;
		private DevExpress.XtraTab.XtraTabPage xtp2;
		private RowMergeView rmvactive;
		private DevExpress.XtraTab.XtraTabPage xtp3;
		private RowMergeView rmvinactive;
		private System.Windows.Forms.GroupBox gbbillsum;
		private RowMergeView rmvbilling;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.DateTimePicker dtpBP;
		internal System.Windows.Forms.ToolStrip tsMenu;
		internal System.Windows.Forms.ToolStripButton btnGo;
		internal System.Windows.Forms.ToolStripDropDownButton btnDPrint;
		internal System.Windows.Forms.ToolStripMenuItem DisconnectionToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem CurrentCollectiblesToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ConsumerIndexToolStripMenuItem;
		internal System.Windows.Forms.ToolStripButton btnPrint;
		internal System.Windows.Forms.ToolStripButton btnClose;
	}
}