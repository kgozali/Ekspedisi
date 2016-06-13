﻿Imports MySql.Data.MySqlClient
Imports System.IO
Public Class edit_kir_truk
    Dim query As New DataTable
    Dim nominal As Integer = 0
    Dim path As String = ""
    Dim kode As String = ""
    Dim kodekir As String = ""
    Dim trukbook As String = ""
    Dim akunkir As String = ""
    Dim akunkas As String = ""
    Private Sub edit_kir_truk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            query = DtTable("select * from kir where id_kir='" + TextEdit1.Text.ToString + "'")
            TextEdit2.Text = query.Rows(0).Item("no_kir").ToString
            kode = TextEdit1.Text.ToString
            TextEdit3.Text = query.Rows(0).Item("nominal")
            trukbook = query.Rows(0).Item("id_truk").ToString
            DateTimePicker2.Value = query.Rows(0).Item("tgl_kir")
            DateTimePicker1.Value = query.Rows(0).Item("tgl_kir_berikutnya")
            DateTimePicker3.Value = query.Rows(0).Item("tgl")

            If query.Rows(0).Item("imgfile").ToString = "" Then

            Else
                Dim arrpic() As Byte = CType(query.Rows(0).Item("imgfile"), Byte())
                If arrpic.Length > 0 Then
                    Dim ms As New MemoryStream(arrpic)
                    PictureEdit1.Image = Image.FromStream(ms)
                    ms.Close()
                Else

                End If
            End If

            Dim nopol As String = Scalar("select no_pol from mtruk where id_truk='" + trukbook + "'")
            ButtonEdit1.Text = nopol

            akunkir = Scalar("select id_akun from control_account where keterangan='Def. Akun KIR'")
            akunkas = Scalar("select id_akun from control_account where keterangan='Def. Akun Kas'")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub
    Sub reset()
        TextEdit2.Text = ""
        TextEdit3.Text = "0"
        trukbook = ""
        DateTimePicker1.ResetText()
        DateTimePicker2.ResetText()
        PictureEdit1.Text = ""
        ButtonEdit1.Text = ""
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            If TextEdit2.Text = "" Then
                MessageBox.Show("Harap mengisi No. KIR terlebih dahulu", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If trukbook = "" Then
                    MessageBox.Show("Harap memilih truk terlebih dahulu", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If DateTimePicker2.Value > DateTimePicker1.Value Then
                        MessageBox.Show("Tanggal KIR berikutnya wajib sesudah tanggal KIR yang ditentukan", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        If nominal = 0 Or Not IsNumeric(nominal) Then
                            MessageBox.Show("Nominal KIR Rp.0 , harap mengisi nominal KIR lebih dari Rp.0", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            If PictureEdit1.Text = "" Then
                                Dim msg As Integer = MessageBox.Show("Bukti KIR tidak ditemukan, apakah anda tetap ingin melanjutkan KIR tanpa mencantumkan bukti KIR?", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                                If msg = DialogResult.OK Then
                                    insert()

                                    Me.Close()
                                End If
                            Else
                                insert()

                                Me.Close()
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Edit KIR"
        Dim aktivitas As String = "Edit KIR Truk: " & kode.ToString
        auditlog(user, kompname, form, aktivitas)
    End Sub
    Sub insert()
        Dim arrpic() As Byte
        If PictureEdit1.Text <> "" Then
            Dim ms As New MemoryStream
            PictureEdit1.Image.Save(ms, PictureEdit1.Image.RawFormat)
            arrpic = ms.GetBuffer()
            ms.Close()
            'Exit Sub
        End If
        Try
            Dim bool As Boolean = InsertInto("update kir set no_kir='" + TextEdit2.Text.ToString + "',tgl='" + DateTimePicker3.Value.Date.ToString("yyyy-MM-dd") + "',tgl_kir='" + DateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "',tgl_kir_berikutnya='" + DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "',nominal='" + nominal.ToString + "' where id_kir='" + kode.ToString + "'")
            Dim Command = New MySqlCommand("Update kir set imgfile=@imgfile where id_kir='" + kode + "'", connect)
            connect.Open()
            Command.Parameters.Add(New MySqlParameter("@imgfile", MySqlDbType.LongBlob)).Value = arrpic
            Command.ExecuteNonQuery()
            connect.Close()
            If bool = True Then
                MessageBox.Show("Data KIR dengan No." & kode.ToString & " berhasil diubah", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                insertakun()
                audit()
                main_menu.refreshorganizer()
            Else
                MessageBox.Show("Jaringan sedang sibuk, silahkan coba beberapa saat lagi", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub insertakun()
        Try
            Dim nominalminus As Integer = nominal * -1
            InsertInto("UPDATE jurnal SET tgl='" + DateTimePicker3.Value.Date.ToString("yyyy-MM-dd") + "' where no_jurnal='" + kode.ToString + "'")
            InsertInto("delete from djurnal where no_jurnal='" + kode.ToString + "'")
            InsertInto("insert into djurnal values('" + kode.ToString + "','" + akunkas + "','','" + nominalminus.ToString + "')")
            InsertInto("insert into djurnal values('" + kode.ToString + "','" + akunkir + "','','" + nominal.ToString + "')")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextEdit3_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit3.EditValueChanged
        If TextEdit3.Text = "" Or Not IsNumeric(TextEdit3.Text) Then

        Else
            nominal = TextEdit3.Text
            TextEdit3.Text = FormatNumber(Double.Parse(TextEdit3.Text).ToString(), 2)
        End If
    End Sub

    Private Sub edit_kir_truk_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        PictureEdit1.Text = ""
    End Sub
End Class