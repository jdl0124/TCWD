namespace bcsys.Forms.EntryForms
{
    partial class consearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consearch));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsMerge = new System.Windows.Forms.ToolStrip();
            this.btnMerge = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.btnHide = new System.Windows.Forms.ToolStripButton();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.tsadd = new System.Windows.Forms.ToolStrip();
            this.tsbSaveC = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.Label4 = new System.Windows.Forms.Label();
            this.tbCustadd = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.tbCustname = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.tbNCustcode = new System.Windows.Forms.TextBox();
            this.lblTableName = new System.Windows.Forms.Label();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTo = new System.Windows.Forms.Label();
            this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCustNo = new System.Windows.Forms.TextBox();
            this.dgvConsumer = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbMerge = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbSelect = new System.Windows.Forms.ToolStripButton();
            this.tsbNewC = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.tbCustCode = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbReason = new System.Windows.Forms.TextBox();
            this.gbMerge = new System.Windows.Forms.GroupBox();
            this.tsMerge.SuspendLayout();
            this.gbAdd.SuspendLayout();
            this.tsadd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumer)).BeginInit();
            this.tsMenu.SuspendLayout();
            this.gbMerge.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMerge
            // 
            this.tsMerge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tsMerge.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMerge.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMerge,
            this.btnClear,
            this.btnHide});
            this.tsMerge.Location = new System.Drawing.Point(264, 128);
            this.tsMerge.Name = "tsMerge";
            this.tsMerge.Size = new System.Drawing.Size(118, 25);
            this.tsMerge.TabIndex = 108;
            this.tsMerge.Text = "Menu";
            // 
            // btnMerge
            // 
            this.btnMerge.Image = ((System.Drawing.Image)(resources.GetObject("btnMerge.Image")));
            this.btnMerge.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(79, 22);
            this.btnMerge.Text = "&Go Merge";
            this.btnMerge.ToolTipText = "Merge Customers";
            this.btnMerge.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(54, 22);
            this.btnClear.Text = "&Clear";
            // 
            // btnHide
            // 
            this.btnHide.Image = ((System.Drawing.Image)(resources.GetObject("btnHide.Image")));
            this.btnHide.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(52, 22);
            this.btnHide.Text = "&Hide";
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.HeaderText = "Territory";
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // gbAdd
            // 
            this.gbAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbAdd.Controls.Add(this.tsadd);
            this.gbAdd.Controls.Add(this.Label4);
            this.gbAdd.Controls.Add(this.tbCustadd);
            this.gbAdd.Controls.Add(this.Label3);
            this.gbAdd.Controls.Add(this.tbCustname);
            this.gbAdd.Controls.Add(this.Label2);
            this.gbAdd.Controls.Add(this.tbNCustcode);
            this.gbAdd.Location = new System.Drawing.Point(123, 86);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(387, 122);
            this.gbAdd.TabIndex = 116;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add New Customer";
            this.gbAdd.Visible = false;
            // 
            // tsadd
            // 
            this.tsadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tsadd.Dock = System.Windows.Forms.DockStyle.None;
            this.tsadd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSaveC,
            this.tsbExit});
            this.tsadd.Location = new System.Drawing.Point(275, 91);
            this.tsadd.Name = "tsadd";
            this.tsadd.Size = new System.Drawing.Size(109, 25);
            this.tsadd.TabIndex = 109;
            this.tsadd.Text = "Menu";
            // 
            // tsbSaveC
            // 
            this.tsbSaveC.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveC.Image")));
            this.tsbSaveC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveC.Name = "tsbSaveC";
            this.tsbSaveC.Size = new System.Drawing.Size(51, 22);
            this.tsbSaveC.Text = "Save";
            this.tsbSaveC.ToolTipText = "Save";
            // 
            // tsbExit
            // 
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(46, 22);
            this.tsbExit.Text = "Exit";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(5, 70);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 13);
            this.Label4.TabIndex = 11;
            this.Label4.Text = "Address:";
            // 
            // tbCustadd
            // 
            this.tbCustadd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCustadd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCustadd.Location = new System.Drawing.Point(93, 68);
            this.tbCustadd.MaxLength = 50;
            this.tbCustadd.Name = "tbCustadd";
            this.tbCustadd.Size = new System.Drawing.Size(287, 20);
            this.tbCustadd.TabIndex = 10;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 47);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(85, 13);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Customer Name:";
            // 
            // tbCustname
            // 
            this.tbCustname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCustname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCustname.Location = new System.Drawing.Point(93, 45);
            this.tbCustname.MaxLength = 50;
            this.tbCustname.Name = "tbCustname";
            this.tbCustname.Size = new System.Drawing.Size(287, 20);
            this.tbCustname.TabIndex = 8;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 21);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(74, 13);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Customer No.:";
            // 
            // tbNCustcode
            // 
            this.tbNCustcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNCustcode.Location = new System.Drawing.Point(94, 19);
            this.tbNCustcode.MaxLength = 20;
            this.tbNCustcode.Name = "tbNCustcode";
            this.tbNCustcode.ReadOnly = true;
            this.tbNCustcode.Size = new System.Drawing.Size(88, 20);
            this.tbNCustcode.TabIndex = 6;
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Location = new System.Drawing.Point(476, 397);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(0, 13);
            this.lblTableName.TabIndex = 115;
            this.lblTableName.Visible = false;
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.HeaderText = "Customer Name";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly = true;
            this.DataGridViewTextBoxColumn1.Width = 200;
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.HeaderText = "Cust.Code";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly = true;
            this.DataGridViewTextBoxColumn2.Width = 80;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(6, 111);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(85, 13);
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "Customer Name:";
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.HeaderText = "Address";
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.ReadOnly = true;
            this.DataGridViewTextBoxColumn4.Width = 200;
            // 
            // tbCustNo
            // 
            this.tbCustNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCustNo.Location = new System.Drawing.Point(272, 17);
            this.tbCustNo.Name = "tbCustNo";
            this.tbCustNo.Size = new System.Drawing.Size(88, 20);
            this.tbCustNo.TabIndex = 6;
            this.tbCustNo.Visible = false;
            // 
            // dgvConsumer
            // 
            this.dgvConsumer.AllowDrop = true;
            this.dgvConsumer.AllowUserToAddRows = false;
            this.dgvConsumer.AllowUserToDeleteRows = false;
            this.dgvConsumer.AllowUserToResizeColumns = false;
            this.dgvConsumer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvConsumer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsumer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsumer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn15,
            this.DataGridViewTextBoxColumn14,
            this.Column16,
            this.Column17,
            this.contype});
            this.dgvConsumer.Location = new System.Drawing.Point(4, 30);
            this.dgvConsumer.Name = "dgvConsumer";
            this.dgvConsumer.ReadOnly = true;
            this.dgvConsumer.RowHeadersVisible = false;
            this.dgvConsumer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsumer.Size = new System.Drawing.Size(602, 357);
            this.dgvConsumer.TabIndex = 111;
            this.dgvConsumer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsumer_CellClick);
            this.dgvConsumer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsumer_CellDoubleClick);
            // 
            // DataGridViewTextBoxColumn15
            // 
            this.DataGridViewTextBoxColumn15.HeaderText = "Consumer Name";
            this.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
            this.DataGridViewTextBoxColumn15.ReadOnly = true;
            this.DataGridViewTextBoxColumn15.Width = 250;
            // 
            // DataGridViewTextBoxColumn14
            // 
            this.DataGridViewTextBoxColumn14.HeaderText = "AcctNo.";
            this.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14";
            this.DataGridViewTextBoxColumn14.ReadOnly = true;
            this.DataGridViewTextBoxColumn14.Width = 80;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Barangay";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 150;
            // 
            // Column17
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column17.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column17.HeaderText = "Zone";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 50;
            // 
            // contype
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.contype.DefaultCellStyle = dataGridViewCellStyle4;
            this.contype.HeaderText = "Book";
            this.contype.Name = "contype";
            this.contype.ReadOnly = true;
            this.contype.Width = 50;
            // 
            // tsMenu
            // 
            this.tsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tsMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMerge,
            this.tsbDelete,
            this.tsbSelect,
            this.tsbNewC,
            this.tsbClose});
            this.tsMenu.Location = new System.Drawing.Point(478, 390);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(126, 25);
            this.tsMenu.TabIndex = 113;
            this.tsMenu.Text = "Menu";
            // 
            // tsbMerge
            // 
            this.tsbMerge.Image = ((System.Drawing.Image)(resources.GetObject("tsbMerge.Image")));
            this.tsbMerge.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMerge.Name = "tsbMerge";
            this.tsbMerge.Size = new System.Drawing.Size(61, 22);
            this.tsbMerge.Text = "&Merge";
            this.tsbMerge.ToolTipText = "Merge Customers";
            this.tsbMerge.Visible = false;
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(60, 22);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.Visible = false;
            // 
            // tsbSelect
            // 
            this.tsbSelect.Image = ((System.Drawing.Image)(resources.GetObject("tsbSelect.Image")));
            this.tsbSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelect.Name = "tsbSelect";
            this.tsbSelect.Size = new System.Drawing.Size(58, 22);
            this.tsbSelect.Text = "&Select";
            this.tsbSelect.Click += new System.EventHandler(this.tsbSelect_Click);
            // 
            // tsbNewC
            // 
            this.tsbNewC.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewC.Image")));
            this.tsbNewC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewC.Name = "tsbNewC";
            this.tsbNewC.Size = new System.Drawing.Size(49, 22);
            this.tsbNewC.Text = "Add";
            this.tsbNewC.Visible = false;
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(56, 22);
            this.tsbClose.Text = "&Close";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSearch.Location = new System.Drawing.Point(3, 4);
            this.tbSearch.MaxLength = 200;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(253, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 85);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Merge to:";
            // 
            // tbCustCode
            // 
            this.tbCustCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCustCode.Location = new System.Drawing.Point(64, 83);
            this.tbCustCode.MaxLength = 20;
            this.tbCustCode.Name = "tbCustCode";
            this.tbCustCode.Size = new System.Drawing.Size(88, 20);
            this.tbCustCode.TabIndex = 4;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(6, 58);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(47, 13);
            this.lblReason.TabIndex = 3;
            this.lblReason.Text = "Reason:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Customer Name:";
            // 
            // tbReason
            // 
            this.tbReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbReason.Location = new System.Drawing.Point(63, 53);
            this.tbReason.MaxLength = 20;
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(275, 20);
            this.tbReason.TabIndex = 0;
            // 
            // gbMerge
            // 
            this.gbMerge.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbMerge.Controls.Add(this.tsMerge);
            this.gbMerge.Controls.Add(this.lblTo);
            this.gbMerge.Controls.Add(this.tbCustNo);
            this.gbMerge.Controls.Add(this.Label1);
            this.gbMerge.Controls.Add(this.tbCustCode);
            this.gbMerge.Controls.Add(this.lblReason);
            this.gbMerge.Controls.Add(this.lblDate);
            this.gbMerge.Controls.Add(this.lblName);
            this.gbMerge.Controls.Add(this.tbReason);
            this.gbMerge.Location = new System.Drawing.Point(123, 214);
            this.gbMerge.Name = "gbMerge";
            this.gbMerge.Size = new System.Drawing.Size(387, 153);
            this.gbMerge.TabIndex = 114;
            this.gbMerge.TabStop = false;
            this.gbMerge.Text = "Merge ";
            this.gbMerge.Visible = false;
            // 
            // consearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 417);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.gbMerge);
            this.Controls.Add(this.dgvConsumer);
            this.Name = "consearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumer Listing";
            this.Load += new System.EventHandler(this.consearch_Load);
            this.tsMerge.ResumeLayout(false);
            this.tsMerge.PerformLayout();
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.tsadd.ResumeLayout(false);
            this.tsadd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumer)).EndInit();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.gbMerge.ResumeLayout(false);
            this.gbMerge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripButton btnHide;
        internal System.Windows.Forms.ToolStrip tsMerge;
        internal System.Windows.Forms.ToolStripButton btnMerge;
        internal System.Windows.Forms.ToolStripButton btnClear;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal System.Windows.Forms.GroupBox gbAdd;
        internal System.Windows.Forms.ToolStrip tsadd;
        internal System.Windows.Forms.ToolStripButton tsbSaveC;
        internal System.Windows.Forms.ToolStripButton tsbExit;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox tbCustadd;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox tbCustname;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox tbNCustcode;
        internal System.Windows.Forms.Label lblTableName;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal System.Windows.Forms.Label lblTo;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal System.Windows.Forms.TextBox tbCustNo;
        internal System.Windows.Forms.DataGridView dgvConsumer;
        internal System.Windows.Forms.ToolStrip tsMenu;
        internal System.Windows.Forms.ToolStripButton tsbMerge;
        internal System.Windows.Forms.ToolStripButton tsbDelete;
        internal System.Windows.Forms.ToolStripButton tsbSelect;
        internal System.Windows.Forms.ToolStripButton tsbNewC;
        internal System.Windows.Forms.ToolStripButton tsbClose;
        internal System.Windows.Forms.TextBox tbSearch;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox tbCustCode;
        internal System.Windows.Forms.Label lblReason;
        internal System.Windows.Forms.Label lblDate;
        internal System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.TextBox tbReason;
        internal System.Windows.Forms.GroupBox gbMerge;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn contype;
    }
}