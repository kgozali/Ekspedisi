Public Class pelunasan_hutang_supir 

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub namakaryawan_ButtonPressed(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles namakaryawan.ButtonPressed
        daftar_hutang_karyawan.ShowDialog()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            If idkaryawan.Text = "Belum Terisi" Or kotaasal.Text = "Belum Terisi" Then
                MessageBox.Show("Karyawan Belum Dipilih")
            Else
                Dim tampung As String = autogenerate("PPS", "select max(id_phutangkaryawan) from pelunasan_hutang_supir")
                InsertInto("INSERT INTO `pelunasan_hutang_supir`(`id_phutangkaryawan`, `tgl`, `total_nominal`, `id_karyawan`) VALUES ('" & tampung & "'," & tanggalpembayaran.Value.ToString("yyyyMMdd") & "," & totaldibayar.Text & ",'" & idkaryawan.Text & "')")
                For i = 0 To datapiutang.RowCount - 1
                    If datapiutang.GetRowCellValue(i, "Bayar") = True Then
                        InsertInto("INSERT INTO `dpelunasan_hutang_supir`(`id_phutangkaryawan`, `id_booking`, `nominal_bayar`) VALUES ('" & tampung & "','" & datapiutang.GetRowCellValue(i, "Kode Booking") & "'," & datapiutang.GetRowCellValue(i, "Sisa Hutang") & ")")
                        InsertInto("UPDATE `booking_truk` SET `status_bayar_supir`='0' WHERE id_booking='" & datapiutang.GetRowCellValue(i, "Kode Booking") & "'")
                    End If

                Next i

                MessageBox.Show("Pelunasan berhasil dilakukan")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pelunasan_hutang_supir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim data As New DataTable
            data = DtTable("select * from makun where tipe_akun='Kas&Bank'")
            namaakun.DataSource = data
            namaakun.DisplayMember = "nama_akun"
            namaakun.ValueMember = "kode_akun"

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
                        angka = angka + datapiutang.GetRowCellValue(i, "Sisa Hutang")
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

    Private Sub openfile_Click(sender As Object, e As EventArgs) Handles openfile.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
    End Sub

    Sub jurnal()

    End Sub
End Class