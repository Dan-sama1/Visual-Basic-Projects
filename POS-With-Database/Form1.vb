Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D

Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ConnectionToDatabase()
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please fill out all the fields!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()
            Return
        End If

        Try
            Dim command As New MySqlCommand("SELECT user_id, roles FROM tbl_login WHERE username=@username AND upassword=@password", connection)
            command.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
            command.Parameters.AddWithValue("@password", txtPassword.Text.Trim())

            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.Read Then
                Dim role As String = reader("roles").ToString()
                Dim userId As Integer = Convert.ToInt32(reader("user_id"))

                reader.Close()
                connection.Close()

                'UPDATE LOGIN
                ConnectionToDatabase()
                Dim updateCommand As New MySqlCommand("UPDATE tbl_login SET last_login = NOW() WHERE user_id = @userId", connection)
                updateCommand.Parameters.AddWithValue("@userId", userId)
                updateCommand.ExecuteNonQuery()
                connection.Close()

                'REDIRECT TO ADMINZ
                If role = "admin" Then
                    MsgBox("Welcome Admin!")
                    Admin.Show()
                ElseIf role = "cashier" Then
                    MsgBox("Welcome Cashier!")
                    Dim posForm As New POS()
                    posForm.currentUserID = userId
                    posForm.Show()
                End If

                txtUsername.Clear()
                txtPassword.Clear()
                txtUsername.Focus()

                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                connection.Close()
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            If connection.State = ConnectionState.Open Then connection.Close()
        End Try
    End Sub
    ' SHOW CHIK BOX
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text <> "" Then
            chkShowPass.Visible = True
        Else
            chkShowPass.Visible = False
        End If
    End Sub
    'SHOW PASS
    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
    'click button if user hit enter
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnLogin.PerformClick()
        End If
    End Sub

    'ADD TEXT OUTLINE
    Private Sub txtLabel_Paint(sender As Object, e As PaintEventArgs) Handles txtLabel.Paint
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        Dim text As String = txtLabel.Text
        Dim font As New Font("Poppins", 24, FontStyle.Bold)

        Dim path As New GraphicsPath()
        path.AddString(text, font.FontFamily, CInt(font.Style), font.SizeInPoints * 1.33F, New Point(0, 0), StringFormat.GenericDefault)

        ' OUTLINE
        Dim outlinePen As New Pen(Color.Black, 2)
        g.DrawPath(outlinePen, path)

        'CUSTOM COLOR TEXT
        Dim fillBrush As New SolidBrush(Color.FromArgb(248, 244, 220))
        g.FillPath(fillBrush, path)
    End Sub

End Class


