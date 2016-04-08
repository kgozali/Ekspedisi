Imports MySql.Data.MySqlClient
Public Class add_karyawan
    Dim cek As Boolean
    Dim cbjabatan As New DataTable
    Dim chckbx As Integer = 1
    Private Sub add_karyawan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If cek = True Then
                Dim msg As Integer = MessageBox.Show("Apakah anda yakin ingin menutup form ini? Semua data yang belum disimpan akan hilang", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If msg = DialogResult.OK Then
                    add_karyawan_Load(sender, e)
                    Reset()
                Else
                    e.Cancel = True
                End If
            Else
                add_karyawan_Load(sender, e)
                Reset()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click

        If nama.Text = "" Or alamat.Text = "" Or tel1.Text = "" Or tel2.Text = "" Or email.Text = "" Or kota.Text = "" Or RichTextBox1.Text = "" Then
            MessageBox.Show("Mohon lengkapi data terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                'insert ke dalam database
                InsertInto("insert into mkaryawan values ('" & id.Text & "','" & nama.Text & "','" & alamat.Text & "','" & kota.Text & "','" & tel1.Text & "','" & tel2.Text & "','" & email.Text & "','" & ComboBox1.SelectedValue.ToString & "','" & DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") & "','" & DateTimePicker2.Value.Date.ToString("yyyy-MM-dd") & "','" & chckbx & "','" & RichTextBox1.Text & "') ")
                'konfirmasi melakukan booking ulang
                Dim msg As Integer = MsgBox("Booking berhasil dilakukan, Apakah anda ingin melakukan input kembali?", MsgBoxStyle.YesNo, "System Message")
                If msg = DialogResult.Yes Then
                    add_karyawan_Load(sender, e)
                    Reset()
                Else
                    cek = False
                    Me.Close()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If



    End Sub

    Private Sub add_karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tanggal As New DataTable
        Dim tgl As String = "MK" + Today.Date.ToString("yyyyMMdd")
        tanggal = DtTable("select * from mkaryawan where substring(ID_KARYAWAN,1,10) = '" & tgl & "'")
        Dim hitung As String = tanggal.Rows.Count() + 1
        While hitung.LongCount < 5
            hitung = "0" + hitung
        End While
        id.Text = tgl + hitung

        nama.Text = ""
        alamat.Text = ""

        tel1.Text = ""
        tel2.Text = ""
        kota.Text = ""
        RichTextBox1.Text = ""
        email.Text = ""
        DateTimePicker1.ResetText()
        DateTimePicker2.ResetText()

        cbjabatan = DtTable("select id_jabatan `Kode Jabatan`,nama_jabatan `Nama Jabatan` from mjabatan")
        ComboBox1.DataSource = cbjabatan
        ComboBox1.DisplayMember = "Nama Jabatan"
        ComboBox1.ValueMember = "Kode Jabatan"
    End Sub

    Private Sub tel1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tel1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub
    Private Sub tel2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tel2.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub nama_TextChanged(sender As Object, e As EventArgs) Handles nama.TextChanged
        'pengecekan untuk mengetahui apakah form sudah di edit atau belum (jika belum, untuk menghindari system warning pertanyaan)
        If nama.Text = "" Then
            cek = False
        Else
            cek = True
        End If
    End Sub


    Private Sub tel1_TextChanged(sender As Object, e As EventArgs) Handles tel1.TextChanged
        'pengecekan untuk mengetahui apakah form sudah di edit atau belum (jika belum, untuk menghindari system warning pertanyaan)
        If tel1.Text = "" Then
            cek = False
        Else
            cek = True
        End If
    End Sub

    Private Sub tel2_TextChanged(sender As Object, e As EventArgs) Handles tel2.TextChanged
        'pengecekan untuk mengetahui apakah form sudah di edit atau belum (jika belum, untuk menghindari system warning pertanyaan)
        If tel2.Text = "" Then
            cek = False
        Else
            cek = True
        End If
    End Sub

    Private Sub email_TextChanged(sender As Object, e As EventArgs) Handles email.TextChanged
        'pengecekan untuk mengetahui apakah form sudah di edit atau belum (jika belum, untuk menghindari system warning pertanyaan)
        If email.Text = "" Then
            cek = False
        Else
            cek = True
        End If
    End Sub

    Private Sub kota_TextChanged(sender As Object, e As EventArgs) Handles kota.TextChanged
        'pengecekan untuk mengetahui apakah form sudah di edit atau belum (jika belum, untuk menghindari system warning pertanyaan)
        If kota.Text = "" Then
            cek = False
        Else
            cek = True
        End If
    End Sub

    Private Sub alamat_TextChanged(sender As Object, e As EventArgs) Handles alamat.TextChanged
        'pengecekan untuk mengetahui apakah form sudah di edit atau belum (jika belum, untuk menghindari system warning pertanyaan)
        If alamat.Text = "" Then
            cek = False
        Else
            cek = True
        End If
    End Sub

    Private Sub rich_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        'pengecekan untuk mengetahui apakah form sudah di edit atau belum (jika belum, untuk menghindari system warning pertanyaan)
        If RichTextBox1.Text = "" Then
            cek = False
        Else
            cek = True
        End If
    End Sub

    Private Sub pasif_CheckedChanged(sender As Object, e As EventArgs) Handles pasif.CheckedChanged
        chckbx = 0
    End Sub

    Private Sub aktif_CheckedChanged(sender As Object, e As EventArgs) Handles aktif.CheckedChanged
        chckbx = 1
    End Sub
End Class