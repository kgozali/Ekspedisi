Public Class daftar_hutang_karyawan 

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        daftarhutang_DoubleClick(sender, e)
    End Sub

    Private Sub daftar_hutang_karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim data As New DataTable
            data = DtTable("SELECT ms.id_supir `Kode Supir`, nama_supir `Nama Supir`,kota `Kota`, tel1 `Nomor Telepon` FROM  `msupir` ms, booking_truk b,trans_do t WHERE t.id_booking=b.id_booking and b.id_supir=ms.id_supir and ms.s='1' and status_bayar_supir='1' group by ms.id_supir")
            daftarhutang.DataSource = data
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub daftarhutang_DoubleClick(sender As Object, e As EventArgs) Handles daftarhutang.DoubleClick
        Try
            pelunasan_hutang_supir.idkaryawan.Text = hutang.GetRowCellValue(hutang.FocusedRowHandle, "Kode Supir")
            pelunasan_hutang_supir.namakaryawan.Text = hutang.GetRowCellValue(hutang.FocusedRowHandle, "Nama Supir")
            pelunasan_hutang_supir.kotaasal.Text = hutang.GetRowCellValue(hutang.FocusedRowHandle, "Kota")
            pelunasan_hutang_supir.nomertelepon.Text = hutang.GetRowCellValue(hutang.FocusedRowHandle, "Nomor Telepon")
            Dim data As New DataTable
            Dim angka As Double = 0
            data = DtTablebayarcek("SELECT b.id_booking `Kode Booking`,t.no_do `Nomor DO`, tgl_terkirim `Tanggal Terkirim`,harga_supir_total `Total Nominal`, dp_awal_supir `DP Awal`,harga_supir_total-dp_awal_supir `Sisa Hutang` FROM  `msupir` ms, booking_truk b,trans_do t WHERE t.id_booking=b.id_booking and b.id_supir=ms.id_supir and ms.s='1' and status_bayar_supir='1'  and ms.id_supir='" & hutang.GetRowCellValue(hutang.FocusedRowHandle, "Kode Supir") & "'")
            pelunasan_hutang_supir.daftarpiutang.DataSource = data
            For i = 0 To pelunasan_hutang_supir.datapiutang.RowCount - 1
                angka = angka + pelunasan_hutang_supir.datapiutang.GetRowCellValue(i, "Sisa Hutang")
                With pelunasan_hutang_supir.datapiutang
                    .SetRowCellValue(i, "Bayar", False)
                End With
            Next i
            pelunasan_hutang_supir.totalhutang.Text = angka.ToString
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        Try
            If nama.Checked = True Then
                Dim data As New DataTable
                data = DtTable("SELECT ms.id_supir `Kode Supir`, nama_supir `Nama Supir`,kota `Kota`, tel1 `Nomor Telepon`,t.no_do `Nomor DO` FROM  `msupir` ms, booking_truk b,trans_do t WHERE t.id_booking=b.id_booking and b.id_supir=ms.id_supir and ms.s='1' and status_bayar_supir='1' and nama_supir like '%" & cari.Text & "%' group by ms.id_supir")
                daftarhutang.DataSource = data
            ElseIf idkaryawan.Checked = True Then
                Dim data As New DataTable
                data = DtTable("SELECT ms.id_supir `Kode Supir`, nama_supir `Nama Supir`,kota `Kota`, tel1 `Nomor Telepon`,t.no_do `Nomor DO` FROM  `msupir` ms, booking_truk b,trans_do t WHERE t.id_booking=b.id_booking and b.id_supir=ms.id_supir and ms.s='1 and status_bayar_supir='1' and ms.id_supir like '%" & cari.Text & "%' group by ms.id_supir")
                daftarhutang.DataSource = data
            Else
                Dim data As New DataTable
                data = DtTable("SELECT ms.id_supir `Kode Supir`, nama_supir `Nama Supir`,kota `Kota`, tel1 `Nomor Telepon`,t.no_do `Nomor DO` FROM  `msupir` ms, booking_truk b,trans_do t WHERE t.id_booking=b.id_booking and b.id_supir=ms.id_supir and ms.s='1' and status_bayar_supir='1' and t.no_do like '%" & cari.Text & "%' group by ms.id_supir")
                daftarhutang.DataSource = data
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub nomerdo_CheckedChanged(sender As Object, e As EventArgs) Handles nomerdo.CheckedChanged
        If nomerdo.Checked = True Then
            cari_EditValueChanged(sender, e)
        Else
            cari_EditValueChanged(sender, e)
        End If
    End Sub
End Class