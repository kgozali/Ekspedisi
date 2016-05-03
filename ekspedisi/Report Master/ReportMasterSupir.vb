Public Class ReportMasterSupir
    Private Sub ReportMasterSupir_PrintProgress(sender As Object, e As DevExpress.XtraPrinting.PrintProgressEventArgs) Handles Me.PrintProgress
        audit()
    End Sub
    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim formvb As String = "Master Supir"
        Dim aktivitas As String = "Print Master Supir "
        auditlog(user, kompname, formvb, aktivitas)
    End Sub
End Class