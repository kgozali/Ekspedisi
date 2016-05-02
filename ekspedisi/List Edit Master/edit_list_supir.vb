Imports MySql.Data.MySqlClient
Public Class edit_list_supir
    Dim data As New DataTable
    Private Sub edit_list_supir_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        master_supir.GridControl1.Visible = True
        master_supir.GridControl2.Visible = False
        data = DtTable("SELECT id_supir `Kode Supir`, b.nama_supir `Nama Supir`, b.alamat `Alamat`, Kota, tel1 `Telepon 1`, tel2 `Telepon 2`, tgl_masuk `Tanggal Masuk`, keterangan `Keterangan` from msupir b where b.`s`='1'")
        master_supir.GridControl1.DataSource = data
        data = DtTable("SELECT id_supir `Kode Supir`, b.nama_supir `Nama Supir`, b.alamat `Alamat`, Kota, tel1 `Telepon 1`, tel2 `Telepon 2`, tgl_masuk `Tanggal Masuk`, keterangan `Keterangan` from msupir b where b.`s`='1'")
        master_supir.GridControl2.DataSource = data
        master_supir.edit.Down = False
        master_supir.GroupControl2.Enabled = True
        master_supir.editing.Visible = False
        master_supir.hapus.Visible = False
    End Sub
    Private Sub edit_list_supir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            data.Clear()
            If data.Columns.Count = 0 Then
                data.Columns.Add("Kode Supir")
                data.Columns.Add("Nama Supir")
                data.Columns.Add("Alamat")
                data.Columns.Add("Telepon 1")
                data.Columns.Add("Telepon 2")
                data.Columns.Add("Kota")
                data.Columns.Add("Tanggal Masuk")
                data.Columns.Add("Keterangan")
            End If

            For i = 0 To master_supir.checks.Rows.Count - 1
                Dim datatemp As New DataTable
                datatemp = DtTable("SELECT id_supir `Kode Supir`, b.nama_supir `Nama Supir`, b.alamat `Alamat`, tel1 `Telepon 1`, tel2 `Telepon 2`,Kota, tgl_masuk `Tanggal Masuk`, keterangan `Keterangan` from msupir b where b.`s`='1' and id_supir = '" & master_supir.checks.Rows(i).Item(0).ToString & "'")
                Dim a As String = datatemp.Rows(0).Item("Kode Supir").ToString
                Dim b As String = datatemp.Rows(0).Item("Nama Supir").ToString
                Dim c As String = datatemp.Rows(0).Item("Alamat").ToString
                Dim e1 As String = datatemp.Rows(0).Item("Telepon 1").ToString
                Dim f As String = datatemp.Rows(0).Item("Telepon 2").ToString
                Dim g As String = datatemp.Rows(0).Item("Kota").ToString
                Dim j As String = datatemp.Rows(0).Item("Tanggal Masuk").ToString
                Dim k As String = datatemp.Rows(0).Item("Keterangan").ToString

                data.Rows.Add(a, b, c, e1, f, g, j, k)

                'If master_supir.GridView2.IsRowSelected(i) Then
                '    Dim a As String = master_supir.GridView2.GetRowCellValue(i, "Kode Supir").ToString()
                '    Dim b As String = master_supir.GridView2.GetRowCellValue(i, "Nama Supir").ToString()
                '    Dim c As String = master_supir.GridView2.GetRowCellValue(i, "Alamat").ToString()
                '    Dim d As String = master_supir.GridView2.GetRowCellValue(i, "Email").ToString()
                '    Dim e1 As String = master_supir.GridView2.GetRowCellValue(i, "Telepon 1").ToString()
                '    Dim f As String = master_supir.GridView2.GetRowCellValue(i, "Telepon 2").ToString()
                '    Dim g As String = master_supir.GridView2.GetRowCellValue(i, "Kota").ToString()
                '    Dim h As String = master_supir.GridView2.GetRowCellValue(i, "Jabatan").ToString()
                '    Dim j As String = master_supir.GridView2.GetRowCellValue(i, "Tanggal Masuk").ToString()
                '    Dim k As String = master_supir.GridView2.GetRowCellValue(i, "Keterangan").ToString()
                '    Dim l As String = master_supir.GridView2.GetRowCellValue(i, "No KTP").ToString()


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
        master_supir.GridControl1.Visible = True
        master_supir.GridControl2.Visible = False
        data = DtTable("SELECT id_supir `Kode Supir`, b.nama_supir `Nama Supir`, b.alamat `Alamat`, Kota, tel1 `Telepon 1`, tel2 `Telepon 2`, tgl_masuk `Tanggal Masuk`, keterangan `Keterangan` from msupir b where b.`s`='1'")
        master_supir.GridControl1.DataSource = data
        data = DtTable("SELECT id_supir `Kode Supir`, b.nama_supir `Nama Supir`, b.alamat `Alamat`, Kota, tel1 `Telepon 1`, tel2 `Telepon 2`, tgl_masuk `Tanggal Masuk`, keterangan `Keterangan` from msupir b where b.`s`='1'")
        master_supir.GridControl2.DataSource = data
        master_supir.edit.Down = False
        master_supir.GroupControl2.Enabled = True
        master_supir.editing.Visible = False
        master_supir.hapus.Visible = False
        Me.Close()
    End Sub


    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        edit_supir.ShowDialog()
    End Sub
End Class