Public Class pelunasan_hutang_supir 

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub namakaryawan_ButtonPressed(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles namakaryawan.ButtonPressed
        daftar_hutang_karyawan.ShowDialog()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            If idkaryawan.Text = "Belum Terisi" or kotaasal.Text=="Belum Terisi" Then
                MessageBox.Show("Karyawan Belum Dipilih")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class