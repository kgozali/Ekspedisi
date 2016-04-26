Imports MySql.Data.MySqlClient
Public Class edit_list_truck
    Dim data As New DataTable
    Private Sub edit_list_truck_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            master_truck.GridControl1.Visible = True
            master_truck.GridControl2.Visible = False
            data = DtTable("SELECT t.id_truk `Kode Truk`, t.no_pol `No Polisi`, t.no_mesin `No Mesin`, t.no_rangka `No Rangka`, s.nama_supplier `Nama Supplier`, t.harga_beli `Harga Beli`, t.umur_default `Umur Default`, t.nilai_residu `Nilai Residu`, a.nama_akun `Akun Aktiva`, p.nama_akun `Akun Penyusutan`, d.nama_akun `Akun Depresiasi` from mtruk t, makun a, makun d, makun p, msupplier s where t.id_supplier = s.id_supplier and t.id_akun_akt = a.kode_akun and t.id_akun_depresiasi = d.kode_akun and t.id_akun_penyusutan = p.kode_akun and t.`s`='1'")
            master_truck.GridControl1.DataSource = data
            data = DtTable("SELECT t.id_truk `Kode Truk`, t.no_pol `No Polisi`, t.no_mesin `No Mesin`, t.no_rangka `No Rangka`, s.nama_supplier `Nama Supplier`, t.harga_beli `Harga Beli`, t.umur_default `Umur Default`, t.nilai_residu `Nilai Residu`, a.nama_akun `Akun Aktiva`, p.nama_akun `Akun Penyusutan`, d.nama_akun `Akun Depresiasi` from mtruk t, makun a, makun d, makun p, msupplier s where t.id_supplier = s.id_supplier and t.id_akun_akt = a.kode_akun and t.id_akun_depresiasi = d.kode_akun and t.id_akun_penyusutan = p.kode_akun and t.`s`='1'")
            master_truck.GridControl2.DataSource = data
            master_truck.deldata.Down = False
            master_truck.edit.Down = False
            master_truck.hapus.Visible = False
            master_truck.editing.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub
    Private Sub edit_list_truck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            data.Clear()
            If data.Columns.Count = 0 Then
                data.Columns.Add("Kode Truk")
                data.Columns.Add("No Polisi")
                data.Columns.Add("No Mesin")
                data.Columns.Add("No Rangka")
                data.Columns.Add("Nama Supplier")
                data.Columns.Add("Harga Beli")
                data.Columns.Add("Umur Default")
                data.Columns.Add("Nilai Residu")
                data.Columns.Add("Akun Aktiva")
                data.Columns.Add("Akun Depresiasi")
                data.Columns.Add("Akun Penyusutan")
            End If

            For i = 0 To master_truck.GridView2.RowCount - 1
                If master_truck.GridView2.IsRowSelected(i) Then
                    Dim a As String = master_truck.GridView2.GetRowCellValue(i, "Kode Truk").ToString()
                    Dim b As String = master_truck.GridView2.GetRowCellValue(i, "No Polisi").ToString()
                    Dim c As String = master_truck.GridView2.GetRowCellValue(i, "No Mesin").ToString()
                    Dim d As String = master_truck.GridView2.GetRowCellValue(i, "No Rangka").ToString()
                    Dim e1 As String = master_truck.GridView2.GetRowCellValue(i, "Nama Supplier").ToString()
                    Dim f As String = master_truck.GridView2.GetRowCellValue(i, "Harga Beli").ToString()
                    Dim g As String = master_truck.GridView2.GetRowCellValue(i, "Umur Default").ToString()
                    Dim h As String = master_truck.GridView2.GetRowCellValue(i, "Nilai Residu").ToString()
                    Dim i1 As String = master_truck.GridView2.GetRowCellValue(i, "Akun Aktiva").ToString()
                    Dim j As String = master_truck.GridView2.GetRowCellValue(i, "Akun Depresiasi").ToString()
                    Dim k As String = master_truck.GridView2.GetRowCellValue(i, "Akun Penyusutan").ToString()
                    data.Rows.Add(a, b, c, d, e1, f, g, h, i1, j, k)
                End If
            Next
            GridControl1.DataSource = data
            For i = 0 To data.Columns.Count - 1
                GridView1.Columns(i).OptionsColumn.AllowEdit = False
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Try
            master_truck.GridControl1.Visible = True
            master_truck.GridControl2.Visible = False
            data = DtTable("SELECT t.id_truk `Kode Truk`, t.no_pol `No Polisi`, t.no_mesin `No Mesin`, t.no_rangka `No Rangka`, s.nama_supplier `Nama Supplier`, t.harga_beli `Harga Beli`, t.umur_default `Umur Default`, t.nilai_residu `Nilai Residu`, a.nama_akun `Akun Aktiva`, p.nama_akun `Akun Penyusutan`, d.nama_akun `Akun Depresiasi` from mtruk t, makun a, makun d, makun p, msupplier s where t.id_supplier = s.id_supplier and t.id_akun_akt = a.kode_akun and t.id_akun_depresiasi = d.kode_akun and t.id_akun_penyusutan = p.kode_akun and t.`s`='1'")
            master_truck.GridControl1.DataSource = data
            data = DtTable("SELECT t.id_truk `Kode Truk`, t.no_pol `No Polisi`, t.no_mesin `No Mesin`, t.no_rangka `No Rangka`, s.nama_supplier `Nama Supplier`, t.harga_beli `Harga Beli`, t.umur_default `Umur Default`, t.nilai_residu `Nilai Residu`, a.nama_akun `Akun Aktiva`, p.nama_akun `Akun Penyusutan`, d.nama_akun `Akun Depresiasi` from mtruk t, makun a, makun d, makun p, msupplier s where t.id_supplier = s.id_supplier and t.id_akun_akt = a.kode_akun and t.id_akun_depresiasi = d.kode_akun and t.id_akun_penyusutan = p.kode_akun and t.`s`='1'")
            master_truck.GridControl2.DataSource = data
            master_truck.deldata.Down = False
            master_truck.edit.Down = False
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub
    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        Edit_truck.ShowDialog()
    End Sub
End Class