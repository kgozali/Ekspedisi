Public Class list_edit_customer_sewa 
    Dim data As New DataTable
    Private Sub list_edit_customer_sewa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        master_customer.GridControl1.Visible = True
        master_customer.GridControl2.Visible = False
        data = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_Customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer_sewa b where b.`s`='1'")
        master_customer.GridControl1.DataSource = data
        master_customer.edit.Down = False
        master_customer.editing.Visible = False
        master_customer.deldata.Down = False
        master_customer.hapus.Visible = False
        master_customer.GroupControl2.Enabled = True
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        master_customer.GridControl1.Visible = True
        master_customer.GridControl2.Visible = False
        data = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_Customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer_sewa b where b.`s`='1'")
        master_customer.GridControl1.DataSource = data
        master_customer.edit.Down = False
        master_customer.editing.Visible = False
        master_customer.deldata.Down = False
        master_customer.hapus.Visible = False
        master_customer.GroupControl2.Enabled = True
        Me.Close()
    End Sub

    Private Sub list_edit_customer_sewa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Data.Clear()
            If Data.Columns.Count = 0 Then
                Data.Columns.Add("Kode Customer")
                Data.Columns.Add("Nama Customer")
                Data.Columns.Add("Alamat")
                Data.Columns.Add("Email")
                Data.Columns.Add("Telepon 1")
                Data.Columns.Add("Telepon 2")
                Data.Columns.Add("Kota")
                Data.Columns.Add("Provinsi")
            End If

            For i = 0 To master_customer_sewa.checks.Rows.Count - 1
                Dim datatemp As New DataTable
                datatemp = DtTable("SELECT id_customer_sewa `Kode Customer`, nama_Customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer_sewa b where b.`s`='1' and id_customer_sewa = '" & master_customer_sewa.checks(i).Item(0).ToString & "'")
                Dim a As String = datatemp.Rows(0).Item("Kode Customer").ToString()
                Dim b As String = datatemp.Rows(0).Item("Nama Customer").ToString()
                Dim c As String = datatemp.Rows(0).Item("Alamat").ToString()
                Dim d As String = datatemp.Rows(0).Item("Email").ToString()
                Dim e1 As String = datatemp.Rows(0).Item("Telepon 1").ToString()
                Dim f As String = datatemp.Rows(0).Item("Telepon 2").ToString()
                Dim g As String = datatemp.Rows(0).Item("Kota").ToString()
                Dim h As String = datatemp.Rows(0).Item("Provinsi").ToString()
                data.Rows.Add(a, b, c, d, e1, f, g, h)

                'If master_customer.GridView1.IsRowSelected(i) Then
                '    Dim a As String = master_customer.GridView1.GetRowCellValue(i, "Kode Customer").ToString()
                '    Dim b As String = master_customer.GridView1.GetRowCellValue(i, "Nama Customer").ToString()
                '    Dim c As String = master_customer.GridView1.GetRowCellValue(i, "Alamat").ToString()
                '    Dim d As String = master_customer.GridView1.GetRowCellValue(i, "Email").ToString()
                '    Dim e1 As String = master_customer.GridView1.GetRowCellValue(i, "Telepon 1").ToString()
                '    Dim f As String = master_customer.GridView1.GetRowCellValue(i, "Telepon 2").ToString()
                '    Dim g As String = master_customer.GridView1.GetRowCellValue(i, "Kota").ToString()
                '    Dim h As String = master_customer.GridView1.GetRowCellValue(i, "Provinsi").ToString()
                '    data.Rows.Add(a, b, c, d, e1, f, g, h)
                'End If
            Next
            GridControl1.DataSource = Data
            For i = 0 To Data.Columns.Count - 1
                GridView1.Columns(i).OptionsColumn.AllowEdit = False
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridControl1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles GridControl1.MouseDoubleClick
        Try
            add_customer_sewa.id.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Customer")
            add_customer_sewa.nama.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Nama Customer")
            add_customer_sewa.email.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Email")
            add_customer_sewa.tel1.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Telepon 1")
            add_customer_sewa.tel2.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Telepon 2")
            add_customer_sewa.nama.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Nama Customer")
            add_customer_sewa.kota.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kota")
            add_customer_sewa.alamat.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Alamat")
            add_customer_sewa.provinsi.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Provinsi")
            add_customer_sewa.saveedit.Visible = True
            add_customer_sewa.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class