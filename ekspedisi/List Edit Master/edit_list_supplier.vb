Imports MySql.Data.MySqlClient
Public Class edit_list_supplier
    Dim data As New DataTable
    Private Sub edit_list_supplier_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        master_supplier.GridControl1.Visible = True
        master_supplier.GridControl2.Visible = False
        data = DtTable("SELECT s.id_supplier `Kode Supplier`, s.nama_supplier `Nama Supplier`, s.Alamat `Alamat`, s.Email, s.tel1`Telepon 1`, s.tel2 `Telepon 2`, s.Kota, s.Provinsi, m.kategori_supplier `Nama Kategori` from msupplier s, mkategori_supplier m where m.id_kategori = s.id_kategori and s.`s`='1'")
        master_supplier.GridControl1.DataSource = data
        master_supplier.edit.Down = False
        master_supplier.deldata.Down = False
        master_supplier.editing.Visible = False
        master_supplier.hapus.Visible = False
        master_supplier.GroupControl2.Enabled = True
    End Sub
    Private Sub edit_list_supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If data.Columns.Count = 0 Then
                data.Columns.Add("Kode Supplier")
                data.Columns.Add("Nama Supplier")
                data.Columns.Add("Alamat")
                data.Columns.Add("Email")
                data.Columns.Add("Telepon 1")
                data.Columns.Add("Telepon 2")
                data.Columns.Add("Kota")
                data.Columns.Add("Provinsi")
                data.Columns.Add("Nama Kategori")
            End If

            For i = 0 To master_supplier.GridView2.RowCount - 1
                If master_supplier.GridView2.IsRowSelected(i) Then
                    Dim a As String = master_supplier.GridView2.GetRowCellValue(i, "Kode Supplier").ToString()
                    Dim b As String = master_supplier.GridView2.GetRowCellValue(i, "Nama Supplier").ToString()
                    Dim c As String = master_supplier.GridView2.GetRowCellValue(i, "Alamat").ToString()
                    Dim d As String = master_supplier.GridView2.GetRowCellValue(i, "Email").ToString()
                    Dim e1 As String = master_supplier.GridView2.GetRowCellValue(i, "Telepon 1").ToString()
                    Dim f As String = master_supplier.GridView2.GetRowCellValue(i, "Telepon 2").ToString()
                    Dim g As String = master_supplier.GridView2.GetRowCellValue(i, "Kota").ToString()
                    Dim h As String = master_supplier.GridView2.GetRowCellValue(i, "Provinsi").ToString()
                    Dim j As String = master_supplier.GridView2.GetRowCellValue(i, "Nama Kategori").ToString()
                    data.Rows.Add(a, b, c, d, e1, f, g, h, j)
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
        master_supplier.GridControl1.Visible = True
        master_supplier.GridControl2.Visible = False
        data = DtTable("SELECT s.id_supplier `Kode Supplier`, s.nama_supplier `Nama Supplier`, s.Alamat `Alamat`, s.Email, s.tel1`Telepon 1`, s.tel2 `Telepon 2`, s.Kota, s.Provinsi, m.kategori_supplier `Nama Kategori` from msupplier s, mkategori_supplier m where m.id_kategori = s.id_kategori and s.`s`='1'")
        master_supplier.GridControl1.DataSource = data
        master_supplier.edit.Down = False
        master_supplier.deldata.Down = False
        master_supplier.editing.Visible = False
        master_supplier.hapus.Visible = False
        master_supplier.GroupControl2.Enabled = True
        Me.Close()
    End Sub


    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        edit_supplier.ShowDialog()
    End Sub
End Class