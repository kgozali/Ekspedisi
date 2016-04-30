Public Class frm_bookingtruk 
    Public bookcode As String = ""
    Private Sub frm_bookingtruk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New Nota_bookingtruk
        rpt.Parameters(0).Value = bookcode
        DocumentViewer1.DocumentSource = rpt
        rpt.CreateDocument()

    End Sub
End Class