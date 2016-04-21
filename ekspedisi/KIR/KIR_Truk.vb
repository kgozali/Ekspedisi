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
    Private Sub KIR_Truk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'autogenerate kode kir
            autogen()
            'select truk
            dt = DtTable("select id_truk,no_pol from mtruk")
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "no_pol"
            ComboBox1.ValueMember = "id_truk"
            dt.Rows.Clear()
            'generate isi gridview
            cekcang()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub nama_CheckedChanged(sender As Object, e As EventArgs)
        cekcang()
    End Sub

    Sub cekcang()
        Try
            dt = DtTable("select concat(day(kir.tgl),' ',monthname(kir.tgl),' ',year(kir.tgl)) `Tanggal KIR`,kir.id_kir `Kode KIR`,kir.no_kir `No. KIR`,mtruk.id_truk `Kode Truk`,mtruk.no_pol `No. Polisi` from kir,mtruk where kir.id_truk=mtruk.id_truk and mtruk.id_truk LIKE '%" + ComboBox1.SelectedValue.ToString + "%'")
            GridControl1.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub autogen()
        Try
            Dim tanggal As New DataTable
            Dim tgl As String = "KIR" + Today.Date.ToString("yyyyMMdd")
            tanggal = DtTable("select * from kir where substring(id_kir,1,11) = '" & tgl & "'")
            Dim hitung As String = tanggal.Rows.Count() + 1
            While hitung.LongCount < 5
                hitung = "0" + hitung
            End While
            kode = tgl + hitung
            TextEdit1.Text = kode
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tanggalhabiskir_CheckedChanged(sender As Object, e As EventArgs)
        cekcang()
    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs)
        cekcang()
    End Sub

    Private Sub tanggalkir_ValueChanged(sender As Object, e As EventArgs)
        cekcang()
    End Sub
    'cara load image dari database
    'Dim arrpic () As Byte =ctype(ambil data image dari database,byte())
    'dim ms as new memorystream(arrpic)
    'pictureedit1.image=image.fromstream(arrpic)
    'ms.close
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim arrpic() As Byte
        Try
            If TextEdit2.Text = "" Then
                MessageBox.Show("Nomor KIR wajib terisi", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If DateTimePicker1.Value < DateTimePicker2.Value Or DateTimePicker1.Value = DateTimePicker2.Value Then
                    MessageBox.Show("Tanggal KIR berikutnya wajib lebih besar dari tanggal KIR saat ini", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If Not IsNumeric(TextEdit3.Text) Then
                        MessageBox.Show("Nominal KIR wajib diisi dengan karakter numerik", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TextEdit3.Text = ""
                    Else
                        If TextEdit3.Text = "0.00" Or TextEdit3.Text = "" Or TextEdit3.Text = "0" Then
                            Dim msg As Integer = MessageBox.Show("Nominal KIR Rp. 0 ,apakah anda ingin melanjutkan transaksi KIR? Tekan OK untuk konfirmasi", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                            If msg = DialogResult.OK Then
                                If TextEdit4.Text = "" Then
                                    Dim msg1 As Integer = MessageBox.Show("Bukti KIR tidak ditemukan, apakah anda ingin melanjutkan tanpa menambahkan bukti KIR?", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                                    If msg1 = DialogResult.OK Then
                                        kodekir = TextEdit1.Text.ToString
                                        Dim insert As Boolean = InsertInto("insert into kir values('" + kodekir + "','" + TextEdit2.Text.ToString + "',now(),'" + DateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "','" + ComboBox1.SelectedValue.ToString + "','" + DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + nominal.ToString + "','" + TextEdit4.Text.ToString + "')")
                                        If insert = True Then
                                            MessageBox.Show("KIR berhasil dilakukan", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        End If
                                        KIR_Truk_Load(sender, e)
                                    End If
                                Else
                                    kodekir = TextEdit1.Text.ToString
                                    Dim insert As Boolean = InsertInto("insert into kir values('" + kodekir + "','" + TextEdit2.Text.ToString + "',now(),'" + DateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "','" + ComboBox1.SelectedValue.ToString + "','" + DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + nominal.ToString + "','" + TextEdit4.Text.ToString + "')")
                                    If insert = True Then
                                        MessageBox.Show("KIR berhasil dilakukan", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    End If
                                    KIR_Truk_Load(sender, e)
                                End If

                            End If

                        Else
                            If TextEdit4.Text = "" Then
                                Dim msg As Integer = MessageBox.Show("Bukti KIR tidak ditemukan, apakah anda ingin melanjutkan tanpa menambahkan bukti KIR?", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                                If msg = DialogResult.OK Then
                                    kodekir = TextEdit1.Text.ToString
                                    If PictureEdit1.Text <> "" Then
                                        Dim newsize As New Bitmap(480, 480)
                                        Dim ms As New MemoryStream
                                        'PictureEdit1.Image.Save(ms, PictureEdit1.Image.RawFormat)
                                        newsize.Save(ms, newsize.RawFormat)
                                        arrpic = ms.GetBuffer
                                        ms.Close()

                                    End If
                                    Dim insert As Boolean = InsertInto("insert into kir values('" + kodekir + "','" + TextEdit2.Text.ToString + "',now(),'" + DateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "','" + ComboBox1.SelectedValue.ToString + "','" + DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + nominal.ToString + "','" + TextEdit4.Text.ToString + "',Null)")
                                    Dim Command = New MySqlCommand("Update kir set imgfile=@imgfile where id_kir='" + kodekir + "'", connect)
                                    connect.Open()
                                    Command.Parameters.Add(New MySqlParameter("@imgfile", MySqlDbType.LongBlob)).Value = arrpic
                                    Command.ExecuteNonQuery()
                                    connect.Close()
                                    If insert = True Then
                                        MessageBox.Show("KIR berhasil dilakukan", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    End If
                                    KIR_Truk_Load(sender, e)
                                End If
                            Else
                                kodekir = TextEdit1.Text.ToString
                                Dim insert As Boolean = InsertInto("insert into kir values('" + kodekir + "','" + TextEdit2.Text.ToString + "',now(),'" + DateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "','" + ComboBox1.SelectedValue.ToString + "','" + DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + nominal.ToString + "','" + TextEdit4.Text.ToString + "')")
                                If insert = True Then
                                    MessageBox.Show("KIR berhasil dilakukan", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                                KIR_Truk_Load(sender, e)
                            End If


                        End If
                    End If
                End If


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        cekcang()
        GroupControl3.Text = "Data KIR "
    End Sub

    Private Sub TextEdit3_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit3.EditValueChanged

        If TextEdit3.Text = "" Or Not IsNumeric(TextEdit3.Text) Then

        Else
            nominal = TextEdit3.Text
            TextEdit3.Text = FormatNumber(Double.Parse(TextEdit3.Text).ToString(), 2)
        End If

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        'ofd.FileName = ""
        'ofd.Filter = "JPG | *.jpg;*.jpeg|PNG | *.png"
        'ofd.DefaultExt = "PNG"
        'ofd.InitialDirectory = "C:\users\public"
        'ofd.ShowDialog()
        PictureEdit1.LoadImage()
    End Sub

    Private Sub ofd_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofd.FileOk
        TextEdit4.Text = ofd.FileName
        path = ofd.FileName.Replace("\", "\\")
    End Sub

    Private Sub TextEdit4_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit4.EditValueChanged

    End Sub

    Private Sub GridControl1_DataSourceChanged(sender As Object, e As EventArgs) Handles GridControl1.DataSourceChanged
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns(i).OptionsColumn.AllowEdit = False
        Next
    End Sub
End Class