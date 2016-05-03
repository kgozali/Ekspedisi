Public Class ViewerPrinciple

    Private Sub ViewerPrinciple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New ReportMasterPrinciple
        DocumentViewer1.DocumentSource = rpt
        rpt.CreateDocument()
    End Sub
End Class