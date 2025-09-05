Imports System.Configuration
Imports MySql.Data.MySqlClient

Module Script
    Public connection As MySqlConnection

    Public Sub ConnectionToDatabase()
        ' Correct way to access the connection string from App.config
        Dim connString As String = ConfigurationManager.ConnectionStrings("PosDatabase").ConnectionString

        ' Initialize the MySqlConnection with the retrieved connection string
        connection = New MySqlConnection(connString)

        Try
            ' Open the database connection
            connection.Open()
        Catch ex As Exception
            ' Handle any errors during the connection attempt
            MessageBox.Show("Database Connection Failed: " & ex.Message)
        End Try
    End Sub
End Module
