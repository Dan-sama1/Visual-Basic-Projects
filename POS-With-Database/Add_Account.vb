Imports MySql.Data.MySqlClient

Public Class Add_Account

    Private Sub clean()
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPass.Clear()
        cboRole.SelectedIndex = -1
        txtUsername.Focus()
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        'CHECK IF THE FIELDS ARE FILLED UP
        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtConfirmPass.Text = "" Then
            MsgBox("Please fill out all the fields!", vbExclamation)
            Return
        End If

        'CHECK IF THE PASS AND CONFIRM PASS IS THE SAME
        If txtPassword.Text <> txtConfirmPass.Text Then
            MsgBox("Passwords do not match!", vbExclamation)
            Return
        End If

        Try
            ConnectionToDatabase()

            'CHECK IF USERNAME ALREADY EXISTS
            Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM tbl_login WHERE USERNAME = @username", connection)
            checkCmd.Parameters.AddWithValue("@username", txtUsername.Text)
            Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            'Chekc if acc alr exists
            If count > 0 Then
                MsgBox("Username Already Exists!", vbExclamation)
                clean()
                connection.Close()
                Return
            End If

            ' Insert new user
            Dim insertCmd As New MySqlCommand("INSERT INTO tbl_login (username, upassword, roles) VALUES (@username, @password, @role)", connection)
            insertCmd.Parameters.AddWithValue("@username", txtUsername.Text)
            insertCmd.Parameters.AddWithValue("@password", txtPassword.Text)
            insertCmd.Parameters.AddWithValue("@role", cboRole.Text)

            Dim result As Integer = insertCmd.ExecuteNonQuery()

            'Register Acc
            If result > 0 Then
                MsgBox("Account successfully created!", vbInformation)
                clean()
            Else
                MsgBox("Failed to create account.", vbCritical)
            End If


        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Add_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboRole.Items.Clear()
        cboRole.Items.Add("cashier")
        cboRole.Items.Add("admin")

        AddHandler txtUsername.TextChanged, AddressOf textfields
        AddHandler txtPassword.TextChanged, AddressOf textfields
        AddHandler txtConfirmPass.TextChanged, AddressOf textfields
    End Sub


    Private Sub textfields()
        If txtUsername.Text <> "" AndAlso txtPassword.Text <> "" AndAlso txtConfirmPass.Text <> "" Then
            cboRole.Enabled = True
        Else
            cboRole.SelectedIndex = -1
            cboRole.Enabled = False
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text <> "" Then
            chkShowPass.Visible = True
        Else
            chkShowPass.Visible = False
        End If
    End Sub

    Private Sub txtConfirmPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPass.TextChanged
        If txtConfirmPass.Text <> "" Then
            chkShowPass2.Visible = True
        Else
            chkShowPass2.Visible = False
        End If
    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub chkShowPass2_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass2.CheckedChanged
        If chkShowPass2.Checked Then
            txtConfirmPass.UseSystemPasswordChar = False
        Else
            txtConfirmPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        clean()
        Me.Close()
    End Sub
End Class