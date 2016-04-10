Imports MySql.Data.MySqlClient
Public Class supir_booking
    Dim tabelid As New DataTable
    Public tampung As New DataTable
    Private Sub supir_booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cari.Text = ""
        proc()
    End Sub
    Sub proc()
        Try
            If id.Checked = True Then
                tabelid = DtTable("select id_supir `Kode Supir`,nama_supir `Nama Supir`,alamat `Alamat`,tel1 `Kontak 1`,tel2 `Kontak 2`,kota `Kota` from msupir where id_supir LIKE '%" + cari.Text.ToString + "%'")
                editing()
            ElseIf nama.Checked = True Then
                tabelid = DtTable("select id_supir `Kode Supir`,nama_supir `Nama Supir`,alamat `Alamat`,tel1 `Kontak 1`,tel2 `Kontak 2`,kota `Kota` from msupir where nama_supir LIKE '%" + cari.Text.ToString + "%'")
                editing()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'query sesuai dengan radiobutton
       
    End Sub

    Sub editing()
        'mematikan edit pada kolom
        controlbooking.DataSource = tabelid
        For i = 0 To gridbooking.Columns.Count - 1
            gridbooking.Columns(i).OptionsColumn.AllowEdit = False
        Next
    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        proc()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            Dim kode As String = gridbooking.GetRowCellValue(gridbooking.FocusedRowHandle, "Kode Supir")
            Dim nama As String = gridbooking.GetRowCellValue(gridbooking.FocusedRowHandle, "Nama Supir")
            If tampung.Columns.Count < 1 Then
                tampung.Columns.Add("Kode Supir")
                tampung.Columns.Add("Nama Supir")
                tampung.Columns.Add("Jumlah DP (Rp)")
            End If
            tampung.Clear()
            tampung.Rows.Add(kode, nama, "0")
            booking_truk.GridControl2.DataSource = tampung
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