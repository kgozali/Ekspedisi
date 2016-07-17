Public Class add_customer_master_sewa

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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub add_customer_master_sewa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cari_EditValueChanged(sender, e)
    End Sub

    Private Sub nama_CheckedChanged(sender As Object, e As EventArgs) Handles nama.CheckedChanged
        cari_EditValueChanged(sender, e)
    End Sub
    Public mobilsewa As New DataTable
    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Try
            tambah_master_sewa.namakaryawan.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Customer")
            tambah_master_sewa.idkaryawan.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Nama Customer")
            tambah_master_sewa.email.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Email")
            tambah_master_sewa.kota.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kota")
            tambah_master_sewa.nomortelepon.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Telepon 1")
            mobilsewa = New DataTable
            Dim tabel As New DataTable
            tabel.Columns.Add("Kode Mobil")
            tabel.Columns.Add("Tipe Mobil")
            tabel.Columns.Add("Nomor Polisi")
            tabel.Columns.Add("Check List", GetType(Boolean))
            mobilsewa = DtTableEdit("SELECT m.id_mobil `Kode Mobil`, tipe_mobil `Tipe Mobil`,no_pol `Nomor Polisi`,d.s `status` FROM mmobil m,dmaster_customer_sewa d where m.id_mobil=d.id_mobil and id_customer='" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Customer") & "'")
            Dim mobilsewaaktif As New DataTable
            mobilsewaaktif = DtTableEdit("SELECT m.id_mobil `Kode Mobil`, tipe_mobil `Tipe Mobil`,no_pol `Nomor Polisi` FROM mmobil m,dmaster_customer_sewa d where m.id_mobil=d.id_mobil and id_customer='" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Customer") & "' and d.s='1'")
            Dim allmobil As New DataTable
            allmobil = DtTableEdit("SELECT m.id_mobil `Kode Mobil`, tipe_mobil `Tipe Mobil`,no_pol `Nomor Polisi` FROM mmobil m where s='1'")
            For i = 0 To mobilsewa.Rows.Count - 1
                If mobilsewa.Rows(i).Item(3) = 1 Then
                    tabel.Rows.Add(mobilsewa.Rows(i).Item(0), mobilsewa.Rows(i).Item(1), mobilsewa.Rows(i).Item(2), True)
                End If
                'With GridView1
                '    .SetRowCellValue(i, "Check List Edit", True)
                'End With
            Next i

            For i = 0 To allmobil.Rows.Count - 1
                tabel.Rows.Add(allmobil.Rows(i).Item(0), allmobil.Rows(i).Item(1), allmobil.Rows(i).Item(2), False)
            Next i
            tambah_master_sewa.GridControl1.DataSource = tabel
            tambah_master_sewa.pilihan = mobilsewaaktif
            tambah_master_sewa.GroupControl3.Enabled = True
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        If submit_pelunasan.Visible = False Then
            submit_Click(sender, e)
        Else
            submit_pelunasan_Click(sender, e)
        End If
    End Sub
    Dim tabel As New DataTable
    Private Sub submit_pelunasan_Click(sender As Object, e As EventArgs) Handles submit_pelunasan.Click
        Try
            tabel = New DataTable
            tabel = DtTablebayarcek("SELECT id_tmobil `Kode Transaksi`,kode_sewa `Kode Sewa`,concat(day(tgl),'-',monthname(tgl),'-',year(tgl)) `Tanggal`,total `Total Transaksi` FROM trans_mobil t,mcustomer_sewa m where m.id_customer_sewa=t.id_customer_sewa and m.id_customer_sewa='" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Customer") & "' and t.s='1'")
            pembayaran_sewa.bayarpiutang.DataSource = tabel
            Dim angka As Double = 0
            For i = 0 To pembayaran_sewa.datapiutang.RowCount - 1
                angka = angka + pembayaran_sewa.datapiutang.GetRowCellValue(i, "Total Transaksi")
                With pembayaran_sewa.datapiutang
                    .SetRowCellValue(i, "Bayar", False)
                End With
            Next i
            pembayaran_sewa.totalpiutang.Text = angka.ToString
            pembayaran_sewa.namakeamanan = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Nama Customer")
            pembayaran_sewa.principle.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Nama Customer")
            pembayaran_sewa.idprinciple = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Customer")
            pembayaran_sewa.alamat.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Alamat")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub add_customer_master_sewa_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        submit_pelunasan.Visible = False
    End Sub
End Class