Public Class pelunasan_piutang

    Private Sub principle_ButtonPressed(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles principle.ButtonPressed
        daftar_principle_pelunasan.ShowDialog()
    End Sub

    Private Sub pelunasan_piutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            nomerpelunasan.Text = autogenerate("PPP", "select max(id_pelunasan) from pelunasan_piutang")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click

    End Sub

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
End Class