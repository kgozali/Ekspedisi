Imports MySql.Data.MySqlClient
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO

Public Class KIR_Truk

    Dim kode As String = ""
    Dim dt As New DataTable
    Dim nominal As Integer = 0
    Dim path As String = ""
    Dim kodekir As String = ""
    Dim inserts As Boolean = False
    Public trukbook As String = ""
    Dim akunkir As String = ""
    Dim akunkas As String = ""

    Private Sub KIR_Truk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DateTimePicker1.Value = DateTimePicker2.Value.AddMonths(6)
            'autogenerate kode kir
            autogen()
            TextEdit1.Text = kode
            akunkir = Scalar("select id_akun from control_account where keterangan='Def. Akun KIR'")
            akunkas = Scalar("select id_akun from control_account where keterangan='Def. Akun Kas'")
            '            Select truk
            '            dt = DtTable("select id_truk,no_pol from mtruk")
            '            ComboBox1.DataSource = dt
            '            ComboBox1.DisplayMember = "no_pol"
            '            ComboBox1.ValueMember = "id_truk"
            '            dt.Rows.Clear()
            '            generate isi gridview
            '            cekcang()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        '    End Sub

        '    Private Sub nama_CheckedChanged(sender As Object, e As EventArgs)
        '        cekcang()
        '    End Sub

        '    Sub cekcang()
        '        Try
        '            dt = DtTable("select concat(day(kir.tgl),' ',monthname(kir.tgl),' ',year(kir.tgl)) `Tanggal KIR`,kir.id_kir `Kode KIR`,kir.no_kir `No. KIR`,mtruk.id_truk `Kode Truk`,mtruk.no_pol `No. Polisi` from kir,mtruk where kir.id_truk=mtruk.id_truk and mtruk.id_truk LIKE '%" + ComboBox1.SelectedValue.ToString + "%'")
        '            GridControl1.DataSource = dt

        '        Catch ex As Exception
        '            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        End Try

    End Sub

    Sub autogen()
        Try
            Dim tanggal As New DataTable
            Dim tgl As String = "KIR" + Today.Date.ToString("yyMMdd")
            tanggal = DtTable("select * from kir where substring(id_kir,1,9) = '" & tgl & "'")
            Dim hitung As String = tanggal.Rows.Count() + 1
            While hitung.LongCount < 5
                hitung = "0" + hitung
            End While
            kode = tgl + hitung

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    '    Private Sub tanggalhabiskir_CheckedChanged(sender As Object, e As EventArgs)
    '        cekcang()
    '    End Sub

    '    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs)
    '        cekcang()
    '    End Sub

    '    Private Sub tanggalkir_ValueChanged(sender As Object, e As EventArgs)
    '        cekcang()
    '    End Sub
    '    cara load image dari database
    '    Dim arrpic () As Byte =ctype(ambil data image dari database,byte())
    '    Dim ms As New MemoryStream(arrpic)
    '    pictureedit1.image=image.fromstream(arrpic)
    '    ms.close
    '    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
    '        Dim arrpic() As Byte
    '        Try
    '            If TextEdit2.Text = "" Then
    '                MessageBox.Show("Nomor KIR wajib terisi", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Else
    '                If DateTimePicker1.Value < DateTimePicker2.Value Or DateTimePicker1.Value = DateTimePicker2.Value Then
    '                    MessageBox.Show("Tanggal KIR berikutnya wajib lebih besar dari tanggal KIR saat ini", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Else
    '                    If Not IsNumeric(TextEdit3.Text) Then
    '                        MessageBox.Show("Nominal KIR wajib diisi dengan karakter numerik", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                        TextEdit3.Text = ""
    '                    Else
    '                        If TextEdit3.Text = "0.00" Or TextEdit3.Text = "" Or TextEdit3.Text = "0" Then
    '                            Dim msg As Integer = MessageBox.Show("Nominal KIR Rp. 0 ,apakah anda ingin melanjutkan transaksi KIR? Tekan OK untuk konfirmasi", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
    '                            If msg = DialogResult.OK Then
    '                                If TextEdit4.Text = "" Then
    '                                    Dim msg1 As Integer = MessageBox.Show("Bukti KIR tidak ditemukan, apakah anda ingin melanjutkan tanpa menambahkan bukti KIR?", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
    '                                    If msg1 = DialogResult.OK Then
    '                                        kodekir = TextEdit1.Text.ToString
    '                                        Dim insert As Boolean = InsertInto("insert into kir values('" + kodekir + "','" + TextEdit2.Text.ToString + "',now(),'" + DateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "','" + ComboBox1.SelectedValue.ToString + "','" + DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + nominal.ToString + "','" + TextEdit4.Text.ToString + "')")
    '                                        If insert = True Then
    '                                            MessageBox.Show("KIR berhasil dilakukan", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                                        End If
    '                                        KIR_Truk_Load(sender, e)
    '                                    End If
    '                                Else
    '                                    kodekir = TextEdit1.Text.ToString
    '                                    Dim insert As Boolean = InsertInto("insert into kir values('" + kodekir + "','" + TextEdit2.Text.ToString + "',now(),'" + DateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "','" + ComboBox1.SelectedValue.ToString + "','" + DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + nominal.ToString + "','" + TextEdit4.Text.ToString + "')")
    '                                    If insert = True Then
    '                                        MessageBox.Show("KIR berhasil dilakukan", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                                    End If
    '                                    KIR_Truk_Load(sender, e)
    '                                End If

    '                            End If

    '                        Else
    '                            If TextEdit4.Text = "" Then
    '                                Dim msg As Integer = MessageBox.Show("Bukti KIR tidak ditemukan, apakah anda ingin melanjutkan tanpa menambahkan bukti KIR?", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
    '                                If msg = DialogResult.OK Then
    '                                    kodekir = TextEdit1.Text.ToString
    '                                    If PictureEdit1.Text <> "" Then
    '                                        Dim newsize As New Bitmap(480, 480)
    '                                        Dim ms As New MemoryStream
    '                                        PictureEdit1.Image.Save(ms, PictureEdit1.Image.RawFormat)
    '                                        newsize.Save(ms, newsize.RawFormat)
    '                                        arrpic = ms.GetBuffer
    '                                        ms.Close()

    '                                    End If
    '                                    Dim insert As Boolean = InsertInto("insert into kir values('" + kodekir + "','" + TextEdit2.Text.ToString + "',now(),'" + DateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "','" + ComboBox1.SelectedValue.ToString + "','" + DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + nominal.ToString + "','" + TextEdit4.Text.ToString + "',Null)")
    '                                    Dim Command = New MySqlCommand("Update kir set imgfile=@imgfile where id_kir='" + kodekir + "'", connect)
    '                                    connect.Open()
    '                                    Command.Parameters.Add(New MySqlParameter("@imgfile", MySqlDbType.LongBlob)).Value = arrpic
    '                                    Command.ExecuteNonQuery()
    '                                    connect.Close()
    '                                    If insert = True Then
    '                                        MessageBox.Show("KIR berhasil dilakukan", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                                    End If
    '                                    KIR_Truk_Load(sender, e)
    '                                End If
    '                            Else
    '                                kodekir = TextEdit1.Text.ToString
    '                                Dim insert As Boolean = InsertInto("insert into kir values('" + kodekir + "','" + TextEdit2.Text.ToString + "',now(),'" + DateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "','" + ComboBox1.SelectedValue.ToString + "','" + DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + nominal.ToString + "','" + TextEdit4.Text.ToString + "')")
    '                                If insert = True Then
    '                                    MessageBox.Show("KIR berhasil dilakukan", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                                End If
    '                                KIR_Truk_Load(sender, e)
    '                            End If


    '                        End If
    '                    End If
    '                End If


    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try


    '    End Sub

    '    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
    '        cekcang()
    '        GroupControl3.Text = "Data KIR "
    '    End Sub

    Private Sub TextEdit3_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit3.EditValueChanged

        If TextEdit3.Text = "" Or Not IsNumeric(TextEdit3.Text) Then

        Else
            nominal = TextEdit3.Text
            TextEdit3.Text = FormatNumber(Double.Parse(TextEdit3.Text).ToString(), 2)
        End If

    End Sub

    '    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
    '        ofd.FileName = ""
    '        ofd.Filter = "JPG | *.jpg;*.jpeg|PNG | *.png"
    '        ofd.DefaultExt = "PNG"
    '        ofd.InitialDirectory = "C:\users\public"
    '        ofd.ShowDialog()
    '        PictureEdit1.LoadImage()
    '    End Sub

    '    Private Sub ofd_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofd.FileOk
    '        TextEdit4.Text = ofd.FileName
    '        path = ofd.FileName.Replace("\", "\\")
    '    End Sub

    '    Private Sub TextEdit4_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit4.EditValueChanged

    '    End Sub

    '    Private Sub GridControl1_DataSourceChanged(sender As Object, e As EventArgs)
    '        For i = 0 To GridView1.Columns.Count - 1
    '            GridView1.Columns(i).OptionsColumn.AllowEdit = False
    '        Next
    '    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            If TextEdit2.Text = "" Then
                MessageBox.Show("Harap mengisi No. KIR terlebih dahulu", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If trukbook = "" Then
                    MessageBox.Show("Harap memilih truk terlebih dahulu", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If DateTimePicker2.Value > DateTimePicker1.Value Then
                        MessageBox.Show("Tanggal KIR berikutnya wajib sesudah tanggal KIR yang ditentukan", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        If nominal = 0 Or Not IsNumeric(nominal) Then
                            MessageBox.Show("Nominal KIR Rp.0 , harap mengisi nominal KIR lebih dari Rp.0", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            If TextEdit4.Text = "" Then
                                Dim msg As Integer = MessageBox.Show("Bukti KIR tidak ditemukan, apakah anda tetap ingin melanjutkan KIR tanpa mencantumkan bukti KIR?", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                                If msg = DialogResult.OK Then
                                    insert()
                                    insertakun()
                                    Me.Close()
                                End If
                            Else
                                insert()
                                insertakun()
                                Me.Close()
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub insert()
        inserts = InsertInto("insert into kir values('" + kode.ToString + "','" + TextEdit2.Text.ToString + "',now(),'" + DateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "','" + trukbook.ToString + "','" + DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + nominal.ToString + "','" + TextEdit4.Text.ToString + "','',0)")
        If inserts = True Then
            MessageBox.Show("KIR berhasil dilakukan, silahkan membuka Form KIR untuk melakukan KIR kembali", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Jaringan sedang sibuk, silahkan coba beberapa saat lagi", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ButtonEdit1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit1.ButtonClick
        kir_daftar_truk.ShowDialog()
    End Sub

    Private Sub KIR_Truk_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        master_KIR.master_KIR_Load(sender, e)
        reset()
    End Sub
    Sub reset()
        TextEdit2.Text = ""
        TextEdit3.Text = "0"
        trukbook = ""
        DateTimePicker1.ResetText()
        DateTimePicker2.ResetText()
        TextEdit4.Text = ""
        ButtonEdit1.Text = ""
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Sub insertakun()
        Try
            Dim nominalminus As Integer = nominal * -1
            InsertInto("insert into jurnal values('" + kode.ToString + "',now())")
            InsertInto("insert into djurnal values('" + kode.ToString + "','" + akunkas + "','','" + nominalminus.ToString + "')")
            InsertInto("insert into djurnal values('" + kode.ToString + "','" + akunkir + "','','" + nominal.ToString + "')")
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        DateTimePicker1.Value = DateTimePicker2.Value.AddMonths(6)
    End Sub
End Class