Imports MySql.Data.MySqlClient
Public Class list_edit_barang
    Dim data As New DataTable
    Private Sub list_edit_barang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        master_barang.GridControl1.Visible = True
        master_barang.GridControl2.Visible = False
        data = DtTable("SELECT id_barang `Kode Barang`, b.nama_barang `Nama Barang`, p.nama_principle `Nama Principle`, Keterangan from mbarang b, mprinciple p where b.id_principle = p.id_principle and b.`s`='1'")
        master_barang.GridControl1.DataSource = data
        master_barang.edit.Down = False
        master_barang.deldata.Down = False
        master_barang.hapus.Visible = False
        master_barang.editing.Visible = False
    End Sub
    Private Sub list_edit_barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If data.Columns.Count = 0 Then
                data.Columns.Add("Kode Barang")
                data.Columns.Add("Nama Barang")
                data.Columns.Add("Nama Principle")
                data.Columns.Add("Keterangan")
            End If

            For i = 0 To master_barang.GridView2.RowCount - 1
                Dim datatemp As New DataTable
                datatemp = DtTable("SELECT id_barang `Kode Barang`, b.nama_barang `Nama Barang`, p.nama_principle `Nama Principle`, Keterangan from mbarang b, mprinciple p where b.id_principle = p.id_principle and b.`s`='1' and id_barang = '" & master_barang.checks.Rows(i).Item(0).ToString & "'")
                Dim a As String = datatemp.Rows(0).Item("Kode Barang").ToString()
                Dim b As String = datatemp.Rows(0).Item("Nama Barang").ToString()
                Dim c As String = datatemp.Rows(0).Item("Nama Principle").ToString()
                Dim d As String = datatemp.Rows(0).Item("Keterangan").ToString()
                data.Rows.Add(a, b, c, d)

                'If master_barang.GridView2.IsRowSelected(i) Then
                '    Dim a As String = master_barang.GridView2.GetRowCellValue(i, "Kode Barang").ToString()
                '    Dim b As String = master_barang.GridView2.GetRowCellValue(i, "Nama Barang").ToString()
                '    Dim c As String = master_barang.GridView2.GetRowCellValue(i, "Nama Principle").ToString()
                '    Dim d As String = master_barang.GridView2.GetRowCellValue(i, "Keterangan").ToString()
                '    data.Rows.Add(a, b, c, d)
                'End If
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
        master_barang.GridControl1.Visible = True
        master_barang.GridControl2.Visible = False
        data = DtTable("SELECT id_barang `Kode Barang`, b.nama_barang `Nama Barang`, p.nama_principle `Nama Principle`, Keterangan from mbarang b, mprinciple p where b.id_principle = p.id_principle and b.`s`='1'")
        master_barang.GridControl1.DataSource = data
        master_barang.edit.Down = False
        master_barang.deldata.Down = False
        master_barang.hapus.Visible = False
        master_barang.editing.Visible = False

    End Sub
    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        edit_barang.ShowDialog()
    End Sub
End Class