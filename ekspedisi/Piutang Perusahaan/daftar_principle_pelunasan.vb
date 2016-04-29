Public Class daftar_principle_pelunasan 
    Dim tabel As New DataTable
    Private Sub daftar_principle_pelunasan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            tabel = DtTable("SELECT id_principle as `Kode Principle`, nama_principle `Nama Principle`, alamat `Alamat`, provinsi `Provinsi`, kota `Kota` FROM `mprinciple` WHERE s='1'")
            dataprinciple.DataSource = tabel
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        Try
            Dim data As New DataTable
            If id.Checked = True Then
                data = DtTable("SELECT id_principle as `Kode Principle`, nama_principle `Nama Principle`, alamat `Alamat`, provinsi `Provinsi`, kota `Kota` FROM `mprinciple` WHERE s='1' and id_principle like '%" & cari.Text & "%'")
                dataprinciple.DataSource = data
            Else
                data = DtTable("SELECT id_principle as `Kode Principle`, nama_principle `Nama Principle`, alamat `Alamat`, provinsi `Provinsi`, kota `Kota` FROM `mprinciple` WHERE s='1' and nama_principle like '%" & cari.Text & "%'")
                dataprinciple.DataSource = data
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub nama_CheckedChanged(sender As Object, e As EventArgs) Handles nama.CheckedChanged
        cari_EditValueChanged(sender, e)
    End Sub

    Private Sub id_CheckedChanged(sender As Object, e As EventArgs) Handles id.CheckedChanged
        cari_EditValueChanged(sender, e)
    End Sub

    Private Sub dataprinciple_DoubleClick(sender As Object, e As EventArgs) Handles dataprinciple.DoubleClick
        submit_Click(sender, e)
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Try
            tabel = New DataTable
            tabel = DtTablebayarcek("Select t.id_transaksi `Kode Transaksi`,no_do as `Nomer DO`,concat(day(tgl_terkirim),'-',monthname(tgl_terkirim),'-',year(tgl_terkirim)) `Tanggal Pengiriman`,jam `Jam Pengiriman`,concat(kota_asal,' - ',kota_tujuan) `Rute`, sum(berat_per_kg)*price_per_unit `Nominal` from booking_truk,mprinciple,mrute,trans_do t,dtrans_do dt where dt.id_transaksi=t.id_transaksi and t.id_booking=booking_truk.id_booking and booking_truk.id_principle=mprinciple.id_principle and booking_truk.id_rute=mrute.id_rute and t.s=1 and mprinciple.id_principle='" & allprinciple.GetRowCellValue(allprinciple.FocusedRowHandle, "Kode Principle") & "' group by t.id_transaksi")
            pelunasan_piutang.bayarpiutang.DataSource = tabel
            Dim angka As Double = 0
            For i = 0 To pelunasan_piutang.datapiutang.RowCount - 1
                angka = angka + pelunasan_piutang.datapiutang.GetRowCellValue(i, "Nominal")
                With pelunasan_piutang.datapiutang
                    .SetRowCellValue(i, "Bayar", False)
                End With
            Next i
            pelunasan_piutang.totalpiutang.Text = angka.ToString
            pelunasan_piutang.namakeamanan = allprinciple.GetRowCellValue(allprinciple.FocusedRowHandle, "Nama Principle")
            pelunasan_piutang.principle.Text = allprinciple.GetRowCellValue(allprinciple.FocusedRowHandle, "Nama Principle")
            pelunasan_piutang.idprinciple = allprinciple.GetRowCellValue(allprinciple.FocusedRowHandle, "Kode Principle")
            pelunasan_piutang.alamat.Text = allprinciple.GetRowCellValue(allprinciple.FocusedRowHandle, "Alamat")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class