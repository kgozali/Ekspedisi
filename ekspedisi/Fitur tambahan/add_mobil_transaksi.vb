Public Class add_mobil_transaksi 
    Dim data As New DataTable
    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        Try
            If nama.Checked = True Then
                GridControl1.DataSource = DtTable("SELECT id_mobil `Kode Mobil`, no_pol `Nomor Polisi`, tipe_mobil `Tipe Mobil`,Warna,Tahun FROM mmobil m where s='1' and no_pol like '%" & cari.Text & "%'")
            Else
                GridControl1.DataSource = DtTable("SELECT id_mobil `Kode Mobil`, no_pol `Nomor Polisi`, tipe_mobil `Tipe Mobil`,Warna,Tahun FROM mmobil m where s='1' and id_mobil like '%" & cari.Text & "%'")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub add_mobil_transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cari_EditValueChanged(sender, e)
    End Sub

    Private Sub nama_CheckedChanged(sender As Object, e As EventArgs) Handles nama.CheckedChanged
        cari_EditValueChanged(sender, e)
    End Sub
End Class