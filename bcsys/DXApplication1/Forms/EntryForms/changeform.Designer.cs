namespace bcsys.Forms.EntryForms
{
	partial class changeform
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changeform));
			this.lblreason = new System.Windows.Forms.Label();
			this.tbreason = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgvh = new System.Windows.Forms.DataGridView();
			this.meterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.oldprdg = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OldLRdg = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.oldcmu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.newmeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.InitialRdg = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbRecon = new System.Windows.Forms.GroupBox();
			this.tbstatus = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpreplaced = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.tboldrdg = new System.Windows.Forms.TextBox();
			this.tboprdg = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.cbBrand = new System.Windows.Forms.ComboBox();
			this.label22 = new System.Windows.Forms.Label();
			this.tbocode = new System.Windows.Forms.TextBox();
			this.tbometerno = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.tbcumused = new System.Windows.Forms.TextBox();
			this.gbConDtl = new System.Windows.Forms.GroupBox();
			this.tbmascode = new System.Windows.Forms.TextBox();
			this.Label16 = new System.Windows.Forms.Label();
			this.tbContype = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.tbAddress = new System.Windows.Forms.TextBox();
			this.btnConSearch = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.tbAcctno = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.tsMenu = new System.Windows.Forms.ToolStrip();
			this.tsbSave = new System.Windows.Forms.ToolStripButton();
			this.btnClose = new System.Windows.Forms.ToolStripButton();
			this.gbpullout = new System.Windows.Forms.GroupBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.gbaccount = new System.Windows.Forms.GroupBox();
			this.gbname = new System.Windows.Forms.GroupBox();
			this.label28 = new System.Windows.Forms.Label();
			this.tbnewname = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.tbnewaddress = new System.Windows.Forms.TextBox();
			this.tbznbk = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.tbCMCode = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tbInitReading = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tbMeterNo = new System.Windows.Forms.TextBox();
			this.cbRType = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbBook = new System.Windows.Forms.ComboBox();
			this.cbZone = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cbMSize = new System.Windows.Forms.ComboBox();
			this.cbClass = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.tbAcc = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvh)).BeginInit();
			this.gbRecon.SuspendLayout();
			this.gbConDtl.SuspendLayout();
			this.tsMenu.SuspendLayout();
			this.gbpullout.SuspendLayout();
			this.gbaccount.SuspendLayout();
			this.gbname.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblreason
			// 
			this.lblreason.AutoSize = true;
			this.lblreason.Location = new System.Drawing.Point(224, 144);
			this.lblreason.Name = "lblreason";
			this.lblreason.Size = new System.Drawing.Size(47, 13);
			this.lblreason.TabIndex = 293;
			this.lblreason.Text = "Reason:";
			// 
			// tbreason
			// 
			this.tbreason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbreason.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbreason.Location = new System.Drawing.Point(274, 140);
			this.tbreason.MaxLength = 200;
			this.tbreason.Name = "tbreason";
			this.tbreason.ReadOnly = true;
			this.tbreason.Size = new System.Drawing.Size(152, 21);
			this.tbreason.TabIndex = 292;
			this.tbreason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox2.Controls.Add(this.dgvh);
			this.groupBox2.Location = new System.Drawing.Point(218, 20);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(226, 100);
			this.groupBox2.TabIndex = 291;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "History";
			// 
			// dgvh
			// 
			this.dgvh.AllowUserToAddRows = false;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F);
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.meterno,
            this.ddate,
            this.oldprdg,
            this.OldLRdg,
            this.oldcmu,
            this.newmeter,
            this.InitialRdg});
			this.dgvh.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvh.Location = new System.Drawing.Point(3, 17);
			this.dgvh.Name = "dgvh";
			this.dgvh.ReadOnly = true;
			this.dgvh.RowHeadersVisible = false;
			this.dgvh.Size = new System.Drawing.Size(220, 80);
			this.dgvh.TabIndex = 0;
			// 
			// meterno
			// 
			this.meterno.HeaderText = "MeterNo";
			this.meterno.Name = "meterno";
			this.meterno.ReadOnly = true;
			this.meterno.Width = 80;
			// 
			// ddate
			// 
			this.ddate.HeaderText = "ChangeDate";
			this.ddate.Name = "ddate";
			this.ddate.ReadOnly = true;
			this.ddate.Width = 70;
			// 
			// oldprdg
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.oldprdg.DefaultCellStyle = dataGridViewCellStyle10;
			this.oldprdg.HeaderText = "OldPRdg";
			this.oldprdg.Name = "oldprdg";
			this.oldprdg.ReadOnly = true;
			this.oldprdg.Visible = false;
			this.oldprdg.Width = 50;
			// 
			// OldLRdg
			// 
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.OldLRdg.DefaultCellStyle = dataGridViewCellStyle11;
			this.OldLRdg.HeaderText = "OldLRdg";
			this.OldLRdg.Name = "OldLRdg";
			this.OldLRdg.ReadOnly = true;
			this.OldLRdg.Visible = false;
			this.OldLRdg.Width = 50;
			// 
			// oldcmu
			// 
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.oldcmu.DefaultCellStyle = dataGridViewCellStyle12;
			this.oldcmu.HeaderText = "CuMUsed";
			this.oldcmu.Name = "oldcmu";
			this.oldcmu.ReadOnly = true;
			this.oldcmu.Width = 50;
			// 
			// newmeter
			// 
			this.newmeter.HeaderText = "NewMeter";
			this.newmeter.Name = "newmeter";
			this.newmeter.ReadOnly = true;
			this.newmeter.Visible = false;
			this.newmeter.Width = 60;
			// 
			// InitialRdg
			// 
			this.InitialRdg.HeaderText = "InitialRdg";
			this.InitialRdg.Name = "InitialRdg";
			this.InitialRdg.ReadOnly = true;
			this.InitialRdg.Visible = false;
			this.InitialRdg.Width = 50;
			// 
			// gbRecon
			// 
			this.gbRecon.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.gbRecon.Controls.Add(this.tbstatus);
			this.gbRecon.Controls.Add(this.label2);
			this.gbRecon.Controls.Add(this.dtpreplaced);
			this.gbRecon.Controls.Add(this.label8);
			this.gbRecon.Controls.Add(this.tboldrdg);
			this.gbRecon.Controls.Add(this.tboprdg);
			this.gbRecon.Controls.Add(this.label21);
			this.gbRecon.Controls.Add(this.label23);
			this.gbRecon.Controls.Add(this.cbBrand);
			this.gbRecon.Controls.Add(this.label22);
			this.gbRecon.Controls.Add(this.tbocode);
			this.gbRecon.Controls.Add(this.tbometerno);
			this.gbRecon.Controls.Add(this.label15);
			this.gbRecon.Controls.Add(this.label19);
			this.gbRecon.Controls.Add(this.tbcumused);
			this.gbRecon.Location = new System.Drawing.Point(7, 20);
			this.gbRecon.Name = "gbRecon";
			this.gbRecon.Size = new System.Drawing.Size(207, 171);
			this.gbRecon.TabIndex = 290;
			this.gbRecon.TabStop = false;
			this.gbRecon.Text = "Meter Detail";
			// 
			// tbstatus
			// 
			this.tbstatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbstatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbstatus.Location = new System.Drawing.Point(107, 146);
			this.tbstatus.MaxLength = 20;
			this.tbstatus.Name = "tbstatus";
			this.tbstatus.Size = new System.Drawing.Size(93, 21);
			this.tbstatus.TabIndex = 290;
			this.tbstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(62, 150);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 289;
			this.label2.Text = "Status:";
			// 
			// dtpreplaced
			// 
			this.dtpreplaced.CustomFormat = "MM/dd/yyyy";
			this.dtpreplaced.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpreplaced.Location = new System.Drawing.Point(108, 124);
			this.dtpreplaced.Name = "dtpreplaced";
			this.dtpreplaced.Size = new System.Drawing.Size(93, 21);
			this.dtpreplaced.TabIndex = 288;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(24, 128);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(81, 13);
			this.label8.TabIndex = 287;
			this.label8.Text = "Date Pulledout:";
			// 
			// tboldrdg
			// 
			this.tboldrdg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tboldrdg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tboldrdg.Location = new System.Drawing.Point(109, 57);
			this.tboldrdg.MaxLength = 20;
			this.tboldrdg.Name = "tboldrdg";
			this.tboldrdg.Size = new System.Drawing.Size(93, 21);
			this.tboldrdg.TabIndex = 286;
			this.tboldrdg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tboprdg
			// 
			this.tboprdg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tboprdg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tboprdg.Location = new System.Drawing.Point(109, 79);
			this.tboprdg.MaxLength = 20;
			this.tboprdg.Name = "tboprdg";
			this.tboprdg.Size = new System.Drawing.Size(93, 21);
			this.tboprdg.TabIndex = 282;
			this.tboprdg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(12, 83);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(94, 13);
			this.label21.TabIndex = 281;
			this.label21.Text = "Previous Reading:";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(33, 61);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(73, 13);
			this.label23.TabIndex = 285;
			this.label23.Text = "Last Reading:";
			// 
			// cbBrand
			// 
			this.cbBrand.FormattingEnabled = true;
			this.cbBrand.Location = new System.Drawing.Point(109, 35);
			this.cbBrand.Name = "cbBrand";
			this.cbBrand.Size = new System.Drawing.Size(92, 21);
			this.cbBrand.TabIndex = 284;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(36, 39);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(70, 13);
			this.label22.TabIndex = 283;
			this.label22.Text = "Meter Brand:";
			// 
			// tbocode
			// 
			this.tbocode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbocode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbocode.Location = new System.Drawing.Point(182, 35);
			this.tbocode.MaxLength = 20;
			this.tbocode.Name = "tbocode";
			this.tbocode.ReadOnly = true;
			this.tbocode.Size = new System.Drawing.Size(19, 21);
			this.tbocode.TabIndex = 280;
			this.tbocode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbocode.Visible = false;
			// 
			// tbometerno
			// 
			this.tbometerno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbometerno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbometerno.Location = new System.Drawing.Point(109, 14);
			this.tbometerno.MaxLength = 20;
			this.tbometerno.Name = "tbometerno";
			this.tbometerno.ReadOnly = true;
			this.tbometerno.Size = new System.Drawing.Size(93, 21);
			this.tbometerno.TabIndex = 263;
			this.tbometerno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(47, 17);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(59, 13);
			this.label15.TabIndex = 260;
			this.label15.Text = "Meter No.:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(11, 105);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(95, 13);
			this.label19.TabIndex = 256;
			this.label19.Text = "Cubic Meter Used:";
			// 
			// tbcumused
			// 
			this.tbcumused.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbcumused.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbcumused.Location = new System.Drawing.Point(109, 101);
			this.tbcumused.MaxLength = 10;
			this.tbcumused.Name = "tbcumused";
			this.tbcumused.ReadOnly = true;
			this.tbcumused.Size = new System.Drawing.Size(93, 21);
			this.tbcumused.TabIndex = 255;
			this.tbcumused.Text = "0";
			this.tbcumused.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// gbConDtl
			// 
			this.gbConDtl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.gbConDtl.Controls.Add(this.tbmascode);
			this.gbConDtl.Controls.Add(this.Label16);
			this.gbConDtl.Controls.Add(this.tbContype);
			this.gbConDtl.Controls.Add(this.Label6);
			this.gbConDtl.Controls.Add(this.tbAddress);
			this.gbConDtl.Controls.Add(this.btnConSearch);
			this.gbConDtl.Controls.Add(this.Label1);
			this.gbConDtl.Controls.Add(this.tbAcctno);
			this.gbConDtl.Controls.Add(this.Label4);
			this.gbConDtl.Controls.Add(this.tbName);
			this.gbConDtl.Location = new System.Drawing.Point(7, 27);
			this.gbConDtl.Name = "gbConDtl";
			this.gbConDtl.Size = new System.Drawing.Size(446, 85);
			this.gbConDtl.TabIndex = 289;
			this.gbConDtl.TabStop = false;
			this.gbConDtl.Text = "Consumer Details";
			// 
			// tbmascode
			// 
			this.tbmascode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbmascode.Location = new System.Drawing.Point(242, 13);
			this.tbmascode.MaxLength = 100;
			this.tbmascode.Name = "tbmascode";
			this.tbmascode.ReadOnly = true;
			this.tbmascode.Size = new System.Drawing.Size(79, 21);
			this.tbmascode.TabIndex = 237;
			this.tbmascode.Visible = false;
			// 
			// Label16
			// 
			this.Label16.AutoSize = true;
			this.Label16.Location = new System.Drawing.Point(447, 62);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(65, 13);
			this.Label16.TabIndex = 236;
			this.Label16.Text = "Connection:";
			// 
			// tbContype
			// 
			this.tbContype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbContype.Location = new System.Drawing.Point(515, 59);
			this.tbContype.MaxLength = 100;
			this.tbContype.Name = "tbContype";
			this.tbContype.ReadOnly = true;
			this.tbContype.Size = new System.Drawing.Size(98, 21);
			this.tbContype.TabIndex = 235;
			// 
			// Label6
			// 
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(42, 62);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(50, 13);
			this.Label6.TabIndex = 233;
			this.Label6.Text = "Address:";
			// 
			// tbAddress
			// 
			this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbAddress.Location = new System.Drawing.Point(101, 59);
			this.tbAddress.MaxLength = 100;
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.ReadOnly = true;
			this.tbAddress.Size = new System.Drawing.Size(340, 21);
			this.tbAddress.TabIndex = 234;
			// 
			// btnConSearch
			// 
			this.btnConSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnConSearch.Image")));
			this.btnConSearch.Location = new System.Drawing.Point(196, 13);
			this.btnConSearch.Name = "btnConSearch";
			this.btnConSearch.Size = new System.Drawing.Size(30, 22);
			this.btnConSearch.TabIndex = 1;
			this.btnConSearch.Text = "F2";
			this.btnConSearch.UseVisualStyleBackColor = true;
			this.btnConSearch.Click += new System.EventHandler(this.btnConSearch_Click);
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(27, 17);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(70, 13);
			this.Label1.TabIndex = 231;
			this.Label1.Text = "Account No.:";
			// 
			// tbAcctno
			// 
			this.tbAcctno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbAcctno.Location = new System.Drawing.Point(101, 14);
			this.tbAcctno.MaxLength = 100;
			this.tbAcctno.Name = "tbAcctno";
			this.tbAcctno.ReadOnly = true;
			this.tbAcctno.Size = new System.Drawing.Size(93, 21);
			this.tbAcctno.TabIndex = 0;
			// 
			// Label4
			// 
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(10, 39);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(89, 13);
			this.Label4.TabIndex = 229;
			this.Label4.Text = "Consumer Name:";
			// 
			// tbName
			// 
			this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbName.Location = new System.Drawing.Point(101, 36);
			this.tbName.MaxLength = 100;
			this.tbName.Name = "tbName";
			this.tbName.ReadOnly = true;
			this.tbName.Size = new System.Drawing.Size(341, 21);
			this.tbName.TabIndex = 230;
			// 
			// tsMenu
			// 
			this.tsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.tsMenu.Dock = System.Windows.Forms.DockStyle.None;
			this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.btnClose});
			this.tsMenu.Location = new System.Drawing.Point(342, -3);
			this.tsMenu.Name = "tsMenu";
			this.tsMenu.Size = new System.Drawing.Size(150, 25);
			this.tsMenu.TabIndex = 294;
			this.tsMenu.TabStop = true;
			this.tsMenu.Text = "Special Billing Menu";
			// 
			// tsbSave
			// 
			this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
			this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSave.Name = "tsbSave";
			this.tsbSave.Size = new System.Drawing.Size(51, 22);
			this.tsbSave.Text = "Save";
			this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
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
			// gbpullout
			// 
			this.gbpullout.Controls.Add(this.gbRecon);
			this.gbpullout.Controls.Add(this.groupBox2);
			this.gbpullout.Controls.Add(this.lblreason);
			this.gbpullout.Controls.Add(this.tbreason);
			this.gbpullout.Location = new System.Drawing.Point(11, 118);
			this.gbpullout.Name = "gbpullout";
			this.gbpullout.Size = new System.Drawing.Size(447, 193);
			this.gbpullout.TabIndex = 295;
			this.gbpullout.TabStop = false;
			this.gbpullout.Text = "Pull Out Meter Detail";
			// 
			// gbaccount
			// 
			this.gbaccount.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.gbaccount.Controls.Add(this.gbname);
			this.gbaccount.Controls.Add(this.tbznbk);
			this.gbaccount.Controls.Add(this.label17);
			this.gbaccount.Controls.Add(this.tbCMCode);
			this.gbaccount.Controls.Add(this.label11);
			this.gbaccount.Controls.Add(this.tbInitReading);
			this.gbaccount.Controls.Add(this.comboBox1);
			this.gbaccount.Controls.Add(this.label10);
			this.gbaccount.Controls.Add(this.label9);
			this.gbaccount.Controls.Add(this.tbMeterNo);
			this.gbaccount.Controls.Add(this.cbRType);
			this.gbaccount.Controls.Add(this.label3);
			this.gbaccount.Controls.Add(this.cbBook);
			this.gbaccount.Controls.Add(this.cbZone);
			this.gbaccount.Controls.Add(this.label12);
			this.gbaccount.Controls.Add(this.label5);
			this.gbaccount.Controls.Add(this.cbMSize);
			this.gbaccount.Controls.Add(this.cbClass);
			this.gbaccount.Controls.Add(this.label7);
			this.gbaccount.Controls.Add(this.label14);
			this.gbaccount.Controls.Add(this.tbAcc);
			this.gbaccount.Controls.Add(this.label13);
			this.gbaccount.Controls.Add(this.label18);
			this.gbaccount.Location = new System.Drawing.Point(7, 120);
			this.gbaccount.Name = "gbaccount";
			this.gbaccount.Size = new System.Drawing.Size(446, 191);
			this.gbaccount.TabIndex = 294;
			this.gbaccount.TabStop = false;
			this.gbaccount.Text = "Account Detail";
			// 
			// gbname
			// 
			this.gbname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.gbname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.gbname.Controls.Add(this.label28);
			this.gbname.Controls.Add(this.tbnewname);
			this.gbname.Controls.Add(this.label20);
			this.gbname.Controls.Add(this.tbnewaddress);
			this.gbname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbname.Location = new System.Drawing.Point(26, 1);
			this.gbname.Name = "gbname";
			this.gbname.Size = new System.Drawing.Size(446, 190);
			this.gbname.TabIndex = 296;
			this.gbname.TabStop = false;
			this.gbname.Text = "Name and Address";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(19, 55);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(74, 13);
			this.label28.TabIndex = 296;
			this.label28.Text = "New Address:";
			// 
			// tbnewname
			// 
			this.tbnewname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbnewname.Location = new System.Drawing.Point(96, 24);
			this.tbnewname.MaxLength = 100;
			this.tbnewname.Name = "tbnewname";
			this.tbnewname.Size = new System.Drawing.Size(312, 21);
			this.tbnewname.TabIndex = 233;
			this.tbnewname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(31, 27);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(62, 13);
			this.label20.TabIndex = 232;
			this.label20.Text = "New Name:";
			// 
			// tbnewaddress
			// 
			this.tbnewaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbnewaddress.Location = new System.Drawing.Point(96, 51);
			this.tbnewaddress.MaxLength = 100;
			this.tbnewaddress.Name = "tbnewaddress";
			this.tbnewaddress.Size = new System.Drawing.Size(312, 21);
			this.tbnewaddress.TabIndex = 0;
			this.tbnewaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbznbk
			// 
			this.tbznbk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbznbk.Location = new System.Drawing.Point(301, 43);
			this.tbznbk.MaxLength = 100;
			this.tbznbk.Name = "tbznbk";
			this.tbznbk.Size = new System.Drawing.Size(40, 21);
			this.tbznbk.TabIndex = 233;
			this.tbznbk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(205, 47);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(94, 13);
			this.label17.TabIndex = 232;
			this.label17.Text = "New Account No.:";
			// 
			// tbCMCode
			// 
			this.tbCMCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbCMCode.Location = new System.Drawing.Point(347, 43);
			this.tbCMCode.MaxLength = 100;
			this.tbCMCode.Name = "tbCMCode";
			this.tbCMCode.ReadOnly = true;
			this.tbCMCode.Size = new System.Drawing.Size(40, 21);
			this.tbCMCode.TabIndex = 79;
			this.tbCMCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(211, 168);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(75, 13);
			this.label11.TabIndex = 78;
			this.label11.Text = "Initial Reading";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label11.Visible = false;
			// 
			// tbInitReading
			// 
			this.tbInitReading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbInitReading.Location = new System.Drawing.Point(220, 184);
			this.tbInitReading.MaxLength = 100;
			this.tbInitReading.Name = "tbInitReading";
			this.tbInitReading.Size = new System.Drawing.Size(51, 21);
			this.tbInitReading.TabIndex = 63;
			this.tbInitReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbInitReading.Visible = false;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(327, 132);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(83, 21);
			this.comboBox1.TabIndex = 76;
			this.comboBox1.Visible = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(287, 136);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(39, 13);
			this.label10.TabIndex = 77;
			this.label10.Text = "Brand:";
			this.label10.Visible = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(151, 137);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(59, 13);
			this.label9.TabIndex = 75;
			this.label9.Text = "Meter No.:";
			this.label9.Visible = false;
			// 
			// tbMeterNo
			// 
			this.tbMeterNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbMeterNo.Location = new System.Drawing.Point(211, 133);
			this.tbMeterNo.MaxLength = 100;
			this.tbMeterNo.Name = "tbMeterNo";
			this.tbMeterNo.Size = new System.Drawing.Size(75, 21);
			this.tbMeterNo.TabIndex = 74;
			this.tbMeterNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbMeterNo.Visible = false;
			// 
			// cbRType
			// 
			this.cbRType.FormattingEnabled = true;
			this.cbRType.Items.AddRange(new object[] {
            "Metered",
            "Flat",
            "Average",
            "Spec"});
			this.cbRType.Location = new System.Drawing.Point(75, 133);
			this.cbRType.Name = "cbRType";
			this.cbRType.Size = new System.Drawing.Size(72, 21);
			this.cbRType.TabIndex = 72;
			this.cbRType.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 137);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 13);
			this.label3.TabIndex = 73;
			this.label3.Text = "Rate Type:";
			this.label3.Visible = false;
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
			this.cbBook.Location = new System.Drawing.Point(159, 42);
			this.cbBook.Name = "cbBook";
			this.cbBook.Size = new System.Drawing.Size(41, 21);
			this.cbBook.TabIndex = 71;
			this.cbBook.SelectedIndexChanged += new System.EventHandler(this.cbBook_SelectedIndexChanged);
			// 
			// cbZone
			// 
			this.cbZone.FormattingEnabled = true;
			this.cbZone.Location = new System.Drawing.Point(75, 43);
			this.cbZone.Name = "cbZone";
			this.cbZone.Size = new System.Drawing.Size(41, 21);
			this.cbZone.TabIndex = 68;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(121, 48);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(34, 13);
			this.label12.TabIndex = 70;
			this.label12.Text = "Book:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(37, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 69;
			this.label5.Text = "Zone:";
			// 
			// cbMSize
			// 
			this.cbMSize.FormattingEnabled = true;
			this.cbMSize.Location = new System.Drawing.Point(301, 16);
			this.cbMSize.Name = "cbMSize";
			this.cbMSize.Size = new System.Drawing.Size(88, 21);
			this.cbMSize.TabIndex = 67;
			this.cbMSize.SelectedIndexChanged += new System.EventHandler(this.cbMSize_SelectedIndexChanged);
			// 
			// cbClass
			// 
			this.cbClass.FormattingEnabled = true;
			this.cbClass.Location = new System.Drawing.Point(75, 16);
			this.cbClass.Name = "cbClass";
			this.cbClass.Size = new System.Drawing.Size(142, 21);
			this.cbClass.TabIndex = 9;
			this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(237, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(61, 13);
			this.label7.TabIndex = 66;
			this.label7.Text = "Meter Size:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(2, 20);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(73, 13);
			this.label14.TabIndex = 64;
			this.label14.Text = "Classification:";
			// 
			// tbAcc
			// 
			this.tbAcc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbAcc.Location = new System.Drawing.Point(393, 43);
			this.tbAcc.MaxLength = 100;
			this.tbAcc.Name = "tbAcc";
			this.tbAcc.Size = new System.Drawing.Size(40, 21);
			this.tbAcc.TabIndex = 0;
			this.tbAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(339, 47);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(11, 13);
			this.label13.TabIndex = 294;
			this.label13.Text = "-";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(385, 47);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(11, 13);
			this.label18.TabIndex = 295;
			this.label18.Text = "-";
			// 
			// changeform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(463, 321);
			this.Controls.Add(this.gbaccount);
			this.Controls.Add(this.gbpullout);
			this.Controls.Add(this.tsMenu);
			this.Controls.Add(this.gbConDtl);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "changeform";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Change Form";
			this.Load += new System.EventHandler(this.changeform_Load);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvh)).EndInit();
			this.gbRecon.ResumeLayout(false);
			this.gbRecon.PerformLayout();
			this.gbConDtl.ResumeLayout(false);
			this.gbConDtl.PerformLayout();
			this.tsMenu.ResumeLayout(false);
			this.tsMenu.PerformLayout();
			this.gbpullout.ResumeLayout(false);
			this.gbpullout.PerformLayout();
			this.gbaccount.ResumeLayout(false);
			this.gbaccount.PerformLayout();
			this.gbname.ResumeLayout(false);
			this.gbname.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Label lblreason;
		internal System.Windows.Forms.TextBox tbreason;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dgvh;
		private System.Windows.Forms.GroupBox gbRecon;
		internal System.Windows.Forms.TextBox tboldrdg;
		internal System.Windows.Forms.TextBox tboprdg;
		internal System.Windows.Forms.Label label21;
		internal System.Windows.Forms.Label label23;
		private System.Windows.Forms.ComboBox cbBrand;
		internal System.Windows.Forms.Label label22;
		internal System.Windows.Forms.TextBox tbocode;
		internal System.Windows.Forms.TextBox tbometerno;
		internal System.Windows.Forms.Label label15;
		internal System.Windows.Forms.Label label19;
		internal System.Windows.Forms.TextBox tbcumused;
		internal System.Windows.Forms.GroupBox gbConDtl;
		internal System.Windows.Forms.TextBox tbmascode;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.TextBox tbContype;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox tbAddress;
		internal System.Windows.Forms.Button btnConSearch;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox tbAcctno;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox tbName;
		internal System.Windows.Forms.DateTimePicker dtpreplaced;
		internal System.Windows.Forms.Label label8;
		internal System.Windows.Forms.TextBox tbstatus;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.ToolStrip tsMenu;
		private System.Windows.Forms.ToolStripButton tsbSave;
		internal System.Windows.Forms.ToolStripButton btnClose;
		private System.Windows.Forms.DataGridViewTextBoxColumn meterno;
		private System.Windows.Forms.DataGridViewTextBoxColumn ddate;
		private System.Windows.Forms.DataGridViewTextBoxColumn oldprdg;
		private System.Windows.Forms.DataGridViewTextBoxColumn OldLRdg;
		private System.Windows.Forms.DataGridViewTextBoxColumn oldcmu;
		private System.Windows.Forms.DataGridViewTextBoxColumn newmeter;
		private System.Windows.Forms.DataGridViewTextBoxColumn InitialRdg;
		private System.Windows.Forms.GroupBox gbpullout;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		internal System.Windows.Forms.GroupBox gbaccount;
		internal System.Windows.Forms.TextBox tbCMCode;
		internal System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox comboBox1;
		internal System.Windows.Forms.Label label10;
		internal System.Windows.Forms.Label label9;
		internal System.Windows.Forms.TextBox tbMeterNo;
		private System.Windows.Forms.ComboBox cbRType;
		internal System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbBook;
		private System.Windows.Forms.ComboBox cbZone;
		internal System.Windows.Forms.Label label12;
		internal System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbMSize;
		private System.Windows.Forms.ComboBox cbClass;
		internal System.Windows.Forms.Label label7;
		internal System.Windows.Forms.Label label14;
		internal System.Windows.Forms.TextBox tbAcc;
		internal System.Windows.Forms.TextBox tbInitReading;
		internal System.Windows.Forms.Label label17;
		internal System.Windows.Forms.TextBox tbznbk;
		internal System.Windows.Forms.Label label13;
		internal System.Windows.Forms.Label label18;
		internal System.Windows.Forms.GroupBox gbname;
		internal System.Windows.Forms.TextBox tbnewname;
		internal System.Windows.Forms.Label label20;
		internal System.Windows.Forms.TextBox tbnewaddress;
		internal System.Windows.Forms.Label label28;
	}
}