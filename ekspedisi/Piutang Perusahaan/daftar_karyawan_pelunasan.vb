Public Class daftar_karyawan_pelunasan 
    Dim tabel As New DataTable
    Private Sub daftar_karyawan_pelunasan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tampung As String = "SELECT id_karyawan as `Kode Karyawan`, nama_karyawan as `Nama Karyawan`, nama_jabatan as `Jabatan`, tel1 as `Nomor Telepon 1`, tel2 as `Nomor Telepon 2`,kota as 'Kota'  FROM mkaryawan mk,mjabatan mj where mj.id_jabatan=mk.id_jabatan and mk.s='1'"

        tabel = DtTable(tampung)
        datakaryawan.DataSource = tabel
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            pelunansan_piutang_karyawan.idkaryawan.Text = viewdatakaryawan.GetRowCellValue(viewdatakaryawan.FocusedRowHandle, "Nama Karyawan")
            pelunansan_piutang_karyawan.namakaryawan.Text = viewdatakaryawan.GetRowCellValue(viewdatakaryawan.FocusedRowHandle, "Kode Karyawan")
            pelunansan_piutang_karyawan.jabatan.Text = viewdatakaryawan.GetRowCellValue(viewdatakaryawan.FocusedRowHandle, "Jabatan")
            pelunansan_piutang_karyawan.kotaasal.Text = viewdatakaryawan.GetRowCellValue(viewdatakaryawan.FocusedRowHandle, "Kota")
            pelunansan_piutang_karyawan.nomortelepon.Text = viewdatakaryawan.GetRowCellValue(viewdatakaryawan.FocusedRowHandle, "Nomor Telepon 1")
            tabel = DtTablebayar("SELECT p.id_piutangkaryawan as `Kode Piutang`,tgl `Tanggal Piutang`,jatuh_tempo `Tanggal Jatuh Tempo`,nominal `Nominal`,keterangan `Keterangan`,if(sum(jumlah_dibayar) is null,0,sum(jumlah_dibayar)) as `Terbayar`,if(nominal-sum(jumlah_dibayar) is null or nominal-sum(jumlah_dibayar)=nominal,nominal,nominal-sum(jumlah_dibayar)) as `Sisa` FROM piutang_karyawan p left join dpiutang_karyawan d on d.id_piutangkaryawan=p.id_piutangkaryawan where p.id_karyawan='" & pelunansan_piutang_karyawan.namakaryawan.Text & "' and status='1' group by p.id_piutangkaryawan;")
            pelunansan_piutang_karyawan.daftarutang.DataSource = tabel
            Dim hitung As Double = 0
            For i = 0 To tabel.Rows.Count - 1
                With pelunansan_piutang_karyawan.datapiutang
                    .SetRowCellValue(i, "Check List Bayar", False)
                End With
                hitung = hitung + tabel.Rows(i).Item("Sisa")
            Next i
            pelunansan_piutang_karyawan.totalhutang.Text = hitung.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        Try
            Dim data As New DataTable
            If id.Checked = True Then
                data = DtTable("SELECT id_karyawan as `Kode Karyawan`, nama_karyawan as `Nama Karyawan`, nama_jabatan as `Jabatan`, tel1 as `Nomor Telepon 1`, tel2 as `Nomor Telepon 2`,kota as 'Kota'  FROM mkaryawan mk,mjabatan mj where mj.id_jabatan=mk.id_jabatan and id_karyawan like '%" & cari.Text & "%' and mk.s='1'")
                datakaryawan.DataSource = data
            Else
                data = DtTable("SELECT id_karyawan as `Kode Karyawan`, nama_karyawan as `Nama Karyawan`, nama_jabatan as `Jabatan`, tel1 as `Nomor Telepon 1`, tel2 as `Nomor Telepon 2`,kota as 'Kota'  FROM mkaryawan mk,mjabatan mj where mj.id_jabatan=mk.id_jabatan and nama_karyawan like '%" & cari.Text & "%' and mk.s='1'")
                datakaryawan.DataSource = data
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub datakaryawan_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles datakaryawan.MouseDoubleClick
        Submit_Click(sender, e)
    End Sub
End Class