Public Class harga_supir
    Dim data As New DataTable
    Private Sub harga_supir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            data = New DataTable
            data = DtTable("select nama_supir,id_supir from msupir where s='1'")
            supir.DataSource = data
            supir.DisplayMember = "nama_supir"
            supir.ValueMember = "id_supir"
            data = New DataTable
            data = DtTableharga("SELECT id_rute `Kode Rute`,concat(kota_asal,' - ',kota_tujuan) `Rute`,nama_principle `Nama Principle` FROM `mrute` mr,mprinciple mp WHERE mp.id_principle=mr.id_principle")
            hargasupir.DataSource = data
            If datapilih.Columns.Count = 0 Then
                datapilih.Columns.Add("id", GetType(String))
                datapilih.Columns.Add("harga", GetType(Double))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
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

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub supir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles supir.SelectedIndexChanged
        Try
            data = New DataTable
            data = DtTableharga("SELECT id_rute `Kode Rute`,concat(kota_asal,' - ',kota_tujuan) `Rute`,nama_principle `Nama Principle` FROM `mrute` mr,mprinciple mp WHERE mp.id_principle=mr.id_principle")
            hargasupir.DataSource = data

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Dim sudah As New DataTable
    Private Sub hargasupir_DataSourceChanged(sender As Object, e As EventArgs) Handles hargasupir.DataSourceChanged
        data = New DataTable
        Try
            For i = 0 To dataharga.RowCount - 1
                With dataharga
                    .SetRowCellValue(i, "Check List Rute", False)
                End With
                With dataharga
                    .SetRowCellValue(i, "Harga Maksimum", 0)
                End With
            Next i
            sudah = New DataTable
            sudah = DtTable("select * from dsupir where id_supir='" & supir.SelectedValue.ToString & "'")
            For i = 0 To dataharga.RowCount - 1
                For k = 0 To sudah.Rows.Count - 1
                    If dataharga.GetRowCellValue(i, "Kode Rute") = sudah.Rows(k).Item("id_rute") Then
                        With dataharga
                            .SetRowCellValue(i, "Check List Rute", True)
                        End With
                        With dataharga
                            .SetRowCellValue(i, "Harga Maksimum", sudah.Rows(k).Item("tarif"))
                        End With
                    End If
                Next k

            Next i
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            InsertInto("delete from dsupir where id_supir='" & supir.SelectedValue.ToString & "'")
            For i = 0 To dataharga.RowCount - 1
                If dataharga.GetRowCellValue(i, "Check List Rute") = True And dataharga.GetRowCellValue(i, "Harga Maksimum") > 0 Then
                    InsertInto("insert into dsupir values ('" & supir.SelectedValue.ToString & "','" & dataharga.GetRowCellValue(i, "Kode Rute").ToString & "','" & dataharga.GetRowCellValue(i, "Harga Maksimum") & "')")
                End If
            Next i
            supir_SelectedIndexChanged(sender, e)
            MessageBox.Show("Data berhasil diinput", "Konfirmasi Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub dataharga_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles dataharga.CellValueChanged
        Try
            If dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "check list rute") = True Or e.Column.FieldName = "Harga Maksimum" Then
                datapilih.Rows.Add(dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Kode Rute"), dataharga.GetRowCellValue(dataharga.FocusedRowHandle, "Harga Maksimum"))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class