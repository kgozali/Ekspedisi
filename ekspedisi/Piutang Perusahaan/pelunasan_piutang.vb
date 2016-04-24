Public Class pelunasan_piutang

    Private Sub principle_ButtonPressed(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles principle.ButtonPressed
        daftar_principle_pelunasan.ShowDialog()
    End Sub

    Private Sub pelunasan_piutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim data As New DataTable
            nomerpelunasan.Text = autogenerate("PPP", "select max(id_pelunasan) from pelunasan_piutang")
            data = DtTable("select nama_akun,kode_akun from makun where tipe_akun='Kas&Bank'")
            RepositoryItemLookUpEdit1.DataSource = data
            RepositoryItemLookUpEdit1.DisplayMember = "nama_akun"
            RepositoryItemLookUpEdit1.ValueMember = "kode_akun"
            pembayaran.OptionsView.ShowFooter = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Try
            Dim nominalbayar As Double
            nominalbayar = pembayaran.Columns(4).SummaryItem.SummaryValue.ToString
            Dim piutang As Double = labeltotalbayar.Text
            Dim centang As Boolean = False
            Dim isisemua As Boolean = False
            For i = 0 To datapiutang.RowCount - 1
                If datapiutang.GetRowCellValue(i, "Bayar") = True Then
                    centang = True
                End If
            Next i
            For i = 0 To pembayaran.RowCount - 1
                If pembayaran.GetRowCellValue(i, "namabank").ToString = "" Then
                    isisemua = True
                ElseIf pembayaran.GetRowCellValue(i, "nomerbg").ToString = "" Then
                    isisemua = True
                ElseIf pembayaran.GetRowCellValue(i, "nominal").ToString = "" Then
                    isisemua = True
                ElseIf pembayaran.GetRowCellValue(i, "tanggalcair").ToString = "" Then
                    isisemua = True
                ElseIf pembayaran.GetRowCellValue(i, "namaakun").ToString = "" Then
                    isisemua = True
                End If

            Next i

            If isisemua = True Then
                MessageBox.Show("Data pembayaran harus di isi semua")
            Else
                If idprinciple.Text = "idprinciple" Then
                    MessageBox.Show("Principle belum dipilih", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf centang = False Then
                    MessageBox.Show("Transaksi DO belum terpilih", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf pembayaran.RowCount = 0 Or pembayaran.Columns(4).SummaryItem.SummaryValue.ToString = "" Then
                    MessageBox.Show("Pembayaran belum diisi", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf nominalbayar < piutang Or nominalbayar > piutang Then
                    MessageBox.Show("Detail pembayaran tidak sesuai", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'ganti di sini untuk bayar bisa nyicil
                    Dim tampung As String = autogenerate("PPP", "select max(id_pelunasan) from pelunasan_piutang")
                    For i = 0 To datapiutang.RowCount - 1
                        If datapiutang.GetRowCellValue(i, "Bayar") = True Then

                            InsertInto("INSERT INTO `pelunasan_piutang`(`id_pelunasan`, `id_principle`, `tgl_pelunasan`, `keterangan`) VALUES ('" & tampung & "','" & idprinciple.Text & "'," & tanggalpelunasan.Value.ToString("yyyyMMdd") & ",'" & catatan.Text & "')")
                            InsertInto("INSERT INTO `dpelunasan_piutang`(`id_pelunasan`, `tgl_faktur`, `id_faktur`, `nominal_faktur`,`pembayaran`, `potongan`) VALUES ('" & tampung & "'," & tanggalpelunasan.Value.ToString("yyyyMMdd") & ",'" & datapiutang.GetRowCellValue(i, "Nomer DO") & "'," & datapiutang.GetRowCellValue(i, "Nominal") & "," & datapiutang.GetRowCellValue(i, "Nominal") & ",0)")
                            InsertInto("update trans_do set total_bayar=" & datapiutang.GetRowCellValue(i, "Nominal") & ",s='0' where id_transaksi='" & datapiutang.GetRowCellValue(i, "Kode Transaksi") & "'")
                            MessageBox.Show("Transksi Berhasil")
                        End If
                    Next i

                    For i = 0 To pembayaran.RowCount - 1
                        InsertInto("INSERT INTO `dmetode_pelunasan`(`id_pelunasan`, `id_akun`, `nominal`, `no_BG`, `tgl_cair`, `keterangan`, `urutan`, `status_BG`, `id_rekening`) VALUES ('" & tampung & "','" & pembayaran.GetRowCellValue(i, "Nama Akun") & "'," & pembayaran.GetRowCellValue(i, "Nominal") & ",'" & pembayaran.GetRowCellValue(i, "Nomor BG") & "'," & pembayaran.GetRowCellValue(i, "Tanggal Cair") & ",'" & catatan.Text & "',,[value-8],[value-9])")
                    Next i

                End If
            End If

           

            'InsertInto("INSERT INTO `pelunasan_piutang`(`id_pelunasan`, `id_principle`, `tgl_pelunasan`, `keterangan`) VALUES ('" & autogenerate("PPP", "select max(id_pelunasan) from pelunasan_piutang") & "','" & idprinciple.Text & "'," & tanggalpelunasan.Value.ToString("yyyyMMdd") & ",'" & catatan.Text & "')")
            'InsertInto("INSERT INTO `dpelunasan_piutang`(`id_pelunasan`, `tgl_faktur`, `id_faktur`, `nominal_faktur`,`pembayaran`, `potongan`) VALUES ('" & autogenerate("PPP", "select max(id_pelunasan) from pelunasan_piutang") & "'," & tanggalpelunasan.Value.ToString("yyyyMMdd") & ",'" &  & "',nominal,pembayaran,0)")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

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
                    labeltotalbayar.Text = angka.ToString
                    totaldibayar.Text = angka.ToString

                Else
                    With datapiutang
                        .SetRowCellValue(.FocusedRowHandle, .FocusedColumn, keamanan)
                    End With
                End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Dim keamanan As String
    Private Sub datapiutang_ShownEditor(sender As Object, e As EventArgs) Handles datapiutang.ShownEditor
        Try
            If datapiutang.FocusedColumn.AbsoluteIndex <> 6 Then
                keamanan = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, datapiutang.FocusedColumn)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class