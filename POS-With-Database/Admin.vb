Imports MySql.Data.MySqlClient

Public Class Admin
    'LOAD REPORT
    Public Sub LoadTransactionReport()
        ConnectionToDatabase()

        Dim query As String = "
        SELECT 
            ti.item_id AS 'Item ID',
            DATE_FORMAT(t.transaction_date, '%Y-%m-%d') AS 'Transact Date',
            TIME(t.transaction_date) AS 'Transact Time',
            t.transaction_id AS 'Transact Number',
            i.item_name AS 'Order Name',
            i.price AS 'Price',
            ti.quantity AS 'Quantity',
            ti.total_price AS 'Total'
        FROM 
            tbl_transactions t
        JOIN 
            tbl_transactionItems ti ON t.transaction_id = ti.transaction_id
        JOIN 
            tbl_items i ON ti.item_id = i.item_id
    "

        Dim adapter As New MySqlDataAdapter(query, connection)
        Dim table As New DataTable()
        adapter.Fill(table)

        dtReport.DataSource = table


        connection.Close()
    End Sub
    'LOAD TODAYS SALES
    Private Sub LoadTodaySales()
        ConnectionToDatabase()

        ' SQL query to calculate total sales for today
        Dim query As String = "
    SELECT SUM(ti.total_price) AS 'TodaySales'
    FROM tbl_transactionItems ti
    JOIN tbl_transactions t ON ti.transaction_id = t.transaction_id
    WHERE DATE(t.transaction_date) = CURDATE();"

        ' Execute the query
        Dim command As New MySqlCommand(query, connection)
        Dim result = command.ExecuteScalar()

        ' Check if the result is DBNull (no transactions for today)
        If IsDBNull(result) Then
            lblTodaySales.Text = "0.00" ' No sales today
        Else
            ' Convert result to Decimal and then format as currency
            lblTodaySales.Text = Convert.ToDecimal(result).ToString("C2") ' Format as currency
        End If

        connection.Close()
    End Sub


    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTransactionReport()
        LoadTodaySales()

        dtpDate.Format = DateTimePickerFormat.Custom
        dtpDate.CustomFormat = "MMMM yyyy"
    End Sub

    'btn
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ConnectionToDatabase()

        Dim searchText As String = txtSearch.Text.Trim()

        ' pull the monht and year 
        Dim selectedMonth As String = dtpDate.Value.ToString("MM")  ' Get month in numeric form
        Dim selectedYear As String = dtpDate.Value.Year.ToString() ' Get the year

        ' query
        Dim query As String = "
        SELECT 
            DATE(t.transaction_date) AS 'Transact Date',
            TIME(t.transaction_date) AS 'Transact Time',
            t.transaction_id AS 'Transact Number',
            i.item_name AS 'Order Name',
            ti.quantity AS 'Quantity',
            ti.total_price AS 'Total',
        FROM 
            tbl_transactions t
        JOIN 
            tbl_transactionItems ti ON t.transaction_id = ti.transaction_id
        JOIN 
            tbl_items i ON ti.item_id = i.item_id
        WHERE 
            (t.transaction_id LIKE @search OR 
             i.item_name LIKE @search OR 
             DATE(t.transaction_date) LIKE @search) 
            AND MONTH(t.transaction_date) = @month 
            AND YEAR(t.transaction_date) = @year;
    "

        ' Add parameters for search text, month, and year
        Dim adapter As New MySqlDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("@search", "%" & searchText & "%")
        adapter.SelectCommand.Parameters.AddWithValue("@month", selectedMonth)
        adapter.SelectCommand.Parameters.AddWithValue("@year", selectedYear)

        Dim table As New DataTable
        adapter.Fill(table)
        dtReport.DataSource = table

        connection.Close()
        txtSearch.Clear()
    End Sub


    Private Sub lblLogOut_Click(sender As Object, e As EventArgs)
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to Log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadTransactionReport()
    End Sub

    Private Sub lblTodaySales_Click(sender As Object, e As EventArgs) Handles lblTodaySales.Click
        LoadTodaySales()
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnSearch.PerformClick()
        End If
    End Sub
    'logout
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to Log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub btnManage_Click(sender As Object, e As EventArgs) Handles btnManage.Click
        Manage_Orders.dtReport.DataSource = Me.dtReport.DataSource
        Manage_Orders.ShowDialog()
    End Sub
    'HIDE ITEM ID
    Private Sub dtReport_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dtReport.DataBindingComplete
        If dtReport.Columns.Contains("Item ID") Then
            dtReport.Columns("Item ID").Visible = False
        End If
    End Sub
End Class