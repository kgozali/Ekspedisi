Imports MySql.Data.MySqlClient
Public Class list_edit_customer
    Dim data As New DataTable
    Private Sub list_edit_customer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        master_customer.GridControl1.Visible = True
        master_customer.GridControl2.Visible = False
        data = DtTable("SELECT id_customer `Kode Customer`, nama_Customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer b where b.`s`='1'")
        master_customer.GridControl1.DataSource = data
        master_customer.edit.Down = False
        master_customer.editing.Visible = False
        master_customer.deldata.Down = False
        master_customer.hapus.Visible = False
        master_customer.GroupControl2.Enabled = True
    End Sub
    Private Sub list_edit_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            data.Clear()
            If data.Columns.Count = 0 Then
                data.Columns.Add("Kode Customer")
                data.Columns.Add("Nama Customer")
                data.Columns.Add("Alamat")
                data.Columns.Add("Email")
                data.Columns.Add("Telepon 1")
                data.Columns.Add("Telepon 2")
                data.Columns.Add("Kota")
                data.Columns.Add("Provinsi")
            End If

            For i = 0 To master_customer.GridView1.RowCount - 1
                If master_customer.GridView1.IsRowSelected(i) Then
                    Dim a As String = master_customer.GridView1.GetRowCellValue(i, "Kode Customer").ToString()
                    Dim b As String = master_customer.GridView1.GetRowCellValue(i, "Nama Customer").ToString()
                    Dim c As String = master_customer.GridView1.GetRowCellValue(i, "Alamat").ToString()
                    Dim d As String = master_customer.GridView1.GetRowCellValue(i, "Email").ToString()
                    Dim e1 As String = master_customer.GridView1.GetRowCellValue(i, "Telepon 1").ToString()
                    Dim f As String = master_customer.GridView1.GetRowCellValue(i, "Telepon 2").ToString()
                    Dim g As String = master_customer.GridView1.GetRowCellValue(i, "Kota").ToString()
                    Dim h As String = master_customer.GridView1.GetRowCellValue(i, "Provinsi").ToString()
                    data.Rows.Add(a, b, c, d, e1, f, g, h)
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
        master_customer.GridControl1.Visible = True
        master_customer.GridControl2.Visible = False
        data = DtTable("SELECT id_customer `Kode Customer`, nama_Customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer b where b.`s`='1'")
        master_customer.GridControl1.DataSource = data
        master_customer.edit.Down = False
        master_customer.editing.Visible = False
        master_customer.deldata.Down = False
        master_customer.hapus.Visible = False
        master_customer.GroupControl2.Enabled = True
        Me.Close()
    End Sub


    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        edit_customer.ShowDialog()
    End Sub
End Class