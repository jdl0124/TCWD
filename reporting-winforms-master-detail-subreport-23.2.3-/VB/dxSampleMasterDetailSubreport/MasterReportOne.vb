Imports DevExpress.XtraReports.UI

Public Class MasterReportOne
    Private Sub xrSubreport1_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xrSubreport1.BeforePrint
        Dim category = DirectCast(GetCurrentRow(), Category)
        CType(sender, XRSubreport).ReportSource.DataSource = category.Products
    End Sub
End Class
