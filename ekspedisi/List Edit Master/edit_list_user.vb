Imports MySql.Data.MySqlClient
Public Class edit_list_user
    Dim data As New DataTable
    Private Sub edit_list_user_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        master_user.GridControl1.Visible = True
        master_user.GridControl2.Visible = False
        data = DtTable("SELECT Username from muser where`s`='1'")
        master_user.GridControl1.DataSource = data
        data = DtTable("SELECT Username from muser where`s`='1'")
        master_user.GridControl2.DataSource = data
        master_user.deldata.Down = False
        master_user.edit.Down = False
    End Sub
    Private Sub edit_list_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            data.Clear()
            If data.Columns.Count() = 0 Then
                data.Columns.Add("Username")
            End If

            For i = 0 To master_user.GridView2.RowCount - 1
                If master_user.GridView2.IsRowSelected(i) Then
                    data.Rows.Add(master_user.GridView2.GetRowCellValue(i, "Username").ToString())
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
        master_user.GridControl1.Visible = True
        master_user.GridControl2.Visible = False
        data = DtTable("SELECT Username from muser where`s`='1'")
        master_user.GridControl1.DataSource = data
        data = DtTable("SELECT Username from muser where`s`='1'")
        master_user.GridControl2.DataSource = data
        master_user.deldata.Down = False
        master_user.edit.Down = False
        Me.Close()
    End Sub
    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        Edit_user.ShowDialog()
    End Sub
End Class