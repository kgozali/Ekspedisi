Public Class frm_reportprinciple 

    Private Sub frm_reportprinciple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim report As Reportprinciple = New Reportprinciple
        report.Parameters(0).Value = System.DateTime.Today.ToString
        report.Parameters(1).Value = System.DateTime.Today.ToString
        DocumentViewer1.DocumentSource = report
        report.CreateDocument()
    End Sub
End Class