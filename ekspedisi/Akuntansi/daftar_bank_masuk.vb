
Public Class daftar_bank_masuk

    Public Sub refreshgrid(ByVal keyid As String)
        'cek
        Dim lcdata As DataTable
        If IsNothing(lcdata) = False Then lcdata.Rows.Clear()
        lcdata = DtTable("select id_tbank as nobukti,tgl,keterangan,id_tbank as keyid from trans_bank where tipe_dokumen='M'")
        GridControl1.DataSource = lcdata
        GridControl1.Refresh()
    End Sub

    Private Sub daftar_bank_masuk_Load(sender As Object, e As EventArgs) Handles Me.Load
        refreshgrid("")
    End Sub

    Private Sub addsiswabaru_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles addsiswabaru.ItemClick
        Dim flagsave As Boolean = Bank_Masuk.initform(1, "")
        If flagsave Then
            refreshgrid("")
        End If
    End Sub

    Private Sub edit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles edit.ItemClick
        Dim flagsave As Boolean

        Dim keyid As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "keyid").ToString
        flagsave = Bank_Masuk.initform(2, keyid)
        If flagsave Then
            refreshgrid("")
        End If
    End Sub

    Private Sub deldata_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles deldata.ItemClick
        Dim flagsave As Boolean

        Dim keyid As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "keyid").ToString
        flagsave = Bank_Masuk.initform(3, keyid)
        If flagsave Then
            refreshgrid("")
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim keyid As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "keyid").ToString
        If keyid = "" Then Exit Sub
        'frmcetaknota.gencetak("TRANSAKSI BANK", keyid, "M")

    End Sub
End Class