Public Class frm_principledetail 

    Private Sub frm_principledetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim report As principledetail = New principledetail
        DocumentViewer1.DocumentSource = report
        report.CreateDocument()
    End Sub
End Class