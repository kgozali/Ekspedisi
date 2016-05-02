Public Class view_lihat_cicilan 

    Private Sub view_lihat_cicilan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New cicilan_piutang_karyawan
        DocumentViewer1.DocumentSource = rpt
        rpt.CreateDocument()

    End Sub
End Class