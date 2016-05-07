﻿Imports MySql.Data.MySqlClient
Public Class main_menu

    Public username As String = ""
    Sub quit(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub masterakun_Click(sender As Object, e As EventArgs) Handles masterakun.Click
        master_principle.ShowDialog()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        master_customer.ShowDialog()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        master_jabatan.ShowDialog()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        master_karyawan.ShowDialog()
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        master_kategori_supplier.ShowDialog()
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        master_kontak_principle.ShowDialog()
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs)
        perubahan_harga.ShowDialog()
    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click
        master_rute.ShowDialog()
    End Sub

    Private Sub SimpleButton11_Click(sender As Object, e As EventArgs) Handles SimpleButton11.Click
        master_truck.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        master_barang.ShowDialog()
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        master_kota.ShowDialog()
    End Sub

    Private Sub SimpleButton10_Click(sender As Object, e As EventArgs) Handles SimpleButton10.Click
        master_supplier.ShowDialog()
    End Sub

    Private Sub SimpleButton12_Click(sender As Object, e As EventArgs) Handles SimpleButton12.Click
        master_user.ShowDialog()
    End Sub

    Private Sub SimpleButton20_Click(sender As Object, e As EventArgs) Handles SimpleButton20.Click
        master_booking.ShowDialog()
    End Sub

    Private Sub SimpleButton19_Click(sender As Object, e As EventArgs) Handles SimpleButton19.Click
        master_DO.ShowDialog()
    End Sub

    Public Sub main_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            login2.ShowDialog()
            refreshorganizer()
        Catch ex As Exception

        End Try


    End Sub
    Public Sub refreshorganizer()
        If checkconnection() = True Then
            GridView2.OptionsView.ShowFooter = True
            GridView3.OptionsView.ShowFooter = True

            'MENU DO APPLICATION MANAGER
            Dim dtdo As New DataTable
            dtdo = DtTable("select id_transaksi `Kode Transaksi`,no_DO `No.DO`,concat(day(jatuh_tempo),'-',monthname(jatuh_tempo),'-',year(jatuh_tempo))` Tanggal Jatuh Tempo` from trans_do where jatuh_tempo <= date_add(now(),INTERVAL 31 DAY) and jatuh_tempo >= now() and s=1 and del=0 order by jatuh_tempo asc")
            GridControl1.DataSource = dtdo
            GridView1.OptionsView.ShowFooter = True
            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).OptionsColumn.AllowEdit = False
                If GridView1.Columns(i).FieldName.ToString = "Tanggal Jatuh Tempo" Then
                    GridView1.Columns(i).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                    GridView1.Columns(i).SummaryItem.FieldName = "Tanggal Jatuh Tempo"
                    GridView1.Columns(i).SummaryItem.DisplayFormat = "Total {0} records"
                End If
            Next

            'MENU KIR APPLICATION MANAGER
            Dim dtkir As New DataTable
            dtkir = DtTable("select no_pol `No.Polisi`,concat(day(tgl_kir_berikutnya),'-',monthname(tgl_kir_berikutnya),'-',year(tgl_kir_berikutnya)) `Tanggal KIR Berikutnya` from mtruk,kir where mtruk.id_truk=kir.id_truk and tgl_kir_berikutnya <= date_add(now(),INTERVAL 31 DAY) and tgl_kir_berikutnya >= now() and del=0 order by tgl_kir_berikutnya")
            GridControl4.DataSource = dtkir
            GridView4.OptionsView.ShowFooter = True
            For i = 0 To GridView4.Columns.Count - 1
                GridView4.Columns(i).OptionsColumn.AllowEdit = False
                If GridView4.Columns(i).FieldName.ToString = "Tanggal KIR Berikutnya" Then
                    GridView4.Columns(i).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                    GridView4.Columns(i).SummaryItem.FieldName = "Tanggal KIR Berikutnya"
                    GridView4.Columns(i).SummaryItem.DisplayFormat = "Total {0} records"
                End If
            Next

            Dim dtpiutang As New DataTable
            dtpiutang = DtTable("SELECT id_piutangkaryawan `Kode Piutang`,nama_karyawan `Nama karyawan`,concat(day(jatuh_tempo),'-',monthname(jatuh_tempo),'-',year(jatuh_tempo)) `Tanggal Jatuh Tempo` FROM `piutang_karyawan`pk,mkaryawan mk WHERE jatuh_tempo<=date_add(NOW(),INTERVAL 31 DAY) and status='1' and mk.id_karyawan=pk.id_karyawan and jatuh_tempo >= now() order by jatuh_tempo")
            GridControl3.DataSource = dtpiutang
            GridView3.OptionsView.ShowFooter = True
            For i = 0 To GridView3.Columns.Count - 1
                GridView3.Columns(i).OptionsColumn.AllowEdit = False
                If GridView3.Columns(i).FieldName.ToString = "Tanggal Jatuh Tempo" Then
                    GridView3.Columns(i).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                    GridView3.Columns(i).SummaryItem.FieldName = "Tanggal Jatuh Tempo"
                    GridView3.Columns(i).SummaryItem.DisplayFormat = "Total {0} records"
                End If
            Next

            Dim dtprinciple As New DataTable
            dtprinciple = DtTable("SELECT id_transaksi `Kode Transaksi`,nama_principle `Nama Principle`,concat(day(jatuh_tempo),'-',monthname(jatuh_tempo),'-',year(jatuh_tempo)) `Tanggal Jatuh Tempo` FROM `trans_do` td,booking_truk bk,mprinciple mp WHERE td.id_booking=bk.id_booking and mp.id_principle=bk.id_principle and td.s='1' and jatuh_tempo<=date_add(NOW(),INTERVAL 31 DAY) and jatuh_tempo >= now() order by jatuh_tempo")
            GridControl2.DataSource = dtprinciple
            GridView2.OptionsView.ShowFooter = True
            For i = 0 To GridView2.Columns.Count - 1
                GridView2.Columns(i).OptionsColumn.AllowEdit = False
                If GridView2.Columns(i).FieldName.ToString = "Tanggal Jatuh Tempo" Then
                    GridView2.Columns(i).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                    GridView2.Columns(i).SummaryItem.FieldName = "Tanggal Jatuh Tempo"
                    GridView2.Columns(i).SummaryItem.DisplayFormat = "Total {0} records"
                End If
            Next

            Dim dtsupir As New DataTable
            dtsupir = DtTable("SELECT id_piutangkaryawan `Kode Piutang`,nama_supir `Nama karyawan`,concat(day(jatuh_tempo),'-',monthname(jatuh_tempo),'-',year(jatuh_tempo)) `Tanggal Jatuh Tempo` FROM `piutang_karyawan`pk,msupir mk WHERE jatuh_tempo<=date_add(NOW(),INTERVAL 31 DAY) and status='1' and mk.id_supir=pk.id_karyawan and jatuh_tempo >= now() order by jatuh_tempo")
            GridControl5.DataSource = dtsupir
            GridView5.OptionsView.ShowFooter = True
            For i = 0 To GridView5.Columns.Count - 1
                GridView5.Columns(i).OptionsColumn.AllowEdit = False
                If GridView5.Columns(i).FieldName.ToString = "Tanggal Jatuh Tempo" Then
                    GridView5.Columns(i).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                    GridView5.Columns(i).SummaryItem.FieldName = "Tanggal Jatuh Tempo"
                    GridView5.Columns(i).SummaryItem.DisplayFormat = "Total {0} records"
                End If
            Next

        Else
            MessageBox.Show("Tidak ada koneksi internet, periksa kembali koneksi Internet", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton41_Click(sender As Object, e As EventArgs) Handles SimpleButton41.Click
        opd.FileName = ""
        opd.DefaultExt = "sql"
        opd.Filter = "SQL Files | *.sql"
        opd.InitialDirectory = "C:\users\public"
        opd.ShowDialog()
    End Sub

    Private Sub opd_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles opd.FileOk
        Try
            restorepath.Text = opd.FileName.ToString()
            Dim info = My.Computer.FileSystem.GetFileInfo(restorepath.Text)
            Label20.Text = info.Name
            Label13.Text = info.Extension
            Label14.Text = info.LastWriteTime.ToString("dd-MM-yyyy HH:mm:ss")
            Label15.Text = info.CreationTime.ToString("dd-MM-yyyy HH:mm:ss")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'private sub buttonrestore_click(sender as object, e as eventargs) handles buttonrestore.click

    '    if restorepath.text = "" then
    '        messagebox.show("file location tidak ditemukan", "system warning", messageboxbuttons.retrycancel, messageboxicon.error)
    '    else
    '        try
    '            dim command as mysqlcommand = new mysqlcommand
    '            command.connection = connect
    '            connect.open()
    '            dim mb as mysqlbackup = new mysqlbackup(command)
    '            mb.importfromfile(restorepath.text.tostring())
    '            connect.close()
    '            messagebox.show("restore database berhasil dilakukan", "system success", messageboxbuttons.ok, messageboxicon.information)
    '            restorepath.text = ""
    '        catch ex as exception
    '            messagebox.show(ex.message, "system warning", messageboxbuttons.ok, messageboxicon.error)

    '        end try
    '    end if


    'end sub

    'private sub backup_click(sender as object, e as eventargs) handles backup.click

    '    if backuppath.text = "" then
    '        messagebox.show("file location tidak ditemukan", "system warning", messageboxbuttons.retrycancel, messageboxicon.error)
    '    else
    '        try
    '            dim com as mysqlcommand = new mysqlcommand
    '            com.connection = connect
    '            dim mb as mysqlbackup = new mysqlbackup(com)
    '            connect.open()
    '            mb.exporttofile(backuppath.text.tostring)
    '            connect.close()
    '            messagebox.show("backup database berhasil dilakukan", "system success", messageboxbuttons.ok, messageboxicon.information)
    '            backuppath.text = ""
    '        catch ex as exception
    '            messagebox.show(ex.message, "system warning", messageboxbuttons.ok, messageboxicon.error)

    '        end try
    '    end if
    'end sub

    Private Sub SimpleButton40_Click(sender As Object, e As EventArgs) Handles SimpleButton40.Click
        Dim asd As String = System.DateTime.Now.ToString("dd-MM-yyyy HHmmss")
        sfd.InitialDirectory = "C:\users\public"
        sfd.FileName = "SSKM-" & asd & ".sql"
        sfd.DefaultExt = "sql"
        sfd.Filter = "SQL Files | *.sql"
        sfd.ShowDialog()
    End Sub

    Private Sub sfd_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles sfd.FileOk
        backuppath.Text = sfd.FileName.ToString

    End Sub

    Private Sub backuppath_TextChanged(sender As Object, e As EventArgs) Handles backuppath.TextChanged

    End Sub
    Private Sub SimpleButton42_Click(sender As Object, e As EventArgs) Handles SimpleButton42.Click
        master_KIR.ShowDialog()
    End Sub

    Private Sub pelunasanpiutangkaryawan_Click(sender As Object, e As EventArgs)
        pelunansan_piutang_karyawan.ShowDialog()
    End Sub

    Private Sub peluanasapiutangprinciple_Click(sender As Object, e As EventArgs)
        pelunasan_piutang.ShowDialog()
    End Sub

    Private Sub SimpleButton28_Click(sender As Object, e As EventArgs) Handles SimpleButton28.Click
        daftar_kas_masuk.ShowDialog()
    End Sub

    Private Sub kaskeluar_Click(sender As Object, e As EventArgs) Handles kaskeluar.Click
        daftar_kas_keluar.ShowDialog()
    End Sub

    Private Sub SimpleButton8_Click_1(sender As Object, e As EventArgs)
        buka_piutang_karyawan.ShowDialog()
    End Sub

    Private Sub SimpleButton39_Click(sender As Object, e As EventArgs) Handles SimpleButton39.Click
        frm_reportprinciple.ShowDialog()
    End Sub

    Private Sub SimpleButton37_Click(sender As Object, e As EventArgs) Handles SimpleButton37.Click
        frm_laporankir.ShowDialog()
    End Sub

    Private Sub SimpleButton36_Click(sender As Object, e As EventArgs) Handles SimpleButton36.Click
        frm_principledetail.ShowDialog()
    End Sub

    Private Sub SimpleButton13_Click(sender As Object, e As EventArgs) Handles SimpleButton13.Click
        Audit_Log.ShowDialog()
    End Sub

    Private Sub SimpleButton30_Click(sender As Object, e As EventArgs) Handles SimpleButton30.Click
        daftar_bank_masuk.ShowDialog()
    End Sub

    Private Sub SimpleButton29_Click(sender As Object, e As EventArgs) Handles SimpleButton29.Click
        daftar_bank_keluar.ShowDialog()
    End Sub


    Private Sub XtraTabControl1_Click(sender As Object, e As EventArgs) Handles XtraTabControl1.Click

    End Sub

    Private Sub BackstageViewTabItem2_ItemPressed(sender As Object, e As DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs) Handles BackstageViewTabItem2.ItemPressed

    End Sub

    Private Sub SimpleButton32_Click(sender As Object, e As EventArgs) Handles SimpleButton32.Click
        master_akun.ShowDialog()
    End Sub

    Private Sub SimpleButton38_Click(sender As Object, e As EventArgs) Handles SimpleButton38.Click
        frmprevlapkeu.ShowDialog()
    End Sub

    Private Sub mastersupir_Click(sender As Object, e As EventArgs) Handles mastersupir.Click
        master_harga_supir.ShowDialog()
    End Sub

    Private Sub master_pelunasan_Click(sender As Object, e As EventArgs) Handles master_pelunasan.Click
        master_peluanasan_karyawan.ShowDialog()
    End Sub

    Private Sub masterpiutangprinciple_Click(sender As Object, e As EventArgs) Handles masterpiutangprinciple.Click
        master_pelunasan_principle.ShowDialog()
    End Sub

    Private Sub hutangdo_Click(sender As Object, e As EventArgs) Handles hutangdo.Click
        pelunasan_hutang_supir.ShowDialog()
    End Sub

    Private Sub SimpleButton24_Click(sender As Object, e As EventArgs) Handles SimpleButton24.Click
        frmbukaperiode.ShowDialog()
    End Sub

    Private Sub SimpleButton26_Click(sender As Object, e As EventArgs) Handles SimpleButton26.Click
        frntutupperiode.ShowDialog()
    End Sub

    Private Sub SimpleButton14_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub SimpleButton15_Click(sender As Object, e As EventArgs) Handles SimpleButton15.Click
        master_supir.ShowDialog()
    End Sub

    Private Sub SimpleButton16_Click(sender As Object, e As EventArgs) Handles SimpleButton16.Click
        ViewerAtiva.ShowDialog()
    End Sub

    Private Sub peluanasapiutangprinciple_Click_1(sender As Object, e As EventArgs) Handles peluanasapiutangprinciple.Click
        pelunasan_piutang.ShowDialog()
    End Sub

    Private Sub pelunasanpiutangkaryawan_Click_1(sender As Object, e As EventArgs) Handles pelunasanpiutangkaryawan.Click
        pelunansan_piutang_karyawan.ShowDialog()
    End Sub

    Private Sub SimpleButton8_Click_2(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        buka_piutang_karyawan.ShowDialog()
    End Sub

    Private Sub main_menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        audit()
        'main_menu_Load(sender, e)

    End Sub
    Sub audit()
        Dim user As String = username.ToString
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "System Logout"
        Dim aktivitas As String = "User Logout: " & username.ToString
        auditlog(user, kompname, form, aktivitas)
    End Sub

    Private Sub SimpleButton14_Click_1(sender As Object, e As EventArgs) Handles SimpleButton14.Click
        Dim msg As Integer = MessageBox.Show("Apakah anda yakin ingin menghapus Audit Log?", "System Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If msg = DialogResult.Yes Then
            Dim insert As Boolean = InsertInto("DELETE FROM audit_log")
            If insert = True Then
                MessageBox.Show("Audit Log berhasil dihapus", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                auditdel()
            Else
                MessageBox.Show("Audit Log gagal dihapus,Coba beberapa saat lagi", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If
    End Sub
    Sub auditdel()
        Dim user As String = username.ToString
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Audit Log"
        Dim aktivitas As String = "Wipe Audit Log: " & username.ToString
        auditlog(user, kompname, form, aktivitas)
    End Sub

    Private Sub SimpleButton21_Click(sender As Object, e As EventArgs) Handles SimpleButton21.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton22_Click(sender As Object, e As EventArgs) Handles SimpleButton22.Click
        change_password.ShowDialog()
    End Sub
End Class