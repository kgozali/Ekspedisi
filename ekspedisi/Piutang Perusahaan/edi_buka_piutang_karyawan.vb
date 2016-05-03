Public Class edi_buka_piutang_karyawan 
    Dim data As New DataTable
    Dim cekform As Boolean = False
    Dim debet As String = Scalar("select id_akun from control_account where keterangan='Def. Akun Piutang'")
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Edit Buka Piutang Karyawan"
        Dim aktivitas As String = "Edit Buka Piutang: " & id.Text
        auditlog(user, kompname, form, aktivitas)
    End Sub
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            InsertInto("UPDATE `piutang_karyawan` SET `id_karyawan`='" & pilihkaryawan.SelectedValue.ToString & "',`tgl`=" & tanggalpiutang.Value.ToString("yyyyMMdd") & ",`nominal`=" & nominal.Text & ",`jatuh_tempo`=" & tanggalpelunasan.Value.ToString("yyyyMMdd") & ",`keterangan`='" & keterangan.Text & "',`status`='1',`id_akun`='" & akunkas.SelectedValue.ToString & "' WHERE id_piutangkaryawan='" & id.Text & "'")
            InsertInto("update jurnal set tgl=" & tanggalpiutang.Value.ToString("yyyyMMdd") & " where no_jurnal='" & id.Text & "'")
            InsertInto("delete from djurnal where no_jurnal='" & id.Text & "'")
            Dim opo As Double = CDbl(nominal.Text) * -1
            InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & id.Text & "','" & debet & "','Buka Piutang Karyawan'," & nominal.Text & ")")
            InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & id.Text & "','" & akunkas.SelectedValue.ToString & "','Buka Piutang Karyawan'," & opo & ")")

            MessageBox.Show("Piutang berhasil diubah", "Konfirmasi edit", MessageBoxButtons.OK, MessageBoxIcon.Information)
            audit()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub edi_buka_piutang_karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        Try
            data = New DataTable
            data = DtTable("select * from makun where tipe_akun='Kas&Bank' and detil='1'")
            akunkas.DataSource = data
            akunkas.DisplayMember = "nama_akun"
            akunkas.ValueMember = "kode_akun"
            data = New DataTable
            data = DtTable("select * from mhari_pelunasan where s='1'")
            harilunas.DataSource = data
            harilunas.DisplayMember = "jumlah_hari"
            harilunas.ValueMember = "jumlah_hari"
            tanggalpelunasan.Value = tanggalpiutang.Value.AddDays(CInt(harilunas.SelectedValue.ToString))
            If master_peluanasan_karyawan.supir.Checked = True Then
                data = DtTable("select id_supir,nama_supir from msupir where s='1'")
                pilihkaryawan.DataSource = data
                pilihkaryawan.DisplayMember = "nama_supir"
                pilihkaryawan.ValueMember = "id_supir"
            Else
                data = DtTable("select id_karyawan,nama_karyawan from mkaryawan where s='1'")
                pilihkaryawan.DataSource = data
                pilihkaryawan.DisplayMember = "nama_karyawan"
                pilihkaryawan.ValueMember = "id_karyawan"
            End If
            cekform = True
            pilihkaryawan.Text = master_peluanasan_karyawan.namakaryawan
            harilunas.Text = master_peluanasan_karyawan.haripilih
            akunkas.Text = master_peluanasan_karyawan.akunpilih
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pilihkaryawan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pilihkaryawan.SelectedIndexChanged
        Try
            idkaryawan.Text = pilihkaryawan.SelectedValue.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub harilunas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles harilunas.SelectedIndexChanged
        Try
            If cekform = True Then
                tanggalpelunasan.Value = tanggalpiutang.Value.AddDays(CInt(harilunas.SelectedValue.ToString))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub edi_buka_piutang_karyawan_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            pilihkaryawan.Text = ""
            idkaryawan.Text = ""
            id.Text = ""
            nominal.Text = ""
            keterangan.Text = ""
            cekform = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class