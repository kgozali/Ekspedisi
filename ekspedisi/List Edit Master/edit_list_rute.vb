Imports MySql.Data.MySqlClient
Public Class edit_list_rute
    Dim data As New DataTable


    Private Sub edit_list_rute_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            data.Columns.Add("Kode Rute")
            data.Columns.Add("Kota Asal")
            data.Columns.Add("Kota Tujuan")
            data.Columns.Add("Nama Principle")
            data.Columns.Add("Price Per Unit")
            data.Columns.Add("Unit")


            For i = 0 To master_rute.GridView1.RowCount - 1
                If master_rute.GridView1.IsRowSelected(i) Then
                    Dim a As String = master_rute.GridView1.GetRowCellValue(i, "Kode Rute").ToString()
                    Dim b As String = master_rute.GridView1.GetRowCellValue(i, "Kota Asal").ToString()
                    Dim c As String = master_rute.GridView1.GetRowCellValue(i, "Kota Tujuan").ToString()
                    Dim d As String = master_rute.GridView1.GetRowCellValue(i, "Nama Principle").ToString()
                    Dim e1 As String = master_rute.GridView1.GetRowCellValue(i, "Price Per Unit").ToString()
                    Dim f As String = master_rute.GridView1.GetRowCellValue(i, "Unit").ToString()

                    data.Rows.Add(a, b, c, d, e1, f)
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
        edit_rute.ShowDialog()
    End Sub
End Class