Imports MySql.Data.MySqlClient
Public Class add_jabatan
    Dim cek As Boolean
    Dim data As New DataTable

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        master_jabatan.GridControl1.Visible = True
        master_jabatan.GridControl2.Visible = False
        data = DtTable("SELECT id_jabatan `Kode Jabatan`, b.nama_jabatan `Nama Jabatan` from mjabatan b where b.`s`='1'")
        master_jabatan.GridControl1.DataSource = data
        master_jabatan.edit.Down = False
        master_jabatan.deldata.Down = False
        master_jabatan.editing.Visible = False
        master_jabatan.hapus.Visible = False
        master_jabatan.GroupControl2.Enabled = True

        Me.Close()
    End Sub

    Private Sub add_jabatan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If cek = True Then
                Dim msg As Integer = MessageBox.Show("Apakah anda yakin ingin menutup form ini? Semua data yang belum disimpan akan hilang", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If msg = DialogResult.OK Then
                    add_jabatan_Load(sender, e)
                    master_jabatan.GridControl1.Visible = True
                    master_jabatan.GridControl2.Visible = False
                    data = DtTable("SELECT id_jabatan `Kode Jabatan`, b.nama_jabatan `Nama Jabatan` from mjabatan b where b.`s`='1'")
                    master_jabatan.GridControl1.DataSource = data
                    master_jabatan.edit.Down = False
                    master_jabatan.deldata.Down = False
                    master_jabatan.editing.Visible = False
                    master_jabatan.hapus.Visible = False
                    master_jabatan.GroupControl2.Enabled = True
                    Reset()
                Else
                    e.Cancel = True
                End If
            Else
                add_jabatan_Load(sender, e)
                master_jabatan.GridControl1.Visible = True
                master_jabatan.GridControl2.Visible = False
                data = DtTable("SELECT id_jabatan `Kode Jabatan`, b.nama_jabatan `Nama Jabatan` from mjabatan b where b.`s`='1'")
                master_jabatan.GridControl1.DataSource = data
                master_jabatan.edit.Down = False
                master_jabatan.deldata.Down = False
                master_jabatan.editing.Visible = False
                master_jabatan.hapus.Visible = False
                master_jabatan.GroupControl2.Enabled = True
                Reset()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Try
            Dim tanggal As New DataTable
            Dim tgl As String = "MJ"
            tanggal = DtTable("select * from mjabatan where substring(ID_jabatan,1,2) = '" & tgl & "'")
            Dim hitung As String = tanggal.Rows.Count() + 1
            While hitung.LongCount < 5
                hitung = "0" + hitung
            End While
            id.Text = tgl + hitung

            'insert ke dalam database
            InsertInto("insert into mjabatan values ('" & id.Text & "','" & nama.Text & "','1')")
            'konfirmasi melakukan booking ulang
            Dim msg As Integer = MsgBox("Booking berhasil dilakukan, Apakah anda ingin melakukan input kembali?", MsgBoxStyle.YesNo, "System Message")
            audit()
            If msg = DialogResult.Yes Then
                add_jabatan_Load(sender, e)
                Reset()
            Else
                master_jabatan.GridControl1.Visible = True
                master_jabatan.GridControl2.Visible = False
                data = DtTable("SELECT id_jabatan `Kode Jabatan`, b.nama_jabatan `Nama Jabatan` from mjabatan b where b.`s`='1'")
                master_jabatan.GridControl1.DataSource = data
                master_jabatan.edit.Down = False
                master_jabatan.deldata.Down = False
                master_jabatan.editing.Visible = False
                master_jabatan.hapus.Visible = False
                master_jabatan.GroupControl2.Enabled = True
                cek = False
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Master Jabatan"
        Dim aktivitas As String = "Add Jabatan: " & id.Text.ToString
        auditlog(user, kompname, form, aktivitas)
    End Sub

    Private Sub add_jabatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nama.Text = ""

        Dim tanggal As New DataTable
        Dim tgl As String = "MJ"
        tanggal = DtTable("select * from mjabatan where substring(ID_jabatan,1,2) = '" & tgl & "'")
        Dim hitung As String = tanggal.Rows.Count() + 1
        While hitung.LongCount < 5
            hitung = "0" + hitung
        End While
        id.Text = tgl + hitung
    End Sub

    Private Sub nama_TextChanged(sender As Object, e As EventArgs) Handles nama.TextChanged
        'pengecekan untuk mengetahui apakah form sudah di edit atau belum (jika belum, untuk menghindari system warning pertanyaan)
        If nama.Text = "" Then
            cek = False
        Else
            cek = True
        End If
    End Sub
End Class