Public Class lihat_slip_gaji 
    Public nomergaji As String
    Private Sub lihat_slip_gaji_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim rpt As New penggajian_DO
            rpt.Parameters(0).Value = nomergaji
            rpt.CreateDocument()
            DocumentViewer1.DocumentSource = rpt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class