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

            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        submit_Click(sender, e)
    End Sub
End Class