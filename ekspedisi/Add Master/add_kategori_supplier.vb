Imports MySql.Data.MySqlClient
Public Class add_kategori_supplier
    Dim cek As Boolean
    Dim data As New DataTable
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        data = DtTable("SELECT id_kategori `Kode Kategori Supplier`, b.kategori_supplier `Nama Kategori Supplier` from mkategori_supplier b where b.`s`='1'")
        master_kategori_supplier.GridControl1.DataSource = data
        master_kategori_supplier.GridControl1.Visible = True
        data = DtTable("SELECT id_kategori `Kode Kategori Supplier`, b.kategori_supplier `Nama Kategori Supplier` from mkategori_supplier b where b.`s`='1'")
        master_kategori_supplier.GridControl2.DataSource = data
        master_kategori_supplier.GridControl2.Visible = False
        master_kategori_supplier.deldata.Down = False
        master_kategori_supplier.hapus.Visible = False
        master_kategori_supplier.edit.Down = False
        master_kategori_supplier.editing.Visible = False

        Me.Close()
    End Sub

    Private Sub add_kategori_supplier_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If cek = True Then
                Dim msg As Integer = MessageBox.Show("Apakah anda yakin ingin menutup form ini? Semua data yang belum disimpan akan hilang", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If msg = DialogResult.OK Then
                    add_kategori_supplier_Load(sender, e)
                    Reset()
                    data = DtTable("SELECT id_kategori `Kode Kategori Supplier`, b.kategori_supplier `Nama Kategori Supplier` from mkategori_supplier b where b.`s`='1'")
                    master_kategori_supplier.GridControl1.DataSource = data
                    master_kategori_supplier.GridControl1.Visible = True
                    data = DtTable("SELECT id_kategori `Kode Kategori Supplier`, b.kategori_supplier `Nama Kategori Supplier` from mkategori_supplier b where b.`s`='1'")
                    master_kategori_supplier.GridControl2.DataSource = data
                    master_kategori_supplier.GridControl2.Visible = False
                    master_kategori_supplier.deldata.Down = False
                    master_kategori_supplier.hapus.Visible = False
                    master_kategori_supplier.edit.Down = False
                    master_kategori_supplier.editing.Visible = False
                Else
                    e.Cancel = True
                End If
            Else
                add_kategori_supplier_Load(sender, e)
                data = DtTable("SELECT id_kategori `Kode Kategori Supplier`, b.kategori_supplier `Nama Kategori Supplier` from mkategori_supplier b where b.`s`='1'")
                master_kategori_supplier.GridControl1.DataSource = data
                master_kategori_supplier.GridControl1.Visible = True
                data = DtTable("SELECT id_kategori `Kode Kategori Supplier`, b.kategori_supplier `Nama Kategori Supplier` from mkategori_supplier b where b.`s`='1'")
                master_kategori_supplier.GridControl2.DataSource = data
                master_kategori_supplier.GridControl2.Visible = False
                master_kategori_supplier.deldata.Down = False
                master_kategori_supplier.hapus.Visible = False
                master_kategori_supplier.edit.Down = False
                master_kategori_supplier.editing.Visible = False
                Reset()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        If nama.Text = "" Then
            MessageBox.Show("Mohon lengkapi data terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                'insert ke dalam database
                InsertInto("insert into mkategori_supplier values ('" & id.Text & "','" & nama.Text & "','1') ")
                'konfirmasi melakukan booking ulang
                Dim msg As Integer = MsgBox("Booking berhasil dilakukan, Apakah anda ingin melakukan input kembali?", MsgBoxStyle.YesNo, "System Message")
                If msg = DialogResult.Yes Then
                    add_kategori_supplier_Load(sender, e)
                    Reset()
                Else
                    cek = False
                    data = DtTable("SELECT id_kategori `Kode Kategori Supplier`, b.kategori_supplier `Nama Kategori Supplier` from mkategori_supplier b where b.`s`='1'")
                    master_kategori_supplier.GridControl1.DataSource = data
                    master_kategori_supplier.GridControl1.Visible = True
                    data = DtTable("SELECT id_kategori `Kode Kategori Supplier`, b.kategori_supplier `Nama Kategori Supplier` from mkategori_supplier b where b.`s`='1'")
                    master_kategori_supplier.GridControl2.DataSource = data
                    master_kategori_supplier.GridControl2.Visible = False
                    master_kategori_supplier.deldata.Down = False
                    master_kategori_supplier.hapus.Visible = False
                    master_kategori_supplier.edit.Down = False
                    master_kategori_supplier.editing.Visible = False
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
        Dim form As String = "Master Kategori"
        Dim aktivitas As String = "Add Kategori: " & id.Text.ToString
        auditlog(user, kompname, form, aktivitas)
    End Sub
    Private Sub add_kategori_supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tanggal As New DataTable
        Dim tgl As String = "ME"
        tanggal = DtTable("select * from mkategori_supplier where substring(id_kategori,1,2) = '" & tgl & "'")
        Dim hitung As String = tanggal.Rows.Count() + 1
        While hitung.LongCount < 5
            hitung = "0" + hitung
        End While
        id.Text = tgl + hitung

        nama.Text = ""
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