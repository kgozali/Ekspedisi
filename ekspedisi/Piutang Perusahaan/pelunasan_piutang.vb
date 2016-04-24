Public Class pelunasan_piutang

    Private Sub principle_ButtonPressed(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles principle.ButtonPressed
        daftar_principle_pelunasan.ShowDialog()
    End Sub

    Private Sub pelunasan_piutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim data As New DataTable
            nomerpelunasan.Text = autogenerate("PPP", "select max(id_pelunasan) from pelunasan_piutang")
            data = DtTable("select nama_akun,kode_akun from makun where tipe_akun='Kas&Bank'")
            RepositoryItemLookUpEdit1.DataSource = data
            RepositoryItemLookUpEdit1.DisplayMember = "nama_akun"
            RepositoryItemLookUpEdit1.ValueMember = "kode_akun"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Try
            Dim nominalbayar As Double = nominalbg.Text
            Dim piutang As Double = totalpiutang.Text
            Dim centang As Boolean = False
            For i = 0 To pembayaran.RowCount - 1
                If pembayaran.GetRowCellValue(i, "Bayar") = True Then
                    centang = True
                End If

            Next i

            If idprinciple.Text = "idprinciple" Then
                MessageBox.Show("Principle belum dipilih", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf centang = False Then
                MessageBox.Show("Transaksi DO belum terpilih", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf pembayaran.RowCount = 0 Or nominalbg.Text = "0" Then
                MessageBox.Show("Pembayaran belum diisi", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf nominalbayar < piutang Then
                MessageBox.Show("Detail pembayaran tidak sesuai", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub


    Private Sub datapiutang_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles datapiutang.CellValueChanging
        Try
            If datapiutang.FocusedColumn.AbsoluteIndex = 6 Then
                Dim angka As Double = 0
                If datapiutang.FocusedColumn.AbsoluteIndex = 6 Then
                    If datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") = False Then
                        With datapiutang
                            .SetRowCellValue(datapiutang.FocusedRowHandle, .FocusedColumn, True)
                        End With
                    Else
                        With datapiutang
                            .SetRowCellValue(datapiutang.FocusedRowHandle, .FocusedColumn, False)
                        End With
                    End If

                    For i = 0 To datapiutang.RowCount - 1

                        If datapiutang.GetRowCellValue(i, "Bayar") = True Then
                            angka = angka + datapiutang.GetRowCellValue(i, "Nominal")
                        End If
                    Next i
                    labeltotalbayar.Text = angka.ToString
                    totaldibayar.Text = angka.ToString
                End If
            Else
                With datapiutang
                    .SetRowCellValue(.FocusedRowHandle, .FocusedColumn, keamanan)
                End With
            End If

            
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Dim keamanan As String
    Private Sub datapiutang_ShownEditor(sender As Object, e As EventArgs) Handles datapiutang.ShownEditor
        Try
            If datapiutang.FocusedColumn.AbsoluteIndex <> 6 Then
                keamanan = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, datapiutang.FocusedColumn)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pembayaran_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles pembayaran.CellValueChanging
        If datapiutang.FocusedColumn.AbsoluteIndex = 2 Then
            'datapiutang.GetRowCellValue(
        End If

    End Sub
End Class