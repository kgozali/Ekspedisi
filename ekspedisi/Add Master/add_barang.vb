Imports MySql.Data.MySqlClient
Public Class add_barang
    Dim cbprinciple As New DataTable
    Dim cek As Boolean = False
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub
    Private Sub add_barang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try

            If DataSet1.Tables("Table1").Rows.Count() = 0 Then
                cek = False
            Else
                cek = True
            End If

            If cek = True Then
                Dim msg As Integer = MessageBox.Show("Apakah anda yakin ingin menutup form ini? Semua data yang belum disimpan akan hilang", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If msg = DialogResult.OK Then
                    add_barang_Load(sender, e)
                    DataTable1.Rows.Clear()
                    Reset()
                Else
                    e.Cancel = True
                End If
            Else
                add_barang_Load(sender, e)
                DataTable1.Rows.Clear()
                Reset()
            End If
        Catch ex As Exception

        End Try
    End Sub
    'Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
    '    If nama.Text = "" Or principle.Text = "" Or notes.Text = "" Then
    '        MessageBox.Show("Mohon lengkapi data terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Else
    '        Try
    '            'insert ke dalam database
    '            InsertInto("insert into mbarang values ('" & id.Text & "','" & nama.Text & "','" & principle.SelectedValue.ToString & "','" & notes.Text & "') ")
    '            'konfirmasi melakukan booking ulang
    '            Dim msg As Integer = MsgBox("Booking berhasil dilakukan, Apakah anda ingin melakukan input kembali?", MsgBoxStyle.YesNo, "System Message")
    '            If msg = DialogResult.Yes Then
    '                add_barang_Load(sender, e)
    '                Reset()
    '            Else
    '                cek = False
    '                Me.Close()
    '            End If

    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End If

    'End Sub

    'Private Sub add_barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    cbprinciple = DtTable("select id_principle `Kode Principle`,nama_principle `Nama Principle` from mprinciple")
    '    principle.DataSource = cbprinciple
    '    principle.DisplayMember = "Nama Principle"
    '    principle.ValueMember = "Kode Principle"
    '    'sourcecode

    '    Dim tanggal As New DataTable
    '    Dim tgl As String = "MB"
    '    tanggal = DtTable("select * from mbarang where substring(ID_Barang,1,10) = '" & tgl & "'")
    '    Dim hitung As String = tanggal.Rows.Count() + 1
    '    While hitung.LongCount < 5
    '        hitung = "0" + hitung
    '    End While
    '    id.Text = tgl + hitung

    '    nama.Text = ""
    '    notes.Text = ""
    'End Sub

    'Private Sub notes_TextChanged(sender As Object, e As EventArgs)
    '    'pengecekan untuk mengetahui apakah form sudah di edit atau belum (jika belum, untuk menghindari system warning pertanyaan)
    '    If notes.Text = "" Then
    '        cek = False
    '    Else
    '        cek = True
    '    End If
    'End Sub


    'Private Sub nama_TextChanged(sender As Object, e As EventArgs)
    '    'pengecekan untuk mengetahui apakah form sudah di edit atau belum (jika belum, untuk menghindari system warning pertanyaan)
    '    If nama.Text = "" Then
    '        cek = False
    '    Else
    '        cek = True
    '    End If
    'End Sub


    Private Sub add_barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbprinciple = DtTable("select id_principle `Kode Principle`,nama_principle `Nama Principle` from mprinciple")
        principle.DataSource = cbprinciple
        principle.DisplayMember = "Nama Principle"
        principle.ValueMember = "Kode Principle"
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Try
            Dim i As Long
            Dim dtbaris As DataRow
            For i = 0 To DataSet1.Tables("Table1").Rows.Count - 1
                dtbaris = DataSet1.Tables("Table1").Rows(i)
                Dim tanggal As New DataTable
                Dim tgl As String = "MB"
                tanggal = DtTable("select * from mbarang where substring(ID_Barang,1,10) = '" & tgl & "'")
                Dim hitung As String = tanggal.Rows.Count() + 1
                While hitung.LongCount < 5
                    hitung = "0" + hitung
                End While
                Dim ccc As String = tgl + hitung
                InsertInto("insert into mbarang values('" & ccc & "','" & dtbaris("Nama Barang") & "','" & principle.SelectedValue.ToString & "','" & dtbaris("Keterangan") & "','1')")
                MsgBox(dtbaris("Keterangan"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       


    End Sub
End Class