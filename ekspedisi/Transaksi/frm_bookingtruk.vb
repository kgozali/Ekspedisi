Public Class frm_bookingtruk 
    Public bookcode As String = ""
    Private Sub frm_bookingtruk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New Nota_bookingtruk
        rpt.Parameters(0).Value = bookcode
        DocumentViewer1.DocumentSource = rpt
        rpt.CreateDocument()

    End Sub

    Private Sub PrintPreviewBarItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintPreviewBarItem8.ItemClick
        
    End Sub

    Private Sub PrintPreviewBarItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintPreviewBarItem9.ItemClick
        
    End Sub
End Class