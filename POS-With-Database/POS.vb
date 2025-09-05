Imports MySql.Data.MySqlClient

Public Class POS
    Dim command As New MySqlCommand
    Dim read As MySqlDataReader
    Dim selectedSize As String = ""
    Public currentUserID As Integer

    'CLEANER
    Sub cleaner()
        txtPay.Clear()
        rdbGrande.Checked = False
        rdbMedio.Checked = False
        chkPearl.Checked = False
        chkCrystal.Checked = False
        chkCoffeeJelly.Checked = False
        chkCreamCheese.Checked = False
        chkCheeseCake.Checked = False
        chkCreamPuff.Checked = False
        chkOreo.Checked = False
    End Sub

    'LOAD DATA
    Sub loadData(categoryId As Integer)
        flpItemName.Controls.Clear()
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT item_name FROM tbl_items WHERE category_id = @categoryId AND is_deleted = FALSE"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@categoryId", categoryId)
                Using read As MySqlDataReader = command.ExecuteReader()
                    While read.Read()
                        Dim btn As New Button()
                        btn.Text = read("item_name").ToString()
                        btn.Width = 150
                        btn.Height = 100
                        btn.BackColor = Color.FromArgb(196, 252, 116)
                        btn.ForeColor = Color.Black
                        btn.Font = New Font("Poppins", 12, FontStyle.Regular)

                        ' TAG FOR INITIALIZING
                        btn.Tag = read("item_name").ToString()

                        ' Attach click event handler
                        AddHandler btn.Click, AddressOf ItemButton_Click

                        flpItemName.Controls.Add(btn)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        CheckIfItemsEmpty()
    End Sub

    'CHECKER OF LAYOUT PANEL
    Private Sub CheckIfItemsEmpty()
        picLogo.Visible = (flpItemName.Controls.Count = 0)
    End Sub

    ' IF ITEMS IN THE DASHBOARD IS CLICKED 
    Private Sub ItemButton_Click(sender As Object, e As EventArgs)
        Dim clickedButton As Button = CType(sender, Button)
        Dim itemName As String = clickedButton.Tag.ToString()

        ' Show the addOrder panel
        pnlAddOrder.Visible = True

        ' Set the item name in the label
        lblItemName.Text = itemName

        ' Reset quantity and size selection
        numQuantity.Value = 1
        rdbMedio.Checked = False
        rdbGrande.Checked = False
    End Sub

    'LOAD CASHIER DATA
    Public Sub LoadRetailerTransactions()
        Dim query As String =
            "SELECT t.transaction_date, t.transaction_number, l.username AS cashier " &
            "FROM tbl_transactions t " &
            "JOIN tbl_login l ON t.user_id = l.user_id " &
            "ORDER BY t.transaction_date DESC"

        Try
            Dim cmd As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dtRetailer.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Failed to load transaction data: " & ex.Message)
        End Try

        dtRetailer.Columns("transaction_date").HeaderText = "Date"
        dtRetailer.Columns("transaction_number").HeaderText = "Transaction no."
        dtRetailer.Columns("cashier").HeaderText = "Cashier"
    End Sub
    'TRANSACTION NUMBER GENERATOR
    Public Sub AddNewTransaction(totalAmount As Decimal, userId As Integer)
        Try
            Dim transactionNumber As String = "TXN" & DateTime.Now.ToString("yyyyMMddHHmmss")
            Dim queryInsert As String =
            "INSERT INTO tbl_transactions (transaction_date, transaction_number, total_amount, user_id) " &
            "VALUES (@date, @number, @amount, @uid)"

            Using cmd As New MySqlCommand(queryInsert, connection)
                cmd.Parameters.AddWithValue("@date", DateTime.Now)
                cmd.Parameters.AddWithValue("@number", transactionNumber)
                cmd.Parameters.AddWithValue("@amount", totalAmount)
                cmd.Parameters.AddWithValue("@uid", userId)

                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If

                cmd.ExecuteNonQuery()
            End Using

            'LATEST TRANSACTION
            Dim querySelect As String =
            "SELECT t.transaction_date, t.transaction_number, l.username AS cashier " &
            "FROM tbl_transactions t " &
            "JOIN tbl_login l ON t.user_id = l.user_id " &
            "ORDER BY t.transaction_id DESC LIMIT 1"

            Using da As New MySqlDataAdapter(querySelect, connection)
                Dim dt As New DataTable()
                da.Fill(dt)

                'DISPLAY
                dtRetailer.DataSource = dt
            End Using

        Catch ex As Exception
            MessageBox.Show("Failed to insert/load transaction: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    'TOTAL LABEL UPDATER
    Private Sub UpdateTotalLabel()
        Dim total As Decimal = 0D

        For Each row As DataGridViewRow In dtOrders.Rows
            If row.Cells("amount").Value IsNot Nothing Then
                total += Convert.ToDecimal(row.Cells("amount").Value)
            End If
        Next

        lblTotal.Text = "₱" & total.ToString("F2")
    End Sub
    'LOG OUT
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to Log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then

            dtRetailer.DataSource = Nothing

            ' CLEAR OTHERS
            currentUserID = 0
            flpItemName.Controls.Clear()
            dtOrders.Rows.Clear()
            cleaner()

            Me.Close()
            Form1.Show()
        End If
    End Sub
    'FOMR
    Private Sub POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectionToDatabase()
        CheckIfItemsEmpty()
        LoadRetailerTransactions()

        dtOrders.Columns.Clear()
        dtOrders.Columns.Add("itemName", "Item Name")
        dtOrders.Columns.Add("unitPrice", "Unit Price")
        dtOrders.Columns.Add("quantity", "Quantity")
        dtOrders.Columns.Add("amount", "Amount")
    End Sub
    'LOAD ORDER NAMES
    Private Sub btnMilkTea_Click(sender As Object, e As EventArgs) Handles btnMilkTea.Click
        loadData(1)
    End Sub

    Private Sub btnCoffee_Click(sender As Object, e As EventArgs) Handles btnCoffee.Click
        loadData(2)
    End Sub

    Private Sub btnFruitTea_Click(sender As Object, e As EventArgs) Handles btnFruitTea.Click
        loadData(3)
    End Sub

    Private Sub btnPRAF_Click(sender As Object, e As EventArgs) Handles btnPRAF.Click
        loadData(4)
    End Sub
    'CLEAR ITEMS
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        flpItemName.Controls.Clear()
        CheckIfItemsEmpty()
    End Sub
    ' ADD ORDER
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ConnectionToDatabase()

        Dim itemName As String = lblItemName.Text
        Dim quantity As Integer = CInt(numQuantity.Value)
        Dim sizePrice As Decimal = 0D
        Dim addonTotal As Decimal = 0D
        Dim selectedAddons As New List(Of String)

        ' Get selected size
        If rdbMedio.Checked Then
            selectedSize = "Medio"
        ElseIf rdbGrande.Checked Then
            selectedSize = "Grande"
        Else
            MessageBox.Show("Please select a size.", "Size Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' FETCH SIZE PRICE
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT price FROM tbl_item_sizes WHERE size_name = @size"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@size", selectedSize)
                Using read As MySqlDataReader = cmd.ExecuteReader()
                    If read.Read() Then
                        sizePrice = Convert.ToDecimal(read("price"))
                    Else
                        MessageBox.Show("Size price not found existing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching size price: " & ex.Message)
            Exit Sub
        End Try

        ' ADDONS
        Dim addonCheckboxes As CheckBox() = {
        chkPearl, chkCrystal, chkCoffeeJelly, chkCreamCheese,
        chkCheeseCake, chkCreamPuff, chkOreo
    }

        For Each chk As CheckBox In addonCheckboxes
            If chk.Checked Then
                addonTotal += 9D
                selectedAddons.Add(chk.Text)
            End If
        Next

        ' TOTAL PRICE FORMULA
        Dim totalPrice As Decimal = (sizePrice + addonTotal) * quantity

        ' SUMMARY
        Dim summary As String = "Order added:" & vbCrLf &
                            "Item: " & itemName & vbCrLf &
                            "Size: " & selectedSize & " - ₱" & sizePrice.ToString("F2") & vbCrLf &
                            "Quantity: " & quantity.ToString() & vbCrLf &
                            "Add-ons: " & If(selectedAddons.Count > 0, String.Join(", ", selectedAddons), "None") & vbCrLf &
                            "Add-on Total: ₱" & addonTotal.ToString("F2") & vbCrLf &
                            "Total Price: ₱" & totalPrice.ToString("F2")



        MessageBox.Show(summary, "Order Added", MessageBoxButtons.OK, MessageBoxIcon.Information)

        dtOrders.Rows.Add(itemName, sizePrice + addonTotal, quantity, totalPrice)

        'DISPLAY TOTAL
        UpdateTotalLabel()
        lblTtl.Visible = True
        lblTotal.Visible = True

        'ENABLE PAYMENT BOX
        txtPay.Enabled = True

        pnlAddOrder.Visible = False

        cleaner()

        connection.Close()
    End Sub
    'BACK TO ORDER BUTTONS
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        pnlAddOrder.Visible = False
        cleaner()
    End Sub
    'SHOW LABELS
    Private Sub txtPay_TextChanged(sender As Object, e As EventArgs) Handles txtPay.TextChanged
        If txtPay.Text <> "" Then
            lblChnge.Visible = True
            lblChange.Visible = True

            Dim total As Decimal
            Dim payment As Decimal

            'TOTAL TXT TO DECIMAL
            If Decimal.TryParse(lblTotal.Text.Replace("₱", "").Trim(), total) AndAlso
           Decimal.TryParse(txtPay.Text.Trim(), payment) Then

                ' CHANGE FORMUILA
                Dim change As Decimal = payment - total

                ' DISPLAY CHANGE IF POSITIVE
                If change >= 0 Then
                    lblChange.Text = "₱" & change.ToString("F2")
                Else
                    lblChange.Text = ""
                End If
            Else
                'HIDE IF PARSING FAIL
                lblChange.Text = ""
            End If
        Else
            'HIDE CHANNGE IF THERE'S NO PAYMENT
            lblChnge.Visible = False
            lblChange.Visible = False
            lblChange.Text = ""
        End If
    End Sub
    'KEY PRESS
    Private Sub txtPay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPay.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso Asc(e.KeyChar) <> 46 Then
            e.Handled = True
        End If

        'PREVENT ENTERING 2 OR MORE DECIMAL
        If e.KeyChar = "." AndAlso txtPay.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub
    'DISPLAY DAILY HISTORY
    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        DailyHistory.ShowDialog()
    End Sub
    'CHECK OUT

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Dim total As Decimal
        Dim payment As Decimal

        'CHECK PAYMENT
        If Not Decimal.TryParse(lblTotal.Text.Replace("₱", "").Trim(), total) Then
            MessageBox.Show("Invalid total amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not Decimal.TryParse(txtPay.Text.Trim(), payment) Then
            MessageBox.Show("Please enter a valid payment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If payment < total Then
            MessageBox.Show("Insufficient payment amount.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'CONFIRM CHECKOUT
        Dim confirm As DialogResult = MessageBox.Show($"Confirm checkout? Change: ₱{(payment - total):F2}", "Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            ' GENERATE TRANSACT NUM
            Dim transactionNumber As String = "TXN" & DateTime.Now.ToString("yyyyMMddHHmmss")

            Try
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If

                ' INSERT transaction record
                Dim queryTransaction As String =
                    "INSERT INTO tbl_transactions (transaction_date, transaction_number, total_amount, customer_payment, change_amount, user_id) " &
                    "VALUES (@date, @number, @amount, @payment, @change, @uid)"

                Using cmdTransaction As New MySqlCommand(queryTransaction, connection)
                    cmdTransaction.Parameters.AddWithValue("@date", DateTime.Now)
                    cmdTransaction.Parameters.AddWithValue("@number", transactionNumber)
                    cmdTransaction.Parameters.AddWithValue("@amount", total)
                    cmdTransaction.Parameters.AddWithValue("@payment", payment)
                    cmdTransaction.Parameters.AddWithValue("@change", payment - total)
                    cmdTransaction.Parameters.AddWithValue("@uid", currentUserID)
                    cmdTransaction.ExecuteNonQuery()
                End Using

                ' FETCH LAST TRANSACTION ID
                Dim transactionId As Integer
                Using cmdGetTransactionId As New MySqlCommand("SELECT transaction_id FROM tbl_transactions WHERE transaction_number = @number", connection)
                    cmdGetTransactionId.Parameters.AddWithValue("@number", transactionNumber)
                    transactionId = Convert.ToInt32(cmdGetTransactionId.ExecuteScalar())
                End Using

                ' INSERT ITEMS WITH ID
                For Each row As DataGridViewRow In dtOrders.Rows
                    If row.Cells("itemName").Value IsNot Nothing Then
                        Dim itemName As String = row.Cells("itemName").Value.ToString()
                        Dim quantity As Integer = Convert.ToInt32(row.Cells("quantity").Value)

                        ' CHECK IF SIZE IS SAVED
                        If String.IsNullOrEmpty(selectedSize) Then
                            MessageBox.Show("Error: Size selection was lost before checkout.", "Size Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If

                        ' FETCH SIZE ID BASE ON selectedsize
                        Dim sizeId As Integer
                        Dim querySizeId As String = "SELECT size_id FROM tbl_item_sizes WHERE LOWER(size_name) = LOWER(@size)"

                        Using cmdGetSizeId As New MySqlCommand(querySizeId, connection)
                            cmdGetSizeId.Parameters.AddWithValue("@size", selectedSize)
                            Dim sizeObj = cmdGetSizeId.ExecuteScalar()
                            If sizeObj IsNot Nothing Then
                                sizeId = Convert.ToInt32(sizeObj)
                            Else
                                MessageBox.Show("Error: Size ID not found.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                        End Using

                        ' FETCH PRICE
                        Dim sizePrice As Decimal
                        Dim querySizePrice As String = "SELECT price FROM tbl_item_sizes WHERE size_id = @sizeId"
                        Using cmdGetSizePrice As New MySqlCommand(querySizePrice, connection)
                            cmdGetSizePrice.Parameters.AddWithValue("@sizeId", sizeId)
                            Dim priceObj = cmdGetSizePrice.ExecuteScalar()
                            If priceObj IsNot Nothing Then
                                sizePrice = Convert.ToDecimal(priceObj)
                            Else
                                MessageBox.Show("Error: Size price not found.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                        End Using

                        ' TOTAL PRICE FORMULA
                        Dim addonTotal As Decimal = 0D
                        Dim addonCheckboxes As CheckBox() = {chkPearl, chkCrystal, chkCoffeeJelly, chkCreamCheese, chkCheeseCake, chkCreamPuff, chkOreo}
                        For Each chk As CheckBox In addonCheckboxes
                            If chk.Checked Then
                                addonTotal += 9D
                            End If
                        Next

                        Dim totalItemPrice As Decimal = (sizePrice + addonTotal) * quantity

                        ' IINSERT INTO Transaction Items Table
                        Dim queryItems As String =
                            "INSERT INTO tbl_transactionItems (transaction_id, item_id, size_id, quantity, total_price) " &
                            "VALUES (@txnId, (SELECT item_id FROM tbl_items WHERE item_name = @name), @sizeId, @qty, @amt)"

                        Using cmdItems As New MySqlCommand(queryItems, connection)
                            cmdItems.Parameters.AddWithValue("@txnId", transactionId)
                            cmdItems.Parameters.AddWithValue("@name", itemName)
                            cmdItems.Parameters.AddWithValue("@sizeId", sizeId)
                            cmdItems.Parameters.AddWithValue("@qty", quantity)
                            cmdItems.Parameters.AddWithValue("@amt", totalItemPrice)
                            cmdItems.ExecuteNonQuery()
                        End Using
                    End If
                Next

                ' CLEAR
                dtRetailer.DataSource = Nothing
                dtOrders.Rows.Clear()
                txtPay.Clear()
                lblTotal.Text = ""
                lblChange.Text = ""
                lblTtl.Visible = False
                lblTotal.Visible = False
                lblChange.Visible = False
                lblChnge.Visible = False
                txtPay.Enabled = False
                picLogo.Visible = True

                ' DISPLAY CONFIRMATION
                MessageBox.Show("Checkout successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Checkout failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End If
    End Sub
    'VOID BUTTON
    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click
        Dim voidConf As DialogResult = MessageBox.Show("Are you sure you want to Void Order?", "Void", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If voidConf = DialogResult.Yes Then
            ' CLEAR
            cleaner()

            dtRetailer.DataSource = Nothing
            dtOrders.Rows.Clear()

            txtPay.Clear()
            lblTotal.Text = ""
            lblChange.Text = ""
            lblTtl.Visible = False
            lblTotal.Visible = False
            lblChange.Visible = False
            lblChnge.Visible = False

            txtPay.Enabled = False
            picLogo.Visible = True
        End If

    End Sub

    'EDIT BUTTON
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' CHECK IF ROW IS SELECTED
        If dtOrders.SelectedRows.Count > 0 Then
            'SELETED ROW
            Dim selectedRow As DataGridViewRow = dtOrders.SelectedRows(0)

            ' CHECK IF ROW IS NOT EMPTY
            If selectedRow.Cells("itemName").Value IsNot Nothing AndAlso selectedRow.Cells("itemName").Value.ToString() <> String.Empty Then

                'DETAILS
                Dim itemName As String = selectedRow.Cells("itemName").Value.ToString()
                Dim quantity As Integer = If(selectedRow.Cells("quantity").Value IsNot DBNull.Value, CInt(selectedRow.Cells("quantity").Value), 0)
                Dim totalPrice As Decimal = If(selectedRow.Cells("amount").Value IsNot DBNull.Value, CDec(selectedRow.Cells("amount").Value), 0D)
                Dim unitPrice As Decimal = If(selectedRow.Cells("unitPrice").Value IsNot DBNull.Value, CDec(selectedRow.Cells("unitPrice").Value), 0D)

                lblItemName.Text = itemName
                numQuantity.Value = quantity

                ' CALCULATE SIZE IF IT MATCHES PRICE
                If totalPrice / quantity = unitPrice Then
                    rdbMedio.Checked = True
                ElseIf totalPrice / quantity = unitPrice + 9D Then
                    rdbGrande.Checked = True
                End If

                ' CLEAR
                chkPearl.Checked = False
                chkCrystal.Checked = False
                chkCoffeeJelly.Checked = False
                chkCreamCheese.Checked = False
                chkCheeseCake.Checked = False
                chkCreamPuff.Checked = False
                chkOreo.Checked = False

                'ADD ONS
                Dim addonTotal As Decimal = totalPrice - (unitPrice * quantity)
                If addonTotal > 0 Then
                    For Each chk As CheckBox In {chkPearl, chkCrystal, chkCoffeeJelly, chkCreamCheese, chkCheeseCake, chkCreamPuff, chkOreo}
                        chk.Checked = True
                        addonTotal -= 9D
                    Next
                End If

                ' DISPLAY BTN AND SHTS
                pnlAddOrder.Visible = True
                btnEditOrder.Visible = True
                btnEditOrder.Enabled = True
                btnCancel.Visible = True
                btnCancel.Enabled = True
            Else
                MessageBox.Show("The selected row is empty. Please select a valid order.", "Empty Row", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Please select an order to edit.", "No Order Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    'EDIT ORDERS BUTTON
    Private Sub btnEditOrder_Click(sender As Object, e As EventArgs) Handles btnEditOrder.Click
        ' CHECK IF SIZE IS NOT EMPTY
        Dim selectedSize As String = ""

        If rdbMedio.Checked Then
            selectedSize = "Medio"
        ElseIf rdbGrande.Checked Then
            selectedSize = "Grande"
        Else
            MessageBox.Show("Please select a size.", "Size Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' PROCEED IF NOT EMPTY
        If dtOrders.SelectedRows.Count > 0 Then

            'GET SELECTED ROW
            Dim selectedRow As DataGridViewRow = dtOrders.SelectedRows(0)

            ' NEW VALUE
            Dim newItemName As String = lblItemName.Text
            Dim newQuantity As Integer = CInt(numQuantity.Value)
            Dim newSizePrice As Decimal = If(rdbMedio.Checked, 29D, 39D)
            Dim addonTotal As Decimal = 0D
            Dim selectedAddons As New List(Of String)

            'CALCULATE ADD ON
            Dim addonCheckboxes As CheckBox() = {
            chkPearl, chkCrystal, chkCoffeeJelly, chkCreamCheese,
            chkCheeseCake, chkCreamPuff, chkOreo
        }

            For Each chk As CheckBox In addonCheckboxes
                If chk.Checked Then
                    addonTotal += 9D
                    selectedAddons.Add(chk.Text)
                End If
            Next

            ' TOTAL PRICE FORMULA
            Dim newTotalPrice As Decimal = (newSizePrice + addonTotal) * newQuantity

            'UPDATE ROW
            selectedRow.Cells("itemName").Value = newItemName
            selectedRow.Cells("quantity").Value = newQuantity
            selectedRow.Cells("unitPrice").Value = newSizePrice
            selectedRow.Cells("amount").Value = newTotalPrice

            ' UPDATE TOTAL LABEL
            UpdateTotalLabel()

            ' HIDE EDIT PARTS
            pnlAddOrder.Visible = False
            btnEditOrder.Visible = False
            btnEditOrder.Enabled = False

            MessageBox.Show("Order updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please select an order to edit.", "No Order Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub dtOrders_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtOrders.CellClick
        ' CHECK IF ROW IS SELECTED
        If e.RowIndex >= 0 Then

            ' SELECT WHOLE LINE
            dtOrders.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' HIDE PNL
        pnlAddOrder.Visible = False
        btnCancel.Visible = False
        btnCancel.Enabled = False

        'RESET SOME FIELDS
        lblItemName.Text = String.Empty
        numQuantity.Value = 0
        rdbMedio.Checked = False
        rdbGrande.Checked = False
        chkPearl.Checked = False
        chkCrystal.Checked = False
        chkCoffeeJelly.Checked = False
        chkCreamCheese.Checked = False
        chkCheeseCake.Checked = False
        chkCreamPuff.Checked = False
        chkOreo.Checked = False

        'EDIT ORDER
        btnEditOrder.Visible = False
        btnEditOrder.Enabled = False

        MessageBox.Show("Editing cancelled.", "Edit Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
'CREATED BY: ALEX DANIEL P. BARRAMEDA
'CREATED BY: ALEX DANIEL P. BARRAMEDA
'CREATED BY: ALEX DANIEL P. BARRAMEDA
'CREATED BY: ALEX DANIEL P. BARRAMEDA
'CREATED BY: ALEX DANIEL P. BARRAMEDA