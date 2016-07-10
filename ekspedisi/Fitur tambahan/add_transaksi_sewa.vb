Public Class add_transaksi_sewa 

    Private Sub add_mobil_Click(sender As Object, e As EventArgs)
        add_mobil_transaksi.ShowDialog()
    End Sub

   
    Private Sub customer_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        add_customer_master_sewa.ShowDialog()
    End Sub

    Private Sub add_transaksi_sewa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            id.Text = autogenerate("SM", "")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class