Public Class ReportMasterCustomer
    Private Sub ReportMasterCustomer_PrintProgress(sender As Object, e As DevExpress.XtraPrinting.PrintProgressEventArgs) Handles Me.PrintProgress
        audit()
    End Sub
    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim formvb As String = "Master Customerr"
        Dim aktivitas As String = "Print Master Customer "
        auditlog(user, kompname, formvb, aktivitas)
    End Sub
End Class