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
                MessageBox.Show("Username Salah", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                username.Text = ""
            Else
                Dim check2 As String = "select username, password from muser where username = '" & username.Text & "' and password = md5('" & password.Text & "') "
                Dim simpan2 As New DataTable
                simpan2 = DtTable(check2)
                If simpan2.Rows.Count = 0 Then
                    MessageBox.Show("Password Salah", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    main_menu.ShowDialog()
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

End Class