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

           
            If kodebooking.Checked = True Then
                cari.Visible = True
                DateTimePicker1.Visible = False
                GridView1.OptionsView.ShowFooter = True
                data = DtTable("Select b.id_booking `idbooking`,concat(day(tgl),'-',monthname(tgl),'-',year(tgl)) `tgl`,jam `jam`,concat(ETA,' ','Jam') `eta`,nama_principle `principle`,concat(kota_asal,' - ',kota_tujuan) `rute`
                            ,group_concat(concat(mb.nama_barang,'  @',jumlah_satuan,' ',ms.satuan) SEPARATOR '\n') `barang`
                            ,b.keterangan `keterangan` 
                            from booking_truk b LEFT JOIN mprinciple mp ON b.id_principle=mp.id_principle 
                            LEFT JOIN mrute ON b.id_rute=mrute.id_rute
                            LEFT JOIN dbooking_truk d ON b.id_booking=d.id_booking    
                            LEFT JOIN mbarang mb ON d.id_barang=mb.id_barang 
                            LEFT JOIN msatuan ms ON mb.id_satuan=ms.id_satuan 
                            WHERE b.s='" & x & "' and b.id_booking LIKE '%" & cari.Text.ToString & "%' and del=0 
                            GROUP BY b.id_booking
                            order by b.tgl asc, b.Jam asc, b.id_booking asc")
                GridControl1.DataSource = data
                summary()
                cellvalue = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi")
               

            ElseIf tgl.Checked = True Then
                cari.Visible = False
                DateTimePicker1.Visible = True
                GridView1.OptionsView.ShowFooter = True
                data = DtTable("Select b.id_booking `idbooking`,concat(day(tgl),'-',monthname(tgl),'-',year(tgl)) `tgl`,jam `jam`,concat(ETA,' ','Jam') `eta`,nama_principle `principle`,concat(kota_asal,' - ',kota_tujuan) `rute`
                            ,group_concat(concat(mb.nama_barang,'  @',jumlah_satuan,' ',ms.satuan) SEPARATOR '\n') `barang`
                            ,b.keterangan `keterangan` 
                            from booking_truk b LEFT JOIN mprinciple mp ON b.id_principle=mp.id_principle 
                            LEFT JOIN mrute ON b.id_rute=mrute.id_rute
                            LEFT JOIN dbooking_truk d ON b.id_booking=d.id_booking    
                            LEFT JOIN mbarang mb ON d.id_barang=mb.id_barang 
                            LEFT JOIN msatuan ms ON mb.id_satuan=ms.id_satuan 
                            WHERE b.s='" & x & "' and b.tgl='" & DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") & "' and del=0 
                            GROUP BY b.id_booking
                            order by b.tgl asc, b.Jam asc, b.id_booking asc")
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
            If GridView1.RowCount = 0 Then
                MessageBox.Show("Tidak ada data yang terpilih", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                edit_booking.id.Text = ""
                edit_booking.id.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "idbooking").ToString
                edit_booking.ShowDialog()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

 
    Private Sub EditBookingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditBookingToolStripMenuItem.Click
        Try
            If GridView1.RowCount = 0 Then
                MessageBox.Show("Tidak ada data yang terpilih", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                edit_booking.id.Text = ""
                edit_booking.id.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "idbooking").ToString
                edit_booking.ShowDialog()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PreviewAndPrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviewAndPrintToolStripMenuItem.Click
        If GridView1.RowCount = 0 Then
            MessageBox.Show("Tidak ada data yang terpilih", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            frm_bookingtruk.bookcode = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "idbooking").ToString
            frm_bookingtruk.ShowDialog()
        End If
    End Sub

    Private Sub DeleteBookingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteBookingToolStripMenuItem.Click
        If GridView1.RowCount = 0 Then
            MessageBox.Show("Tidak ada data yang terpilih", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            del(sender, e)
        End If

    End Sub
    Sub del(sender As Object, e As EventArgs)
        Dim msg As Integer = MessageBox.Show("Apakah anda yakin ingin menghapus Booking " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "idbooking") & "? Data yang telah dihapus tidak dapat dikembalikan", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If msg = DialogResult.OK Then
            InsertInto("update booking_truk set del=1,s=0 where id_booking='" + GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "idbooking") + "'")
            InsertInto("delete from jurnal where no_jurnal='" + GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "idbooking") + "'")
            Dim ret As Boolean = InsertInto("delete from djurnal where no_jurnal='" + GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "idbooking") + "'")
            If ret = True Then
                audit()
                MessageBox.Show("Booking " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "idbooking") & " Berhasil di Hapus", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
                master_booking_Load(sender, e)
            End If

        End If
    End Sub
    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Booking Truk"
        Dim aktivitas As String = "Delete Booking: " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "idbooking").ToString
        auditlog(user, kompname, form, aktivitas)
    End Sub

    Private Sub deldata_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles deldata.ItemClick
        If GridView1.RowCount = 0 Then
            MessageBox.Show("Tidak ada data yang terpilih", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            del(sender, e)
        End If

    End Sub

   
    Private Sub jumpmenu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles jumpmenu.ItemClick
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
End Class