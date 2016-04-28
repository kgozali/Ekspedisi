Imports MySql.Data.MySqlClient
Public Class edit_kir_truk
    Dim query As New DataTable
    Private Sub edit_kir_truk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            query = DtTable("select * from kir where id_kir='" + TextEdit1.Text.ToString + "'")
            TextEdit2.Text = query.Rows(0).Item("no_kir").ToString
            DateTimePicker2.Value = query.Rows(0).Item("tgl_kir")
            DateTimePicker1.Value = query.Rows(0).Item("tgl_kir_berikutnya")
            TextEdit3.Text = query.Rows(0).Item("nominal").ToString
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class