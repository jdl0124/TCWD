namespace bcsys.Forms.EntryForms
{
    partial class libsearch
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(libsearch));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.DataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.dgv = new System.Windows.Forms.DataGridView();
			this.accountno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tsMenu = new System.Windows.Forms.ToolStrip();
			this.tsbDelete = new System.Windows.Forms.ToolStripButton();
			this.tsbSelect = new System.Windows.Forms.ToolStripButton();
			this.tsbClose = new System.Windows.Forms.ToolStripButton();
			this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.tsMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// DataGridViewTextBoxColumn7
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle1.Format = "n2";
			this.DataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle1;
			this.DataGridViewTextBoxColumn7.HeaderText = "Price/Pc";
			this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
			this.DataGridViewTextBoxColumn7.Width = 80;
			// 
			// DataGridViewTextBoxColumn5
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "n10";
			this.DataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle2;
			this.DataGridViewTextBoxColumn5.HeaderText = "Addres";
			this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
			this.DataGridViewTextBoxColumn5.ReadOnly = true;
			this.DataGridViewTextBoxColumn5.Width = 250;
			// 
			// DataGridViewTextBoxColumn4
			// 
			this.DataGridViewTextBoxColumn4.HeaderText = "MeterNo";
			this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
			this.DataGridViewTextBoxColumn4.ReadOnly = true;
			this.DataGridViewTextBoxColumn4.Visible = false;
			this.DataGridViewTextBoxColumn4.Width = 80;
			// 
			// DataGridViewTextBoxColumn3
			// 
			this.DataGridViewTextBoxColumn3.HeaderText = "BatchCode";
			this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
			this.DataGridViewTextBoxColumn3.ReadOnly = true;
			this.DataGridViewTextBoxColumn3.Visible = false;
			this.DataGridViewTextBoxColumn3.Width = 50;
			// 
			// DataGridViewTextBoxColumn2
			// 
			this.DataGridViewTextBoxColumn2.HeaderText = "Customer Name";
			this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
			this.DataGridViewTextBoxColumn2.ReadOnly = true;
			this.DataGridViewTextBoxColumn2.Width = 350;
			// 
			// DataGridViewTextBoxColumn1
			// 
			this.DataGridViewTextBoxColumn1.HeaderText = "Account No.";
			this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
			this.DataGridViewTextBoxColumn1.ReadOnly = true;
			this.DataGridViewTextBoxColumn1.Width = 90;
			// 
			// tbSearch
			// 
			this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSearch.Location = new System.Drawing.Point(6, 2);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(187, 20);
			this.tbSearch.TabIndex = 9;
			// 
			// dgv
			// 
			this.dgv.AllowUserToAddRows = false;
			this.dgv.AllowUserToResizeRows = false;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountno,
            this.CustomerName});
			this.dgv.Location = new System.Drawing.Point(6, 28);
			this.dgv.Name = "dgv";
			this.dgv.ReadOnly = true;
			this.dgv.RowHeadersVisible = false;
			this.dgv.RowHeadersWidth = 20;
			this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv.Size = new System.Drawing.Size(300, 283);
			this.dgv.TabIndex = 7;
			// 
			// accountno
			// 
			this.accountno.HeaderText = "Description";
			this.accountno.Name = "accountno";
			this.accountno.ReadOnly = true;
			this.accountno.Width = 200;
			// 
			// CustomerName
			// 
			this.CustomerName.HeaderText = "Code";
			this.CustomerName.Name = "CustomerName";
			this.CustomerName.ReadOnly = true;
			this.CustomerName.Width = 80;
			// 
			// tsMenu
			// 
			this.tsMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.tsMenu.Dock = System.Windows.Forms.DockStyle.None;
			this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDelete,
            this.tsbSelect,
            this.tsbClose});
			this.tsMenu.Location = new System.Drawing.Point(125, 316);
			this.tsMenu.Name = "tsMenu";
			this.tsMenu.Size = new System.Drawing.Size(186, 25);
			this.tsMenu.TabIndex = 8;
			this.tsMenu.Text = "Menu";
			// 
			// tsbDelete
			// 
			this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
			this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbDelete.Name = "tsbDelete";
			this.tsbDelete.Size = new System.Drawing.Size(60, 22);
			this.tsbDelete.Text = "&Delete";
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
			// tsbClose
			// 
			this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
			this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbClose.Name = "tsbClose";
			this.tsbClose.Size = new System.Drawing.Size(56, 22);
			this.tsbClose.Text = "&Close";
			this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
			// 
			// DataGridViewTextBoxColumn6
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle5.Format = "n2";
			this.DataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle5;
			this.DataGridViewTextBoxColumn6.HeaderText = "Addres";
			this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
			this.DataGridViewTextBoxColumn6.ReadOnly = true;
			this.DataGridViewTextBoxColumn6.Width = 250;
			// 
			// libsearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(315, 343);
			this.Controls.Add(this.tbSearch);
			this.Controls.Add(this.dgv);
			this.Controls.Add(this.tsMenu);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "libsearch";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Library Search";
			this.Load += new System.EventHandler(this.libsearch_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.tsMenu.ResumeLayout(false);
			this.tsMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal System.Windows.Forms.TextBox tbSearch;
        internal System.Windows.Forms.DataGridView dgv;
        internal System.Windows.Forms.ToolStripButton tsbDelete;
        internal System.Windows.Forms.ToolStrip tsMenu;
        internal System.Windows.Forms.ToolStripButton tsbSelect;
        internal System.Windows.Forms.ToolStripButton tsbClose;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountno;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
    }
}