Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Repository
Public Class add_item
    Dim dataset As New DataTable
    Public barangset As DataTable = New DataTable

    Private Sub add_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'tes
            sortir()
            GroupControl2.Text = "List Barang " & transaksi_DO.namaprinciple


            For i = 0 To transaksi_DO.GridView1.DataRowCount - 1
                For j = 0 To gridbarang.DataRowCount - 1
                    If transaksi_DO.GridView1.GetRowCellValue(i, "Kode Barang") = gridbarang.GetRowCellValue(j, "Kode Barang") Then
                        gridbarang.SelectRow(j)
                    End If
                Next
            Next
            barangset.Rows.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
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
        Try
            GridControl1.DataSource = dataset
            For i = 0 To gridbarang.Columns.Count - 1
                If i = 2 Then
                    gridbarang.Columns(i).OptionsColumn.AllowEdit = True
                Else
                    gridbarang.Columns(i).OptionsColumn.AllowEdit = False
                End If

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            Dim cek As Boolean = False
            If barangset.Columns.Count - 1 > 0 Then     
            Else
                barangset.Columns.Add("Kode Barang")
                barangset.Columns.Add("Nama Barang")
                barangset.Columns.Add("Berat (Kilogram)")
            End If


            For i = 0 To gridbarang.DataRowCount - 1

                If gridbarang.IsRowSelected(i) Then
                    Dim ar(2) As String
                    ar(0) = gridbarang.GetRowCellValue(i, "Kode Barang")
                    ar(1) = gridbarang.GetRowCellValue(i, "Nama Barang")
                    ar(2) = "0"
                    barangset.Rows.Add(ar(0), ar(1), ar(2))
                End If
            Next
            transaksi_DO.GridControl1.DataSource = barangset
            For i = 0 To transaksi_DO.GridView1.Columns.Count - 1
                If i < 2 Then
                    transaksi_DO.GridView1.Columns(i).OptionsColumn.AllowEdit = False
                Else
                    transaksi_DO.GridView1.Columns(i).OptionsColumn.AllowEdit = True
                End If

            Next
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
End Class