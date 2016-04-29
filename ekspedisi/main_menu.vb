Imports MySql.Data.MySqlClient
Public Class main_menu


    Private Sub masterakun_Click(sender As Object, e As EventArgs) Handles masterakun.Click
        master_supir.ShowDialog()
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

    Private Sub main_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub buttonrestore_Click(sender As Object, e As EventArgs) Handles buttonrestore.Click

        If restorepath.Text = "" Then
            MessageBox.Show("File Location tidak Ditemukan", "System Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        Else
            Try

                Dim command As MySqlCommand = New MySqlCommand
                command.Connection = connect
                connect.Open()
                'Dim mb As MySqlBackup = New MySqlBackup(command)
                'mb.ImportFromFile(restorepath.Text.ToString())
                connect.Close()
                MessageBox.Show("Restore database berhasil dilakukan", "System Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                restorepath.Text = ""
            Catch ex As Exception
                MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End If


    End Sub

    Private Sub backup_Click(sender As Object, e As EventArgs) Handles backup.Click

        If backuppath.Text = "" Then
            MessageBox.Show("File Location tidak Ditemukan", "System Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        Else
            Try
                Dim command As MySqlCommand = New MySqlCommand
                command.Connection = connect
                connect.Open()
                'Dim mb As MySqlBackup = New MySqlBackup(command)
                'mb.ExportToFile(backuppath.Text.ToString())
                connect.Close()
                MessageBox.Show("Backup database berhasil dilakukan", "System Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End If
    End Sub

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

    Private Sub pelunasanpiutangkaryawan_Click(sender As Object, e As EventArgs) Handles pelunasanpiutangkaryawan.Click
        pelunansan_piutang_karyawan.ShowDialog()
    End Sub

    Private Sub peluanasapiutangprinciple_Click(sender As Object, e As EventArgs) Handles peluanasapiutangprinciple.Click
        pelunasan_piutang.ShowDialog()
    End Sub

    Private Sub SimpleButton28_Click(sender As Object, e As EventArgs) Handles SimpleButton28.Click
        kas_masuk.ShowDialog()
    End Sub

    Private Sub kaskeluar_Click(sender As Object, e As EventArgs) Handles kaskeluar.Click
        kas_keluar.ShowDialog()
    End Sub

    Private Sub SimpleButton8_Click_1(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        buka_piutang_karyawan.ShowDialog()
    End Sub

    Private Sub SimpleButton39_Click(sender As Object, e As EventArgs) Handles SimpleButton39.Click
        frm_reportprinciple.ShowDialog()
    End Sub



    Private Sub SimpleButton37_Click(sender As Object, e As EventArgs) Handles SimpleButton37.Click
        frm_laporankir.ShowDialog()
    End Sub
End Class