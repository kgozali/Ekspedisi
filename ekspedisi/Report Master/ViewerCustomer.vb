Public Class ViewerCustomer

    Private Sub ViewerCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New ReportMasterCustomer
        DocumentViewer1.DocumentSource = rpt
        rpt.CreateDocument()
    End Sub
End Class