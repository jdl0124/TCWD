using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace bcsys.Reports
{
	public partial class ServiceInvoiceXR : DevExpress.XtraReports.UI.XtraReport
	{
		public ServiceInvoiceXR()
		{
			InitializeComponent();
		}

        private void TopMargin_BeforePrint(object sender, CancelEventArgs e)
        {

        }
    }
}
