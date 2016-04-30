Public Class frm_bookingtruk 

    Private Sub frm_bookingtruk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New Nota_bookingtruk

        DocumentViewer1.DocumentSource = rpt
        rpt.CreateDocument()

    End Sub
End Class