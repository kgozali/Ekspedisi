Public Class tambah_transaksi_sewa 

    Private Sub idkaryawan_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles idkaryawan.ButtonClick
        add_customer_master_sewa.ShowDialog()
    End Sub

    
    Private Sub tambahmobil_Click(sender As Object, e As EventArgs) Handles tambahmobil.Click
        add_mobil_transaksi.ShowDialog()
    End Sub
End Class