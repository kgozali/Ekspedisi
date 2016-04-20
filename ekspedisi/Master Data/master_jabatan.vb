﻿Imports MySql.Data.MySqlClient
Public Class master_jabatan
    Dim data As New DataTable
    Dim cc() As String
    Dim checks As New DataTable
    Dim unchecks As New DataTable

    Private Sub addjabatanbaru_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles addjabatanbaru.ItemClick
        add_jabatan.ShowDialog()
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
                GridView2.Columns(i).OptionsColumn.AllowEdit = False
            Next
        Else
            GridControl1.Visible = True
            GridControl2.Visible = False
            editing.Visible = False
        End If
    End Sub

    Private Sub master_jabatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridControl2.Visible = False
        data = DtTable("SELECT id_jabatan `ID jabatan`, b.nama_jabatan `Nama jabatan` from mjabatan b where b.`s`='1'")
        GridControl1.DataSource = data
        For i = 0 To data.Columns.Count - 1
            GridView1.Columns(i).OptionsColumn.AllowEdit = False
        Next

        checks.Columns.Add("ID jabatan")
        unchecks.Columns.Add("ID jabatan")
        For i = 0 To GridView1.DataRowCount - 1
            Dim temp As String = GridView1.GetRowCellValue(i, "ID jabatan").ToString
            unchecks.Rows.Add(temp)
        Next

    End Sub
    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        If edit.Down = True Then
            If id.Checked = True Then
                If aktif.Checked = True Then
                    data = DtTable("SELECT id_jabatan `ID jabatan`, b.nama_jabatan `Nama jabatan` from mjabatan b where b.`s`='1' and id_jabatan like '%" & cari.Text & "%'")
                Else
                    data = DtTable("SELECT id_jabatan `ID jabatan`, b.nama_jabatan `Nama jabatan` from mjabatan b where b.`s`='0' and id_jabatan like '%" & cari.Text & "%'")
                End If

            Else
                If aktif.Checked = True Then
                    data = DtTable("SELECT id_jabatan `ID jabatan`, b.nama_jabatan `Nama jabatan` from mjabatan b where b.`s`='1' and nama_jabatan like '%" & cari.Text & "%'")
                Else
                    data = DtTable("SELECT id_jabatan `ID jabatan`, b.nama_jabatan `Nama jabatan` from mjabatan b where b.`s`='0' and nama_jabatan like '%" & cari.Text & "%'")
                End If
            End If
            GridControl2.DataSource = data
            'memberi cek ke ID yg udah didalam dttable checks
            If checks.Rows.Count > 0 Then
                For i = 0 To GridView2.DataRowCount - 1
                    For j = 0 To checks.Rows.Count() - 1
                        If GridView2.GetRowCellValue(i, "ID jabatan").ToString = checks.Rows(j).Item(0).ToString Then
                            GridView2.SelectRow(i)
                        End If
                    Next
                Next
            End If

        Else
            If id.Checked = True Then
                If aktif.Checked = True Then
                    data = DtTable("SELECT id_jabatan `ID jabatan`, b.nama_jabatan `Nama jabatan` from mjabatan b where b.`s`='1' and id_jabatan like '%" & cari.Text & "%'")
                Else
                    data = DtTable("SELECT id_jabatan `ID jabatan`, b.nama_jabatan `Nama jabatan` from mjabatan b where b.`s`='0' and id_jabatan like '%" & cari.Text & "%'")
                End If

            Else
                If aktif.Checked = True Then
                    data = DtTable("SELECT id_jabatan `ID jabatan`, b.nama_jabatan `Nama jabatan` from mjabatan b where b.`s`='1' and nama_jabatan like '%" & cari.Text & "%'")
                Else
                    data = DtTable("SELECT id_jabatan `ID jabatan`, b.nama_jabatan `Nama jabatan` from mjabatan b where b.`s`='0' and nama_jabatan like '%" & cari.Text & "%'")
                End If
            End If
            GridControl1.DataSource = data
        End If


    End Sub


    Private Sub editing_Click(sender As Object, e As EventArgs) Handles editing.Click
        Dim cek As Boolean = False
        For i = 0 To GridView2.RowCount - 1
            If GridView2.IsRowSelected(i) Then
                cek = True
            End If
        Next i
        If cek = True Then
            edit_list_jabatan.ShowDialog()
        Else
            MessageBox.Show("Tidak ada data yang terpilih")
        End If
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Try
            Dim cek As Boolean = False
            For i = 0 To GridView2.RowCount - 1
                If GridView2.IsRowSelected(i) = True Then
                    cek = True
                End If
            Next i
            If cek = True Then
                Select Case MsgBox("Apakah anda yakin menghapus data ini?", MsgBoxStyle.YesNo, "System Error")
                    Case MsgBoxResult.Yes
                        For i = 0 To GridView2.RowCount - 1
                            If GridView2.IsRowSelected(i) = True Then
                                InsertInto("update mjabatan set `s`=1 where id_jabatan='" & GridView2.GetRowCellValue(GridView1.FocusedRowHandle, "ID jabatan").ToString & "'")
                            End If
                        Next i
                        MessageBox.Show("File Deleted")
                        connect.Close()
                        GridControl2.Visible = False
                        GridControl1.Visible = True
                        master_jabatan_Load(sender, e)
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

    Private Sub GridView2_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView2.SelectionChanged
        Try
            If GridView2.IsRowSelected(GridView2.FocusedRowHandle) Then
                For i = 0 To unchecks.Rows.Count() - 1
                    If unchecks.Rows(i).Item(0).ToString = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "ID jabatan").ToString Then
                        MsgBox(unchecks.Rows(i).Item(0).ToString)
                        Dim cc As String = unchecks.Rows(i).Item(0).ToString
                        unchecks.Rows.RemoveAt(i)
                        checks.Rows.Add(cc)
                    End If
                Next
            Else
                For i = 0 To checks.Rows.Count() - 1
                    If checks.Rows(i).Item(0).ToString = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "ID jabatan").ToString Then
                        MsgBox(checks.Rows(i).Item(0).ToString)
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