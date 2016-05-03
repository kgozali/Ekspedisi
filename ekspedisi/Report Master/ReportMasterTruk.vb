Public Class ReportMasterTruk
    Private Sub ReporMasterTruk_PrintProgress(sender As Object, e As DevExpress.XtraPrinting.PrintProgressEventArgs) Handles Me.PrintProgress
        audit()
    End Sub
    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim formvb As String = "Master Truk"
        Dim aktivitas As String = "Print Master Truk "
        auditlog(user, kompname, formvb, aktivitas)
    End Sub
End Class