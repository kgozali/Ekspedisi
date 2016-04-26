Public Class master_piutang_principle 
    Dim data As New DataTable
    Private Sub jumpmenu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles jumpmenu.ItemClick
        Me.Close()
    End Sub

    Private Sub addbarangbaru_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles pelunasanbaru.ItemClick
        pelunasan_piutang.ShowDialog()
    End Sub

    Private Sub master_piutang_principle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            data = DtTable("SELECT b.id_booking `Kode Booking`, id_transaksi `Kode Transaksi`,mp.id_principle `Kode Principle`,nama_principle `Nama Principle`,no_DO `Nomer DO` FROM trans_do t,booking_truk b, mprinciple mp where b.id_principle=mp.id_principle and t.id_booking=b.id_booking and t.s='1'")
            baranglist.DataSource = data
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub edit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles edit.ItemClick
        Try
            data = New DataTable
            data = DtTablebayarcek("Select t.id_transaksi `Kode Transaksi`,no_do as `Nomer DO`,concat(day(tgl_terkirim),'-',monthname(tgl_terkirim),'-',year(tgl_terkirim)) `Tanggal Pengiriman`,jam `Jam Pengiriman`,concat(kota_asal,' - ',kota_tujuan) `Rute`, sum(berat_per_kg)*price_per_unit `Nominal` from booking_truk,mprinciple,mrute,trans_do t,dtrans_do dt where dt.id_transaksi=t.id_transaksi and t.id_booking=booking_truk.id_booking and booking_truk.id_principle=mprinciple.id_principle and booking_truk.id_rute=mrute.id_rute  and mprinciple.id_principle='" & allprinciple.GetRowCellValue(allprinciple.FocusedRowHandle, "Kode Principle") & "' group by t.id_transaksi")
            edit_pelunasan_principle.bayarpiutang.DataSource = data
            Dim angka As Double = 0
            For i = 0 To edit_pelunasan_principle.datapiutang.RowCount - 1
                angka = angka + edit_pelunasan_principle.datapiutang.GetRowCellValue(i, "Nominal")
                With edit_pelunasan_principle.datapiutang
                    .SetRowCellValue(i, "Bayar", False)
                End With
            Next i
            edit_pelunasan_principle.totalpiutang.Text = angka.ToString
            edit_pelunasan_principle.principle.Text = allprinciple.GetRowCellValue(allprinciple.FocusedRowHandle, "Nama Principle")
            edit_pelunasan_principle.idprinciple.Text = allprinciple.GetRowCellValue(allprinciple.FocusedRowHandle, "Kode Principle")
            edit_pelunasan_principle.alamat.Text = allprinciple.GetRowCellValue(allprinciple.FocusedRowHandle, "Alamat")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        edit_pelunasan_principle.ShowDialog()
    End Sub

    Private Sub aktif_CheckedChanged(sender As Object, e As EventArgs) Handles aktif.CheckedChanged

        cari_EditValueChanged(sender, e)

    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        Try
            data = New DataTable
            If aktif.Checked = True And id.Checked = True Then
                data = DtTable("SELECT b.id_booking `Kode Booking`, id_transaksi `Kode Transaksi`,nama_principle `Nama Principle`,no_DO `Nomer DO` FROM trans_do t,booking_truk b, mprinciple mp where b.id_principle=mp.id_principle and t.id_booking=b.id_booking and t.s='1' and id_principle like '%" & cari.Text & "%'")
            ElseIf aktif.Checked = True And nama.Checked = True Then
                data = DtTable("SELECT b.id_booking `Kode Booking`, id_transaksi `Kode Transaksi`,nama_principle `Nama Principle`,no_DO `Nomer DO` FROM trans_do t,booking_truk b, mprinciple mp where b.id_principle=mp.id_principle and t.id_booking=b.id_booking and t.s='1' and nama_principle like '%" & cari.Text & "%'")
            ElseIf aktif.Checked = True And nomerdo.Checked = True Then
                data = DtTable("SELECT b.id_booking `Kode Booking`, id_transaksi `Kode Transaksi`,nama_principle `Nama Principle`,no_DO `Nomer DO` FROM trans_do t,booking_truk b, mprinciple mp where b.id_principle=mp.id_principle and t.id_booking=b.id_booking and t.s='1' and no_DO like '%" & cari.Text & "%'")
            ElseIf aktif.Checked = False And nama.Checked = True Then
                data = DtTable("SELECT b.id_booking `Kode Booking`, id_transaksi `Kode Transaksi`,nama_principle `Nama Principle`,no_DO `Nomer DO` FROM trans_do t,booking_truk b, mprinciple mp where b.id_principle=mp.id_principle and t.id_booking=b.id_booking and t.s='0' and nama_principle like '%" & cari.Text & "%'")
            ElseIf aktif.Checked = False And nomerdo.Checked = True Then
                data = DtTable("SELECT b.id_booking `Kode Booking`, id_transaksi `Kode Transaksi`,nama_principle `Nama Principle`,no_DO `Nomer DO` FROM trans_do t,booking_truk b, mprinciple mp where b.id_principle=mp.id_principle and t.id_booking=b.id_booking and t.s='0' and no_DO like '%" & cari.Text & "%'")
            ElseIf aktif.Checked = True And id.Checked = True Then
                data = DtTable("SELECT b.id_booking `Kode Booking`, id_transaksi `Kode Transaksi`,nama_principle `Nama Principle`,no_DO `Nomer DO` FROM trans_do t,booking_truk b, mprinciple mp where b.id_principle=mp.id_principle and t.id_booking=b.id_booking and t.s='1' and id_principle like '%" & cari.Text & "%'")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub id_CheckedChanged(sender As Object, e As EventArgs) Handles id.CheckedChanged
        cari_EditValueChanged(sender, e)
    End Sub

    Private Sub nomerdo_CheckedChanged(sender As Object, e As EventArgs) Handles nomerdo.CheckedChanged
        cari_EditValueChanged(sender, e)
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub
End Class