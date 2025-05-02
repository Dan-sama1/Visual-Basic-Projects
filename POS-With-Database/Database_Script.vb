Imports MySql.Data.MySqlClient
Module Script
    Public connection As MySqlConnection

    Public Sub ConnectionToDatabase()
        connection = New MySqlConnection("server=127.0.0.1;port=3308; user id=posongbato;password=;database=db_posongbato")

        Try
            connection.Open()
        Catch ex As Exception
            MessageBox.Show("Database Connection Failed: " & ex.Message)
        End Try
    End Sub
End Module