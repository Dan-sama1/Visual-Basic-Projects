Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Num1 As Integer
        Dim Num2 As Integer
        Dim total As Integer

        If IsNumeric(txtNum1.Text) = True AndAlso IsNumeric(txtNum2.Text) = True Then
            Num1 = CInt(txtNum1.Text)
            Num2 = CInt(txtNum2.Text)
        Else
            MessageBox.Show("PLEASE ENTER A VALID NUMBER.")
            Exit Sub
        End If

        total = Num1 + Num2

        txtAns.Text = total.ToString()
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        Dim Num1 As Integer
        Dim Num2 As Integer
        Dim total As Integer

        If IsNumeric(txtNum1.Text) = True AndAlso IsNumeric(txtNum2.Text) = True Then
            Num1 = CInt(txtNum1.Text)
            Num2 = CInt(txtNum2.Text)
        Else
            MessageBox.Show("PLEASE ENTER A VALID NUMBER.")
            Exit Sub
        End If

        total = Num1 * Num2

        txtAns.Text = total.ToString()
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Dim Num1 As Integer
        Dim Num2 As Integer
        Dim total As Integer

        If IsNumeric(txtNum1.Text) = True AndAlso IsNumeric(txtNum2.Text) = True Then
            Num1 = CInt(txtNum1.Text)
            Num2 = CInt(txtNum2.Text)
        Else
            MessageBox.Show("PLEASE ENTER A VALID NUMBER.")
            Exit Sub
        End If

        total = Num1 - Num2

        txtAns.Text = total.ToString()
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Dim Num1 As Integer
        Dim Num2 As Integer
        Dim total As Integer

        If IsNumeric(txtNum1.Text) = True AndAlso IsNumeric(txtNum2.Text) = True Then
            Num1 = CInt(txtNum1.Text)
            Num2 = CInt(txtNum2.Text)
        Else
            MessageBox.Show("PLEASE ENTER A VALID NUMBER.")
            Exit Sub
        End If

        total = Num1 / Num2

        txtAns.Text = total.ToString()
    End Sub

    Private Sub btnIntDiv_Click(sender As Object, e As EventArgs) Handles btnIntDiv.Click
        Dim Num1 As Integer
        Dim Num2 As Integer
        Dim total As Integer

        If IsNumeric(txtNum1.Text) = True AndAlso IsNumeric(txtNum2.Text) = True Then
            Num1 = CInt(txtNum1.Text)
            Num2 = CInt(txtNum2.Text)
        Else
            MessageBox.Show("PLEASE ENTER A VALID NUMBER.")
            Exit Sub
        End If

        total = Num1 \ Num2

        txtAns.Text = total.ToString()
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Dim Num1 As Integer
        Dim Num2 As Integer
        Dim total As Integer

        If IsNumeric(txtNum1.Text) = True AndAlso IsNumeric(txtNum2.Text) = True Then
            Num1 = CInt(txtNum1.Text)
            Num2 = CInt(txtNum2.Text)
        Else
            MessageBox.Show("PLEASE ENTER A VALID NUMBER.")
            Exit Sub
        End If

        total = Num1 Mod Num2

        txtAns.Text = total.ToString()
    End Sub
End Class
