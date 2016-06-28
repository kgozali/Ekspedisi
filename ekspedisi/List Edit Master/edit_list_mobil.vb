Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class edit_list_mobil
    Dim data As New DataTable
    Private Sub edit_list_mobil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            data = New DataTable
            If data.Columns.Count = 0 Then
                data.Columns.Add("Kode Mobil")
                data.Columns.Add("No Polisi")
                data.Columns.Add("Tanggal Beli")

            End If

            For i = 0 To Master_mobil.checks.Rows.Count - 1
                Dim datatemp As New DataTable
                datatemp = DtTable("SELECT id_mobil `Kode Mobil`,no_pol `No.Polisi`,concat(day(tgl_beli),'-',monthname(tgl_beli),'-',year(tgl_beli)) `Tanggal Beli`,tipe_mobil `Tipe`,warna `Warna`,tahun `Tahun` from mmobil where `s`='1' and id_mobil ='" & Master_mobil.checks.Rows(i).Item(0).ToString & "'")
                Dim a As String = datatemp.Rows(0).Item("Kode Mobil").ToString()
                Dim b As String = datatemp.Rows(0).Item("No.Polisi").ToString()
                Dim l As String = datatemp.Rows(0).Item("Tanggal Beli").ToString()
                data.Rows.Add(a, b, l)

                'If master_truck.GridView2.IsRowSelected(i) Then
                '    Dim a As String = master_truck.GridView2.GetRowCellValue(i, "Kode Truk").ToString()
                '    Dim b As String = master_truck.GridView2.GetRowCellValue(i, "No Polisi").ToString()
                '    Dim c As String = master_truck.GridView2.GetRowCellValue(i, "No Mesin").ToString()
                '    Dim d As String = master_truck.GridView2.GetRowCellValue(i, "No Rangka").ToString()
                '    Dim e1 As String = master_truck.GridView2.GetRowCellValue(i, "Nama Supplier").ToString()
                '    Dim f As String = master_truck.GridView2.GetRowCellValue(i, "Harga Beli").ToString()
                '    Dim g As String = master_truck.GridView2.GetRowCellValue(i, "Umur Default").ToString()
                '    Dim h As String = master_truck.GridView2.GetRowCellValue(i, "Nilai Residu").ToString()
                '    Dim i1 As String = master_truck.GridView2.GetRowCellValue(i, "Akun Aktiva").ToString()
                '    Dim j As String = master_truck.GridView2.GetRowCellValue(i, "Akun Depresiasi").ToString()
                '    Dim k As String = master_truck.GridView2.GetRowCellValue(i, "Akun Penyusutan").ToString()
                '    data.Rows.Add(a, b, c, d, e1, f, g, h, i1, j, k)
                'End If
            Next
            GridControl1.DataSource = data
            For i = 0 To data.Columns.Count - 1
                GridView1.Columns(i).OptionsColumn.AllowEdit = False
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub edit_list_mobil_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Master_mobil.GridControl1.Visible = True
            Master_mobil.GridControl2.Visible = False
            data = DtTable("SELECT id_mobil `Kode Mobil`,no_pol `No.Polisi`,concat(day(tgl_beli),'-',monthname(tgl_beli),'-',year(tgl_beli)) `Tanggal Beli`,tipe_mobil `Tipe`,warna `Warna`,tahun `Tahun` from mmobil where `s`='1'")
            Master_mobil.GridControl1.DataSource = data
            data = DtTable("SELECT id_mobil `Kode Mobil`,no_pol `No.Polisi`,concat(day(tgl_beli),'-',monthname(tgl_beli),'-',year(tgl_beli)) `Tanggal Beli`,tipe_mobil `Tipe`,warna `Warna`,tahun `Tahun` from mmobil where `s`='1'")
            Master_mobil.GridControl2.DataSource = data
            Master_mobil.deldata.Down = False
            Master_mobil.edit.Down = False
            Master_mobil.hapus.Visible = False
            Master_mobil.editing.Visible = False
            Master_mobil.GroupControl2.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Try
            add_mobil_sewa.id.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Mobil")
            add_mobil_sewa.nomorpolisi.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "No Polisi")
            'import globalization
            Dim tanggalan As DateTime = DateTime.ParseExact(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Tanggal Beli"), "d-MMMM-yyyy", CultureInfo.InvariantCulture)
            add_mobil_sewa.tanggal.Value = New Date(tanggalan.Year, tanggalan.Month, tanggalan.Day)
            add_mobil_sewa.tipemobil.Text = Master_mobil.GridView2.GetRowCellValue(Master_mobil.GridView2.FocusedRowHandle, "Tipe")
            add_mobil_sewa.tahun.Text = Master_mobil.GridView2.GetRowCellValue(Master_mobil.GridView2.FocusedRowHandle, "Tahun")
            add_mobil_sewa.warna.Text = Master_mobil.GridView2.GetRowCellValue(Master_mobil.GridView2.FocusedRowHandle, "Warna")
            add_mobil_sewa.simpanedit.Visible = True
            add_mobil_sewa.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class