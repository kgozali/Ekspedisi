Imports MySql.Data.MySqlClient
Public Class booking_truk
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
    Private Sub booking_truk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            akunkas = Scalar("select id_akun from control_account where keterangan='Def. Akun Kas'")
            akunhutang = Scalar("select id_akun from control_account where keterangan='Def. Akun Hutang Lain-Lain'")
            akundpsupir = Scalar("select id_akun from control_account where keterangan='Def. Akun DP Supir'")
            autogen()
            id.Text = kode
            grid()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ButtonEdit4_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit4.ButtonClick
        If principlebook = "" Then
            MessageBox.Show("Pilih principle terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            rute_booking.ShowDialog()
        End If
    End Sub

    Private Sub ButtonEdit1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit1.ButtonClick
        truk_booking.ShowDialog()
    End Sub

    Private Sub ButtonEdit2_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit2.ButtonClick
        principle_booking.ShowDialog()
    End Sub

    Private Sub GridControl2_DoubleClick(sender As Object, e As EventArgs) Handles GridControl2.DoubleClick
        If rutebook = "" Then
            MessageBox.Show("Pilih rute terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            supir_booking.ShowDialog()
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
        TimeEdit1.Reset()
        trukbook = ""
        rutebook = ""
        tabelkontak.Rows.Clear()
        tabelsupir.Rows.Clear()
        grid()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Sub grid()
        Try
            'buat kolom-kolom di gridview
            If tabelkontak.Columns.Count < 1 Then
                tabelkontak.Columns.Add("ETA (Jam)")
                tabelkontak.Columns.Add("Contact Person")
                tabelkontak.Columns.Add("Nomor Telepon")
                tabelkontak.Columns.Add("Alamat")
            End If

            Dim ar(3) As String
            For i = 0 To 3
                ar(i) = ""
            Next
            tabelkontak.Rows.Add(ar(0), ar(1), ar(2), ar(3))
            GridControl1.DataSource = tabelkontak

            If tabelsupir.Columns.Count < 1 Then
                tabelsupir.Columns.Add("Kode Supir")
                tabelsupir.Columns.Add("Nama Supir")
                tabelsupir.Columns.Add("Jumlah DP (Rp)")
                tabelsupir.Columns.Add("Total Bayar (Rp)")
            End If

            Dim arr(2) As String
            For i = 0 To 2
                arr(i) = ""
            Next
            tabelsupir.Rows.Clear()
            tabelsupir.Rows.Add(arr(0), arr(1), arr(2))
            GridControl2.DataSource = tabelsupir

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            If DateTimePicker2.Value > DateTimePicker1.Value Then
                MessageBox.Show("Tanggal Booking tidak diperbolehkan melebihi Tanggal Pengiriman", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If trukbook = "" Then
                    MessageBox.Show("Harap pilih truk terlebih dahulu sebelum melakukan booking", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If Not IsNumeric(gridkontak.GetRowCellValue(gridkontak.FocusedRowHandle, "ETA (Jam)")) Then
                        MessageBox.Show("Harap mengisi data kontak dengan format yang sesuai", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        If GridControl2.DataSource Is tabelsupir Then
                            MessageBox.Show("Harap pilih supir terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                                            autogen()
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
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Booking Truk"
        Dim aktivitas As String = "Add Booking: " & kode.ToString
        auditlog(user, kompname, form, aktivitas)
    End Sub
    Sub insert()
        'insert ke database
        Try
            autogen()
            Dim jam As New DateTime
            jam = Convert.ToDateTime(TimeEdit1.Text).ToString("HH:mm:ss")
            Dim insert As Boolean = InsertInto("insert into booking_truk values('" + kode.ToString + "','" + DateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "','" + DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + jam + "','" + gridkontak.GetRowCellValue(gridkontak.FocusedRowHandle, "ETA (Jam)") + "','" + principlebook + "','" + GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Kode Supir") + "','" + trukbook + "','" + RichTextBox2.Text.ToString + "','" + rutebook + "','" + gridkontak.GetRowCellValue(GridView2.FocusedRowHandle, "Alamat") + "','" + gridkontak.GetRowCellValue(GridView2.FocusedRowHandle, "Contact Person") + "','" + gridkontak.GetRowCellValue(GridView2.FocusedRowHandle, "Nomor Telepon") + "','" + GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Jumlah DP (Rp)") + "','" + GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Total Bayar (Rp)") + "',1,1,1)")
            insertakun()
            
            If insert = True Then
                MessageBox.Show("Booking berhasil dilakukan, Untuk melakukan booking kembali, silahkan membuka kembali form Booking Truk", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frm_bookingtruk.bookcode = kode.ToString
                frm_bookingtruk.ShowDialog()
                ceking = True
                reset()

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
                dt = DtTable("select nama_kontak,tel1 from mkontakprinciple where id_principle='" + principlebook + "'")
                If dt.Rows.Count < 1 Then
                    Dim alamat As String = ""
                    alamat = Scalar("select alamat from mprinciple where id_principle='" + principlebook + "'")
                    Dim ar(3) As String
                    ar(0) = "0"
                    ar(1) = ""
                    ar(2) = ""
                    ar(3) = alamat
                    tabelkontak.Rows.Add(ar(0), ar(1), ar(2), ar(3))
                    GridControl1.DataSource = tabelkontak
                Else
                    Dim alamat As String = ""
                    alamat = Scalar("select alamat from mprinciple where id_principle='" + principlebook + "'")
                    Dim ar(3) As String
                    ar(0) = "0"
                    ar(1) = dt.Rows(0).Item("nama_kontak").ToString
                    ar(2) = dt.Rows(0).Item("tel1").ToString
                    ar(3) = alamat
                    tabelkontak.Rows.Add(ar(0), ar(1), ar(2), ar(3))
                    GridControl1.DataSource = tabelkontak
                End If
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
    Sub autogen()
        Try
            Dim tanggal As New DataTable
            Dim tgl As String = "BK" + Today.Date.ToString("yyMMdd")
            tanggal = DtTable("select * from booking_truk where substring(id_booking,1,8) = '" & tgl & "'")
            Dim hitung As String = tanggal.Rows.Count() + 1
            While hitung.LongCount < 5
                hitung = "0" + hitung
            End While
            kode = tgl + hitung
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
    Sub insertakun()
        Try
            Dim jumlahdp As Integer = CInt(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Jumlah DP (Rp)").ToString)
            Dim totbayar As Integer = CInt(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Total Bayar (Rp)").ToString)
            Dim dpkredit As Integer = jumlahdp * -1
            Dim totkredit As Integer = totbayar * -1
            'insert jurnal
            InsertInto("insert into jurnal values('" + kode.ToString + "','" + DateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "')")

            'Inser djurnal biaya gaji pada hutang
            InsertInto("insert into djurnal values('" + kode.ToString + "','" + akundpsupir.ToString + "','','" + totbayar.ToString + "')")
            InsertInto("insert into djurnal values('" + kode.ToString + "','" + akunhutang.ToString + "','','" + totkredit.ToString + "')")

            'Insert djurnal bayar dp = hutang pada kas
            InsertInto("insert into djurnal values('" + kode.ToString + "','" + akunhutang.ToString + "','','" + jumlahdp.ToString + "')")
            InsertInto("insert into djurnal values('" + kode.ToString + "','" + akunkas.ToString + "','','" + dpkredit.ToString + "')")

            

           
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       

    End Sub

    
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Try
            If DateTimePicker2.Value > DateTimePicker1.Value Then
                MessageBox.Show("Tanggal Booking tidak diperbolehkan melebihi Tanggal Pengiriman", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If trukbook = "" Then
                    MessageBox.Show("Harap pilih truk terlebih dahulu sebelum melakukan booking", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If Not IsNumeric(gridkontak.GetRowCellValue(gridkontak.FocusedRowHandle, "ETA (Jam)")) Then
                        MessageBox.Show("Harap mengisi data kontak dengan format yang sesuai", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        If GridControl2.DataSource Is tabelsupir Then
                            MessageBox.Show("Harap pilih supir terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                                            autogen()
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
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class