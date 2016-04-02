Imports MySql.Data.MySqlClient
Public Class add_user
    Dim inputuser As String = ""
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        If password.Text = reenterpass.Text Then
            inputuser = "insert into muser values ('" & username.Text & "',md5('" & password.Text & "')) "
            InsertInto(inputuser)
            MsgBox("Data Telah Terinput!")
            add_user_Load(sender, e)
        Else
            MsgBox("Password tidak sama")
            password.Text = ""
            reenterpass.Text = ""
        End If


    End Sub

    Private Sub add_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Text = ""
        password.Text = ""
        reenterpass.Text = ""
    End Sub
End Class