Public Class ViewerTruk

    Private Sub ViewerTruk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New ReportMasterTruk
        DocumentViewer1.DocumentSource = rpt
        rpt.CreateDocument()
    End Sub
End Class