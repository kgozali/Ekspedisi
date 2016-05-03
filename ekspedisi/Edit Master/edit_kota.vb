Imports MySql.Data.MySqlClient
Public Class edit_kota
    Private Sub edit_kota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kota.Text = edit_list_kota.GridView1.GetRowCellValue(edit_list_kota.GridView1.FocusedRowHandle, "Nama Kota").ToString()
        provinsi.Text = edit_list_kota.GridView1.GetRowCellValue(edit_list_kota.GridView1.FocusedRowHandle, "Nama Provinsi").ToString()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Select Case MsgBox("Apakah anda yakin mengedit data ini?", MsgBoxStyle.YesNo, "System Error")
            Case MsgBoxResult.Yes
                Dim ccccc As String = "update mkota set provinsi='" & provinsi.Text & "' where kota='" & kota.Text & "'"
                InsertInto(ccccc)
                audit()
                MessageBox.Show("File Updated")
                connect.Close()
                edit_list_kota.GridView1.DeleteSelectedRows()
                Me.Close()
        End Select
    End Sub

    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Master Kota"
        Dim aktivitas As String = "Edit Kota: " & kota.Text.ToString
        auditlog(user, kompname, form, aktivitas)
    End Sub
End Class