Public Class tambah_transaksi_sewa
    Dim kode As String = ""
    Public customersewa As String = ""
    Dim kodesewavar As String = ""
    Dim defpiutang As String = ""
    Dim defpendapatan As String = ""
    Dim total As Integer = 0
    Dim mintot As Integer = 0
    Private Sub idkaryawan_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles idkaryawan.ButtonClick
        add_customer_master_sewa.ShowDialog()
    End Sub

    
    Private Sub tambahmobil_Click(sender As Object, e As EventArgs) Handles tambahmobil.Click
        add_mobil_transaksi.ShowDialog()
    End Sub

    Private Sub tambah_transaksi_sewa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autogen()
        id.Text = kode
        defpiutang = Scalar("select id_akun from control_account where keterangan='Def. Akun Piutang'")
        defpendapatan = Scalar("select id_akun from control_account where keterangan='Def. Akun Pendapatan'")
    End Sub

    Sub autogen()
        Try
            Dim tanggal As New DataTable
            Dim tgl As String = "SM" + Today.Date.ToString("yyMMdd")
            tanggal = DtTable("select * from trans_mobil where substring(id_tmobil,1,8) = '" & tgl & "'")
            Dim hitung As String = tanggal.Rows.Count() + 1
            While hitung.LongCount < 5
                hitung = "0" + hitung
            End While
            kode = tgl + hitung
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub idkaryawan_Click(sender As Object, e As EventArgs) Handles idkaryawan.Click
        add_customer_master_sewa.ShowDialog()
    End Sub

    Private Sub tambah_transaksi_sewa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If customersewa <> "" Then
            Dim msg As Integer = MessageBox.Show("Apakah anda yakin ingin menutup form ini? Semua data yang belum disimpan akan hilang", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If msg = DialogResult.OK Then
                reset()
                master_transaksi.master_transaksi_Load(sender, e)
            Else
                e.Cancel = True

            End If
        Else
            reset()
            master_transaksi.master_transaksi_Load(sender, e)
        End If

    End Sub
    Sub reset()
        kodesewa.Text = ""
        idkaryawan.Text = ""
        email.Text = ""
        nomortelepon.Text = ""
        kotaasal.Text = ""
        customersewa = ""
        Dim dt As New DataTable
        GridControl1.DataSource = dt
        DateTimePicker1.ResetText()

    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        If customersewa = "" Then
            MessageBox.Show("Pilih customer terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If GridView1.DataRowCount < 1 Then
                MessageBox.Show("Customer yang terpilih belum memiliki daftar mobil", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If kodesewa.Text = "" Then
                    Dim msg As Integer = MessageBox.Show("Apakah anda ingin melanjutkan tanpa mencantumkan kode sewa?", "System Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If msg = DialogResult.Yes Then
                        savetrans()
                    End If
                Else
                    savetrans()
                End If
            End If
        End If
    End Sub

    Private Sub savetrans()
        Try
            kodesewavar = kodesewa.Text
            autogen()
            Dim tot As Integer = GridView1.Columns("Harga Sewa").SummaryItem.SummaryValue.ToString
            total = tot
            mintot = total * -1
            Dim hasil As Boolean = InsertInto("INSERT INTO trans_mobil VALUES('" + kode + "',now(),'" + kodesewavar + "','" + customersewa + "','" + DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + tot.ToString + "',1,0,0)")
            For i = 0 To GridView1.DataRowCount - 1
                InsertInto("INSERT INTO dtrans_mobil VALUES('" + kode + "','" + GridView1.GetRowCellValue(i, "Kode Mobil").ToString + "','" + GridView1.GetRowCellValue(i, "Harga Sewa").ToString + "')")
            Next
            InsertInto("INSERT INTO jurnal VALUES('" + kode + "','" + DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "')")
            InsertInto("INSERT INTO djurnal VALUES('" + kode + "','" + defpiutang + "','Sewa Mobil','" + total.ToString + "')")
            InsertInto("INSERT INTO djurnal VALUES('" + kode + "','" + defpendapatan + "','Sewa Mobil','" + mintot.ToString + "')")
            If hasil = True Then
                MessageBox.Show("Transaksi " & kode & " berhasil disimpan", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
                customersewa = ""
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class