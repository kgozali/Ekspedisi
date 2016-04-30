Imports MySql.Data.MySqlClient
Public Class edit_booking

    Public trukbook As String = ""
    Public principlebook As String = ""
    Public rutebook As String = ""
    Public tabelsupir As New DataTable
    Dim cek As Boolean = False
    Dim tabelkontak As New DataTable
    Public max As Integer = 0
    Dim kode As String = ""
    Dim ceking As Boolean = False
    Dim akunkas As String = ""
    Dim akunhutang As String = ""
    Dim akundpsupir As String = ""
    Public Sub edit_booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'select akun default
            akunkas = Scalar("select id_akun from control_account where keterangan='Def. Akun Kas'")
            akunhutang = Scalar("select id_akun from control_account where keterangan='Def. Akun Hutang Lain-Lain'")
            akundpsupir = Scalar("select id_akun from control_account where keterangan='Def. Akun DP Supir'")
            'select principle
            kode = id.Text.ToString
            principlebook = Scalar("select id_principle from booking_truk where id_booking='" + kode + "'")
            ButtonEdit2.Text = Scalar("select nama_principle from mprinciple where id_principle='" + principlebook.ToString + "'")

            'select truk
            trukbook = Scalar("select id_truk from booking_truk where id_booking='" + kode + "'")
            ButtonEdit1.Text = Scalar("select no_pol from mtruk where id_truk='" + trukbook.ToString + "'")

            'select rute
            rutebook = Scalar("select id_rute from booking_truk where id_booking='" + kode + "'")
            ButtonEdit4.Text = Scalar("select concat(kota_asal,' - ',kota_tujuan) from mrute where id_rute='" + rutebook.ToString + "'")

            'select tanggal dan jam kirim
            Dim tgljam As New DataTable
            tgljam = DtTable("select tgl,jam from booking_truk where id_booking='" + kode + "'")
            DateTimePicker1.Value = tgljam.Rows(0).Item("tgl")
            TimeEdit1.EditValue = tgljam.Rows(0).Item("jam")
            grid()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonEdit4_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit4.ButtonClick
        If principlebook = "" Then
            MessageBox.Show("Pilih principle terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            list_rute_edit.ShowDialog()
        End If
    End Sub

    Private Sub ButtonEdit1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit1.ButtonClick
        list_truk_edit.ShowDialog()
    End Sub


    Private Sub GridControl2_DoubleClick(sender As Object, e As EventArgs) Handles GridControl2.DoubleClick
        If rutebook = "" Then
            MessageBox.Show("Pilih rute terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            list_edit_supir.ShowDialog()
        End If

    End Sub

    Private Sub booking_truk_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If ceking = True Then
                reset()
                master_booking.master_booking_Load(sender, e)
            Else
                If ButtonEdit1.Text <> "" Or ButtonEdit2.Text <> "" Or ButtonEdit4.Text <> "" Then
                    cek = True
                Else
                    cek = False

                End If
                If cek = True Then
                    Dim msg As Integer = MessageBox.Show("Apakah anda yakin ingin menutup form ini? Semua data yang belum disimpan akan hilang", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    If msg = DialogResult.OK Then
                        reset()
                        master_booking.master_booking_Load(sender, e)

                    Else
                        e.Cancel = True
                    End If
                Else
                    reset()
                    master_booking.master_booking_Load(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub reset()
        ButtonEdit1.Text = ""
        ButtonEdit2.Text = ""
        ButtonEdit4.Text = ""
        principlebook = ""
        trukbook = ""
        rutebook = ""
        tabelkontak.Rows.Clear()
        tabelsupir.Rows.Clear()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Sub grid()
        Try
            'tabelsupir.Rows.Add(arr(0), arr(1), arr(2))
            tabelsupir = DtTable("select booking_truk.id_supir `Kode Supir`,nama_supir `Nama Supir`,dp_awal_supir `Jumlah DP (Rp)`,harga_supir_total `Total Bayar (Rp)` from booking_truk,msupir where booking_truk.id_supir=msupir.id_supir and booking_truk.id_booking='" + kode.ToString + "'")
            GridControl2.DataSource = tabelsupir
            max = tabelsupir.Rows(0).Item("Total Bayar (Rp)").ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            If trukbook = "" Then
                MessageBox.Show("Harap pilih truk terlebih dahulu sebelum melakukan booking", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If Not IsNumeric(gridkontak.GetRowCellValue(gridkontak.FocusedRowHandle, "ETA (Jam)")) Then
                    MessageBox.Show("Harap mengisi data kontak dengan format yang sesuai", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If CInt(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Total Bayar (Rp)")) > max Then
                        MessageBox.Show("Nominal Total tidak diperbolehkan melebihi nominal maksimum yang telah ditentukan", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        If CInt(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Jumlah DP (Rp)")) > CInt(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Total Bayar (Rp)")) Then
                            MessageBox.Show("Nominal DP tidak diperbolehkan melebihi Nominal Total Bayar", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            If CInt(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Jumlah DP (Rp)")) = "0" Then
                                Dim msg As Integer = MessageBox.Show("Nominal DP Rp. 0 , apakah anda yakin ingin melanjutkan tanpa nominal DP?", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                                If msg = DialogResult.OK Then
                                    insert()
                                    audit()
                                Else

                                End If

                            Else
                                insert()
                                audit()
                            End If

                        End If

                    End If

                    End If
                End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub audit()
        Dim user As String = "Kevin"
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Booking Truk"
        Dim aktivitas As String = "Edit Booking: " & kode.ToString
        auditlog(user, kompname, form, aktivitas)
    End Sub
    Sub insert()
        'insert ke database
        Try

            Dim jam As New DateTime
            jam = Convert.ToDateTime(TimeEdit1.Text).ToString("HH:mm:ss")
            Dim insert As Boolean = InsertInto("update booking_truk set tgl='" + DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "',jam='" + jam + "',ETA='" + gridkontak.GetRowCellValue(gridkontak.FocusedRowHandle, "ETA (Jam)").ToString + "',id_principle='" + principlebook.ToString + "',id_supir='" + GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Kode Supir").ToString + "',id_truk='" + trukbook + "',keterangan='" + RichTextBox2.Text.ToString + "',id_rute='" + rutebook.ToString + "',alamat_tujuan='" + gridkontak.GetRowCellValue(GridView2.FocusedRowHandle, "Alamat").ToString + "',contact_person='" + gridkontak.GetRowCellValue(GridView2.FocusedRowHandle, "Contact Person").ToString + "',no_telp='" + gridkontak.GetRowCellValue(GridView2.FocusedRowHandle, "Nomor Telepon").ToString + "',dp_awal_supir='" + GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Jumlah DP (Rp)").ToString + "',harga_supir_total='" + GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Total Bayar (Rp)").ToString + "' where id_booking='" + kode.ToString + "'")
            If insert = True Then
                insertakun()
                MessageBox.Show("Perubahan terhadap booking berhasil dilakukan, Untuk melakukan perubahan kembali, silahkan membuka kembali form Booking Truk", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ceking = True
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub ButtonEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles ButtonEdit2.EditValueChanged
        Try
            If ButtonEdit2.Text = "" Then

            Else
                rutebook = ""
                ButtonEdit4.Text = ""
                grid()
                tabelkontak.Rows.Clear()
                Dim dt As New DataTable
                dt = DtTable("select ETA `ETA (Jam)`,contact_person `Contact Person`,no_telp `Nomor Telepon`,alamat_tujuan `Alamat` from booking_truk where id_booking='" + kode + "'")
                GridControl1.DataSource = dt
                'If dt.Rows.Count < 1 Then
                '    Dim alamat As String = ""
                '    alamat = Scalar("select alamat_tujuan from booking_truk where id_booking='" + kode + "'")
                '    Dim ar(3) As String
                '    ar(0) = "0"
                '    ar(1) = ""
                '    ar(2) = ""
                '    ar(3) = alamat
                '    tabelkontak.Rows.Add(ar(0), ar(1), ar(2), ar(3))
                '    GridControl1.DataSource = tabelkontak
                'Else
                '    Dim alamat As String = ""
                '    alamat = Scalar("select alamat_tujuan from booking_truk where id_booking='" + kode + "'")

                '    Dim ar(3) As String
                '    ar(0) = dt.Rows(0).Item("eta").ToString
                '    ar(1) = dt.Rows(0).Item("contact_person").ToString
                '    ar(2) = dt.Rows(0).Item("no_telp").ToString
                '    ar(3) = alamat
                '    tabelkontak.Rows.Add(ar(0), ar(1), ar(2), ar(3))
                '    GridControl1.DataSource = tabelkontak
                'End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub GridControl2_DataSourceChanged(sender As Object, e As EventArgs) Handles GridControl2.DataSourceChanged
        For i = 0 To GridView2.Columns.Count - 3
            GridView2.Columns(i).OptionsColumn.AllowEdit = False
        Next
    End Sub

    Sub insertakun()
        Dim jumlahdp As Integer = CInt(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Jumlah DP (Rp)").ToString)
        Dim totbayar As Integer = CInt(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Total Bayar (Rp)").ToString)
        Dim dpkredit As Integer = jumlahdp * -1
        Dim totkredit As Integer = totbayar * -1
        'insert jurnal
        InsertInto("delete from djurnal where no_jurnal='" + kode.ToString + "'")

        'Inser djurnal biaya gaji pada hutang
        InsertInto("insert into djurnal values('" + kode.ToString + "','" + akundpsupir.ToString + "','','" + totbayar.ToString + "')")
        InsertInto("insert into djurnal values('" + kode.ToString + "','" + akunhutang.ToString + "','','" + totkredit.ToString + "')")

        'Insert djurnal bayar dp = hutang pada kas
        InsertInto("insert into djurnal values('" + kode.ToString + "','" + akunhutang.ToString + "','','" + jumlahdp.ToString + "')")
        InsertInto("insert into djurnal values('" + kode.ToString + "','" + akunkas.ToString + "','','" + dpkredit.ToString + "')")
    End Sub
   
    
End Class