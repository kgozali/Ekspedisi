Imports MySql.Data.MySqlClient
Public Class add_rute
    Dim cek As Boolean
    Dim cbasal As New DataTable
    Dim ctujuan As New DataTable
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub add_rute_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If cek = True Then
                Dim msg As Integer = MessageBox.Show("Apakah anda yakin ingin menutup form ini? Semua data yang belum disimpan akan hilang", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If msg = DialogResult.OK Then
                    add_rute_Load(sender, e)
                    Reset()
                Else
                    e.Cancel = True
                End If
            Else
                add_rute_Load(sender, e)
                Reset()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        If hargaunit.Text = "" Or unit.Text = "" Then
            MessageBox.Show("Mohon lengkapi data terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim cc As New DataTable
            cc = DtTable("select * from mrute where kota_asal = '" & ComboBox1.SelectedValue.ToString & "' and kota_tujuan = '" & ComboBox2.SelectedValue.ToString & "'")
            If cc.Rows.Count = 0 Then
                Try
                    'insert ke dalam database
                    InsertInto("insert into mrute values ('" & id.Text & "','" & ComboBox1.SelectedValue.ToString & "','" & ComboBox2.SelectedValue.ToString & "','" & hargaunit.Text & "','" & unit.Text & "') ")
                    'konfirmasi melakukan booking ulang
                    Dim msg As Integer = MsgBox("Booking berhasil dilakukan, Apakah anda ingin melakukan input kembali?", MsgBoxStyle.YesNo, "System Message")
                    If msg = DialogResult.Yes Then
                        add_rute_Load(sender, e)
                        Reset()
                    Else
                        cek = False
                        Me.Close()
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Rute telah pernah dibuat", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            
        End If



    End Sub

    Private Sub add_rute_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tanggal As New DataTable
        Dim tgl As String = "MR" + Today.Date.ToString("yyyyMMdd")
        tanggal = DtTable("select * from mrute where substring(ID_rute,1,10) = '" & tgl & "'")
        Dim hitung As String = tanggal.Rows.Count() + 1
        While hitung.LongCount < 5
            hitung = "0" + hitung
        End While
        id.Text = tgl + hitung

        cbasal = DtTable("select kota from mkota")
        ComboBox1.DataSource = cbasal
        ComboBox1.DisplayMember = "Kota"
        ComboBox1.ValueMember = "Kota"
        ctujuan = DtTable("select kota from mkota")
        ComboBox2.DataSource = ctujuan
        ComboBox2.DisplayMember = "Kota"
        ComboBox2.ValueMember = "Kota"
        unit.Text = ""
        hargaunit.Text = ""

    End Sub


    Private Sub hargaunit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles hargaunit.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
        'pengecekan untuk mengetahui apakah form sudah di edit atau belum (jika belum, untuk menghindari system warning pertanyaan)
        If hargaunit.Text = "" Then
            cek = False
        Else
            cek = True
        End If
    End Sub

    Private Sub unit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles unit.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
        'pengecekan untuk mengetahui apakah form sudah di edit atau belum (jika belum, untuk menghindari system warning pertanyaan)
        If unit.Text = "" Then
            cek = False
        Else
            cek = True
        End If
    End Sub

 
End Class