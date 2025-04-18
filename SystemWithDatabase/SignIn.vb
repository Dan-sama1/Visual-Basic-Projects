Imports MySql.Data.MySqlClient

Public Class SignIn
    Private Sub closer()
        txtUser.Clear()
        txtConfirmPass.Clear()
        txtPass.Clear()
        txtUser.Focus()
    End Sub
    'BACK
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Form1.txtUser.Focus()
        Me.Close()
    End Sub
    'SHOW CHECK BOX 1
    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        If txtPass.Text <> "" Then
            chkShowPass.Visible = True
        Else
            chkShowPass.Visible = False
        End If
    End Sub
    'SHOW CHECK BOX 2
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPass.TextChanged
        If txtConfirmPass.Text <> "" Then
            chkShowPass2.Visible = True
        Else
            chkShowPass2.Visible = False
        End If

    End Sub
    'FOCUS CONFIRM TEXT BOX
    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtConfirmPass.Focus()
        End If
    End Sub
    'REGISTER ENTER
    Private Sub txtConfirmPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConfirmPass.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnRegister.PerformClick()
        End If
    End Sub

    'REGISTER BUTTON
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ConnectionToDatabase()

        'CHECK IF THE FIELDS ARE FILLED UP
        If txtUser.Text = "" Or txtPass.Text = "" Or txtConfirmPass.Text = "" Then
            MsgBox("Please fill out all the fields!", vbExclamation)
            closer()
            Return
        End If

        'CHECK IF THE PASS AND CONFIRM PASS IS THE SAME
        If txtPass.Text <> txtConfirmPass.Text Then
            MsgBox("Passwords do not match!", vbExclamation)
            closer()
            Return
        End If

        'CHECK IF PASS ALREADY EXISTS
        Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM USERS WHERE USERNAME = @username", connection)
        checkCmd.Parameters.AddWithValue("@username", txtUser.Text)
        Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

        If count > 0 Then
            MsgBox("Username Already Exists!", vbExclamation)
            closer()
            connection.Close()
            Return
        End If

        'REGISTERS THE ACCOUNT
        Dim cmd As New MySqlCommand("INSERT INTO USERS (USERNAME, UPASSWORD) VALUES (@username, @password)", connection)
        cmd.Parameters.AddWithValue("@username", txtUser.Text)
        cmd.Parameters.AddWithValue("@password", txtConfirmPass.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Account Registered!", vbOKOnly)
        MsgBox("Go back to Home...", vbOKOnly)
        connection.Close()
        closer()
        Me.Hide()
        Form1.Show()

    End Sub

    'SHOW PASS 1
    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    'SHOW PASS 2
    Private Sub chkShowPass2_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass2.CheckedChanged
        If chkShowPass2.Checked = True Then
            txtConfirmPass.UseSystemPasswordChar = False
        Else
            txtConfirmPass.UseSystemPasswordChar = True
        End If
    End Sub

End Class