Public Class daftar_edit_piutang_principle 
    Dim tabel As New DataTable
    Private Sub daftar_edit_piutang_principle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            tabel = DtTable("SELECT id_principle as `Kode Principle`, nama_principle `Nama Principle`, alamat `Alamat`, provinsi `Provinsi`, kota `Kota` FROM `mprinciple` WHERE s='1'")
            dataprinciple.DataSource = tabel
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
           
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class