Imports MySql.Data.MySqlClient
Public Class master_DO
    Dim path As String = ""
    Dim cellvalue As String = ""
    Private Sub addsiswabaru_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles addsiswabaru.ItemClick
        booking_do.ShowDialog()
    End Sub

    Private Sub master_DO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nama.Checked = True
        aktif.Checked = True
        process()
        unallowedit()
    End Sub

    Sub process()
        Try
            Dim x As String = ""
            If aktif.Checked = True Then
                x = 1
            ElseIf nonaktif.Checked = True Then
                x = 0
            End If

            If nama.Checked = True Then
                cari.Visible = True
                DateTimePicker1.Visible = False
                Dim datatable As New DataTable
                datatable = DtTable("select id_transaksi `Kode Transaksi`,no_DO `No.DO`,concat(day(tgl_terkirim),'-',monthname(tgl_terkirim),'-',year(tgl_terkirim)) `Tanggal Terkirim`,concat(day(jatuh_tempo),'-',monthname(jatuh_tempo),'-',year(jatuh_tempo)) `Tanggal Jatuh Tempo` from trans_do where no_DO LIKE '%" + cari.Text.ToString + "%' and s='" + x + "' order by jatuh_tempo asc")
                GridControl1.DataSource = datatable

                cellvalue = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi")
                path = Scalar("select path_upload from trans_do where id_transaksi='" + cellvalue + "'")
                Label1.Text = path

            ElseIf kodebooking.Checked = True Then

                cari.Visible = True
                DateTimePicker1.Visible = False
                Dim datatable As New DataTable
                datatable = DtTable("select id_transaksi `Kode Transaksi`,no_DO `No.DO`,concat(day(tgl_terkirim),'-',monthname(tgl_terkirim),'-',year(tgl_terkirim)) `Tanggal Terkirim`,concat(day(jatuh_tempo),'-',monthname(jatuh_tempo),'-',year(jatuh_tempo)) `Tanggal Jatuh Tempo` from trans_do where id_booking LIKE '%" + cari.Text.ToString + "%' and s='" + x + "' order by jatuh_tempo asc")
                GridControl1.DataSource = datatable

                cellvalue = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi")
                path = Scalar("select path_upload from trans_do where id_transaksi='" + cellvalue + "'")
                Label1.Text = path

            ElseIf tgl.Checked = True Then
                cari.Visible = False
                DateTimePicker1.Visible = True
                Dim datatable As New DataTable
                datatable = DtTable("select id_transaksi `Kode Transaksi`,no_DO `No.DO`,concat(day(tgl_terkirim),'-',monthname(tgl_terkirim),'-',year(tgl_terkirim)) `Tanggal Terkirim`,concat(day(jatuh_tempo),'-',monthname(jatuh_tempo),'-',year(jatuh_tempo)) `Tanggal Jatuh Tempo` from trans_do where tgl_terkirim ='" + DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' and s='" + x + "' order by jatuh_tempo asc")
                GridControl1.DataSource = datatable

                cellvalue = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi")
                path = Scalar("select path_upload from trans_do where id_transaksi='" + cellvalue + "'")
                Label1.Text = path
            End If
            unallowedit()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        process()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        process()
    End Sub

    Private Sub nama_CheckedChanged(sender As Object, e As EventArgs) Handles nama.CheckedChanged
        process()
        cari.Text = ""
        DateTimePicker1.ResetText()
    End Sub

    Private Sub tgl_CheckedChanged(sender As Object, e As EventArgs) Handles tgl.CheckedChanged
        process()
        cari.Text = ""
        DateTimePicker1.ResetText()
    End Sub

    Private Sub kodebooking_CheckedChanged(sender As Object, e As EventArgs) Handles kodebooking.CheckedChanged
        process()
        cari.Text = ""
        DateTimePicker1.ResetText()
    End Sub
    
    Private Sub aktif_CheckedChanged(sender As Object, e As EventArgs) Handles aktif.CheckedChanged
        process()
    End Sub

    Private Sub nonaktif_CheckedChanged(sender As Object, e As EventArgs) Handles nonaktif.CheckedChanged
        process()
    End Sub

    Private Sub GridControl1_DataSourceChanged(sender As Object, e As EventArgs) Handles GridControl1.DataSourceChanged
        unallowedit()
    End Sub

    Sub unallowedit()
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns(i).OptionsColumn.AllowEdit = False
        Next
    End Sub

   
    Private Sub Label1_TextChanged(sender As Object, e As EventArgs) Handles Label1.TextChanged
        Try
            PictureBox1.Image = Image.FromFile(Label1.Text)
        Catch

        End Try

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub master_DO_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        res()
    End Sub

    Private Sub edit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles edit.ItemClick
        Try
            edit_DO.id.Text = ""
            edit_DO.id.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Transaksi").ToString
            edit_DO.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        

    End Sub

    Private Sub jumpmenu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles jumpmenu.ItemClick
        Me.Close()
    End Sub
    Sub res()
        DateTimePicker1.ResetText()
        cari.Text = ""
    End Sub


End Class