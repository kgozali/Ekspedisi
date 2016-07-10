Public Class Transaksi_sewa_mobil 

    Private Sub addsiswabaru_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles addsiswabaru.ItemClick
        tambah_master_sewa.ShowDialog()
    End Sub

    Private Sub Transaksi_sewa_mobil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cari_EditValueChanged(sender, e)
    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        If id.Checked = True Then
            GridControl1.DataSource = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_customer `Nama Customer` FROM mcustomer_sewa m where s='1' and id_customer_sewa like '%" & cari.Text & "%'")
        Else
            GridControl1.DataSource = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_customer `Nama Customer` FROM mcustomer_sewa m where s='1' and nama_customer like '%" & cari.Text & "%'")
        End If
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub jumpmenu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles jumpmenu.ItemClick
        Me.Close()
    End Sub
End Class