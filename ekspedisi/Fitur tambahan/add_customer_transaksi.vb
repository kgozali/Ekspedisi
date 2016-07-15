Public Class add_customer_transaksi 

    Public data As New DataTable
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged

        Try
            If nama.Checked = True Then
                GridControl1.DataSource = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer_sewa b where b.`s`='1' and nama_customer like '%" & cari.Text & "%'")
            Else
                GridControl1.DataSource = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer_sewa b where b.`s`='1' and id_customer_sewa like '%" & cari.Text & "%'")
            End If

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).OptionsColumn.AllowEdit = False
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub nama_CheckedChanged(sender As Object, e As EventArgs) Handles nama.CheckedChanged
        cari_EditValueChanged(sender, e)
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        tambah_transaksi_sewa.customersewa = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Customer").ToString
        tambah_transaksi_sewa.idkaryawan.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Nama Customer").ToString
        tambah_transaksi_sewa.email.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Email").ToString
        tambah_transaksi_sewa.nomortelepon.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Telepon 1").ToString & "/" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Telepon 2")
        tambah_transaksi_sewa.kotaasal.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kota").ToString
        data = DtTable("SELECT dmaster_customer_sewa.id_mobil `Kode Mobil`,no_pol `No.Polisi`,tipe_mobil `Tipe Mobil`,warna `Warna`,tahun `Tahun`,harga_sewa `Harga Sewa` from mmobil,dmaster_customer_sewa where mmobil.id_mobil=dmaster_customer_sewa.id_mobil and id_customer='" + GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Customer").ToString + "'")
        tambah_transaksi_sewa.GridControl1.DataSource = data

        tambah_transaksi_sewa.GridView1.OptionsView.ShowFooter = True
        For i = 0 To tambah_transaksi_sewa.GridView1.Columns.Count - 1
            tambah_transaksi_sewa.GridView1.Columns(i).OptionsColumn.AllowEdit = False
            If tambah_transaksi_sewa.GridView1.Columns(i).FieldName.ToString = "Harga Sewa" Then
                tambah_transaksi_sewa.GridView1.Columns(i).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                tambah_transaksi_sewa.GridView1.Columns(i).SummaryItem.FieldName = "Harga Sewa"
                tambah_transaksi_sewa.GridView1.Columns(i).SummaryItem.DisplayFormat = "Total =    Rp. {0:N2} "
            End If
        Next
        Me.Close()
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        submit_Click(sender, e)
    End Sub

    Private Sub add_customer_transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cari_EditValueChanged(sender, e)
    End Sub
End Class