Imports MySql.Data.MySqlClient
Public Class add_customer
    Dim cek As Boolean
    Dim data As New DataTable
    Dim cbkota As New DataTable

    Private Sub add_customer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If cek = True Then
                Dim msg As Integer = MessageBox.Show("Apakah anda yakin ingin menutup form ini? Semua data yang belum disimpan akan hilang", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If msg = DialogResult.OK Then
                    add_customer_Load(sender, e)
                    master_customer.GridControl1.Visible = True
                    master_customer.GridControl2.Visible = False
                    data = DtTable("SELECT id_customer `Kode Customer`, nama_Customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer b where b.`s`='1'")
                    master_customer.GridControl1.DataSource = data
                    master_customer.edit.Down = False
                    master_customer.editing.Visible = False
                    master_customer.deldata.Down = False
                    master_customer.hapus.Visible = False
                    master_customer.GroupControl2.Enabled = True
                    Reset()
                Else
                    e.Cancel = True
                End If
            Else
                add_customer_Load(sender, e)
                master_customer.GridControl1.Visible = True
                master_customer.GridControl2.Visible = False
                data = DtTable("SELECT id_customer `Kode Customer`, nama_customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer b where b.`s`='1'")
                master_customer.GridControl1.DataSource = data
                master_customer.edit.Down = False
                master_customer.editing.Visible = False
                master_customer.deldata.Down = False
                master_customer.hapus.Visible = False
                master_customer.GroupControl2.Enabled = True
                Reset()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        master_customer.GridControl1.Visible = True
        master_customer.GridControl2.Visible = False
        data = DtTable("SELECT id_customer `Kode Customer`, nama_customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer b where b.`s`='1'")
        master_customer.GridControl1.DataSource = data
        master_customer.edit.Down = False
        master_customer.editing.Visible = False
        master_customer.deldata.Down = False
        master_customer.hapus.Visible = False
        master_customer.GroupControl2.Enabled = True
        Me.Close()
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click

        If nama.Text = "" Or alamat.Text = "" Or email.Text = "" Or tel1.Text = "" Or provinsi.Text = "" Or kota.Text = "" Then
            MessageBox.Show("Mohon lengkapi data terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim tanggal As New DataTable
                Dim tgl As String = "MC"
                tanggal = DtTable("select * from mcustomer where substring(ID_customer,1,2) = '" & tgl & "'")
                Dim hitung As String = tanggal.Rows.Count() + 1
                While hitung.LongCount < 5
                    hitung = "0" + hitung
                End While
                id.Text = tgl + hitung

                'insert ke dalam database
                InsertInto("insert into mcustomer values ('" & id.Text & "','" & nama.Text & "','" & alamat.Text & "','" & email.Text & "','" & tel1.Text & "','" & tel2.Text & "','" & provinsi.Text & "','" & kota.Text.ToString & "','1') ")
                audit()
                'konfirmasi melakukan booking ulang
                Dim msg As Integer = MsgBox("Booking berhasil dilakukan, Apakah anda ingin melakukan input kembali?", MsgBoxStyle.YesNo, "System Message")
                If msg = DialogResult.Yes Then
                    add_customer_Load(sender, e)
                    Reset()
                Else
                    cek = False
                    master_customer.GridControl1.Visible = True
                    master_customer.GridControl2.Visible = False
                    data = DtTable("SELECT id_customer `Kode Customer`, nama_Customer `Nama Customer`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mcustomer b where b.`s`='1'")
                    master_customer.GridControl1.DataSource = data
                    master_customer.edit.Down = False
                    master_customer.editing.Visible = False
                    master_customer.deldata.Down = False
                    master_customer.hapus.Visible = False
                    master_customer.GroupControl2.Enabled = True
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
        Dim form As String = "Master Customer"
        Dim aktivitas As String = "Add Customer: " & id.Text.ToString
        auditlog(user, kompname, form, aktivitas)
    End Sub

    Private Sub add_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbkota = DtTable("select kota, provinsi from mkota where s = '1'")
        kota.DataSource = cbkota
        kota.ValueMember = "kota"
        kota.DisplayMember = "kota"


        Dim tanggal As New DataTable
        Dim tgl As String = "MC"
        tanggal = DtTable("select * from mcustomer where substring(ID_customer,1,2) = '" & tgl & "'")
        Dim hitung As String = tanggal.Rows.Count() + 1
        While hitung.LongCount < 5
            hitung = "0" + hitung
        End While
        id.Text = tgl + hitung

        nama.Text = ""
        alamat.Text = ""
        email.Text = ""
        tel1.Text = ""
        tel2.Text = ""
        provinsi.Text = ""
        kota.Text = ""
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

    Private Sub email_TextChanged(sender As Object, e As EventArgs) Handles email.TextChanged
        'pengecekan untuk mengetahui apakah form sudah di edit atau belum (jika belum, untuk menghindari system warning pertanyaan)
        If email.Text = "" Then
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


    Private Sub provinsi_TextChanged(sender As Object, e As EventArgs) Handles provinsi.TextChanged
        'pengecekan untuk mengetahui apakah form sudah di edit atau belum (jika belum, untuk menghindari system warning pertanyaan)
        If provinsi.Text = "" Then
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


    Private Sub kota_SelectedValueChanged(sender As Object, e As EventArgs) Handles kota.SelectedValueChanged
        Dim carip As String = "select provinsi from mkota where kota ='" & kota.Text.ToString & "' and s = '1'"
        Dim prov As String = Scalar(carip)
        provinsi.Text = prov
    End Sub

End Class