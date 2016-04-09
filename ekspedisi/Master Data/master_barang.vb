Imports MySql.Data.MySqlClient
Public Class master_barang
    Dim data As New DataTable
    Dim cc(1000) As String
    Private Sub addbarangbaru_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles addbarangbaru.ItemClick
        add_barang.ShowDialog()
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub edit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles edit.ItemClick
        If edit.Down = True Then
            GridControl2.DataSource = data
            GridControl2.Visible = True
            deldata.Down = False
            editing.Visible = True
            hapus.Visible = False
            GridControl1.Visible = False
            For i = 0 To data.Columns.Count - 1
                GridView2.Columns(i).OptionsColumn.AllowEdit = False
            Next
        Else
            GridControl1.Visible = False
            editing.Visible = False
        End If
    End Sub

    Private Sub master_barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridControl2.Visible = False
        data = DtTable("SELECT id_barang `ID Barang`, b.nama_barang `Nama Barang`, p.nama_principle `Nama Principle`, Keterangan from mbarang b, mprinciple p where b.id_principle = p.id_principle and b.`s`='0'")
        GridControl1.DataSource = data
        For i = 0 To data.Columns.Count - 1
            GridView1.Columns(i).OptionsColumn.AllowEdit = False
        Next

    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        If edit.Down = True Then
            If id.Checked = True Then
                If aktif.Checked = True Then
                    data = DtTable("SELECT id_barang `ID Barang`, b.nama_barang `Nama Barang`, p.nama_principle `Nama Principle`, Keterangan from mbarang b, mprinciple p where b.id_principle = p.id_principle and b.`s`='0' and id_barang like '%" & cari.Text & "%'")
                Else
                    data = DtTable("SELECT id_barang `ID Barang`, b.nama_barang `Nama Barang`, p.nama_principle `Nama Principle`, Keterangan from mbarang b, mprinciple p where b.id_principle = p.id_principle and b.`s`='1' and id_barang like '%" & cari.Text & "%'")
                End If

            Else
                If aktif.Checked = True Then
                    data = DtTable("SELECT id_barang `ID Barang`, b.nama_barang `Nama Barang`, p.nama_principle `Nama Principle`, Keterangan from mbarang b, mprinciple p where b.id_principle = p.id_principle and b.`s`='0' and nama_barang like '%" & cari.Text & "%'")
                Else
                    data = DtTable("SELECT id_barang `ID Barang`, b.nama_barang `Nama Barang`, p.nama_principle `Nama Principle`, Keterangan from mbarang b, mprinciple p where b.id_principle = p.id_principle and b.`s`='1' and nama_barang like '%" & cari.Text & "%'")
                End If
            End If
            GridControl2.DataSource = data

            For i = 0 To GridView2.RowCount - 1
                For j = 0 To 1000
                    If GridView2.GetRowCellValue(GridView1.FocusedRowHandle, "ID Barang") = cc(j) Then
                        GridView2.SelectRow(i)
                    End If
                Next
            Next


        Else
            If id.Checked = True Then
                If aktif.Checked = True Then
                    data = DtTable("SELECT id_barang `ID Barang`, b.nama_barang `Nama Barang`, p.nama_principle `Nama Principle`, Keterangan from mbarang b, mprinciple p where b.id_principle = p.id_principle and b.`s`='0' and id_barang like '%" & cari.Text & "%'")
                Else
                    data = DtTable("SELECT id_barang `ID Barang`, b.nama_barang `Nama Barang`, p.nama_principle `Nama Principle`, Keterangan from mbarang b, mprinciple p where b.id_principle = p.id_principle and b.`s`='1' and id_barang like '%" & cari.Text & "%'")
                End If

            Else
                If aktif.Checked = True Then
                    data = DtTable("SELECT id_barang `ID Barang`, b.nama_barang `Nama Barang`, p.nama_principle `Nama Principle`, Keterangan from mbarang b, mprinciple p where b.id_principle = p.id_principle and b.`s`='0' and nama_barang like '%" & cari.Text & "%'")
                Else
                    data = DtTable("SELECT id_barang `ID Barang`, b.nama_barang `Nama Barang`, p.nama_principle `Nama Principle`, Keterangan from mbarang b, mprinciple p where b.id_principle = p.id_principle and b.`s`='1' and nama_barang like '%" & cari.Text & "%'")
                End If
            End If
            GridControl1.DataSource = data
        End If


    End Sub


    Private Sub editing_Click(sender As Object, e As EventArgs) Handles editing.Click
        Try
            For i = 0 To GridView2.DataRowCount - 1
                If GridView2.IsRowSelected(i) Then

                End If
            Next

        Catch ex As Exception

        End Try
    End Sub


    Private Sub GridView2_Click(sender As Object, e As EventArgs) Handles GridView2.RowCellClick
        For i = 0 To GridView2.RowCount() - 1
            If GridView2.IsRowSelected(i) = True Then
                cc(i) = GridView2.GetRowCellValue(i, "ID Barang").ToString
            End If
        Next



    End Sub


    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Try
            Dim cek As Boolean = False
            For i = 0 To GridView2.RowCount - 1
                If GridView2.IsRowSelected(i) = True Then
                    cek = True
                End If
            Next i
            If cek = True Then
                Select Case MsgBox("Apakah anda yakin menghapus data ini?", MsgBoxStyle.YesNo, "System Error")
                    Case MsgBoxResult.Yes
                        For i = 0 To GridView2.RowCount - 1
                            If GridView2.IsRowSelected(i) = True Then
                                InsertInto("update mbarang set `s`=1 where id_barang='" & GridView2.GetRowCellValue(GridView1.FocusedRowHandle, "ID Barang").ToString & "'")
                            End If
                        Next i
                        MessageBox.Show("File Deleted")
                        connect.Close()
                        GridControl2.Visible = False
                        GridControl1.Visible = True
                        master_barang_Load(sender, e)
                End Select
            Else
                MessageBox.Show("Tidak ada data yang terpilih")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub deldata_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles deldata.ItemClick
        If deldata.Down = True Then
            GridControl2.DataSource = data
            GridControl2.Visible = True
            edit.Down = False
            GridControl1.Visible = False
            editing.Visible = False
            hapus.Visible = True
        Else
            GridControl2.Visible = False
            hapus.Visible = False
        End If
    End Sub
End Class