Public Class ViewerMasterKaryawan

    Private Sub ViewerMasterKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New ReportMasteKaryawan
        DocumentViewer1.DocumentSource = rpt
        rpt.CreateDocument()
    End Sub
End Class