Imports MySql.Data.MySqlClient
Public Class rute_booking

    Private Sub rute_booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabelrute As New DataTable
        tabelrute = DtTable("select id_rute `Kode Rute`,concat(kota_asal,' - ','kota_tujuan') `Rute`,concat(price_per_unit,'/',unit) `Harga` from mrute")
        GridControl1.DataSource = tabelrute
    End Sub
End Class