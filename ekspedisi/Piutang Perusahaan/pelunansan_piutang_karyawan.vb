Public Class pelunansan_piutang_karyawan 
    Dim debet As String = Scalar("select id_akun from control_account where keterangan='Def. Akun Kas'")
    Dim kredit As String = Scalar("select id_akun from control_account where keterangan='Def. Akun Piutang'")
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            Dim syaratnol As Boolean = False
            Dim syaratlunas As Boolean = False
            If namakaryawan.Text = "Belum terisi" Or idkaryawan.Text = "" Then
                MessageBox.Show("Karyawan belum dipilih")

            ElseIf datapiutang.RowCount > 0 Then
                For i = 0 To datapiutang.RowCount - 1
                    If datapiutang.GetRowCellValue(i, "Sisa") = 0 Then
                        syaratlunas = True
                    ElseIf IsDBNull(datapiutang.GetRowCellValue(i, "Bayar")) = True Then
                        syaratnol = True
                    End If
                    If syaratlunas = True And syaratnol = False Then
                        InsertInto("insert into dpiutang_karyawan values ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & datapiutang.GetRowCellValue(i, "Bayar") & "')")
                        InsertInto("update piutang_karyawan set `status`='0' where id_piutangkaryawan='" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "'")
                        InsertInto("INSERT INTO `jurnal`(`no_jurnal`, `tgl`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "'," & System.DateTime.Today.ToString("yyyMMdd") & ")")
                        Dim opo As Double = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") * -1
                        InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & debet & "','Buka Piutang Karyawan'," & datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") & ")")
                        InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & kredit & "','Buka Piutang Karyawan'," & opo & ")")

                        MessageBox.Show("Piutang berhasil di update")
                    ElseIf syaratlunas = False And syaratnol = False Then
                        InsertInto("insert into dpiutang_karyawan values ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & datapiutang.GetRowCellValue(i, "Bayar") & "')")
                        MessageBox.Show("Piutang berhasil di update")
                        InsertInto("insert into dpiutang_karyawan values ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & datapiutang.GetRowCellValue(i, "Bayar") & "')")
                        InsertInto("update piutang_karyawan set `status`='0' where id_piutangkaryawan='" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "'")
                        InsertInto("INSERT INTO `jurnal`(`no_jurnal`, `tgl`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "'," & System.DateTime.Today.ToString("yyyMMdd") & ")")
                        Dim opo As Double = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") * -1
                        InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & debet & "','Buka Piutang Karyawan'," & datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Bayar") & ")")
                        InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & kredit & "','Buka Piutang Karyawan'," & opo & ")")

                    End If
                Next i

                Dim tabel As New DataTable
                tabel = DtTablebayar("SELECT p.id_piutangkaryawan as `Kode Piutang`,tgl `Tanggal Piutang`,jatuh_tempo `Tanggal Jatuh Tempo`,nominal `Nominal`,keterangan `Keterangan`,if(sum(jumlah_dibayar) is null,0,sum(jumlah_dibayar)) as `Terbayar`,if(nominal-sum(jumlah_dibayar) is null or nominal-sum(jumlah_dibayar)=nominal,0,nominal-sum(jumlah_dibayar)) as `Sisa` FROM dpiutang_karyawan d, piutang_karyawan p where d.id_piutangkaryawan=p.id_piutangkaryawan and status='1' and p.id_karyawan='" & namakaryawan.Text & "' group by p.id_piutangkaryawan;")
                daftarutang.DataSource = tabel
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
End Class