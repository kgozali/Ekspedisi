Imports MySql.Data.MySqlClient
Public Class add_rute
    Dim cek As Boolean
    Dim cbasal As New DataTable
    Dim ctujuan As New DataTable
    Dim cbprinciple As New DataTable
    Dim data As New DataTable
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        master_rute.GroupControl2.Enabled = True
        master_rute.GridControl1.Visible = True
        master_rute.GridControl2.Visible = False
        master_rute.hapus.Visible = False
        master_rute.editing.Visible = False
        master_rute.edit.Down = False
        master_rute.deldata.Down = False


        data = DtTable("SELECT s.id_rute `Kode Rute`, s.kota_asal `Kota Asal`, s.kota_tujuan `Kota Tujuan`,p.nama_principle `Nama Principle`, s.price_per_unit `Price Per Unit`, s.unit `Unit` from mrute s, mprinciple p where s.id_principle = p.id_principle and s.`s`='1'")
        master_rute.GridControl1.DataSource = data
        Me.Close()
    End Sub

    Private Sub add_rute_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If cek = True Then
                Dim msg As Integer = MessageBox.Show("Apakah anda yakin ingin menutup form ini? Semua data yang belum disimpan akan hilang", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If msg = DialogResult.OK Then
                    add_rute_Load(sender, e)
                    master_rute.GroupControl2.Enabled = True
                    master_rute.GridControl1.Visible = True
                    master_rute.GridControl2.Visible = False
                    master_rute.hapus.Visible = False
                    master_rute.editing.Visible = False
                    master_rute.edit.Down = False
                    master_rute.deldata.Down = False


                    data = DtTable("SELECT s.id_rute `Kode Rute`, s.kota_asal `Kota Asal`, s.kota_tujuan `Kota Tujuan`,p.nama_principle `Nama Principle`, s.price_per_unit `Price Per Unit`, s.unit `Unit` from mrute s, mprinciple p where s.id_principle = p.id_principle and s.`s`='1'")
                    master_rute.GridControl1.DataSource = data
                    Reset()
                Else
                    e.Cancel = True
                End If
            Else
                add_rute_Load(sender, e)
                master_rute.GroupControl2.Enabled = True
                master_rute.GridControl1.Visible = True
                master_rute.GridControl2.Visible = False
                master_rute.hapus.Visible = False
                master_rute.editing.Visible = False
                master_rute.edit.Down = False
                master_rute.deldata.Down = False


                data = DtTable("SELECT s.id_rute `Kode Rute`, s.kota_asal `Kota Asal`, s.kota_tujuan `Kota Tujuan`,p.nama_principle `Nama Principle`, s.price_per_unit `Price Per Unit`, s.unit `Unit` from mrute s, mprinciple p where s.id_principle = p.id_principle and s.`s`='1'")
                master_rute.GridControl1.DataSource = data
                Reset()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        If hargaunit.Text = "" Or unit.Text = "" Then
            MessageBox.Show("Mohon lengkapi data terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim cc As New DataTable
            cc = DtTable("select * from mrute where kota_asal = '" & asal.SelectedValue.ToString & "' and kota_tujuan = '" & tujuan.SelectedValue.ToString & "'")
            If cc.Rows.Count = 0 Then
                Try
                    'insert ke dalam database
                    InsertInto("insert into mrute values ('" & id.Text & "','" & asal.SelectedValue.ToString & "','" & tujuan.SelectedValue.ToString & "','" & principle.SelectedValue.ToString & "','" & hargaunit.Text & "','" & unit.Text & "','1') ")
                    'konfirmasi melakukan booking ulang
                    Dim msg As Integer = MsgBox("Booking berhasil dilakukan, Apakah anda ingin melakukan input kembali?", MsgBoxStyle.YesNo, "System Message")
                    If msg = DialogResult.Yes Then
                        add_rute_Load(sender, e)
                        Reset()
                    Else
                        cek = False
                        master_rute.GroupControl2.Enabled = True
                        master_rute.GridControl1.Visible = True
                        master_rute.GridControl2.Visible = False
                        master_rute.hapus.Visible = False
                        master_rute.editing.Visible = False

                        Data = DtTable("SELECT s.id_rute `Kode Rute`, s.kota_asal `Kota Asal`, s.kota_tujuan `Kota Tujuan`,p.nama_principle `Nama Principle`, s.price_per_unit `Price Per Unit`, s.unit `Unit` from mrute s, mprinciple p where s.id_principle = p.id_principle and s.`s`='1'")
                        master_rute.GridControl1.DataSource = Data
                        Me.Close()
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Kota Asal dan Tujuan tidak boleh sama", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        End If



    End Sub

    Private Sub add_rute_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tanggal As New DataTable
        Dim tgl As String = "MR"
        tanggal = DtTable("select * from mrute where substring(ID_rute,1,2) = '" & tgl & "'")
        Dim hitung As String = tanggal.Rows.Count() + 1
        While hitung.LongCount < 5
            hitung = "0" + hitung
        End While
        id.Text = tgl + hitung

        cbasal = DtTable("select kota from mkota")
        asal.DataSource = cbasal
        asal.DisplayMember = "Kota"
        asal.ValueMember = "Kota"
        ctujuan = DtTable("select kota from mkota")
        tujuan.DataSource = ctujuan
        tujuan.DisplayMember = "Kota"
        tujuan.ValueMember = "Kota"

        cbprinciple = DtTable("select id_principle `Kode Principle`,nama_principle `Nama Principle` from mprinciple")
        principle.DataSource = cbprinciple
        principle.DisplayMember = "Nama Principle"
        principle.ValueMember = "Kode Principle"
        unit.Text = ""
        hargaunit.Text = ""

    End Sub


    Private Sub hargaunit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles hargaunit.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
        'pengecekan untuk mengetahui apakah form sudah di edit atau belum (jika belum, untuk menghindari system warning pertanyaan)
        If hargaunit.Text = "" Then
            cek = False
        Else
            cek = True
        End If
    End Sub


End Class