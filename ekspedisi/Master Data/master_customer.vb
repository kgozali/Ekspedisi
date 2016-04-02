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


        'Kalo kalian mau ambil data dari row yang kalian pilih dalam gridview caranya dibawah
        'Hapus ya kalo udh tau cuman contoh aja males taruk notepad
        'GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "nama column header")

        'Catatan====
        'DI xtragrid agak beda sama datagridview. jadi di xtragrid, gridviewnya punya 2 komponen
        'yaitu gridcontrol sama dalemnya ada anakannya (namanya gridview1 ada tulisannya)
        'untuk datasource masukkan ke gridcontrol 
        'untuk coding data dll nya kalian codingnya di gridview1

        'testing

    End Sub
End Class