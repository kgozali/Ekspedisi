Imports MySql.Data.MySqlClient
Public Class edit_user
    Dim data As New DataTable
    Private Sub edit_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            id.Text = edit_list_user.GridView1.GetRowCellValue(edit_list_user.GridView1.FocusedRowHandle, "Username").ToString()
            data = DtTable("select h.form_id `Kode Form`, nama_form `Nama Form`, View, Baru, Edit, Hapus, Cetak from hak_akses h, form_akses f where f.form_id = h.form_id and h.username = '" & id.Text & "'")
            levelakses.DataSource = data
            'For i = 0 To data.Rows.Count - 1


            'Next


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        

        Select Case MsgBox("Apakah anda yakin mengedit data ini?", MsgBoxStyle.YesNo, "System Error")
            Case MsgBoxResult.Yes
                Dim check As Boolean = True
                If CheckBox1.Checked = True Then
                    If MaskedTextBox1.Text = MaskedTextBox2.Text Then
                        InsertInto("update muser set password ='" & MaskedTextBox1.Text & "' where username = 'md5(" & id.Text & ")'")
                    Else
                        MsgBox("Password anda tidak sesuai", MsgBoxStyle.OkOnly, "System Error")
                        check = False
                    End If
                End If

                If check = True Then
                    InsertInto("delete from hak_akses where username = '" & id.Text & "'")
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
                        InsertInto("insert into hak_akses values ('" & id.Text & "', '" & name & "','" & a & "','" & b & "','" & c & "','" & d & "','" & e1 & "') ")
                        connect.Close()
                        edit_list_user.GridView1.DeleteSelectedRows()
                        Me.Close()
                    Next

                End If

                
        End Select
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            GroupControl3.Enabled = True
        Else
            GroupControl3.Enabled = False
        End If

    End Sub
End Class