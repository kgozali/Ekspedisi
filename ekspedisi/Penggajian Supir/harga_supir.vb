Public Class harga_supir
    Dim data As New DataTable
    Dim cek As Boolean = False
    Private Sub harga_supir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If datapilih.Columns.Count = 0 Then
                datapilih.Columns.Add("id", GetType(String))
                datapilih.Columns.Add("harga", GetType(Double))
            End If
            data = New DataTable
            data = DtTable("select nama_supir,id_supir from msupir where s='1'")
            If data.Rows.Count > 0 Then
                supir.DataSource = data
                supir.DisplayMember = "nama_supir"
                supir.ValueMember = "id_supir"
            End If
            data = New DataTable
            data = DtTableharga("SELECT id_rute `Kode Rute`,concat(kota_asal,' - ',kota_tujuan) `Rute`,nama_principle `Nama Principle` FROM `mrute` mr,mprinciple mp WHERE mp.id_principle=mr.id_principle")
            ambilcek()
            If data.Rows.Count > 0 Then
                hargasupir.DataSource = data
            End If
            eksekusi()
            cek = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Dim cekubah As Boolean = False
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Try
            If cekubah = True Then
                Dim a As Integer = MessageBox.Show("Data mengalami perubahan, apakah anda akan melakukan penyimpanan?", "System Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If a = DialogResult.Yes Then
                    Submit_Click(sender, e)
                    Me.Close()
                Else
                    Me.Close()
                End If
            Else
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub isidata()
        For i = 0 To dataharga.RowCount - 1
            With dataharga
                .SetRowCellValue(i, "Check List Rute", False)
                .SetRowCellValue(i, "Harga Maksimum", 0)
            End With
        Next i
    End Sub
    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        Try
            data = New DataTable
            If kota.Checked = True Then
                data = DtTableharga("SELECT id_rute `Kode Rute`,concat(kota_asal,' - ',kota_tujuan) `Rute`,nama_principle `Nama Principle` FROM `mrute` mr,mprinciple mp WHERE mp.id_principle=mr.id_principle and (kota_asal like '%" & cari.Text & "%' or kota_tujuan like '%" & cari.Text & "%')")
                hargasupir.DataSource = data
            Else
                data = DtTableharga("SELECT id_rute `Kode Rute`,concat(kota_asal,' - ',kota_tujuan) `Rute`,nama_principle `Nama Principle` FROM `mrute` mr,mprinciple mp WHERE mp.id_principle=mr.id_principle and id_rute like '%" & cari.Text & "%'")
                hargasupir.DataSource = data
            End If
            eksekusi()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub ambilcek()
        sudah = New DataTable
        sudah = DtTable("select * from dsupir where id_supir='" & supir.SelectedValue.ToString & "'")
        If sudah.Rows.Count > 0 Then
            For i = 0 To sudah.Rows.Count - 1
                datapilih.Rows.Add(sudah.Rows(i).Item("id_rute"), sudah.Rows(i).Item("tarif"))
            Next i
        End If
    End Sub

    Sub eksekusi()
        cek = False
        For i = 0 To dataharga.RowCount - 1
            With dataharga
                .SetRowCellValue(i, "Check List Rute", False)
                .SetRowCellValue(i, "Harga Maksimum", 0)
            End With
            For j = 0 To datapilih.Rows.Count - 1
                If dataharga.GetRowCellValue(i, "Kode Rute") = datapilih.Rows(j).Item("id") Then
                    With dataharga
                        .SetRowCellValue(i, "Check List Rute", True)
                        .SetRowCellValue(i, "Harga Maksimum", datapilih.Rows(j).Item("harga"))
                    End With
                End If
            Next j
        Next i
        cek = True
    End Sub

    Private Sub supir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles supir.SelectedIndexChanged
        Try
            datapilih.Clear()
            datatolak.Clear()
            ambilcek()
            data = New DataTable
            data = DtTableharga("SELECT id_rute `Kode Rute`,concat(kota_asal,' - ',kota_tujuan) `Rute`,nama_principle `Nama Principle` FROM `mrute` mr,mprinciple mp WHERE mp.id_principle=mr.id_principle")
            hargasupir.DataSource = data
            eksekusi()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Dim sudah As New DataTable
    Dim datatolak As New DataTable

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            InsertInto("delete from dsupir where id_supir='" & supir.SelectedValue.ToString & "'")
            For i = 0 To datapilih.Rows.Count - 1
                InsertInto("insert into dsupir values ('" & supir.SelectedValue.ToString & "','" & datapilih.Rows(i).Item("id").ToString & "','" & datapilih.Rows(i).Item("harga").ToString & "')")
            Next i
            supir_SelectedIndexChanged(sender, e)
            datapilih.Clear()
            MessageBox.Show("Data berhasil diupdate", "Konfirmasi Update Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            audit()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Dim keamanan As String
    Private Sub dataharga_ShownEditor(sender As Object, e As EventArgs) Handles dataharga.ShownEditor
        Try
            If dataharga.FocusedColumn.AbsoluteIndex <> 4 Then
                keamanan = dataharga.GetRowCellValue(dataharga.FocusedRowHandle, dataharga.FocusedColumn)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Dim datapilih As New DataTable
    Private Sub dataharga_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles dataharga.CellValueChanging
        Try
            If e.Column.FieldName <> "Harga Maksimum" Then
                With dataharga
                    .SetRowCellValue(.FocusedRowHandle, .FocusedColumn, keamanan)
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub harga_supir_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        datapilih.Clear()
    End Sub
    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Harga Supir"
        Dim aktivitas As String = "Edit harga maksimal supir dengan kode supir: " & supir.SelectedValue.ToString
        auditlog(user, kompname, form, aktivitas)
    End Sub
    Private Sub dataharga_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles dataharga.CellValueChanged
        Try
            If cek = True Then
                If dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Check List Rute") = True And e.Column.FieldName = "Harga Maksimum" Then
                    If e.Value > 0 Then
                        If datapilih.Rows.Count = 0 Then
                            datapilih.Rows.Add(dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Kode Rute"), e.Value)
                        Else
                            Dim kenyangklathak As Boolean = False
                            For i = 0 To datapilih.Rows.Count - 1
                                If datapilih.Rows(i).Item("id") = dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Kode Rute") Then
                                    datapilih.Rows.Add(dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Kode Rute"), e.Value)
                                    datapilih.Rows.RemoveAt(i)
                                    'error di sini, kita mo makan pak pong duluuuuu ^^
                                ElseIf kenyangklathak = False Then
                                    datapilih.Rows.Add(dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Kode Rute"), e.Value)
                                    kenyangklathak = True
                                End If
                            Next i
                        End If
                    End If
                End If
                If e.Column.FieldName = "Check List Rute" Then
                    If dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Check List Rute") = False Then
                        For i = 0 To datapilih.Rows.Count - 1
                            If datapilih.Rows(i).Item("id") = dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Kode Rute") Then
                                datapilih.Rows.RemoveAt(i)
                            End If
                        Next i
                    End If
                End If
                If e.Column.FieldName = "Check List Rute" Then
                    If dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Check List Rute") = True And dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Harga Maksimum") > 0 Then
                        Dim ada As Boolean = False
                        If datapilih.Rows.Count > 0 Then
                            For i = 0 To datapilih.Rows.Count - 1
                                If datapilih.Rows(i).Item("id") = dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Kode Rute") Then
                                    datapilih.Rows.Add(dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Kode Rute"), dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Harga Maksimum"))
                                    datapilih.Rows.RemoveAt(i)
                                    ada = True
                                End If
                            Next i
                            If ada = False Then
                                datapilih.Rows.Add(dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Kode Rute"), dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Harga Maksimum"))
                            End If
                        Else
                            datapilih.Rows.Add(dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Kode Rute"), dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Harga Maksimum"))
                        End If
                    End If
                End If
            End If
            cekubah = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dataharga_Click(sender As Object, e As EventArgs) Handles dataharga.Click
        'Try
        '    If cek = True Then
        '        If dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Check List Rute") = True Then
        '            If dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Harga Maksismum") > 0 Then
        '                datapilih.Rows.Add(dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Kode Rute"), dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Harga Maksimum"))
        '            End If
        '        End If
        '        If dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Check List Rute") = True Then
        '            For i = 0 To datapilih.Rows.Count - 1
        '                If dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Kode Rute") = datapilih.Rows(i).Item("id") Then
        '                    datatolak.Rows.Add(datapilih.Rows(i).Item("id"), datapilih.Rows(i).Item("harga"))
        '                    datapilih.Rows.RemoveAt(i)
        '                End If
        '            Next i

        '            'datatolak.Rows.Add(dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Kode Rute"), dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Harga Maksimum"))
        '        End If
        '        If dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Check List Rute") = False Then
        '            Dim ada As Boolean = False
        '            For i = 0 To datatolak.Rows.Count - 1
        '                If dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Kode Rute") = datatolak.Rows(i).Item("id") Then
        '                    datapilih.Rows.Add(datatolak.Rows(i).Item("id"), datatolak.Rows(i).Item("harga"))
        '                    datatolak.Rows.RemoveAt(i)
        '                    ada = True
        '                End If
        '            Next i
        '            If ada = False Then
        '                datapilih.Rows.Add(dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Kode Rute"), dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Harga Maksimum"))
        '            End If
        '            'datatolak.Rows.Add(dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Kode Rute"), dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Harga Maksimum"))
        '        End If
        '        'If e.Column.FieldName = "Check List Rute" And e.Value = True Then
        '        '    For i = 0 To datapilih.Rows.Count - 1
        '        '        If dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Kode Rute") = datapilih.Rows(i).Item(0) Then
        '        '            datapilih.Rows.RemoveAt(i)
        '        '            'datapilih.Rows.Add(dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Kode Rute"), dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Harga Maksimum"), False)
        '        '        End If
        '        '    Next i
        '        'End If
        '        'If e.Column.FieldName = "Check List Rute" And e.Value = True Then
        '        '    For i = 0 To datatolak.Rows.Count - 1
        '        '        If dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Kode Rute") = datatolak.Rows(i).Item(0) Then
        '        '            datatolak.Rows.RemoveAt(i)
        '        '            'datapilih.Rows.Add(dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Kode Rute"), dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Harga Maksimum"), False)
        '        '        End If
        '        '    Next i
        '        'End If

        '    End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    
End Class