Imports MySql.Data.MySqlClient
Public Module Module1
    Public connect As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("ekspedisi").ConnectionString)

    Function Scalar(ByVal x As String)
        Try
            connect.Open()
            Dim command As New MySqlCommand(x, connect)
            Dim a As String = command.ExecuteScalar()
            connect.Close()
            Return a

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Function DtTable(ByVal x As String)
        Try
            Dim command As New MySqlCommand(x, connect)
            command.Connection = connect
            Dim data As DataTable = New DataTable
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(data)
            Return data
            data.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Function InsertInto(ByVal x As String)
        Try
            connect.Open()
            Dim command As New MySqlCommand(x, connect)
            command.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Function DtTablemaster(ByVal x As String)
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
            MsgBox(ex.Message)
        End Try

    End Function
End Module
