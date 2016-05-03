Imports MySql.Data.MySqlClient
Public Class change_password

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Try
            If pass.Text = repass.Text Then
                InsertInto("update muser set password=md5('" & pass.Text & "') where username='" & username & "'")
                MessageBox.Show("Password Terubah", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Password Tidak Sama", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub change_password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pass.Text = ""
        repass.Text = ""
        nama.Text = main_menu.username
    End Sub
End Class