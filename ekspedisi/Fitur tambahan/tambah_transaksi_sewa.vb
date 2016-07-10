Public Class tambah_transaksi_sewa
    Dim kode As String = ""
    Public customersewa As String = ""
    Private Sub idkaryawan_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles idkaryawan.ButtonClick
        add_customer_master_sewa.ShowDialog()
    End Sub

    
    Private Sub tambahmobil_Click(sender As Object, e As EventArgs) Handles tambahmobil.Click
        add_mobil_transaksi.ShowDialog()
    End Sub

    Private Sub tambah_transaksi_sewa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autogen()
        id.Text = kode
    End Sub

    Sub autogen()
        Try
            Dim tanggal As New DataTable
            Dim tgl As String = "SM" + Today.Date.ToString("yyMMdd")
            tanggal = DtTable("select * from trans_mobil where substring(id_tmobil,1,8) = '" & tgl & "'")
            Dim hitung As String = tanggal.Rows.Count() + 1
            While hitung.LongCount < 5
                hitung = "0" + hitung
            End While
            kode = tgl + hitung
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub idkaryawan_Click(sender As Object, e As EventArgs) Handles idkaryawan.Click
        add_customer_master_sewa.ShowDialog()
    End Sub

    Private Sub tambah_transaksi_sewa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If customersewa <> "" Then
            Dim msg As Integer = MessageBox.Show("Apakah anda yakin ingin menutup form ini? Semua data yang belum disimpan akan hilang", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If msg = DialogResult.OK Then
                reset()
            Else
                e.Cancel = True

            End If
        End If

    End Sub
    Sub reset()
        kodesewa.Text = ""
        idkaryawan.Text = ""
        email.Text = ""
        nomortelepon.Text = ""
        kotaasal.Text = ""
        customersewa = ""
        Dim dt As New DataTable
        GridControl1.DataSource = dt
        DateTimePicker1.ResetText()

    End Sub
End Class