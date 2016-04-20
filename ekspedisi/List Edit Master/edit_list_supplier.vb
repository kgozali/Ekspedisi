Imports MySql.Data.MySqlClient
Public Class edit_list_Supplier
    Dim data As New DataTable
    Private Sub edit_list_Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            data.Columns.Add("Kode Supplier")
            data.Columns.Add("Nama Supplier")
            data.Columns.Add("Alamat")
            data.Columns.Add("Email")
            data.Columns.Add("Telepon 1")
            data.Columns.Add("Telepon 2")
            data.Columns.Add("Kota")
            data.Columns.Add("Provinsi")
            data.Columns.Add("Nama Kategori")

            For i = 0 To master_supplier.GridView1.RowCount - 1
                If master_supplier.GridView1.IsRowSelected(i) Then
                    Dim a As String = master_supplier.GridView1.GetRowCellValue(i, "ID Supplier").ToString()
                    Dim b As String = master_supplier.GridView1.GetRowCellValue(i, "Nama Supplier").ToString()
                    Dim c As String = master_supplier.GridView1.GetRowCellValue(i, "Alamat").ToString()
                    Dim d As String = master_supplier.GridView1.GetRowCellValue(i, "Email").ToString()
                    Dim e1 As String = master_supplier.GridView1.GetRowCellValue(i, "Telepon 1").ToString()
                    Dim f As String = master_supplier.GridView1.GetRowCellValue(i, "Telepon 2").ToString()
                    Dim g As String = master_supplier.GridView1.GetRowCellValue(i, "Kota").ToString()
                    Dim h As String = master_supplier.GridView1.GetRowCellValue(i, "Provinsi").ToString()
                    Dim i As String = master_supplier.GridView1.GetRowCellValue(i, "Nama Kategori").ToString()
                    data.Rows.Add(a, b, c, d, e1, f, g, h, i)
                End If
            Next
            GridControl1.DataSource = data
            For i = 0 To data.Columns.Count - 1
                GridView1.Columns(i).OptionsColumn.AllowEdit = False
            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub


    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        edit_supplier.ShowDialog()
    End Sub
End Class