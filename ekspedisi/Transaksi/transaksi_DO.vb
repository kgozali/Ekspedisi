Imports MySql.Data.MySqlClient
Public Class transaksi_DO
    Public kodeprinciple As String = ""
    Public namaprinciple As String = ""
    Private Sub idbooking_EditValueChanged(sender As Object, e As EventArgs) Handles idbooking.EditValueChanged
        Dim data As String = ""
        data = Scalar("select nama_principle from mprinciple,booking_truk where id_booking='" + idbooking.Text.ToString + "' and mprinciple.id_principle=booking_truk.id_principle")
        TextBox2.Text = data
        namaprinciple = data
    End Sub

    Private Sub transaksi_DO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub idbooking_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles idbooking.ButtonClick
        Try
            Me.Visible = False
            booking_do.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        add_item.ShowDialog()
        kodeprinciple = Scalar("select id_principle from booking_truk where id_booking='" + idbooking.Text + "'")
    End Sub
End Class