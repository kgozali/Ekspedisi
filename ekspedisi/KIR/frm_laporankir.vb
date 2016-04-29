Public Class frm_laporankir 

    Private Sub frm_laporankir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New laporanKIR
        DocumentViewer1.DocumentSource = rpt
        rpt.CreateDocument()
    End Sub
End Class