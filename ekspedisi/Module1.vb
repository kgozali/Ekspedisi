Imports MySql.Data.MySqlClient
Public Module Module1
    Public connect As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("ekspedisi").ConnectionString)

    Function Scalar(ByVal x As String)
        'untuk select single data
        Try
            connect.Open()
            Dim command As New MySqlCommand(x, connect)
            Dim a As String = command.ExecuteScalar()
            connect.Close()
            Return a

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Try
            connect.Open()
            Dim command As New MySqlCommand(x, connect)
            command.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
End Module
