Imports MySql.Data.MySqlClient

Public Class Manage_Orders

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
        tbl_items i ON ti.item_id = i.item_id;
    "

        Dim adapter As New MySqlDataAdapter(query, connection)
        Dim table As New DataTable()
        adapter.Fill(table)

        dtReport.DataSource = table

        connection.Close()

    End Sub
    'HIDE ITEM ID
    Private Sub dtReport_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dtReport.DataBindingComplete
        If dtReport.Columns.Contains("Item ID") Then
            dtReport.Columns("Item ID").Visible = False
        End If
    End Sub

    ' CHANGE BG COLOR OF QTY
    Private Sub CustomColor()

        Dim quantityColumn As DataGridViewColumn = dtReport.Columns("Quantity")

        If quantityColumn IsNot Nothing Then
            'BG COLOR
            quantityColumn.DefaultCellStyle.BackColor = Color.FromArgb(248, 244, 220)

            'FORE COLOR
            quantityColumn.DefaultCellStyle.ForeColor = Color.Black
        End If
    End Sub

    'DISABLE SYSTEM GENERATED ROWS
    Private Sub Manage_Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomColor()

        'SET COLUMNS TO READ ONLKY
        LoadTransactionReport()

        dtReport.Columns("Transact Date").ReadOnly = True
        dtReport.Columns("Transact Time").ReadOnly = True
        dtReport.Columns("Transact Number").ReadOnly = True
        dtReport.Columns("Order Name").ReadOnly = True
        dtReport.Columns("Price").ReadOnly = True
        dtReport.Columns("Total").ReadOnly = True
    End Sub

    'UPDATE
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim checker As Boolean = False

        Try
            ConnectionToDatabase()

            For Each row As DataGridViewRow In dtReport.Rows
                If row.IsNewRow Then Continue For

                Dim transactionId As Integer = Convert.ToInt32(row.Cells("Transact Number").Value)
                Dim itemId As Integer = Convert.ToInt32(row.Cells("Item ID").Value)
                Dim price As Decimal = Convert.ToDecimal(row.Cells("Price").Value)
                Dim quantity As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
                Dim currentTotal As Decimal = Convert.ToDecimal(row.Cells("Total").Value)

                Dim newTotal As Decimal = price * quantity

                ' Only update if total chanegd
                If newTotal <> currentTotal Then
                    row.Cells("Total").Value = newTotal

                    Dim query As String = "
                    UPDATE tbl_transactionItems
                    SET quantity = @quantity, total_price = @total
                    WHERE transaction_id = @transactionId AND item_id = @itemId;
                "

                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@quantity", quantity)
                        command.Parameters.AddWithValue("@total", newTotal)
                        command.Parameters.AddWithValue("@transactionId", transactionId)
                        command.Parameters.AddWithValue("@itemId", itemId)

                        Dim result As Integer = command.ExecuteNonQuery()
                        If result > 0 Then checker = True
                    End Using
                End If
            Next

            If checker Then
                MessageBox.Show("Update(s) successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No records updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub



    'DELETE
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dtReport.SelectedCells.Count = 0 Then
            MessageBox.Show("Please select a valid row first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'SELECT WHOLE ROW from the selected cell
        Dim selectedCell As DataGridViewCell = dtReport.SelectedCells(0)
        Dim rowIndex As Integer = selectedCell.RowIndex
        Dim selectedRow As DataGridViewRow = dtReport.Rows(rowIndex)

        'CHECK IF ROW IS VALID
        Dim ValidRow As Boolean = True
        Try
            Dim transactVal = selectedRow.Cells("Transact Number").Value
            Dim itemVal = selectedRow.Cells("Item ID").Value

            If transactVal Is Nothing OrElse itemVal Is Nothing Then
                ValidRow = False
            ElseIf IsDBNull(transactVal) OrElse IsDBNull(itemVal) Then
                ValidRow = False
            ElseIf String.IsNullOrWhiteSpace(transactVal.ToString()) OrElse String.IsNullOrWhiteSpace(itemVal.ToString()) Then
                ValidRow = False
            End If
        Catch
            ValidRow = False
        End Try

        If Not ValidRow OrElse selectedRow.IsNewRow Then
            MessageBox.Show("Selected row is invalid, empty, or incomplete.", "Invalid Row", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'CONFIRMATION
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            Try
                ConnectionToDatabase()

                'GET ID FOR DELETION
                Dim transactionId As Integer = Convert.ToInt32(selectedRow.Cells("Transact Number").Value)
                Dim itemId As Integer = Convert.ToInt32(selectedRow.Cells("Item ID").Value)

                'DELETE FROM TABLE
                Dim query As String = "
                DELETE FROM tbl_transactionItems
                WHERE transaction_id = @transactionId AND item_id = @itemId;
                "

                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@transactionId", transactionId)
                command.Parameters.AddWithValue("@itemId", itemId)

                Dim result As Integer = command.ExecuteNonQuery()

                If result > 0 Then
                    MessageBox.Show("Delete successful!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'REMOVE FROM REPORT TABLE
                    dtReport.Rows.Remove(selectedRow)

                    'REFRESH TABLE
                    LoadTransactionReport()

                    'REFRESH ADMIN TABLE
                    Admin.LoadTransactionReport()
                Else
                    MessageBox.Show("Delete failed. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Close()
            End Try
        End If
    End Sub

    'SEARCH
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ConnectionToDatabase()

        Dim searchText As String = txtSearch.Text.Trim()

        Dim query As String = "
        SELECT 
            DATE_FORMAT(t.transaction_date, '%Y-%m-%d') AS 'Transact Date',
            TIME(t.transaction_date) AS 'Transact Time',
            t.transaction_id AS 'Transact Number',
            i.item_name AS 'Order Name',
            i.price AS 'Price',
            ti.quantity AS 'Quantity',
            ti.total_price AS 'Total',
            ti.item_id AS 'Item ID'
        FROM 
            tbl_transactions t
        JOIN 
            tbl_transactionItems ti ON t.transaction_id = ti.transaction_id
        JOIN 
            tbl_items i ON ti.item_id = i.item_id
        WHERE 
            (t.transaction_id LIKE @search OR 
             i.item_name LIKE @search OR 
             DATE(t.transaction_date) LIKE @search);
    "

        Dim adapter As New MySqlDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("@search", "%" & searchText & "%")

        Dim table As New DataTable
        adapter.Fill(table)
        dtReport.DataSource = table

        connection.Close()
    End Sub
    'REFRESH
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadTransactionReport()
    End Sub
    'EXIT
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Admin.Show()
    End Sub

    'CLICK ENTER
    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnSearch.PerformClick()
        End If
    End Sub
    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        ToolTip1.SetToolTip(btnInfo, "Click here for more information about managing orders.")

        MessageBox.Show("Manage orders by EDITING QUANTITY of an order or REMOVING data from customers.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class