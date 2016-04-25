Imports MySql.Data.MySqlClient
Public Class list_truk_edit
    Dim tabelid As New DataTable
    Private Sub list_truk_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cari.Text = ""
        proc()
    End Sub

    Sub proc()
        Try
            'query sesuai dengan radiobutton
            If id.Checked = True Then
                tabelid = DtTable("select id_truk `Kode Truk`,no_pol `No.Polisi`,no_mesin `No.Mesin`,no_rangka `No.Rangka` from mtruk where id_truk LIKE '%" + cari.Text.ToString + "%'")
                edit()
            ElseIf nama.Checked = True Then
                tabelid = DtTable("select id_truk `Kode Truk`,no_pol `No.Polisi`,no_mesin `No.Mesin`,no_rangka `No.Rangka` from mtruk where no_pol LIKE '%" + cari.Text.ToString + "%'")
                edit()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub edit()
        Try
            'mematikan edit pada kolom
            GridControl1.DataSource = tabelid
            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).OptionsColumn.AllowEdit = False
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click, GridControl1.DoubleClick
        Try
            'pilih truk ditampilkan pada buttonedit Booking truk
            Dim query As New DataTable
            'cek supir apa ada bookingan pada hari itu
            query = DtTable("select id_truk from booking_truk where id_truk='" + GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Truk") + "' and tgl='" + edit_booking.DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "'")
            If query.Rows.Count > 0 Then
                Dim msg As Integer = MessageBox.Show("Truk yang dipilih telah terdaftar dalam salah satu booking pada tanggal yang telah dipilih, apakah anda ingin melanjutkan booking?", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                If msg = DialogResult.OK Then
                    check(sender, e)
                End If
            Else
                check(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub check(sender As Object, e As EventArgs)
        Try
            Dim kode As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Truk")
            Dim nama As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "No.Polisi")
            edit_booking.ButtonEdit1.Text = nama
            edit_booking.trukbook = kode
            list_truk_edit_Load(sender, e)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub list_truk_edit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        edit_booking.edit_booking_Load(sender, e)
    End Sub
End Class