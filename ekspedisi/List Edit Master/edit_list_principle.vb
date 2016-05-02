Imports MySql.Data.MySqlClient
Public Class edit_list_principle
    Dim data As New DataTable
    Private Sub edit_list_principle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        master_principle.GridControl1.Visible = True
        master_principle.GridControl2.Visible = False
        data = DtTable("SELECT id_principle `Kode Principle`, nama_Principle `Nama Principle`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mprinciple b where b.`s`='1'")
        master_principle.GridControl1.DataSource = data
        master_principle.edit.Down = False
        master_principle.editing.Visible = False
        master_principle.deldata.Down = False
        master_principle.hapus.Visible = False
        master_principle.GroupControl2.Enabled = True
    End Sub
    Private Sub edit_list_principle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            data.Clear()
            If data.Columns.Count = 0 Then
                data.Columns.Add("Kode Principle")
                data.Columns.Add("Nama Principle")
                data.Columns.Add("Alamat")
                data.Columns.Add("Email")
                data.Columns.Add("Telepon 1")
                data.Columns.Add("Telepon 2")
                data.Columns.Add("Kota")
                data.Columns.Add("Provinsi")
            End If

            For i = 0 To master_principle.checks.Rows.Count - 1
                Dim datatemp As New DataTable
                datatemp = DtTable("SELECT id_principle `Kode Principle`, nama_Principle `Nama Principle`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mprinciple b where b.`s`='1' and id_principle = '" & master_principle.checks(i).Item(0).ToString & "'")
                Dim a As String = datatemp.Rows(0).Item("Kode Principle").ToString()
                Dim b As String = datatemp.Rows(0).Item("Nama Principle").ToString()
                Dim c As String = datatemp.Rows(0).Item("Alamat").ToString()
                Dim d As String = datatemp.Rows(0).Item("Email").ToString()
                Dim e1 As String = datatemp.Rows(0).Item("Telepon 1").ToString()
                Dim f As String = datatemp.Rows(0).Item("Telepon 2").ToString()
                Dim g As String = datatemp.Rows(0).Item("Kota").ToString()
                Dim h As String = datatemp.Rows(0).Item("Provinsi").ToString()
                data.Rows.Add(a, b, c, d, e1, f, g, h)

                'If master_principle.GridView1.IsRowSelected(i) Then
                '    Dim a As String = master_principle.GridView1.GetRowCellValue(i, "Kode Principle").ToString()
                '    Dim b As String = master_principle.GridView1.GetRowCellValue(i, "Nama Principle").ToString()
                '    Dim c As String = master_principle.GridView1.GetRowCellValue(i, "Alamat").ToString()
                '    Dim d As String = master_principle.GridView1.GetRowCellValue(i, "Email").ToString()
                '    Dim e1 As String = master_principle.GridView1.GetRowCellValue(i, "Telepon 1").ToString()
                '    Dim f As String = master_principle.GridView1.GetRowCellValue(i, "Telepon 2").ToString()
                '    Dim g As String = master_principle.GridView1.GetRowCellValue(i, "Kota").ToString()
                '    Dim h As String = master_principle.GridView1.GetRowCellValue(i, "Provinsi").ToString()
                '    data.Rows.Add(a, b, c, d, e1, f, g, h)
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
        master_principle.GridControl1.Visible = True
        master_principle.GridControl2.Visible = False
        data = DtTable("SELECT id_principle `Kode Principle`, nama_Principle `Nama Principle`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mprinciple b where b.`s`='1'")
        master_principle.GridControl1.DataSource = data
        master_principle.edit.Down = False
        master_principle.editing.Visible = False
        master_principle.deldata.Down = False
        master_principle.hapus.Visible = False
        master_principle.GroupControl2.Enabled = True
        Me.Close()
    End Sub


    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        edit_Principle.ShowDialog()
    End Sub
End Class