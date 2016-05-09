Public Class pelunasan_hutang_supir 
    Dim akunhutang As String = ""
    Dim idakun As String = ""
    Dim tampung As String = ""
    Dim data As New DataTable
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub namakaryawan_ButtonPressed(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles namakaryawan.ButtonPressed
        daftar_hutang_karyawan.ShowDialog()
    End Sub
    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Pelunasan Hutang Supir"
        Dim aktivitas As String = "Pelunasan hutang supir dengan kode: " & tampung
        auditlog(user, kompname, form, aktivitas)
    End Sub
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            Dim centang As Boolean = False
            For i = 0 To datapiutang.RowCount - 1
                If datapiutang.GetRowCellValue(i, "Bayar") = True Then
                    centang = True
                End If

            Next i

            If idkaryawan.Text = "" Or kotaasal.Text = "" Then
                MessageBox.Show("Supir belum dipilih", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf centang = False Then
                MessageBox.Show("Hutang belum dipilih", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                tampung = autogenerate("PPS", "select max(id_phutangkaryawan) from pelunasan_hutang_supir")
                InsertInto("INSERT INTO `pelunasan_hutang_supir`(`id_phutangkaryawan`, `tgl`, `total_nominal`, `id_karyawan`) VALUES ('" & tampung & "'," & tanggalpembayaran.Value.ToString("yyyyMMdd") & "," & totaldibayar.Text & ",'" & idkaryawan.Text & "')")
                For i = 0 To datapiutang.RowCount - 1
                    If datapiutang.GetRowCellValue(i, "Bayar") = True Then
                        InsertInto("INSERT INTO `dpelunasan_hutang_supir`(`id_phutangkaryawan`, `id_booking`, `nominal_bayar`) VALUES ('" & tampung & "','" & datapiutang.GetRowCellValue(i, "Kode Booking") & "'," & datapiutang.GetRowCellValue(i, "Sisa Hutang") & ")")
                        InsertInto("UPDATE `booking_truk` SET `status_bayar_supir`='0' WHERE id_booking='" & datapiutang.GetRowCellValue(i, "Kode Booking") & "'")
                    End If
                Next i
                MessageBox.Show("Pelunasan berhasil dilakukan", "Konfirmasi pembayaran hutang", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                jurnal()
                Dim total As Double = CDbl(totaldibayar.Text)
                Dim mintotal As Double = total * -1
                For i = 0 To datapiutang.RowCount - 1
                    InsertInto("insert into djurnal values('" + tampung + "','" + akunhutang.ToString + "','Pelunasan Hutang Supir'," & datapiutang.GetRowCellValue(i, "Sisa Hutang") & ")")
                Next i
                InsertInto("insert into djurnal values('" + tampung + "','" + idakun.ToString + "','Pelunasan Hutang Supir'," + mintotal.ToString + ")")
                audit()
                'refresh
                Dim angka As Double = 0
                data = New DataTable
                data = DtTablebayarcek("SELECT b.id_booking `Kode Booking`,harga_supir_total `Total Nominal`, dp_awal_supir `DP Awal`,harga_supir_total-dp_awal_supir `Sisa Hutang` FROM  `msupir` ms, booking_truk b WHERE b.id_supir=ms.id_supir and ms.s='1' and status_bayar_supir='1' and ms.id_supir='" & idkaryawan.Text & "' and b.del='0'")
                daftarpiutang.DataSource = data
                For i = 0 To datapiutang.RowCount - 1
                    angka = angka + datapiutang.GetRowCellValue(i, "Sisa Hutang")
                    With datapiutang
                        .SetRowCellValue(i, "Bayar", False)
                    End With
                Next i
                totalhutang.Text = angka.ToString

                lihat_slip_gaji.nomergaji = tampung
                lihat_slip_gaji.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pelunasan_hutang_supir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim data As New DataTable
            data = DtTable("select nama_akun,kode_akun from makun where tipe_akun='Kas&Bank' and detil='1'")
            namaakun.DataSource = data
            namaakun.DisplayMember = "nama_akun"
            namaakun.ValueMember = "kode_akun"
            akunhutang = Scalar("select id_akun from control_account where keterangan='Def. Akun Hutang Lain-Lain'")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Dim keamanan As String
    Private Sub datapiutang_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles datapiutang.CellValueChanging
        Try
            If e.Column.FieldName = "Bayar" Then
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


    Sub jurnal()
        Try
            
            idakun = namaakun.SelectedValue.ToString
            InsertInto("insert into jurnal values('" + tampung + "'," & tanggalpembayaran.Value.ToString("yyyyMMdd") & ")")
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub pelunasan_hutang_supir_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            idkaryawan.Text = ""
            namakaryawan.Text = ""
            nomertelepon.Text = ""
            kotaasal.Text = ""
            totaldibayar.Text = "0"
            totalhutang.Text = "0"
            data = New DataTable
            daftarpiutang.DataSource = data
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class