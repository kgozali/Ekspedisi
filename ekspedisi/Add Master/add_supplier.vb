Imports MySql.Data.MySqlClient
Public Class add_supplier
    Dim inputsupplier As String = ""
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        inputsupplier = "insert into msupplier "
        InsertInto(inputsupplier)
    End Sub

    Private Sub tel1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tel1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub tel2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tel2.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub
End Class