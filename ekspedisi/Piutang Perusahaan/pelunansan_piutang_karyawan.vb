Public Class pelunansan_piutang_karyawan 
    Dim debet As String = Scalar("select id_akun from control_account where keterangan='Def. Akun Kas'")
    Dim kredit As String = Scalar("select id_akun from control_account where keterangan='Def. Akun Piutang'")
    Public keamanankaryawan As String = ""
    Public supirataukarywan As String
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try

            If namakaryawan.Text = "" Or idkaryawan.Text = "" Then
                MessageBox.Show("Karyawan belum dipilih", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ElseIf datapiutang.RowCount > 0 Then
                '    For i = 0 To datapiutang.RowCount - 1
                '        Dim syaratnol As Boolean = False
                '        Dim syaratlunas As Boolean = False
                '        Dim syaratcicil As Boolean = False
                '        Dim data As New DataTable
                '        data = DtTable("SELECT id_piutangkaryawan FROM `dpiutang_karyawan` WHERE id_piutangkaryawan='" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "'")

                '        If datapiutang.GetRowCellValue(i, "Sisa") = datapiutang.GetRowCellValue(i, "Bayar") Then
                '            syaratlunas = True
                '        End If
                '        If datapiutang.GetRowCellValue(i, "Check List Bayar") = False Then
                '            syaratnol = True
                '        End If
                '        If data.Rows.Count > 0 Then
                '            syaratcicil = True
                '        End If

                '        If syaratlunas = True And syaratnol = False And syaratcicil = False Then
                '            InsertInto("insert into dpiutang_karyawan values ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & datapiutang.GetRowCellValue(i, "Bayar") & "'," & tanggalpelunasan.Value.ToString("yyyyMMdd") & ")")
                '            InsertInto("update piutang_karyawan set `status`='0' where id_piutangkaryawan='" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "'")
                '            InsertInto("INSERT INTO `jurnal`(`no_jurnal`, `tgl`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "'," & System.DateTime.Today.ToString("yyyMMdd") & ")")
                '            Dim opo As Double = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") * -1
                '            InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & debet & "','Buka Piutang Karyawan'," & datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") & ")")
                '            InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & kredit & "','Buka Piutang Karyawan'," & opo & ")")
                '        ElseIf syaratlunas = False And syaratnol = False And syaratcicil = False Then
                '            InsertInto("insert into dpiutang_karyawan values ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & datapiutang.GetRowCellValue(i, "Bayar") & "'," & tanggalpelunasan.Value.ToString("yyyyMMdd") & ")")
                '            InsertInto("INSERT INTO `jurnal`(`no_jurnal`, `tgl`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "'," & System.DateTime.Today.ToString("yyyMMdd") & ")")
                '            Dim opo As Double = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") * -1
                '            InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & debet & "','Buka Piutang Karyawan'," & datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") & ")")
                '            InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & kredit & "','Buka Piutang Karyawan'," & opo & ")")
                '        ElseIf syaratcicil = True And syaratnol = False And syaratlunas = False Then
                '            InsertInto("insert into dpiutang_karyawan values ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & datapiutang.GetRowCellValue(i, "Bayar") & "'," & tanggalpelunasan.Value.ToString("yyyyMMdd") & ")")
                '            Dim opo As Double = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") * -1
                '            InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & debet & "','Buka Piutang Karyawan'," & datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") & ")")
                '            InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & kredit & "','Buka Piutang Karyawan'," & opo & ")")
                '        ElseIf syaratcicil = False And syaratnol = False And syaratlunas = False Then
                '            InsertInto("insert into dpiutang_karyawan values ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & datapiutang.GetRowCellValue(i, "Bayar") & "'," & tanggalpelunasan.Value.ToString("yyyyMMdd") & ")")
                '            InsertInto("INSERT INTO `jurnal`(`no_jurnal`, `tgl`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "'," & System.DateTime.Today.ToString("yyyMMdd") & ")")
                '            Dim opo As Double = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") * -1
                '            InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & debet & "','Buka Piutang Karyawan'," & datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") & ")")
                '            InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & kredit & "','Buka Piutang Karyawan'," & opo & ")")
                '        ElseIf syaratlunas = True And syaratnol = False And syaratcicil = True Then
                '            InsertInto("insert into dpiutang_karyawan values ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & datapiutang.GetRowCellValue(i, "Bayar") & "'," & tanggalpelunasan.Value.ToString("yyyyMMdd") & ")")
                '            InsertInto("update piutang_karyawan set `status`='0' where id_piutangkaryawan='" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "'")
                '            Dim opo As Double = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") * -1
                '            InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & debet & "','Buka Piutang Karyawan'," & datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") & ")")
                '            InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & kredit & "','Buka Piutang Karyawan'," & opo & ")")
                '        End If
                '    Next i
                '    Dim tabel As New DataTable
                '    tabel = DtTablebayar("SELECT p.id_piutangkaryawan as `Kode Piutang`,tgl `Tanggal Piutang`,jatuh_tempo `Tanggal Jatuh Tempo`,nominal `Nominal`,keterangan `Keterangan`,if(sum(jumlah_dibayar) is null,0,sum(jumlah_dibayar)) as `Terbayar`,if(nominal-sum(jumlah_dibayar) is null or nominal-sum(jumlah_dibayar)=nominal,nominal,nominal-sum(jumlah_dibayar)) as `Sisa` FROM piutang_karyawan p left join dpiutang_karyawan d on d.id_piutangkaryawan=p.id_piutangkaryawan where p.id_karyawan='" & namakaryawan.Text & "' and status='1' group by p.id_piutangkaryawan;")
                '    daftarutang.DataSource = tabel
                '    Dim hitung As Integer = 0
                '    For i = 0 To tabel.Rows.Count - 1
                '        With datapiutang
                '            .SetRowCellValue(i, "Check List Bayar", False)
                '        End With
                '        With datapiutang
                '            .SetRowCellValue(i, "Bayar", 0)
                '        End With
                '        hitung = hitung + tabel.Rows(i).Item("Sisa")
                '    Next i
                '    MessageBox.Show("Piutang berhasil di update")
                'Else
                '    MessageBox.Show("Karyawan tidak memiliki piutang")
                Dim centang As Boolean = False

                For i = 0 To datapiutang.RowCount - 1
                    If datapiutang.GetRowCellValue(i, "Check List Bayar") = True Then
                        centang = True
                    End If
                Next i
                If centang = True Then
                    id = autogenerate("PPK", "SELECT max(id_peluanasan_karyawan) FROM `pelunasapiutang_karyawan`")
                    InsertInto("INSERT INTO `pelunasapiutang_karyawan`(`id_peluanasan_karyawan`,`tanggal_pelunasan`) VALUES ('" & id & "'," & tanggalpelunasan.Value.ToString("yyyyMMdd") & ")")

                    For i = 0 To datapiutang.RowCount - 1
                        If datapiutang.GetRowCellValue(i, "Check List Bayar") = True Then
                            InsertInto("INSERT INTO `dpiutang_karyawan`(`id_piutangkaryawan`, `jumlah_dibayar`, `id_peluanasan_karyawan`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "'," & datapiutang.GetRowCellValue(i, "Bayar") & ",'" & id & "')")
                            If datapiutang.GetRowCellValue(i, "Sisa") = datapiutang.GetRowCellValue(i, "Bayar") Then
                                InsertInto("Update piutang_karyawan set `status`='0' where id_piutangkaryawan='" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "'")
                            End If

                        End If
                    Next i
                    Dim masukjurnal As String = Scalar("select no_jurnal from jurnal where no_jurnal='" & id & "'")
                    If IsNothing(masukjurnal) = True Then
                        InsertInto("INSERT INTO `jurnal`(`no_jurnal`, `tgl`) VALUES ('" & id & "','" & tanggalpelunasan.Value.ToString("yyyyMMdd") & "')")
                    End If
                    Dim opo As Double = CDbl(totalbayar.Text) * -1
                    InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & id & "','" & debet & "','Pelunasan Piutang Pribadi Karywawan'," & CDbl(totalbayar.Text) & ")")
                    InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & id & "','" & kredit & "','Pelunasan Piutang Pribadi Karyawan'," & opo & ")")
                    Dim tabel As New DataTable
                    tabel = DtTablebayar("SELECT p.id_piutangkaryawan as `Kode Piutang`,tgl `Tanggal Piutang`,jatuh_tempo `Tanggal Jatuh Tempo`,nominal `Nominal`,keterangan `Keterangan`,if(sum(jumlah_dibayar) is null,0,sum(jumlah_dibayar)) as `Terbayar`,if(nominal-sum(jumlah_dibayar) is null or nominal-sum(jumlah_dibayar)=nominal,nominal,nominal-sum(jumlah_dibayar)) as `Sisa` FROM piutang_karyawan p left join dpiutang_karyawan d on d.id_piutangkaryawan=p.id_piutangkaryawan where p.id_karyawan='" & namakaryawan.Text & "' and status='1' group by p.id_piutangkaryawan;")
                    daftarutang.DataSource = tabel
                    Dim hitung As Double = 0
                    Dim itungan As Double = 0
                    For i = 0 To tabel.Rows.Count - 1
                        With datapiutang
                            .SetRowCellValue(i, "Check List Bayar", False)
                            .SetRowCellValue(i, "Bayar", 0)
                        End With
                        hitung = hitung + tabel.Rows(i).Item("Sisa")
                    Next i
                    MessageBox.Show("Transaksi pelunasan telah berhasil", "Informasi Transaksi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    totalbayar.Text = "0"
                    totalhutang.Text = hitung
                    If supirataukarywan = "karyawan" Then
                        viewkwitansipinjaman.penerima = id
                        viewkwitansipinjaman.ShowDialog()
                    Else
                        view_kwitansi_supir.terima = id
                        view_kwitansi_supir.ShowDialog()
                    End If
                Else
                    MessageBox.Show("Transaksi pelunasan belum dipilih", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If
            Else
                MessageBox.Show("Karyawan tidak memiliki piutang", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try
    End Sub
    Public id As String
    Private Sub idkaryawan_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles idkaryawan.ButtonClick
        daftar_karyawan_pelunasan.ShowDialog()
    End Sub

    Dim keamanan As String

    Private Sub datapiutang_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles datapiutang.CellValueChanged

        Try
            Dim angka As Double = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Nominal")
            Dim angka2 As Double = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Terbayar")
            If e.Column.FieldName = "Bayar" Then

                'If angka < 0 Then
                '    With datapiutang
                '        .SetRowCellValue(.FocusedRowHandle, "Bayar", datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Sisa"))
                '    End With
                'Else
                '    With datapiutang
                '        .SetRowCellValue(.FocusedRowHandle, "Sisa", angka)
                '    End With
                'End If

                Dim hitung As Double = 0
                For i = 0 To datapiutang.RowCount - 1
                    If IsDBNull(datapiutang.GetRowCellValue(i, "Bayar")) = False Then
                        hitung = hitung + datapiutang.GetRowCellValue(i, "Bayar")
                    End If
                Next i
                totalbayar.Text = hitung.ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub datapiutang_ShownEditor(sender As Object, e As EventArgs) Handles datapiutang.ShownEditor
        Try
            If datapiutang.FocusedColumn.AbsoluteIndex <> 8 And IsDBNull(datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Check List Bayar")) = False Then
                keamanan = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, datapiutang.FocusedColumn)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub


    Private Sub datapiutang_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles datapiutang.CellValueChanging
        Try
            If e.Column.FieldName <> "Bayar" Then
                With datapiutang
                    .SetRowCellValue(.FocusedRowHandle, .FocusedColumn, keamanan)
                End With

            End If
            If e.Column.FieldName = "Check List Bayar" Then
                If e.Value = True Then
                    With datapiutang
                        .SetRowCellValue(.FocusedRowHandle, "Bayar", datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Sisa"))
                    End With
                Else
                    With datapiutang
                        .SetRowCellValue(.FocusedRowHandle, "Bayar", 0)
                    End With
                End If
                    Dim hitung As Double = 0
                    For i = 0 To datapiutang.RowCount - 1
                        If IsDBNull(datapiutang.GetRowCellValue(i, "Bayar")) = False Then
                            hitung = hitung + datapiutang.GetRowCellValue(i, "Bayar")
                        End If
                    Next i
                    totalbayar.Text = hitung.ToString
                End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub pelunansan_piutang_karyawan_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim kosong As New DataTable
        daftarutang.DataSource = kosong
        idkaryawan.Text = ""
        namakaryawan.Text = ""
        jabatan.Text = ""
        kotaasal.Text = ""
        nomortelepon.Text = ""
        totalbayar.Text = ""
        totalhutang.Text = ""
    End Sub

    Private Sub idkaryawan_Click(sender As Object, e As EventArgs) Handles idkaryawan.Click
        daftar_karyawan_pelunasan.ShowDialog()
    End Sub

    Public Sub New()
        Try
            Dim tabel As New DataTable
            tabel = DtTable("SELECT nama_karyawan as `Nama Karyawan` FROM mkaryawan mk where s='1'")
            InitializeComponent()
            Dim collection As New AutoCompleteStringCollection()

            For i = 0 To tabel.Rows.Count - 1
                collection.Add(tabel.Rows(i).Item("Nama Karyawan"))
            Next i

            idkaryawan.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource
            idkaryawan.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            idkaryawan.MaskBox.AutoCompleteCustomSource = collection
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class