Imports MySql.Data.MySqlClient
Public Class master_customer
    Private Sub master_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataset1 As New DataTable
        dataset1 = DtTablemaster("select id_customer `Kode Customer`,nama_customer `Nama Customer`,alamat `Alamat`,email `E-Mail`,tel1 `Telephone 1`,tel2 `Telephone 2`,Provinsi `Provinsi`,kota `Kota` from mcustomer")
        GridControl1.DataSource = dataset1

        'Ini untuk matikan column lain selain checkbox, mulai dari index 1 soalnya checkbox index 0
        For i = 1 To dataset1.Columns.Count - 1
            gridcustomer.Columns(i).OptionsColumn.AllowEdit = False
        Next

    End Sub
End Class