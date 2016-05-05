Imports MySql.Data.MySqlClient
Public Class add_karyawan
    Dim cek As Boolean
    Dim cbjabatan As New DataTable
    Dim cbkota As New DataTable
    Dim chckbx As Integer = 1
    Dim data As New DataTable
    Private Sub add_karyawan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If cek = True Then
                Dim msg As Integer = MessageBox.Show("Apakah anda yakin ingin menutup form ini? Semua data yang belum disimpan akan hilang", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If msg = DialogResult.OK Then
                    add_karyawan_Load(sender, e)
                    master_karyawan.deldata.Down = False
                    master_karyawan.edit.Down = False
                    master_karyawan.GroupControl2.Enabled = True
                    master_karyawan.GridControl1.Visible = True
                    master_karyawan.GridControl2.Visible = False
                    master_karyawan.editing.Visible = False
                    master_karyawan.hapus.Visible = False
                    Data = DtTable("SELECT id_karyawan `Kode Karyawan`, b.nama_karyawan `Nama Karyawan`, b.alamat `Alamat`,Email, Kota, tel1 `Telepon 1`, tel2 `Telepon 2`, j.nama_jabatan `Jabatan`, tgl_masuk `Tanggal Masuk`, keterangan `Keterangan`, no_ktp `No KTP` from mkaryawan b, mjabatan j where b.id_jabatan = j.id_jabatan and j.`s` = '1' and b.`s`='1'")
                    master_karyawan.GridControl1.DataSource = Data
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
        master_karyawan.deldata.Down = False
        master_karyawan.edit.Down = False
        master_karyawan.GroupControl2.Enabled = True
        master_karyawan.GridControl1.Visible = True
        master_karyawan.GridControl2.Visible = False
        master_karyawan.editing.Visible = False
        master_karyawan.hapus.Visible = False
        data = DtTable("SELECT id_karyawan `Kode Karyawan`, b.nama_karyawan `Nama Karyawan`, b.alamat `Alamat`,Email, Kota, tel1 `Telepon 1`, tel2 `Telepon 2`, j.nama_jabatan `Jabatan`, tgl_masuk `Tanggal Masuk`, keterangan `Keterangan`, no_ktp `No KTP` from mkaryawan b, mjabatan j where b.id_jabatan = j.id_jabatan and j.`s` = '1' and b.`s`='1'")
        master_karyawan.GridControl1.DataSource = data
        Me.Close()
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click

        If nama.Text = "" Or alamat.Text = "" Or tel1.Text = "" Or tel2.Text = "" Or email.Text = "" Or kota.Text = "" Or RichTextBox1.Text = "" Then
            MessageBox.Show("Mohon lengkapi data terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim tanggal As New DataTable
                Dim tgl As String = "MK"
                tanggal = DtTable("select * from mkaryawan where substring(ID_KARYAWAN,1,2) = '" & tgl & "'")
                Dim hitung As String = tanggal.Rows.Count() + 1
                While hitung.LongCount < 5
                    hitung = "0" + hitung
                End While
                id.Text = tgl + hitung

                'insert ke dalam database
                InsertInto("insert into mkaryawan values ('" & id.Text & "','" & nama.Text & "','" & alamat.Text & "','" & kota.Text & "','" & tel1.Text & "','" & tel2.Text & "','" & email.Text & "','" & jabatan.SelectedValue.ToString & "','" & DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") & "',null,'" & RichTextBox1.Text & "','" & ktp.Text & "','1') ")
                'konfirmasi melakukan Input ulang
                audit()
                Dim msg As Integer = MsgBox("Input berhasil dilakukan, Apakah anda ingin melakukan input kembali?", MsgBoxStyle.YesNo, "System Message")
                If msg = DialogResult.Yes Then
                    add_karyawan_Load(sender, e)
                    Reset()
                Else
                    cek = False
                    add_karyawan_Load(sender, e)
                    master_karyawan.deldata.Down = False
                    master_karyawan.edit.Down = False
                    master_karyawan.hapus.Visible = False
                    master_karyawan.editing.Visible = False
                    master_karyawan.GroupControl2.Enabled = True
                    master_karyawan.GridControl1.Visible = True
                    master_karyawan.GridControl2.Visible = False
                    data = DtTable("SELECT id_karyawan `Kode Karyawan`, b.nama_karyawan `Nama Karyawan`, b.alamat `Alamat`,Email, Kota, tel1 `Telepon 1`, tel2 `Telepon 2`, j.nama_jabatan `Jabatan`, tgl_masuk `Tanggal Masuk`, keterangan `Keterangan`, no_ktp `No KTP` from mkaryawan b, mjabatan j where b.id_jabatan = j.id_jabatan and j.`s` = '1' and b.`s`='1'")
                    master_karyawan.GridControl1.DataSource = data
                    Me.Close()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If



    End Sub
    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Master Karyawan"
        Dim aktivitas As String = "Add Karyawan: " & id.Text.ToString
        auditlog(user, kompname, form, aktivitas)
    End Sub

    Private Sub add_karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tanggal As New DataTable
        Dim tgl As String = "MK"
        tanggal = DtTable("select * from mkaryawan where substring(ID_KARYAWAN,1,2) = '" & tgl & "'")
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
        ktp.Text = ""

        cbjabatan = DtTable("select id_jabatan `Kode Jabatan`,nama_jabatan `Nama Jabatan` from mjabatan where s = '1'")
        jabatan.DataSource = cbjabatan
        jabatan.DisplayMember = "Nama Jabatan"
        jabatan.ValueMember = "Kode Jabatan"

        cbkota = DtTable("select kota, provinsi from mkota where s = '1'")
        kota.DataSource = cbkota
        kota.ValueMember = "kota"
        kota.DisplayMember = "kota"
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

    Private Sub kota_TextChanged(sender As Object, e As EventArgs)
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

    Private Sub pasif_CheckedChanged(sender As Object, e As EventArgs)
        chckbx = 0
    End Sub

    Private Sub aktif_CheckedChanged(sender As Object, e As EventArgs)
        chckbx = 1
    End Sub

End Class