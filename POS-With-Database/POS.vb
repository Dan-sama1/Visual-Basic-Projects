Imports MySql.Data.MySqlClient

Public Class POS
    Dim command As New MySqlCommand
    Dim read As MySqlDataReader
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to Log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            Me.Close()
            Form1.Show()
        End If
    End Sub
    Private Sub POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectionToDatabase()
    End Sub

    Sub loadData(categoryId As Integer)
        flpItemName.Controls.Clear()
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT item_name FROM tbl_items WHERE category_id = @categoryId"
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
    End Sub

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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        flpItemName.Controls.Clear()
    End Sub
End Class