Public Class master_harga_supir 
    Dim data As New DataTable
    Private Sub addjabatanbaru_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles settings.ItemClick
        harga_supir.ShowDialog()
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub master_harga_supir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            data = DtTable("SELECT nama_supir `Nama Supir`,mr.id_rute `Kode Rute`,concat(kota_asal,' - ',kota_tujuan) `Rute`,nama_principle `Nama Principle`,tarif `Tarif`  FROM `mrute` mr,mprinciple mp,dsupir ds,msupir ms WHERE mp.id_principle=mr.id_principle and ds.id_rute=mr.id_rute and ms.id_supir=ds.id_supir")
            dataharga.DataSource = data
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        Try
            If kota.Checked = True Then
                data = DtTable("SELECT nama_supir `Nama Supir`,mr.id_rute `Kode Rute`,concat(kota_asal,' - ',kota_tujuan) `Rute`,nama_principle `Nama Principle`,tarif `Tarif`  FROM `mrute` mr,mprinciple mp,dsupir ds,msupir ms WHERE mp.id_principle=mr.id_principle and ds.id_rute=mr.id_rute and ms.id_supir=ds.id_supir and (kota_asal like '%" & cari.Text & "%' or kota_tujuan like '%" & cari.Text & "%')")
            ElseIf id.Checked = True Then
                data = DtTable("SELECT nama_supir `Nama Supir`,mr.id_rute `Kode Rute`,concat(kota_asal,' - ',kota_tujuan) `Rute`,nama_principle `Nama Principle`,tarif `Tarif`  FROM `mrute` mr,mprinciple mp,dsupir ds,msupir ms WHERE mp.id_principle=mr.id_principle and ds.id_rute=mr.id_rute and ms.id_supir=ds.id_supir and mr.id_rute like '%" & cari.Text & "%'")
            Else
                data = DtTable("SELECT nama_supir `Nama Supir`,mr.id_rute `Kode Rute`,concat(kota_asal,' - ',kota_tujuan) `Rute`,nama_principle `Nama Principle`,tarif `Tarif`  FROM `mrute` mr,mprinciple mp,dsupir ds,msupir ms WHERE mp.id_principle=mr.id_principle and ds.id_rute=mr.id_rute and ms.id_supir=ds.id_supir and nama_supir like '%" & cari.Text & "%'")
            End If
            dataharga.DataSource = data
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub jumpmenu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles jumpmenu.ItemClick
        Me.Close()
    End Sub

    Private Sub master_harga_supir_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        master_harga_supir_Load(sender, e)
    End Sub
End Class