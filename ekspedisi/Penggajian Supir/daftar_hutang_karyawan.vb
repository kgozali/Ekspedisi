Public Class daftar_hutang_karyawan 

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        daftarhutang_DoubleClick(sender, e)
    End Sub

    Private Sub daftar_hutang_karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim data As New DataTable
            data = DtTable("SELECT t.no_do `Nomor DO`,tgl_terkirim `Tanggal Terkirim`, FROM  `msupir` ms, booking_truk b,trans_do t WHERE t.id_booking=b.id_booking and b.id_supir=ms.id_supir and ms.s='1'")
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
            DtTablebayar("SELECT ms.id_supir `Kode Supir`, nama_supir `Nama Supir`,kota `Kota`, tel1 `Nomor Telepon`,t.no_do `Nomor DO` FROM  `msupir` ms, booking_truk b,trans_do t WHERE t.id_booking=b.id_booking and b.id_supir=ms.id_supir and ms.s='1'")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        Try
            If nama.Checked = True Then
                Dim data As New DataTable
                data = DtTable("SELECT ms.id_supir `Kode Supir`, nama_supir `Nama Supir`, tel1 `Nomor Telepon`,t.no_do `Nomor DO` FROM  `msupir` ms, booking_truk b,trans_do t WHERE t.id_booking=b.id_booking and b.id_supir=ms.id_supir and ms.s='1' and nama_supir like '%" & cari.Text & "%'")
                daftarhutang.DataSource = data
            ElseIf idkaryawan.Checked = True Then
                Dim data As New DataTable
                data = DtTable("SELECT ms.id_supir `Kode Supir`, nama_supir `Nama Supir`, tel1 `Nomor Telepon`,t.no_do `Nomor DO` FROM  `msupir` ms, booking_truk b,trans_do t WHERE t.id_booking=b.id_booking and b.id_supir=ms.id_supir and ms.s='1' and id_supir like '%" & cari.Text & "%'")
            Else
                Dim data As New DataTable
                data = DtTable("SELECT ms.id_supir `Kode Supir`, nama_supir `Nama Supir`, tel1 `Nomor Telepon`,t.no_do `Nomor DO` FROM  `msupir` ms, booking_truk b,trans_do t WHERE t.id_booking=b.id_booking and b.id_supir=ms.id_supir and ms.s='1' and no_do like '%" & cari.Text & "%'")
                daftarhutang.DataSource = data
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub
End Class