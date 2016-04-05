Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Repository
Public Class add_item
    Dim dataset As New DataTable
    Private Sub add_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sortir()
        GroupControl2.Text = "List Barang " & transaksi_DO.namaprinciple
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        sortir()
    End Sub

    Sub sortir()
        Try
            If RadioButton1.Checked = True Then
                dataset = DtTable("Select id_barang `Kode Barang`,nama_barang `Nama Barang` from mbarang where id_principle='" + transaksi_DO.kodeprinciple + "' and id_barang LIKE '%" + TextEdit1.Text + "%'")
                checkadd()
            ElseIf RadioButton2.Checked = True Then
                dataset = DtTable("Select id_barang `Kode Barang`,nama_barang `Nama Barang` from mbarang where id_principle='" + transaksi_DO.kodeprinciple + "' and nama_barang LIKE '%" + TextEdit1.Text + "%'")
                checkadd()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit1.EditValueChanged
        sortir()
    End Sub

    Sub checkadd()
        DataSet.Columns.Add("Tambah", GetType(Boolean))
        GridControl1.DataSource = dataset
        For i = 0 To gridbarang.Columns.Count - 1
            If i = 2 Then
                gridbarang.Columns(i).OptionsColumn.AllowEdit = True
            Else
                gridbarang.Columns(i).OptionsColumn.AllowEdit = False
            End If

        Next
    End Sub
End Class