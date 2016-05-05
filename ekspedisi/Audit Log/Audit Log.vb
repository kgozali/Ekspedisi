Public Class Audit_Log 

    Private Sub Audit_Log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New XtraReport2
        Dim time As String = Scalar("select date(now())") 
        rpt.Parameters(0).Value = time
        rpt.Parameters(1).Value = time
        DocumentViewer1.DocumentSource = rpt
        rpt.CreateDocument()
    End Sub
End Class