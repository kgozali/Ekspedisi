Imports MySql.Data.MySqlClient
Public Class booking_do
    Public kodebooking As String = ""
    Private Sub booking_do_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim data As New DataTable
            gridbooking.OptionsView.ShowFooter = True
            data = DtTable("Select id_booking `Kode Booking`,concat(day(tgl),'-',monthname(tgl),'-',year(tgl)) `Tanggal Pengiriman`,jam `Jam Pengiriman`,concat(ETA,' ','Jam') `ETA`,nama_principle `Principle`,concat(kota_asal,' - ',kota_tujuan) `Rute`,keterangan `Keterangan` from booking_truk,mprinciple,mrute where booking_truk.id_principle=mprinciple.id_principle and booking_truk.id_rute=mrute.id_rute and booking_truk.s=1 order by tgl asc,jam asc")
            controlbooking.DataSource = data

            For i = 0 To data.Columns.Count - 1
                gridbooking.Columns(i).OptionsColumn.AllowEdit = False
                If gridbooking.Columns(i).FieldName.ToString = "Keterangan" Then
                    gridbooking.Columns(i).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                    gridbooking.Columns(i).SummaryItem.FieldName = "Keterangan"
                    gridbooking.Columns(i).SummaryItem.DisplayFormat = "Total {0} records"
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       



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
                dataset = DtTable("Select id_booking `Kode Booking`,concat(day(tgl),'-',monthname(tgl),'-',year(tgl)) `Tanggal Pengiriman`,jam `Jam Pengiriman`,concat(ETA,' ','Jam') `ETA`,nama_principle `Principle`,concat(kota_asal,' - ',kota_tujuan) `Rute`,keterangan `Keterangan` from booking_truk,mprinciple,mrute where booking_truk.id_principle=mprinciple.id_principle and booking_truk.id_rute=mrute.id_rute and id_booking LIKE '%" + cari.Text + "%' and booking_truk.s=1")
                controlbooking.DataSource = dataset

            ElseIf nama.Checked = True Then
                tgl.Visible = True
                cari.Visible = False
                Dim dataset As New DataTable
                dataset = DtTable("Select id_booking `Kode Booking`,concat(day(tgl),'-',monthname(tgl),'-',year(tgl)) `Tanggal Pengiriman`,jam `Jam Pengiriman`,concat(ETA,' ','Jam') `ETA`,nama_principle `Principle`,concat(kota_asal,' - ',kota_tujuan) `Rute`,keterangan `Keterangan` from booking_truk,mprinciple,mrute where booking_truk.id_principle=mprinciple.id_principle and booking_truk.id_rute=mrute.id_rute and tgl='" + tgl.Value.Date.ToString("yyyyMMdd") + "' and booking_truk.s=1")
                controlbooking.DataSource = dataset

            ElseIf principle.Checked = True Then
                tgl.Visible = False
                cari.Visible = True
                Dim dataset As New DataTable
                dataset = DtTable("Select id_booking `Kode Booking`,concat(day(tgl),'-',monthname(tgl),'-',year(tgl)) `Tanggal Pengiriman`,jam `Jam Pengiriman`,concat(ETA,' ','Jam') `ETA`,nama_principle `Principle`,concat(kota_asal,' - ',kota_tujuan) `Rute`,keterangan `Keterangan` from booking_truk,mprinciple,mrute where booking_truk.id_principle=mprinciple.id_principle and booking_truk.id_rute=mrute.id_rute and nama_principle LIKE '%" + cari.Text + "%' and booking_truk.s=1")
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