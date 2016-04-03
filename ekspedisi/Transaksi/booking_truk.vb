Imports MySql.Data.MySqlClient
Public Class booking_truk
    Dim cbprinciple As New DataTable
    Private Sub booking_truk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cbsupir As New DataTable
        Dim cbtruk As New DataTable
        Dim cbrute As New DataTable
        Dim asd As String = ""
        Try
            cbprinciple = DtTable("select id_principle `Kode Principle`,nama_principle `Nama Principle` from mprinciple")
            ComboBox1.DataSource = cbprinciple
            ComboBox1.DisplayMember = "Nama Principle"
            ComboBox1.ValueMember = "Kode Principle"

            cbsupir = DtTable("select id_karyawan `Kode Karyawan`,nama_karyawan `Nama Karyawan` from mkaryawan")
            ComboBox2.DataSource = cbsupir
            ComboBox2.DisplayMember = "Nama Karyawan"
            ComboBox2.ValueMember = "Kode Karyawan"

            cbtruk = DtTable("select id_truk `Kode Truk`,no_pol `Nomor Polisi` from mtruk")
            ComboBox3.DataSource = cbtruk
            ComboBox3.DisplayMember = "Kode Truk"
            ComboBox3.ValueMember = "Nomor Polisi"

            asd = "select id_rute `Kode Rute`,concat(kota_asal,' - ',kota_tujuan) `Rute` from mrute"
            cbrute = DtTable(asd)
            ComboBox4.DataSource = cbrute
            ComboBox4.DisplayMember = "Rute"
            ComboBox4.ValueMember = "Kode Rute"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

 
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim tel As String = ""
        Dim kontak As String = ""

        tel = Scalar("select tel1 from mkontakprinciple where id_principle='" + ComboBox1.SelectedValue.ToString + "'")
        TextBox4.Text = tel

        kontak = Scalar("select nama_kontak from mkontakprinciple where id_principle='" + ComboBox1.SelectedValue.ToString + "'")
        TextBox3.Text = kontak



    End Sub

   
    Private Sub booking_truk_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Dim msg As Integer = MessageBox.Show("Apakah anda yakin ingin menutup form ini? Semua data yang belum disimpan akan hilang", "System Warning", MessageBoxButtons.OKCancel)
            If msg = DialogResult.OK Then
                booking_truk_Load(sender, e)
                reset()
            Else
                e.Cancel = True
            End If
        Catch ex As Exception

        End Try



        
        


    End Sub

    Sub reset()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
        DateTimePicker1.ResetText()
    End Sub
End Class