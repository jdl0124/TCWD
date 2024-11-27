namespace bcsys.Forms.EntryForms
{
	partial class changemeter
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changemeter));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tsMenu = new System.Windows.Forms.ToolStrip();
			this.btnchange = new System.Windows.Forms.ToolStripButton();
			this.btnClose = new System.Windows.Forms.ToolStripButton();
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
			this.gbRecon = new System.Windows.Forms.GroupBox();
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbpcode = new System.Windows.Forms.TextBox();
			this.tbinitrdg = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbnewbrand = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbncode = new System.Windows.Forms.TextBox();
			this.dtpreplaced = new System.Windows.Forms.DateTimePicker();
			this.tbnmeterno = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tbplumber = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgvh = new System.Windows.Forms.DataGridView();
			this.meterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.oldprdg = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OldLRdg = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.oldcmu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.newmeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.InitialRdg = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.tbreason = new System.Windows.Forms.TextBox();
			this.lblreason = new System.Windows.Forms.Label();
			this.tsMenu.SuspendLayout();
			this.gbConDtl.SuspendLayout();
			this.gbRecon.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvh)).BeginInit();
			this.SuspendLayout();
			// 
			// tsMenu
			// 
			this.tsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tsMenu.Dock = System.Windows.Forms.DockStyle.None;
			this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnchange,
            this.btnClose});
			this.tsMenu.Location = new System.Drawing.Point(253, -5);
			this.tsMenu.Name = "tsMenu";
			this.tsMenu.Size = new System.Drawing.Size(170, 25);
			this.tsMenu.TabIndex = 282;
			this.tsMenu.TabStop = true;
			this.tsMenu.Text = "Special Billing Menu";
			// 
			// btnchange
			// 
			this.btnchange.Image = ((System.Drawing.Image)(resources.GetObject("btnchange.Image")));
			this.btnchange.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnchange.Name = "btnchange";
			this.btnchange.Size = new System.Drawing.Size(102, 22);
			this.btnchange.Text = "Change Meter";
			this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
			// 
			// btnClose
			// 
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(56, 20);
			this.btnClose.Text = "&Close";
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
			this.gbConDtl.Location = new System.Drawing.Point(6, 22);
			this.gbConDtl.Name = "gbConDtl";
			this.gbConDtl.Size = new System.Drawing.Size(446, 85);
			this.gbConDtl.TabIndex = 281;
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
			// gbRecon
			// 
			this.gbRecon.BackColor = System.Drawing.SystemColors.ScrollBar;
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
			this.gbRecon.Location = new System.Drawing.Point(6, 113);
			this.gbRecon.Name = "gbRecon";
			this.gbRecon.Size = new System.Drawing.Size(207, 131);
			this.gbRecon.TabIndex = 283;
			this.gbRecon.TabStop = false;
			this.gbRecon.Text = "Current Meter Detail";
			// 
			// tboldrdg
			// 
			this.tboldrdg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tboldrdg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tboldrdg.Location = new System.Drawing.Point(109, 57);
			this.tboldrdg.MaxLength = 20;
			this.tboldrdg.Name = "tboldrdg";
			this.tboldrdg.ReadOnly = true;
			this.tboldrdg.Size = new System.Drawing.Size(93, 21);
			this.tboldrdg.TabIndex = 286;
			this.tboldrdg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tboprdg
			// 
			this.tboprdg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tboprdg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tboprdg.Location = new System.Drawing.Point(108, 79);
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
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.groupBox1.Controls.Add(this.tbpcode);
			this.groupBox1.Controls.Add(this.tbinitrdg);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cbnewbrand);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.tbncode);
			this.groupBox1.Controls.Add(this.dtpreplaced);
			this.groupBox1.Controls.Add(this.tbnmeterno);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.tbplumber);
			this.groupBox1.Location = new System.Drawing.Point(242, 113);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(207, 131);
			this.groupBox1.TabIndex = 284;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "New Meter Detail";
			// 
			// tbpcode
			// 
			this.tbpcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbpcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbpcode.Location = new System.Drawing.Point(6, 83);
			this.tbpcode.MaxLength = 20;
			this.tbpcode.Name = "tbpcode";
			this.tbpcode.ReadOnly = true;
			this.tbpcode.Size = new System.Drawing.Size(19, 21);
			this.tbpcode.TabIndex = 287;
			this.tbpcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbpcode.Visible = false;
			// 
			// tbinitrdg
			// 
			this.tbinitrdg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbinitrdg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbinitrdg.Location = new System.Drawing.Point(109, 57);
			this.tbinitrdg.MaxLength = 20;
			this.tbinitrdg.Name = "tbinitrdg";
			this.tbinitrdg.Size = new System.Drawing.Size(93, 21);
			this.tbinitrdg.TabIndex = 286;
			this.tbinitrdg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 13);
			this.label3.TabIndex = 285;
			this.label3.Text = "Initial Reading:";
			// 
			// cbnewbrand
			// 
			this.cbnewbrand.FormattingEnabled = true;
			this.cbnewbrand.Location = new System.Drawing.Point(109, 35);
			this.cbnewbrand.Name = "cbnewbrand";
			this.cbnewbrand.Size = new System.Drawing.Size(92, 21);
			this.cbnewbrand.TabIndex = 284;
			this.cbnewbrand.SelectedIndexChanged += new System.EventHandler(this.cbnewbrand_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(36, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 13);
			this.label5.TabIndex = 283;
			this.label5.Text = "Meter Brand:";
			// 
			// tbncode
			// 
			this.tbncode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbncode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbncode.Location = new System.Drawing.Point(181, 35);
			this.tbncode.MaxLength = 20;
			this.tbncode.Name = "tbncode";
			this.tbncode.ReadOnly = true;
			this.tbncode.Size = new System.Drawing.Size(19, 21);
			this.tbncode.TabIndex = 280;
			this.tbncode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbncode.Visible = false;
			// 
			// dtpreplaced
			// 
			this.dtpreplaced.CustomFormat = "MM/dd/yyyy";
			this.dtpreplaced.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpreplaced.Location = new System.Drawing.Point(109, 79);
			this.dtpreplaced.Name = "dtpreplaced";
			this.dtpreplaced.Size = new System.Drawing.Size(93, 21);
			this.dtpreplaced.TabIndex = 275;
			// 
			// tbnmeterno
			// 
			this.tbnmeterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbnmeterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbnmeterno.Location = new System.Drawing.Point(109, 14);
			this.tbnmeterno.MaxLength = 20;
			this.tbnmeterno.Name = "tbnmeterno";
			this.tbnmeterno.ReadOnly = true;
			this.tbnmeterno.Size = new System.Drawing.Size(93, 21);
			this.tbnmeterno.TabIndex = 263;
			this.tbnmeterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(47, 17);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 13);
			this.label7.TabIndex = 260;
			this.label7.Text = "Meter No.:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(25, 83);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(81, 13);
			this.label8.TabIndex = 258;
			this.label8.Text = "Date Replaced:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(9, 105);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(49, 13);
			this.label9.TabIndex = 256;
			this.label9.Text = "Plumber:";
			// 
			// tbplumber
			// 
			this.tbplumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbplumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbplumber.Location = new System.Drawing.Point(59, 101);
			this.tbplumber.MaxLength = 50;
			this.tbplumber.Name = "tbplumber";
			this.tbplumber.ReadOnly = true;
			this.tbplumber.Size = new System.Drawing.Size(144, 21);
			this.tbplumber.TabIndex = 255;
			this.tbplumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox2.Controls.Add(this.dgvh);
			this.groupBox2.Location = new System.Drawing.Point(6, 278);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(439, 133);
			this.groupBox2.TabIndex = 285;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Change Meter History";
			// 
			// dgvh
			// 
			this.dgvh.AllowUserToAddRows = false;
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 8.25F);
			dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
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
			this.dgvh.Size = new System.Drawing.Size(433, 113);
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
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.oldprdg.DefaultCellStyle = dataGridViewCellStyle14;
			this.oldprdg.HeaderText = "OldPRdg";
			this.oldprdg.Name = "oldprdg";
			this.oldprdg.ReadOnly = true;
			this.oldprdg.Width = 50;
			// 
			// OldLRdg
			// 
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.OldLRdg.DefaultCellStyle = dataGridViewCellStyle15;
			this.OldLRdg.HeaderText = "OldLRdg";
			this.OldLRdg.Name = "OldLRdg";
			this.OldLRdg.ReadOnly = true;
			this.OldLRdg.Width = 50;
			// 
			// oldcmu
			// 
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.oldcmu.DefaultCellStyle = dataGridViewCellStyle16;
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
			this.newmeter.Width = 60;
			// 
			// InitialRdg
			// 
			this.InitialRdg.HeaderText = "InitialRdg";
			this.InitialRdg.Name = "InitialRdg";
			this.InitialRdg.ReadOnly = true;
			this.InitialRdg.Width = 50;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(220, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 120);
			this.label2.TabIndex = 286;
			this.label2.Text = "C H A N G E  T O";
			// 
			// tbreason
			// 
			this.tbreason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbreason.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbreason.Location = new System.Drawing.Point(61, 250);
			this.tbreason.MaxLength = 200;
			this.tbreason.Name = "tbreason";
			this.tbreason.ReadOnly = true;
			this.tbreason.Size = new System.Drawing.Size(333, 21);
			this.tbreason.TabIndex = 287;
			this.tbreason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblreason
			// 
			this.lblreason.AutoSize = true;
			this.lblreason.Location = new System.Drawing.Point(11, 253);
			this.lblreason.Name = "lblreason";
			this.lblreason.Size = new System.Drawing.Size(47, 13);
			this.lblreason.TabIndex = 288;
			this.lblreason.Text = "Reason:";
			// 
			// changemeter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(455, 413);
			this.Controls.Add(this.lblreason);
			this.Controls.Add(this.tbreason);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gbRecon);
			this.Controls.Add(this.tsMenu);
			this.Controls.Add(this.gbConDtl);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "changemeter";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Change Meter";
			this.Load += new System.EventHandler(this.changemeter_Load);
			this.tsMenu.ResumeLayout(false);
			this.tsMenu.PerformLayout();
			this.gbConDtl.ResumeLayout(false);
			this.gbConDtl.PerformLayout();
			this.gbRecon.ResumeLayout(false);
			this.gbRecon.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvh)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.ToolStrip tsMenu;
		private System.Windows.Forms.ToolStripButton btnchange;
		internal System.Windows.Forms.ToolStripButton btnClose;
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
		private System.Windows.Forms.GroupBox gbRecon;
		internal System.Windows.Forms.TextBox tboldrdg;
		internal System.Windows.Forms.Label label23;
		private System.Windows.Forms.ComboBox cbBrand;
		internal System.Windows.Forms.Label label22;
		internal System.Windows.Forms.TextBox tboprdg;
		internal System.Windows.Forms.Label label21;
		internal System.Windows.Forms.TextBox tbocode;
		internal System.Windows.Forms.TextBox tbometerno;
		internal System.Windows.Forms.Label label15;
		internal System.Windows.Forms.Label label19;
		internal System.Windows.Forms.TextBox tbcumused;
		private System.Windows.Forms.GroupBox groupBox1;
		internal System.Windows.Forms.TextBox tbinitrdg;
		internal System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbnewbrand;
		internal System.Windows.Forms.Label label5;
		internal System.Windows.Forms.TextBox tbncode;
		internal System.Windows.Forms.DateTimePicker dtpreplaced;
		internal System.Windows.Forms.TextBox tbnmeterno;
		internal System.Windows.Forms.Label label7;
		internal System.Windows.Forms.Label label8;
		internal System.Windows.Forms.Label label9;
		internal System.Windows.Forms.TextBox tbplumber;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dgvh;
		private System.Windows.Forms.DataGridViewTextBoxColumn meterno;
		private System.Windows.Forms.DataGridViewTextBoxColumn ddate;
		private System.Windows.Forms.DataGridViewTextBoxColumn oldprdg;
		private System.Windows.Forms.DataGridViewTextBoxColumn OldLRdg;
		private System.Windows.Forms.DataGridViewTextBoxColumn oldcmu;
		private System.Windows.Forms.DataGridViewTextBoxColumn newmeter;
		private System.Windows.Forms.DataGridViewTextBoxColumn InitialRdg;
		internal System.Windows.Forms.TextBox tbpcode;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.TextBox tbreason;
		internal System.Windows.Forms.Label lblreason;
	}
}