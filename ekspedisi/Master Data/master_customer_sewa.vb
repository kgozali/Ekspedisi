Public Class master_customer_sewa 

    Dim data As New DataTable
    Dim cc() As String
    Public checks As New DataTable
    Dim unchecks As New DataTable
    Dim dataygdidelete As String = ""
    Private Sub addcustomerbaru_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles addcustomerbaru.ItemClick
        Try
            Dim tanggal As New DataTable
            Dim tgl As String = "CS"
            tanggal = DtTable("select * from mcustomer_sewa where substring(id_customer_sewa,1,2) = '" & tgl & "'")
            Dim hitung As String = tanggal.Rows.Count() + 1
            While hitung.LongCount < 5
                hitung = "0" + hitung
            End While
            add_customer_master_sewa.id.Text = tgl + hitung
            add_customer_sewa.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub


    Private Sub master_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            data = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer_sewa b where b.`s`='1'")
            GridControl1.DataSource = data


            If checks.Columns.Count = 0 Then
                checks.Columns.Add("Kode Customer")
                unchecks.Columns.Add("Kode Customer")

            End If
            For i = 0 To GridView1.DataRowCount - 1
                Dim temp As String = GridView1.GetRowCellValue(i, "Kode Customer").ToString
                unchecks.Rows.Add(temp)
            Next

            For i = 0 To data.Columns.Count - 1
                gridcustomer.Columns(i).OptionsColumn.AllowEdit = False
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        Try

            If edit.Down = True Or deldata.Down = True Then
                If id.Checked = True Then
                    If aktif.Checked = True Then
                        data = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer_sewa where `s`='1'and id_customer_sewa like '%" & cari.Text & "%'")
                    Else
                        data = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer_sewa where `s`='0'and id_customer_sewa like '%" & cari.Text & "%'")
                    End If

                Else
                    If aktif.Checked = True Then
                        data = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer_sewa  where `s`='1' and nama_customer like '%" & cari.Text & "%'")
                    Else
                        data = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer_sewa where `s`='0' and nama_customer like '%" & cari.Text & "%'")
                    End If
                End If
                GridControl2.DataSource = data
                'memberi cek ke Kode yg udah didalam dttable checks
                If checks.Rows.Count > 0 Then
                    For i = 0 To GridView1.DataRowCount - 1
                        For j = 0 To checks.Rows.Count() - 1
                            If GridView1.GetRowCellValue(i, "Kode Customer").ToString = checks.Rows(j).Item(0).ToString Then
                                GridView1.SelectRow(i)
                            End If
                        Next
                    Next
                End If

            Else
                If id.Checked = True Then
                    If aktif.Checked = True Then
                        data = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer_sewa  where `s`='1' and id_customer_sewa like '%" & cari.Text & "%'")
                    Else
                        data = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer_sewa  where `s`='0' and id_customer_sewa like '%" & cari.Text & "%'")
                    End If

                Else
                    If aktif.Checked = True Then
                        data = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer_sewa where `s`='1' and nama_customer like '%" & cari.Text & "%'")
                    Else
                        data = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer_sewa where `s`='0' and nama_customer like '%" & cari.Text & "%'")
                    End If
                End If
                GridControl1.DataSource = data
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub editing_Click(sender As Object, e As EventArgs) Handles editing.Click
        Try
            Dim cek As Boolean = False
            For i = 0 To GridView1.RowCount - 1
                If GridView1.IsRowSelected(i) Then
                    cek = True
                End If
            Next i
            If cek = True Then
                list_edit_customer.ShowDialog()
            Else
                MessageBox.Show("Tidak ada data terpilih", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
                                InsertInto("update mcustomer_sewa set `s`=0 where id_customer_sewa='" & GridView1.GetRowCellValue(i, "Kode Customer").ToString & "'")
                                dataygdidelete = GridView1.GetRowCellValue(i, "Kode Customer").ToString
                                audit()
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
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Master Cutomer"
        Dim aktivitas As String = "Delete Customer: " & dataygdidelete.ToString
        auditlog(user, kompname, form, aktivitas)
    End Sub

    Private Sub gridview1_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        Try
            If gridview1.IsRowSelected(gridview1.FocusedRowHandle) Then
                For i = 0 To unchecks.Rows.Count() - 1
                    If unchecks.Rows(i).Item(0).ToString = gridview1.GetRowCellValue(gridview1.FocusedRowHandle, "Kode Customer").ToString Then
                        'MsgBox(unchecks.Rows(i).Item(0).ToString)
                        Dim cc As String = unchecks.Rows(i).Item(0).ToString
                        unchecks.Rows.RemoveAt(i)
                        checks.Rows.Add(cc)
                    End If
                Next
            Else
                For i = 0 To checks.Rows.Count() - 1
                    If checks.Rows(i).Item(0).ToString = gridview1.GetRowCellValue(gridview1.FocusedRowHandle, "Kode Customer").ToString Then
                        'MsgBox(checks.Rows(i).Item(0).ToString)
                        Dim cc As String = checks.Rows(i).Item(0).ToString
                        checks.Rows.RemoveAt(i)
                        unchecks.Rows.Add(cc)
                    End If
                Next
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub aktif_CheckedChanged(sender As Object, e As EventArgs) Handles aktif.CheckedChanged
        deldata.Enabled = True
        edit.Enabled = True
        data = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer_sewa b where b.`s`='1'")
        GridControl1.DataSource = data
    End Sub

    Private Sub nonaktif_CheckedChanged(sender As Object, e As EventArgs) Handles nonaktif.CheckedChanged
        deldata.Enabled = False
        edit.Enabled = False
        data = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer_sewa b where b.`s`='0'")
        GridControl1.DataSource = data
    End Sub

    Private Sub edit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles edit.ItemClick
        Try
            If edit.Down = True Then
                deldata.Down = False
                GroupControl2.Enabled = False
                checks.Clear()
                unchecks.Clear()
                editing.Visible = True
                hapus.Visible = False
                GridControl1.Visible = False
                GridControl2.Visible = True
                data = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer_sewa b where b.`s`='1'")
                GridControl2.DataSource = data
                For i = 0 To GridView1.DataRowCount - 1
                    Dim temp As String = GridView1.GetRowCellValue(i, "Kode Customer").ToString
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
                data = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer_sewa b where b.`s`='1'")
                GridControl1.DataSource = data
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub deldata_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles deldata.ItemClick

        Try
            If deldata.Down = True Then
                edit.Down = False
                GroupControl2.Enabled = False
                checks.Clear()
                unchecks.Clear()
                editing.Visible = False
                hapus.Visible = True
                GridControl1.Visible = False
                GridControl2.Visible = True
                data = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer_sewa b where b.`s`='1'")
                GridControl2.DataSource = data
                For i = 0 To GridView1.DataRowCount - 1
                    Dim temp As String = GridView1.GetRowCellValue(i, "Kode Customer").ToString
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
                data = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer_sewa b where b.`s`='1'")
                GridControl1.DataSource = data
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    'Sub showgridpreview(ByVal grid As GridControl)
    '    If Not grid.IsPrintingAvailable Then
    '        MsgBox("The 'Devexpress.Xtraprinting' library is not found", "Error")
    '        Return
    '    End If

    '    grid.ShowPrintPreview()
    'End Sub

    Private Sub ContextMenuStrip1_Click(sender As Object, e As EventArgs) Handles Print.Click
        ViewerCustomer.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ViewerCustomer.ShowDialog()
    End Sub

    Private Sub jumpmenu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles jumpmenu.ItemClick
        Me.Close()
    End Sub
End Class