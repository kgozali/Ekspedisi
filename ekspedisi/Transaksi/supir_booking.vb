Imports MySql.Data.MySqlClient
Public Class supir_booking
    Dim tabelid As New DataTable
    Public tampung As New DataTable
    Private Sub supir_booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim route As String = booking_truk.ButtonEdit4.Text.ToString
            cari.Text = ""
            proc()
            GroupControl3.Text = "Daftar Supir Rute " & route

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Sub proc()
        Try
            If id.Checked = True Then
                tabelid = DtTable("select msupir.id_supir `Kode Supir`,nama_supir `Nama Supir`,alamat `Alamat`,tel1 `Kontak 1`,tel2 `Kontak 2`,kota `Kota` ,tarif `Tariff Maksimum` from msupir,dsupir where msupir.id_supir=dsupir.id_supir and  msupir.id_supir LIKE '%" + cari.Text.ToString + "%' and id_rute='" + booking_truk.rutebook + "'")
                editing()
            ElseIf nama.Checked = True Then
                tabelid = DtTable("select msupir.id_supir `Kode Supir`,nama_supir `Nama Supir`,alamat `Alamat`,tel1 `Kontak 1`,tel2 `Kontak 2`,kota `Kota`,tarif `Tariff Maksimum` from msupir,dsupir where msupir.id_supir=dsupir.id_supir and nama_supir LIKE '%" + cari.Text.ToString + "%' and id_rute='" + booking_truk.rutebook + "'")
                editing()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'query sesuai dengan radiobutton 

    End Sub

    Sub editing()
        Try
            'mematikan edit pada kolom
            controlbooking.DataSource = tabelid
            For i = 0 To gridbooking.Columns.Count - 1
                gridbooking.Columns(i).OptionsColumn.AllowEdit = False
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        proc()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            Dim query As New DataTable
            'cek supir apa ada bookingan pada hari itu
            query = DtTable("select id_supir from booking_truk where id_supir='" + gridbooking.GetRowCellValue(gridbooking.FocusedRowHandle, "Kode Supir") + "' and tgl='" + booking_truk.DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "'")
            If query.Rows.Count > 0 Then
                Dim msg As Integer = MessageBox.Show("Supir yang dipilih telah terdaftar dalam salah satu booking pada tanggal yang telah dipilih, apakah anda ingin melanjutkan booking?", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                If msg = DialogResult.OK Then
                    'task
                Else
                    'task kalo enggak
                End If
            Else
                'task
            End If

            Dim kode As String = gridbooking.GetRowCellValue(gridbooking.FocusedRowHandle, "Kode Supir")
            Dim nama As String = gridbooking.GetRowCellValue(gridbooking.FocusedRowHandle, "Nama Supir")
            Dim tarif As Integer = gridbooking.GetRowCellValue(gridbooking.FocusedRowHandle, "Tariff Maksimum")
            If tampung.Columns.Count < 1 Then
                tampung.Columns.Add("Kode Supir")
                tampung.Columns.Add("Nama Supir")
                tampung.Columns.Add("Jumlah DP (Rp)")
                tampung.Columns.Add("Total Bayar (Rp)")
            End If
            tampung.Clear()
            tampung.Rows.Add(kode, nama, "0", tarif)
            booking_truk.GridControl2.DataSource = tampung
            booking_truk.max = tarif
            supir_booking_Load(sender, e)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
End Class