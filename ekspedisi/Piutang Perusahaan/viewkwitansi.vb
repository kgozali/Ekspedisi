Public Class viewkwitansi 
    Public tangkap As String
    Private Sub viewkwitansi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim rpt As New kwitansi
            rpt.Parameters(0).Value = tangkap
            DocumentViewer1.DocumentSource = rpt
            rpt.CreateDocument()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class