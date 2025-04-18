Imports MySql.Data.MySqlClient

Public Class Form1
    Public CurrentUserID As Integer

    Private Sub Closer()
        txtUser.Clear()
        txtPass.Clear()
        txtUser.Focus()
        chkShowPass.Checked = False
    End Sub

    'LOG IN
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ConnectionToDatabase()

        Dim cmd As New MySqlCommand("SELECT ID FROM USERS WHERE BINARY USERNAME=@username AND UPASSWORD=@password", connection)
        cmd.Parameters.AddWithValue("@username", txtUser.Text)
        cmd.Parameters.AddWithValue("@password", txtPass.Text)
        Dim reader = cmd.ExecuteReader()

        If reader.Read Then
            CurrentUserID = reader("ID")
            connection.Close()

            Items.userID = CurrentUserID
            Items.Show()
            Me.Hide()
        Else
            MsgBox("Invalid Credentials.")
            txtPass.Clear()
            txtUser.Focus()
            connection.Close()
        End If

    End Sub

    'SHOW CHECK BOX
    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        If txtPass.Text <> "" Then
            chkShowPass.Visible = True
        Else
            chkShowPass.Visible = False
        End If
    End Sub

    'SHOW PASS
    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        SignIn.Show()
        Me.Hide()
        txtUser.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Focus()
    End Sub
End Class
