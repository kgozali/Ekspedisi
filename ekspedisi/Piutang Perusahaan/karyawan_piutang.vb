Public Class karyawan_piutang 

    Private Sub karyawan_piutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tampung As String = "SELECT id_karyawan as `Kode Karyawan`, nama_karyawan as `Nama Karyawan`, nama_jabatan as `Jabatan`, tel1 as `Nomor Telepon 1`, tel2 as `Nomor Telepon 2`  FROM mkaryawan mk,mjabatan mj where mj.id_jabatan=mk.id_jabatan"
        Dim tabel As New DataTable
        tabel = DtTable(tampung)
        datakaryawan.DataSource = tabel
    End Sub
End Class