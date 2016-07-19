Imports DevExpress.XtraPrinting

Public Class invoice
    Dim x As String
    Private Sub invoice_PrintProgress(sender As Object, e As PrintProgressEventArgs) Handles Me.PrintProgress
        x = preview_invoice_sewa.idtransaksi
        InsertInto("update trans_mobil set cetakan_ke=(cetakan_ke)+1 where id_booking='" + x.ToString + "'")
        audit()
    End Sub

    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim formvb As String = "Sewa Mobil"
        Dim aktivitas As String = "Print Invoice Sewa Mobil: " & x.ToString
        auditlog(user, kompname, formvb, aktivitas)
    End Sub
End Class