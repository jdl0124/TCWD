using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dxSample {
    public partial class Form1 : DevExpress.XtraBars.ToolbarForm.ToolbarForm {
        public Form1() {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            barButtonItem2.Down = false;
            var report = new MasterReport();
            report.CreateDocument();
            this.documentViewer1.DocumentSource = report;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            barButtonItem1.Down = false;
            var report = new MasterReportOne();
            report.DataSource = CategoryProductDataSource.GetData();
            report.CreateDocument();
            this.documentViewer1.DocumentSource = report;
        }


    }
}
