Public Class edit_principle_pelunasan
    Public idprinciple As String
    Private Sub principle_ButtonPressed(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        daftar_edit_piutang_principle.ShowDialog()
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub
    Dim tabel As New DataTable
    Private Sub edit_principle_pelunasan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim data As New DataTable
            Data = DtTable("select nama_akun,kode_akun from makun where tipe_akun='Kas&Bank' and detil='1'")
            RepositoryItemLookUpEdit1.DataSource = Data
            RepositoryItemLookUpEdit1.DisplayMember = "nama_akun"
            RepositoryItemLookUpEdit1.ValueMember = "kode_akun"
            Dim datapembayaran As DataTable = DtTablebayarcek("Select t.id_transaksi `Kode Transaksi`,no_do as `Nomer DO`,concat(day(tgl_terkirim),'-',monthname(tgl_terkirim),'-',year(tgl_terkirim)) `Tanggal Pengiriman`,jam `Jam Pengiriman`,concat(kota_asal,' - ',kota_tujuan) `Rute`, sum(berat_per_kg)*price_per_unit `Nominal` from booking_truk,mprinciple,mrute,trans_do t,dtrans_do dt,pelunasan_piutang pp,dpelunasan_piutang dp where pp.id_pelunasan=dp.id_pelunasan and dp.id_faktur=no_do and dt.id_transaksi=t.id_transaksi and t.id_booking=booking_truk.id_booking and booking_truk.id_principle=mprinciple.id_principle and booking_truk.id_rute=mrute.id_rute and pp.id_pelunasan='" & nomerpelunasan.Text & "' and t.s=0 and mprinciple.id_principle='" & idprinciple & "' group by t.id_transaksi")
            'Dim mreader As DataTableReader = datapembayaran.CreateDataReader
            'Dim tampung As String = master_pelunasan_principle.viewdatapelunasan.GetRowCellValue(master_peluanasan_karyawan.viewdatapelunasan.FocusedRowHandle, 0)
            Dim tabelpembayaran As DataTable = DtTable("SELECT id_rekening `namabank`, no_BG `nomerbg`,nominal `nominal`,tgl_cair `tanggalcair`,id_akun `akun` FROM `dmetode_pelunasan`d,makun ma WHERE ma.kode_akun=d.id_akun and id_pelunasan='" & nomerpelunasan.Text & "'")
            Dim mreader As DataTableReader
            'tabel = DtTablebayarcek("Select t.id_transaksi `Kode Transaksi`,no_do as `Nomer DO`,concat(day(tgl_terkirim),'-',monthname(tgl_terkirim),'-',year(tgl_terkirim)) `Tanggal Pengiriman`,jam `Jam Pengiriman`,concat(kota_asal,' - ',kota_tujuan) `Rute`, sum(berat_per_kg)*price_per_unit `Nominal` from booking_truk,mprinciple,mrute,trans_do t,dtrans_do dt where dt.id_transaksi=t.id_transaksi and t.id_booking=booking_truk.id_booking and booking_truk.id_principle=mprinciple.id_principle and booking_truk.id_rute=mrute.id_rute and no_do='" & master_pelunasan_principle.viewdatapelunasan.GetRowCellValue(master_pelunasan_principle.viewdatapelunasan.FocusedRowHandle, "Nomor DO") & "' and t.s=0 and mprinciple.id_principle='" & idprinciple & "' group by t.id_transaksi")
            bayarpiutang.DataSource = tabel
            Dim angka As Double = 0

            mreader = tabelpembayaran.CreateDataReader
            pelunasan.Tables(1).Load(mreader)

            bayarpiutang.DataSource = datapembayaran
            daftarbayar.DataSource = pelunasan
            daftarbayar.DataMember = "bayaran"
            For i = 0 To datapiutang.RowCount - 1
                angka = angka + datapiutang.GetRowCellValue(i, "Nominal")
                With datapiutang
                    .SetRowCellValue(i, "Bayar", True)
                End With
            Next i
            totaldibayar.Text = angka.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Dim keamanan As String
    Private Sub datapiutang_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles datapiutang.CellValueChanging
        Try
            If datapiutang.FocusedColumn.AbsoluteIndex = 6 Then
                Dim angka As Double = 0
                If datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") = False Then
                    With datapiutang
                        .SetRowCellValue(datapiutang.FocusedRowHandle, .FocusedColumn, True)
                    End With
                Else
                    With datapiutang
                        .SetRowCellValue(datapiutang.FocusedRowHandle, .FocusedColumn, False)
                    End With
                End If

                For i = 0 To datapiutang.RowCount - 1
                    If datapiutang.GetRowCellValue(i, "Bayar") = True Then
                        angka = angka + datapiutang.GetRowCellValue(i, "Nominal")
                    End If
                Next i
                totaldibayar.Text = angka.ToString
            Else
                With datapiutang
                    .SetRowCellValue(.FocusedRowHandle, .FocusedColumn, keamanan)
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub datapiutang_ShownEditor(sender As Object, e As EventArgs) Handles datapiutang.ShownEditor
        Try
            If datapiutang.FocusedColumn.AbsoluteIndex <> 6 Then
                keamanan = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, datapiutang.FocusedColumn)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pelunasan_piutang_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            principle.Text = ""
            alamat.Text = ""
            nomerpelunasan.Text = ""
            Dim kosong As New DataTable
            bayarpiutang.DataSource = kosong
            pelunasan.Tables("Bayaran").Rows.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Edit Pelunasan Priciple"
        Dim aktivitas As String = "Edit Pelunasan Principle: " & nomerpelunasan.Text
        auditlog(user, kompname, form, aktivitas)
    End Sub
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Try
            Dim nominalbayar As Double
            nominalbayar = pembayaran.Columns(4).SummaryItem.SummaryValue.ToString
            Dim piutang As Double = totaldibayar.Text
            Dim centang As Boolean = False
            Dim isisemua As Boolean = False
            Dim datarow As DataRow
            Dim tunaisalah As Boolean = False
            For i = 0 To datapiutang.RowCount - 1
                If datapiutang.GetRowCellValue(i, "Bayar") = True Then
                    centang = True
                End If
            Next i
            For i = 0 To pembayaran.RowCount - 1
                If pembayaran.GetRowCellValue(i, "namabank").ToString = "" And pelunasan.Tables.Item(1).Rows(i).Item(1) <> "Tunai" Then
                    isisemua = True
                ElseIf pembayaran.GetRowCellValue(i, "nomerbg").ToString = "" Then
                    isisemua = True
                ElseIf pembayaran.GetRowCellValue(i, "nominal").ToString = "" Then
                    isisemua = True
                ElseIf pembayaran.GetRowCellValue(i, "tanggalcair").ToString = "" Then
                    isisemua = True
                ElseIf IsDBNull(pembayaran.GetRowCellValue(i, "namaakun")) = True Then
                    isisemua = True
                ElseIf pembayaran.GetRowCellValue(i, "namabank").ToString <> "" And pelunasan.Tables.Item(1).Rows(i).Item(1) = "Tunai" Then
                    tunaisalah = True
                End If

            Next i

            If isisemua = True Then
                MessageBox.Show("Data pembayaran harus di isi semua", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If idprinciple = "" Then
                    MessageBox.Show("Principle belum dipilih", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf centang = False Then
                    Dim result As Integer = MessageBox.Show("Apakah anda yakin akan menghapus data pelunasan " & nomerpelunasan.Text & "?", "Konfirmasi penghapusan pelunasan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If result = DialogResult.Yes Then
                        For i = 0 To datapiutang.RowCount - 1
                            InsertInto("DELETE FROM `dpelunasan_piutang` WHERE id_pelunasan='" & nomerpelunasan.Text & "' and id_faktur='" & datapiutang.GetRowCellValue(i, "Nomer DO") & "'")
                            InsertInto("DELETE FROM `pelunasan_piutang` WHERE id_pelunasan='" & nomerpelunasan.Text & "'")
                            InsertInto("update trans_do set total_bayar=0,s='1' where id_transaksi='" & datapiutang.GetRowCellValue(i, "Kode Transaksi") & "'")
                            InsertInto("DELETE FROM `djurnal` WHERE no_jurnal='" & nomerpelunasan.Text & "'")
                            InsertInto("DELETE FROM `jurnal` WHERE no_jurnal='" & nomerpelunasan.Text & "'")
                            InsertInto("DELETE FROM `dmetode_pelunasan` WHERE id_pelunasan='" & nomerpelunasan.Text & "'")
                        Next i
                    End If
                ElseIf pembayaran.RowCount = 0 Or pembayaran.Columns(4).SummaryItem.SummaryValue.ToString = "" Then
                    MessageBox.Show("Pembayaran belum diisi", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf piutang <> nominalbayar Then
                    MessageBox.Show("Detail pembayaran tidak sesuai", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf tunaisalah = True Then
                    MessageBox.Show("Pembayaran tunai tidak memerlukan Bank", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'ganti di sini untuk bayar bisa nyicil
                    Dim tampung As String = nomerpelunasan.Text
                    For i = 0 To datapiutang.RowCount - 1
                        If datapiutang.GetRowCellValue(i, "Bayar") = True Then
                            InsertInto("UPDATE `pelunasan_piutang` SET `tgl_pelunasan`=" & tanggalpelunasan.Value.ToString("yyyyMMdd") & ",`keterangan`='" & catatan.Text & "' WHERE id_pelunasan='" & nomerpelunasan.Text & "'")
                        ElseIf datapiutang.GetRowCellValue(i, "Bayar") = False Then
                            InsertInto("DELETE FROM `dpelunasan_piutang` WHERE where id_pelunasan='" & nomerpelunasan.Text & "' and id_faktur='" & datapiutang.GetRowCellValue(i, "Nomer DO") & "'")
                            InsertInto("update trans_do set total_bayar=0,s='1' where id_transaksi='" & datapiutang.GetRowCellValue(i, "Kode Transaksi") & "'")
                        End If
                    Next i
                    InsertInto("DELETE FROM `djurnal` WHERE no_jurnal='" & nomerpelunasan.Text & "'")
                    InsertInto("DELETE FROM `dmetode_pelunasan` WHERE id_pelunasan='" & nomerpelunasan.Text & "'")
                    kredit = Scalar("select id_akun from control_account where keterangan='Def. Akun Piutang'")
                    Dim opo As Integer = CDbl(totaldibayar.Text) * -1
                    InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & tampung & "','" & kredit & "','Pelunasan Piutang Principle'," & opo & ")")
                    For i = 0 To pembayaran.RowCount - 1
                        datarow = pelunasan.Tables.Item(1).Rows(i)
                        debet = datarow(4)
                        InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & tampung & "','" & debet & "','Pelunasan Piutang Principle'," & datarow("nominal") & ")")
                        InsertInto("INSERT INTO `dmetode_pelunasan`(`id_pelunasan`, `id_akun`, `nominal`, `no_BG`, `tgl_cair`, `keterangan`, `urutan`, `status_BG`, `id_rekening`) VALUES ('" & tampung & "','" & datarow(4) & "'," & datarow("nominal") & ",'" & datarow("nomerbg") & "',STR_TO_DATE('" & datarow("tanggalcair") & "','%d/%m/%Y'),'" & catatan.Text & "'," & i + 1 & ",'0','" & datarow(0) & "')")
                    Next i
                    'refresh page
                    Dim tabel As New DataTable
                    tabel = DtTablebayarcek("Select t.id_transaksi `Kode Transaksi`,no_do as `Nomer DO`,concat(day(tgl_terkirim),'-',monthname(tgl_terkirim),'-',year(tgl_terkirim)) `Tanggal Pengiriman`,jam `Jam Pengiriman`,concat(kota_asal,' - ',kota_tujuan) `Rute`, sum(berat_per_kg)*price_per_unit `Nominal` from booking_truk,mprinciple,mrute,trans_do t,dtrans_do dt where dt.id_transaksi=t.id_transaksi and t.id_booking=booking_truk.id_booking and booking_truk.id_principle=mprinciple.id_principle and booking_truk.id_rute=mrute.id_rute and t.s=1 and mprinciple.id_principle='" & idprinciple & "' group by t.id_transaksi")
                    bayarpiutang.DataSource = tabel
                    Dim angka As Double = 0
                    For i = 0 To datapiutang.RowCount - 1
                        angka = angka + datapiutang.GetRowCellValue(i, "Nominal")
                        With datapiutang
                            .SetRowCellValue(i, "Bayar", True)
                        End With
                    Next i
                    totaldibayar.Text = "0"
                    Me.Close()
                    MessageBox.Show("Pelunasan sukses diedit", "Konfirmasi Pelunasan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Dim debet As String
    Dim kredit As String
End Class