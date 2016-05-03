Public Class viewkwitansipinjaman 
    Public penerima As String
    Private Sub viewkwitansipinjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New kwitansipembayarankaryawan
        rpt.Parameters(0).Value = penerima
        rpt.Parameters("username").Value = ""
        rpt.CreateDocument()
        DocumentViewer1.DocumentSource = rpt

    End Sub
End Class