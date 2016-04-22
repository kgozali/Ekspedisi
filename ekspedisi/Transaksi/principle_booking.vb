Imports MySql.Data.MySqlClient
Public Class principle_booking
    Dim tabelid As New DataTable
    Private Sub principle_booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cari.Text = ""
        proc()
    End Sub

    Sub proc()
        'query sesuai dengan radiobutton
        If id.Checked = True Then
            tabelid = DtTable("select id_principle `Kode Principle`,nama_principle `Nama Principle`,alamat `Alamat`,email `E-Mail`, tel1 `Kontak 1`,tel2 `Kontak 2`,provinsi `Provinsi`,kota `Kota` from mprinciple where id_principle LIKE '%" + cari.Text.ToString + "%'")
            edit()
        ElseIf nama.Checked = True Then
            tabelid = DtTable("select id_principle `Kode Principle`,nama_principle `Nama Principle`,alamat `Alamat`,email `E-Mail`, tel1 `Kontak 1`,tel2 `Kontak 2`,provinsi `Provinsi`,kota `Kota` from mprinciple where nama_principle LIKE '%" + cari.Text.ToString + "%'")
            edit()
        End If
    End Sub

    Sub edit()
        'mematikan edit pada kolom
        GridControl1.DataSource = tabelid
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns(i).OptionsColumn.AllowEdit = False
        Next
    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        proc()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim kode As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Principle")
        Dim nama As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Nama Principle")
        booking_truk.principlebook = kode
        booking_truk.ButtonEdit2.Text = nama
        principle_booking_Load(sender, e)
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Dim kode As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Principle")
        Dim nama As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Nama Principle")
        booking_truk.principlebook = kode
        booking_truk.ButtonEdit2.Text = nama
        principle_booking_Load(sender, e)
        Me.Close()
    End Sub
End Class