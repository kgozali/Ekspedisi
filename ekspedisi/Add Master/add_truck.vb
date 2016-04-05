Imports MySql.Data.MySqlClient
Public Class add_truck
    Dim inputtruk As String = ""
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        inputtruk = "insert into "
        InsertInto(inputtruk)
    End Sub

    Private Sub hargabeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles hargabeli.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub nilairesidu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nilairesidu.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub add_truck_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class