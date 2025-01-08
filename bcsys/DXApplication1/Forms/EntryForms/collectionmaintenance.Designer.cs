namespace bcsys.Forms.EntryForms
{
	partial class collectionmaintenance
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(collectionmaintenance));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnGo = new System.Windows.Forms.ToolStripButton();
			this.Label2 = new System.Windows.Forms.Label();
			this.cbteller = new System.Windows.Forms.ComboBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.dgv = new System.Windows.Forms.DataGridView();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.tsbCancel = new System.Windows.Forms.ToolStripButton();
			this.cvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cv1cntr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tsbClose = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.toolStrip2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGo});
			this.toolStrip1.Location = new System.Drawing.Point(372, 2);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(54, 25);
			this.toolStrip1.TabIndex = 314;
			this.toolStrip1.TabStop = true;
			this.toolStrip1.Text = "Receiving Menu";
			// 
			// btnGo
			// 
			this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
			this.btnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(42, 22);
			this.btnGo.Text = "&Go";
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click_1);
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(189, 7);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(69, 13);
			this.Label2.TabIndex = 313;
			this.Label2.Text = "Select Teller:";
			// 
			// cbteller
			// 
			this.cbteller.FormattingEnabled = true;
			this.cbteller.Location = new System.Drawing.Point(262, 3);
			this.cbteller.Name = "cbteller";
			this.cbteller.Size = new System.Drawing.Size(103, 21);
			this.cbteller.TabIndex = 1;
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(6, 6);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(83, 13);
			this.Label1.TabIndex = 311;
			this.Label1.Text = "Collection Date:";
			// 
			// dtpDate
			// 
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDate.Location = new System.Drawing.Point(94, 3);
			this.dtpDate.MinDate = new System.DateTime(1945, 1, 1, 0, 0, 0, 0);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(89, 21);
			this.dtpDate.TabIndex = 0;
			// 
			// dgv
			// 
			this.dgv.AllowDrop = true;
			this.dgv.AllowUserToAddRows = false;
			this.dgv.AllowUserToDeleteRows = false;
			this.dgv.AllowUserToResizeColumns = false;
			this.dgv.AllowUserToResizeRows = false;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cvDate,
            this.Column14,
            this.Column15,
            this.cvAmount,
            this.pcode,
            this.cv1cntr});
			this.dgv.Location = new System.Drawing.Point(0, 26);
			this.dgv.MultiSelect = false;
			this.dgv.Name = "dgv";
			this.dgv.ReadOnly = true;
			this.dgv.RowHeadersVisible = false;
			this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv.Size = new System.Drawing.Size(434, 492);
			this.dgv.TabIndex = 3;
			// 
			// toolStrip2
			// 
			this.toolStrip2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCancel,
            this.tsbClose});
			this.toolStrip2.Location = new System.Drawing.Point(219, 521);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(233, 25);
			this.toolStrip2.TabIndex = 4;
			this.toolStrip2.TabStop = true;
			this.toolStrip2.Text = "Receiving Menu";
			// 
			// tsbCancel
			// 
			this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
			this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbCancel.Name = "tsbCancel";
			this.tsbCancel.Size = new System.Drawing.Size(134, 22);
			this.tsbCancel.Text = "&Cancel Selected OR?";
			this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
			// 
			// cvDate
			// 
			dataGridViewCellStyle6.Format = "d";
			dataGridViewCellStyle6.NullValue = null;
			this.cvDate.DefaultCellStyle = dataGridViewCellStyle6;
			this.cvDate.HeaderText = "Date";
			this.cvDate.Name = "cvDate";
			this.cvDate.ReadOnly = true;
			this.cvDate.Width = 70;
			// 
			// Column14
			// 
			this.Column14.HeaderText = "Orno";
			this.Column14.Name = "Column14";
			this.Column14.ReadOnly = true;
			this.Column14.Width = 70;
			// 
			// Column15
			// 
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Column15.DefaultCellStyle = dataGridViewCellStyle7;
			this.Column15.HeaderText = "Consumer";
			this.Column15.Name = "Column15";
			this.Column15.ReadOnly = true;
			this.Column15.Width = 200;
			// 
			// cvAmount
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle8.Format = "N2";
			dataGridViewCellStyle8.NullValue = "0.00";
			this.cvAmount.DefaultCellStyle = dataGridViewCellStyle8;
			this.cvAmount.HeaderText = "Amount";
			this.cvAmount.Name = "cvAmount";
			this.cvAmount.ReadOnly = true;
			this.cvAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cvAmount.Width = 70;
			// 
			// pcode
			// 
			this.pcode.HeaderText = "mascode";
			this.pcode.Name = "pcode";
			this.pcode.ReadOnly = true;
			this.pcode.Visible = false;
			// 
			// cv1cntr
			// 
			this.cv1cntr.HeaderText = "cntr";
			this.cv1cntr.Name = "cv1cntr";
			this.cv1cntr.ReadOnly = true;
			this.cv1cntr.Visible = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.toolStrip2);
			this.groupBox1.Controls.Add(this.dgv);
			this.groupBox1.Location = new System.Drawing.Point(6, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(442, 555);
			this.groupBox1.TabIndex = 317;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Collection List";
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(94, 33);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(108, 21);
			this.tbSearch.TabIndex = 2;
			this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 13);
			this.label3.TabIndex = 319;
			this.label3.Text = "Enter OR No.:";
			// 
			// tsbClose
			// 
			this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
			this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbClose.Name = "tsbClose";
			this.tsbClose.Size = new System.Drawing.Size(56, 22);
			this.tsbClose.Text = "Close";
			this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click_1);
			// 
			// collectionmaintenance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(446, 607);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbSearch);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.cbteller);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.dtpDate);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "collectionmaintenance";
			this.Text = "collectionmaintenance";
			this.Load += new System.EventHandler(this.collectionmaintenance_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.ToolStrip toolStrip1;
		internal System.Windows.Forms.ToolStripButton btnGo;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.ComboBox cbteller;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.DateTimePicker dtpDate;
		internal System.Windows.Forms.DataGridView dgv;
		private System.Windows.Forms.DataGridViewTextBoxColumn cvDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
		private System.Windows.Forms.DataGridViewTextBoxColumn cvAmount;
		private System.Windows.Forms.DataGridViewTextBoxColumn pcode;
		private System.Windows.Forms.DataGridViewTextBoxColumn cv1cntr;
		internal System.Windows.Forms.ToolStrip toolStrip2;
		internal System.Windows.Forms.ToolStripButton tsbCancel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ToolStripButton tsbClose;
	}
}