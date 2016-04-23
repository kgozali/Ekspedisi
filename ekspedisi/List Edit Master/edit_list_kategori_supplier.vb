Imports MySql.Data.MySqlClient
Public Class edit_list_kategori_supplier
    Dim data As New DataTable
    Private Sub edit_list_kategori_supplier_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        master_kategori_supplier.GridControl1.Visible = True
        master_kategori_supplier.GridControl2.Visible = False
        data = DtTable("SELECT b.id_kategori `Kode Kategori Supplier`, b.kategori_supplier `Nama Kategori Supplier` from mkategori_supplier b where b.`s`='1'")
        master_kategori_supplier.GridControl1.DataSource = data
        data = DtTable("SELECT b.id_kategori `Kode Kategori Supplier`, b.kategori_supplier `Nama Kategori Supplier` from mkategori_supplier b where b.`s`='1'")
        master_kategori_supplier.GridControl2.DataSource = data
        master_kategori_supplier.edit.Down = False
        master_kategori_supplier.GroupControl2.Enabled = True
    End Sub
    Private Sub edit_list_kategori_supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            data.Columns.Add("Kode Kategori Supplier")
            data.Columns.Add("Nama Kategori Supplier")

            For i = 0 To master_kategori_supplier.GridView2.RowCount - 1
                If master_kategori_supplier.GridView2.IsRowSelected(i) Then
                    Dim a As String = master_kategori_supplier.GridView2.GetRowCellValue(i, "Kode Kategori Supplier").ToString()
                    Dim b As String = master_kategori_supplier.GridView2.GetRowCellValue(i, "Nama Kategori Supplier").ToString()
                    data.Rows.Add(a, b)
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
        Me.Close()
        master_kategori_supplier.GridControl1.Visible = True
        master_kategori_supplier.GridControl2.Visible = False
        data = DtTable("SELECT b.id_kategori `Kode Kategori Supplier`, b.kategori_supplier `Nama Kategori Supplier` from mkategori_supplier b where b.`s`='1'")
        master_kategori_supplier.GridControl1.DataSource = data
        data = DtTable("SELECT b.id_kategori `Kode Kategori Supplier`, b.kategori_supplier `Nama Kategori Supplier` from mkategori_supplier b where b.`s`='1'")
        master_kategori_supplier.GridControl2.DataSource = data
        master_kategori_supplier.deldata.Down = False
        master_kategori_supplier.edit.Down = False

    End Sub
    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        edit_kategori_supplier.ShowDialog()
    End Sub
End Class