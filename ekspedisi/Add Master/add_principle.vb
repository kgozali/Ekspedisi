Imports MySql.Data.MySqlClient
Public Class add_principle
    Dim cek As Boolean
    Private Sub cancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs)
        Try
            'insert ke dalam database
            InsertInto("insert into mprinciple values ('" & id.Text & "','" & nama.Text & "','" & alamat.Text & "','" & email.Text & "','" & tel1.Text & "','" & tel2.Text & "','" & provinsi.Text & "','" & kota.Text & "')) ")
            'konfirmasi melakukan booking ulang
            Dim msg As Integer = MsgBox("Booking berhasil dilakukan, Apakah anda ingin melakukan input kembali?", MsgBoxStyle.YesNo, "System Message")
            If msg = DialogResult.Yes Then
                add_principle_Load(sender, e)
                Reset()
            Else
                cek = False
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub add_principle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        nama.Text = ""
        alamat.Text = ""
        email.Text = ""
        tel1.Text = ""
        tel2.Text = ""
        provinsi.Text = ""
        kota.Text = ""
    End Sub

    Private Sub nama_TextChanged(sender As Object, e As EventArgs)
        'pengecekan untuk mengetahui apakah form sudah di edit atau belum (jika belum, untuk menghindari system warning pertanyaan)
        If nama.Text = "" Then
            cek = False
        Else
            cek = True
        End If
    End Sub
End Class