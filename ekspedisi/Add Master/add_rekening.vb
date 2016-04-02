Imports MySql.Data.MySqlClient
Public Class add_rekening
    Dim inputrekening As String = ""
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        inputrekening = "insert into mrekening values ('" & id.Text & "', '" & nama.Text & "')"
        InsertInto(inputrekening)
        MsgBox("Data Telah Terinput!")
        add_rekening_Load(sender, e)
    End Sub

    Private Sub add_rekening_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id.Text = ""
        nama.Text = ""
    End Sub
End Class