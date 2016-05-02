Public Class master_peluanasan_karyawan 

    Private Sub master_peluanasan_karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim data As New DataTable
            data = DtTable("SELECT mk.id_karyawan `Kode Karyawan`, id_piutangkaryawan `Kode Piutang`,nama_karyawan `Nama Karyawan`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, mkaryawan mk where mk.id_karyawan=p.id_karyawan")
            datapelunasan.DataSource = data
            datapelunasan.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Dim data As New DataTable
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles printing.Click
        Try
            If karyawan.Checked = True Then
                view_lihat_cicilan.ShowDialog()
            Else
                view_cicilan_supir.ShowDialog()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        Try
            data = New DataTable
            If all.Checked = True Then
                If nama.Checked = True And karyawan.Checked = True Then
                    data = DtTable("SELECT mk.id_karyawan `Kode Karyawan`, id_piutangkaryawan `Kode Piutang`,nama_karyawan `Nama Karyawan`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, mkaryawan mk where mk.id_karyawan=p.id_karyawan and nama_karyawan like '%" & cari.Text & "%'")
                ElseIf nama.Checked = True And supir.Checked = True Then
                    data = DtTable("SELECT mk.id_supir `Kode Supir`, id_piutangkaryawan `Kode Piutang`,nama_supir `Nama Supir`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, msupir mk where mk.id_supir=p.id_karyawan and nama_supir like '%" & cari.Text & "%'")
                ElseIf nama.Checked = False And karyawan.Checked = True Then
                    data = DtTable("SELECT mk.id_karyawan `Kode Karyawan`, id_piutangkaryawan `Kode Piutang`,nama_karyawan `Nama Karyawan`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, mkaryawan mk where mk.id_karyawan=p.id_karyawan and id_piutangkaryawan like '%" & cari.Text & "%'")
                ElseIf nama.Checked = False And supir.Checked = True Then
                    data = DtTable("SELECT mk.id_supir `Kode Supir`, id_piutangkaryawan `Kode Piutang`,nama_supir `Nama Supir`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, msupir mk where mk.id_supir=p.id_karyawan and id_piutangkaryawan like '%" & cari.Text & "%'")
                End If
            ElseIf belumlunas.Checked = True Then
                If nama.Checked = True And karyawan.Checked = True Then
                    data = DtTable("SELECT mk.id_karyawan `Kode Karyawan`, id_piutangkaryawan `Kode Piutang`,nama_karyawan `Nama Karyawan`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, mkaryawan mk where mk.id_karyawan=p.id_karyawan and nama_karyawan like '%" & cari.Text & "%' and status='1'")
                ElseIf nama.Checked = True And supir.Checked = True Then
                    data = DtTable("SELECT mk.id_supir `Kode Supir`, id_piutangkaryawan `Kode Piutang`,nama_supir `Nama Supir`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, msupir mk where mk.id_supir=p.id_karyawan and nama_supir like '%" & cari.Text & "%' and status='1'")
                ElseIf nama.Checked = False And karyawan.Checked = True Then
                    data = DtTable("SELECT mk.id_karyawan `Kode Karyawan`, id_piutangkaryawan `Kode Piutang`,nama_karyawan `Nama Karyawan`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, mkaryawan mk where mk.id_karyawan=p.id_karyawan and id_piutangkaryawan like '%" & cari.Text & "%' and status='1'")
                ElseIf nama.Checked = False And supir.Checked = True Then
                    data = DtTable("SELECT mk.id_supir `Kode Supir``, id_piutangkaryawan `Kode Piutang`,nama_supir `Nama Supir`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, msupir mk where mk.id_supir=p.id_karyawan and id_piutangkaryawan like '%" & cari.Text & "%' and status='1'")
                End If
            ElseIf lunas.Checked = True Then
                If nama.Checked = True And karyawan.Checked = True Then
                    data = DtTable("SELECT mk.id_karyawan `Kode Karyawan`, id_piutangkaryawan `Kode Piutang`,nama_karyawan `Nama Karyawan`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, mkaryawan mk where mk.id_karyawan=p.id_karyawan and nama_karyawan like '%" & cari.Text & "%' and status='0'")
                ElseIf nama.Checked = True And supir.Checked = True Then
                    data = DtTable("SELECT mk.id_supir `Kode Supir`, id_piutangkaryawan `Kode Piutang`,nama_supir `Nama Supir`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, msupir mk where mk.id_supir=p.id_karyawan and nama_supir like '%" & cari.Text & "%' and status='0'")
                ElseIf nama.Checked = False And karyawan.Checked = True Then
                    data = DtTable("SELECT mk.id_karyawan `Kode Karyawan`, id_piutangkaryawan `Kode Piutang`,nama_karyawan `Nama Karyawan`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, mkaryawan mk where mk.id_karyawan=p.id_karyawan and id_piutangkaryawan like '%" & cari.Text & "%' and status='0'")
                ElseIf nama.Checked = False And supir.Checked = True Then
                    data = DtTable("SELECT mk.id_supir `Kode Supir`, id_piutangkaryawan `Kode Piutang`,nama_supir `Nama Supir`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, msupir mk where mk.id_supir=p.id_karyawan and id_piutangkaryawan like '%" & cari.Text & "%' and status='0'")
                End If
            End If
            If karyawan.Checked = True Then
                datapelunasan.DataSource = data
            Else
                datapelunasansupir.DataSource = data
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub karyawan_CheckedChanged(sender As Object, e As EventArgs) Handles karyawan.CheckedChanged
        Try
            data = New DataTable
            If karyawan.Checked = False Then
                data = DtTable("SELECT mk.id_supir `Kode Supir`, id_piutangkaryawan `Kode Piutang`,nama_supir `Nama Supir`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, msupir mk where mk.id_supir=p.id_karyawan")
                datapelunasan.Visible = False
                datapelunasansupir.Visible = True
            Else
                data = DtTable("SELECT mk.id_karyawan `Kode Karyawan`, id_piutangkaryawan `Kode Piutang`,nama_karyawan `Nama Karyawan`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, mkaryawan mk where mk.id_karyawan=p.id_karyawan")
                datapelunasansupir.Visible = False
                datapelunasan.Visible = True
            End If
            If karyawan.Checked = True Then
                datapelunasan.DataSource = data
            Else
                datapelunasansupir.DataSource = data
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub all_CheckedChanged(sender As Object, e As EventArgs) Handles all.CheckedChanged
        Try
            If all.Checked = True Then
                If nama.Checked = True And karyawan.Checked = True Then
                    data = DtTable("SELECT mk.id_karyawan `Kode Karyawan`, id_piutangkaryawan `Kode Piutang`,nama_karyawan `Nama Karyawan`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, mkaryawan mk where mk.id_karyawan=p.id_karyawan")
                ElseIf nama.Checked = True And supir.Checked = True Then
                    data = DtTable("SELECT mk.id_supir `Kode Supir`, id_piutangkaryawan `Kode Piutang`,nama_supir `Nama Supir`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, msupir mk where mk.id_supir=p.id_karyawan")
                ElseIf nama.Checked = False And karyawan.Checked = True Then
                    data = DtTable("SELECT mk.id_karyawan `Kode Karyawan`, id_piutangkaryawan `Kode Piutang`,nama_karyawan `Nama Karyawan`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, mkaryawan mk where mk.id_karyawan=p.id_karyawan")
                ElseIf nama.Checked = False And supir.Checked = True Then
                    data = DtTable("SELECT mk.id_supir `Kode Supir`, id_piutangkaryawan `Kode Piutang`,nama_supir `Nama Supir`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, msupir mk where mk.id_supir=p.id_karyawan")
                End If
            ElseIf belumlunas.Checked = True Then
                If nama.Checked = True And karyawan.Checked = True Then
                    data = DtTable("SELECT mk.id_karyawan `Kode Karyawan`, id_piutangkaryawan `Kode Piutang`,nama_karyawan `Nama Karyawan`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, mkaryawan mk where mk.id_karyawan=p.id_karyawan and status='1'")
                ElseIf nama.Checked = True And supir.Checked = True Then
                    data = DtTable("SELECT mk.id_supir `Kode Supir`, id_piutangkaryawan `Kode Piutang`,nama_supir `Nama Supir`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, msupir mk where mk.id_supir=p.id_karyawan and status='1'")
                ElseIf nama.Checked = False And karyawan.Checked = True Then
                    data = DtTable("SELECT mk.id_karyawan `Kode Karyawan`, id_piutangkaryawan `Kode Piutang`,nama_karyawan `Nama Karyawan`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, mkaryawan mk where mk.id_karyawan=p.id_karyawan and id_piutangkaryawan and status='1'")
                ElseIf nama.Checked = False And supir.Checked = True Then
                    data = DtTable("SELECT mk.id_supir `Kode Supir`, id_piutangkaryawan `Kode Piutang`,nama_supir `Nama Supir`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, msupir mk where mk.id_supir=p.id_karyawan and status='1'")
                End If
            ElseIf lunas.Checked = True Then
                If nama.Checked = True And karyawan.Checked = True Then
                    data = DtTable("SELECT mk.id_karyawan `Kode Karyawan`, id_piutangkaryawan `Kode Piutang`,nama_karyawan `Nama Karyawan`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, mkaryawan mk where mk.id_karyawan=p.id_karyawan and status='0'")
                ElseIf nama.Checked = True And supir.Checked = True Then
                    data = DtTable("SELECT mk.id_supir `Kode Karyawan`, id_piutangkaryawan `Kode Piutang`,nama_supir `Nama Supir`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, msupir mk where mk.id_supir=p.id_karyawan and status='0'")
                ElseIf nama.Checked = False And karyawan.Checked = True Then
                    data = DtTable("SELECT mk.id_karyawan `Kode Karyawan`, id_piutangkaryawan `Kode Piutang`,nama_karyawan `Nama Karyawan`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, mkaryawan mk where mk.id_karyawan=p.id_karyawan and status='0'")
                ElseIf nama.Checked = False And supir.Checked = True Then
                    data = DtTable("SELECT mk.id_supir `Kode Supir`, id_piutangkaryawan `Kode Piutang`,nama_supir `Nama Supir`,tgl `Tanggal Piutang`, nominal `Nominal`, jatuh_tempo `Jatuh Tempo`,p.keterangan `Keterangan`,if(status='1','Belum Lunas','Lunas') `Status` FROM `piutang_karyawan` p, msupir mk where mk.id_supir=p.id_karyawan and status='0'")
                End If
            End If
            If karyawan.Checked = True Then
                datapelunasan.DataSource = data
            Else
                datapelunasansupir.DataSource = data
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub lunas_CheckedChanged(sender As Object, e As EventArgs) Handles lunas.CheckedChanged
        all_CheckedChanged(sender, e)
    End Sub

    Private Sub editdata_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles editdata.ItemClick
        Try
            Dim tampung As String
            data = New DataTable
            If supir.Checked = True Then
                data = DtTable("SELECT id_piutangkaryawan FROM `dpiutang_karyawan` WHERE id_piutangkaryawan='" & viewdatapelunasansupir.GetRowCellValue(viewdatapelunasansupir.FocusedRowHandle, "Kode Piutang") & "'")
            Else
                data = DtTable("SELECT id_piutangkaryawan FROM `dpiutang_karyawan` WHERE id_piutangkaryawan='" & viewdatapelunasan.GetRowCellValue(viewdatapelunasan.FocusedRowHandle, "Kode Piutang") & "'")
            End If
            If data.Rows.Count > 0 Then
                If supir.Checked = True Then
                    MessageBox.Show("Pelunasan sudah dilakukan pada kode piutang " & viewdatapelunasansupir.GetRowCellValue(viewdatapelunasansupir.FocusedRowHandle, "Kode Piutang"), "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Pelunasan sudah dilakukan pada kode piutang " & viewdatapelunasan.GetRowCellValue(viewdatapelunasan.FocusedRowHandle, "Kode Piutang"), "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Else
                If supir.Checked = True Then
                    tampung = Scalar("select abs(datediff(tgl, jatuh_tempo)) from piutang_karyawan where id_piutangkaryawan='" & viewdatapelunasansupir.GetRowCellValue(viewdatapelunasansupir.FocusedRowHandle, "Kode Piutang") & "'")
                    edi_buka_piutang_karyawan.id.Text = viewdatapelunasansupir.GetRowCellValue(viewdatapelunasansupir.FocusedRowHandle, "Kode Piutang")
                    edi_buka_piutang_karyawan.idkaryawan.Text = viewdatapelunasansupir.GetRowCellValue(viewdatapelunasansupir.FocusedRowHandle, "Kode Karyawan")
                    haripilih = tampung
                    edi_buka_piutang_karyawan.nominal.Text = viewdatapelunasansupir.GetRowCellValue(viewdatapelunasansupir.FocusedRowHandle, "Nominal")
                    tampung = Scalar("select nama_akun from piutang_karyawan p,makun ma where ma.kode_akun=p.id_akun and id_piutangkaryawan='" & viewdatapelunasansupir.GetRowCellValue(viewdatapelunasansupir.FocusedRowHandle, "Kode Piutang") & "'")
                    akunpilih = tampung
                    namakaryawan = viewdatapelunasansupir.GetRowCellValue(viewdatapelunasansupir.FocusedRowHandle, "Nama Supir")
                    edi_buka_piutang_karyawan.keterangan.Text = viewdatapelunasansupir.GetRowCellValue(viewdatapelunasansupir.FocusedRowHandle, "Keterangan")
                    edi_buka_piutang_karyawan.ShowDialog()
                ElseIf karyawan.Checked = True Then
                    tampung = Scalar("select abs(datediff(tgl, jatuh_tempo)) from piutang_karyawan where id_piutangkaryawan='" & viewdatapelunasan.GetRowCellValue(viewdatapelunasan.FocusedRowHandle, "Kode Piutang") & "'")
                    edi_buka_piutang_karyawan.id.Text = viewdatapelunasan.GetRowCellValue(viewdatapelunasan.FocusedRowHandle, "Kode Piutang")
                    edi_buka_piutang_karyawan.nominal.Text = viewdatapelunasan.GetRowCellValue(viewdatapelunasan.FocusedRowHandle, "Nominal")
                    edi_buka_piutang_karyawan.idkaryawan.Text = viewdatapelunasan.GetRowCellValue(viewdatapelunasan.FocusedRowHandle, "Kode Karyawan")
                    haripilih = tampung
                    namakaryawan = viewdatapelunasan.GetRowCellValue(viewdatapelunasan.FocusedRowHandle, "Nama Karyawan")
                    tampung = Scalar("select nama_akun from piutang_karyawan p,makun ma where ma.kode_akun=p.id_akun and id_piutangkaryawan='" & viewdatapelunasan.GetRowCellValue(viewdatapelunasan.FocusedRowHandle, "Kode Piutang") & "'")
                    akunpilih = tampung
                    edi_buka_piutang_karyawan.keterangan.Text = viewdatapelunasan.GetRowCellValue(viewdatapelunasan.FocusedRowHandle, "Keterangan")
                    edi_buka_piutang_karyawan.ShowDialog()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    Public namakaryawan As String
    Public akunpilih As String
    Public haripilih As String

    Private Sub master_peluanasan_karyawan_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        cari.Text = ""
        cari_EditValueChanged(sender, e)
    End Sub

    Private Sub jumpmenu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles jumpmenu.ItemClick
        Me.Close()
    End Sub

    Private Sub editpelunasan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles editpelunasan.ItemClick
        Try
            data = New DataTable
            If supir.Checked = True Then
                data = DtTable("SELECT id_supir,nama_supir,kota,tel1 FROM msupir m where id_supir='" & viewdatapelunasansupir.GetRowCellValue(viewdatapelunasansupir.FocusedRowHandle, "Kode Supir") & "'")
                edit_pelunasan_karyawan.idkaryawan.Text = data.Rows(0).Item("id_supir").ToString
                edit_pelunasan_karyawan.namakaryawan.Text = data.Rows(0).Item("nama_supir").ToString
                edit_pelunasan_karyawan.jabatan.Text = "Supir"
                edit_pelunasan_karyawan.kotaasal.Text = data.Rows(0).Item("kota").ToString
                edit_pelunasan_karyawan.nomortelepon.Text = data.Rows(0).Item("tel1").ToString
                edit_pelunasan_karyawan.totalhutang.Text = viewdatapelunasansupir.GetRowCellValue(viewdatapelunasansupir.FocusedRowHandle, "Nominal")
                data = New DataTable
                data = DtTableEdit("SELECT pp.id_peluanasan_karyawan `Kode Pelunasan`,pk.id_piutangkaryawan `Kode Piutang`,keterangan `Keterangan`,tanggal_pelunasan `Tanggal Pelunasan`,jumlah_dibayar `Jumlah Bayar` FROM pelunasapiutang_karyawan pp,piutang_karyawan pk,dpiutang_karyawan dp where pp.id_peluanasan_karyawan=dp.id_peluanasan_karyawan and pk.id_piutangkaryawan=dp.id_piutangkaryawan and pk.id_piutangkaryawan='" & viewdatapelunasansupir.GetRowCellValue(viewdatapelunasansupir.FocusedRowHandle, "Kode Piutang") & "'")
                edit_pelunasan_karyawan.daftarutang.DataSource = data
                
            ElseIf karyawan.Checked = True Then
                data = DtTable("SELECT id_karyawan,nama_karyawan,nama_jabatan,kota,tel1 FROM mkaryawan m,mjabatan mj where id_karyawan ='" & viewdatapelunasan.GetRowCellValue(viewdatapelunasan.FocusedRowHandle, "Kode Karyawan") & "' and m.id_jabatan=mj.id_jabatan")
                edit_pelunasan_karyawan.idkaryawan.Text = data.Rows(0).Item("id_karyawan").ToString
                edit_pelunasan_karyawan.namakaryawan.Text = data.Rows(0).Item("nama_karyawan").ToString
                edit_pelunasan_karyawan.jabatan.Text = data.Rows(0).Item("nama_jabatan").ToString
                edit_pelunasan_karyawan.kotaasal.Text = data.Rows(0).Item("kota").ToString
                edit_pelunasan_karyawan.nomortelepon.Text = data.Rows(0).Item("tel1").ToString
                edit_pelunasan_karyawan.totalhutang.Text = viewdatapelunasan.GetRowCellValue(viewdatapelunasan.FocusedRowHandle, "Nominal")
                data = New DataTable
                data = DtTableEdit("SELECT pp.id_peluanasan_karyawan `Kode Pelunasan`,pk.id_piutangkaryawan `Kode Piutang`,keterangan `Keterangan`,tanggal_pelunasan `Tanggal Pelunasan`,jumlah_dibayar `Jumlah Bayar` FROM pelunasapiutang_karyawan pp,piutang_karyawan pk,dpiutang_karyawan dp where pp.id_peluanasan_karyawan=dp.id_peluanasan_karyawan and pk.id_piutangkaryawan=dp.id_piutangkaryawan and pk.id_piutangkaryawan='" & viewdatapelunasan.GetRowCellValue(viewdatapelunasan.FocusedRowHandle, "Kode Piutang") & "'")
                edit_pelunasan_karyawan.daftarutang.DataSource = data
            End If
            edit_pelunasan_karyawan.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class