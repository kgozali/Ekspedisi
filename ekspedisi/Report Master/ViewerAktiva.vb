Public Class ViewerAtiva

    Private Sub ViewerAktiva(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New ReportKartuAktiva
        DocumentViewer1.DocumentSource = rpt
        rpt.CreateDocument()
    End Sub
End Class