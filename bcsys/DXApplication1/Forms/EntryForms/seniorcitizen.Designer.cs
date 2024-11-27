namespace bcsys.Forms.EntryForms
{
	partial class seniorcitizen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seniorcitizen));
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.tbtin = new System.Windows.Forms.TextBox();
			this.tbidno = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.gbdates = new System.Windows.Forms.GroupBox();
			this.dtps = new System.Windows.Forms.DateTimePicker();
			this.label19 = new System.Windows.Forms.Label();
			this.dtpe = new System.Windows.Forms.DateTimePicker();
			this.label18 = new System.Windows.Forms.Label();
			this.cbsc = new System.Windows.Forms.CheckBox();
			this.tsMenu = new System.Windows.Forms.ToolStrip();
			this.btnPost = new System.Windows.Forms.ToolStripButton();
			this.btnClose = new System.Windows.Forms.ToolStripButton();
			this.lblstat = new System.Windows.Forms.Label();
			this.gbConDtl.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.gbdates.SuspendLayout();
			this.tsMenu.SuspendLayout();
			this.SuspendLayout();
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
			this.gbConDtl.Location = new System.Drawing.Point(7, 29);
			this.gbConDtl.Name = "gbConDtl";
			this.gbConDtl.Size = new System.Drawing.Size(446, 85);
			this.gbConDtl.TabIndex = 245;
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
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.groupBox1.Controls.Add(this.Label10);
			this.groupBox1.Controls.Add(this.tbtin);
			this.groupBox1.Controls.Add(this.tbidno);
			this.groupBox1.Controls.Add(this.Label11);
			this.groupBox1.Location = new System.Drawing.Point(7, 120);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(163, 67);
			this.groupBox1.TabIndex = 252;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Additional Info";
			// 
			// Label10
			// 
			this.Label10.AutoSize = true;
			this.Label10.Location = new System.Drawing.Point(21, 19);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(28, 13);
			this.Label10.TabIndex = 252;
			this.Label10.Text = "TIN:";
			// 
			// tbtin
			// 
			this.tbtin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbtin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbtin.Location = new System.Drawing.Point(53, 16);
			this.tbtin.MaxLength = 10;
			this.tbtin.Name = "tbtin";
			this.tbtin.Size = new System.Drawing.Size(106, 21);
			this.tbtin.TabIndex = 251;
			this.tbtin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tbidno
			// 
			this.tbidno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbidno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbidno.Location = new System.Drawing.Point(53, 37);
			this.tbidno.MaxLength = 10;
			this.tbidno.Name = "tbidno";
			this.tbidno.Size = new System.Drawing.Size(106, 21);
			this.tbidno.TabIndex = 253;
			this.tbidno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Label11
			// 
			this.Label11.AutoSize = true;
			this.Label11.Location = new System.Drawing.Point(8, 41);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(42, 13);
			this.Label11.TabIndex = 254;
			this.Label11.Text = "ID No.:";
			// 
			// gbdates
			// 
			this.gbdates.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.gbdates.Controls.Add(this.dtps);
			this.gbdates.Controls.Add(this.label19);
			this.gbdates.Controls.Add(this.dtpe);
			this.gbdates.Controls.Add(this.label18);
			this.gbdates.Location = new System.Drawing.Point(176, 120);
			this.gbdates.Name = "gbdates";
			this.gbdates.Size = new System.Drawing.Size(172, 67);
			this.gbdates.TabIndex = 265;
			this.gbdates.TabStop = false;
			this.gbdates.Text = "Date Details";
			// 
			// dtps
			// 
			this.dtps.CustomFormat = "MM/dd/yyyy";
			this.dtps.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtps.Location = new System.Drawing.Point(69, 15);
			this.dtps.Name = "dtps";
			this.dtps.Size = new System.Drawing.Size(98, 21);
			this.dtps.TabIndex = 254;
			this.dtps.ValueChanged += new System.EventHandler(this.dtps_ValueChanged);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(10, 41);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(55, 13);
			this.label19.TabIndex = 257;
			this.label19.Text = "End Date:";
			// 
			// dtpe
			// 
			this.dtpe.CustomFormat = "MM/dd/yyyy";
			this.dtpe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpe.Location = new System.Drawing.Point(68, 37);
			this.dtpe.Name = "dtpe";
			this.dtpe.Size = new System.Drawing.Size(99, 21);
			this.dtpe.TabIndex = 255;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(5, 18);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(61, 13);
			this.label18.TabIndex = 258;
			this.label18.Text = "Start Date:";
			// 
			// cbsc
			// 
			this.cbsc.AutoSize = true;
			this.cbsc.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cbsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbsc.Location = new System.Drawing.Point(357, 129);
			this.cbsc.Name = "cbsc";
			this.cbsc.Size = new System.Drawing.Size(81, 28);
			this.cbsc.TabIndex = 266;
			this.cbsc.Text = "Senior Citizen?";
			this.cbsc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.cbsc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.cbsc.UseVisualStyleBackColor = true;
			// 
			// tsMenu
			// 
			this.tsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tsMenu.Dock = System.Windows.Forms.DockStyle.None;
			this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPost,
            this.btnClose});
			this.tsMenu.Location = new System.Drawing.Point(341, 1);
			this.tsMenu.Name = "tsMenu";
			this.tsMenu.Size = new System.Drawing.Size(119, 25);
			this.tsMenu.TabIndex = 278;
			this.tsMenu.TabStop = true;
			this.tsMenu.Text = "Special Billing Menu";
			this.tsMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsMenu_ItemClicked);
			// 
			// btnPost
			// 
			this.btnPost.Image = ((System.Drawing.Image)(resources.GetObject("btnPost.Image")));
			this.btnPost.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnPost.Name = "btnPost";
			this.btnPost.Size = new System.Drawing.Size(51, 22);
			this.btnPost.Text = "&Save";
			this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
			// 
			// btnClose
			// 
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(56, 22);
			this.btnClose.Text = "&Close";
			// 
			// lblstat
			// 
			this.lblstat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblstat.Location = new System.Drawing.Point(351, 168);
			this.lblstat.Name = "lblstat";
			this.lblstat.Size = new System.Drawing.Size(99, 17);
			this.lblstat.TabIndex = 279;
			this.lblstat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// seniorcitizen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 192);
			this.Controls.Add(this.lblstat);
			this.Controls.Add(this.tsMenu);
			this.Controls.Add(this.cbsc);
			this.Controls.Add(this.gbdates);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gbConDtl);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "seniorcitizen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Change Consumer Senior Citizen Status";
			this.gbConDtl.ResumeLayout(false);
			this.gbConDtl.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gbdates.ResumeLayout(false);
			this.gbdates.PerformLayout();
			this.tsMenu.ResumeLayout(false);
			this.tsMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

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
		private System.Windows.Forms.GroupBox groupBox1;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.TextBox tbtin;
		internal System.Windows.Forms.TextBox tbidno;
		internal System.Windows.Forms.Label Label11;
		private System.Windows.Forms.GroupBox gbdates;
		internal System.Windows.Forms.DateTimePicker dtps;
		internal System.Windows.Forms.Label label19;
		internal System.Windows.Forms.DateTimePicker dtpe;
		internal System.Windows.Forms.Label label18;
		private System.Windows.Forms.CheckBox cbsc;
		internal System.Windows.Forms.ToolStrip tsMenu;
		internal System.Windows.Forms.ToolStripButton btnPost;
		internal System.Windows.Forms.ToolStripButton btnClose;
		private System.Windows.Forms.Label lblstat;
	}
}