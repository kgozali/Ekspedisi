Imports MySql.Data.MySqlClient
Public Class add_kota
    Dim cek As Boolean
    Dim data As New DataTable
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        master_kota.GridControl1.Visible = True
        master_kota.GridControl2.Visible = False
        data = DtTable("SELECT b.kota `Nama Kota`, b.provinsi `Nama Provinsi` from mkota b where b.`s`='1'")
        master_kota.GridControl1.DataSource = data
        master_kota.edit.Down = False
        master_kota.deldata.Down = False
        master_kota.editing.Visible = False
        master_kota.hapus.Visible = False
        master_kota.GroupControl2.Enabled = True
        Me.Close()
    End Sub

    Private Sub add_kota_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If cek = True Then
                Dim msg As Integer = MessageBox.Show("Apakah anda yakin ingin menutup form ini? Semua data yang belum disimpan akan hilang", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If msg = DialogResult.OK Then
                    add_kota_Load(sender, e)
                    Reset()
                    master_kota.GridControl1.Visible = True
                    master_kota.GridControl2.Visible = False
                    data = DtTable("SELECT b.kota `Nama Kota`, b.provinsi `Nama Provinsi` from mkota b where b.`s`='1'")
                    master_kota.GridControl1.DataSource = data
                    master_kota.edit.Down = False
                    master_kota.deldata.Down = False
                    master_kota.editing.Visible = False
                    master_kota.hapus.Visible = False
                    master_kota.GroupControl2.Enabled = True
                    Me.Close()
                Else
                    e.Cancel = True
                End If
            Else
                add_kota_Load(sender, e)
                master_kota.GridControl1.Visible = True
                master_kota.GridControl2.Visible = False
                data = DtTable("SELECT b.kota `Nama Kota`, b.provinsi `Nama Provinsi` from mkota b where b.`s`='1'")
                master_kota.GridControl1.DataSource = data
                master_kota.edit.Down = False
                master_kota.deldata.Down = False
                master_kota.editing.Visible = False
                master_kota.hapus.Visible = False
                master_kota.GroupControl2.Enabled = True
                Reset()
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Try
            'insert ke dalam database
            InsertInto("insert into mkota values ('','" & provinsi.Text & "','" & kota.Text & "','1') ")
            'konfirmasi melakukan Input ulang
            audit()
            Dim msg As Integer = MsgBox("Input berhasil dilakukan, Apakah anda ingin melakukan input kembali?", MsgBoxStyle.YesNo, "System Message")
            If msg = DialogResult.Yes Then
                add_kota_Load(sender, e)
                Reset()
            Else
                cek = False
                master_kota.GridControl1.Visible = True
                master_kota.GridControl2.Visible = False
                data = DtTable("SELECT b.kota `Nama Kota`, b.provinsi `Nama Provinsi` from mkota b where b.`s`='1'")
                master_kota.GridControl1.DataSource = data
                master_kota.edit.Down = False
                master_kota.deldata.Down = False
                master_kota.editing.Visible = False
                master_kota.hapus.Visible = False
                master_kota.GroupControl2.Enabled = True
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Master Kota"
        Dim aktivitas As String = "Add Kota: " & kota.Text.ToString
        auditlog(user, kompname, form, aktivitas)
    End Sub

    Private Sub add_kota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kota.Text = ""
        provinsi.Text = ""
    End Sub

    Private Sub nama_TextChanged(sender As Object, e As EventArgs)
        'pengecekan untuk mengetahui apakah form sudah di edit atau belum (jika belum, untuk menghindari system warning pertanyaan)
        If kota.Text = "" Then
            cek = False
        Else
            cek = True
        End If
    End Sub

End Class