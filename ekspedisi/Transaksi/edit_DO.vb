Imports MySql.Data.MySqlClient
Public Class edit_DO
    Public kodeprinciple As String = ""
    Public namaprinciple As String = ""
    Dim res As String = ""
    Dim sum As Integer = 0
    Dim kodetrans As String = ""
    Dim jumlahcek As Integer = 0
    Dim boolcek As Boolean = False
    Dim cek As Boolean = False
    Dim datatable As New DataTable
    Dim dtbarang As New DataTable
    Dim audit As String = ""
    Dim total As Integer = 0
    Dim price As Integer = 0
    Dim defpiutang As String = ""
    Dim defpendapatan As String = ""
    Private Sub id_TextChanged(sender As Object, e As EventArgs) Handles id.TextChanged
        
       

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        'button edit item di klik
        kodeprinciple = res
        namaprinciple = TextBox2.Text
        edit_item.ShowDialog()
    End Sub

    Private Sub edit_DO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'select akun
            defpiutang = Scalar("select id_akun from control_account where keterangan='Def. Akun Piutang'")
            defpendapatan = Scalar("select id_akun from control_account where keterangan='Def. Akun Pendapatan'")

            'select awal ambil data semua
            datatable = DtTable("select id_booking,tgl_jam,tgl_terkirim,jatuh_tempo,no_do from trans_do where id_transaksi='" + id.Text.ToString + "'")
            idbooking.Text = datatable.Rows(0).Item("id_booking").ToString
            tanggalterkirim.Value = datatable.Rows(0).Item("tgl_terkirim").ToString
            tanggaljatuhtempo.Value = datatable.Rows(0).Item("jatuh_tempo").ToString
            nomerdo.Text = datatable.Rows(0).Item("no_do").ToString
            tgldo.Value = datatable.Rows(0).Item("tgl_jam").ToString

            kodetrans = id.Text.ToString


            res = Scalar("select id_principle from booking_truk,trans_do where trans_do.id_booking=booking_truk.id_booking and id_transaksi='" + id.Text.ToString + "'")
            'select rute
            Dim rute As String = ""
            rute = Scalar("select id_rute from booking_truk where id_booking='" + idbooking.Text.ToString + "' and id_principle='" + res + "'")
            'select price per KG
            price = Scalar("select price_per_unit from mrute where id_rute='" + rute + "'")


            Dim prin As String = ""
            prin = Scalar("select nama_principle from mprinciple where id_principle='" + res + "'")
            TextBox2.Text = prin

            dtbarang = DtTable("select dtrans_do.id_barang `Kode Barang`,nama_barang `Nama Barang`,berat_per_kg `Berat (Kilogram)` from dtrans_do,mbarang where dtrans_do.id_barang=mbarang.id_barang and dtrans_do.id_transaksi='" + id.Text.ToString + "'")
            GridControl1.DataSource = dtbarang
            'matikan edit gridview
            For i = 0 To GridView1.Columns.Count - 1
                If GridView1.Columns(i).FieldName.ToString = "Berat (Kilogram)" Then
                    GridView1.Columns(i).OptionsColumn.AllowEdit = True
                Else
                    GridView1.Columns(i).OptionsColumn.AllowEdit = False
                End If
            Next
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
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'matikan edit gridview
        For i = 0 To GridView1.Columns.Count - 2
            GridView1.Columns(i).OptionsColumn.AllowEdit = False
        Next
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            jumlahcek = GridView1.DataRowCount - 1
            If tanggalterkirim.Value >= tanggaljatuhtempo.Value Then
                Dim msg As Integer = MessageBox.Show("Tanggal Terkirim lebih besar atau sama dengan Tanggal Jatuh Tempo, apakah anda ingin melanjutkan?", "System Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If msg = DialogResult.Yes Then
                    update()
                End If
            Else
                update()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Sub update()
        'lihat apakah berat dari total barang adalah 0
        sum = CInt(GridView1.Columns("Berat (Kilogram)").SummaryItem.SummaryValue.ToString)
        total = price * sum
        If sum <> 0 Then
            Dim update As Boolean = InsertInto("update trans_do set no_do='" + nomerdo.Text + "',tgl_jam='" + tgldo.Value.Date.ToString("yyyy-MM-dd") + "',tgl_terkirim='" + tanggalterkirim.Value.Date.ToString("yyyy-MM-dd") + "',jatuh_tempo='" + tanggaljatuhtempo.Value.Date.ToString("yyyy-MM-dd") + "' where id_transaksi='" + kodetrans.ToString + "'")
            'delete
            InsertInto("delete from dtrans_do where id_transaksi='" + kodetrans.ToString + "'")
            'insert baru
            For i = 0 To GridView1.DataRowCount - 1
                boolcek = InsertInto("insert into dtrans_do values('" + kodetrans.ToString + "','" + GridView1.GetRowCellValue(i, "Kode Barang").ToString + "','" + GridView1.GetRowCellValue(i, "Berat (Kilogram)").ToString + "','')")
            Next


            If update = True And boolcek = True Then
                MessageBox.Show("Update Delivery Order " & kodetrans.ToString & " Berhasil", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'insert jurnal
                jurnal()
                reset()
                Me.Close()
            Else
                MessageBox.Show("Jaringan sedang sibuk, silahkan coba beberapa saat lagi", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            Dim msg As Integer = MessageBox.Show("Total berat dari barang adalah 0 Kilogram, apakah anda ingin tetap melakukan perubahan?", "System Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If msg = DialogResult.Yes Then
                Dim update As Boolean = InsertInto("update trans_do set no_do='" + nomerdo.Text + "',tgl_jam='" + tgldo.Value.Date.ToString("yyyy-MM-dd") + "',tgl_terkirim='" + tanggalterkirim.Value.Date.ToString("yyyy-MM-dd") + "',jatuh_tempo='" + tanggaljatuhtempo.Value.Date.ToString("yyyy-MM-dd") + "',total_bayar='" + total.ToString + "' where id_transaksi='" + kodetrans.ToString + "'")
                'delete
                InsertInto("delete from dtrans_do where id_transaksi='" + kodetrans.ToString + "'")
                'insert baru
                For i = 0 To GridView1.DataRowCount - 1
                    boolcek = InsertInto("insert into dtrans_do values('" + kodetrans.ToString + "','" + GridView1.GetRowCellValue(i, "Kode Barang").ToString + "','" + GridView1.GetRowCellValue(i, "Berat (Kilogram)").ToString + "','')")
                Next

                If update = True And boolcek = True Then
                    MessageBox.Show("Update Delivery Order " & kodetrans.ToString & " Berhasil", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'insert jurnal
                    auditloger()
                    jurnal()
                    reset()
                    Me.Close()
                Else
                    MessageBox.Show("Jaringan sedang sibuk, silahkan coba beberapa saat lagi", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If


    End Sub
    Sub auditloger()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Transaksi DO"
        Dim aktivitas As String = "Edit DO: " & kodetrans.ToString
        auditlog(user, kompname, form, aktivitas)
    End Sub

    Private Sub edit_DO_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If nomerdo.Text <> "" Then
                cek = True
            Else
                cek = False
            End If
            If cek = True Then
                Dim msg As Integer = MessageBox.Show("Apakah anda yakin ingin menutup form ini? Semua data yang belum disimpan akan hilang", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If msg = DialogResult.OK Then
                    reset()

                Else
                    e.Cancel = True
                End If
            Else
                reset()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub reset()
        idbooking.Text = ""
        nomerdo.Text = ""
        TextBox2.Text = ""
        edit_item.barangset.Rows.Clear()
        datatable.Rows.Clear()
        dtbarang.Rows.Clear()
        id.Text = ""
    End Sub

    Sub jurnal()
        Dim totalkredit As Integer = total * -1
        InsertInto("update jurnal set tgl='" + tgldo.Value.Date.ToString("yyyy-MM-dd") + "' where no_jurnal='" + kodetrans.ToString + "'")
        InsertInto("delete from djurnal where no_jurnal='" + kodetrans.ToString + "'")
        InsertInto("insert into djurnal values('" + kodetrans.ToString + "','" + defpiutang + "','','" + total.ToString + "')")
        InsertInto("insert into djurnal values('" + kodetrans.ToString + "','" + defpendapatan + "','','" + totalkredit.ToString + "')")
    End Sub
End Class