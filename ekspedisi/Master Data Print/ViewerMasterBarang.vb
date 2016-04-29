Public Class ViewerMasterBarang

    Private Sub ViewerMasterBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New ReportMasterBarang
        DocumentViewer1.DocumentSource = rpt
        rpt.CreateDocument()
    End Sub
End Class