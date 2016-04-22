Imports MySql.Data.MySqlClient
Public Class edit_DO
    Public kodeprinciple As String = ""
    Public namaprinciple As String = ""
    Dim res As String = ""
    Private Sub id_TextChanged(sender As Object, e As EventArgs) Handles id.TextChanged
        Dim datatable As New DataTable
        Dim dtbarang As New DataTable
        Try
            'select awal ambil data semua
            datatable = DtTable("select id_booking,tgl_terkirim,jatuh_tempo,no_do from trans_do where id_transaksi='" + id.Text.ToString + "'")
            idbooking.Text = datatable.Rows(0).Item("id_booking").ToString
            tanggalterkirim.Value = datatable.Rows(0).Item("tgl_terkirim").ToString
            tanggaljatuhtempo.Value = datatable.Rows(0).Item("jatuh_tempo").ToString
            nomerdo.Text = datatable.Rows(0).Item("no_do").ToString


            res = Scalar("select id_principle from booking_truk,trans_do where trans_do.id_booking=booking_truk.id_booking and id_transaksi='" + id.Text.ToString + "'")

            Dim prin As String = ""
            prin = Scalar("select nama_principle from mprinciple where id_principle='" + res + "'")
            TextBox2.Text = prin

            dtbarang = DtTable("select dtrans_do.id_barang `Kode Barang`,nama_barang `Nama Barang`,berat_per_kg `Berat (Kilogram)` from dtrans_do,mbarang where dtrans_do.id_barang=mbarang.id_barang and dtrans_do.id_transaksi='" + id.Text.ToString + "'")
            GridControl1.DataSource = dtbarang
            'summary column dibawah
            For i = 0 To dtbarang.Columns.Count - 1
                GridView1.Columns(i).OptionsColumn.AllowEdit = False
                If GridView1.Columns(i).FieldName.ToString = "Berat (Kilogram)" Then
                    GridView1.Columns(i).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    GridView1.Columns(i).SummaryItem.FieldName = "Berat (Kilogram)"
                    GridView1.Columns(i).SummaryItem.DisplayFormat = "TOTAL {0} Kilogram"
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        'button edit item di klik
        kodeprinciple = res
        namaprinciple = TextBox2.Text
        edit_item.ShowDialog()
    End Sub

    Private Sub edit_DO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GridControl1_DataSourceChanged(sender As Object, e As EventArgs) Handles GridControl1.DataSourceChanged
        Try
            'hitung ulang kiloan barang
            For i = 0 To edit_item.barangset.Columns.Count - 1
                GridView1.Columns(i).OptionsColumn.AllowEdit = False
                If GridView1.Columns(i).FieldName.ToString = "Berat (Kilogram)" Then
                    GridView1.Columns(i).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    GridView1.Columns(i).SummaryItem.FieldName = "Berat (Kilogram)"
                    GridView1.Columns(i).SummaryItem.DisplayFormat = "TOTAL {0} Kilogram"
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'matikan edit gridview
        For i = 0 To GridView1.Columns.Count - 2
            GridView1.Columns(i).OptionsColumn.AllowEdit = False
        Next
    End Sub
End Class