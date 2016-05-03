Public Class master_akun

    Private Sub refreshgrid(ByVal keyid As String)
        'cek
        Dim lcdata As DataTable
        If IsNothing(lcdata) = False Then lcdata.Rows.Clear()
        lcdata = DtTable("select * from vw_makun where keyid like '%" & keyid & "%'")
        GridControl1.DataSource = lcdata
        GridControl1.Refresh()
    End Sub

    Private Sub master_akun_Load(sender As Object, e As EventArgs) Handles Me.Load
        refreshgrid("")
    End Sub

    Private Sub addsiswabaru_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles addsiswabaru.ItemClick
        Dim flagsave As Boolean = COA.initform(1, "")
        If flagsave Then
            refreshgrid("")
        End If
    End Sub

    Private Sub edit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles edit.ItemClick
        Dim flagsave As Boolean

        Dim keyid As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "keyid").ToString
        flagsave = COA.initform(2, keyid)
        If flagsave Then
            refreshgrid("")
        End If
    End Sub

    Private Sub deldata_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles deldata.ItemClick
        Dim flagsave As Boolean

        Dim keyid As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "keyid").ToString
        flagsave = COA.initform(3, keyid)
        If flagsave Then
            refreshgrid("")
        End If
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub
End Class