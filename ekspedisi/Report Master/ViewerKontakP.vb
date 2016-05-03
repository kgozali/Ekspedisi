Public Class ViewerkontakP

    Private Sub ViewerKontakPLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New ReportMasterKontak
        DocumentViewer1.DocumentSource = rpt
        rpt.CreateDocument()
    End Sub
End Class