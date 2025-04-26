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
    'UPDATE
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dtReport.SelectedCells.Count = 0 Then
            MessageBox.Show("Please select a cell to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Get the clicked cell
        Dim selectedCell As DataGridViewCell = dtReport.SelectedCells(0)
        Dim rowIndex As Integer = selectedCell.RowIndex

        ' Get current values
        Dim itemId As Integer = Convert.ToInt32(dtReport.Rows(rowIndex).Cells("Item ID").Value)
        Dim oldOrderName As String = dtReport.Rows(rowIndex).Cells("Order Name").Value.ToString()
        Dim newOrderName As String = dtReport.Rows(rowIndex).Cells("Order Name").EditedFormattedValue.ToString()

        ' get values
        Dim transactionId As Integer = Convert.ToInt32(dtReport.Rows(rowIndex).Cells("Transact Number").Value)
        Dim price As Decimal = Convert.ToDecimal(dtReport.Rows(rowIndex).Cells("Price").Value)
        Dim quantity As Integer = Convert.ToInt32(dtReport.Rows(rowIndex).Cells("Quantity").Value)



        ' calculate new total
        Dim newTotal As Decimal = price * quantity
        dtReport.Rows(rowIndex).Cells("Total").Value = newTotal

        ' Update the database with the new values
        Try
            ConnectionToDatabase()

            Dim query As String = "
                UPDATE tbl_transactionItems
                SET quantity = @quantity, total_price = @total
                WHERE transaction_id = @transactionId AND item_id = @itemId;
            "

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@quantity", quantity)
            command.Parameters.AddWithValue("@total", newTotal)
            command.Parameters.AddWithValue("@transactionId", transactionId)
            command.Parameters.AddWithValue("@itemId", itemId)

            Dim result As Integer = command.ExecuteNonQuery()

            If result > 0 Then
                MessageBox.Show("Update successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record updated. Please check your data.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    'DELETE
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dtReport.CurrentCell Is Nothing Then
            MessageBox.Show("Please click on a row first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'SELECT WHOLE ROW
        Dim selectedRow As DataGridViewRow = dtReport.Rows(dtReport.CurrentCell.RowIndex)

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
                    WHERE transaction_id = @transactionId and item_id = @itemId;
                "

                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@transactionId", transactionId)
                command.Parameters.AddWithValue("@itemId", itemId)

                Dim result As Integer = command.ExecuteNonQuery()

                If result > 0 Then
                    MessageBox.Show("Delete successful!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'REMOVE FROM REPORT TABLE
                    dtReport.Rows.Remove(selectedRow)

                    'REFRESH TABLE AFTER DELETE
                    LoadTransactionReport()
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
        txtSearch.Clear()
    End Sub
    'REFRESH
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadTransactionReport()
    End Sub
    'BACK TO ADMIN
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Admin.Show()
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnSearch.PerformClick()
        End If
    End Sub
End Class