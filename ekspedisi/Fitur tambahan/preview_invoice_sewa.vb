Public Class preview_invoice_sewa 
    Public idtransaksi As String
    Private Sub preview_invoice_sewa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New invoice
        rpt.Parameters("kodetrans").Value = idtransaksi
        rpt.CreateDocument()
        DocumentViewer1.DocumentSource = rpt
    End Sub
End Class