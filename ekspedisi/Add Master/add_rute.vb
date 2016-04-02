Imports MySql.Data.MySqlClient
Public Class add_rute
    Dim inputrute As String = ""
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        inputrute = "insert into "
        InsertInto(inputrute)
    End Sub

    Private Sub hargaunit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles hargaunit.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub unit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles unit.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub add_rute_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class