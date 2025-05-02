Imports MySql.Data.MySqlClient

Public Class LoginLogs
    'EXIT
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Admin.Show()
    End Sub

    'LOAD LOGIN LOGS
    Private Sub LoginLogs()
        Try
            ConnectionToDatabase()
            Dim query As String = "SELECT username, roles, last_login FROM tbl_login ORDER BY last_login DESC"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable
            adapter.Fill(table)
            dtLog.DataSource = table

            'CHANGE HEADER
            dtLog.Columns("username").HeaderText = "Username"
            dtLog.Columns("roles").HeaderText = "Role"
            dtLog.Columns("last_login").HeaderText = "Last Login"
        Catch ex As Exception
            MessageBox.Show("Error loading logs: " & ex.Message)
            Exit Sub
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Private Sub LoginLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginLogs()
    End Sub
End Class

'CREATED BY: ALEX DANIEL P. BARRAMEDA
'CREATED BY: ALEX DANIEL P. BARRAMEDA
'CREATED BY: ALEX DANIEL P. BARRAMEDA
'CREATED BY: ALEX DANIEL P. BARRAMEDA
'CREATED BY: ALEX DANIEL P. BARRAMEDA