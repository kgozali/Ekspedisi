Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views

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
    Private Sub idbooking_EditValueChanged(sender As Object, e As EventArgs) Handles idbooking.EditValueChanged
        Try
            'select nama principle
            Dim data As String = ""
            data = Scalar("select nama_principle from mprinciple,booking_truk where id_booking='" + idbooking.Text.ToString + "' and mprinciple.id_principle=booking_truk.id_principle")
            TextBox2.Text = data
            namaprinciple = data

            'select id principle
            Dim data2 As String = ""
            data2 = Scalar("select booking_truk.id_principle from booking_truk where id_booking='" + idbooking.Text.ToString + "'")
            idprinciple = data2

            'select rute
            Dim rute As String = ""
            rute = Scalar("select id_rute from booking_truk where id_booking='" + idbooking.Text.ToString + "' and id_principle='" + idprinciple + "'")

            'select price untuk rute
            price = Scalar("select price_per_unit from mrute where id_rute='" + rute + "'")
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

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            kodeprinciple = Scalar("select id_principle from booking_truk where id_booking='" + idbooking.Text + "'")
            add_item.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub GroupControl3_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl3.Paint

    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            Dim kem As String = ""
            If nomerdo.Text = "" Then
                MessageBox.Show("Mohon lengkapi data terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If GridView1.DataRowCount < 1 Then
                    MessageBox.Show("Tidak ada barang yang terpilih", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim sum As Integer = 0
                    sum = GridView1.Columns("Berat (Kilogram)").SummaryItem.SummaryValue.ToString
                    total = sum * price
                    generate()
                    Dim totalkredit As Integer = total * -1
                    InsertInto("insert into trans_do values('" + kode.ToString + "','" + idbooking.Text.ToString + "',now(),'" + tanggalterkirim.Value.Date.ToString("yyyy-MM-dd") + "','" + nomerdo.Text.ToString + "','',0,0,0,'" + tanggaljatuhtempo.Value.Date.ToString("yyyy-MM-dd") + "',0,1)")
                    For i = 0 To GridView1.DataRowCount - 1
                        InsertInto("insert into dtrans_do values('" + kode.ToString + "','" + GridView1.GetRowCellValue(i, "Kode Barang").ToString + "','" + GridView1.GetRowCellValue(i, "Berat (Kilogram)").ToString + "','')")
                    Next
                    InsertInto("update booking_truk set s=0 where id_booking='" + idbooking.Text.ToString + "'")
                    Dim ins As Boolean = InsertInto("insert into jurnal values('" + kode.ToString + "',now())")
                    InsertInto("insert into djurnal values('" + kode.ToString + "','" + defpiutang + "','','" + total.ToString + "')")
                    InsertInto("insert into djurnal values('" + kode.ToString + "','" + defpendapatan + "','','" + totalkredit.ToString + "')")
                    If ins = True Then
                        MessageBox.Show("Delivery Order berhasil dilakukan, untuk melakukan Delivery Order lagi silahkan membuka Form Delivery Order kembali", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    res()
                    Me.Close()

                End If


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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

    End Sub

    Sub generate()
        Try

            Dim tanggal As New DataTable
            Dim tgl As String = "TDO" + Today.Date.ToString("yyMMdd")
            tanggal = DtTable("select * from trans_do where substring(id_transaksi,1,9) = '" & tgl & "'")
            Dim hitung As String = tanggal.Rows.Count() + 1
            While hitung.LongCount < 5
                hitung = "0" + hitung
            End While
            kode = tgl + hitung
            kodetrans.Text = kode
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub
End Class