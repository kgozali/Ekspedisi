Public Class login2
    Dim cek As Boolean = False
    Private Sub login2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        password.Text = ""
        username.Text = ""
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
        main_menu.quit(sender, e)
    End Sub
    Private Sub formclosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        If cek = False Then
            main_menu.quit(sender, e)
        End If
    End Sub
    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Try
            Dim check As String = "select username from muser where username = '" & username.Text & "' "
            Dim simpan As New DataTable
            simpan = DtTable(check)
            If simpan.Rows.Count = 0 Then
                MessageBox.Show("Username Salah", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                username.Text = ""
            Else
                Dim check2 As String = "select username, password from muser where username = '" & username.Text & "' and password = md5('" & password.Text & "') "
                Dim simpan2 As New DataTable
                simpan2 = DtTable(check2)
                If simpan2.Rows.Count = 0 Then
                    MessageBox.Show("Password Salah", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    cek = True
                    Me.Close()
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub
    Sub checkakses()
        Dim selectall As String = "select * from hak_akses"
        Dim tableselect As New DataTable
        tableselect = DtTable(selectall)

    End Sub

    Private Sub username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles username.KeyPress, password.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then

                If username.Text = "" Or password.Text = "" Then
                    MessageBox.Show("Harap melengkapi Username dan Password", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    login_Click(sender, e)
                End If
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class