Imports MySql.Data.MySqlClient
Public Class master_karyawan
    'Dim data As New DataTable
    'Private Sub edit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles edit.ItemClick
    '    If edit.Down = True Then
    '        GridControl1.DataSource = data
    '        GridControl1.Visible = True
    '        deldata.Down = False
    '        editing.Visible = True
    '        hapus.Visible = False
    '    Else
    '        GridControl1.Visible = False
    '        editing.Visible = False
    '    End If
    'End Sub

    'Private Sub deldata_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles deldata.ItemClick
    '    If deldata.Down = True Then
    '        GridControl1.DataSource = data
    '        GridControl1.Visible = True
    '        edit.Down = False
    '        GridControl1.Visible = True
    '        editing.Visible = False
    '        hapus.Visible = True
    '    Else
    '        GridControl1.Visible = False
    '        hapus.Visible = False
    '    End If
    'End Sub

    'Private Sub menu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles jumpmenu.ItemClick
    '    Me.Close()
    '    main_menu.Show()
    'End Sub

    'Private Sub addkary_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles addkary.ItemClick
    '    add_karyawan.Show()
    'End Sub

    'Private Sub Master_data_karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Try
    '        data = DtTable("Select id_karyawan, nama_karyawan, alamat, kota, tel1, tel2, email, id_jabatan from mkaryawan where s = '0'")
    '        dataview.DataSource = data
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    'Private Sub aktif_CheckedChanged(sender As Object, e As EventArgs) Handles aktif.CheckedChanged
    '    If aktif.Checked = True Then
    '        Try
    '            data = DtTable("SELECT id_karyawan as `ID karyawan`, nama_karyawan as `Nama karyawan`, nama_cina as `Nama China karyawan`, alamat as `Alamat`,tel1 as `Telepon 1`, tel2 as `Telepon 2`, tel_rumah as `Telepon Rumah`, tgl_lahir as `Tanggal Lahir`, tgl_masuk as `Tanggal Masuk`, nama_level as `Level`, email as `Email`, note as `Notes` FROM mlvl ml,mkaryawan m where m.`delete`='0' and id_lvl=id_level")
    '            dataview.DataSource = data
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message)
    '        End Try
    '    End If
    'End Sub

    'Private Sub nonaktif_CheckedChanged(sender As Object, e As EventArgs) Handles nonaktif.CheckedChanged
    '    If nonaktif.Checked = True Then
    '        Try
    '            data = DtTable("SELECT id_karyawan as `ID karyawan`, nama_karyawan as `Nama karyawan`, nama_cina as `Nama China karyawan`, alamat as `Alamat`,tel1 as `Telepon 1`, tel2 as `Telepon 2`, tel_rumah as `Telepon Rumah`, tgl_lahir as `Tanggal Lahir`, tgl_masuk as `Tanggal Masuk`, nama_level as `Level`, email as `Email`, note as `Notes` FROM mlvl ml,mkaryawan m where m.`delete`='1' and id_lvl=id_level")
    '            dataview.DataSource = data
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message)
    '        End Try
    '    End If
    'End Sub

    'Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged

    'End Sub

    'Private Sub editing_Click(sender As Object, e As EventArgs) Handles editing.Click
    '    Dim cek As Boolean = False
    '    For i = 0 To GridView1.FocusedRowHandle - 1
    '        If GridView1.GetRowCellValue(i, 0) = True Then
    '            cek = True
    '        End If
    '    Next i
    '    If cek = True Then
    '        edit_list_karyawan.ShowDialog()
    '    Else
    '        MessageBox.Show("Tidak ada data yang terpilih")
    '    End If
    'End Sub

    'Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
    '    Try
    '        Dim cek As Boolean = False
    '        For i = 0 To GridView1.FocusedRowHandle - 1
    '            If GridView1.GetRowCellValue(i, 0) = True Then
    '                cek = True
    '            End If
    '        Next i
    '        If cek = True Then
    '            Select Case MsgBox("Are you sure want to delete this data?", MsgBoxStyle.YesNo, "Delete Confirmation")
    '                Case MsgBoxResult.Yes
    '                    connect.Open()
    '                    For i = 0 To GridView1.RowCount - 1
    '                        If GridView1.selec = True Then
    '                            'InsertInto("update mkaryawan set `delete`=1 where id_karyawan='" & gridview1.Rows(i).Cells(1).Value.ToString & "'")
    '                            'InsertInto("insert into audit_log values (" & Format(Date.Now(), "yyyyMMddHHmmss") & ",'" & user & "','Master karyawan','Delete ID karyawan:" & gridview1.Rows(i).Cells(1).Value.ToString & "')")
    '                        End If
    '                    Next i
    '                    MessageBox.Show("File Deleted")
    '                    connect.Close()
    '                    GridView1.Visible = False
    '                    dataview.Visible = True
    '                    Master_data_karyawan_Load(sender, e)
    '            End Select
    '        Else
    '            MessageBox.Show("Tidak ada data yang terpilih")
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    'Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
    '    Me.Close()
    'End Sub

    'Private Sub gridview1_VisibleChanged(sender As Object, e As EventArgs) Handles GridView1.VisibleChanged
    '    For i = 0 To gridview1.Rows.Count - 1
    '        gridview1.Rows(i).Cells(0).Value = False
    '    Next i
    'End Sub

    'Private Sub Master_data_karyawan_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
    '    Master_data_karyawan_Load(sender, e)
    'End Sub

    'Private Sub Master_data_karyawan_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    '    deldata.Down = False
    '    edit.Down = False
    '    If edit.Down = True Then
    '        gridview1.DataSource = data
    '        gridview1.Visible = True
    '        deldata.Down = False
    '        editing.Visible = True
    '        hapus.Visible = False
    '    Else
    '        gridview1.Visible = False
    '        editing.Visible = False
    '    End If
    '    If deldata.Down = True Then
    '        gridview1.DataSource = data
    '        gridview1.Visible = True
    '        edit.Down = False
    '        gridview1.Visible = True
    '        editing.Visible = False
    '        hapus.Visible = True
    '    Else
    '        gridview1.Visible = False
    '        hapus.Visible = False
    '    End If
    'End Sub
    'Private Sub addkaryawanbaru_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles addkary.ItemClick
    '    add_karyawan.ShowDialog()
    'End Sub

End Class