Imports MySql.Data.MySqlClient
Public Class booking_do
    Public kodebooking As String = ""
    Private Sub booking_do_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As New DataTable
        data = DtTable("Select id_booking `Kode Booking`,tgl `Tanggal Pengiriman`,jam `Jam Pengiriman`,concat(ETA,' ','Jam') `ETA`,nama_principle `Principle`,concat(kota_asal,' - ',kota_tujuan) `Rute`,keterangan `Keterangan` from booking_truk,mprinciple,mrute where booking_truk.id_principle=mprinciple.id_principle and booking_truk.id_rute=mrute.id_rute")
        controlbooking.DataSource = data

        For i = 0 To data.Columns.Count - 1
            gridbooking.Columns(i).OptionsColumn.AllowEdit = False
        Next
    End Sub

    Private Sub id_CheckedChanged(sender As Object, e As EventArgs) Handles id.CheckedChanged
        cari.Text = ""
        tgl.ResetText()
        selection()
    End Sub
    Private Sub nama_CheckedChanged(sender As Object, e As EventArgs) Handles nama.CheckedChanged
        cari.Text = ""
        tgl.ResetText()
        selection()
    End Sub

    Private Sub principle_CheckedChanged(sender As Object, e As EventArgs) Handles principle.CheckedChanged
        cari.Text = ""
        tgl.ResetText()
        selection()
    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        selection()
    End Sub

    Private Sub tgl_ValueChanged(sender As Object, e As EventArgs) Handles tgl.ValueChanged
        selection()
    End Sub

    Sub selection()
        'query untuk tiap check changed dengan LIKE
        Try
            If id.Checked = True Then
                tgl.Visible = False
                cari.Visible = True
                Dim dataset As New DataTable
                dataset = DtTable("Select id_booking `Kode Booking`,tgl `Tanggal Pengiriman`,jam `Jam Pengiriman`,concat(ETA,' ','Jam') `ETA`,nama_principle `Principle`,concat(kota_asal,' - ',kota_tujuan) `Rute`,keterangan `Keterangan` from booking_truk,mprinciple,mrute where booking_truk.id_principle=mprinciple.id_principle and booking_truk.id_rute=mrute.id_rute and id_booking LIKE '%" + cari.Text + "%'")
                controlbooking.DataSource = dataset

            ElseIf nama.Checked = True Then
                tgl.Visible = True
                cari.Visible = False
                Dim dataset As New DataTable
                dataset = DtTable("Select id_booking `Kode Booking`,tgl `Tanggal Pengiriman`,jam `Jam Pengiriman`,concat(ETA,' ','Jam') `ETA`,nama_principle `Principle`,concat(kota_asal,' - ',kota_tujuan) `Rute`,keterangan `Keterangan` from booking_truk,mprinciple,mrute where booking_truk.id_principle=mprinciple.id_principle and booking_truk.id_rute=mrute.id_rute and tgl='" + tgl.Value.Date.ToString("yyyyMMdd") + "'")
                controlbooking.DataSource = dataset

            ElseIf principle.Checked = True Then
                tgl.Visible = False
                cari.Visible = True
                Dim dataset As New DataTable
                dataset = DtTable("Select id_booking `Kode Booking`,tgl `Tanggal Pengiriman`,jam `Jam Pengiriman`,concat(ETA,' ','Jam') `ETA`,nama_principle `Principle`,concat(kota_asal,' - ',kota_tujuan) `Rute`,keterangan `Keterangan` from booking_truk,mprinciple,mrute where booking_truk.id_principle=mprinciple.id_principle and booking_truk.id_rute=mrute.id_rute and nama_principle LIKE '%" + cari.Text + "%'")
                controlbooking.DataSource = dataset

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub view()
        Try
            kodebooking = gridbooking.GetRowCellValue(gridbooking.FocusedRowHandle, "Kode Booking")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub details_Click(sender As Object, e As EventArgs) Handles details.Click
        view()

    End Sub

    Private Sub booking_do_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        cari.Text = ""
        tgl.ResetText()
        booking_do_Load(sender, e)
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        view()
        transaksi_DO.idbooking.Text = kodebooking
        Me.Visible = False
        transaksi_DO.ShowDialog()


    End Sub
End Class