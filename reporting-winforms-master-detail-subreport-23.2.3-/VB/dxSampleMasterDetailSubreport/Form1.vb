Imports System.ComponentModel
Imports System.Text


Partial Public Class Form1
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        BarButtonItem2.Down = False
        Dim report As New MasterReport()
        report.CreateDocument()
        DocumentViewer1.DocumentSource = report
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        BarButtonItem1.Down = False
        Dim report As New MasterReportOne()
        report.DataSource = CategoryProductDataSource.GetData()
        report.CreateDocument()
        DocumentViewer1.DocumentSource = report
    End Sub
End Class
