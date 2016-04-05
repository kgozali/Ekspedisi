Imports MySql.Data.MySqlClient
Public Class add_user
    Dim inputuser As String = ""
    Dim cek As Boolean
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub
    Private Sub add_user_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If cek = True Then
                Dim msg As Integer = MessageBox.Show("Apakah anda yakin ingin menutup form ini? Semua data yang belum disimpan akan hilang", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If msg = DialogResult.OK Then
                    add_user_Load(sender, e)
                    Reset()
                Else
                    e.Cancel = True
                End If
            Else
                add_user_Load(sender, e)
                Reset()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        If username.Text = "" Or password.Text = "" Or reenterpass.Text = "" Then
            MessageBox.Show("Mohon lengkapi data terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                If password.Text = reenterpass.Text Then
                    inputuser = "insert into muser values ('" & username.Text & "',md5('" & password.Text & "')) "
                    InsertInto(inputuser)
                    Dim msg As Integer = MsgBox("Booking berhasil dilakukan, Apakah anda ingin melakukan input kembali?", MsgBoxStyle.YesNo, "System Message")
                    If msg = DialogResult.Yes Then
                        add_user_Load(sender, e)
                        Reset()
                    Else
                        cek = False
                        Me.Close()
                    End If
                Else
                    MessageBox.Show("Password tidak sama", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    password.Text = ""
                    reenterpass.Text = ""
                End If
            Catch ex As Exception

            End Try
 
        End If

        


    End Sub

    Private Sub add_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Text = ""
        password.Text = ""
        reenterpass.Text = ""
    End Sub
End Class