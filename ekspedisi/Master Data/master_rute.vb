Public Class master_rute 

    Private Sub addsiswabaru_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles addsiswabaru.ItemClick
        add_rute.ShowDialog()
    End Sub

    Private Sub ubahharga_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ubahharga.ItemClick
        form_perubahan_harga.ShowDialog()
    End Sub
End Class