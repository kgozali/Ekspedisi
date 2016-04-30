Public Class Audit_Log 

    Private Sub Audit_Log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New XtraReport2
        rpt.Parameters(0).Value = System.DateTime.Now
        rpt.Parameters(1).Value = System.DateTime.Now
        DocumentViewer1.DocumentSource = rpt
        rpt.CreateDocument()
    End Sub
End Class