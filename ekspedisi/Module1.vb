Imports MySql.Data.MySqlClient
Public Module Module1
    Public connect As New MySqlConnection("Server=localhost;Uid=root;database=ekspedisi")

    Function Scalar(ByVal x As String)
        Try
            connect.Open()
            Dim command As New MySqlCommand(x, connect)
            Dim a As String = command.ExecuteScalar()
            Return a
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Function DtTable(ByVal x As String)
        Try
            connect.Open()
            Dim command As New MySqlCommand(x, connect)
            command.Connection = connect
            Dim data As DataTable = New DataTable
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(data)
            connect.Close()

            Return data

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

        End Try


    End Function
End Module
