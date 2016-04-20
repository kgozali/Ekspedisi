Imports MySql.Data.MySqlClient
Public Class booking_truk
    Public trukbook As String = ""
    Public principlebook As String = ""
    Public rutebook As String = ""
    Public tabelsupir As New DataTable
    Dim cek As Boolean = False
    'tes
    Private Sub booking_truk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim tanggal As New DataTable
            Dim tgl As String = "BK" + Today.Date.ToString("yyyyMMdd")
            tanggal = DtTable("select * from trans_do where substring(id_transaksi,1,10) = '" & tgl & "'")
            Dim hitung As String = tanggal.Rows.Count() + 1
            While hitung.LongCount < 5
                hitung = "0" + hitung
            End While
            id.Text = tgl + hitung

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
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Sub grid()
        Try
            'buat kolom-kolom di gridview
            Dim tabelkontak As New DataTable
            If tabelkontak.Columns.Count < 1 Then
                tabelkontak.Columns.Add("ETA (Jam)")
                tabelkontak.Columns.Add("Contact Person")
                tabelkontak.Columns.Add("Nomor Telepon")
                tabelkontak.Columns.Add("Alamat")
            Else

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
            tabelsupir.Rows.Add(arr(0), arr(1), arr(2))
            GridControl2.DataSource = tabelsupir
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click

    End Sub

    Private Sub ButtonEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles ButtonEdit1.EditValueChanged

    End Sub

    Private Sub ButtonEdit4_EditValueChanged(sender As Object, e As EventArgs) Handles ButtonEdit4.EditValueChanged

    End Sub

    Private Sub ButtonEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles ButtonEdit2.EditValueChanged
        rutebook = ""
        ButtonEdit4.Text = ""
    End Sub

    Private Sub GridControl2_DataSourceChanged(sender As Object, e As EventArgs) Handles GridControl2.DataSourceChanged
        For i = 0 To GridView2.Columns.Count - 3
            GridView2.Columns(i).OptionsColumn.AllowEdit = False
        Next
    End Sub
End Class