Public Class edit_pelunasan_karyawan 
    Dim debet As String = Scalar("select id_akun from control_account where keterangan='Def. Akun Kas'")
    Dim kredit As String = Scalar("select id_akun from control_account where keterangan='Def. Akun Piutang'")
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Dim keamanan As String
    Private Sub datapiutang_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles datapiutang.CellValueChanging
        Try
            If e.Column.FieldName <> "Jumlah Bayar" Then
                With datapiutang
                    .SetRowCellValue(.FocusedRowHandle, .FocusedColumn, keamanan)
                End With
            End If
            If e.Column.FieldName = "Jumlah Bayar" And datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Check List Edit") = False Then
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
            'If datapiutang.FocusedColumn.AbsoluteIndex <> 3 Then
            keamanan = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, datapiutang.FocusedColumn)
            'ElseIf datapiutang.FocusedColumn.AbsoluteIndex <> 4 Then
            '    keamanan = datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, datapiutang.FocusedColumn)
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub edit_pelunasan_karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If datakeamanan.Columns.Count = 0 Then
                datakeamanan.Columns.Add(New DataColumn("kode", GetType(String)))
                datakeamanan.Columns.Add(New DataColumn("bayar", GetType(String)))
            End If
            Dim hitung As Double = 0
            For i = 0 To datapiutang.RowCount - 1
                With datapiutang
                    .SetRowCellValue(i, "Check List Edit", False)
                End With
                datakeamanan.Rows.Add(datapiutang.GetRowCellValue(i, "Kode Pelunasan"), datapiutang.GetRowCellValue(i, "Jumlah Bayar"))
                hitung = hitung + datapiutang.GetRowCellValue(i, "Jumlah Bayar")
            Next i
            totalbayar.Text = hitung
            cekload = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Dim datakeamanan As New DataTable

    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Edit Buka Piutang Karyawan"
        Dim aktivitas As String = "Edit Buka Piutang: " & id.Text
        auditlog(user, kompname, form, aktivitas)
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            Dim centang As Boolean = False
            For i = 0 To datapiutang.RowCount - 1
                If datapiutang.GetRowCellValue(i, "Check List Edit") = True Then
                    centang = True
                End If
            Next i

            If CDbl(totalbayar.Text) > CDbl(totalhutang.Text) Then
                MessageBox.Show("Total bayar tidak sesuai dengan total hutang", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf centang = False Then
                MessageBox.Show("Tidak ada data pelunasan yang terpilih", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf datapiutang.RowCount = 0 Then
                MessageBox.Show("Data pelunasan kosong", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If CDbl(totalbayar.Text) = CDbl(totalhutang.Text) Then
                    InsertInto("UPDATE `piutang_karyawan` SET `status`='0' WHERE id_piutangkaryawan='" & datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Kode Piutang") & "'")
                Else
                    InsertInto("UPDATE `piutang_karyawan` SET `status`='1' WHERE id_piutangkaryawan='" & datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Kode Piutang") & "'")
                End If
                For i = 0 To datapiutang.RowCount - 1
                    If datapiutang.GetRowCellValue(i, "Check List Edit") = True Then
                        InsertInto("delete from dpiutang_karyawan where id_piutangkaryawan='" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "' and id_peluanasan_karyawan='" & datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Kode Pelunasan") & "'")
                        InsertInto("INSERT INTO `dpiutang_karyawan`(`id_piutangkaryawan`, `jumlah_dibayar`, `id_peluanasan_karyawan`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Piutang") & "','" & datapiutang.GetRowCellValue(i, "Jumlah Bayar") & "','" & datapiutang.GetRowCellValue(i, "Kode Pelunasan") & "')")
                        InsertInto("update jurnal set tgl=STR_TO_DATE('" & datapiutang.GetRowCellValue(i, "Tanggal Pelunasan") & "','%d/%m/%y') where no_jurnal='" & datapiutang.GetRowCellValue(i, "Kode Pelunasan") & "'")
                        Dim opo As Double = CDbl(totalbayar.Text) * -1
                        InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Pelunasan") & "','" & debet & "','Pelunasan Piutang Pribadi Karywawan'," & CDbl(totalbayar.Text) & ")")
                        InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & datapiutang.GetRowCellValue(i, "Kode Pelunasan") & "','" & kredit & "','Pelunasan Piutang Pribadi Karyawan'," & opo & ")")
                        Dim result As Integer = MessageBox.Show("Cetak kwitansi?", "Konfirmasi Cetak Kwitansi", MessageBoxButtons.YesNo)
                        If result = DialogResult.Yes Then
                            If master_peluanasan_karyawan.karyawan.Checked = True Then
                                viewkwitansipinjaman.penerima = datapiutang.GetRowCellValue(i, "Kode Pelunasan")
                                viewkwitansipinjaman.ShowDialog()
                            ElseIf master_peluanasan_karyawan.supir.Checked = True Then
                                view_kwitansi_supir.terima = datapiutang.GetRowCellValue(i, "Kode Pelunasan")
                                view_kwitansi_supir.ShowDialog()
                            End If
                        End If
                    End If
                Next i
                MessageBox.Show("Pelunasan berhasil diedit", "Konfirmasi Edit Pelunasan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                audit()
            End If
            If master_peluanasan_karyawan.karyawan.Checked = True Then
                data = New DataTable
                data = DtTableEdit("SELECT pp.id_peluanasan_karyawan `Kode Pelunasan`,pk.id_piutangkaryawan `Kode Piutang`,keterangan `Keterangan`,tanggal_pelunasan `Tanggal Pelunasan`,jumlah_dibayar `Jumlah Bayar` FROM pelunasapiutang_karyawan pp,piutang_karyawan pk,dpiutang_karyawan dp where pp.id_peluanasan_karyawan=dp.id_peluanasan_karyawan and pk.id_piutangkaryawan=dp.id_piutangkaryawan and pk.id_piutangkaryawan='" & master_peluanasan_karyawan.viewdatapelunasan.GetRowCellValue(master_peluanasan_karyawan.viewdatapelunasan.FocusedRowHandle, "Kode Piutang") & "'")
            ElseIf master_peluanasan_karyawan.supir.Checked = True Then
                data = New DataTable
                data = DtTableEdit("SELECT pp.id_peluanasan_karyawan `Kode Pelunasan`,pk.id_piutangkaryawan `Kode Piutang`,keterangan `Keterangan`,tanggal_pelunasan `Tanggal Pelunasan`,jumlah_dibayar `Jumlah Bayar` FROM pelunasapiutang_karyawan pp,piutang_karyawan pk,dpiutang_karyawan dp where pp.id_peluanasan_karyawan=dp.id_peluanasan_karyawan and pk.id_piutangkaryawan=dp.id_piutangkaryawan and pk.id_piutangkaryawan='" & master_peluanasan_karyawan.viewdatapelunasansupir.GetRowCellValue(master_peluanasan_karyawan.viewdatapelunasansupir.FocusedRowHandle, "Kode Piutang") & "'")
            End If
            daftarutang.DataSource = data
            edit_pelunasan_karyawan_Load(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Dim cekload As Boolean = False
    Dim data As New DataTable
    Private Sub datapiutang_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles datapiutang.CellValueChanged
        Try
            If e.Column.FieldName = "Check List Edit" And datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, 5) = False And cekload = True Then
                Dim result() As DataRow = datakeamanan.Select("kode='" & datapiutang.GetRowCellValue(datapiutang.FocusedRowHandle, "Kode Pelunasan") & "'")
                With datapiutang
                    .SetRowCellValue(.FocusedRowHandle, "Jumlah Bayar", result(0).Item(1))
                End With
            End If
            Dim hitung As Double = 0
            For i = 0 To datapiutang.RowCount - 1
                hitung = hitung + datapiutang.GetRowCellValue(i, "Jumlah Bayar")
            Next i
            totalbayar.Text = hitung

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub edit_pelunasan_karyawan_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        datakeamanan.Clear()
        cekload = False
    End Sub
End Class