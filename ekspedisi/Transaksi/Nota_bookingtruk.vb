Public Class Nota_bookingtruk
    Dim x As String
    Private Sub Nota_bookingtruk_PrintProgress(sender As Object, e As DevExpress.XtraPrinting.PrintProgressEventArgs) Handles Me.PrintProgress
        x = frm_bookingtruk.bookcode
        InsertInto("update booking_truk set cetakan_ke=(cetakan_ke)+1 where id_booking='" + x.ToString + "'")
        audit()

    End Sub
    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim formvb As String = "Booking Truk"
        Dim aktivitas As String = "Print Booking: " & x.ToString
        auditlog(user, kompname, formvb, aktivitas)
    End Sub
End Class