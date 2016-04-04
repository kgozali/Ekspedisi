Imports MySql.Data.MySqlClient
Public Class booking_do

    Private Sub booking_do_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As New DataTable
        data = DtTable("Select id_booking `Kode Booking`,tgl_jam `Tanggal Jam Pengiriman`,concat(ETA,' ','Jam') `ETA`,nama_principle `Principle`,concat(kota_asal,' - ',kota_tujuan) `Rute`,alamat_tujuan `Alamat`,keterangan `Keterangan` from booking_truk,mprinciple,mrute where booking_truk.id_principle=mprinciple.id_principle and booking_truk.id_rute=mrute.id_rute")
        controlbooking.DataSource = data

        For i = 0 To data.Columns.Count - 1
            gridbooking.Columns(i).OptionsColumn.AllowEdit = False
        Next
    End Sub
End Class