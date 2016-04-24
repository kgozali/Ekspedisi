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
                    inputuser = "insert into muser values ('" & username.Text & "',md5('" & password.Text & "'),'1') "
                    InsertInto(inputuser)

                    For i = 0 To GridView1.RowCount() - 1
                        Dim name As String = GridView1.GetRowCellValue(i, "Kode Form").ToString
                        Dim a, b, c, d, e1 As String
                        If GridView1.GetRowCellValue(i, "View") = True Then
                            a = "1"
                        Else
                            a = "0"
                        End If
                        If GridView1.GetRowCellValue(i, "Baru") = True Then
                            b = "1"
                        Else
                            b = "0"
                        End If
                        If GridView1.GetRowCellValue(i, "Edit") = True Then
                            c = "1"
                        Else
                            c = "0"
                        End If
                        If GridView1.GetRowCellValue(i, "Hapus") = True Then
                            d = "1"
                        Else
                            d = "0"
                        End If
                        If GridView1.GetRowCellValue(i, "Cetak") = True Then
                            e1 = "1"
                        Else
                            e1 = "0"
                        End If
                        
                        inputuser = "insert into hak_akses values ('" & username.Text & "', '" & name & "','" & a & "','" & b & "','" & c & "','" & d & "','" & e1 & "') "
                        InsertInto(inputuser)
                    Next

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

        Dim data As New DataTable
        data = DtTable("select form_id `Kode Form`, nama_form `Nama Form` from form_akses")
        Dim baru As New DataTable
        baru.Columns.Add("Kode Form")
        baru.Columns.Add("Nama Form")
        baru.Columns.Add("View", GetType(Boolean))
        baru.Columns.Add("Baru", GetType(Boolean))
        baru.Columns.Add("Edit", GetType(Boolean))
        baru.Columns.Add("Hapus", GetType(Boolean))
        baru.Columns.Add("Cetak", GetType(Boolean))
        For i = 0 To data.Rows.Count - 1
            Dim a As String = data.Rows(i).Item("Kode Form").ToString
            Dim b As String = data.Rows(i).Item("Nama Form").ToString
            baru.Rows.Add(a, b, False, False, False, False, False)
        Next
        levelakses.DataSource = baru
    End Sub
End Class