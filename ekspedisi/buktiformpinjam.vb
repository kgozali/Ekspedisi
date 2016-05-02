Public Class buktiformpinjam 

    Private Sub buktiformpinjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim rpt As New bukti_pinjam_supir
            rpt.Parameters("nomopiutang").Value = buka_piutang_karyawan.idbukapiutang
            rpt.Parameters("username").Value = username
            rpt.CreateDocument()
            DocumentViewer1.DocumentSource = rpt
            
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class