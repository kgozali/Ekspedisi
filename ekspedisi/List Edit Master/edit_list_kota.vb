Imports MySql.Data.MySqlClient
Public Class edit_list_kota
    Dim data As New DataTable
    Private Sub edit_list_kota_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        master_kota.GridControl1.Visible = True
        master_kota.GridControl2.Visible = False
        data = DtTable("SELECT b.kota `Nama Kota`, b.provinsi `Nama Provinsi` from mkota b where b.`s`='1'")
        master_kota.GridControl1.DataSource = data
        data = DtTable("SELECT b.kota `Nama Kota`, b.provinsi `Nama Provinsi` from mkota b where b.`s`='1'")
        master_kota.GridControl2.DataSource = data
        master_kota.edit.Down = False
        master_kota.deldata.Down = False
        master_kota.hapus.Visible = False
        master_kota.editing.Visible = False
        master_kota.GroupControl2.Enabled = True
    End Sub
    Private Sub edit_list_kota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If data.Columns.Count = 0 Then
                data.Columns.Add("Nama Kota")
                data.Columns.Add("Nama Provinsi")
            End If



            For i = 0 To master_kota.checks.Rows.Count - 1
                Dim datatemp As New DataTable
                datatemp = DtTable("SELECT b.kota `Nama Kota`, b.provinsi `Nama Provinsi` from mkota b where b.`s`='1' and b.kota = '" & master_kota.checks.Rows(i).Item(0).ToString & "'")
                Dim a As String = datatemp.Rows(0).Item("Nama Kota").ToString()
                Dim b As String = datatemp.Rows(0).Item("Nama Provinsi").ToString()
                data.Rows.Add(a, b)

                'If master_kota.GridView2.IsRowSelected(i) Then
                '    Dim a As String = master_kota.GridView2.GetRowCellValue(i, "Nama Kota").ToString()
                '    Dim b As String = master_kota.GridView2.GetRowCellValue(i, "Nama Provinsi").ToString()
                '    data.Rows.Add(a, b)
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
        master_kota.GridControl1.Visible = True
        master_kota.GridControl2.Visible = False
        data = DtTable("SELECT b.kota `Nama Kota`, b.provinsi `Nama Provinsi` from mkota b where b.`s`='1'")
        master_kota.GridControl1.DataSource = data
        data = DtTable("SELECT b.kota `Nama Kota`, b.provinsi `Nama Provinsi` from mkota b where b.`s`='1'")
        master_kota.GridControl2.DataSource = data
        master_kota.edit.Down = False
        master_kota.deldata.Down = False
        master_kota.hapus.Visible = False
        master_kota.editing.Visible = False
        master_kota.GroupControl2.Enabled = True
        Me.Close()

    End Sub
    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        edit_kota.ShowDialog()
    End Sub
End Class