Imports MySql.Data.MySqlClient
Public Class add_truck
    Dim inputtruk As String = ""
    Dim cbsupplier As New DataTable
    Dim cbaktv As New DataTable
    Dim cbpenystn As New DataTable
    Dim cbdpresiasi As New DataTable
    Dim cek As Boolean
    Dim data As New DataTable

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        data = DtTable("SELECT t.id_truk `Kode Truk`, t.no_pol `No Polisi`, t.no_mesin `No Mesin`, t.no_rangka `No Rangka`, s.nama_supplier `Nama Supplier`, t.harga_beli `Harga Beli`, t.umur_default `Umur Default`, t.nilai_residu `Nilai Residu`, a.nama_akun `Akun Aktiva`, p.nama_akun `Akun Penyusutan`, d.nama_akun `Akun Depresiasi` from mtruk t, makun a, makun d, makun p, msupplier s where t.id_supplier = s.id_supplier and t.id_akun_akt = a.kode_akun and t.id_akun_depresiasi = d.kode_akun and t.id_akun_penyusutan = p.kode_akun and t.`s`='1'")
        master_truck.GridControl1.DataSource = data
        master_truck.GridControl1.Visible = True
        master_truck.GridControl2.Visible = False
        master_truck.GroupControl2.Enabled = True
        master_truck.deldata.Down = False
        master_truck.hapus.Visible = False
        master_truck.editing.Visible = False
        master_truck.edit.Down = False
        Me.Close()
    End Sub

    Private Sub add_truck_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If cek = True Then
                Dim msg As Integer = MessageBox.Show("Apakah anda yakin ingin menutup form ini? Semua data yang belum disimpan akan hilang", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If msg = DialogResult.OK Then
                    add_truck_Load(sender, e)
                    Reset()
                    data = DtTable("SELECT t.id_truk `Kode Truk`, t.no_pol `No Polisi`, t.no_mesin `No Mesin`, t.no_rangka `No Rangka`, s.nama_supplier `Nama Supplier`, t.harga_beli `Harga Beli`, t.umur_default `Umur Default`, t.nilai_residu `Nilai Residu`, a.nama_akun `Akun Aktiva`, p.nama_akun `Akun Penyusutan`, d.nama_akun `Akun Depresiasi` , tgl_beli `Tanggal Beli` from mtruk t, makun a, makun d, makun p, msupplier s where t.id_supplier = s.id_supplier and t.id_akun_akt = a.kode_akun and t.id_akun_depresiasi = d.kode_akun and t.id_akun_penyusutan = p.kode_akun and t.`s`='1'")
                    master_truck.GridControl1.DataSource = data
                    master_truck.GridControl1.Visible = True
                    master_truck.GridControl2.Visible = False
                    master_truck.GroupControl2.Enabled = True
                    master_truck.deldata.Down = False
                    master_truck.hapus.Visible = False
                    master_truck.editing.Visible = False
                    master_truck.edit.Down = False
                Else
                    e.Cancel = True
                End If
            Else
                add_truck_Load(sender, e)
                data = DtTable("SELECT t.id_truk `Kode Truk`, t.no_pol `No Polisi`, t.no_mesin `No Mesin`, t.no_rangka `No Rangka`, s.nama_supplier `Nama Supplier`, t.harga_beli `Harga Beli`, t.umur_default `Umur Default`, t.nilai_residu `Nilai Residu`, a.nama_akun `Akun Aktiva`, p.nama_akun `Akun Penyusutan`, d.nama_akun `Akun Depresiasi` , tgl_beli `Tanggal Beli` from mtruk t, makun a, makun d, makun p, msupplier s where t.id_supplier = s.id_supplier and t.id_akun_akt = a.kode_akun and t.id_akun_depresiasi = d.kode_akun and t.id_akun_penyusutan = p.kode_akun and t.`s`='1'")
                master_truck.GridControl1.DataSource = data
                master_truck.GridControl1.Visible = True
                master_truck.GridControl2.Visible = False
                master_truck.GroupControl2.Enabled = True
                master_truck.deldata.Down = False
                master_truck.hapus.Visible = False
                master_truck.editing.Visible = False
                master_truck.edit.Down = False
                Reset()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        If nop.Text = "" Or nomesin.Text = "" Or norangka.Text = "" Or hargabeli.Text = "" Or nilairesidu.Text = "" Or umur.Text = "" Then
            MessageBox.Show("Mohon lengkapi data terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try
                'insert ke dalam database
                'MsgBox(aktiva.SelectedValue.ToString)
                Dim penampung As String = "insert into mtruk values ('" & id.Text & "','" & nop.Text & "','" & nomesin.Text & "','" & norangka.Text & "" & "','" & Cmbbxsupp.SelectedValue.ToString & "','" & hargabeli.Text & "','" & umur.Text & "','" & nilairesidu.Text & "','" & aktiva.SelectedValue.ToString & "','" & penyusutan.SelectedValue.ToString & "','" & depresiasi.SelectedValue.ToString & "','" & DateTimePicker1.Value.ToString("yyyyMMdd") & "','1') "
                'MsgBox(penampung)
                InsertInto(penampung)
                Dim pnmpungharga As Double = (CInt(hargabeli.Text) - CInt(nilairesidu.Text)) / CInt(umur.Text)

                If DateTimePicker1.Value.ToString("MM") = "01" Then
                    Dim nilaibuku As Double = CInt(hargabeli.Text)
                    For i = 0 To CInt(umur.Text) - 1
                        nilaibuku = nilaibuku - pnmpungharga
                        Dim tglakhir As Integer = CInt(DateTimePicker1.Value.ToString("yyyy")) + CInt(i)
                        Dim inserting As String = "insert into kartu_aktiva values ('" & id.Text & "','January " & tglakhir.ToString & "- December " & tglakhir.ToString & "', '" & pnmpungharga.ToString & "','" & nilaibuku.ToString & "') "
                        InsertInto(inserting)
                    Next
                Else
                    Dim penghitung As Integer = 0
                    For i = CInt(DateTimePicker1.Value.ToString("MM")) To 12
                        penghitung = penghitung + 1
                    Next

                    Dim nilaipertama As Double = (penghitung / 12) * pnmpungharga
                    Dim nilaibuku2 As Double = CInt(hargabeli.Text) - nilaipertama
                    'MsgBox(nilaipertama)
                    Dim masukan As String = "insert into kartu_aktiva values ('" & id.Text & "','" & DateTimePicker1.Value.ToString("MMMM yyyy") & "- December " & DateTimePicker1.Value.ToString("yyyy") & "', '" & nilaipertama.ToString & "','" & nilaibuku2.ToString & "') "
                    InsertInto(masukan)


                    For i = 1 To CInt(umur.Text) - 1
                        nilaibuku2 = nilaibuku2 - pnmpungharga
                        Dim tglakhir As Integer = CInt(DateTimePicker1.Value.ToString("yyyy")) + CInt(i)
                        Dim inserting As String = "insert into kartu_aktiva values ('" & id.Text & "','January " & tglakhir.ToString & "- December " & tglakhir.ToString & "', '" & pnmpungharga.ToString & "','" & nilaibuku2.ToString & "') "
                        InsertInto(inserting)
                    Next

                    Dim nilaiterakhir As Double = pnmpungharga - nilaipertama
                    nilaibuku2 = nilaibuku2 - nilaiterakhir
                    Dim tanggalnya As Integer = CInt(DateTimePicker1.Value.ToString("yyyy")) + CInt(umur.Text)
                    Dim masukan2 As String = "insert into kartu_aktiva values ('" & id.Text & "','January " & tanggalnya.ToString & "- " & DateTimePicker1.Value.ToString("MMMM") & " " & tanggalnya.ToString & "', '" & nilaiterakhir.ToString & "','" & nilaibuku2.ToString & "') "
                    InsertInto(masukan2)

                End If
                'konfirmasi melakukan booking ulang
                Dim msg As Integer = MsgBox("Booking berhasil dilakukan, Apakah anda ingin melakukan input kembali?", MsgBoxStyle.YesNo, "System Message")
                If msg = DialogResult.Yes Then
                    add_truck_Load(sender, e)
                    Reset()
                Else
                    cek = False
                    data = DtTable("SELECT t.id_truk `Kode Truk`, t.no_pol `No Polisi`, t.no_mesin `No Mesin`, t.no_rangka `No Rangka`, s.nama_supplier `Nama Supplier`, t.harga_beli `Harga Beli`, t.umur_default `Umur Default`, t.nilai_residu `Nilai Residu`, a.nama_akun `Akun Aktiva`, p.nama_akun `Akun Penyusutan`, d.nama_akun `Akun Depresiasi` , tgl_beli `Tanggal Beli` from mtruk t, makun a, makun d, makun p, msupplier s where t.id_supplier = s.id_supplier and t.id_akun_akt = a.kode_akun and t.id_akun_depresiasi = d.kode_akun and t.id_akun_penyusutan = p.kode_akun and t.`s`='1'")
                    master_truck.GridControl1.DataSource = data
                    master_truck.GridControl1.Visible = True
                    master_truck.GridControl2.Visible = False
                    master_truck.GroupControl2.Enabled = True
                    master_truck.deldata.Down = False
                    master_truck.hapus.Visible = False
                    master_truck.editing.Visible = False
                    master_truck.edit.Down = False
                    Me.Close()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub hargabeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles hargabeli.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub nilairesidu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nilairesidu.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub umur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles umur.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub


    Private Sub add_truck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            umur.Text = "5"
            nop.Text = ""
            nomesin.Text = ""
            norangka.Text = ""
            hargabeli.Text = ""
            nilairesidu.Text = ""
            DateTimePicker1.Text = Now()

            cbsupplier = DtTable("select id_supplier `Kode Supplier`,nama_supplier `Nama Supplier` from msupplier where `s` = 1")
            Cmbbxsupp.DataSource = cbsupplier
            Cmbbxsupp.DisplayMember = "Nama Supplier"
            Cmbbxsupp.ValueMember = "Kode Supplier"

            cbaktv = DtTable("select kode_akun, nama_akun from makun where detil = '1'")
            aktiva.DataSource = cbaktv
            aktiva.DisplayMember = "nama_akun"
            aktiva.ValueMember = "kode_akun"

            cbdpresiasi = DtTable("select kode_akun, nama_akun from makun where detil = '1'")
            depresiasi.DataSource = cbdpresiasi
            depresiasi.DisplayMember = "nama_akun"
            depresiasi.ValueMember = "kode_akun"

            cbpenystn = DtTable("select kode_akun, nama_akun from makun where detil = '1'")
            penyusutan.DataSource = cbpenystn
            penyusutan.DisplayMember = "nama_akun"
            penyusutan.ValueMember = "kode_akun"

            Dim tanggal As New DataTable
            Dim tgl As String = "MT"
            tanggal = DtTable("select * from mtruk where substring(id_truk,1,2) = '" & tgl & "'")
            Dim hitung As String = tanggal.Rows.Count() + 1
            While hitung.LongCount < 5
                hitung = "0" + hitung
            End While
            id.Text = tgl + hitung
        Catch ex As Exception

        End Try

    End Sub



End Class