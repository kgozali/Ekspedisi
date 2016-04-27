Imports MySql.Data.MySqlClient
Public Class edit_kir_truk
    Dim query As New DataTable
    Private Sub edit_kir_truk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = DtTable("select * from kir where id_kir='" + TextEdit1.Text.ToString + "'")
        TextEdit2.Text = query.Rows(0).Item("no_kir").ToString
        DateTimePicker2.Value = query.Rows(0).Item("tgl_kir")
        DateTimePicker1.Value = query.Rows(0).Item("tgl_kir_berikutnya")
        TextEdit3.Text = query.Rows(0).Item("nominal").ToString
    End Sub
End Class