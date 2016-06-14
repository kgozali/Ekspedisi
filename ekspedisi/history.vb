Public Class historyperubahan
    Sub unallowedit()
        For i = 0 To daftarperubahan.Columns.Count - 1
            daftarperubahan.Columns(i).OptionsColumn.AllowEdit = False
        Next
    End Sub

    Private Sub historyperubahan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        unallowedit()
    End Sub
End Class