using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace dxSample {
    public partial class MasterReportOne : DevExpress.XtraReports.UI.XtraReport {
        public MasterReportOne() {
            InitializeComponent();
        }

        private void xrSubreport1_BeforePrint(object sender, CancelEventArgs e) {
            var category = GetCurrentRow() as Category;
            ((XRSubreport)sender).ReportSource.DataSource = category.Products;
        }
    }
}
