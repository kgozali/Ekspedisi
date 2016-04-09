Public Class main_menu 


    Private Sub masterakun_Click(sender As Object, e As EventArgs) Handles masterakun.Click
        master_akun.ShowDialog()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        master_customer.ShowDialog()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        master_jabatan.ShowDialog()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        master_karyawan.ShowDialog()
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        master_kategori_supplier.ShowDialog()
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        master_kontak_principle.ShowDialog()
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        perubahan_harga.ShowDialog()
    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click
        master_rute.ShowDialog()
    End Sub

    Private Sub SimpleButton11_Click(sender As Object, e As EventArgs) Handles SimpleButton11.Click
        master_truck.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        master_barang.ShowDialog()
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        master_kota.ShowDialog()
    End Sub

    Private Sub SimpleButton10_Click(sender As Object, e As EventArgs) Handles SimpleButton10.Click
        master_supplier.ShowDialog()
    End Sub

    Private Sub SimpleButton12_Click(sender As Object, e As EventArgs) Handles SimpleButton12.Click
        master_user.ShowDialog()
    End Sub

    Private Sub SimpleButton20_Click(sender As Object, e As EventArgs) Handles SimpleButton20.Click
        booking_truk.ShowDialog()
    End Sub

    Private Sub SimpleButton19_Click(sender As Object, e As EventArgs) Handles SimpleButton19.Click
        master_DO.ShowDialog()
    End Sub

    Private Sub main_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class