Public Class add_mobil_sewa 

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
        simpanedit.Visible = False
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Try
            InsertInto("insert into mmobil values ('" & autogenerate("MM", "select max(id_mobil) from mmobil") & "','" & nomorpolisi.Text & "'," & tanggal.Value.ToString("yyyyMMdd") & ",'" & tipemobil.Text & "','" & warna.Text & "','" & tahun.Text & "','1')")
            MessageBox.Show("Data berhasil diinput", "Input Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub simpanedit_Click(sender As Object, e As EventArgs) Handles simpanedit.Click

    End Sub
End Class