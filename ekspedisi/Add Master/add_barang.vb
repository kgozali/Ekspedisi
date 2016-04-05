Imports MySql.Data.MySqlClient
Public Class add_barang
    Dim cbprinciple As New DataTable
    Dim cek As Boolean
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Try
            'insert ke dalam database
            InsertInto("insert into mbarang values ('" & id.Text & "','" & nama.Text & "','" & principle.Text & "','" & notes.Text & "')) ")
            'konfirmasi melakukan booking ulang
            Dim msg As Integer = MsgBox("Booking berhasil dilakukan, Apakah anda ingin melakukan input kembali?", MsgBoxStyle.YesNo, "System Message")
            If msg = DialogResult.Yes Then
                add_barang_Load(sender, e)
                Reset()
            Else
                cek = False
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub add_barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbprinciple = DtTable("select id_principle `Kode Principle`,nama_principle `Nama Principle` from mprinciple")
        principle.DataSource = cbprinciple
        principle.DisplayMember = "Nama Principle"
        principle.ValueMember = "Kode Principle"

    End Sub

    Private Sub notes_TextChanged(sender As Object, e As EventArgs) Handles notes.TextChanged
        'pengecekan untuk mengetahui apakah form sudah di edit atau belum (jika belum, untuk menghindari system warning pertanyaan)
        If notes.Text = "" Then
            cek = False
        Else
            cek = True
        End If
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