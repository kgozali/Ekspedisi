Imports MySql.Data.MySqlClient
Public Class master_transaksi
    Dim stat As Integer = 0
    Dim query As New DataTable
    Private Sub addsiswabaru_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles addsiswabaru.ItemClick
        tambah_transaksi_sewa.ShowDialog()
    End Sub

    Public Sub master_transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        search()

    End Sub
    Private Sub search()
        Try
            If aktif.Checked = True Then
                stat = 1
            Else
                stat = 0
            End If

            If kodetransaksi.Checked = True Then
                query = DtTable("select id_tmobil `Kode Transaksi`,kode_sewa `Kode Sewa`,concat(day(tgl),' - ',monthname(tgl),' - ',year(tgl)) `Tanggal`,concat(day(tgl_nota),' - ',monthname(tgl_nota),' - ',year(tgl_nota)) `Tanggal Nota`,nama_customer `Nama Customer` from trans_mobil,mcustomer_sewa where trans_mobil.id_customer_sewa=mcustomer_sewa.id_customer_sewa and trans_mobil.s='" + stat.ToString + "' and id_tmobil LIKE '%" + cari.Text.ToString + "%' and trans_mobil.del=0")
                GridControl1.DataSource = query
            ElseIf cust.Checked = True Then
                query = DtTable("select id_tmobil `Kode Transaksi`,kode_sewa `Kode Sewa`,concat(day(tgl),' - ',monthname(tgl),' - ',year(tgl)) `Tanggal`,concat(day(tgl_nota),' - ',monthname(tgl_nota),' - ',year(tgl_nota)) `Tanggal Nota`,nama_customer `Nama Customer` from trans_mobil,mcustomer_sewa where trans_mobil.id_customer_sewa=mcustomer_sewa.id_customer_sewa and trans_mobil.s='" + stat.ToString + "' and nama_customer LIKE '%" + cari.Text.ToString + "%' and trans_mobil.del=0")
                GridControl1.DataSource = query
            ElseIf ksewa.Checked = True Then
                query = DtTable("select id_tmobil `Kode Transaksi`,kode_sewa `Kode Sewa`,concat(day(tgl),' - ',monthname(tgl),' - ',year(tgl)) `Tanggal`,concat(day(tgl_nota),' - ',monthname(tgl_nota),' - ',year(tgl_nota)) `Tanggal Nota`,nama_customer `Nama Customer` from trans_mobil,mcustomer_sewa where trans_mobil.id_customer_sewa=mcustomer_sewa.id_customer_sewa and trans_mobil.s='" + stat.ToString + "' and kode_sewa LIKE '%" + cari.Text.ToString + "%' and trans_mobil.del=0")
                GridControl1.DataSource = query
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        search()
    End Sub

    Private Sub aktif_CheckedChanged(sender As Object, e As EventArgs) Handles aktif.CheckedChanged
        If nonaktif.Checked = True Then
            deldata.Enabled = False
            edit.Enabled = False
        Else
            deldata.Enabled = True
            edit.Enabled = True
        End If
        search()
    End Sub

    Private Sub nonaktif_CheckedChanged(sender As Object, e As EventArgs) Handles nonaktif.CheckedChanged
        If nonaktif.Checked = True Then
            deldata.Enabled = False
            edit.Enabled = False
        Else
            deldata.Enabled = True
            edit.Enabled = True
        End If
        search()
    End Sub

    Private Sub cust_CheckedChanged(sender As Object, e As EventArgs) Handles cust.CheckedChanged
        search()
    End Sub

    Private Sub ksewa_CheckedChanged(sender As Object, e As EventArgs) Handles ksewa.CheckedChanged
        search()
    End Sub

    Private Sub kodetransaksi_CheckedChanged(sender As Object, e As EventArgs) Handles kodetransaksi.CheckedChanged
        search()
    End Sub

    Private Sub PreviewAndPrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviewAndPrintToolStripMenuItem.Click
        preview_invoice_sewa.idtransaksi = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi").ToString
        preview_invoice_sewa.ShowDialog()
    End Sub

    Private Sub DeleteBookingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteBookingToolStripMenuItem.Click
        If GridView1.DataRowCount < 1 Then
            MessageBox.Show("Tidak ada data yang terpilih untuk dihapus", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim int As Integer = MessageBox.Show("Apakah anda yakin ingin menghapus Transaksi " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi").ToString & "?", "System Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If int = DialogResult.Yes Then
                Dim kembali As Boolean = InsertInto("update trans_mobil set del=1 where id_tmobil='" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi").ToString & "'")
                InsertInto("DELETE FROM jurnal where no_jurnal='" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi").ToString & "'")
                InsertInto("DELETE FROM djurnal where no_jurnal='" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi").ToString & "'")
                If kembali = True Then
                    MessageBox.Show("Data " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi") & " Berhasil di Hapus", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    master_transaksi_Load(sender, e)
                End If
            Else
            End If
        End If
    End Sub

    Private Sub deldata_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles deldata.ItemClick
        If GridView1.DataRowCount < 1 Then
            MessageBox.Show("Tidak ada data yang terpilih untuk dihapus", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim int As Integer = MessageBox.Show("Apakah anda yakin ingin menghapus Transaksi " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi").ToString & "?", "System Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If int = DialogResult.Yes Then
                Dim kembali As Boolean = InsertInto("update trans_mobil set del=1 where id_tmobil='" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi").ToString & "'")
                InsertInto("DELETE FROM jurnal where no_jurnal='" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi").ToString & "'")
                InsertInto("DELETE FROM djurnal where no_jurnal='" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi").ToString & "'")
                If kembali = True Then
                    MessageBox.Show("Data " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi") & " Berhasil di Hapus", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    master_transaksi_Load(sender, e)
                End If
            Else

            End If

        End If

    End Sub

    Private Sub edit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles edit.ItemClick
        If GridView1.DataRowCount < 1 Then
            MessageBox.Show("Tidak ada data yang terpilih untuk di-Edit", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

        End If
    End Sub

    Private Sub EditBookingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditBookingToolStripMenuItem.Click
        If GridView1.DataRowCount < 1 Then
            MessageBox.Show("Tidak ada data yang terpilih untuk di-Edit", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

        End If
    End Sub
End Class