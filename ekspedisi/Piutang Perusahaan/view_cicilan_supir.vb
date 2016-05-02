Public Class view_cicilan_supir 

    Private Sub view_cicilan_supir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New cicilan_piutang_supir
        DocumentViewer1.DocumentSource = rpt
        rpt.CreateDocument()
    End Sub
End Class