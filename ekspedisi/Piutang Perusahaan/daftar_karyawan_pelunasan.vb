Public Class daftar_karyawan_pelunasan 

    Private Sub daftar_karyawan_pelunasan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tampung As String = "SELECT id_karyawan as `Kode Karyawan`, nama_karyawan as `Nama Karyawan`, nama_jabatan as `Jabatan`, tel1 as `Nomor Telepon 1`, tel2 as `Nomor Telepon 2`,kota as 'Kota'  FROM mkaryawan mk,mjabatan mj where mj.id_jabatan=mk.id_jabatan"
        Dim tabel As New DataTable
        tabel = DtTable(tampung)
        datakaryawan.DataSource = tabel
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        pelunansan_piutang_karyawan.idkaryawan.Text = viewdatakaryawan.GetRowCellValue(viewdatakaryawan.FocusedRowHandle, "Kode Karyawan")
        pelunansan_piutang_karyawan.namakaryawan.Text = viewdatakaryawan.GetRowCellValue(viewdatakaryawan.FocusedRowHandle, "Kode Karyawan")
        pelunansan_piutang_karyawan.jabatan.Text = viewdatakaryawan.GetRowCellValue(viewdatakaryawan.FocusedRowHandle, "Jabatan")
        pelunansan_piutang_karyawan.kotaasal.Text = viewdatakaryawan.GetRowCellValue(viewdatakaryawan.FocusedRowHandle, "Kota")
        pelunansan_piutang_karyawan.nomertelepon.Text = viewdatakaryawan.GetRowCellValue(viewdatakaryawan.FocusedRowHandle, "Nomor Telepon 1")
        Me.Close()
    End Sub
End Class