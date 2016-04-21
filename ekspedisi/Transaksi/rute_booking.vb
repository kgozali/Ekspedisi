Imports MySql.Data.MySqlClient
Public Class rute_booking
    Dim tabelid As New DataTable
    Private Sub rute_booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cari.Text = ""
        proc()
        Dim nama As String = Scalar("select nama_principle from mprinciple where id_principle='" + booking_truk.principlebook + "'")
        GroupControl3.Text = "Daftar Rute " & nama
    End Sub

    Private Sub id_CheckedChanged(sender As Object, e As EventArgs) Handles id.CheckedChanged
        proc()
    End Sub
    Sub proc()
        'query sesuai dengan radiobutton 
        If id.Checked = True Then
            tabelid = DtTable("select id_rute `Kode Rute`,concat(kota_asal,' - ',kota_tujuan) `Rute`,concat(price_per_unit,'/',unit) `Harga` from mrute where id_rute LIKE '%" + cari.Text + "%' and id_principle='" + booking_truk.principlebook + "'")
            edit()
        ElseIf nama.Checked = True Then
            tabelid = DtTable("select id_rute `Kode Rute`,concat(kota_asal,' - ',kota_tujuan) as `Rute`,concat(price_per_unit,'/',unit) `Harga` from mrute where kota_asal LIKE '%" + cari.Text + "%' or kota_tujuan LIKE '%" + cari.Text + "%' and id_principle='" + booking_truk.principlebook + "'")
            edit()
        End If
    End Sub

    Private Sub nama_CheckedChanged(sender As Object, e As EventArgs) Handles nama.CheckedChanged
        proc()
    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        proc()
    End Sub

    Sub edit()
        'mematikan edit pada kolom
        GridControl1.DataSource = tabelid
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns(i).OptionsColumn.AllowEdit = False
        Next
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim kode As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Rute")
        Dim rute As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Rute")
        booking_truk.ButtonEdit4.Text = rute
        booking_truk.rutebook = kode
        rute_booking_Load(sender, e)
        Me.Close()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
End Class