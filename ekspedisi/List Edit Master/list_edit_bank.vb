'Imports MySql.Data.MySqlClient
'Public Class list_edit_bank
'    Dim data As New DataTable
'    Private Sub list_edit_bank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        Try
'            data.Columns.Add("Kode bank")
'            data.Columns.Add("Nama bank")


'            For i = 0 To master_bank.GridView2.RowCount - 1
'                If master_bank.GridView2.IsRowSelected(i) Then
'                    Dim a As String = master_bank.GridView2.GetRowCellValue(i, "ID bank").ToString()
'                    Dim b As String = master_bank.GridView2.GetRowCellValue(i, "Nama bank").ToString()
'                    data.Rows.Add(a, b)
'                End If
'            Next
'            GridControl1.DataSource = data
'            For i = 0 To data.Columns.Count - 1
'                GridView2.Columns(i).OptionsColumn.AllowEdit = False
'            Next

'        Catch ex As Exception

'        End Try

'    End Sub

'    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
'        Me.Close()
'    End Sub


'    Private Sub GridView2_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView2.RowCellClick
'        edit_bank.ShowDialog()
'    End Sub
'End Class