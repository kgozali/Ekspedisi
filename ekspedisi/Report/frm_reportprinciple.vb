Public Class frm_reportprinciple 

    Private Sub frm_reportprinciple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim report As Reportprinciple = New Reportprinciple
        DocumentViewer1.DocumentSource = report
        report.CreateDocument()
    End Sub
End Class