namespace bcsys.Forms.EntryForms
{
    partial class penalty
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(penalty));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tsMenu = new System.Windows.Forms.ToolStrip();
			this.btnGo = new System.Windows.Forms.ToolStripButton();
			this.btnPost = new System.Windows.Forms.ToolStripButton();
			this.btnClose = new System.Windows.Forms.ToolStripButton();
			this.pb1 = new System.Windows.Forms.ProgressBar();
			this.dgvP = new System.Windows.Forms.DataGridView();
			this.gb1 = new System.Windows.Forms.GroupBox();
			this.Acctno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Meterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Previous = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.duedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Present = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Others = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mascode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.msize = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtpPDate = new System.Windows.Forms.DateTimePicker();
			this.Label2 = new System.Windows.Forms.Label();
			this.tsMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvP)).BeginInit();
			this.gb1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tsMenu
			// 
			this.tsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tsMenu.Dock = System.Windows.Forms.DockStyle.None;
			this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGo,
            this.btnPost,
            this.btnClose});
			this.tsMenu.Location = new System.Drawing.Point(678, 9);
			this.tsMenu.Name = "tsMenu";
			this.tsMenu.Size = new System.Drawing.Size(160, 25);
			this.tsMenu.TabIndex = 228;
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
			// btnPost
			// 
			this.btnPost.Enabled = false;
			this.btnPost.Image = ((System.Drawing.Image)(resources.GetObject("btnPost.Image")));
			this.btnPost.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnPost.Name = "btnPost";
			this.btnPost.Size = new System.Drawing.Size(50, 22);
			this.btnPost.Text = "&Post";
			this.btnPost.Click += new System.EventHandler(this.btnPrint_Click);
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
			// pb1
			// 
			this.pb1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pb1.Location = new System.Drawing.Point(0, 566);
			this.pb1.Name = "pb1";
			this.pb1.Size = new System.Drawing.Size(836, 15);
			this.pb1.TabIndex = 229;
			// 
			// dgvP
			// 
			this.dgvP.AllowUserToAddRows = false;
			this.dgvP.AllowUserToDeleteRows = false;
			this.dgvP.AllowUserToResizeRows = false;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.dgvP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Acctno,
            this.DataGridViewTextBoxColumn3,
            this.Meterno,
            this.BP,
            this.Previous,
            this.duedate,
            this.Present,
            this.cum,
            this.Amount,
            this.Others,
            this.category,
            this.status,
            this.mascode,
            this.msize});
			this.dgvP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvP.Location = new System.Drawing.Point(3, 16);
			this.dgvP.Name = "dgvP";
			this.dgvP.RowHeadersVisible = false;
			this.dgvP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvP.Size = new System.Drawing.Size(823, 502);
			this.dgvP.TabIndex = 234;
			// 
			// gb1
			// 
			this.gb1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.gb1.Controls.Add(this.dgvP);
			this.gb1.Location = new System.Drawing.Point(5, 39);
			this.gb1.Name = "gb1";
			this.gb1.Size = new System.Drawing.Size(829, 521);
			this.gb1.TabIndex = 235;
			this.gb1.TabStop = false;
			this.gb1.Text = "Penalty Details";
			// 
			// Acctno
			// 
			this.Acctno.HeaderText = "Acctno";
			this.Acctno.Name = "Acctno";
			this.Acctno.ReadOnly = true;
			this.Acctno.Width = 60;
			// 
			// DataGridViewTextBoxColumn3
			// 
			this.DataGridViewTextBoxColumn3.HeaderText = "Consumer Name";
			this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
			this.DataGridViewTextBoxColumn3.ReadOnly = true;
			this.DataGridViewTextBoxColumn3.ToolTipText = "Double Click to show the average.";
			this.DataGridViewTextBoxColumn3.Width = 250;
			// 
			// Meterno
			// 
			this.Meterno.HeaderText = "Meterno";
			this.Meterno.Name = "Meterno";
			this.Meterno.ReadOnly = true;
			this.Meterno.Width = 70;
			// 
			// BP
			// 
			this.BP.HeaderText = "bp";
			this.BP.Name = "BP";
			this.BP.Width = 60;
			// 
			// Previous
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.Format = "N0";
			this.Previous.DefaultCellStyle = dataGridViewCellStyle10;
			this.Previous.HeaderText = "Previous";
			this.Previous.Name = "Previous";
			this.Previous.ReadOnly = true;
			this.Previous.Width = 60;
			// 
			// duedate
			// 
			this.duedate.HeaderText = "duedate";
			this.duedate.Name = "duedate";
			this.duedate.Width = 80;
			// 
			// Present
			// 
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.Format = "N0";
			this.Present.DefaultCellStyle = dataGridViewCellStyle11;
			this.Present.HeaderText = "Present";
			this.Present.Name = "Present";
			this.Present.Width = 60;
			// 
			// cum
			// 
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.Format = "N0";
			this.cum.DefaultCellStyle = dataGridViewCellStyle12;
			this.cum.HeaderText = "CumUsed";
			this.cum.Name = "cum";
			this.cum.Width = 50;
			// 
			// Amount
			// 
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle13.Format = "N2";
			this.Amount.DefaultCellStyle = dataGridViewCellStyle13;
			this.Amount.HeaderText = "BillAmt";
			this.Amount.Name = "Amount";
			this.Amount.Width = 60;
			// 
			// Others
			// 
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle14.Format = "N2";
			this.Others.DefaultCellStyle = dataGridViewCellStyle14;
			this.Others.HeaderText = "Penalty";
			this.Others.Name = "Others";
			this.Others.Width = 50;
			// 
			// category
			// 
			this.category.HeaderText = "classcode";
			this.category.Name = "category";
			this.category.ReadOnly = true;
			this.category.Visible = false;
			// 
			// status
			// 
			this.status.HeaderText = "status";
			this.status.Name = "status";
			this.status.Visible = false;
			// 
			// mascode
			// 
			this.mascode.HeaderText = "mascode";
			this.mascode.Name = "mascode";
			this.mascode.Visible = false;
			// 
			// msize
			// 
			this.msize.HeaderText = "msize";
			this.msize.Name = "msize";
			this.msize.Visible = false;
			// 
			// dtpPDate
			// 
			this.dtpPDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpPDate.Location = new System.Drawing.Point(78, 9);
			this.dtpPDate.Name = "dtpPDate";
			this.dtpPDate.Size = new System.Drawing.Size(99, 20);
			this.dtpPDate.TabIndex = 237;
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(4, 12);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(71, 13);
			this.Label2.TabIndex = 238;
			this.Label2.Text = "Penalty Date:";
			// 
			// penalty
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(836, 581);
			this.Controls.Add(this.dtpPDate);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.gb1);
			this.Controls.Add(this.pb1);
			this.Controls.Add(this.tsMenu);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "penalty";
			this.Text = "Penalty/Surcharge Processing";
			this.Load += new System.EventHandler(this.penalty_Load);
			this.tsMenu.ResumeLayout(false);
			this.tsMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvP)).EndInit();
			this.gb1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip tsMenu;
        internal System.Windows.Forms.ToolStripButton btnGo;
        internal System.Windows.Forms.ToolStripButton btnPost;
        internal System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ProgressBar pb1;
		internal System.Windows.Forms.DataGridView dgvP;
		private System.Windows.Forms.GroupBox gb1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Acctno;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Meterno;
		private System.Windows.Forms.DataGridViewTextBoxColumn BP;
		private System.Windows.Forms.DataGridViewTextBoxColumn Previous;
		private System.Windows.Forms.DataGridViewTextBoxColumn duedate;
		private System.Windows.Forms.DataGridViewTextBoxColumn Present;
		private System.Windows.Forms.DataGridViewTextBoxColumn cum;
		private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
		private System.Windows.Forms.DataGridViewTextBoxColumn Others;
		private System.Windows.Forms.DataGridViewTextBoxColumn category;
		private System.Windows.Forms.DataGridViewTextBoxColumn status;
		private System.Windows.Forms.DataGridViewTextBoxColumn mascode;
		private System.Windows.Forms.DataGridViewTextBoxColumn msize;
		internal System.Windows.Forms.DateTimePicker dtpPDate;
		internal System.Windows.Forms.Label Label2;
	}
}