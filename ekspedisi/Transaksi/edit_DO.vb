Imports MySql.Data.MySqlClient
Imports System.IO
Imports DevExpress.XtraGrid.Views.Base

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
    Dim switch As Boolean = False
    Dim totaldo As Integer = 0
    Dim nominal As Integer = 0
    Dim nominalparse As String = ""
    Dim koma As Boolean = False
    Private Sub id_TextChanged(sender As Object, e As EventArgs) Handles id.TextChanged



    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
        'button edit item di klik
        kodeprinciple = res
        namaprinciple = TextBox2.Text
        edit_item.ShowDialog()
    End Sub

    Private Sub edit_DO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            switch = False

            tgldo.Value = Convert.ToDateTime(tgldo.Value.Date.ToLongDateString & " " & "00:00:00")
            'select akun
            defpiutang = Scalar("select id_akun from control_account where keterangan='Def. Akun Piutang'")
            defpendapatan = Scalar("select id_akun from control_account where keterangan='Def. Akun Pendapatan'")

            'select awal ambil data semua
            datatable = DtTable("select id_booking,path_upload,tgl_jam,tgl_terkirim,jatuh_tempo,no_do,berat_do,keterangan from trans_do where id_transaksi='" & id.Text.ToString & "'")
            idbooking.Text = datatable.Rows(0).Item("id_booking").ToString
            tanggalterkirim.Value = datatable.Rows(0).Item("tgl_terkirim").ToString
            tanggaljatuhtempo.Value = datatable.Rows(0).Item("jatuh_tempo").ToString
            nomerdo.Text = datatable.Rows(0).Item("no_do").ToString
            tgldo.Value = datatable.Rows(0).Item("tgl_jam").ToString
            RichTextBox1.Text = datatable.Rows(0).Item("keterangan").ToString
            TextBox1.Text = datatable.Rows(0).Item("berat_do").ToString()

            kodetrans = id.Text.ToString

            If datatable.Rows(0).Item("path_upload").ToString = "" Or datatable.Rows(0).Item("path_upload").ToString.Length < 14 Then

            Else
                Dim arrpic() As Byte = CType(datatable.Rows(0).Item("path_upload"), Byte())
                If arrpic.Length > 0 Then
                    Dim ms As New MemoryStream(arrpic)
                    PictureEdit1.Image = Image.FromStream(ms)
                    ms.Close()
                Else

                End If
            End If



            res = Scalar("select id_principle from booking_truk,trans_do where trans_do.id_booking=booking_truk.id_booking and id_transaksi='" & id.Text.ToString & "'")
            'select rute
            Dim rute As String = ""
            rute = Scalar("select id_rute from booking_truk where id_booking='" & idbooking.Text.ToString & "' and id_principle='" & res & "'")
            'select price per KG
            price = Scalar("select price_per_unit from mrute where id_rute='" & rute & "'")


            Dim prin As String = ""
            prin = Scalar("select nama_principle from mprinciple where id_principle='" & res & "'")
            TextBox2.Text = prin

            Dim dtbarangs As New DataTable
            dtbarangs = DtTable("select id_barang `Kode Barang`,nama_barang `Nama Barang` from mbarang where id_principle='" & res & "'")
            RepositoryItemLookUpEdit1.DataSource = dtbarangs
            RepositoryItemLookUpEdit1.ValueMember = "Kode Barang"
            RepositoryItemLookUpEdit1.DisplayMember = "Nama Barang"

            dtbarang = DtTable("select dtrans_do.id_barang `namabarang`,berat_per_kg `berat`,satuan,jumlah_satuan `kgsatuan` FROM dtrans_do LEFT JOIN mbarang ON mbarang.id_barang=dtrans_do.id_barang LEFT JOIN msatuan ON msatuan.id_satuan=mbarang.id_satuan WHERE dtrans_do.id_transaksi='" & id.Text.ToString & "'")
            GridControl1.DataSource = dtbarang

            Dim mreader As DataTableReader
            mreader = dtbarang.CreateDataReader
            datasetdo.Tables(0).Load(mreader)
            GridControl1.DataSource = datasetdo
            GridControl1.DataMember = "Table1"



        Catch ex As Exception

        End Try
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
        Dim arrpic() As Byte
        If PictureEdit1.Text <> "" Then
            Dim ms As New MemoryStream
            PictureEdit1.Image.Save(ms, PictureEdit1.Image.RawFormat)
            arrpic = ms.GetBuffer()
            ms.Close()
            'Exit Sub
        End If
        'lihat apakah berat dari total barang adalah 0
        sum = CInt(GridView1.Columns("berat").SummaryItem.SummaryValue.ToString)
        total = price * sum
        totaldo = nominal * price
        If sum - nominal > 100 And RichTextBox1.Text = "" Then
            MessageBox.Show("Total Berat DO Dibawah Total Berat Yang Seharusnya, Harap Isi Keterangan", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            If sum <> 0 Then
                Dim update As Boolean = InsertInto("update trans_do set keterangan='" & RichTextBox1.Text.ToString & "',berat_do='" & nominal & "',nominal_do='" & totaldo & "',nominal_komp='" & total & "',no_do='" & nomerdo.Text & "',tgl_jam='" & tgldo.Value.Date.ToString("yyyy-MM-dd") & "',tgl_terkirim='" & tanggalterkirim.Value.Date.ToString("yyyy-MM-dd") & "',jatuh_tempo='" & tanggaljatuhtempo.Value.Date.ToString("yyyy-MM-dd") & "' where id_transaksi='" & kodetrans.ToString & "'")
                'masukkan Gambar
                Dim Command = New MySqlCommand("Update trans_do set path_upload=@imgfile where id_transaksi='" & kodetrans.ToString & "'", connect)
                connect.Open()
                Command.Parameters.Add(New MySqlParameter("@imgfile", MySqlDbType.LongBlob)).Value = arrpic
                Command.ExecuteNonQuery()
                connect.Close()
                'delete
                InsertInto("delete from dtrans_do where id_transaksi='" & kodetrans.ToString & "'")
                'insert baru
                Dim rows As DataRow
                For i = 0 To GridView1.DataRowCount - 1
                    rows = datasetdo.Tables.Item(0).Rows(i)
                    boolcek = InsertInto("insert into dtrans_do (id_transaksi,id_barang,berat_per_kg,jumlah_satuan) values('" & kodetrans.ToString & "','" & rows("namabarang") & "','" & rows("berat") & "','" & rows("kgsatuan") & "')")
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
                    Dim update As Boolean = InsertInto("update trans_do set keterangan='" & RichTextBox1.Text.ToString & "',berat_do='" & nominal & "',nominal_do='" & totaldo & "',nominal_komp='" & total & "',no_do='" & nomerdo.Text & "',tgl_jam='" & tgldo.Value.Date.ToString("yyyy-MM-dd") & "',tgl_terkirim='" & tanggalterkirim.Value.Date.ToString("yyyy-MM-dd") & "',jatuh_tempo='" & tanggaljatuhtempo.Value.Date.ToString("yyyy-MM-dd") & "',total_bayar='" & total.ToString & "' where id_transaksi='" & kodetrans.ToString & "'")
                    'masukkan Gambar
                    Dim Command = New MySqlCommand("Update trans_do set path_upload=@imgfile where id_transaksi='" & kodetrans.ToString & "'", connect)
                    connect.Open()
                    Command.Parameters.Add(New MySqlParameter("@imgfile", MySqlDbType.LongBlob)).Value = arrpic
                    Command.ExecuteNonQuery()
                    connect.Close()
                    'delete
                    InsertInto("delete from dtrans_do where id_transaksi='" & kodetrans.ToString & "'")
                    'insert baru
                    Dim rows As DataRow
                    For i = 0 To GridView1.DataRowCount - 1
                        rows = datasetdo.Tables.Item(0).Rows(i)
                        boolcek = InsertInto("insert into dtrans_do (id_transaksi,id_barang,berat_per_kg,jumlah_satuan) values('" & kodetrans.ToString & "','" & rows("namabarang") & "','" & rows("berat") & "','" & rows("kgsatuan") & "')")
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
        datasetdo.Tables(0).Rows.Clear()
        datasetdo.Dispose()
        switch = False
    End Sub

    Sub jurnal()
        Dim totalkredit As Integer = totaldo * -1
        InsertInto("update jurnal set tgl='" & tgldo.Value.Date.ToString("yyyy-MM-dd") & "' where no_jurnal='" & kodetrans.ToString & "'")
        InsertInto("delete from djurnal where no_jurnal='" & kodetrans.ToString & "'")
        InsertInto("insert into djurnal values('" & kodetrans.ToString & "','" & defpiutang & "','','" & totaldo.ToString & "')")
        InsertInto("insert into djurnal values('" & kodetrans.ToString & "','" & defpendapatan & "','','" & totalkredit.ToString & "')")
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub GridView1_RowCountChanged(sender As Object, e As EventArgs) Handles GridView1.RowCountChanged
        If Switch = True Then
            Dim asd As DataRow
            Dim berat As Double = 0
            Dim satuan As String = ""
            If CStr(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "kgsatuan")) = "" Then

            Else
                For i = 0 To datasetdo.Tables.Item(0).Rows.Count - 1
                    asd = datasetdo.Tables.Item(0).Rows(i)
                    berat = Scalar("SELECT berat FROM mbarang WHERE id_barang='" & asd("namabarang") & "'")
                    satuan = Scalar("SELECT satuan FROM msatuan LEFT JOIN mbarang ON msatuan.id_satuan=mbarang.id_satuan WHERE id_barang='" & asd("namabarang") & "'")

                    If berat = 0 Then
                        berat = 0
                    End If
                    asd("berat") = berat * CDbl(GridView1.GetRowCellValue(i, "kgsatuan"))
                    asd("satuan") = satuan
                Next
            End If
        Else
            Switch = True
            Exit Sub
        End If
    End Sub



    Private Sub GridView1_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Try
            If datasetdo.Tables(0).Rows.Count > 0 Then
                If e.RowHandle > -1 Then
                    If (e.Column.Name = "kgsatuan" Or e.Column.Name = "namabarang") And CStr(GridView1.GetRowCellValue(e.RowHandle, "kgsatuan")) <> "" Then
                        If Not IsNumeric(GridView1.GetRowCellValue(e.RowHandle, "kgsatuan")) Then
                            MessageBox.Show("Kolom Satuan Hanya Boleh Diisi Dengan Angka", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            Dim asd As DataRow
                            Dim berat As String = ""
                            Dim satuan As String = ""
                            asd = datasetdo.Tables.Item(0).Rows(e.RowHandle)
                            berat = Scalar("SELECT berat FROM mbarang WHERE id_barang='" & asd("namabarang") & "'")
                            satuan = Scalar("SELECT satuan FROM msatuan LEFT JOIN mbarang ON msatuan.id_satuan=mbarang.id_satuan WHERE id_barang='" & asd("namabarang") & "'")

                            If berat = "" Then
                                berat = "0"
                            End If
                            asd("berat") = CDbl(berat) * CDbl(GridView1.GetRowCellValue(e.RowHandle, "kgsatuan"))
                            asd("satuan") = satuan
                        End If

                    End If
                End If

            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click
        switch = True
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
                nominal = CInt(TextBox1.Text)
                nominalparse = nominal.ToString("N0")
                TextBox1.Text = nominalparse
                koma = True
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        Try
            If koma = False Then
                nominal = CInt(TextBox1.Text)
                nominalparse = nominal.ToString("N0")
                TextBox1.Text = nominalparse
            End If
            koma = False
        Catch ex As Exception

        End Try
    End Sub
End Class