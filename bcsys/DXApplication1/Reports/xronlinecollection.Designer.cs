﻿namespace bcsys.Reports
{
	partial class xronlinecollection
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
			this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.dataSet21 = new bcsys.Reports.DataSet2();
			this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// TopMargin
			// 
			this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2});
			this.TopMargin.Dpi = 96F;
			this.TopMargin.HeightF = 96F;
			this.TopMargin.Name = "TopMargin";
			// 
			// xrLabel2
			// 
			this.xrLabel2.Dpi = 96F;
			this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[blotterID]")});
			this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(371F, 57.95999F);
			this.xrLabel2.Multiline = true;
			this.xrLabel2.Name = "xrLabel2";
			this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrLabel2.SizeF = new System.Drawing.SizeF(96F, 22.08F);
			this.xrLabel2.Text = "xrLabel2";
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
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel1});
			this.Detail.Dpi = 96F;
			this.Detail.HeightF = 96F;
			this.Detail.Name = "Detail";
			// 
			// xrLabel4
			// 
			this.xrLabel4.Dpi = 96F;
			this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[onlineref]")});
			this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(122F, 0.9599915F);
			this.xrLabel4.Multiline = true;
			this.xrLabel4.Name = "xrLabel4";
			this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrLabel4.SizeF = new System.Drawing.SizeF(96F, 22.08F);
			this.xrLabel4.Text = "xrLabel4";
			// 
			// xrLabel3
			// 
			this.xrLabel3.Dpi = 96F;
			this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[amount]")});
			this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(367F, 3.960022F);
			this.xrLabel3.Multiline = true;
			this.xrLabel3.Name = "xrLabel3";
			this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrLabel3.SizeF = new System.Drawing.SizeF(96F, 22.08F);
			this.xrLabel3.Text = "xrLabel3";
			// 
			// xrLabel1
			// 
			this.xrLabel1.Dpi = 96F;
			this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[bankID]")});
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(3F, 2.959991F);
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
			// xrLabel5
			// 
			this.xrLabel5.Dpi = 96F;
			this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[onlinedate]")});
			this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(224F, 0.9600067F);
			this.xrLabel5.Multiline = true;
			this.xrLabel5.Name = "xrLabel5";
			this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrLabel5.SizeF = new System.Drawing.SizeF(96F, 22.08F);
			this.xrLabel5.Text = "xrLabel5";
			// 
			// xronlinecollection
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
			this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dataSet21});
			this.DataMember = "online";
			this.DataSource = this.dataSet21;
			this.Dpi = 96F;
			this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
			this.Margins = new DevExpress.Drawing.DXMargins(36F, 96F, 96F, 96F);
			this.PageHeight = 1056;
			this.PageWidth = 816;
			this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.Pixels;
			this.SnapGridSize = 12.5F;
			this.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.None;
			this.Version = "22.2";
			((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion

		private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		private DevExpress.XtraReports.UI.DetailBand Detail;
		private DevExpress.XtraReports.UI.XRLabel xrLabel2;
		private DevExpress.XtraReports.UI.XRLabel xrLabel4;
		private DevExpress.XtraReports.UI.XRLabel xrLabel3;
		private DevExpress.XtraReports.UI.XRLabel xrLabel1;
		private DataSet2 dataSet21;
		private DevExpress.XtraReports.UI.XRLabel xrLabel5;
	}
}
