﻿Imports MySql.Data.MySqlClient
Public Class master_customer
    Dim data As New DataTable
    Dim cc() As String
    Dim checks As New DataTable
    Dim unchecks As New DataTable

    Private Sub addcustomerbaru_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles addcustomerbaru.ItemClick
        add_customer.ShowDialog()
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub edit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles edit.ItemClick
        If edit.Down = True Then
            GridControl2.DataSource = data
            GridControl2.Visible = True
            deldata.Down = False
            editing.Visible = True
            hapus.Visible = False
            GridControl1.Visible = False

            For i = 0 To data.Columns.Count - 1
                gridview1.Columns(i).OptionsColumn.AllowEdit = False
            Next
        Else
            GridControl1.Visible = True
            GridControl2.Visible = False
            editing.Visible = False
        End If
    End Sub

    Private Sub master_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridControl2.Visible = False
        data = DtTable("SELECT id_customer `ID customer`, nama_customer `Nama customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer b where b.`s`='1'")
        GridControl1.DataSource = data
        For i = 0 To data.Columns.Count - 1
            gridcustomer.Columns(i).OptionsColumn.AllowEdit = False
        Next

        If data.Rows.Count > 0 Then
            checks.Columns.Add("ID customer")
            unchecks.Columns.Add("ID customer")
            For i = 0 To gridcustomer.DataRowCount - 1
                Dim temp As String = gridcustomer.GetRowCellValue(i, "ID customer").ToString
                unchecks.Rows.Add(temp)
            Next
        End If




    End Sub
    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        If edit.Down = True Then
            If id.Checked = True Then
                If aktif.Checked = True Then
                    data = DtTable("SELECT id_customer `ID customer`, nama_customer `Nama customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer where `s`='1'and id_customer like '%" & cari.Text & "%'")
                Else
                    data = DtTable("SELECT id_customer `ID customer`, nama_customer `Nama customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer where `s`='0'and id_customer like '%" & cari.Text & "%'")
                End If

            Else
                If aktif.Checked = True Then
                    data = DtTable("SELECT id_customer `ID customer`, nama_customer `Nama customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer  where `s`='1' and nama_customer like '%" & cari.Text & "%'")
                Else
                    data = DtTable("SELECT id_customer `ID customer`, nama_customer `Nama customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer where `s`='0' and nama_customer like '%" & cari.Text & "%'")
                End If
            End If
            GridControl2.DataSource = data
            'memberi cek ke ID yg udah didalam dttable checks
            If checks.Rows.Count > 0 Then
                For i = 0 To gridview1.DataRowCount - 1
                    For j = 0 To checks.Rows.Count() - 1
                        If gridview1.GetRowCellValue(i, "ID customer").ToString = checks.Rows(j).Item(0).ToString Then
                            gridview1.SelectRow(i)
                        End If
                    Next
                Next
            End If

        Else
            If id.Checked = True Then
                If aktif.Checked = True Then
                    data = DtTable("SELECT id_customer `ID customer`, nama_customer `Nama customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer  where `s`='1' and id_customer like '%" & cari.Text & "%'")
                Else
                    data = DtTable("SELECT id_customer `ID customer`, nama_customer `Nama customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer  where `s`='0' and id_customer like '%" & cari.Text & "%'")
                End If

            Else
                If aktif.Checked = True Then
                    data = DtTable("SELECT id_customer `ID customer`, nama_customer `Nama customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer where `s`='1' and nama_customer like '%" & cari.Text & "%'")
                Else
                    data = DtTable("SELECT id_customer `ID customer`, nama_customer `Nama customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer where `s`='0' and nama_customer like '%" & cari.Text & "%'")
                End If
            End If
            GridControl1.DataSource = data
        End If


    End Sub


    Private Sub editing_Click(sender As Object, e As EventArgs) Handles editing.Click
        Dim cek As Boolean = False
        For i = 0 To gridview1.RowCount - 1
            If gridview1.IsRowSelected(i) Then
                cek = True
            End If
        Next i
        If cek = True Then
            list_edit_customer.ShowDialog()
        Else
            MessageBox.Show("Tidak ada data yang terpilih")
        End If
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Try
            Dim cek As Boolean = False
            For i = 0 To gridview1.RowCount - 1
                If gridview1.IsRowSelected(i) = True Then
                    cek = True
                End If
            Next i
            If cek = True Then
                Select Case MsgBox("Apakah anda yakin menghapus data ini?", MsgBoxStyle.YesNo, "System Error")
                    Case MsgBoxResult.Yes
                        For i = 0 To gridview1.RowCount - 1
                            If gridview1.IsRowSelected(i) = True Then
                                InsertInto("update mcustomer set `s`=1 where id_customer='" & gridview1.GetRowCellValue(gridcustomer.FocusedRowHandle, "ID customer").ToString & "'")
                            End If
                        Next i
                        MessageBox.Show("File Deleted")
                        connect.Close()
                        GridControl2.Visible = False
                        GridControl1.Visible = True
                        master_customer_Load(sender, e)
                End Select
            Else
                MessageBox.Show("Tidak ada data yang terpilih")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub deldata_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles deldata.ItemClick
        If deldata.Down = True Then
            GridControl2.DataSource = data
            GridControl2.Visible = True
            edit.Down = False
            GridControl1.Visible = False
            editing.Visible = False
            hapus.Visible = True
        Else
            GridControl1.Visible = True
            GridControl2.Visible = False
            hapus.Visible = False
        End If
    End Sub

    Private Sub gridview1_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        Try
            If gridview1.IsRowSelected(gridview1.FocusedRowHandle) Then
                For i = 0 To unchecks.Rows.Count() - 1
                    If unchecks.Rows(i).Item(0).ToString = gridview1.GetRowCellValue(gridview1.FocusedRowHandle, "ID customer").ToString Then
                        'MsgBox(unchecks.Rows(i).Item(0).ToString)
                        Dim cc As String = unchecks.Rows(i).Item(0).ToString
                        unchecks.Rows.RemoveAt(i)
                        checks.Rows.Add(cc)
                    End If
                Next
            Else
                For i = 0 To checks.Rows.Count() - 1
                    If checks.Rows(i).Item(0).ToString = gridview1.GetRowCellValue(gridview1.FocusedRowHandle, "ID customer").ToString Then
                        'MsgBox(checks.Rows(i).Item(0).ToString)
                        Dim cc As String = checks.Rows(i).Item(0).ToString
                        checks.Rows.RemoveAt(i)
                        unchecks.Rows.Add(cc)
                    End If
                Next
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub aktif_CheckedChanged(sender As Object, e As EventArgs) Handles aktif.CheckedChanged
        deldata.Enabled = True
        edit.Enabled = True
    End Sub

    Private Sub nonaktif_CheckedChanged(sender As Object, e As EventArgs) Handles nonaktif.CheckedChanged
        deldata.Enabled = False
        edit.Enabled = False
    End Sub

    Private Sub edit_DownChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles edit.DownChanged
        If edit.Down = True Then
            GroupControl2.Enabled = False
        Else
            GroupControl2.Enabled = True
        End If

    End Sub

End Class