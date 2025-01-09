namespace bcsys.Reports
{
	partial class xrcashcollection
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
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.dataSet21 = new bcsys.Reports.DataSet2();
			this.blotID = new DevExpress.XtraReports.Parameters.Parameter();
			this.dataSet22 = new bcsys.Reports.DataSet2();
			((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet22)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// TopMargin
			// 
			this.TopMargin.Dpi = 96F;
			this.TopMargin.HeightF = 96F;
			this.TopMargin.Name = "TopMargin";
			// 
			// xrLabel3
			// 
			this.xrLabel3.Dpi = 96F;
			this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[blotterID]")});
			this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(8F, 2.959991F);
			this.xrLabel3.Multiline = true;
			this.xrLabel3.Name = "xrLabel3";
			this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrLabel3.SizeF = new System.Drawing.SizeF(96F, 22.08F);
			this.xrLabel3.Text = "xrLabel3";
			// 
			// BottomMargin
			// 
			this.BottomMargin.Dpi = 96F;
			this.BottomMargin.HeightF = 96F;
			this.BottomMargin.Name = "BottomMargin";
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel2,
            this.xrLabel1});
			this.Detail.Dpi = 96F;
			this.Detail.HeightF = 33F;
			this.Detail.Name = "Detail";
			// 
			// xrLabel4
			// 
			this.xrLabel4.Dpi = 96F;
			this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[amount]")});
			this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(329F, 0.9600067F);
			this.xrLabel4.Multiline = true;
			this.xrLabel4.Name = "xrLabel4";
			this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrLabel4.SizeF = new System.Drawing.SizeF(96F, 22.08F);
			this.xrLabel4.Text = "xrLabel4";
			this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			// 
			// xrLabel2
			// 
			this.xrLabel2.Dpi = 96F;
			this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[eorno]")});
			this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(231F, 0.9600067F);
			this.xrLabel2.Multiline = true;
			this.xrLabel2.Name = "xrLabel2";
			this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrLabel2.SizeF = new System.Drawing.SizeF(96F, 22.08F);
			this.xrLabel2.Text = "xrLabel2";
			// 
			// xrLabel1
			// 
			this.xrLabel1.Dpi = 96F;
			this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[sorno]")});
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(118F, 1.960007F);
			this.xrLabel1.Multiline = true;
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(96F, 22.08F);
			this.xrLabel1.Text = "xrLabel1";
			// 
			// dataSet21
			// 
			this.dataSet21.DataSetName = "DataSet2";
			this.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// blotID
			// 
			this.blotID.Description = "Parameter1";
			this.blotID.Name = "blotID";
			this.blotID.Type = typeof(int);
			this.blotID.ValueInfo = "0";
			// 
			// dataSet22
			// 
			this.dataSet22.DataSetName = "DataSet2";
			this.dataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// xrcashcollection
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
			this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dataSet21,
            this.dataSet22});
			this.DataMember = "cash";
			this.DataSource = this.dataSet22;
			this.Dpi = 96F;
			this.FilterString = "[blotterID] = ?blotID";
			this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
			this.Margins = new DevExpress.Drawing.DXMargins(96F, 96F, 96F, 96F);
			this.PageHeight = 1056;
			this.PageWidth = 816;
			this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.blotID, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.blotID});
			this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.Pixels;
			this.SnapGridSize = 12.5F;
			this.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.None;
			this.Version = "22.2";
			((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet22)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion

		private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		private DevExpress.XtraReports.UI.DetailBand Detail;
		private DataSet2 dataSet21;
		private DevExpress.XtraReports.UI.XRLabel xrLabel3;
		private DevExpress.XtraReports.UI.XRLabel xrLabel4;
		private DevExpress.XtraReports.UI.XRLabel xrLabel2;
		private DevExpress.XtraReports.UI.XRLabel xrLabel1;
		private DevExpress.XtraReports.Parameters.Parameter blotID;
		private DataSet2 dataSet22;
	}
}
