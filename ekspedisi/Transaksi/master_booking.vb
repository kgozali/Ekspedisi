Imports MySql.Data.MySqlClient
Public Class master_booking
    Dim cellvalue As String = ""
    Dim data As New DataTable
    Private Sub addsiswabaru_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles addsiswabaru.ItemClick
        booking_truk.ShowDialog()
    End Sub


    Sub process()
        Try
            Dim x As String = ""
            If aktif.Checked = True Then
                x = 1
                edit.Enabled = True
                ContextMenuStrip1.Enabled = True
            ElseIf nonaktif.Checked = True Then
                x = 0
                edit.Enabled = False
                ContextMenuStrip1.Items(0).Enabled = False
                ContextMenuStrip1.Items(1).Enabled = True
            End If

           
            If kodebooking.Checked = True Then
                cari.Visible = True
                DateTimePicker1.Visible = False
                GridView1.OptionsView.ShowFooter = True
                data = DtTable("Select id_booking `Kode Booking`,concat(day(tgl),'-',monthname(tgl),'-',year(tgl)) `Tanggal Pengiriman`,jam `Jam Pengiriman`,concat(ETA,' ','Jam') `ETA`,nama_principle `Principle`,concat(kota_asal,' - ',kota_tujuan) `Rute`,keterangan `Keterangan` from booking_truk,mprinciple,mrute where booking_truk.id_principle=mprinciple.id_principle and booking_truk.id_rute=mrute.id_rute and booking_truk.s='" + x + "' and id_booking LIKE '%" + cari.Text.ToString + "%' order by tgl asc, Jam asc, id_booking asc")
                GridControl1.DataSource = data
                summary()
                cellvalue = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi")
               

            ElseIf tgl.Checked = True Then
                cari.Visible = False
                DateTimePicker1.Visible = True
                GridView1.OptionsView.ShowFooter = True
                data = DtTable("Select id_booking `Kode Booking`,concat(day(tgl),'-',monthname(tgl),'-',year(tgl)) `Tanggal Pengiriman`,jam `Jam Pengiriman`,concat(ETA,' ','Jam') `ETA`,nama_principle `Principle`,concat(kota_asal,' - ',kota_tujuan) `Rute`,keterangan `Keterangan` from booking_truk,mprinciple,mrute where booking_truk.id_principle=mprinciple.id_principle and booking_truk.id_rute=mrute.id_rute and booking_truk.s='" + x + "' and booking_truk.tgl='" + DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' order by Jam asc,id_booking asc")
                GridControl1.DataSource = data
                summary()
                cellvalue = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi")
               
            End If
                unallowedit()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub summary()
        For i = 0 To GridView1.Columns.Count - 1
            If GridView1.Columns(i).FieldName.ToString = "Keterangan" Then
                GridView1.Columns(i).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                GridView1.Columns(i).SummaryItem.FieldName = "Keterangan"
                GridView1.Columns(i).SummaryItem.DisplayFormat = "Total {0} records"
            End If
        Next

    End Sub

    Sub unallowedit()
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns(i).OptionsColumn.AllowEdit = False
        Next
    End Sub

    Public Sub master_booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        process()
    End Sub

    Private Sub kodebooking_CheckedChanged(sender As Object, e As EventArgs) Handles kodebooking.CheckedChanged
        process()
    End Sub

    Private Sub tgl_CheckedChanged(sender As Object, e As EventArgs) Handles tgl.CheckedChanged
        process()
    End Sub

    Private Sub aktif_CheckedChanged(sender As Object, e As EventArgs) Handles aktif.CheckedChanged
        process()
    End Sub

    Private Sub nonaktif_CheckedChanged(sender As Object, e As EventArgs) Handles nonaktif.CheckedChanged
        process()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        process()
    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        process()
    End Sub

    Private Sub edit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles edit.ItemClick
        Try
            edit_booking.id.Text = ""
            edit_booking.id.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Booking").ToString
            edit_booking.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

 
    Private Sub EditBookingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditBookingToolStripMenuItem.Click
        Try
            edit_booking.id.Text = ""
            edit_booking.id.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Booking").ToString
            edit_booking.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PreviewAndPrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviewAndPrintToolStripMenuItem.Click
        frm_bookingtruk.bookcode = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Booking").ToString
        frm_bookingtruk.ShowDialog()
    End Sub
End Class