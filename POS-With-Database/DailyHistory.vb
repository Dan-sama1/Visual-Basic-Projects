Imports MySql.Data.MySqlClient

Public Class DailyHistory

    'LOAD TODAYS TRANSACTION
    Private Sub loadHistory()
        ConnectionToDatabase()

        Dim command As New MySqlCommand(
        "SELECT
            t.transaction_date AS 'Transaction Time',
            t.transaction_number AS 'Transaction Number',
            i.item_name AS 'Order Name',
            s.price AS 'Size Price',
            ti.quantity AS 'Quantity',
            ti.total_price AS 'Total'
        FROM 
            tbl_transactions t
        JOIN 
            tbl_transactionItems ti ON t.transaction_id = ti.transaction_id
        JOIN 
            tbl_items i ON ti.item_id = i.item_id
        JOIN 
            tbl_item_sizes s ON ti.size_id = s.size_id
        WHERE 
            DATE(t.transaction_date) = CURDATE() " & ' Filter by today's date
        "ORDER BY 
            t.transaction_date DESC", connection
    )

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            dtHistory.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error loading history: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    'BAKC
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        txtSearch.Clear()
        dtHistory.Focus()
        Me.Hide()
    End Sub
    'FORM
    Private Sub DailyHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadHistory()
    End Sub
    'SEARCH
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text.Trim = "" Then
            MessageBox.Show("Please enter a search term.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ConnectionToDatabase()

        Dim searchTerm As String = "%" & txtSearch.Text.Trim & "%"
        Dim query As String = "
        SELECT
            t.transaction_date AS 'Transaction Time',
            t.transaction_number AS 'Transaction Number',
            i.item_name AS 'Order Name',
            s.price AS 'Size Price',
            ti.quantity AS 'Quantity',
            ti.total_price AS 'Total'
        FROM 
            tbl_transactions t
            JOIN tbl_transactionItems ti ON t.transaction_id = ti.transaction_id
            JOIN tbl_items i ON ti.item_id = i.item_id
            JOIN tbl_item_sizes s ON ti.size_id = s.size_id
        WHERE 
            i.item_name LIKE @searchTerm 
            OR t.transaction_number LIKE @searchTerm
        ORDER BY 
            t.transaction_date DESC
    "

        Dim adapter As New MySqlDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("@searchTerm", searchTerm)
        Dim dt As New DataTable()

        Try
            adapter.Fill(dt)
            dtHistory.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error during search: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        loadHistory()
        txtSearch.Clear()
        dtHistory.Focus()
    End Sub
End Class

'CREATED BY: ALEX DANIEL P. BARRAMEDA
'CREATED BY: ALEX DANIEL P. BARRAMEDA
'CREATED BY: ALEX DANIEL P. BARRAMEDA
'CREATED BY: ALEX DANIEL P. BARRAMEDA
'CREATED BY: ALEX DANIEL P. BARRAMEDA