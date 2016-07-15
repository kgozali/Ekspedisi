Public Class Transaksi_sewa_mobil

    Private Sub addsiswabaru_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles addsiswabaru.ItemClick
        tambah_master_sewa.ShowDialog()
    End Sub

    Private Sub Transaksi_sewa_mobil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cari_EditValueChanged(sender, e)
    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        Try
            If id.Checked = True Then
                GridControl1.DataSource = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_customer `Nama Customer` FROM mcustomer_sewa m where s='1' and id_customer_sewa like '%" & cari.Text & "%'")
            ElseIf nama.Checked = True Then
                GridControl1.DataSource = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_customer `Nama Customer` FROM mcustomer_sewa m where s='1' and nama_customer like '%" & cari.Text & "%'")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub jumpmenu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles jumpmenu.ItemClick
        Me.Close()
    End Sub

    Private Sub GridControl1_MouseClick(sender As Object, e As MouseEventArgs) Handles GridControl1.MouseClick
        daftarsewa()
    End Sub


    Private Sub GridControl1_DataSourceChanged(sender As Object, e As EventArgs) Handles GridControl1.DataSourceChanged
        daftarsewa()
    End Sub

    Sub daftarsewa()
        Try
            If aktif.Checked = True Then
                GridControl2.DataSource = DtTable("SELECT d.id_mobil `Kode Mobil`,no_pol `Nomor Polisi`,tipe_mobil `Tipe Mobil` FROM dmaster_customer_sewa d,mmobil m where d.s='1' and id_customer='" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Customer") & "' and d.id_mobil=m.id_mobil")
            Else
                GridControl2.DataSource = DtTable("SELECT d.id_mobil `Kode Mobil`,no_pol `Nomor Polisi`,tipe_mobil `Tipe Mobil` FROM dmaster_customer_sewa d,mmobil m where d.s='0' and id_customer='" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Customer") & "' and d.id_mobil=m.id_mobil")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub aktif_CheckedChanged(sender As Object, e As EventArgs) Handles aktif.CheckedChanged
        daftarsewa()
    End Sub

    Private Sub deldata_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles deldata.ItemClick
        Try
            Dim result As Integer = MessageBox.Show("Apakah anda yakin ingin menghapus data sewa mobil " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Nomor Polisi") & " ?", "Delete Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                InsertInto("update dmaster_customer_sewa set s='0' where id_customer='" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Customer") & "' and id_mobil='" & GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Kode Mobil") & "'")
                InsertInto("update mmobil set s='1' where id_mobil='" & GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Kode Mobil") & "'")
                MessageBox.Show("Data berhasil dihapus", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class