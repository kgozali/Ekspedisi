Imports MySql.Data.MySqlClient
Public Module Module1

    Public connect As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("ekspedisi").ConnectionString)

    Function tglserver() As DateTime
        Return Scalar("select now() ")
    End Function

    Function Scalar(ByVal x As String)
        'untuk select single data
        Try
            connect.Open()
            Dim a As String
            Dim command As New MySqlCommand(x, connect)
            If IsDBNull(command.ExecuteScalar()) = True Then
                a = ""
            Else
                a = command.ExecuteScalar()
            End If
            connect.Close()
            Return a

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Function CekTandaPetik(ByVal vData As String) As String
        Dim retval As String

        retval = Replace(vData, "'", "''")
        retval = Replace(retval, "\", "\\")

        Return retval
    End Function

    Public Function DtSetReturn(ByVal pSQL As String, ByVal pTableName As String) As DataSet
        Dim pDataSet As DataSet = New DataSet
        Dim xAdap As MySqlDataAdapter
        Try
            xAdap = New MySqlDataAdapter(pSQL, connect)
            xAdap.Fill(pDataSet, pTableName)
            xAdap.Dispose()
            connect.Close()
            Return pDataSet
        Catch expr_BB As MySqlException
            MessageBox.Show(expr_BB.Message.ToString)
            Return Nothing
        End Try
    End Function

    Function DtTable(ByVal x As String)
        'untuk select datatable biasa
        Try
            Dim command As New MySqlCommand(x, connect)
            command.Connection = connect
            Dim data As DataTable = New DataTable
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(data)
            Return data
            data.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    Function InsertInto(ByVal x As String)
        'insert semua pakek ini
        Dim vartr As MySql.Data.MySqlClient.MySqlTransaction
        Try
            connect.Open()
            vartr = connect.BeginTransaction()
            Dim command As New MySqlCommand()
            command.Connection = connect
            command.CommandText = x
            command.Transaction = vartr
            command.ExecuteNonQuery()
            vartr.Commit()
            Return True
        Catch ex As Exception
            Try
                vartr.Rollback()
            Catch ex1 As MySqlException
                MessageBox.Show(ex1.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        Finally
            If IsNothing(connect) = False Then
                connect.Close()
            End If
        End Try
    End Function

    Function DtTablemaster(ByVal x As String)
        'select khusus master data yang perlu checkbox 
        Try

            Dim command As New MySqlCommand(x, connect)
            command.Connection = connect
            Dim data As DataTable = New DataTable
            Dim adapter As New MySqlDataAdapter(command)

            'Tambah checkbox column dalam Datatable
            'Ini nambahnya di samping kiri, kalo mau disamping kanan code buat nambahnya di taruk setelah adapter fill
            data.Columns.Add("Check", GetType(Boolean))
            adapter.Fill(data)

            Return data

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    Function DtTablebayar(ByVal x As String)
        'select khusus master data yang perlu checkbox 
        Try

            Dim command As New MySqlCommand(x, connect)
            command.Connection = connect
            Dim data As DataTable = New DataTable
            Dim adapter As New MySqlDataAdapter(command)

            'Tambah checkbox column dalam Datatable
            'Ini nambahnya di samping kiri, kalo mau disamping kanan code buat nambahnya di taruk setelah adapter fill

            adapter.Fill(data)
            data.Columns.Add("Bayar", GetType(Double))
            data.Columns("Bayar").DefaultValue = 0
            Return data

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    Function auditlog(ByVal a As String, ByVal b As String, ByVal c As String, ByVal d As String, ByVal e As String, ByVal f As String)
        'untuk insert auditlog, tinggal panggil trus lempar
        Try
            connect.Open()
            Dim Command As MySqlCommand = New MySqlCommand("insert into audit_log values('" + a + "','" + b + "','" + c + "','" + d + "','" + e + "','" + f + "')", connect)
            Command.ExecuteNonQuery()
            connect.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Function autogenerate2(ByVal prefix As String, ByVal cekmax As String, ByVal tgltrans As Date)
        Dim fmt As String
        Dim tgl As String = Format(tgltrans, "yyMM")
        Dim maxcount As String = Scalar(cekmax)
        If Trim(maxcount) = "" Then
            maxcount = 0
        Else
            maxcount = Microsoft.VisualBasic.Right(maxcount, 5)
        End If
        fmt = String.Format("{0:00000}", Val(maxcount) + 1)
        Return prefix + tgl + fmt
    End Function
    Function autogenerate(ByVal prefix As String, ByVal cekmax As String)
        Try
            Dim currentTime As System.DateTime = System.DateTime.Now
            Dim urutan As Integer
            Dim kode As String = Scalar(cekmax).ToString
            Dim fix As String = ""
            If urutan = 0 Then
                kode = prefix & currentTime.Date.ToString("yyMMdd") & "00001"
            ElseIf kode.Substring(2, 6) = currentTime.Date.ToString("yyMMdd") Or kode.Substring(3, 6) = currentTime.Date.ToString("yyMMdd") Then
                urutan = kode.Substring(Scalar(cekmax).Length - 5)
                urutan = urutan + 1
                For i = 0 To 4 - urutan.ToString.Substring(Scalar(cekmax).Length - 5).Length
                    fix = fix & "0"
                Next i
                fix = fix & urutan.ToString
                kode = prefix & currentTime.Date.ToString("yyMMdd") & fix
            Else
                kode = prefix & currentTime.Date.ToString("yyMMdd") & "00001"
            End If

            Return kode
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function

    Function KolomBayar(ByVal x As String)

    End Function
End Module
