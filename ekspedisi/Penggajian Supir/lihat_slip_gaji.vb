Public Class lihat_slip_gaji 
    Public nomergaji As String
    Private Sub lihat_slip_gaji_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New penggajian_DO
        rpt.Parameters(0).Value = nomergaji
        rpt.CreateDocument()
        DocumentViewer1.DocumentSource = rpt
    End Sub
End Class