Public Class pelunansan_piutang_karyawan 
    Dim debet As String = Scalar("select id_akun from control_account where keterangan='Def. Akun Kas'")
    Dim kredit As String = Scalar("select id_akun from control_account where keterangan='Def. Akun Piutang'")
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
           
            If namakaryawan.Text = "" Or idkaryawan.Text = "" Then
                MessageBox.Show("Karyawan belum dipilih")

            ElseIf datapiutang.RowCount > 0 Then
                For i = 0 To datapiutang.RowCount - 1
                    Dim syaratnol As Boolean = False
                    Dim syaratlunas As Boolean = False
                    Dim syaratcicil As Boolean = False
                    Dim data As New DataTable
                    data = DtTable("SELECT id_piutangkaryawan FROM `dpiutang_karyawan` WHERE id_piutangkaryawan='" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "'")

                    If datapiutang.GetRowCellValue(i, "Sisa") = 0 Then
                        syaratlunas = True
                    End If
                    If datapiutang.GetRowCellValue(i, "Bayar").ToString = "" Then
                        syaratnol = True
                    End If
                    If data.Rows.Count > 0 Then
                        syaratcicil = True
                    End If
                    If syaratlunas = True And syaratnol = False And syaratcicil = False Then
                        InsertInto("insert into dpiutang_karyawan values ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & datapiutang.GetRowCellValue(i, "Bayar") & "')")
                        InsertInto("update piutang_karyawan set `status`='0' where id_piutangkaryawan='" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "'")
                        InsertInto("INSERT INTO `jurnal`(`no_jurnal`, `tgl`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "'," & System.DateTime.Today.ToString("yyyMMdd") & ")")
                        Dim opo As Double = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") * -1
                        InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & debet & "','Buka Piutang Karyawan'," & datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") & ")")
                        InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & kredit & "','Buka Piutang Karyawan'," & opo & ")")
                    ElseIf syaratlunas = False And syaratnol = False And syaratcicil = False Then
                        InsertInto("insert into dpiutang_karyawan values ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & datapiutang.GetRowCellValue(i, "Bayar") & "')")
                        InsertInto("INSERT INTO `jurnal`(`no_jurnal`, `tgl`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "'," & System.DateTime.Today.ToString("yyyMMdd") & ")")
                        Dim opo As Double = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") * -1
                        InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & debet & "','Buka Piutang Karyawan'," & datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") & ")")
                        InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & kredit & "','Buka Piutang Karyawan'," & opo & ")")
                    ElseIf syaratcicil = True And syaratnol = False And syaratlunas = False Then
                        InsertInto("insert into dpiutang_karyawan values ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & datapiutang.GetRowCellValue(i, "Bayar") & "')")
                        Dim opo As Double = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") * -1
                        InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & debet & "','Buka Piutang Karyawan'," & datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") & ")")
                        InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & kredit & "','Buka Piutang Karyawan'," & opo & ")")
                    ElseIf syaratcicil = False And syaratnol = False And syaratlunas = False Then
                        InsertInto("insert into dpiutang_karyawan values ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & datapiutang.GetRowCellValue(i, "Bayar") & "')")
                        InsertInto("INSERT INTO `jurnal`(`no_jurnal`, `tgl`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "'," & System.DateTime.Today.ToString("yyyMMdd") & ")")
                        Dim opo As Double = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") * -1
                        InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & debet & "','Buka Piutang Karyawan'," & datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") & ")")
                        InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & kredit & "','Buka Piutang Karyawan'," & opo & ")")
                    ElseIf syaratlunas = True And syaratnol = False And syaratcicil = True Then
                        InsertInto("insert into dpiutang_karyawan values ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & datapiutang.GetRowCellValue(i, "Bayar") & "')")
                        InsertInto("update piutang_karyawan set `status`='0' where id_piutangkaryawan='" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "'")
                        Dim opo As Double = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") * -1
                        InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & debet & "','Buka Piutang Karyawan'," & datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") & ")")
                        InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & kredit & "','Buka Piutang Karyawan'," & opo & ")")
                    End If
                Next i
                Dim tabel As New DataTable
                tabel = DtTablebayar("SELECT p.id_piutangkaryawan as `Kode Piutang`,tgl `Tanggal Piutang`,jatuh_tempo `Tanggal Jatuh Tempo`,nominal `Nominal`,keterangan `Keterangan`,if(sum(jumlah_dibayar) is null,0,sum(jumlah_dibayar)) as `Terbayar`,if(nominal-sum(jumlah_dibayar) is null or nominal-sum(jumlah_dibayar)=nominal,nominal,nominal-sum(jumlah_dibayar)) as `Sisa` FROM piutang_karyawan p left join dpiutang_karyawan d on d.id_piutangkaryawan=p.id_piutangkaryawan where p.id_karyawan='" & namakaryawan.Text & "' and status='1' group by p.id_piutangkaryawan;")
                daftarutang.DataSource = tabel
                MessageBox.Show("Piutang berhasil di update")
            Else
                MessageBox.Show("Karyawan tidak memiliki piutang")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub idkaryawan_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles idkaryawan.ButtonClick
        daftar_karyawan_pelunasan.ShowDialog()
    End Sub

    Dim keamanan As String

    Private Sub datapiutang_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles datapiutang.CellValueChanged

        Try
            Dim angka As Double = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Nominal")
            Dim angka2 As Double = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Terbayar")
            If e.Column.FieldName = "Bayar" Then
                angka = angka - angka2 - e.Value
                If angka < 0 Then
                    With datapiutang
                        MessageBox.Show("Uang Kembali = " & angka * -1)
                        .SetRowCellValue(.FocusedRowHandle, "Sisa", 0)
                    End With
                Else
                    With datapiutang
                        .SetRowCellValue(.FocusedRowHandle, "Sisa", angka)
                    End With
                End If
                
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub datapiutang_ShownEditor(sender As Object, e As EventArgs) Handles datapiutang.ShownEditor
        If datapiutang.FocusedColumn.AbsoluteIndex <> 7 Then
            keamanan = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, datapiutang.FocusedColumn)
        End If
    End Sub


    Private Sub datapiutang_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles datapiutang.CellValueChanging
        If e.Column.FieldName <> "Bayar" Then
            With datapiutang
                .SetRowCellValue(.FocusedRowHandle, .FocusedColumn, keamanan)
            End With
        End If
    End Sub

    Private Sub pelunansan_piutang_karyawan_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim kosong As New DataTable
        daftarutang.DataSource = kosong
    End Sub

    Private Sub idkaryawan_Click(sender As Object, e As EventArgs) Handles idkaryawan.Click
        daftar_karyawan_pelunasan.ShowDialog()
    End Sub

    Private Sub idkaryawan_TextChanged(sender As Object, e As EventArgs) Handles idkaryawan.TextChanged
        'Try
        '    Dim data As New DataTable
        '    data = DtTable("SELECT id_karyawan as `Kode Karyawan`, nama_karyawan as `Nama Karyawan`, nama_jabatan as `Jabatan`, tel1 as `Nomor Telepon 1`, tel2 as `Nomor Telepon 2`,kota as 'Kota'  FROM mkaryawan mk,mjabatan mj where mj.id_jabatan=mk.id_jabatan and nama_karyawan = '" & idkaryawan.Text & "'")
        '    If data.Rows.Count > 0 Then
        '        idkaryawan.Text = data.Rows(0).Item("Kode Karyawan").ToString
        '        namakaryawan.Text = data.Rows(0).Item("Nama Karyawan").ToString
        '        jabatan.Text = data.Rows(0).Item("Jabatan").ToString
        '        kotaasal.Text = data.Rows(0).Item("Kota").ToString
        '        nomortelepon.Text = data.Rows(0).Item("Nomor Telepon 1").ToString
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
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
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class