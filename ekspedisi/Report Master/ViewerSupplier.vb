Public Class ViewerSupplier

    Private Sub ViewerSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New ReportMasterSupplier
        DocumentViewer1.DocumentSource = rpt
        rpt.CreateDocument()
    End Sub
End Class