Public Class view_kwitansi_supir
    Public terima As String
    Private Sub view_kwitansi_supir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New kwitansi_pembayaran_piutang_supir
        rpt.Parameters("nomorpelunasan").Value = terima
        rpt.Parameters("username").Value = main_menu.username
        rpt.CreateDocument()
        DocumentViewer1.DocumentSource = rpt
    End Sub
End Class