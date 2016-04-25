Imports MySql.Data.MySqlClient
Public Class kas_masuk
    Dim _modelayar As Integer
    Dim _mkeyid As String
    Private savestatus As Boolean = False
    Dim tbakunkas As DataTable
    Dim tbakundetil As DataTable
    Dim tbtruk As DataTable
    Dim isloaddata As Boolean = False

    Private Function hapusdata(mkeyid As String) As Boolean
        Dim vartr As MySql.Data.MySqlClient.MySqlTransaction
        Try
            connect.Open()
            vartr = connect.BeginTransaction()
            Dim command As New MySqlCommand()
            command.Connection = connect
            command.Transaction = vartr
            command.CommandText = "delete from trans_kas where id_transaksi_kas='" & mkeyid & "'"
            command.ExecuteNonQuery()
            command.CommandText = "delete from jurnal where no_jurnal='" & mkeyid & "'"
            command.ExecuteNonQuery()
            command.CommandText = "delete from dtrans_kas where id_transaksi_kas='" & mkeyid & "'"
            command.ExecuteNonQuery()
            command.CommandText = "delete from djurnal where no_jurnal='" & mkeyid & "'"
            command.ExecuteNonQuery()
            vartr.Commit()
            connect.Close()
            savestatus = True
        Catch ex As Exception
            savestatus = False
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Try
                vartr.Rollback()
            Catch ex2 As Exception
                MessageBox.Show(ex2.Message)
            End Try
        Finally
            If IsNothing(connect) = False Then
                If connect.State = ConnectionState.Open Then connect.Close()
            End If
            If savestatus Then
                'connect.Close()
                MessageBox.Show("Hapus transaksi kas  " + mkeyid + " berhasil")
                Me.Close()
            End If
        End Try
    End Function

    Public Function initform(ByVal modelayar As Integer, ByVal KeyID As String) As Boolean
        GridLookUpEdit1.Enabled = True
        RichTextBox1.Enabled = True
        DateTimePicker1.Enabled = True
        GridControl1.Enabled = True

        _mkeyid = KeyID
        _modelayar = modelayar
        '_griddataset = griddataset
        ResetValues()
        Select Case modelayar
            Case 1
                Me.Text = "Input Kas Masuk"
            Case 2
                loaddata(_mkeyid)
                Me.Text = "Edit Kas Masuk"
            Case 3
                loaddata(_mkeyid)
                Me.Text = "Hapus Kas Masuk"
        End Select

        Me.ShowDialog()
        Return savestatus
    End Function

    Private Sub loaddata(ByVal mkeyid As String)
        Dim lcdata As New DataTable
        Dim lcdtrow As DataRow
        lcdata = DtTable("select * from trans_kas where id_transaksi_kas='" & mkeyid & "'")

        If lcdata.Rows.Count > 0 Then
            lcdtrow = lcdata.Rows(0)
            isloaddata = True
            TextBox1.Text = lcdtrow("id_transaksi_kas")
            RichTextBox1.Text = lcdtrow("keterangan")
            DateTimePicker1.Value = lcdtrow("tgl")
            GridLookUpEdit1.EditValue = lcdtrow("id_akun_kas")
            isloaddata = False
        End If
        lcdata.Clear()
        DataSet1.Clear()
        DataSet1 = DtSetReturn("select * from dtrans_kas where id_transaksi_kas='" & mkeyid & "'", "datadetil")
        GridControl1.DataSource = DataSet1
        GridControl1.DataMember = "datadetil"

    End Sub

    Private Sub ResetValues()
        GridLookUpEdit1.EditValue = ""
        RepositoryItemLookUpEdit1.NullText = ""
        RepositoryItemLookUpEdit2.NullText = ""
        RichTextBox1.Text = ""
        DateTimePicker1.Value = tglserver()
        'TextBox1.Text = ""
        DataSet1.Clear()
    End Sub

    Private Function Validate() As Boolean
        'cek kode akun sudah ada tidak
        Dim retdata As Object
        If Trim(TextBox1.Text) = "" Then
            MessageBox.Show("No. Bukti belum di input")
            Return False
        End If

        If Trim(GridLookUpEdit1.EditValue) = "" Then
            MessageBox.Show("Akun Kas belum di input")
            Return False
        End If
        'cek tgl dengan periode aktif belum ada
        Return True
    End Function

    Private Sub kas_masuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tbakunkas = DtTable("select kode_akun,concat(nama_akun,' - ',kode_akun) descr from makun where detil=1 and tipe_akun='Kas&Bank' order by kode_akun")
        GridLookUpEdit1.Properties.DataSource = tbakunkas
        GridLookUpEdit1.Properties.DisplayMember = "descr"
        GridLookUpEdit1.Properties.ValueMember = "kode_akun"
        'LookUpEdit1.EditValue = ""

        tbakundetil = DtTable("select kode_akun,concat(nama_akun,'-',kode_akun) descr from makun where  detil=1 order by kode_akun")
        RepositoryItemLookUpEdit1.DataSource = tbakundetil
        RepositoryItemLookUpEdit1.DisplayMember = "descr"
        RepositoryItemLookUpEdit1.ValueMember = "kode_akun"
        tbtruk = DtTable(" select * from (select '' no_pol,0 id_truk union all select no_pol, id_truk from mtruk) x  order by no_pol")

        RepositoryItemLookUpEdit2.DataSource = tbtruk
        RepositoryItemLookUpEdit2.DisplayMember = "no_pol"
        RepositoryItemLookUpEdit2.ValueMember = "id_truk"
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim strsub As String
        Dim i As Integer = 0
        Dim flagval As Boolean
        Dim vartr As MySql.Data.MySqlClient.MySqlTransaction
        Dim dtrow As DataRow
        Try
            flagval = Validate()
            If flagval Then

                Dim command As New MySqlCommand()
                connect.Open()
                command.Connection = connect
                vartr = connect.BeginTransaction()
                command.Transaction = vartr
                If _modelayar = 2 Then
                    command.CommandText = "delete from trans_kas where id_transaksi_kas='" & _mkeyid & "'"
                    command.ExecuteNonQuery()
                    command.CommandText = "delete from jurnal where no_jurnal='" & _mkeyid & "'"
                    command.ExecuteNonQuery()
                    command.CommandText = "delete from dtrans_kas where id_transaksi_kas='" & _mkeyid & "'"
                    command.ExecuteNonQuery()
                    command.CommandText = "delete from djurnal where no_jurnal='" & _mkeyid & "'"
                    command.ExecuteNonQuery()
                End If
                'insert jurnal
                command.CommandText = "insert into jurnal (no_jurnal,tgl) VALUES ('" & TextBox1.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "')"
                command.ExecuteNonQuery()
                command.CommandText = "insert into trans_kas (id_transaksi_kas,tgl,id_akun_kas,keterangan,cetakan_ke,tipe_dokumen) VALUES ('" & TextBox1.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & GridLookUpEdit1.EditValue & "','" & CekTandaPetik(RichTextBox1.Text) & "',0,'M')"
                command.ExecuteNonQuery()
                'insert detil
                For i = 0 To DataSet1.Tables.Item("datadetil").Rows.Count - 1
                    dtrow = DataSet1.Tables.Item("datadetil").Rows(i)
                    command.CommandText = "insert into dtrans_kas (id_transaksi_kas,tgl,nominal,id_akun_detil,id_truk,keterangan,urutan) VALUES ('" & TextBox1.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'," & dtrow("nominal") & ",'" & dtrow("id_akun_detil") & "','" & dtrow("id_truk") & "','" & CekTandaPetik(dtrow("keterangan")) & "'," & i + 1 & ")"
                    command.ExecuteNonQuery()
                    command.CommandText = "insert into djurnal (no_jurnal,id_akun,keterangan,nominal) VALUES ('" & TextBox1.Text & "','" & dtrow("id_akun_detil") & "','" & CekTandaPetik(dtrow("keterangan")) & "'," & -1 * dtrow("nominal") & ")"
                    command.ExecuteNonQuery()
                Next
                Dim total As Double = GridView1.Columns("nominal").SummaryItem.SummaryValue
                command.CommandText = "insert into djurnal (no_jurnal,id_akun,keterangan,nominal) VALUES ('" & TextBox1.Text & "','" & GridLookUpEdit1.EditValue & "','" & CekTandaPetik(RichTextBox1.Text) & "'," & total & ")"
                command.ExecuteNonQuery()

                vartr.Commit()
                savestatus = True
            Else
                savestatus = False
            End If
        Catch ex As Exception
            savestatus = False
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Try
                vartr.Rollback()
            Catch ex2 As Exception
                MessageBox.Show(ex2.Message)
            End Try
        Finally
            If IsNothing(connect)=False Then
                connect.Close()
            End If
            If flagval And savestatus = True Then

                MessageBox.Show("Simpan Data Kas Masuk " + TextBox1.Text + " Sukses")
                If _modelayar = 1 Then
                    ResetValues()
                    If IsNothing(daftar_kas_masuk) = False Then
                        daftar_kas_masuk.refreshgrid("")
                    End If
                Else
                    Me.Close()
                End If
            End If
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If _modelayar = 1 Then
            ResetValues()
        Else
            Me.Close()
        End If
    End Sub

    Private Function gennobuktina(ByVal tgl As Date) As String
        Dim retval As String = ""
        retval = autogenerate2("KM", "select max(id_transaksi_kas) from trans_kas where tipe_dokumen='M' and month(tgl)=" & Format(tgl, "MM") & " and year(tgl)=" & Format(tgl, "yyyy"), tgl)
        Return retval
    End Function

    Private Sub DateTimePicker1_LostFocus(sender As Object, e As EventArgs) Handles DateTimePicker1.LostFocus
        If isloaddata = False Then TextBox1.Text = gennobuktina(DateTimePicker1.Value)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If isloaddata = False Then TextBox1.Text = gennobuktina(DateTimePicker1.Value)
    End Sub

    Private Sub kas_masuk_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If _modelayar = 3 Then
            Dim result As DialogResult = MessageBox.Show("Hapus Data ini ?", _
                              "Transaksi Kas Masuk", _
                              MessageBoxButtons.YesNo, _
                              MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                hapusdata(_mkeyid)
            Else
                savestatus = False
                Me.Close()
            End If
        End If
    End Sub
End Class