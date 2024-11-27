namespace bcsys.Forms
{
	partial class XtraForm1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm1));
			this.rowMergeView1 = new RowMergeView();
			((System.ComponentModel.ISupportInitialize)(this.rowMergeView1)).BeginInit();
			this.SuspendLayout();
			// 
			// rowMergeView1
			// 
			this.rowMergeView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.rowMergeView1.Location = new System.Drawing.Point(21, 12);
			this.rowMergeView1.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
			this.rowMergeView1.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("rowMergeView1.MergeColumnNames")));
			this.rowMergeView1.Name = "rowMergeView1";
			this.rowMergeView1.RowTemplate.Height = 23;
			this.rowMergeView1.Size = new System.Drawing.Size(849, 565);
			this.rowMergeView1.TabIndex = 0;
			// 
			// XtraForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(930, 649);
			this.Controls.Add(this.rowMergeView1);
			this.Name = "XtraForm1";
			this.Text = "XtraForm1";
			((System.ComponentModel.ISupportInitialize)(this.rowMergeView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private RowMergeView rowMergeView1;
	}
}