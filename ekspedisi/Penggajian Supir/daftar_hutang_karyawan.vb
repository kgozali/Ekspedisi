Public Class daftar_hutang_karyawan 

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        daftarhutang_DoubleClick(sender, e)
    End Sub

    Private Sub daftar_hutang_karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim data As New DataTable
            data = DtTable("SELECT id_karyawan, nama_karyawan, nama_jabatan, kota, tel1 FROM  `mkaryawan` mk, mjabatan mj WHERE mj.id_jabatan = mk.id_jabatan and mk.s='1'")
            daftarhutang.DataSource = data
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub daftarhutang_DoubleClick(sender As Object, e As EventArgs) Handles daftarhutang.DoubleClick
        Try
            pelunasan_hutang_supir.idkaryawan.Text = hutang.GetRowCellValue(hutang.FocusedRowHandle, "id_karyawan")
            pelunasan_hutang_supir.namakaryawan.Text = hutang.GetRowCellValue(hutang.FocusedRowHandle, "nama_karyawan")
            pelunasan_hutang_supir.jabatan.Text = hutang.GetRowCellValue(hutang.FocusedRowHandle, "nama_jabatan")
            pelunasan_hutang_supir.kotaasal.Text = hutang.GetRowCellValue(hutang.FocusedRowHandle, "kota")
            pelunasan_hutang_supir.nomertelepon.Text = hutang.GetRowCellValue(hutang.FocusedRowHandle, "nama_karyawan")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub
End Class