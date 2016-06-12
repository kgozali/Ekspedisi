Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid
Public Class master_truck
    Dim data As New DataTable
    Dim cc() As String
    Public checks As New DataTable
    Dim unchecks As New DataTable

    Private Sub addtruckbaru_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles addtruckbaru.ItemClick
        add_truck.ShowDialog()
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

   

    Private Sub master_truck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        data = DtTable("SELECT t.id_truk `Kode Truk`, t.no_pol `No Polisi`, t.no_mesin `No Mesin`, t.no_rangka `No Rangka`, s.nama_supplier `Nama Supplier`, t.harga_beli `Harga Beli`, t.umur_default `Umur Default`, t.nilai_residu `Nilai Residu`, a.nama_akun `Akun Aktiva`, p.nama_akun `Akun Penyusutan`, d.nama_akun `Akun Depresiasi`, t.tgl_beli `Tanggal Beli` from mtruk t, makun a, makun d, makun p, msupplier s where t.id_supplier = s.id_supplier and t.id_akun_akt = a.kode_akun and t.id_akun_depresiasi = d.kode_akun and t.id_akun_penyusutan = p.kode_akun and t.`s`='1'")
        GridControl1.DataSource = data

        Try
            If data.Rows.Count > 0 Then
                For i = 0 To data.Columns.Count - 1
                    GridView1.Columns(i).OptionsColumn.AllowEdit = False
                Next

                If checks.Columns.Count() = 0 Then
                    checks.Columns.Add("Kode Truk")
                    unchecks.Columns.Add("Kode Truk")
                    For i = 0 To GridView1.DataRowCount - 1
                        Dim temp As String = GridView1.GetRowCellValue(i, "Kode Truk").ToString
                        unchecks.Rows.Add(temp)
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        If edit.Down = True Or deldata.Down = True Then
            If id.Checked = True Then
                If aktif.Checked = True Then
                    data = DtTable("SELECT t.id_truk `Kode Truk`, t.no_pol `No Polisi`, t.no_mesin `No Mesin`, t.no_rangka `No Rangka`, s.nama_supplier `Nama Supplier`, t.harga_beli `Harga Beli`, t.umur_default `Umur Default`, t.nilai_residu `Nilai Residu`, a.nama_akun `Akun Aktiva`, p.nama_akun `Akun Penyusutan`, d.nama_akun `Akun Depresiasi`, t.tgl_beli `Tanggal Beli` from mtruk t, makun a, makun d, makun p, msupplier s where t.id_supplier = s.id_supplier and t.id_akun_akt = a.kode_akun and t.id_akun_depresiasi = d.kode_akun and t.id_akun_penyusutan = p.kode_akun and t.`s`='1' and t.id_truk like '%" & cari.Text & "%'")
                Else
                    data = DtTable("SELECT t.id_truk `Kode Truk`, t.no_pol `No Polisi`, t.no_mesin `No Mesin`, t.no_rangka `No Rangka`, s.nama_supplier `Nama Supplier`, t.harga_beli `Harga Beli`, t.umur_default `Umur Default`, t.nilai_residu `Nilai Residu`, a.nama_akun `Akun Aktiva`, p.nama_akun `Akun Penyusutan`, d.nama_akun `Akun Depresiasi`, t.tgl_beli `Tanggal Beli` from mtruk t, makun a, makun d, makun p, msupplier s where t.id_supplier = s.id_supplier and t.id_akun_akt = a.kode_akun and t.id_akun_depresiasi = d.kode_akun and t.id_akun_penyusutan = p.kode_akun and t.`s`='0' and t.id_truk like '%" & cari.Text & "%'")
                End If

            Else
                If aktif.Checked = True Then
                    data = DtTable("SELECT t.id_truk `Kode Truk`, t.no_pol `No Polisi`, t.no_mesin `No Mesin`, t.no_rangka `No Rangka`, s.nama_supplier `Nama Supplier`, t.harga_beli `Harga Beli`, t.umur_default `Umur Default`, t.nilai_residu `Nilai Residu`, a.nama_akun `Akun Aktiva`, p.nama_akun `Akun Penyusutan`, d.nama_akun `Akun Depresiasi`, t.tgl_beli `Tanggal Beli` from mtruk t, makun a, makun d, makun p, msupplier s where t.id_supplier = s.id_supplier and t.id_akun_akt = a.kode_akun and t.id_akun_depresiasi = d.kode_akun and t.id_akun_penyusutan = p.kode_akun and t.`s`='1' and t.no_pol like '%" & cari.Text & "%'")
                Else
                    data = DtTable("SELECT t.id_truk `Kode Truk`, t.no_pol `No Polisi`, t.no_mesin `No Mesin`, t.no_rangka `No Rangka`, s.nama_supplier `Nama Supplier`, t.harga_beli `Harga Beli`, t.umur_default `Umur Default`, t.nilai_residu `Nilai Residu`, a.nama_akun `Akun Aktiva`, p.nama_akun `Akun Penyusutan`, d.nama_akun `Akun Depresiasi`, t.tgl_beli `Tanggal Beli` from mtruk t, makun a, makun d, makun p, msupplier s where t.id_supplier = s.id_supplier and t.id_akun_akt = a.kode_akun and t.id_akun_depresiasi = d.kode_akun and t.id_akun_penyusutan = p.kode_akun and t.`s`='0' and t.no_pol like '%" & cari.Text & "%'")
                End If
            End If
            GridControl2.DataSource = data
            'memberi cek ke Kode yg udah didalam dttable checks
            If checks.Rows.Count > 0 Then
                For i = 0 To GridView2.DataRowCount - 1
                    For j = 0 To checks.Rows.Count() - 1
                        If GridView2.GetRowCellValue(i, "Kode Truk").ToString = checks.Rows(j).Item(0).ToString Then
                            GridView2.SelectRow(i)
                        End If
                    Next
                Next
            End If

        Else
            If id.Checked = True Then
                If aktif.Checked = True Then
                    data = DtTable("SELECT t.id_truk `Kode Truk`, t.no_pol `No Polisi`, t.no_mesin `No Mesin`, t.no_rangka `No Rangka`, s.nama_supplier `Nama Supplier`, t.harga_beli `Harga Beli`, t.umur_default `Umur Default`, t.nilai_residu `Nilai Residu`, a.nama_akun `Akun Aktiva`, p.nama_akun `Akun Penyusutan`, d.nama_akun `Akun Depresiasi`, t.tgl_beli `Tanggal Beli` from mtruk t, makun a, makun d, makun p, msupplier s where t.id_supplier = s.id_supplier and t.id_akun_akt = a.kode_akun and t.id_akun_depresiasi = d.kode_akun and t.id_akun_penyusutan = p.kode_akun and t.`s`='1' and t.id_truk like '%" & cari.Text & "%'")
                Else
                    data = DtTable("SELECT t.id_truk `Kode Truk`, t.no_pol `No Polisi`, t.no_mesin `No Mesin`, t.no_rangka `No Rangka`, s.nama_supplier `Nama Supplier`, t.harga_beli `Harga Beli`, t.umur_default `Umur Default`, t.nilai_residu `Nilai Residu`, a.nama_akun `Akun Aktiva`, p.nama_akun `Akun Penyusutan`, d.nama_akun `Akun Depresiasi`, t.tgl_beli `Tanggal Beli` from mtruk t, makun a, makun d, makun p, msupplier s where t.id_supplier = s.id_supplier and t.id_akun_akt = a.kode_akun and t.id_akun_depresiasi = d.kode_akun and t.id_akun_penyusutan = p.kode_akun and t.`s`='0' and t.id_truk like '%" & cari.Text & "%'")
                End If

            Else
                If aktif.Checked = True Then
                    data = DtTable("SELECT t.id_truk `Kode Truk`, t.no_pol `No Polisi`, t.no_mesin `No Mesin`, t.no_rangka `No Rangka`, s.nama_supplier `Nama Supplier`, t.harga_beli `Harga Beli`, t.umur_default `Umur Default`, t.nilai_residu `Nilai Residu`, a.nama_akun `Akun Aktiva`, p.nama_akun `Akun Penyusutan`, d.nama_akun `Akun Depresiasi`, t.tgl_beli `Tanggal Beli` from mtruk t, makun a, makun d, makun p, msupplier s where t.id_supplier = s.id_supplier and t.id_akun_akt = a.kode_akun and t.id_akun_depresiasi = d.kode_akun and t.id_akun_penyusutan = p.kode_akun and t.`s`='1' and t.no_pol like '%" & cari.Text & "%'")
                Else
                    data = DtTable("SELECT t.id_truk `Kode Truk`, t.no_pol `No Polisi`, t.no_mesin `No Mesin`, t.no_rangka `No Rangka`, s.nama_supplier `Nama Supplier`, t.harga_beli `Harga Beli`, t.umur_default `Umur Default`, t.nilai_residu `Nilai Residu`, a.nama_akun `Akun Aktiva`, p.nama_akun `Akun Penyusutan`, d.nama_akun `Akun Depresiasi`, t.tgl_beli `Tanggal Beli` from mtruk t, makun a, makun d, makun p, msupplier s where t.id_supplier = s.id_supplier and t.id_akun_akt = a.kode_akun and t.id_akun_depresiasi = d.kode_akun and t.id_akun_penyusutan = p.kode_akun and t.`s`='0' and t.no_pol like '%" & cari.Text & "%'")
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
            edit_list_truck.ShowDialog()
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
                                InsertInto("update mtruk set `s`= 0 where id_truk='" & GridView2.GetRowCellValue(i, "Kode Truk").ToString & "'")
                                dataygdidelete = GridView2.GetRowCellValue(i, "Kode Truk").ToString
                                audit()
                            End If
                        Next i
                        MessageBox.Show("File Deleted")
                        connect.Close()
                        GridControl2.Visible = False
                        GridControl1.Visible = True
                        master_truck_Load(sender, e)
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
        Dim form As String = "Master Truk"
        Dim aktivitas As String = "Delete Truk: " & dataygdidelete.ToString
        auditlog(user, kompname, form, aktivitas)
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
            data = DtTable("SELECT t.id_truk `Kode Truk`, t.no_pol `No Polisi`, t.no_mesin `No Mesin`, t.no_rangka `No Rangka`, s.nama_supplier `Nama Supplier`, t.harga_beli `Harga Beli`, t.umur_default `Umur Default`, t.nilai_residu `Nilai Residu`, a.nama_akun `Akun Aktiva`, p.nama_akun `Akun Penyusutan`, d.nama_akun `Akun Depresiasi`, t.tgl_beli `Tanggal Beli` from mtruk t, makun a, makun d, makun p, msupplier s where t.id_supplier = s.id_supplier and t.id_akun_akt = a.kode_akun and t.id_akun_depresiasi = d.kode_akun and t.id_akun_penyusutan = p.kode_akun and t.`s`='1'")
            GridControl2.DataSource = data
            For i = 0 To GridView1.DataRowCount - 1
                Dim temp As String = GridView1.GetRowCellValue(i, "Kode Truk").ToString
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
            data = DtTable("SELECT t.id_truk `Kode Truk`, t.no_pol `No Polisi`, t.no_mesin `No Mesin`, t.no_rangka `No Rangka`, s.nama_supplier `Nama Supplier`, t.harga_beli `Harga Beli`, t.umur_default `Umur Default`, t.nilai_residu `Nilai Residu`, a.nama_akun `Akun Aktiva`, p.nama_akun `Akun Penyusutan`, d.nama_akun `Akun Depresiasi`, t.tgl_beli `Tanggal Beli` from mtruk t, makun a, makun d, makun p, msupplier s where t.id_supplier = s.id_supplier and t.id_akun_akt = a.kode_akun and t.id_akun_depresiasi = d.kode_akun and t.id_akun_penyusutan = p.kode_akun and t.`s`='1'")
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
            data = DtTable("SELECT t.id_truk `Kode Truk`, t.no_pol `No Polisi`, t.no_mesin `No Mesin`, t.no_rangka `No Rangka`, s.nama_supplier `Nama Supplier`, t.harga_beli `Harga Beli`, t.umur_default `Umur Default`, t.nilai_residu `Nilai Residu`, a.nama_akun `Akun Aktiva`, p.nama_akun `Akun Penyusutan`, d.nama_akun `Akun Depresiasi`, t.tgl_beli `Tanggal Beli` from mtruk t, makun a, makun d, makun p, msupplier s where t.id_supplier = s.id_supplier and t.id_akun_akt = a.kode_akun and t.id_akun_depresiasi = d.kode_akun and t.id_akun_penyusutan = p.kode_akun and t.`s`='1'")
            GridControl2.DataSource = data
            For i = 0 To GridView1.DataRowCount - 1
                Dim temp As String = GridView1.GetRowCellValue(i, "Kode Truk").ToString
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
            data = DtTable("SELECT t.id_truk `Kode Truk`, t.no_pol `No Polisi`, t.no_mesin `No Mesin`, t.no_rangka `No Rangka`, s.nama_supplier `Nama Supplier`, t.harga_beli `Harga Beli`, t.umur_default `Umur Default`, t.nilai_residu `Nilai Residu`, a.nama_akun `Akun Aktiva`, p.nama_akun `Akun Penyusutan`, d.nama_akun `Akun Depresiasi`, t.tgl_beli `Tanggal Beli` from mtruk t, makun a, makun d, makun p, msupplier s where t.id_supplier = s.id_supplier and t.id_akun_akt = a.kode_akun and t.id_akun_depresiasi = d.kode_akun and t.id_akun_penyusutan = p.kode_akun and t.`s`='1'")
            GridControl1.DataSource = data
        End If
    End Sub

    Private Sub GridView2_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView2.SelectionChanged
        Try
            If GridView2.IsRowSelected(GridView2.FocusedRowHandle) Then
                For i = 0 To unchecks.Rows.Count() - 1
                    If unchecks.Rows(i).Item(0).ToString = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Kode Truk").ToString Then
                        'MsgBox(unchecks.Rows(i).Item(0).ToString)
                        Dim cc As String = unchecks.Rows(i).Item(0).ToString
                        unchecks.Rows.RemoveAt(i)
                        checks.Rows.Add(cc)
                    End If
                Next
            Else
                For i = 0 To checks.Rows.Count() - 1
                    If checks.Rows(i).Item(0).ToString = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Kode Truk").ToString Then
                        'MsgBox(checks.Rows(i).Item(0).ToString)
                        Dim cc As String = checks.Rows(i).Item(0).ToString
                        checks.Rows.RemoveAt(i)
                        unchecks.Rows.Add(cc)
                    End If
                Next
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub aktif_CheckedChanged(sender As Object, e As EventArgs) Handles aktif.CheckedChanged
        deldata.Enabled = True
        edit.Enabled = True
        data = DtTable("SELECT t.id_truk `Kode Truk`, t.no_pol `No Polisi`, t.no_mesin `No Mesin`, t.no_rangka `No Rangka`, s.nama_supplier `Nama Supplier`, t.harga_beli `Harga Beli`, t.umur_default `Umur Default`, t.nilai_residu `Nilai Residu`, a.nama_akun `Akun Aktiva`, p.nama_akun `Akun Penyusutan`, d.nama_akun `Akun Depresiasi`, t.tgl_beli `Tanggal Beli` from mtruk t, makun a, makun d, makun p, msupplier s where t.id_supplier = s.id_supplier and t.id_akun_akt = a.kode_akun and t.id_akun_depresiasi = d.kode_akun and t.id_akun_penyusutan = p.kode_akun and t.`s`='1'")
        GridControl1.DataSource = data
    End Sub

    Private Sub nonaktif_CheckedChanged(sender As Object, e As EventArgs) Handles nonaktif.CheckedChanged
        deldata.Enabled = False
        edit.Enabled = False
        data = DtTable("SELECT t.id_truk `Kode Truk`, t.no_pol `No Polisi`, t.no_mesin `No Mesin`, t.no_rangka `No Rangka`, s.nama_supplier `Nama Supplier`, t.harga_beli `Harga Beli`, t.umur_default `Umur Default`, t.nilai_residu `Nilai Residu`, a.nama_akun `Akun Aktiva`, p.nama_akun `Akun Penyusutan`, d.nama_akun `Akun Depresiasi`, t.tgl_beli `Tanggal Beli` from mtruk t, makun a, makun d, makun p, msupplier s where t.id_supplier = s.id_supplier and t.id_akun_akt = a.kode_akun and t.id_akun_depresiasi = d.kode_akun and t.id_akun_penyusutan = p.kode_akun and t.`s`='0'")
        GridControl1.DataSource = data
    End Sub

    'Sub showgridpreview(ByVal grid As GridControl)
    '    If Not grid.IsPrintingAvailable Then
    '        MsgBox("The 'Devexpress.Xtraprinting' library is not found", "Error")
    '        Return
    '    End If

    '    grid.ShowPrintPreview()
    'End Sub

    Private Sub ContextMenuStrip1_Click(sender As Object, e As EventArgs) Handles Print.Click
        ViewerTruk.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ViewerTruk.ShowDialog()
    End Sub

    Private Sub jumpmenu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles jumpmenu.ItemClick
        Me.Close()
    End Sub
End Class