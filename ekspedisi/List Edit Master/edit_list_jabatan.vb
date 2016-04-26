Imports MySql.Data.MySqlClient
Public Class edit_list_jabatan
    Dim data As New DataTable
    Private Sub edit_list_jabatan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        master_jabatan.GridControl1.Visible = True
        master_jabatan.GridControl2.Visible = False
        data = DtTable("SELECT id_jabatan `Kode Jabatan`, b.nama_jabatan `Nama Jabatan` from mjabatan b where b.`s`='1'")
        master_jabatan.GridControl1.DataSource = data
        data = DtTable("SELECT id_jabatan `Kode Jabatan`, b.nama_jabatan `Nama Jabatan` from mjabatan b where b.`s`='1'")
        master_jabatan.GridControl2.DataSource = data
        master_jabatan.edit.Down = False
        master_jabatan.hapus.Visible = False
        master_jabatan.editing.Visible = False
        master_jabatan.GroupControl2.Enabled = True
    End Sub
    Private Sub edit_list_jabatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            data.Clear()
            If data.Columns.Count = 0 Then
                data.Columns.Add("Kode Jabatan")
                data.Columns.Add("Nama Jabatan")
            End If

            For i = 0 To master_jabatan.GridView2.RowCount - 1
                If master_jabatan.GridView2.IsRowSelected(i) Then
                    Dim a As String = master_jabatan.GridView2.GetRowCellValue(i, "Kode Jabatan").ToString()
                    Dim b As String = master_jabatan.GridView2.GetRowCellValue(i, "Nama Jabatan").ToString()
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
        master_jabatan.GridControl1.Visible = True
        master_jabatan.GridControl2.Visible = False
        data = DtTable("SELECT id_jabatan `Kode Jabatan`, b.nama_jabatan `Nama Jabatan` from mjabatan b where b.`s`='1'")
        master_jabatan.GridControl1.DataSource = data
        data = DtTable("SELECT id_jabatan `Kode Jabatan`, b.nama_jabatan `Nama Jabatan` from mjabatan b where b.`s`='1'")
        master_jabatan.GridControl2.DataSource = data
        master_jabatan.deldata.Down = False
        master_jabatan.edit.Down = False

    End Sub
    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        edit_jabatan.ShowDialog()
    End Sub
End Class