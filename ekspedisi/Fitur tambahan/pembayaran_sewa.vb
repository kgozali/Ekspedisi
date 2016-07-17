Public Class pembayaran_sewa 
    Public idprinciple As String
    Public namakeamanan As String
    Dim debet As String
    Dim kredit As String
    Private Sub principle_ButtonPressed(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles principle.ButtonPressed
        add_customer_master_sewa.submit_pelunasan.Visible = True
        add_customer_master_sewa.ShowDialog()
    End Sub

    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Pelunasan Piutang Sewa Mobil"
        Dim aktivitas As String = "Pelunasan piutang sewa mobil dengan kode: " & tampung
        auditlog(user, kompname, form, aktivitas)
    End Sub
    Dim tampung As String
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Try
            Dim nominalbayar As Double
            nominalbayar = pembayaran.Columns(4).SummaryItem.SummaryValue.ToString
            Dim piutang As Double = labeltotalbayar.Text
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
                    MessageBox.Show("Customer belum dipilih", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf centang = False Then
                    MessageBox.Show("Transaksi Sewa belum terpilih", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf pembayaran.RowCount = 0 Or pembayaran.Columns(4).SummaryItem.SummaryValue.ToString = "" Then
                    MessageBox.Show("Pembayaran belum diisi", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf piutang <> nominalbayar Then
                    MessageBox.Show("Detail pembayaran tidak sesuai", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf tunaisalah = True Then
                    MessageBox.Show("Pembayaran tunai tidak memerlukan Bank", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'ganti di sini untuk bayar bisa nyicil
                    tampung = autogenerate("PPS", "select max(id_pelunasan) from pelunasan_sewa")
                    InsertInto("INSERT INTO `pelunasan_sewa`(`id_pelunasan`, `id_customer`, `tgl_pelunasan`, `keterangan`) VALUES ('" & tampung & "','" & idprinciple & "'," & tanggalpelunasan.Value.ToString("yyyyMMdd") & ",'" & catatan.Text & "')")
                    For i = 0 To datapiutang.RowCount - 1
                        If datapiutang.GetRowCellValue(i, "Bayar") = True Then
                            InsertInto("INSERT INTO `dpelunasan_sewa`(`id_pelunasan`, `tgl_faktur`, `id_faktur`, `nominal_faktur`,`pembayaran`, `potongan`) VALUES ('" & tampung & "'," & tanggalpelunasan.Value.ToString("yyyyMMdd") & ",'" & datapiutang.GetRowCellValue(i, "Nomer DO") & "'," & datapiutang.GetRowCellValue(i, "Nominal") & "," & datapiutang.GetRowCellValue(i, "Nominal") & ",0)")
                            InsertInto("update trans_mobil set s='0' where id_tmobil='" & datapiutang.GetRowCellValue(i, "Kode Transaksi") & "'")

                        End If
                    Next i
                    InsertInto("INSERT INTO `jurnal`(`no_jurnal`, `tgl`) VALUES ('" & tampung & "'," & tanggalpelunasan.Value.ToString("yyyyMMdd") & ")")
                    kredit = Scalar("select id_akun from control_account where keterangan='Def. Akun Piutang'")
                    Dim opo As Integer = CDbl(totaldibayar.Text) * -1
                    InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & tampung & "','" & kredit & "','Pelunasan Piutang Principle'," & opo & ")")
                    For i = 0 To pembayaran.RowCount - 1
                        datarow = pelunasan.Tables.Item(1).Rows(i)
                        debet = datarow(4)
                        InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & tampung & "','" & debet & "','Pelunasan Piutang Principle'," & datarow("nominal") & ")")
                        InsertInto("INSERT INTO `dmetode_pelunasan`(`id_pelunasan`, `id_akun`, `nominal`, `no_BG`, `tgl_cair`, `keterangan`, `urutan`, `status_BG`, `id_rekening`) VALUES ('" & tampung & "','" & datarow(4) & "'," & datarow("nominal") & ",'" & datarow("nomerbg") & "',STR_TO_DATE('" & datarow("tanggalcair") & "','%m/%d/%Y'),'" & catatan.Text & "'," & i + 1 & ",'0','" & datarow(0) & "')")
                    Next i
                    'refresh page
                    Dim tabel As New DataTable
                    tabel = DtTablebayarcek("SELECT id_tmobil `Kode Transaksi`,kode_sewa `Kode Sewa`,concat(day(tgl),'-',monthname(tgl),'-',year(tgl)) `Tanggal`,total `Total Transaksi` FROM trans_mobil t,mcustomer_sewa m where m.id_customer_sewa=t.id_customer_sewa and m.id_customer_sewa='" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Customer") & "' and t.s='1'")
                    bayarpiutang.DataSource = tabel
                    Dim angka As Double = 0
                    For i = 0 To datapiutang.RowCount - 1
                        angka = angka + datapiutang.GetRowCellValue(i, "Total Transaksi")
                        With datapiutang
                            .SetRowCellValue(i, "Bayar", False)
                        End With
                    Next i
                    Dim datakosong As New DataTable
                    daftarbayar.DataSource = datakosong
                    totaldibayar.Text = "0"
                    'Me.Close()
                    MessageBox.Show("Pelunasan sukses diinput", "Konfirmasi Pelunasan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    audit()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub datapiutang_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles datapiutang.CellValueChanging
        Try
            If datapiutang.FocusedColumn.AbsoluteIndex = 4 Then
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
                        angka = angka + datapiutang.GetRowCellValue(i, "Total Transaksi")
                    End If
                Next i
                labeltotalbayar.Text = angka.ToString
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
    Dim keamanan As String
    Private Sub datapiutang_ShownEditor(sender As Object, e As EventArgs) Handles datapiutang.ShownEditor
        Try
            If datapiutang.FocusedColumn.AbsoluteIndex <> 4 Then
                keamanan = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, datapiutang.FocusedColumn)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub principle_Click(sender As Object, e As EventArgs) Handles principle.Click
        daftar_principle_pelunasan.ShowDialog()
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

    Private Sub pembayaran_KeyDown(sender As Object, e As KeyEventArgs) Handles pembayaran.KeyDown
        If e.KeyData = Keys.Delete Then
            pembayaran.DeleteRow(pembayaran.FocusedRowHandle)
            pembayaran.RefreshData()
        End If
    End Sub
    Private Sub pembayaran_sewa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim data As New DataTable
            nomerpelunasan.Text = autogenerate("PPS", "select max(id_pelunasan) from pelunasan_sewa")
            data = DtTable("select nama_akun,kode_akun from makun where tipe_akun='Kas&Bank' and detil='1'")
            RepositoryItemLookUpEdit1.DataSource = data
            RepositoryItemLookUpEdit1.DisplayMember = "nama_akun"
            RepositoryItemLookUpEdit1.ValueMember = "kode_akun"
            pembayaran.OptionsView.ShowFooter = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class