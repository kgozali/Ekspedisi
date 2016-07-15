Public Class tambah_master_sewa

    Private Sub add_mobil_Click(sender As Object, e As EventArgs)
        add_mobil_master.ShowDialog()
    End Sub


    Private Sub customer_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        add_customer_master_sewa.ShowDialog()
    End Sub

    Private Sub idkaryawan_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles idkaryawan.ButtonClick
        add_customer_master_sewa.ShowDialog()
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub
    Dim data As New DataTable
    'Dim sewaan As New DataTable
    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        Try
            Dim tampung As String
            If add_customer_master_sewa.mobilsewa.Rows.Count > 0 Or uncheck.Rows.Count > 0 Then
                tampung = "SELECT m.id_mobil `Kode Mobil`, tipe_mobil `Tipe Mobil`,no_pol `Nomor Polisi` FROM mmobil m where (s='1'"
                For i = 0 To add_customer_master_sewa.mobilsewa.Rows.Count - 1
                    'If i = 0 Then
                    '    tampung = tampung & " or id_mobil='" & add_customer_master_sewa.mobilsewa.Rows(i).Item(0) & "'"
                    'Else
                    tampung = tampung & " or id_mobil='" & add_customer_master_sewa.mobilsewa.Rows(i).Item(0) & "'"
                    'End If

                Next i
                For i = 0 To uncheck.Rows.Count - 1
                    'If i = 0 Then
                    '    tampung = tampung & " or id_mobil='" & uncheck.Rows(i).Item(0) & "'"
                    'Else
                    tampung = tampung & " or id_mobil='" & uncheck.Rows(i).Item(0) & "'"
                    'End If

                Next i
                tampung = tampung & ")"
            Else
                tampung = "SELECT m.id_mobil `Kode Mobil`, tipe_mobil `Tipe Mobil`,no_pol `Nomor Polisi` FROM mmobil m where s='1'"
            End If
            If nama.Checked = True Then
                tampung = tampung & " and no_pol like '%" & cari.Text & "%'"
            Else
                tampung = tampung & " and id_mobil like '%" & cari.Text & "%'"
            End If
            Dim tabel As New DataTable
            data = New DataTable
            data = DtTable(tampung)
            tabel.Columns.Add("Kode Mobil")
            'sewaan.Columns.Add("Kode Mobil")
            tabel.Columns.Add("Tipe Mobil")
            tabel.Columns.Add("Nomor Polisi")
            tabel.Columns.Add("Check List", GetType(Boolean))
            For i = 0 To data.Rows.Count - 1
                tabel.Rows.Add(data.Rows(i).Item(0), data.Rows(i).Item(1), data.Rows(i).Item(2), False)
            Next i
            GridControl1.DataSource = tabel
            For i = 0 To GridView1.RowCount - 1
                For k = 0 To pilihan.Rows.Count - 1
                    If GridView1.GetRowCellValue(i, "Kode Mobil") = pilihan.Rows(k).Item(0) Then
                        With GridView1
                            .SetRowCellValue(i, "Check List", True)
                        End With
                    End If
                Next k
            Next i


        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public pilihan As New DataTable
    Dim uncheck As New DataTable
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Try
            If namakaryawan.Text = "" Then
                MessageBox.Show("Pilih customer terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                'InsertInto("delete from dmaster_customer_sewa where id_customer='" & namakaryawan.Text & "'")
                Dim sudahsewa As New DataTable
                Dim sewaaktif As New DataTable
                sudahsewa = DtTable("SELECT m.id_mobil `Kode Mobil`, tipe_mobil `Tipe Mobil`,no_pol `Nomor Polisi`,d.s `status` FROM mmobil m,dmaster_customer_sewa d where m.id_mobil=d.id_mobil and id_customer='" & namakaryawan.Text & "'")
                'sewaaktif = DtTable("SELECT m.id_mobil `Kode Mobil`, tipe_mobil `Tipe Mobil`,no_pol `Nomor Polisi` FROM mmobil m,dmaster_customer_sewa d where m.id_mobil=d.id_mobil and id_customer='" & namakaryawan.Text & "' and d.s='1'")
                For i = 0 To pilihan.Rows.Count - 1
                    Dim cek As Boolean = False
                    Dim aktif As Boolean = False
                    For k = 0 To sudahsewa.Rows.Count - 1
                        'If pilihan.Rows(i).Item(0) = sudahsewa.Rows(k).Item(0) And sudahsewa.Rows(k).Item(3) = "0" Then
                        '    cek = True
                        'ElseIf pilihan.Rows(i).Item(0) = sudahsewa.Rows(k).Item(0) And sudahsewa.Rows(k).Item(3) = "1" Then
                        '    cek = True
                        '    aktif = True
                        'End If
                        If pilihan.Rows(i).Item(0) = sudahsewa.Rows(k).Item(0) Then
                            cek = True
                            If sudahsewa.Rows(k).Item(3) = "1" Then
                                aktif = True
                            End If
                        End If
                        'If cek = False And sudahsewa.Rows(k).Item(3) = "1" Then
                        '    InsertInto("update dmaster_customer_sewa set s='0' where id_customer='" & namakaryawan.Text & "' and id_mobil='" & sudahsewa.Rows(k).Item(0) & "'")
                        '    InsertInto("update mmobil set s='1' where id_mobil='" & sudahsewa.Rows(k).Item(0) & "'")
                        'End If
                    Next k

                    If cek = False Then
                        InsertInto("insert into dmaster_customer_sewa values ('" & namakaryawan.Text & "','" & pilihan.Rows(i).Item(0) & "','1')")
                        InsertInto("update mmobil set s='0' where id_mobil='" & GridView1.GetRowCellValue(i, "Kode Mobil") & "'")
                    ElseIf cek = True And aktif = False Then
                        InsertInto("update dmaster_customer_sewa set s='1' where id_customer='" & namakaryawan.Text & "' and id_mobil='" & pilihan.Rows(i).Item(0) & "'")
                        InsertInto("update mmobil set s='0' where id_mobil='" & pilihan.Rows(i).Item(0) & "'")
                    End If
                    'InsertInto("update mmobil set s='1' where id_mobil='" & GridView1.GetRowCellValue(i, "Kode Mobil") & "'")


                Next i

                For j = 0 To uncheck.Rows.Count - 1
                    InsertInto("update dmaster_customer_sewa set s='0' where id_customer='" & namakaryawan.Text & "' and id_mobil='" & uncheck.Rows(j).Item(0) & "'")
                    InsertInto("update mmobil set s='1' where id_mobil='" & uncheck.Rows(j).Item(0) & "'")
                Next j

                MessageBox.Show("Data berhasil disimpan", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GridView1_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        Try
            If uncheck.Columns.Count = 0 Then
                uncheck.Columns.Add("Kode Mobil")
                uncheck.Columns.Add("Tipe Mobil")
                uncheck.Columns.Add("Nomor Polisi")
                uncheck.Columns.Add("Check List")
            End If
            If e.Column.FieldName = "Check List" Then
                If e.Value = True Then
                    If uncheck.Rows.Count = 0 Then
                        pilihan.Rows.Add(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Mobil"), GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Tipe Mobil"), GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Nomor Polisi"), True)
                    Else
                        Dim syarat As Boolean = False
                        For i = 0 To uncheck.Rows.Count - 1
                            If syarat = False Then
                                If uncheck.Rows(i).Item(0) = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Mobil") Then
                                    pilihan.Rows.Add(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Mobil"), GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Tipe Mobil"), GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Nomor Polisi"), True)
                                    uncheck.Rows.RemoveAt(i)
                                    syarat = True
                                End If
                            End If
                        Next i
                    End If
                ElseIf e.Value = False Then
                    Dim syarat As Boolean = False
                    For i = 0 To pilihan.Rows.Count - 1
                        If syarat = False Then
                            If pilihan.Rows(i).Item(0) = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Mobil") Then
                                uncheck.Rows.Add(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Mobil"), GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Tipe Mobil"), GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Nomor Polisi"), True)
                                pilihan.Rows.RemoveAt(i)
                                syarat = True
                            End If
                        End If
                    Next i
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub namakaryawan_TextChanged(sender As Object, e As EventArgs) Handles namakaryawan.TextChanged
        uncheck.Rows.Clear()
        pilihan.Rows.Clear()
    End Sub
End Class