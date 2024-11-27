namespace bcsys.Forms.EntryForms
{
    partial class ledger_old
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ledger_old));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvConsumer = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbBook = new System.Windows.Forms.ComboBox();
            this.cbZone = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbBgyCode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLDtl = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RdgDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cumused = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbApp = new System.Windows.Forms.GroupBox();
            this.tbMasCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.tbConCode = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumer)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDtl)).BeginInit();
            this.gbApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvConsumer);
            this.groupBox1.Location = new System.Drawing.Point(3, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 547);
            this.groupBox1.TabIndex = 115;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consumer List";
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
            this.dgvConsumer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsumer.Location = new System.Drawing.Point(3, 16);
            this.dgvConsumer.Name = "dgvConsumer";
            this.dgvConsumer.ReadOnly = true;
            this.dgvConsumer.RowHeadersVisible = false;
            this.dgvConsumer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsumer.Size = new System.Drawing.Size(330, 528);
            this.dgvConsumer.TabIndex = 112;
            this.dgvConsumer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsumer_CellClick);
            // 
            // DataGridViewTextBoxColumn15
            // 
            this.DataGridViewTextBoxColumn15.HeaderText = "Consumer Name";
            this.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
            this.DataGridViewTextBoxColumn15.ReadOnly = true;
            this.DataGridViewTextBoxColumn15.Width = 235;
            // 
            // DataGridViewTextBoxColumn14
            // 
            this.DataGridViewTextBoxColumn14.HeaderText = "Acct No.";
            this.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14";
            this.DataGridViewTextBoxColumn14.ReadOnly = true;
            this.DataGridViewTextBoxColumn14.Width = 75;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Barangay";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Visible = false;
            this.Column16.Width = 120;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Purok";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Visible = false;
            this.Column17.Width = 120;
            // 
            // contype
            // 
            this.contype.HeaderText = "ConType";
            this.contype.Name = "contype";
            this.contype.ReadOnly = true;
            this.contype.Visible = false;
            this.contype.Width = 60;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox6.Controls.Add(this.cbBook);
            this.groupBox6.Controls.Add(this.cbZone);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.tbSearch);
            this.groupBox6.Controls.Add(this.tbBgyCode);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.textBox6);
            this.groupBox6.Location = new System.Drawing.Point(5, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(330, 84);
            this.groupBox6.TabIndex = 116;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Filter Options";
            // 
            // cbBook
            // 
            this.cbBook.FormattingEnabled = true;
            this.cbBook.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbBook.Location = new System.Drawing.Point(148, 36);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(41, 21);
            this.cbBook.TabIndex = 118;
            // 
            // cbZone
            // 
            this.cbZone.FormattingEnabled = true;
            this.cbZone.Location = new System.Drawing.Point(64, 37);
            this.cbZone.Name = "cbZone";
            this.cbZone.Size = new System.Drawing.Size(41, 21);
            this.cbZone.TabIndex = 115;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(110, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 117;
            this.label12.Text = "Book:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(26, 41);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 13);
            this.label23.TabIndex = 116;
            this.label23.Text = "Zone:";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(2, 60);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(326, 20);
            this.tbSearch.TabIndex = 114;
            this.tbSearch.Text = "Search";
            // 
            // tbBgyCode
            // 
            this.tbBgyCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBgyCode.Location = new System.Drawing.Point(265, 14);
            this.tbBgyCode.MaxLength = 100;
            this.tbBgyCode.Name = "tbBgyCode";
            this.tbBgyCode.Size = new System.Drawing.Size(47, 20);
            this.tbBgyCode.TabIndex = 65;
            this.tbBgyCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBgyCode.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(230, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 21);
            this.button1.TabIndex = 61;
            this.button1.Text = "F2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 17);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 13);
            this.label22.TabIndex = 60;
            this.label22.Text = "Barangay:";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(64, 14);
            this.textBox6.MaxLength = 100;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(162, 20);
            this.textBox6.TabIndex = 59;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLDtl);
            this.groupBox2.Location = new System.Drawing.Point(342, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(897, 546);
            this.groupBox2.TabIndex = 117;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ledger Dettail";
            // 
            // dgvLDtl
            // 
            this.dgvLDtl.AllowDrop = true;
            this.dgvLDtl.AllowUserToAddRows = false;
            this.dgvLDtl.AllowUserToDeleteRows = false;
            this.dgvLDtl.AllowUserToResizeColumns = false;
            this.dgvLDtl.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvLDtl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLDtl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLDtl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLDtl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.RdgDate,
            this.dataGridViewTextBoxColumn1,
            this.Reading,
            this.cumused,
            this.Debit,
            this.Credit,
            this.Balance,
            this.user,
            this.DateE,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvLDtl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLDtl.Location = new System.Drawing.Point(3, 16);
            this.dgvLDtl.Name = "dgvLDtl";
            this.dgvLDtl.ReadOnly = true;
            this.dgvLDtl.RowHeadersVisible = false;
            this.dgvLDtl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLDtl.Size = new System.Drawing.Size(891, 527);
            this.dgvLDtl.TabIndex = 112;
            // 
            // Date
            // 
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.Date.DefaultCellStyle = dataGridViewCellStyle5;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 80;
            // 
            // RdgDate
            // 
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.RdgDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.RdgDate.HeaderText = "DueDate";
            this.RdgDate.Name = "RdgDate";
            this.RdgDate.ReadOnly = true;
            this.RdgDate.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Particulars";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 180;
            // 
            // Reading
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Reading.DefaultCellStyle = dataGridViewCellStyle7;
            this.Reading.HeaderText = "Reading";
            this.Reading.Name = "Reading";
            this.Reading.ReadOnly = true;
            this.Reading.Width = 60;
            // 
            // cumused
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cumused.DefaultCellStyle = dataGridViewCellStyle8;
            this.cumused.HeaderText = "CmUsed";
            this.cumused.Name = "cumused";
            this.cumused.ReadOnly = true;
            this.cumused.Width = 50;
            // 
            // Debit
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            this.Debit.DefaultCellStyle = dataGridViewCellStyle9;
            this.Debit.HeaderText = "Debit";
            this.Debit.Name = "Debit";
            this.Debit.ReadOnly = true;
            this.Debit.Width = 70;
            // 
            // Credit
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            this.Credit.DefaultCellStyle = dataGridViewCellStyle10;
            this.Credit.HeaderText = "Credit";
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            this.Credit.Width = 70;
            // 
            // Balance
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            this.Balance.DefaultCellStyle = dataGridViewCellStyle11;
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.Width = 80;
            // 
            // user
            // 
            this.user.HeaderText = "User";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            this.user.Width = 60;
            // 
            // DateE
            // 
            dataGridViewCellStyle12.Format = "G";
            dataGridViewCellStyle12.NullValue = null;
            this.DateE.DefaultCellStyle = dataGridViewCellStyle12;
            this.DateE.HeaderText = "DateEntered";
            this.DateE.Name = "DateE";
            this.DateE.ReadOnly = true;
            this.DateE.Width = 140;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Acct No.";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Barangay";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Purok";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "ConType";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // gbApp
            // 
            this.gbApp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbApp.Controls.Add(this.tbMasCode);
            this.gbApp.Controls.Add(this.label2);
            this.gbApp.Controls.Add(this.tbAddress);
            this.gbApp.Controls.Add(this.Label1);
            this.gbApp.Controls.Add(this.tbName);
            this.gbApp.Controls.Add(this.Label15);
            this.gbApp.Controls.Add(this.tbConCode);
            this.gbApp.Location = new System.Drawing.Point(346, 5);
            this.gbApp.Name = "gbApp";
            this.gbApp.Size = new System.Drawing.Size(465, 88);
            this.gbApp.TabIndex = 118;
            this.gbApp.TabStop = false;
            this.gbApp.Text = "Consumer Detail";
            // 
            // tbMasCode
            // 
            this.tbMasCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMasCode.Location = new System.Drawing.Point(201, 18);
            this.tbMasCode.MaxLength = 100;
            this.tbMasCode.Name = "tbMasCode";
            this.tbMasCode.Size = new System.Drawing.Size(74, 20);
            this.tbMasCode.TabIndex = 72;
            this.tbMasCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Address:";
            // 
            // tbAddress
            // 
            this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddress.Location = new System.Drawing.Point(98, 64);
            this.tbAddress.MaxLength = 100;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(361, 20);
            this.tbAddress.TabIndex = 61;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(7, 44);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 13);
            this.Label1.TabIndex = 59;
            this.Label1.Text = "Consumer Name:";
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbName.Location = new System.Drawing.Point(98, 41);
            this.tbName.MaxLength = 100;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(361, 20);
            this.tbName.TabIndex = 54;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(10, 20);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(85, 13);
            this.Label15.TabIndex = 52;
            this.Label15.Text = "Consumer Code:";
            // 
            // tbConCode
            // 
            this.tbConCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbConCode.Location = new System.Drawing.Point(98, 17);
            this.tbConCode.MaxLength = 100;
            this.tbConCode.Name = "tbConCode";
            this.tbConCode.Size = new System.Drawing.Size(99, 20);
            this.tbConCode.TabIndex = 0;
            this.tbConCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ledger_old
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 648);
            this.Controls.Add(this.gbApp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.Name = "ledger_old";
            this.Text = "ledger_old";
            this.Load += new System.EventHandler(this.ledger_old_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumer)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDtl)).EndInit();
            this.gbApp.ResumeLayout(false);
            this.gbApp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.DataGridView dgvConsumer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn contype;
        internal System.Windows.Forms.GroupBox groupBox6;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label label22;
        internal System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.DataGridView dgvLDtl;
        internal System.Windows.Forms.GroupBox gbApp;
        internal System.Windows.Forms.TextBox tbMasCode;
        internal System.Windows.Forms.TextBox tbBgyCode;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox tbAddress;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox tbName;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox tbConCode;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.ComboBox cbZone;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn RdgDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reading;
        private System.Windows.Forms.DataGridViewTextBoxColumn cumused;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}