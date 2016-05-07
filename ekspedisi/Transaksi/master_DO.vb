Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Views.Grid
Public Class master_DO
    Dim path As String = ""
    Dim cellvalue As String = ""
    Dim datatable As New DataTable
    Private Sub addsiswabaru_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles addsiswabaru.ItemClick
        booking_do.ShowDialog()
    End Sub

    Public Sub master_DO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nama.Checked = True
        aktif.Checked = True
        process()
        summary()
        unallowedit()

    End Sub
    
   
    Sub process()
        Try
            Dim x As String = ""
            If aktif.Checked = True Then
                x = 1
                edit.Enabled = True
                deldata.Enabled = True
                ContextMenuStrip1.Items(0).Enabled = True
                ContextMenuStrip1.Items(1).Enabled = True
                ContextMenuStrip1.Items(2).Enabled = True
            ElseIf nonaktif.Checked = True Then
                x = 0
                edit.Enabled = False
                deldata.Enabled = False
                ContextMenuStrip1.Items(0).Enabled = False
                ContextMenuStrip1.Items(1).Enabled = False
                ContextMenuStrip1.Items(2).Enabled = True
            End If

            If nama.Checked = True Then
                cari.Visible = True
                DateTimePicker1.Visible = False
                GridView1.OptionsView.ShowFooter = True
                datatable = DtTable("select id_transaksi `Kode Transaksi`,no_DO `No.DO`,nama_principle `Nama Principle`,concat(day(tgl_terkirim),'-',monthname(tgl_terkirim),'-',year(tgl_terkirim)) `Tanggal Terkirim`,concat(day(jatuh_tempo),'-',monthname(jatuh_tempo),'-',year(jatuh_tempo)) `Tanggal Jatuh Tempo` from trans_do,booking_truk,mprinciple where trans_do.id_booking=booking_truk.id_booking and booking_truk.id_principle=mprinciple.id_principle and no_DO LIKE '%" + cari.Text.ToString + "%' and trans_do.s='" + x + "' and trans_do.del=0 order by jatuh_tempo asc,id_transaksi asc")
                GridControl1.DataSource = datatable
                summary()
                cellvalue = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi")



            ElseIf kodebooking.Checked = True Then

                cari.Visible = True
                DateTimePicker1.Visible = False
                GridView1.OptionsView.ShowFooter = True
                datatable = DtTable("select id_transaksi `Kode Transaksi`,no_DO `No.DO`,nama_principle `Nama Principle`,concat(day(tgl_terkirim),'-',monthname(tgl_terkirim),'-',year(tgl_terkirim)) `Tanggal Terkirim`,concat(day(jatuh_tempo),'-',monthname(jatuh_tempo),'-',year(jatuh_tempo)) `Tanggal Jatuh Tempo` from trans_do,booking_truk,mprinciple where trans_do.id_booking=booking_truk.id_booking and booking_truk.id_principle=mprinciple.id_principle and id_transaksi LIKE '%" + cari.Text.ToString + "%' and trans_do.s='" + x + "' and trans_do.del=0 order by jatuh_tempo asc,id_transaksi asc")
                GridControl1.DataSource = datatable
                summary()
                cellvalue = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi")



            ElseIf tgl.Checked = True Then
                cari.Visible = False
                DateTimePicker1.Visible = True
                GridView1.OptionsView.ShowFooter = True
                datatable = DtTable("select id_transaksi `Kode Transaksi`,no_DO `No.DO`,nama_principle `Nama Principle`,concat(day(tgl_terkirim),'-',monthname(tgl_terkirim),'-',year(tgl_terkirim)) `Tanggal Terkirim`,concat(day(jatuh_tempo),'-',monthname(jatuh_tempo),'-',year(jatuh_tempo)) `Tanggal Jatuh Tempo` from trans_do,booking_truk,mprinciple where trans_do.id_booking=booking_truk.id_booking and booking_truk.id_principle=mprinciple.id_principle and tgl_terkirim='" + DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' and trans_do.s='" + x + "' and trans_do.del=0 order by jatuh_tempo asc,id_transaksi asc")
                GridControl1.DataSource = datatable
                summary()
                cellvalue = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi")


            End If
            unallowedit()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        process()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        process()

    End Sub

    Private Sub nama_CheckedChanged(sender As Object, e As EventArgs) Handles nama.CheckedChanged
        process()

        cari.Text = ""
        DateTimePicker1.ResetText()
    End Sub

    Private Sub tgl_CheckedChanged(sender As Object, e As EventArgs) Handles tgl.CheckedChanged
        process()

        cari.Text = ""
        DateTimePicker1.ResetText()
    End Sub

    Private Sub kodebooking_CheckedChanged(sender As Object, e As EventArgs) Handles kodebooking.CheckedChanged
        process()

        cari.Text = ""
        DateTimePicker1.ResetText()
    End Sub
    
    Private Sub aktif_CheckedChanged(sender As Object, e As EventArgs) Handles aktif.CheckedChanged
        process()

    End Sub

    Private Sub nonaktif_CheckedChanged(sender As Object, e As EventArgs) Handles nonaktif.CheckedChanged
        process()

    End Sub

    Private Sub GridControl1_DataSourceChanged(sender As Object, e As EventArgs) Handles GridControl1.DataSourceChanged
        unallowedit()
    End Sub

    Sub unallowedit()
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns(i).OptionsColumn.AllowEdit = False
        Next
    End Sub

   
    

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub master_DO_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        res()
    End Sub

    Private Sub edit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles edit.ItemClick
        Try
            If GridView1.RowCount = 0 Then
                MessageBox.Show("Tidak ada data yang terpilih", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                edit_DO.id.Text = ""
                edit_DO.id.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi").ToString
                edit_DO.ShowDialog()
            End If
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        

    End Sub

    Private Sub jumpmenu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles jumpmenu.ItemClick
        Me.Close()
    End Sub
    Sub res()
        DateTimePicker1.ResetText()
        cari.Text = ""
    End Sub
    Sub summary()
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns(i).OptionsColumn.AllowEdit = False
            If GridView1.Columns(i).FieldName.ToString = "Tanggal Jatuh Tempo" Then
                GridView1.Columns(i).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                GridView1.Columns(i).SummaryItem.FieldName = "Tanggal Jatuh Tempo"
                GridView1.Columns(i).SummaryItem.DisplayFormat = "Total {0} records"
            End If
        Next

    End Sub


    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        If GridView1.RowCount = 0 Then
            MessageBox.Show("Tidak ada data yang terpilih", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            frm_notado.transid = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi")
            frm_notado.ShowDialog()
        End If

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Try
            If GridView1.RowCount = 0 Then
                MessageBox.Show("Tidak ada data yang terpilih", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                edit_DO.id.Text = ""
                edit_DO.id.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi").ToString
                edit_DO.ShowDialog()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub deldata_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles deldata.ItemClick
        If GridView1.RowCount = 0 Then
            MessageBox.Show("Tidak ada data yang terpilih", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            del(sender, e)
        End If

    End Sub
    Sub del(sender As Object, e As EventArgs)
        Dim msg As Integer = MessageBox.Show("Apakah anda yakin ingin menghapus Transaksi " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi") & "? Data yang telah dihapus tidak dapat dikembalikan", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If msg = DialogResult.OK Then
            InsertInto("update trans_do set del=1 where id_transaksi='" + GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi") + "'")
            Dim x As String = Scalar("select id_booking from trans_do where id_transaksi='" + GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi") + "'")
            InsertInto("update booking_truk set s=1 where id_booking='" + x.ToString + "'")
            InsertInto("delete from jurnal where no_jurnal='" + GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi") + "'")
            Dim ret As Boolean = InsertInto("delete from djurnal where no_jurnal='" + GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi") + "'")
            If ret = True Then
                audit()
                MessageBox.Show("Transaksi " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi") & " Berhasil di Hapus", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
                master_DO_Load(sender, e)
                main_menu.main_menu_Load(sender, e)
            End If

        End If
    End Sub
    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Delivery Order"
        Dim aktivitas As String = "Delete DO: " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi").ToString
        auditlog(user, kompname, form, aktivitas)
    End Sub

    Private Sub DeleteDeliveryOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteDeliveryOrderToolStripMenuItem.Click
        If GridView1.RowCount = 0 Then
            MessageBox.Show("Tidak ada data yang terpilih", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            del(sender, e)
        End If

    End Sub
End Class