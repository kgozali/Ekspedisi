Imports MySql.Data.MySqlClient
Public Class edit_list_karyawan
    Dim data As New DataTable
    Private Sub edit_list_karyawan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        master_karyawan.GridControl1.Visible = True
        master_karyawan.GridControl2.Visible = False
        data = DtTable("SELECT id_karyawan `Kode Karyawan`, b.nama_karyawan `Nama Karyawan`, b.alamat `Alamat`,Email, Kota, tel1 `Telepon 1`, tel2 `Telepon 2`, j.nama_jabatan `Jabatan`, tgl_masuk `Tanggal Masuk`, keterangan `Keterangan`, no_ktp `No KTP` from mkaryawan b, mjabatan j where b.id_jabatan = j.id_jabatan and j.`s` = '1' and b.`s`='1'")
        master_karyawan.GridControl1.DataSource = data
        data = DtTable("SELECT id_karyawan `Kode Karyawan`, b.nama_karyawan `Nama Karyawan`, b.alamat `Alamat`,Email, Kota, tel1 `Telepon 1`, tel2 `Telepon 2`, j.nama_jabatan `Jabatan`, tgl_masuk `Tanggal Masuk`, keterangan `Keterangan`, no_ktp `No KTP` from mkaryawan b, mjabatan j where b.id_jabatan = j.id_jabatan and j.`s` = '1' and b.`s`='1'")
        master_karyawan.GridControl2.DataSource = data
        master_karyawan.edit.Down = False
        master_karyawan.GroupControl2.Enabled = True
        master_karyawan.editing.Visible = False
        master_karyawan.hapus.Visible = False
    End Sub
    Private Sub edit_list_karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            data.Clear()
            If data.Columns.Count = 0 Then
                data.Columns.Add("Kode Karyawan")
                data.Columns.Add("Nama Karyawan")
                data.Columns.Add("Alamat")
                data.Columns.Add("Email")
                data.Columns.Add("Telepon 1")
                data.Columns.Add("Telepon 2")
                data.Columns.Add("Kota")
                data.Columns.Add("Jabatan")
                data.Columns.Add("Tanggal Masuk")
                data.Columns.Add("Keterangan")
                data.Columns.Add("No KTP")
            End If

            For i = 0 To master_karyawan.checks.Rows.Count - 1
                Dim datatemp As New DataTable
                datatemp = DtTable("SELECT id_karyawan `Kode Karyawan`, b.nama_karyawan `Nama Karyawan`, b.alamat `Alamat`,Email, Kota, tel1 `Telepon 1`, tel2 `Telepon 2`, j.nama_jabatan `Jabatan`, tgl_masuk `Tanggal Masuk`, keterangan `Keterangan`, no_ktp `No KTP` from mkaryawan b, mjabatan j where b.id_jabatan = j.id_jabatan and j.`s` = '1' and b.`s`='1' and id_karyawan = '" & master_karyawan.checks.Rows(i).Item(0).ToString & "'")
                Dim a As String = datatemp.Rows(0).Item("Kode Karyawan").ToString
                Dim b As String = datatemp.Rows(0).Item("Nama Karyawan").ToString
                Dim c As String = datatemp.Rows(0).Item("Alamat").ToString
                Dim d As String = datatemp.Rows(0).Item("Email").ToString
                Dim e1 As String = datatemp.Rows(0).Item("Telepon 1").ToString
                Dim f As String = datatemp.Rows(0).Item("Telepon 2").ToString
                Dim g As String = datatemp.Rows(0).Item("Kota ").ToString
                Dim h As String = datatemp.Rows(0).Item("Jabatan").ToString
                Dim j As String = datatemp.Rows(0).Item("Tanggal Masuk").ToString
                Dim k As String = datatemp.Rows(0).Item("Keterangan").ToString
                Dim l As String = datatemp.Rows(0).Item("No KTP").ToString
                data.Rows.Add(a, b, c, d, e1, f, g, h, j, k, l)
                'If master_karyawan.GridView2.IsRowSelected(i) Then
                '    Dim a As String = master_karyawan.GridView2.GetRowCellValue(i, "Kode Karyawan").ToString()
                '    Dim b As String = master_karyawan.GridView2.GetRowCellValue(i, "Nama Karyawan").ToString()
                '    Dim c As String = master_karyawan.GridView2.GetRowCellValue(i, "Alamat").ToString()
                '    Dim d As String = master_karyawan.GridView2.GetRowCellValue(i, "Email").ToString()
                '    Dim e1 As String = master_karyawan.GridView2.GetRowCellValue(i, "Telepon 1").ToString()
                '    Dim f As String = master_karyawan.GridView2.GetRowCellValue(i, "Telepon 2").ToString()
                '    Dim g As String = master_karyawan.GridView2.GetRowCellValue(i, "Kota").ToString()
                '    Dim h As String = master_karyawan.GridView2.GetRowCellValue(i, "Jabatan").ToString()
                '    Dim j As String = master_karyawan.GridView2.GetRowCellValue(i, "Tanggal Masuk").ToString()
                '    Dim k As String = master_karyawan.GridView2.GetRowCellValue(i, "Keterangan").ToString()
                '    Dim l As String = master_karyawan.GridView2.GetRowCellValue(i, "No KTP").ToString()


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
        Me.Close()
    End Sub


    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        edit_karyawan.ShowDialog()
    End Sub
End Class