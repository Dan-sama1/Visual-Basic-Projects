Imports MySql.Data.MySqlClient

Public Class AddItem

    Private Sub cleaner()
        txtSearch.Clear()
        txtName.Clear()
        rdbMilkTea.Checked = False
        rdbCoffee.Checked = False
        rdbFruitTea.Checked = False
        rdbFrap.Checked = False
        dtProductName.ClearSelection()
        txtName.Focus()
    End Sub
    'LOAD ITEMS
    Private Sub loadItems()
        ConnectionToDatabase()

        Dim query As String = "
            SELECT i.item_id, i.item_name, c.category_name 
            FROM tbl_items i 
            JOIN tbl_categories c ON i.category_id = c.category_id
            WHERE i.is_deleted = FALSE
            ORDER BY i.item_name;
            "

        Dim adapter As New MySqlDataAdapter(query, connection)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        dtProductName.DataSource = dt

        dtProductName.Columns("item_id").HeaderText = "ID"
        dtProductName.Columns("item_name").HeaderText = "Product Name"
        dtProductName.Columns("category_name").HeaderText = "Category"
        dtProductName.Columns("item_id").Visible = False
    End Sub
    'FORM
    Private Sub AddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadItems()
    End Sub
    'EXIT
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        cleaner()
        Me.Hide()
        Admin.Show()
    End Sub
    'CLEAR
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cleaner()
    End Sub
    'CREATE PRODUCT
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If txtName.Text.Trim = "" Then
            MessageBox.Show("Please enter a product name.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim categoryID As Integer
        If rdbMilkTea.Checked Then
            categoryID = 1
        ElseIf rdbCoffee.Checked Then
            categoryID = 2
        ElseIf rdbFruitTea.Checked Then
            categoryID = 3
        ElseIf rdbFrap.Checked Then
            categoryID = 4
        Else
            MessageBox.Show("Please select a category.", "Missing Category", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ConnectionToDatabase()

            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If

            ' CHECK IF ITEM ALREADY EXISTS
            Dim query As String = "SELECT COUNT(*) FROM tbl_items WHERE item_name = @name"
            Using checkCmd As New MySqlCommand(query, connection)
                checkCmd.Parameters.AddWithValue("@name", txtName.Text.Trim)
                Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                If exists > 0 Then
                    MessageBox.Show("Item already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End Using

            ' INSERT INTO DATABASE
            Dim insertQuery As String = "INSERT INTO tbl_items (item_name, price, category_id) VALUES (@name, 0.00, @categoryID)"
            Using insertCmd As New MySqlCommand(insertQuery, connection)
                insertCmd.Parameters.AddWithValue("@name", txtName.Text.Trim)
                insertCmd.Parameters.AddWithValue("@categoryID", categoryID)
                insertCmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Item created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cleaner()
            loadItems()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    'EDIT PRODUCTS
    Private Sub dtProductName_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtProductName.CellClick
        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = dtProductName.Rows(e.RowIndex)

            'SET PRODUCT NAME
            txtName.Text = row.Cells("item_name").Value.ToString

            'SELECT CATEGORY
            Dim category As String = row.Cells("category_name").Value.ToString()

            Select Case category.ToUpper()
                Case "MILK TEA"
                    rdbMilkTea.Checked = True
                Case "COFFEE"
                    rdbCoffee.Checked = True
                Case "FRUIT TEA"
                    rdbFruitTea.Checked = True
                Case "PRAF"
                    rdbFrap.Checked = True
                Case Else
                    rdbMilkTea.Checked = False
                    rdbCoffee.Checked = False
                    rdbFruitTea.Checked = False
                    rdbFrap.Checked = False
            End Select
        End If
    End Sub
    'EDIT
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtName.Text.Trim = "" Then
            MessageBox.Show("Please enter a product name.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow = dtProductName.CurrentRow
        If selectedRow Is Nothing Then
            MessageBox.Show("Please select a product from the list.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim productId As Integer = Convert.ToInt32(selectedRow.Cells("item_id").Value)

        ' CHECK IF PROD ALRDY EXISTS
        Dim queryCheck As String = "SELECT COUNT(*) FROM tbl_items WHERE item_name = @name AND item_id != @id"
        Dim checkCommand As New MySqlCommand(queryCheck, connection)
        checkCommand.Parameters.AddWithValue("@name", txtName.Text.Trim)
        checkCommand.Parameters.AddWithValue("@id", productId)
        Dim exists As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

        If exists > 0 Then
            MessageBox.Show("Item name already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' UPDAET
        Dim updateCommand As New MySqlCommand("UPDATE tbl_items SET item_name = @name WHERE item_id = @id", connection)
        updateCommand.Parameters.AddWithValue("@name", txtName.Text.Trim)
        updateCommand.Parameters.AddWithValue("@id", productId)

        Try
            updateCommand.ExecuteNonQuery()
            MessageBox.Show("Item name updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loadItems()
            cleaner()
        Catch ex As Exception
            MessageBox.Show("Error updating product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'NAME
    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        If txtName.Text <> "" Then
            rdbMilkTea.Enabled = True
            rdbCoffee.Enabled = True
            rdbFruitTea.Enabled = True
            rdbFrap.Enabled = True
        Else
            rdbMilkTea.Enabled = False
            rdbCoffee.Enabled = False
            rdbFruitTea.Enabled = False
            rdbFrap.Enabled = False
        End If
    End Sub
    'DELETE
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' CHECK IF CELL IS SELECTED
        Dim selectedRow As DataGridViewRow = dtProductName.CurrentRow
        If selectedRow Is Nothing Then
            MessageBox.Show("Please select a product from the list.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' GET ID
        Dim productId As Integer = Convert.ToInt32(selectedRow.Cells("item_id").Value)

        ' CONFIRM DELETE
        Dim checkResult As DialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If checkResult = DialogResult.Yes Then
            Try
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If

                ' PERFORM SOFT DELETE
                Dim softDeleteCommand As New MySqlCommand("UPDATE tbl_items SET is_deleted = TRUE WHERE item_id = @id", connection)
                softDeleteCommand.Parameters.AddWithValue("@id", productId)
                softDeleteCommand.ExecuteNonQuery()

                MessageBox.Show("Item deleted (soft delete) successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' REFRESH
                loadItems()
                cleaner()

            Catch ex As Exception
                MessageBox.Show("Error deleting product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Close()
            End Try
        End If
    End Sub

    'SEARCH
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ConnectionToDatabase()

        ' CHECK SEARCH BAR
        If txtSearch.Text.Trim = "" Then
            MessageBox.Show("Please enter a search term.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim searchTerm As String = "%" & txtSearch.Text.Trim & "%"
        Dim query As String = "
            SELECT i.item_id, i.item_name, c.category_name
            FROM tbl_items i
            JOIN tbl_categories c ON i.category_id = c.category_id
            WHERE (i.item_name LIKE @searchTerm OR c.category_name LIKE @searchTerm)
            AND i.is_deleted = FALSE
            ORDER BY i.item_name;
        "

        Dim adapter As New MySqlDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("@searchTerm", searchTerm)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        dtProductName.DataSource = dt
    End Sub
    'REFRESH DATA
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        loadItems()
        cleaner()
    End Sub
    'ENTER BTN
    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnSearch.PerformClick()
        End If
    End Sub
End Class

'CREATED BY: ALEX DANIEL P. BARRAMEDA
'CREATED BY: ALEX DANIEL P. BARRAMEDA
'CREATED BY: ALEX DANIEL P. BARRAMEDA
'CREATED BY: ALEX DANIEL P. BARRAMEDA
'CREATED BY: ALEX DANIEL P. BARRAMEDA