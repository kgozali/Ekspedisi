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
        search()
    End Sub

    Private Sub nonaktif_CheckedChanged(sender As Object, e As EventArgs) Handles nonaktif.CheckedChanged
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
End Class