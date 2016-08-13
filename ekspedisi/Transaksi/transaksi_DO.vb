Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views
Imports System.IO
Imports DevExpress.XtraGrid.Views.Base

Public Class transaksi_DO
    Public kodeprinciple As String = ""
    Public namaprinciple As String = ""
    Public idprinciple As String = ""
    Dim cek As Boolean = False
    Dim price As Integer = 0
    Dim total As Integer = 0
    Dim kode As String = ""
    Dim defpiutang As String = ""
    Dim defpendapatan As String = ""
    Dim switch As Boolean = False
    Dim tabelbarang As New DataTable
    Dim nominal As Integer = 0
    Dim nominalparse As String = ""
    Dim koma As Boolean = False
    Dim totaldo As Integer = 0
    Private Sub idbooking_EditValueChanged(sender As Object, e As EventArgs) Handles idbooking.EditValueChanged
        Try

            switch = False
            If idbooking.Text = "" Then

            Else
                kode = idbooking.Text.ToString
                tgldo.Value = Convert.ToDateTime(tgldo.Value.Date.ToLongDateString & " " & "00:00:00")
                'select nama principle
                Dim data As String = ""
                data = Scalar("select nama_principle from mprinciple,booking_truk where id_booking='" & kode & "' and mprinciple.id_principle=booking_truk.id_principle")
                TextBox2.Text = data
                namaprinciple = data
                'select tanggal kirim
                tanggalterkirim.Value = Scalar("select tgl from booking_truk where id_booking='" & kode & "'")
                'select id principle
                Dim data2 As String = ""
                data2 = Scalar("select booking_truk.id_principle from booking_truk where id_booking='" & kode & "'")
                idprinciple = data2

                'select rute
                Dim rute As String = ""
                rute = Scalar("select id_rute from booking_truk where id_booking='" & idbooking.Text.ToString & "' and id_principle='" & idprinciple & "'")

                'select price untuk rute
                price = Scalar("select price_per_unit from mrute where id_rute='" & rute & "'")


                Dim dtbarang As New DataTable
                dtbarang = DtTable("select id_barang `Kode Barang`,nama_barang `Nama Barang` from mbarang where id_principle='" & idprinciple.ToString & "'")
                RepositoryItemLookUpEdit1.DataSource = dtbarang
                RepositoryItemLookUpEdit1.ValueMember = "Kode Barang"
                RepositoryItemLookUpEdit1.DisplayMember = "Nama Barang"


                tabelbarang = DtTable("SELECT dbooking_truk.id_barang `namabarang`,qty `berat`,jumlah_satuan `kgsatuan`,satuan
                                FROM dbooking_truk LEFT JOIN mbarang ON dbooking_truk.id_barang=mbarang.id_barang
                                LEFT JOIN msatuan ON mbarang.id_satuan=msatuan.id_satuan WHERE id_booking='" & kode & "'")

                Dim mreader As DataTableReader

                mreader = tabelbarang.CreateDataReader
                datasetdo.Tables(0).Load(mreader)
                GridControl1.DataSource = datasetdo
                GridControl1.DataMember = "Table1"


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub transaksi_DO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            generate()
            tanggaljatuhtempo.Value = tanggalterkirim.Value.Date.AddDays(30)
            defpiutang = Scalar("select id_akun from control_account where keterangan='Def. Akun Piutang'")
            defpendapatan = Scalar("select id_akun from control_account where keterangan='Def. Akun Pendapatan'")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub idbooking_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles idbooking.ButtonClick
        Try
            Me.Visible = False
            booking_do.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
        Try
            kodeprinciple = Scalar("select id_principle from booking_truk where id_booking='" & idbooking.Text & "'")
            add_item.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub GroupControl3_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl3.Paint

    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click
        switch = True
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try

            If tanggalterkirim.Value < tgldo.Value Then
                MessageBox.Show("Tanggal DO tidak diperbolehkan melebihi Tanggal Kirim", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If tanggalterkirim.Value > tanggaljatuhtempo.Value Then
                    MessageBox.Show("Tanggal Kirim tidak diperbolehkan melebihi Tanggal Jatuh Tempo", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If nomerdo.Text = "" Then
                        MessageBox.Show("Mohon lengkapi data terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        If GridView1.DataRowCount < 1 Then
                            MessageBox.Show("Tidak ada barang yang terpilih", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            If TextBox1.Text = "" Then
                                MessageBox.Show("Harap Isi Nominal DO Terlebih Dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            Else

                                If PictureEdit1.Text = "" Then
                                    Dim msg As Integer = MessageBox.Show("Bukti DO tidak ditemukan, apakah anda ingin melanjutkan tanpa mencatumkan bukti DO?", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                                    If msg = DialogResult.OK Then
                                        insertnoprint()
                                    Else

                                    End If
                                Else
                                    insertnoprint()
                                End If


                            End If
                        End If
                    End If
                End If


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Sub insertnoprint()
        Dim arrpic() As Byte
        If PictureEdit1.Text = "" Then
        Else
            Dim ms As New MemoryStream
            PictureEdit1.Image.Save(ms, PictureEdit1.Image.RawFormat)
            arrpic = ms.GetBuffer()
            ms.Close()
        End If

        Dim sum As Integer = 0
        sum = GridView1.Columns("berat").SummaryItem.SummaryValue.ToString

        If sum - nominal > 100 And RichTextBox1.Text = "" Then
            MessageBox.Show("Total Berat DO Dibawah Total Berat Yang Seharusnya, Harap Isi Keterangan", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            total = sum * price
            totaldo = nominal * price
            generate()
            Dim totalkredit As Integer = totaldo * -1
            InsertInto("insert into trans_do values('" & kode.ToString & "','" & idbooking.Text.ToString & "','" & tgldo.Value.Date.ToString("yyyy-MM-dd") & "','" & tanggalterkirim.Value.Date.ToString("yyyy-MM-dd") & "','" & nomerdo.Text.ToString & "','" & username.ToString & "','" & totaldo & "','" & total & "',0,0,0,0,'" & tanggaljatuhtempo.Value.Date.ToString("yyyy-MM-dd") & "','" & RichTextBox1.Text.ToString & "',0,1,0)")
            Dim rows As DataRow
            For i = 0 To GridView1.DataRowCount - 1
                rows = datasetdo.Tables.Item(0).Rows(i)
                InsertInto("insert into dtrans_do (id_transaksi,id_barang,berat_per_kg,jumlah_satuan) values('" & kode.ToString & "','" & rows("namabarang") & "','" & rows("berat") & "','" & rows("kgsatuan") & "')")
            Next

            'masukkan Gambar
            Dim Command = New MySqlCommand("Update trans_do set path_upload=@imgfile where id_transaksi='" & kode.ToString & "'", connect)
            connect.Open()
            Command.Parameters.Add(New MySqlParameter("@imgfile", MySqlDbType.LongBlob)).Value = arrpic
            Command.ExecuteNonQuery()
            connect.Close()

            InsertInto("update booking_truk set s=0 where id_booking='" & idbooking.Text.ToString & "'")
            Dim ins As Boolean = InsertInto("insert into jurnal values('" & kode.ToString & "','" & tgldo.Value.Date.ToString("yyyy-MM-dd") & "')")
            InsertInto("insert into djurnal values('" & kode.ToString & "','" & defpiutang & "','','" & totaldo.ToString & "')")
            InsertInto("insert into djurnal values('" & kode.ToString & "','" & defpendapatan & "','','" & totalkredit.ToString & "')")
            If ins = True Then
                MessageBox.Show("Delivery Order No." & kode.ToString & " berhasil dilakukan", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                audit()
                cek = False
            End If
            res()
            Me.Close()
        End If

    End Sub
    Sub scando()

    End Sub
    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Transaksi DO"
        Dim aktivitas As String = "Add DO: " & kode.ToString
        auditlog(user, kompname, form, aktivitas)
    End Sub

    Private Sub tanggalterkirim_ValueChanged(sender As Object, e As EventArgs) Handles tanggalterkirim.ValueChanged
        tanggaljatuhtempo.Value = tanggalterkirim.Value.Date.AddDays(30)
    End Sub


    Private Sub GridView1_DataSourceChanged(sender As Object, e As EventArgs) Handles GridView1.DataSourceChanged
        Try
            For i = 0 To add_item.barangset.Columns.Count - 1
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

    End Sub

    Private Sub transaksi_DO_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If nomerdo.Text <> "" Or GridView1.DataRowCount > 0 Then
                cek = True
            Else
                cek = False
            End If
            If cek = True Then
                Dim msg As Integer = MessageBox.Show("Apakah anda yakin ingin menutup form ini? Semua data yang belum disimpan akan hilang", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If msg = DialogResult.OK Then
                    res()
                    master_DO.master_DO_Load(sender, e)
                Else
                    e.Cancel = True
                End If
            Else
                res()
                master_DO.master_DO_Load(sender, e)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Sub res()
        idbooking.Text = ""
        nomerdo.Text = ""
        add_item.barangset.Rows.Clear()
        PictureEdit1.Text = ""
        switch = False
        tabelbarang.Clear()
        tabelbarang.Dispose()
        datasetdo.Tables(0).Rows.Clear()
        datasetdo.Dispose()

    End Sub

    Sub generate()
        Try

            Dim tanggal As New DataTable
            Dim tgl As String = "TDO" & Today.Date.ToString("yyMMdd")
            tanggal = DtTable("select * from trans_do where substring(id_transaksi,1,9) = '" & tgl & "'")
            Dim hitung As String = tanggal.Rows.Count() + 1
            While hitung.LongCount < 5
                hitung = "0" & hitung
            End While
            kode = tgl & hitung
            kodetrans.Text = kode
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Try

            If tanggalterkirim.Value < tgldo.Value Then
                MessageBox.Show("Tanggal DO tidak diperbolehkan melebihi Tanggal Kirim", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If tanggalterkirim.Value > tanggaljatuhtempo.Value Then
                    MessageBox.Show("Tanggal Kirim tidak diperbolehkan melebihi Tanggal Jatuh Tempo", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If nomerdo.Text = "" Then
                        MessageBox.Show("Mohon lengkapi data terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        If GridView1.DataRowCount < 1 Then
                            MessageBox.Show("Tidak ada barang yang terpilih", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            If TextBox1.Text = "" Then
                                MessageBox.Show("Harap Isi Nominal DO Terlebih Dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            Else
                                If PictureEdit1.Text = "" Then
                                    Dim msg As Integer = MessageBox.Show("Bukti DO tidak ditemukan, apakah anda ingin melanjutkan tanpa mencatumkan bukti DO?", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                                    If msg = DialogResult.OK Then
                                        insertprint()
                                    Else

                                    End If
                                Else
                                    insertprint()
                                End If

                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub insertprint()
        Dim arrpic() As Byte
        If PictureEdit1.Text = "" Then
        Else
            Dim ms As New MemoryStream
            PictureEdit1.Image.Save(ms, PictureEdit1.Image.RawFormat)
            arrpic = ms.GetBuffer()
            ms.Close()
        End If

        Dim sum As Integer = 0
        sum = GridView1.Columns("berat").SummaryItem.SummaryValue.ToString
        If sum - nominal > 100 And RichTextBox1.Text = "" Then
            MessageBox.Show("Total Berat DO Dibawah Total Berat Yang Seharusnya, Harap Isi Keterangan", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            total = sum * price
            totaldo = nominal * price
            generate()
            Dim totalkredit As Integer = totaldo * -1
            InsertInto("insert into trans_do values('" & kode.ToString & "','" & idbooking.Text.ToString & "','" & tgldo.Value.Date.ToString("yyyy-MM-dd") & "','" & tanggalterkirim.Value.Date.ToString("yyyy-MM-dd") & "','" & nomerdo.Text.ToString & "','" & totaldo & "','" & username.ToString & "','" & total & "',0,0,0,0,'" & tanggaljatuhtempo.Value.Date.ToString("yyyy-MM-dd") & "','" & RichTextBox1.Text.ToString & "',0,1,0)")
            Dim rows As DataRow
            For i = 0 To GridView1.DataRowCount - 1
                rows = datasetdo.Tables.Item(0).Rows(i)
                InsertInto("insert into dtrans_do (id_transaksi,id_barang,berat_per_kg,jumlah_satuan) values('" & kode.ToString & "','" & rows("namabarang") & "','" & rows("berat") & "','" & rows("kgsatuan") & "')")
            Next

            'masukkan Gambar
            Dim Command = New MySqlCommand("Update trans_do set path_upload=@imgfile where id_transaksi='" & kode.ToString & "'", connect)
            connect.Open()
            Command.Parameters.Add(New MySqlParameter("@imgfile", MySqlDbType.LongBlob)).Value = arrpic
            Command.ExecuteNonQuery()
            connect.Close()

            InsertInto("update booking_truk set s=0 where id_booking='" & idbooking.Text.ToString & "'")
            Dim ins As Boolean = InsertInto("insert into jurnal values('" & kode.ToString & "','" & tgldo.Value.Date.ToString("yyyy-MM-dd") & "')")
            InsertInto("insert into djurnal values('" & kode.ToString & "','" & defpiutang & "','','" & totaldo.ToString & "')")
            InsertInto("insert into djurnal values('" & kode.ToString & "','" & defpendapatan & "','','" & totalkredit.ToString & "')")
            If ins = True Then
                MessageBox.Show("Delivery Order No." & kode.ToString & " berhasil dilakukan", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                audit()
                cek = False
                frm_notado.transid = kode
                frm_notado.ShowDialog()
            End If
            res()
            Me.Close()
        End If

    End Sub

    Private Sub idbooking_Click(sender As Object, e As EventArgs) Handles idbooking.Click
        Try
            Me.Visible = False
            booking_do.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
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

    Private Sub LabelControl8_Click(sender As Object, e As EventArgs) Handles LabelControl8.Click

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
End Class