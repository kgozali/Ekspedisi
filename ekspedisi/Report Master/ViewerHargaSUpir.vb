Public Class ViewerHargaSupir

    Private Sub ViewerHargaSupir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New ReportHargaSupir
        DocumentViewer1.DocumentSource = rpt
        rpt.CreateDocument()
    End Sub
End Class