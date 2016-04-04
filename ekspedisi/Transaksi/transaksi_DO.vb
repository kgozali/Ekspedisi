Imports MySql.Data.MySqlClient
Public Class transaksi_DO
    Private Sub idbooking_EditValueChanged(sender As Object, e As EventArgs) Handles idbooking.EditValueChanged
        Dim data As String = ""
        data = Scalar("select nama_principle from mprinciple,booking_truk where id_booking='" + idbooking.Text.ToString + "' and mprinciple.id_principle=booking_truk.id_principle")
        TextBox2.Text = data
    End Sub

    Private Sub transaksi_DO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub idbooking_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles idbooking.ButtonClick
        booking_do.ShowDialog()
    End Sub
End Class