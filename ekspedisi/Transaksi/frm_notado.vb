Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Public Class frm_notado
    Public transid As String = ""
    Private Sub frm_notado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim report As New NotaDO
        report.Parameters(0).Value = transid
        DocumentViewer1.DocumentSource = report
        report.CreateDocument()
        'Dim rpt As ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(report)
        'rpt.PrintDialog()
    End Sub
End Class