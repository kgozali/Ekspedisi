Imports MySql.Data.MySqlClient
Public Class edit_Supir
    Dim cbkota As New DataTable
    Private Sub edit_Supir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            id.Text = edit_list_supir.GridView1.GetRowCellValue(edit_list_supir.GridView1.FocusedRowHandle, "Kode Supir").ToString()
            nama.Text = edit_list_supir.GridView1.GetRowCellValue(edit_list_supir.GridView1.FocusedRowHandle, "Nama Supir").ToString()
            alamat.Text = edit_list_supir.GridView1.GetRowCellValue(edit_list_supir.GridView1.FocusedRowHandle.ToString, "Alamat").ToString()
            tel1.Text = edit_list_supir.GridView1.GetRowCellValue(edit_list_supir.GridView1.FocusedRowHandle.ToString, "Telepon 1").ToString()
            tel2.Text = edit_list_supir.GridView1.GetRowCellValue(edit_list_supir.GridView1.FocusedRowHandle.ToString, "Telepon 2").ToString()
            kota.Text = edit_list_supir.GridView1.GetRowCellValue(edit_list_supir.GridView1.FocusedRowHandle.ToString, "Kota").ToString()
            DateTimePicker1.Text = edit_list_supir.GridView1.GetRowCellValue(edit_list_supir.GridView1.FocusedRowHandle.ToString, "Tanggal Masuk").ToString()
            RichTextBox1.Text = edit_list_supir.GridView1.GetRowCellValue(edit_list_supir.GridView1.FocusedRowHandle.ToString, "Keterangan").ToString()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub tel1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tel1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub
    Private Sub tel2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tel2.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Select Case MsgBox("Apakah anda yakin mengedit data ini?", MsgBoxStyle.YesNo, "System Error")
            Case MsgBoxResult.Yes
                Dim ccccc As String = "update msupir set nama_Supir='" & nama.Text & "',  alamat = '" & alamat.Text & "', tel1 ='" & tel1.Text & "', tel2 = '" & tel2.Text & "',kota ='" & kota.Text & "', keterangan ='" & RichTextBox1.Text & "', tgl_masuk ='" & DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") & "' where id_Supir='" & id.Text.ToString & "'"
                InsertInto(ccccc)
                audit()
                MessageBox.Show("File Updated")
                connect.Close()
                edit_list_supir.GridView1.DeleteSelectedRows()
                Me.Close()
        End Select
    End Sub

    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Master Supir"
        Dim aktivitas As String = "Edit Supir: " & id.Text.ToString
        auditlog(user, kompname, form, aktivitas)
    End Sub

End Class