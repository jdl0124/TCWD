namespace bcsys.Reports
{
	partial class test
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

		#region Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo objectConstructorInfo1 = new DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.VerticalDetail = new DevExpress.XtraReports.UI.VerticalDetailBand();
			this.label1 = new DevExpress.XtraReports.UI.XRLabel();
			this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
			this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
			this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DetailData1VerticalFirstRow = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DetailData1VerticalLastRow_Even = new DevExpress.XtraReports.UI.XRControlStyle();
			this.HeaderData1VerticalFirstRow = new DevExpress.XtraReports.UI.XRControlStyle();
			this.HeaderData1VerticalLastRow_Even = new DevExpress.XtraReports.UI.XRControlStyle();
			((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// TopMargin
			// 
			this.TopMargin.Name = "TopMargin";
			// 
			// BottomMargin
			// 
			this.BottomMargin.Name = "BottomMargin";
			// 
			// ReportHeader
			// 
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label1});
			this.ReportHeader.HeightF = 60F;
			this.ReportHeader.Name = "ReportHeader";
			// 
			// VerticalDetail
			// 
			this.VerticalDetail.Expanded = false;
			this.VerticalDetail.HeightF = 56F;
			this.VerticalDetail.KeepTogether = true;
			this.VerticalDetail.Name = "VerticalDetail";
			this.VerticalDetail.WidthF = 646.875F;
			// 
			// label1
			// 
			this.label1.LocationFloat = new DevExpress.Utils.PointFloat(163.5417F, 0F);
			this.label1.Name = "label1";
			this.label1.SizeF = new System.Drawing.SizeF(317.8592F, 24.19433F);
			this.label1.StyleName = "Title";
			this.label1.StylePriority.UseTextAlignment = false;
			this.label1.Text = "test";
			this.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			// 
			// objectDataSource1
			// 
			this.objectDataSource1.Constructor = objectConstructorInfo1;
			this.objectDataSource1.DataMember = "billdtl";
			this.objectDataSource1.DataSource = typeof(bcsys.Reports.DataSet2);
			this.objectDataSource1.Name = "objectDataSource1";
			// 
			// Title
			// 
			this.Title.BackColor = System.Drawing.Color.Transparent;
			this.Title.BorderColor = System.Drawing.Color.Black;
			this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.Title.BorderWidth = 1F;
			this.Title.Font = new DevExpress.Drawing.DXFont("Arial", 14.25F);
			this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.Title.Name = "Title";
			this.Title.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
			// 
			// PageInfo
			// 
			this.PageInfo.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
			this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.PageInfo.Name = "PageInfo";
			this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
			// 
			// DetailData1VerticalFirstRow
			// 
			this.DetailData1VerticalFirstRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
			this.DetailData1VerticalFirstRow.BorderColor = System.Drawing.Color.White;
			this.DetailData1VerticalFirstRow.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
			this.DetailData1VerticalFirstRow.BorderWidth = 2F;
			this.DetailData1VerticalFirstRow.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
			this.DetailData1VerticalFirstRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.DetailData1VerticalFirstRow.Name = "DetailData1VerticalFirstRow";
			this.DetailData1VerticalFirstRow.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
			this.DetailData1VerticalFirstRow.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// DetailData1VerticalLastRow_Even
			// 
			this.DetailData1VerticalLastRow_Even.BackColor = System.Drawing.Color.Transparent;
			this.DetailData1VerticalLastRow_Even.BorderColor = System.Drawing.Color.White;
			this.DetailData1VerticalLastRow_Even.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.DetailData1VerticalLastRow_Even.BorderWidth = 2F;
			this.DetailData1VerticalLastRow_Even.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
			this.DetailData1VerticalLastRow_Even.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.DetailData1VerticalLastRow_Even.Name = "DetailData1VerticalLastRow_Even";
			this.DetailData1VerticalLastRow_Even.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
			this.DetailData1VerticalLastRow_Even.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// HeaderData1VerticalFirstRow
			// 
			this.HeaderData1VerticalFirstRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
			this.HeaderData1VerticalFirstRow.BorderColor = System.Drawing.Color.White;
			this.HeaderData1VerticalFirstRow.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
			this.HeaderData1VerticalFirstRow.BorderWidth = 2F;
			this.HeaderData1VerticalFirstRow.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
			this.HeaderData1VerticalFirstRow.ForeColor = System.Drawing.Color.White;
			this.HeaderData1VerticalFirstRow.Name = "HeaderData1VerticalFirstRow";
			this.HeaderData1VerticalFirstRow.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
			this.HeaderData1VerticalFirstRow.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// HeaderData1VerticalLastRow_Even
			// 
			this.HeaderData1VerticalLastRow_Even.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
			this.HeaderData1VerticalLastRow_Even.BorderColor = System.Drawing.Color.White;
			this.HeaderData1VerticalLastRow_Even.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.HeaderData1VerticalLastRow_Even.BorderWidth = 2F;
			this.HeaderData1VerticalLastRow_Even.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
			this.HeaderData1VerticalLastRow_Even.ForeColor = System.Drawing.Color.White;
			this.HeaderData1VerticalLastRow_Even.Name = "HeaderData1VerticalLastRow_Even";
			this.HeaderData1VerticalLastRow_Even.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
			this.HeaderData1VerticalLastRow_Even.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// test
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.VerticalDetail});
			this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
			this.DataSource = this.objectDataSource1;
			this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
			this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.PageInfo,
            this.DetailData1VerticalFirstRow,
            this.DetailData1VerticalLastRow_Even,
            this.HeaderData1VerticalFirstRow,
            this.HeaderData1VerticalLastRow_Even});
			this.Version = "22.2";
			this.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart;
			((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion

		private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		private DevExpress.XtraReports.UI.XRLabel label1;
		private DevExpress.XtraReports.UI.VerticalDetailBand VerticalDetail;
		private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
		private DevExpress.XtraReports.UI.XRControlStyle Title;
		private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
		private DevExpress.XtraReports.UI.XRControlStyle DetailData1VerticalFirstRow;
		private DevExpress.XtraReports.UI.XRControlStyle DetailData1VerticalLastRow_Even;
		private DevExpress.XtraReports.UI.XRControlStyle HeaderData1VerticalFirstRow;
		private DevExpress.XtraReports.UI.XRControlStyle HeaderData1VerticalLastRow_Even;
	}
}
