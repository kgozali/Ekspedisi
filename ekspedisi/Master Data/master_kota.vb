Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid
Public Class master_kota
    Dim data As New DataTable
    Public checks As New DataTable
    Dim unchecks As New DataTable

    Private Sub addkotabaru_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles addkotabaru.ItemClick
        add_kota.ShowDialog()
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

  

    Private Sub master_kota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            checks.Clear()
            unchecks.Clear()
            data.Clear()
            GridControl1.Visible = True
            GridControl2.Visible = False
            GroupControl2.Enabled = True
            hapus.Visible = False
            editing.Visible = False
            deldata.Down = False
            edit.Down = False
            cari.Text = ""

            data = DtTable("SELECT b.kota `Nama Kota`, b.provinsi `Nama Provinsi` from mkota b where b.`s`='1'")
            GridControl1.DataSource = data
            For i = 0 To data.Columns.Count - 1
                GridView1.Columns(i).OptionsColumn.AllowEdit = False
            Next
            If checks.Columns.Count() = 0 Then
                checks.Columns.Add("Nama Kota")
                unchecks.Columns.Add("Nama Kota")
            End If


            For i = 0 To GridView1.DataRowCount - 1
                Dim temp As String = GridView1.GetRowCellValue(i, "Nama Kota").ToString
                unchecks.Rows.Add(temp)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        If edit.Down = True Or deldata.Down = True Then
            If aktif.Checked = True Then
                data = DtTable("SELECT b.kota `Nama Kota`, b.provinsi `Nama Provinsi` from mkota b where b.`s`='1' and b.kota like '%" & cari.Text & "%'")
            Else
                data = DtTable("SELECT b.kota `Nama Kota`, b.provinsi `Nama Provinsi` from mkota b where b.`s`='0' and b.kota like '%" & cari.Text & "%'")
            End If
            GridControl2.DataSource = data
            'memberi cek ke ID yg udah didalam dttable checks
            If checks.Rows.Count > 0 Then
                For i = 0 To GridView2.DataRowCount - 1
                    For j = 0 To checks.Rows.Count() - 1
                        If GridView2.GetRowCellValue(i, "Nama Kota").ToString = checks.Rows(j).Item(0).ToString Then
                            GridView2.SelectRow(i)
                        End If
                    Next
                Next
            End If

        Else

            If aktif.Checked = True Then
                data = DtTable("SELECT b.kota `Nama Kota`, b.provinsi `Nama Provinsi` from mkota b where b.`s`='1' and b.kota like '%" & cari.Text & "%'")
            Else
                data = DtTable("SELECT b.kota `Nama Kota`, b.provinsi `Nama Provinsi` from mkota b where b.`s`='0' and b.kota like '%" & cari.Text & "%'")
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
            edit_list_kota.ShowDialog()
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
                                InsertInto("update mkota set `s`=0 where kota='" & GridView2.GetRowCellValue(i, "Nama Kota").ToString & "'")
                                dataygdidelete = GridView2.GetRowCellValue(i, "Nama Kota").ToString
                                audit()
                            End If
                        Next i
                        MessageBox.Show("File Deleted")
                        connect.Close()
                        GridControl2.Visible = False
                        GridControl1.Visible = True
                        master_kota_Load(sender, e)
                        deldata.Down = False
                End Select
            Else
                MessageBox.Show("Tidak ada data yang terpilih")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Dim dataygdidelete As String = ""

    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Master Kota"
        Dim aktivitas As String = "Delete Kota: " & dataygdidelete.ToString
        auditlog(user, kompname, form, aktivitas)
    End Sub

    Private Sub GridView2_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView2.SelectionChanged
        Try
            If GridView2.IsRowSelected(GridView2.FocusedRowHandle) Then
                For i = 0 To unchecks.Rows.Count() - 1
                    If unchecks.Rows(i).Item(0).ToString = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Nama Kota").ToString Then
                        'MsgBox(unchecks.Rows(i).Item(0).ToString)
                        Dim cc As String = unchecks.Rows(i).Item(0).ToString
                        unchecks.Rows.RemoveAt(i)
                        checks.Rows.Add(cc)
                    End If
                Next
            Else
                For i = 0 To checks.Rows.Count() - 1
                    If checks.Rows(i).Item(0).ToString = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Nama Kota").ToString Then
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
        data = DtTable("SELECT b.kota `Nama Kota`, b.provinsi `Nama Provinsi` from mkota b where b.`s`='1'")
        GridControl1.DataSource = data
    End Sub

    Private Sub nonaktif_CheckedChanged(sender As Object, e As EventArgs) Handles nonaktif.CheckedChanged
        deldata.Enabled = False
        edit.Enabled = False
        data = DtTable("SELECT b.kota `Nama Kota`, b.provinsi `Nama Provinsi` from mkota b where b.`s`='0'")
        GridControl1.DataSource = data
    End Sub
    Private Sub edit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles edit.ItemClick
        If edit.Down = True Then
            deldata.Down = False
            GroupControl2.Enabled = False
            checks.Clear()
            unchecks.Clear()
            editing.Visible = True
            hapus.Visible = False
            GridControl1.Visible = False
            GridControl2.Visible = True
            data = DtTable("SELECT b.kota `Nama Kota`, b.provinsi `Nama Provinsi` from mkota b where b.`s`='1'")
            GridControl2.DataSource = data
            For i = 0 To GridView1.DataRowCount - 1
                Dim temp As String = GridView1.GetRowCellValue(i, "Nama Kota").ToString
                unchecks.Rows.Add(temp)
            Next
        Else
            GroupControl2.Enabled = True
            checks.Clear()
            unchecks.Clear()
            editing.Visible = False
            hapus.Visible = False
            GridControl1.Visible = True
            GridControl2.Visible = False
            data = DtTable("SELECT b.kota `Nama Kota`, b.provinsi `Nama Provinsi` from mkota b where b.`s`='1'")
            GridControl1.DataSource = data
        End If
    End Sub
    Private Sub deldata_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles deldata.ItemClick
        If deldata.Down = True Then
            edit.Down = False
            GroupControl2.Enabled = False
            checks.Clear()
            unchecks.Clear()
            editing.Visible = False
            hapus.Visible = True
            GridControl1.Visible = False
            GridControl2.Visible = True
            data = DtTable("SELECT b.kota `Nama Kota`, b.provinsi `Nama Provinsi` from mkota b where b.`s`='1'")
            GridControl2.DataSource = data
            For i = 0 To GridView1.DataRowCount - 1
                Dim temp As String = GridView1.GetRowCellValue(i, "Nama Kota").ToString
                unchecks.Rows.Add(temp)
            Next
        Else
            GroupControl2.Enabled = True
            checks.Clear()
            unchecks.Clear()
            editing.Visible = False
            hapus.Visible = False
            GridControl1.Visible = True
            GridControl2.Visible = False
            data = DtTable("SELECT b.kota `Nama Kota`, b.provinsi `Nama Provinsi` from mkota b where b.`s`='1'")
            GridControl1.DataSource = data
        End If
    End Sub

    Sub showgridpreview(ByVal grid As GridControl)
        If Not grid.IsPrintingAvailable Then
            MsgBox("The 'Devexpress.Xtraprinting' library is not found", "Error")
            Return
        End If
        grid.ShowPrintPreview()
    End Sub

    Private Sub ContextMenuStrip1_Click(sender As Object, e As EventArgs) Handles Print.Click
        showgridpreview(GridControl1)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        showgridpreview(GridControl1)
    End Sub


End Class