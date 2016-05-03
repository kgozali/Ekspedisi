Imports MySql.Data.MySqlClient
Public Class add_supplier
    Dim cek As Boolean
    Dim data As New DataTable
    Dim cbkota As New DataTable
    Dim cbsupplier As New DataTable

    Private Sub add_supplier_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If cek = True Then
                Dim msg As Integer = MessageBox.Show("Apakah anda yakin ingin menutup form ini? Semua data yang belum disimpan akan hilang", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If msg = DialogResult.OK Then
                    add_supplier_Load(sender, e)
                    master_supplier.GridControl1.Visible = True
                    master_supplier.GridControl2.Visible = False
                    data = DtTable("SELECT s.id_supplier `Kode Supplier`, s.nama_supplier `Nama Supplier`, s.Alamat `Alamat`, s.Email, s.tel1`Telepon 1`, s.tel2 `Telepon 2`, s.Kota, s.Provinsi, m.kategori_supplier `Nama Kategori` from msupplier s, mkategori_supplier m where m.id_kategori = s.id_kategori and s.`s`='1'")
                    master_supplier.GridControl1.DataSource = data
                    master_supplier.edit.Down = False
                    master_supplier.deldata.Down = False
                    master_supplier.editing.Visible = False
                    master_supplier.hapus.Visible = False
                    master_supplier.GroupControl2.Enabled = True
                    Reset()
                Else
                    e.Cancel = True
                End If
            Else
                add_supplier_Load(sender, e)
                master_supplier.GridControl1.Visible = True
                master_supplier.GridControl2.Visible = False
                data = DtTable("SELECT s.id_supplier `Kode Supplier`, s.nama_supplier `Nama Supplier`, s.Alamat `Alamat`, s.Email, s.tel1`Telepon 1`, s.tel2 `Telepon 2`, s.Kota, s.Provinsi, m.kategori_supplier `Nama Kategori` from msupplier s, mkategori_supplier m where m.id_kategori = s.id_kategori and s.`s`='1'")
                master_supplier.GridControl1.DataSource = data
                master_supplier.edit.Down = False
                master_supplier.deldata.Down = False
                master_supplier.editing.Visible = False
                master_supplier.hapus.Visible = False
                master_supplier.GroupControl2.Enabled = True
                Reset()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        master_supplier.GridControl1.Visible = True
        master_supplier.GridControl2.Visible = False
        data = DtTable("SELECT s.id_supplier `Kode Supplier`, s.nama_supplier `Nama Supplier`, s.Alamat `Alamat`, s.Email, s.tel1`Telepon 1`, s.tel2 `Telepon 2`, s.Kota, s.Provinsi, m.kategori_supplier `Nama Kategori` from msupplier s, mkategori_supplier m where m.id_kategori = s.id_kategori and s.`s`='1'")
        master_supplier.GridControl1.DataSource = data
        master_supplier.edit.Down = False
        master_supplier.deldata.Down = False
        master_supplier.editing.Visible = False
        master_supplier.hapus.Visible = False
        master_supplier.GroupControl2.Enabled = True
        Me.Close()
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click

        If nama.Text = "" Or alamat.Text = "" Or email.Text = "" Or tel1.Text = "" Or provinsi.Text = "" Or kota.Text = "" Then
            MessageBox.Show("Mohon lengkapi data terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim tanggal As New DataTable
                Dim tgl As String = "MS"
                tanggal = DtTable("select * from msupplier where substring(id_supplier,1,2) = '" & tgl & "'")
                Dim hitung As String = tanggal.Rows.Count() + 1
                While hitung.LongCount < 5
                    hitung = "0" + hitung
                End While
                id.Text = tgl + hitung

                'insert ke dalam database
                InsertInto("insert into msupplier values ('" & id.Text & "','" & nama.Text & "','" & alamat.Text & "','" & email.Text & "','" & tel1.Text & "','" & tel2.Text & "','" & provinsi.Text & "','" & kota.Text.ToString & "','" & kategori.SelectedValue.ToString & "','1') ")
                'konfirmasi melakukan booking ulang
                audit()
                Dim msg As Integer = MsgBox("Booking berhasil dilakukan, Apakah anda ingin melakukan input kembali?", MsgBoxStyle.YesNo, "System Message")
                If msg = DialogResult.Yes Then
                    add_supplier_Load(sender, e)
                    Reset()
                Else
                    cek = False
                    master_supplier.GridControl1.Visible = True
                    master_supplier.GridControl2.Visible = False
                    data = DtTable("SELECT s.id_supplier `Kode Supplier`, s.nama_supplier `Nama Supplier`, s.Alamat `Alamat`, s.Email, s.tel1`Telepon 1`, s.tel2 `Telepon 2`, s.Kota, s.Provinsi, m.kategori_supplier `Nama Kategori` from msupplier s, mkategori_supplier m where m.id_kategori = s.id_kategori and s.`s`='1'")
                    master_supplier.GridControl1.DataSource = data
                    master_supplier.edit.Down = False
                    master_supplier.deldata.Down = False
                    master_supplier.editing.Visible = False
                    master_supplier.hapus.Visible = False
                    master_supplier.GroupControl2.Enabled = True
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
        Dim form As String = "Master Supplier"
        Dim aktivitas As String = "Add Supplier: " & id.Text.ToString
        auditlog(user, kompname, form, aktivitas)
    End Sub

    Private Sub add_supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbkota = DtTable("select kota, provinsi from mkota where s = '1'")
            kota.DataSource = cbkota
            kota.ValueMember = "kota"
            kota.DisplayMember = "kota"

            cbsupplier = DtTable("select id_kategori, kategori_supplier from mkategori_supplier where s = '1'")
            kategori.DataSource = cbsupplier
            kategori.ValueMember = "id_kategori"
            kategori.DisplayMember = "kategori_supplier"

            Dim tanggal As New DataTable
            Dim tgl As String = "MS"
            tanggal = DtTable("select * from msupplier where substring(id_supplier,1,2) = '" & tgl & "'")
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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