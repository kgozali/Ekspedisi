Public Class pelunasan_hutang_supir 

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub namakaryawan_ButtonPressed(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles namakaryawan.ButtonPressed
        daftar_hutang_karyawan.ShowDialog()
    End Sub
End Class