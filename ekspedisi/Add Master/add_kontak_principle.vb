Imports MySql.Data.MySqlClient
Public Class add_kontak_principle
    Dim data As New DataTable
    Dim cek As Boolean
    Dim cbprinciple As New DataTable

    Private Sub add_kontak_principle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tanggal As New DataTable
        Dim tgl As String = "MO"
        tanggal = DtTable("select * from mkontakprinciple where substring(ID_Kontak,1,2) = '" & tgl & "'")
        Dim hitung As String = tanggal.Rows.Count() + 1
        While hitung.LongCount < 5
            hitung = "0" + hitung
        End While

        cbprinciple = DtTable("select id_principle `Kode Principle`,nama_principle `Nama Principle` from mprinciple")
        principle.DataSource = cbprinciple
        principle.DisplayMember = "Nama Principle"
        principle.ValueMember = "Kode Principle"

        id.Text = tgl + hitung
        nama.Text = ""
        tel1.Text = ""
        tel2.Text = ""
    End Sub
    Private Sub tel1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tel1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub
    Private Sub tel2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tel2.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub add_Kontak_Principle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If cek = True Then
                Dim msg As Integer = MessageBox.Show("Apakah anda yakin ingin menutup form ini? Semua data yang belum disimpan akan hilang", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If msg = DialogResult.OK Then
                    add_kontak_principle_Load(sender, e)
                    master_kontak_principle.GridControl1.Visible = True
                    master_kontak_principle.GridControl2.Visible = False
                    data = DtTable("SELECT id_Kontak `Kode Kontak Principle`, Nama_Kontak_Principle `Nama Kontak`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mkontakprinciple b where b.`s`='1'")
                    master_kontak_principle.GridControl1.DataSource = data
                    master_kontak_principle.edit.Down = False
                    master_kontak_principle.deldata.Down = False
                    Reset()
                Else
                    e.Cancel = True
                End If
            Else
                add_Kontak_Principle_Load(sender, e)
                Reset()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click

        If nama.Text = "" Or email.Text = "" Or tel1.Text = "" Then
            MessageBox.Show("Mohon lengkapi data terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                'insert ke dalam database
                InsertInto("insert into mkontakprinciple values ('" & id.Text & "','" & principle.SelectedValue.ToString & "','" & nama.Text & "','" & tel1.Text & "','" & tel2.Text & "','" & email.Text & "','1') ")
                'konfirmasi melakukan booking ulang
                Dim msg As Integer = MsgBox("Booking berhasil dilakukan, Apakah anda ingin melakukan input kembali?", MsgBoxStyle.YesNo, "System Message")
                If msg = DialogResult.Yes Then
                    add_kontak_principle_Load(sender, e)
                    Reset()
                Else
                    cek = False

                    master_kontak_principle.GridControl1.Visible = True
                    master_kontak_principle.GridControl2.Visible = False
                    data = DtTable("SELECT b.id_kontak `Kode Kontak`,p.nama_principle `Nama Principle`, b.nama_kontak `Nama Kontak`, b.tel1 `Telepon 1`, b.tel2 `Telepon 2`, b.Email `Email` from mkontakprinciple b, mprinciple p  where p.id_principle = b.id_principle and b.`s`='1'")
                    master_kontak_principle.GridControl1.DataSource = data
                    master_kontak_principle.edit.Down = False
                    master_kontak_principle.deldata.Down = False
                    Me.Close()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End If
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        master_kontak_principle.GridControl1.Visible = True
        master_kontak_principle.GridControl2.Visible = False
        data = DtTable("SELECT id_Kontak `Kode Kontak Principle`, Nama_Kontak_Principle `Nama Kontak`, Alamat, Email,tel1 `Telepon 1`,tel2 `Telepon 2`,Kota, Provinsi from mKontakPrinciple b where b.`s`='1'")
        master_kontak_principle.GridControl1.DataSource = data
        master_kontak_principle.deldata.Down = False
        master_kontak_principle.deldata.Down = True
        Me.Close()
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
End Class