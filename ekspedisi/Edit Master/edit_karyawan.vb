Imports MySql.Data.MySqlClient
Public Class edit_Karyawan
    Dim cbkota As New DataTable
    Dim cbjabatan As New DataTable
    Private Sub edit_Karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbkota = DtTable("select kota, provinsi from mkota where s = '1'")
            kota.DataSource = cbkota
            kota.ValueMember = "kota"
            kota.DisplayMember = "kota"

            cbjabatan = DtTable("select id_jabatan `Kode Jabatan`,nama_jabatan `Nama Jabatan` from mjabatan where `s` = 1")
            jabatan.DataSource = cbjabatan
            jabatan.DisplayMember = "Nama Jabatan"
            jabatan.ValueMember = "Kode Jabatan"

            id.Text = edit_list_karyawan.GridView1.GetRowCellValue(edit_list_karyawan.GridView1.FocusedRowHandle, "Kode Karyawan").ToString()
            nama.Text = edit_list_karyawan.GridView1.GetRowCellValue(edit_list_karyawan.GridView1.FocusedRowHandle, "Nama Karyawan").ToString()
            email.Text = edit_list_karyawan.GridView1.GetRowCellValue(edit_list_karyawan.GridView1.FocusedRowHandle.ToString, "Email").ToString()
            alamat.Text = edit_list_karyawan.GridView1.GetRowCellValue(edit_list_karyawan.GridView1.FocusedRowHandle.ToString, "Alamat").ToString()
            tel1.Text = edit_list_karyawan.GridView1.GetRowCellValue(edit_list_karyawan.GridView1.FocusedRowHandle.ToString, "Telepon 1").ToString()
            tel2.Text = edit_list_karyawan.GridView1.GetRowCellValue(edit_list_karyawan.GridView1.FocusedRowHandle.ToString, "Telepon 2").ToString()
            kota.Text = edit_list_karyawan.GridView1.GetRowCellValue(edit_list_karyawan.GridView1.FocusedRowHandle.ToString, "Kota").ToString()
            jabatan.Text = edit_list_karyawan.GridView1.GetRowCellValue(edit_list_karyawan.GridView1.FocusedRowHandle.ToString, "Jabatan").ToString()
            ktp.Text = edit_list_karyawan.GridView1.GetRowCellValue(edit_list_karyawan.GridView1.FocusedRowHandle.ToString, "No KTP").ToString()
            DateTimePicker1.Text = edit_list_karyawan.GridView1.GetRowCellValue(edit_list_karyawan.GridView1.FocusedRowHandle.ToString, "Tanggal Masuk").ToString()
            RichTextBox1.Text = edit_list_karyawan.GridView1.GetRowCellValue(edit_list_karyawan.GridView1.FocusedRowHandle.ToString, "Keterangan").ToString()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Select Case MsgBox("Apakah anda yakin mengedit data ini?", MsgBoxStyle.YesNo, "System Error")
            Case MsgBoxResult.Yes
                Dim ccccc As String = "update mkaryawan set nama_Karyawan='" & nama.Text & "', email ='" & email.Text & "', alamat = '" & alamat.Text & "', tel1 ='" & tel1.Text & "', tel2 = '" & tel2.Text & "',kota ='" & kota.Text & "', no_ktp ='" & ktp.Text & "', id_jabatan ='" & jabatan.SelectedValue.ToString & "', keterangan ='" & RichTextBox1.Text & "', tgl_masuk ='" & DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") & "' where id_Karyawan='" & id.Text.ToString & "'"
                InsertInto(ccccc)
                MessageBox.Show("File Updated")
                connect.Close()
                edit_list_karyawan.GridView1.DeleteSelectedRows()
                Me.Close()
        End Select
    End Sub

End Class