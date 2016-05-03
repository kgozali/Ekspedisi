Public Class ViewerSupir

    Private Sub ViewerSupir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New ReportMasterSupir
        DocumentViewer1.DocumentSource = rpt
        rpt.CreateDocument()
    End Sub
End Class