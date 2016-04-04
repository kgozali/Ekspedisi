Imports MySql.Data.MySqlClient
Public Class transaksi_DO
    Private Sub idbooking_EditValueChanged(sender As Object, e As EventArgs) Handles idbooking.EditValueChanged
        Dim data As String = ""
        data = Scalar("select nama_principle from mprinciple,booking_truk where id_booking='" + idbooking.Text.ToString + "' and mprinciple.id_principle=booking_truk.id_principle")
        TextBox2.Text = data
    End Sub
End Class