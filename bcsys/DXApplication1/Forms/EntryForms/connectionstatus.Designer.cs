namespace bcsys.Forms.EntryForms
{
	partial class connectionstatus
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connectionstatus));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tsMenu = new System.Windows.Forms.ToolStrip();
			this.btnRecon = new System.Windows.Forms.ToolStripButton();
			this.btnPost = new System.Windows.Forms.ToolStripButton();
			this.btnmark = new System.Windows.Forms.ToolStripButton();
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
			this.gbdisconnect = new System.Windows.Forms.GroupBox();
			this.tbbrand = new System.Windows.Forms.TextBox();
			this.gbmstat = new System.Windows.Forms.GroupBox();
			this.rbtaping = new System.Windows.Forms.RadioButton();
			this.rbplug = new System.Windows.Forms.RadioButton();
			this.rbseal = new System.Windows.Forms.RadioButton();
			this.rbukey = new System.Windows.Forms.RadioButton();
			this.rbpout = new System.Windows.Forms.RadioButton();
			this.rbplocked = new System.Windows.Forms.RadioButton();
			this.rbna = new System.Windows.Forms.RadioButton();
			this.cbtemp = new System.Windows.Forms.CheckBox();
			this.dtpord = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpdc = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.tbmeterno = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbdorno = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbdamt = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.tbpr = new System.Windows.Forms.TextBox();
			this.tbcmu = new System.Windows.Forms.TextBox();
			this.tbcr = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvh = new System.Windows.Forms.DataGridView();
			this.meterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbRecon = new System.Windows.Forms.GroupBox();
			this.dtpactivate = new System.Windows.Forms.DateTimePicker();
			this.label18 = new System.Windows.Forms.Label();
			this.tbinitrdg = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.cbBrand = new System.Windows.Forms.ComboBox();
			this.label22 = new System.Windows.Forms.Label();
			this.tbbalance = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.tbbcode = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rbsp = new System.Windows.Forms.RadioButton();
			this.rbave = new System.Windows.Forms.RadioButton();
			this.rbflat = new System.Windows.Forms.RadioButton();
			this.rbmetered = new System.Windows.Forms.RadioButton();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.dtprecon = new System.Windows.Forms.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.tbrmeterno = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.tbror = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.tbramt = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.tsMenu.SuspendLayout();
			this.gbConDtl.SuspendLayout();
			this.gbdisconnect.SuspendLayout();
			this.gbmstat.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvh)).BeginInit();
			this.gbRecon.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tsMenu
			// 
			this.tsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tsMenu.Dock = System.Windows.Forms.DockStyle.None;
			this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRecon,
            this.btnPost,
            this.btnmark,
            this.btnClose});
			this.tsMenu.Location = new System.Drawing.Point(242, -1);
			this.tsMenu.Name = "tsMenu";
			this.tsMenu.Size = new System.Drawing.Size(322, 25);
			this.tsMenu.TabIndex = 280;
			this.tsMenu.TabStop = true;
			this.tsMenu.Text = "Special Billing Menu";
			this.tsMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsMenu_ItemClicked);
			// 
			// btnRecon
			// 
			this.btnRecon.Image = ((System.Drawing.Image)(resources.GetObject("btnRecon.Image")));
			this.btnRecon.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnRecon.Name = "btnRecon";
			this.btnRecon.Size = new System.Drawing.Size(83, 22);
			this.btnRecon.Text = "Reconnect";
			this.btnRecon.Click += new System.EventHandler(this.btnRecon_Click);
			// 
			// btnPost
			// 
			this.btnPost.Image = ((System.Drawing.Image)(resources.GetObject("btnPost.Image")));
			this.btnPost.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnPost.Name = "btnPost";
			this.btnPost.Size = new System.Drawing.Size(86, 22);
			this.btnPost.Text = "&Disconnect";
			this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
			// 
			// btnmark
			// 
			this.btnmark.Image = ((System.Drawing.Image)(resources.GetObject("btnmark.Image")));
			this.btnmark.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnmark.Name = "btnmark";
			this.btnmark.Size = new System.Drawing.Size(54, 22);
			this.btnmark.Text = "Mark";
			// 
			// btnClose
			// 
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(56, 22);
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
			this.gbConDtl.Location = new System.Drawing.Point(9, 26);
			this.gbConDtl.Name = "gbConDtl";
			this.gbConDtl.Size = new System.Drawing.Size(446, 85);
			this.gbConDtl.TabIndex = 279;
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
			// gbdisconnect
			// 
			this.gbdisconnect.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.gbdisconnect.Controls.Add(this.tbbrand);
			this.gbdisconnect.Controls.Add(this.gbmstat);
			this.gbdisconnect.Controls.Add(this.cbtemp);
			this.gbdisconnect.Controls.Add(this.dtpord);
			this.gbdisconnect.Controls.Add(this.label2);
			this.gbdisconnect.Controls.Add(this.dtpdc);
			this.gbdisconnect.Controls.Add(this.label7);
			this.gbdisconnect.Controls.Add(this.tbmeterno);
			this.gbdisconnect.Controls.Add(this.label5);
			this.gbdisconnect.Controls.Add(this.tbdorno);
			this.gbdisconnect.Controls.Add(this.label3);
			this.gbdisconnect.Controls.Add(this.tbdamt);
			this.gbdisconnect.Controls.Add(this.label8);
			this.gbdisconnect.Controls.Add(this.Label10);
			this.gbdisconnect.Controls.Add(this.Label12);
			this.gbdisconnect.Controls.Add(this.tbpr);
			this.gbdisconnect.Controls.Add(this.tbcmu);
			this.gbdisconnect.Controls.Add(this.tbcr);
			this.gbdisconnect.Controls.Add(this.Label11);
			this.gbdisconnect.Location = new System.Drawing.Point(10, 115);
			this.gbdisconnect.Name = "gbdisconnect";
			this.gbdisconnect.Size = new System.Drawing.Size(317, 237);
			this.gbdisconnect.TabIndex = 281;
			this.gbdisconnect.TabStop = false;
			this.gbdisconnect.Text = "Disconnection Details";
			// 
			// tbbrand
			// 
			this.tbbrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbbrand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbbrand.Location = new System.Drawing.Point(183, 11);
			this.tbbrand.MaxLength = 20;
			this.tbbrand.Name = "tbbrand";
			this.tbbrand.ReadOnly = true;
			this.tbbrand.Size = new System.Drawing.Size(19, 21);
			this.tbbrand.TabIndex = 280;
			this.tbbrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbbrand.Visible = false;
			// 
			// gbmstat
			// 
			this.gbmstat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.gbmstat.Controls.Add(this.rbtaping);
			this.gbmstat.Controls.Add(this.rbplug);
			this.gbmstat.Controls.Add(this.rbseal);
			this.gbmstat.Controls.Add(this.rbukey);
			this.gbmstat.Controls.Add(this.rbpout);
			this.gbmstat.Controls.Add(this.rbplocked);
			this.gbmstat.Controls.Add(this.rbna);
			this.gbmstat.Location = new System.Drawing.Point(207, 14);
			this.gbmstat.Name = "gbmstat";
			this.gbmstat.Size = new System.Drawing.Size(104, 173);
			this.gbmstat.TabIndex = 279;
			this.gbmstat.TabStop = false;
			this.gbmstat.Text = "Meter Status";
			// 
			// rbtaping
			// 
			this.rbtaping.AutoSize = true;
			this.rbtaping.Location = new System.Drawing.Point(7, 150);
			this.rbtaping.Name = "rbtaping";
			this.rbtaping.Size = new System.Drawing.Size(80, 17);
			this.rbtaping.TabIndex = 6;
			this.rbtaping.TabStop = true;
			this.rbtaping.Text = "Tapping Pt.";
			this.rbtaping.UseVisualStyleBackColor = true;
			// 
			// rbplug
			// 
			this.rbplug.AutoSize = true;
			this.rbplug.Location = new System.Drawing.Point(7, 127);
			this.rbplug.Name = "rbplug";
			this.rbplug.Size = new System.Drawing.Size(63, 17);
			this.rbplug.TabIndex = 5;
			this.rbplug.TabStop = true;
			this.rbplug.Text = "Plugged";
			this.rbplug.UseVisualStyleBackColor = true;
			// 
			// rbseal
			// 
			this.rbseal.AutoSize = true;
			this.rbseal.Location = new System.Drawing.Point(7, 108);
			this.rbseal.Name = "rbseal";
			this.rbseal.Size = new System.Drawing.Size(45, 17);
			this.rbseal.TabIndex = 4;
			this.rbseal.TabStop = true;
			this.rbseal.Text = "Seal";
			this.rbseal.UseVisualStyleBackColor = true;
			// 
			// rbukey
			// 
			this.rbukey.AutoSize = true;
			this.rbukey.Location = new System.Drawing.Point(7, 87);
			this.rbukey.Name = "rbukey";
			this.rbukey.Size = new System.Drawing.Size(67, 17);
			this.rbukey.TabIndex = 3;
			this.rbukey.TabStop = true;
			this.rbukey.Text = "Univ Key";
			this.rbukey.UseVisualStyleBackColor = true;
			// 
			// rbpout
			// 
			this.rbpout.AutoSize = true;
			this.rbpout.Location = new System.Drawing.Point(7, 65);
			this.rbpout.Name = "rbpout";
			this.rbpout.Size = new System.Drawing.Size(74, 17);
			this.rbpout.TabIndex = 2;
			this.rbpout.TabStop = true;
			this.rbpout.Text = "Pulled Out";
			this.rbpout.UseVisualStyleBackColor = true;
			// 
			// rbplocked
			// 
			this.rbplocked.AutoSize = true;
			this.rbplocked.Location = new System.Drawing.Point(7, 42);
			this.rbplocked.Name = "rbplocked";
			this.rbplocked.Size = new System.Drawing.Size(73, 17);
			this.rbplocked.TabIndex = 1;
			this.rbplocked.TabStop = true;
			this.rbplocked.Text = "Padlocked";
			this.rbplocked.UseVisualStyleBackColor = true;
			// 
			// rbna
			// 
			this.rbna.AutoSize = true;
			this.rbna.Location = new System.Drawing.Point(7, 19);
			this.rbna.Name = "rbna";
			this.rbna.Size = new System.Drawing.Size(43, 17);
			this.rbna.TabIndex = 0;
			this.rbna.TabStop = true;
			this.rbna.Text = "N/A";
			this.rbna.UseVisualStyleBackColor = true;
			// 
			// cbtemp
			// 
			this.cbtemp.AutoSize = true;
			this.cbtemp.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbtemp.Location = new System.Drawing.Point(41, 193);
			this.cbtemp.Name = "cbtemp";
			this.cbtemp.Size = new System.Drawing.Size(82, 17);
			this.cbtemp.TabIndex = 278;
			this.cbtemp.Text = "Temporary:";
			this.cbtemp.UseVisualStyleBackColor = true;
			// 
			// dtpord
			// 
			this.dtpord.CustomFormat = "MM/dd/yyyy";
			this.dtpord.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpord.Location = new System.Drawing.Point(109, 166);
			this.dtpord.Name = "dtpord";
			this.dtpord.Size = new System.Drawing.Size(93, 21);
			this.dtpord.TabIndex = 277;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(54, 170);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 276;
			this.label2.Text = "OR Date:";
			// 
			// dtpdc
			// 
			this.dtpdc.CustomFormat = "MM/dd/yyyy";
			this.dtpdc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpdc.Location = new System.Drawing.Point(109, 33);
			this.dtpdc.Name = "dtpdc";
			this.dtpdc.Size = new System.Drawing.Size(93, 21);
			this.dtpdc.TabIndex = 275;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 126);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(98, 13);
			this.label7.TabIndex = 264;
			this.label7.Text = "Disconnection Fee:";
			// 
			// tbmeterno
			// 
			this.tbmeterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbmeterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbmeterno.Location = new System.Drawing.Point(109, 11);
			this.tbmeterno.MaxLength = 20;
			this.tbmeterno.Name = "tbmeterno";
			this.tbmeterno.ReadOnly = true;
			this.tbmeterno.Size = new System.Drawing.Size(93, 21);
			this.tbmeterno.TabIndex = 263;
			this.tbmeterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(60, 145);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 13);
			this.label5.TabIndex = 262;
			this.label5.Text = "OR No.:";
			// 
			// tbdorno
			// 
			this.tbdorno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbdorno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbdorno.Location = new System.Drawing.Point(109, 143);
			this.tbdorno.MaxLength = 10;
			this.tbdorno.Name = "tbdorno";
			this.tbdorno.ReadOnly = true;
			this.tbdorno.Size = new System.Drawing.Size(93, 21);
			this.tbdorno.TabIndex = 261;
			this.tbdorno.Text = "0";
			this.tbdorno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(47, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 260;
			this.label3.Text = "Meter No.:";
			// 
			// tbdamt
			// 
			this.tbdamt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbdamt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbdamt.Location = new System.Drawing.Point(109, 122);
			this.tbdamt.MaxLength = 10;
			this.tbdamt.Name = "tbdamt";
			this.tbdamt.Size = new System.Drawing.Size(93, 21);
			this.tbdamt.TabIndex = 259;
			this.tbdamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(5, 37);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(101, 13);
			this.label8.TabIndex = 258;
			this.label8.Text = "Date Disconnected:";
			// 
			// Label10
			// 
			this.Label10.AutoSize = true;
			this.Label10.Location = new System.Drawing.Point(13, 62);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(94, 13);
			this.Label10.TabIndex = 252;
			this.Label10.Text = "Previous Reading:";
			// 
			// Label12
			// 
			this.Label12.AutoSize = true;
			this.Label12.Location = new System.Drawing.Point(15, 105);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(91, 13);
			this.Label12.TabIndex = 256;
			this.Label12.Text = "Cubic Meter Used";
			// 
			// tbpr
			// 
			this.tbpr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbpr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbpr.Location = new System.Drawing.Point(109, 59);
			this.tbpr.MaxLength = 10;
			this.tbpr.Name = "tbpr";
			this.tbpr.Size = new System.Drawing.Size(93, 21);
			this.tbpr.TabIndex = 251;
			this.tbpr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tbcmu
			// 
			this.tbcmu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbcmu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbcmu.Location = new System.Drawing.Point(109, 101);
			this.tbcmu.MaxLength = 10;
			this.tbcmu.Name = "tbcmu";
			this.tbcmu.ReadOnly = true;
			this.tbcmu.Size = new System.Drawing.Size(93, 21);
			this.tbcmu.TabIndex = 255;
			this.tbcmu.Text = "0";
			this.tbcmu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tbcr
			// 
			this.tbcr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbcr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbcr.Location = new System.Drawing.Point(109, 80);
			this.tbcr.MaxLength = 10;
			this.tbcr.Name = "tbcr";
			this.tbcr.Size = new System.Drawing.Size(93, 21);
			this.tbcr.TabIndex = 253;
			this.tbcr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Label11
			// 
			this.Label11.AutoSize = true;
			this.Label11.Location = new System.Drawing.Point(18, 83);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(90, 13);
			this.Label11.TabIndex = 254;
			this.Label11.Text = "Present Reading:";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox1.Controls.Add(this.dgvh);
			this.groupBox1.Location = new System.Drawing.Point(332, 117);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(177, 187);
			this.groupBox1.TabIndex = 282;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Disconnection History";
			// 
			// dgvh
			// 
			this.dgvh.AllowUserToAddRows = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.meterno,
            this.ddate});
			this.dgvh.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvh.Location = new System.Drawing.Point(3, 17);
			this.dgvh.Name = "dgvh";
			this.dgvh.ReadOnly = true;
			this.dgvh.RowHeadersVisible = false;
			this.dgvh.Size = new System.Drawing.Size(171, 167);
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
			this.ddate.HeaderText = "DisconDate";
			this.ddate.Name = "ddate";
			this.ddate.ReadOnly = true;
			this.ddate.Width = 70;
			// 
			// gbRecon
			// 
			this.gbRecon.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.gbRecon.Controls.Add(this.dtpactivate);
			this.gbRecon.Controls.Add(this.label18);
			this.gbRecon.Controls.Add(this.tbinitrdg);
			this.gbRecon.Controls.Add(this.label23);
			this.gbRecon.Controls.Add(this.cbBrand);
			this.gbRecon.Controls.Add(this.label22);
			this.gbRecon.Controls.Add(this.tbbalance);
			this.gbRecon.Controls.Add(this.label21);
			this.gbRecon.Controls.Add(this.tbbcode);
			this.gbRecon.Controls.Add(this.groupBox3);
			this.gbRecon.Controls.Add(this.dateTimePicker1);
			this.gbRecon.Controls.Add(this.label9);
			this.gbRecon.Controls.Add(this.dtprecon);
			this.gbRecon.Controls.Add(this.label13);
			this.gbRecon.Controls.Add(this.tbrmeterno);
			this.gbRecon.Controls.Add(this.label14);
			this.gbRecon.Controls.Add(this.tbror);
			this.gbRecon.Controls.Add(this.label15);
			this.gbRecon.Controls.Add(this.tbramt);
			this.gbRecon.Controls.Add(this.label17);
			this.gbRecon.Controls.Add(this.label19);
			this.gbRecon.Controls.Add(this.textBox6);
			this.gbRecon.Location = new System.Drawing.Point(9, 118);
			this.gbRecon.Name = "gbRecon";
			this.gbRecon.Size = new System.Drawing.Size(317, 236);
			this.gbRecon.TabIndex = 282;
			this.gbRecon.TabStop = false;
			this.gbRecon.Text = "Reconnection Details";
			// 
			// dtpactivate
			// 
			this.dtpactivate.CustomFormat = "MM/dd/yyyy";
			this.dtpactivate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpactivate.Location = new System.Drawing.Point(109, 124);
			this.dtpactivate.Name = "dtpactivate";
			this.dtpactivate.Size = new System.Drawing.Size(93, 21);
			this.dtpactivate.TabIndex = 288;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(21, 128);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(85, 13);
			this.label18.TabIndex = 287;
			this.label18.Text = "Date Activation:";
			// 
			// tbinitrdg
			// 
			this.tbinitrdg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbinitrdg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbinitrdg.Location = new System.Drawing.Point(109, 80);
			this.tbinitrdg.MaxLength = 20;
			this.tbinitrdg.Name = "tbinitrdg";
			this.tbinitrdg.ReadOnly = true;
			this.tbinitrdg.Size = new System.Drawing.Size(93, 21);
			this.tbinitrdg.TabIndex = 286;
			this.tbinitrdg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(28, 85);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(79, 13);
			this.label23.TabIndex = 285;
			this.label23.Text = "Initial Reading:";
			// 
			// cbBrand
			// 
			this.cbBrand.FormattingEnabled = true;
			this.cbBrand.Location = new System.Drawing.Point(109, 58);
			this.cbBrand.Name = "cbBrand";
			this.cbBrand.Size = new System.Drawing.Size(92, 21);
			this.cbBrand.TabIndex = 284;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(36, 62);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(70, 13);
			this.label22.TabIndex = 283;
			this.label22.Text = "Meter Brand:";
			// 
			// tbbalance
			// 
			this.tbbalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbbalance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbbalance.Location = new System.Drawing.Point(109, 16);
			this.tbbalance.MaxLength = 20;
			this.tbbalance.Name = "tbbalance";
			this.tbbalance.ReadOnly = true;
			this.tbbalance.Size = new System.Drawing.Size(93, 21);
			this.tbbalance.TabIndex = 282;
			this.tbbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(58, 18);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(48, 13);
			this.label21.TabIndex = 281;
			this.label21.Text = "Balance:";
			// 
			// tbbcode
			// 
			this.tbbcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbbcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbbcode.Location = new System.Drawing.Point(13, 56);
			this.tbbcode.MaxLength = 20;
			this.tbbcode.Name = "tbbcode";
			this.tbbcode.ReadOnly = true;
			this.tbbcode.Size = new System.Drawing.Size(19, 21);
			this.tbbcode.TabIndex = 280;
			this.tbbcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbbcode.Visible = false;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox3.Controls.Add(this.rbsp);
			this.groupBox3.Controls.Add(this.rbave);
			this.groupBox3.Controls.Add(this.rbflat);
			this.groupBox3.Controls.Add(this.rbmetered);
			this.groupBox3.Location = new System.Drawing.Point(207, 58);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(104, 109);
			this.groupBox3.TabIndex = 279;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Rate Type";
			// 
			// rbsp
			// 
			this.rbsp.AutoSize = true;
			this.rbsp.Location = new System.Drawing.Point(7, 87);
			this.rbsp.Name = "rbsp";
			this.rbsp.Size = new System.Drawing.Size(58, 17);
			this.rbsp.TabIndex = 3;
			this.rbsp.TabStop = true;
			this.rbsp.Text = "Special";
			this.rbsp.UseVisualStyleBackColor = true;
			// 
			// rbave
			// 
			this.rbave.AutoSize = true;
			this.rbave.Location = new System.Drawing.Point(7, 65);
			this.rbave.Name = "rbave";
			this.rbave.Size = new System.Drawing.Size(66, 17);
			this.rbave.TabIndex = 2;
			this.rbave.TabStop = true;
			this.rbave.Text = "Average";
			this.rbave.UseVisualStyleBackColor = true;
			// 
			// rbflat
			// 
			this.rbflat.AutoSize = true;
			this.rbflat.Location = new System.Drawing.Point(7, 42);
			this.rbflat.Name = "rbflat";
			this.rbflat.Size = new System.Drawing.Size(43, 17);
			this.rbflat.TabIndex = 1;
			this.rbflat.TabStop = true;
			this.rbflat.Text = "Flat";
			this.rbflat.UseVisualStyleBackColor = true;
			// 
			// rbmetered
			// 
			this.rbmetered.AutoSize = true;
			this.rbmetered.Location = new System.Drawing.Point(7, 19);
			this.rbmetered.Name = "rbmetered";
			this.rbmetered.Size = new System.Drawing.Size(65, 17);
			this.rbmetered.TabIndex = 0;
			this.rbmetered.TabStop = true;
			this.rbmetered.Text = "Metered";
			this.rbmetered.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(109, 211);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(93, 21);
			this.dateTimePicker1.TabIndex = 277;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(54, 215);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(52, 13);
			this.label9.TabIndex = 276;
			this.label9.Text = "OR Date:";
			// 
			// dtprecon
			// 
			this.dtprecon.CustomFormat = "MM/dd/yyyy";
			this.dtprecon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtprecon.Location = new System.Drawing.Point(109, 102);
			this.dtprecon.Name = "dtprecon";
			this.dtprecon.Size = new System.Drawing.Size(93, 21);
			this.dtprecon.TabIndex = 275;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(9, 171);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(97, 13);
			this.label13.TabIndex = 264;
			this.label13.Text = "Reconnection Fee:";
			// 
			// tbrmeterno
			// 
			this.tbrmeterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbrmeterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbrmeterno.Location = new System.Drawing.Point(109, 37);
			this.tbrmeterno.MaxLength = 20;
			this.tbrmeterno.Name = "tbrmeterno";
			this.tbrmeterno.ReadOnly = true;
			this.tbrmeterno.Size = new System.Drawing.Size(93, 21);
			this.tbrmeterno.TabIndex = 263;
			this.tbrmeterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(60, 193);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(46, 13);
			this.label14.TabIndex = 262;
			this.label14.Text = "OR No.:";
			// 
			// tbror
			// 
			this.tbror.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbror.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbror.Location = new System.Drawing.Point(109, 190);
			this.tbror.MaxLength = 10;
			this.tbror.Name = "tbror";
			this.tbror.ReadOnly = true;
			this.tbror.Size = new System.Drawing.Size(93, 21);
			this.tbror.TabIndex = 261;
			this.tbror.Text = "0";
			this.tbror.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(47, 40);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(59, 13);
			this.label15.TabIndex = 260;
			this.label15.Text = "Meter No.:";
			// 
			// tbramt
			// 
			this.tbramt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbramt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbramt.Location = new System.Drawing.Point(109, 168);
			this.tbramt.MaxLength = 10;
			this.tbramt.Name = "tbramt";
			this.tbramt.Size = new System.Drawing.Size(93, 21);
			this.tbramt.TabIndex = 259;
			this.tbramt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(6, 106);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(100, 13);
			this.label17.TabIndex = 258;
			this.label17.Text = "Date Reconnected:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(9, 150);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(98, 13);
			this.label19.TabIndex = 256;
			this.label19.Text = "Disconnection Fee:";
			// 
			// textBox6
			// 
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBox6.Location = new System.Drawing.Point(109, 146);
			this.textBox6.MaxLength = 10;
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new System.Drawing.Size(93, 21);
			this.textBox6.TabIndex = 255;
			this.textBox6.Text = "0";
			this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// connectionstatus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(531, 363);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tsMenu);
			this.Controls.Add(this.gbConDtl);
			this.Controls.Add(this.gbRecon);
			this.Controls.Add(this.gbdisconnect);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "connectionstatus";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Connection Status";
			this.Load += new System.EventHandler(this.connectionstatus_Load);
			this.tsMenu.ResumeLayout(false);
			this.tsMenu.PerformLayout();
			this.gbConDtl.ResumeLayout(false);
			this.gbConDtl.PerformLayout();
			this.gbdisconnect.ResumeLayout(false);
			this.gbdisconnect.PerformLayout();
			this.gbmstat.ResumeLayout(false);
			this.gbmstat.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvh)).EndInit();
			this.gbRecon.ResumeLayout(false);
			this.gbRecon.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.ToolStrip tsMenu;
		internal System.Windows.Forms.ToolStripButton btnPost;
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
		private System.Windows.Forms.GroupBox gbdisconnect;
		internal System.Windows.Forms.Label label7;
		internal System.Windows.Forms.TextBox tbmeterno;
		internal System.Windows.Forms.Label label5;
		internal System.Windows.Forms.TextBox tbdorno;
		internal System.Windows.Forms.Label label3;
		internal System.Windows.Forms.TextBox tbdamt;
		internal System.Windows.Forms.Label label8;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.TextBox tbpr;
		internal System.Windows.Forms.TextBox tbcmu;
		internal System.Windows.Forms.TextBox tbcr;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.DateTimePicker dtpdc;
		internal System.Windows.Forms.DateTimePicker dtpord;
		internal System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox cbtemp;
		private System.Windows.Forms.GroupBox gbmstat;
		private System.Windows.Forms.RadioButton rbna;
		private System.Windows.Forms.RadioButton rbtaping;
		private System.Windows.Forms.RadioButton rbplug;
		private System.Windows.Forms.RadioButton rbseal;
		private System.Windows.Forms.RadioButton rbukey;
		private System.Windows.Forms.RadioButton rbpout;
		private System.Windows.Forms.RadioButton rbplocked;
		private System.Windows.Forms.ToolStripButton btnmark;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgvh;
		private System.Windows.Forms.DataGridViewTextBoxColumn meterno;
		private System.Windows.Forms.DataGridViewTextBoxColumn ddate;
		internal System.Windows.Forms.TextBox tbbrand;
		private System.Windows.Forms.GroupBox gbRecon;
		internal System.Windows.Forms.TextBox tbbalance;
		internal System.Windows.Forms.Label label21;
		internal System.Windows.Forms.TextBox tbbcode;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rbsp;
		private System.Windows.Forms.RadioButton rbave;
		private System.Windows.Forms.RadioButton rbflat;
		private System.Windows.Forms.RadioButton rbmetered;
		internal System.Windows.Forms.DateTimePicker dateTimePicker1;
		internal System.Windows.Forms.Label label9;
		internal System.Windows.Forms.DateTimePicker dtprecon;
		internal System.Windows.Forms.Label label13;
		internal System.Windows.Forms.TextBox tbrmeterno;
		internal System.Windows.Forms.Label label14;
		internal System.Windows.Forms.TextBox tbror;
		internal System.Windows.Forms.Label label15;
		internal System.Windows.Forms.TextBox tbramt;
		internal System.Windows.Forms.Label label17;
		internal System.Windows.Forms.Label label19;
		internal System.Windows.Forms.TextBox textBox6;
		internal System.Windows.Forms.Label label22;
		private System.Windows.Forms.ComboBox cbBrand;
		internal System.Windows.Forms.TextBox tbinitrdg;
		internal System.Windows.Forms.Label label23;
		internal System.Windows.Forms.DateTimePicker dtpactivate;
		internal System.Windows.Forms.Label label18;
		private System.Windows.Forms.ToolStripButton btnRecon;
	}
}