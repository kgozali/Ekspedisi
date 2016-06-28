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
        Try
            InsertInto("update mmobil set no_pol='" & nomorpolisi.Text & "',tgl_beli=" & tanggal.Value.ToString("yyyyMMdd") & ",tipe_mobil='" & tipemobil.Text & "',warna='" & warna.Text & "',tahun='" & tahun.Text & "' where id_mobil='" & id.Text & "'")
            With edit_list_mobil.GridView1
                .SetRowCellValue(.FocusedRowHandle, "No Polisi", nomorpolisi.Text)
                .SetRowCellValue(.FocusedRowHandle, "Tanggal Beli", tanggal.Value.ToString("dd-MMMM-yyyy"))
            End With
            MessageBox.Show("Data berhasil diupdate", "Update Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class