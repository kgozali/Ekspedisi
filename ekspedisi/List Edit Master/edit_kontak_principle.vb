Imports MySql.Data.MySqlClient
Public Class edit_kontak_principle
    Dim data As New DataTable
    Private Sub edit_kontak_principle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        master_kontak_principle.GridControl1.Visible = True
        master_kontak_principle.GridControl2.Visible = False
        data = DtTable("SELECT b.id_kontak `Kode Kontak`,p.nama_principle `Nama Principle`, b.nama_kontak `Nama Kontak`, b.tel1 `Telepon 1`, b.tel2 `Telepon 2`, b.Email `Email` from mkontakprinciple b, mprinciple p  where p.id_principle = b.id_principle and b.`s`='1'")
        master_kontak_principle.GridControl1.DataSource = data
        data = DtTable("SELECT b.id_kontak `Kode Kontak`,p.nama_principle `Nama Principle`, b.nama_kontak `Nama Kontak`, b.tel1 `Telepon 1`, b.tel2 `Telepon 2`, b.Email `Email` from mkontakprinciple b, mprinciple p  where p.id_principle = b.id_principle and b.`s`='1'")
        master_kontak_principle.GridControl2.DataSource = data
        master_kontak_principle.deldata.Down = False
        master_kontak_principle.hapus.Visible = False
        master_kontak_principle.editing.Visible = False
        master_kontak_principle.edit.Down = False
    End Sub
    Private Sub edit_kontak_principle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            data.Clear()
            If data.Columns.Count = 0 Then
                data.Columns.Add("Kode Kontak")
                data.Columns.Add("Nama Principle")
                data.Columns.Add("Nama Kontak")
                data.Columns.Add("Telepon 1")
                data.Columns.Add("Telepon 2")
                data.Columns.Add("Email")
            End If

            For i = 0 To master_kontak_principle.GridView2.RowCount - 1
                If master_kontak_principle.GridView2.IsRowSelected(i) Then
                    Dim a As String = master_kontak_principle.GridView2.GetRowCellValue(i, "Kode Kontak").ToString()
                    Dim b As String = master_kontak_principle.GridView2.GetRowCellValue(i, "Nama Principle").ToString()
                    Dim c As String = master_kontak_principle.GridView2.GetRowCellValue(i, "Nama Kontak").ToString()
                    Dim d As String = master_kontak_principle.GridView2.GetRowCellValue(i, "Telepon 1").ToString()
                    Dim e1 As String = master_kontak_principle.GridView2.GetRowCellValue(i, "Telepon 2").ToString()
                    Dim f As String = master_kontak_principle.GridView2.GetRowCellValue(i, "Email").ToString()
                    data.Rows.Add(a, b, c, d, e1, f)
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
        master_kontak_principle.GridControl1.Visible = True
        master_kontak_principle.GridControl2.Visible = False
        data = DtTable("SELECT b.id_kontak `Kode Kontak`,p.nama_principle `Nama Principle`, b.nama_kontak `Nama Kontak`, b.tel1 `Telepon 1`, b.tel2 `Telepon 2`, b.Email `Email` from mkontakprinciple b, mprinciple p  where p.id_principle = b.id_principle and b.`s`='1'")
        master_kontak_principle.GridControl1.DataSource = data
        data = DtTable("SELECT b.id_kontak `Kode Kontak`,p.nama_principle `Nama Principle`, b.nama_kontak `Nama Kontak`, b.tel1 `Telepon 1`, b.tel2 `Telepon 2`, b.Email `Email` from mkontakprinciple b, mprinciple p  where p.id_principle = b.id_principle and b.`s`='1'")
        master_kontak_principle.GridControl2.DataSource = data
        master_kontak_principle.deldata.Down = False
        master_kontak_principle.hapus.Visible = False
        master_kontak_principle.editing.Visible = False
        master_kontak_principle.edit.Down = False
        Me.Close()
    End Sub
    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        edit_kontak.ShowDialog()
    End Sub
End Class