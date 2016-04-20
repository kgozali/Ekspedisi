Public Class pelunansan_piutang_karyawan 

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()

    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            For i = 0 To datapiutang.RowCount - 1
                InsertInto("insert into dpiutang_karyawan values ('" & datapiutang.GetRowCellValue(0, "Kode Karyawan") & "','" & datapiutang.GetRowCellValue(i, "Bayar") & "')")
            Next i
            MessageBox.Show("Piutang berhasil di update")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub idkaryawan_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles idkaryawan.ButtonClick
        daftar_karyawan_pelunasan.ShowDialog()
    End Sub

    Dim keamanan As String

    Private Sub datapiutang_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles datapiutang.CellValueChanged

        Try
            Dim angka As Double = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Nominal")
            Dim angka2 As Double = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Terbayar")
            If e.Column.FieldName = "Bayar" Then
                angka = angka - angka2 - e.Value
                With datapiutang
                    .SetRowCellValue(.FocusedRowHandle, "Sisa", angka)
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub datapiutang_ShownEditor(sender As Object, e As EventArgs) Handles datapiutang.ShownEditor
        If datapiutang.FocusedColumn.AbsoluteIndex <> 7 Then
            keamanan = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, datapiutang.FocusedColumn)
        End If
    End Sub
End Class