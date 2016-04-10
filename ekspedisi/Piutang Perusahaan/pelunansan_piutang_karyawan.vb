Public Class pelunansan_piutang_karyawan 

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()

    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click

    End Sub

    Private Sub idkaryawan_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles idkaryawan.ButtonClick
        daftar_karyawan_pelunasan.ShowDialog()
    End Sub
End Class