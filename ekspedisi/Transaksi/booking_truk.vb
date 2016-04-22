Imports MySql.Data.MySqlClient
Public Class booking_truk
    Public trukbook As String = ""
    Public principlebook As String = ""
    Public rutebook As String = ""
    Public tabelsupir As New DataTable
    Dim cek As Boolean = False
    Dim tabelkontak As New DataTable
    Public max As Integer = 0
    Dim kode As String = ""
    Dim ceking As Boolean = False
    Private Sub booking_truk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            autogen()
            id.Text = kode
            grid()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ButtonEdit4_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit4.ButtonClick
        If principlebook = "" Then
            MessageBox.Show("Pilih principle terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            rute_booking.ShowDialog()
        End If
    End Sub

    Private Sub ButtonEdit1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit1.ButtonClick
        truk_booking.ShowDialog()
    End Sub

    Private Sub ButtonEdit2_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit2.ButtonClick
        principle_booking.ShowDialog()
    End Sub

    Private Sub GridControl2_DoubleClick(sender As Object, e As EventArgs) Handles GridControl2.DoubleClick
        If rutebook = "" Then
            MessageBox.Show("Pilih rute terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            supir_booking.ShowDialog()
        End If

    End Sub

    Private Sub booking_truk_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If ceking = True Then

            Else
                If ButtonEdit1.Text <> "" Or ButtonEdit2.Text <> "" Or ButtonEdit4.Text <> "" Then
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
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub reset()
        ButtonEdit1.Text = ""
        ButtonEdit2.Text = ""
        ButtonEdit4.Text = ""
        principlebook = ""
        trukbook = ""
        rutebook = ""
        tabelkontak.Rows.Clear()
        tabelsupir.Rows.Clear()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Sub grid()
        Try
            'buat kolom-kolom di gridview
            If tabelkontak.Columns.Count < 1 Then
                tabelkontak.Columns.Add("ETA (Jam)")
                tabelkontak.Columns.Add("Contact Person")
                tabelkontak.Columns.Add("Nomor Telepon")
                tabelkontak.Columns.Add("Alamat")
            End If

            Dim ar(3) As String
            For i = 0 To 3
                ar(i) = ""
            Next
            tabelkontak.Rows.Add(ar(0), ar(1), ar(2), ar(3))
            GridControl1.DataSource = tabelkontak

            If tabelsupir.Columns.Count < 1 Then
                tabelsupir.Columns.Add("Kode Supir")
                tabelsupir.Columns.Add("Nama Supir")
                tabelsupir.Columns.Add("Jumlah DP (Rp)")
                tabelsupir.Columns.Add("Total Bayar (Rp)")
            End If

            Dim arr(2) As String
            For i = 0 To 2
                arr(i) = ""
            Next
            tabelsupir.Rows.Clear()
            tabelsupir.Rows.Add(arr(0), arr(1), arr(2))
            GridControl2.DataSource = tabelsupir

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            If trukbook = "" Then
                MessageBox.Show("Harap pilih truk terlebih dahulu sebelum melakukan booking", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If Not IsNumeric(gridkontak.GetRowCellValue(gridkontak.FocusedRowHandle, "ETA (Jam)")) Then
                    MessageBox.Show("Harap mengisi data kontak dengan format yang sesuai", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If GridControl2.DataSource Is tabelsupir Then
                        MessageBox.Show("Harap pilih supir terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        If CInt(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Total Bayar (Rp)")) > max Then
                            MessageBox.Show("Nominal Total tidak diperbolehkan melebihi nominal maksimum yang telah ditentukan", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            If CInt(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Jumlah DP (Rp)")) > CInt(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Total Bayar (Rp)")) Then
                                MessageBox.Show("Nominal DP tidak diperbolehkan melebihi Nominal Total Bayar", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Else
                                autogen()
                                Dim jam As New DateTime
                                jam = Convert.ToDateTime(TimeEdit1.Text).ToString("HH:mm:ss")
                                Dim insert As Boolean = InsertInto("insert into booking_truk values('" + kode.ToString + "',now(),'" + DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + jam + "','" + gridkontak.GetRowCellValue(gridkontak.FocusedRowHandle, "ETA (Jam)") + "','" + principlebook + "','" + GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Kode Supir") + "','" + trukbook + "','" + RichTextBox2.Text.ToString + "','" + rutebook + "','" + gridkontak.GetRowCellValue(GridView2.FocusedRowHandle, "Alamat") + "','" + gridkontak.GetRowCellValue(GridView2.FocusedRowHandle, "Contact Person") + "','" + gridkontak.GetRowCellValue(GridView2.FocusedRowHandle, "Nomor Telepon") + "','" + GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Jumlah DP (Rp)") + "','" + GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Total Bayar (Rp)") + "',1,1)")
                                If insert = True Then
                                    MessageBox.Show("Sukses")
                                    ceking = True
                                    Me.Close()
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

    Private Sub ButtonEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles ButtonEdit2.EditValueChanged
        Try
            If ButtonEdit2.Text = "" Then

            Else
                rutebook = ""
                ButtonEdit4.Text = ""
                grid()
                tabelkontak.Rows.Clear()
                Dim dt As New DataTable
                dt = DtTable("select nama_kontak,tel1 from mkontakprinciple where id_principle='" + principlebook + "'")
                If dt.Rows.Count < 1 Then
                    Dim alamat As String = ""
                    alamat = Scalar("select alamat from mprinciple where id_principle='" + principlebook + "'")
                    Dim ar(3) As String
                    ar(0) = "0"
                    ar(1) = ""
                    ar(2) = ""
                    ar(3) = alamat
                    tabelkontak.Rows.Add(ar(0), ar(1), ar(2), ar(3))
                    GridControl1.DataSource = tabelkontak
                Else
                    Dim alamat As String = ""
                    alamat = Scalar("select alamat from mprinciple where id_principle='" + principlebook + "'")
                    Dim ar(3) As String
                    ar(0) = "0"
                    ar(1) = dt.Rows(0).Item("nama_kontak").ToString
                    ar(2) = dt.Rows(0).Item("tel1").ToString
                    ar(3) = alamat
                    tabelkontak.Rows.Add(ar(0), ar(1), ar(2), ar(3))
                    GridControl1.DataSource = tabelkontak
                End If
            End If
           

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub GridControl2_DataSourceChanged(sender As Object, e As EventArgs) Handles GridControl2.DataSourceChanged
        For i = 0 To GridView2.Columns.Count - 3
            GridView2.Columns(i).OptionsColumn.AllowEdit = False
        Next




    End Sub
    Sub autogen()
        Try
            Dim tanggal As New DataTable
            Dim tgl As String = "BK" + Today.Date.ToString("yyyyMMdd")
            tanggal = DtTable("select * from booking_truk where substring(id_booking,1,10) = '" & tgl & "'")
            Dim hitung As String = tanggal.Rows.Count() + 1
            While hitung.LongCount < 5
                hitung = "0" + hitung
            End While
            kode = tgl + hitung
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       

    End Sub
    Sub resetall()

    End Sub
End Class