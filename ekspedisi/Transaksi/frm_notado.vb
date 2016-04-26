Public Class frm_notado 
    Public transid As String = ""
    Private Sub frm_notado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim report As New NotaDO
        report.Parameters(0).Value = transid
        DocumentViewer1.DocumentSource = report
        report.CreateDocument()
    End Sub
End Class