Imports MySql.Data.MySqlClient
Public Class add_rute
    Dim cek As Boolean
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Try
            'insert ke dalam database
            InsertInto("insert into mrute values ('" & id.Text & "','" & kotaasal.Text & "','" & kotatujuan.Text & "','" & kotatujuan.Text & "','" & hargaunit.Text & "','" & unit.Text & "')) ")
            'konfirmasi melakukan booking ulang
            Dim msg As Integer = MsgBox("Booking berhasil dilakukan, Apakah anda ingin melakukan input kembali?", MsgBoxStyle.YesNo, "System Message")
            If msg = DialogResult.Yes Then
                add_rute_Load(sender, e)
                Reset()
            Else
                cek = False
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub add_rute_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        kotaasal.Text = ""
        kotatujuan.Text = ""
        unit.Text = ""
        hargaunit.Text = ""

    End Sub

    Private Sub kotaasal_TextChanged(sender As Object, e As EventArgs) Handles kotaasal.TextChanged
        'pengecekan untuk mengetahui apakah form sudah di edit atau belum (jika belum, untuk menghindari system warning pertanyaan)
        If kotaasal.Text = "" Then
            cek = False
        Else
            cek = True
        End If
    End Sub

    Private Sub kotatujuan_TextChanged(sender As Object, e As EventArgs) Handles kotatujuan.TextChanged
        'pengecekan untuk mengetahui apakah form sudah di edit atau belum (jika belum, untuk menghindari system warning pertanyaan)
        If kotatujuan.Text = "" Then
            cek = False
        Else
            cek = True
        End If
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

    Private Sub unit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles unit.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
        'pengecekan untuk mengetahui apakah form sudah di edit atau belum (jika belum, untuk menghindari system warning pertanyaan)
        If unit.Text = "" Then
            cek = False
        Else
            cek = True
        End If
    End Sub
End Class