﻿Public Class buka_piutang_karyawan 
    Dim debet As String = Scalar("select id_akun from control_account where keterangan='Def. Akun Piutang'")
    Dim kredit As String = Scalar("select id_akun from control_account where keterangan='Def. Akun Kas'")


    Private Sub buka_piutang_karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            id.Text = autogenerate("BPK", "select max(id_piutangkaryawan) FROM piutang_karyawan p")
            Dim data As New DataTable
            data = DtTable("select * from makun where tipe_akun='Kas&Bank'")
            akunkas.DataSource = data
            akunkas.DisplayMember = "nama_akun"
            akunkas.ValueMember = "kode_akun"
            data = New DataTable
            data = DtTable("select * from mhari_pelunasan where s='1'")
            harilunas.DataSource = data
            harilunas.DisplayMember = "jumlah_hari"
            harilunas.ValueMember = "id_hari"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

 
    Private Sub pilihkaryawan_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles pilihkaryawan.ButtonClick
        karyawan_piutang.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        id.Text = autogenerate("BPK", "select max(id_piutangkaryawan) FROM piutang_karyawan p")
        If InsertInto("INSERT INTO `piutang_karyawan`(`id_piutangkaryawan`, `id_karyawan`, `tgl`, `nominal`, `path_bukti`, `jatuh_tempo`, `keterangan`, `status`,`id_akun`, `cetakan_ke`) VALUES ('" & id.Text & "','" & idkaryawan.Text & "'," & tanggalpiutang.Value.ToString("yyyMMdd") & "," & nominal.Text & ",'path'," & tanggalpiutang.Value.ToString("yyyyMMdd") & ",'" & keterangan.Text & "','0','" & akunkas.SelectedValue.ToString & "',0)") = True Then
            InsertInto("INSERT INTO `jurnal`(`no_jurnal`, `tgl`) VALUES ('" & id.Text & "'," & tanggalpiutang.Value.ToString("yyyMMdd") & ")")
            Dim opo As Double = CDbl(nominal.Text) * -1
            InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & id.Text & "','" & debet & "','Buka Piutang Karyawan'," & nominal.Text & ")")
            InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & id.Text & "','" & kredit & "','Buka Piutang Karyawan'," & opo & ")")
            MessageBox.Show("Input Piutang Berhasil")
        Else
            MessageBox.Show("Input Piutang Gagal")
        End If
    End Sub
End Class