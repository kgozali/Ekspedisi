Imports MySql.Data.MySqlClient
Public Class add_item

    Private Sub add_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sortir()
        Label2.Text = transaksi_DO.namaprinciple
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        sortir()
    End Sub

    Sub sortir()
        Try
            If RadioButton1.Checked = True Then
                Dim dataset As New DataTable
                dataset = DtTable("Select id_barang `Kode Barang`,nama_barang `Nama Barang` from mbarang where id_principle='" + transaksi_DO.kodeprinciple + "' and id_barang LIKE '%" + TextEdit1.Text + "%'")
                GridControl1.DataSource = dataset
            ElseIf RadioButton2.Checked = True Then
                Dim dataset As New DataTable
                dataset = DtTable("Select id_barang `Kode Barang`,nama_barang `Nama Barang` from mbarang where id_principle='" + transaksi_DO.kodeprinciple + "' and nama_barang LIKE '%" + TextEdit1.Text + "%'")
                GridControl1.DataSource = dataset
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class