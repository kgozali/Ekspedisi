Public Class COA
    Dim _modelayar As Integer
    Dim _mkeyid As String
    Private savestatus As Boolean = False

    Private Function hapusdata(mkeyid As String) As Boolean
        Try
            InsertInto("delete from makun where kode_akun='" & mkeyid & "'")
        Catch ex As Exception
            savestatus = False
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            savestatus = True
            MessageBox.Show("Hapus Akun " + mkeyid + " berhasil")
            Me.Close()
        End Try
    End Function

    Public Function initform(ByVal modelayar As Integer, ByVal KeyID As String) As Boolean
        GridLookUpEdit1.Enabled = True
        kodeakun.Enabled = True
        namaakun.Enabled = True
        akundetil.Enabled = True
        LookUpEdit1.Enabled = True
        _mkeyid = KeyID
        _modelayar = modelayar
        '_griddataset = griddataset
        ResetValues()
        Select modelayar
            Case 2, 3
                kodeakun.Enabled = False
                loaddata(_mkeyid)

        End Select


        Me.ShowDialog()
        Return savestatus
    End Function

    Private Sub loaddata(ByVal mkeyid As String)
        Dim lcdata As New DataTable
        Dim lcdtrow As DataRow
        lcdata = DtTable("select * from makun where kode_akun='" & mkeyid & "'")

        If lcdata.Rows.Count > 0 Then
            lcdtrow = lcdata.Rows(0)
            kodeakun.Text = lcdtrow("kode_akun")
            namaakun.Text = lcdtrow("nama_akun")
            akundetil.Checked = lcdtrow("detil")
            'MessageBox.Show(lcdtrow("tipe_akun").ToString)
            GridLookUpEdit1.EditValue = lcdtrow("tipe_akun").ToString
            LookUpEdit1.EditValue = lcdtrow("sub_akun").ToString
        End If
    End Sub

    Private Sub ResetValues()
        GridLookUpEdit1.EditValue = ""
        kodeakun.Text = ""
        namaakun.Text = ""
        akundetil.Checked = False
        LookUpEdit1.EditValue = ""
    End Sub

    Private Function Validate() As Boolean
        'cek kode akun sudah ada tidak
        Dim retdata As Object
        If Trim(kodeakun.Text) = "" Then
            MessageBox.Show("Kode Akun belum di input")
            Return False
        End If

        If Trim(namaakun.Text) = "" Then
            MessageBox.Show("Nama Akun belum di input")
            Return False
        End If
        If _modelayar = 1 Then
            retdata = Scalar("select kode_akun from makun where kode_akun='" & CekTandaPetik(kodeakun.Text) & "'")
            If IsNothing(retdata) = False Then
                MessageBox.Show("Kode Akun " + kodeakun.Text + " sudah ada pada Database")
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub COA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridLookUpEdit1.Properties.DataSource = DtTable("select tipeakun from tipeakun where ditampilkan=1 order by urutan")
        GridLookUpEdit1.Properties.DisplayMember = "tipeakun"
        GridLookUpEdit1.Properties.ValueMember = "tipeakun"
        'GridLookUpEdit1.EditValue = ""

        LookUpEdit1.Properties.DataSource = DtTable("select concat(nama_akun,'-',kode_akun) descr,kode_akun from makun where detil=0 order by kode_akun")
        LookUpEdit1.Properties.DisplayMember = "descr"
        LookUpEdit1.Properties.ValueMember = "kode_akun"
        'LookUpEdit1.EditValue = ""
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        If _modelayar = 1 Then
            ResetValues()
        Else
            loaddata(_mkeyid)
        End If
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim strsub As String
        Dim i As Integer = 0
        Dim flagval As Boolean
        Dim levelnya As Integer = 0
        Try
            flagval = Validate()
            If flagval Then
                'cari level akun

                If Trim(LookUpEdit1.EditValue) = "" Then
                    levelnya = 0
                Else
                    'buat leveling

                    strsub = LookUpEdit1.EditValue
carilevelna:
                    Dim dtrow As DataRow
                    Dim datatb As DataTable
                    datatb = DtTable("select sub_akun from makun where kode_akun='" & strsub & "'")
                    Dim irow As Integer = datatb.Rows.Count
                    i = 0
                    Do While i < irow
                        dtrow = datatb.Rows(i)
                        i = i + 1
                        If IsDBNull(dtrow("sub_akun")) = False Then
                            If Trim(dtrow("sub_akun").ToString) = "" Then
                                strsub = ""
                            Else
                                strsub = Trim(dtrow("sub_akun"))
                            End If
                        Else
                            strsub = ""
                        End If
                        If strsub <> LookUpEdit1.EditValue Then
                            levelnya = levelnya + 2
                            GoTo carilevelna
                        Else
                            levelnya = levelnya + 2
                        End If
                    Loop
                End If
                If _modelayar = 1 Then
                    InsertInto("insert into makun (kode_akun,nama_akun,tipe_akun,sub_akun,level,detil) VALUES ('" & CekTandaPetik(kodeakun.Text) & "','" & CekTandaPetik(namaakun.Text) & "','" & GridLookUpEdit1.EditValue & "','" & LookUpEdit1.EditValue & "'," & levelnya & "," & akundetil.Checked & ")")
                Else
                    InsertInto("update makun set nama_akun='" & CekTandaPetik(namaakun.Text) & "',tipe_akun='" & GridLookUpEdit1.EditValue & "',sub_akun='" & LookUpEdit1.EditValue & "',level=" & levelnya & ",detil=" & akundetil.Checked & " where kode_akun='" & kodeakun.Text & "'")
                End If
            End If
        Catch ex As Exception
            savestatus = False
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If flagval Then
                savestatus = True

                MessageBox.Show("Simpan Data Akun " + kodeakun.Text + " Sukses", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If _modelayar = 1 Then
                    ResetValues()
                Else
                    Me.Close()
                End If
            End If
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub COA_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If _modelayar = 3 Then
            Dim result As DialogResult = MessageBox.Show("Hapus Data ini ?", _
                              "Master COA", _
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