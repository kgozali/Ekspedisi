Public Class karyawan_piutang 

    Private Sub karyawan_piutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim tampung As String = "SELECT id_karyawan as `Kode Karyawan`, nama_karyawan as `Nama Karyawan`, nama_jabatan as `Jabatan`, tel1 as `Nomor Telepon 1`, tel2 as `Nomor Telepon 2`  FROM mkaryawan mk,mjabatan mj where mj.id_jabatan=mk.id_jabatan"
            Dim tabel As New DataTable
            tabel = DtTable(tampung)
            datakaryawan.DataSource = tabel
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            buka_piutang_karyawan.pilihkaryawan.Text = viewdatakaryawan.GetRowCellValue(viewdatakaryawan.FocusedRowHandle, "Nama Karyawan")
            buka_piutang_karyawan.idkaryawan.Text = viewdatakaryawan.GetRowCellValue(viewdatakaryawan.FocusedRowHandle, "Kode Karyawan")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub datakaryawan_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles datakaryawan.MouseDoubleClick
        Submit_Click(sender, e)
    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        Try
            Dim data As New DataTable
            If id.Checked = True Then
                data = DtTable("SELECT id_karyawan as `Kode Karyawan`, nama_karyawan as `Nama Karyawan`, nama_jabatan as `Jabatan`, tel1 as `Nomor Telepon 1`, tel2 as `Nomor Telepon 2`,kota as 'Kota'  FROM mkaryawan mk,mjabatan mj where mj.id_jabatan=mk.id_jabatan and id_karyawan like '%" & cari.Text & "%'")
                datakaryawan.DataSource = data
            Else
                data = DtTable("SELECT id_karyawan as `Kode Karyawan`, nama_karyawan as `Nama Karyawan`, nama_jabatan as `Jabatan`, tel1 as `Nomor Telepon 1`, tel2 as `Nomor Telepon 2`,kota as 'Kota'  FROM mkaryawan mk,mjabatan mj where mj.id_jabatan=mk.id_jabatan and nama_karyawan like '%" & cari.Text & "%'")
                datakaryawan.DataSource = data
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class