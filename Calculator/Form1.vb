Public Class Form1
    'MAKING THE BUTTON ROUND
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CLEARING
        RoundButton(btnBckSpc)
        RoundButton(btnClear)
        'OPERATORS
        RoundButton(btnPlus)
        RoundButton(btnMinus)
        RoundButton(btnMultiply)
        RoundButton(btnDivide)
        'NUMBERS
        RoundButton(btn9)
        RoundButton(btn8)
        RoundButton(btn7)
        RoundButton(btn6)
        RoundButton(btn5)
        RoundButton(btn4)
        RoundButton(btn3)
        RoundButton(btn2)
        RoundButton(btn1)
        RoundButton(btn0)
        'EQUAL, POINT AND CHANGE
        RoundButton(btnEqual)
        RoundButton(btnPoint)
        RoundButton(btn00)

    End Sub
    'BUTTON DESIGN
    Private Sub RoundButton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0

        Dim Raduis As New Drawing2D.GraphicsPath
        Dim radius As Integer = 10

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)

        ' Top edge
        Raduis.AddLine(radius, 0, btn.Width - radius, 0)

        ' Top-right corner
        Raduis.AddArc(New Rectangle(btn.Width - radius, 0, radius, radius), -90, 90)

        ' Right edge
        Raduis.AddLine(btn.Width, radius, btn.Width, btn.Height - radius)

        ' Bottom-right corner
        Raduis.AddArc(New Rectangle(btn.Width - radius, btn.Height - radius, radius, radius), 0, 90)

        ' Bottom edge
        Raduis.AddLine(btn.Width - radius, btn.Height, radius, btn.Height)

        ' Bottom-left corner
        Raduis.AddArc(New Rectangle(0, btn.Height - radius, radius, radius), 90, 90)

        ' Close the figure
        Raduis.CloseFigure()

        ' Set the region for the button to apply the rounded edges
        btn.Region = New Region(Raduis)
    End Sub
    'SET CURSOR TO RIGHT
    Private Sub UpdateDisplay(text As String)
        txtDisplay.Text &= text
        txtDisplay.SelectionStart = txtDisplay.Text.Length
        txtDisplay.SelectionLength = 0
    End Sub
    'IF THE TEXTBOX IS ERROR STATE
    Private Function IsError() As Boolean
        Return txtDisplay.Text = "Error"
    End Function

    'OUTPUT OF DIGIT BUTTON CLICKS ON KEYBOARD AND BUTTON
    Public Sub DigitButtonClicks(button As Button)
        If IsError() Then Return
        txtDisplay.Text &= button.Text
    End Sub

    'NUMBER 0
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        Dim button0 As Button = CType(sender, Button)
        DigitButtonClicks(button0)
        txtDisplay.Focus()
    End Sub
    'DOUBLE 0
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btn00.Click
        Dim button00 As Button = CType(sender, Button)
        DigitButtonClicks(button00)
    End Sub
    'NUMBER 1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim button1 As Button = CType(sender, Button)
        DigitButtonClicks(button1)
    End Sub
    'NUMBER 2
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim button2 As Button = CType(sender, Button)
        DigitButtonClicks(button2)
    End Sub
    'NUMBER 3
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Dim button3 As Button = CType(sender, Button)
        DigitButtonClicks(button3)
    End Sub
    'NUMBER 4
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Dim button4 As Button = CType(sender, Button)
        DigitButtonClicks(button4)
    End Sub
    'NUMBER 5
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        Dim button5 As Button = CType(sender, Button)
        DigitButtonClicks(button5)
    End Sub
    'NUMBER 6
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        Dim button6 As Button = CType(sender, Button)
        DigitButtonClicks(button6)
    End Sub
    'NUMBER 7
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        Dim button7 As Button = CType(sender, Button)
        DigitButtonClicks(button7)
    End Sub
    'NUMBER 8
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        Dim button8 As Button = CType(sender, Button)
        DigitButtonClicks(button8)
    End Sub
    'NUMBER 9
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        Dim button9 As Button = CType(sender, Button)
        DigitButtonClicks(button9)
    End Sub

    'OUTPUT OF OPERATOR BUTTON CLICKS ON KEYBOARD AND BUTTON
    Public Sub OperatorButtonClicks(button As Button)
        If IsError() Then Return
        If String.IsNullOrEmpty(txtDisplay.Text) OrElse txtDisplay.Text.EndsWith("+") OrElse
        txtDisplay.Text.EndsWith("-") OrElse txtDisplay.Text.EndsWith("*") OrElse txtDisplay.Text.EndsWith("/") Then
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1) & button.Text
        Else
            txtDisplay.Text &= button.Text
        End If
        txtDisplay.SelectionStart = txtDisplay.Text.Length
        txtDisplay.SelectionLength = 0
    End Sub
    Public Sub HandleOperatorInput(ope As String)
        ' Check if last character is an operator
        If String.IsNullOrEmpty(txtDisplay.Text) OrElse txtDisplay.Text.EndsWith("+") OrElse
        txtDisplay.Text.EndsWith("-") OrElse txtDisplay.Text.EndsWith("*") OrElse txtDisplay.Text.EndsWith("/") Then
            Return
        End If
        txtDisplay.Text &= ope
        txtDisplay.SelectionStart = txtDisplay.Text.Length
        txtDisplay.SelectionLength = 0
    End Sub
    'ADD
    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Dim add As Button = CType(sender, Button)
        OperatorButtonClicks(add)
    End Sub
    'MINUS
    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        Dim minus As Button = CType(sender, Button)
        OperatorButtonClicks(minus)
    End Sub
    'MULTIPLY
    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        Dim multiply As Button = CType(sender, Button)
        OperatorButtonClicks(multiply)
    End Sub
    'DIVIDE
    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Dim divide As Button = CType(sender, Button)
        OperatorButtonClicks(divide)
    End Sub
    'POINT
    Private Sub btnPoint_Click(sender As Object, e As EventArgs) Handles btnPoint.Click
        txtDisplay.Text &= "."
    End Sub
    'EQUAL
    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If IsError() Then Return
        Try
            If txtDisplay.Text.Contains("/0") Then
                txtDisplay.Text = "Error"
                'SET CURSOR TO RIGHT
                txtDisplay.SelectionStart = txtDisplay.Text.Length
                txtDisplay.SelectionLength = 0
            Else
                Dim result As Object = New DataTable().Compute(txtDisplay.Text, Nothing)
                txtDisplay.Text = result.ToString()
                'SET CURSOR TO RIGHT
                txtDisplay.SelectionStart = txtDisplay.Text.Length
                txtDisplay.SelectionLength = 0
            End If
        Catch ex As Exception
            txtDisplay.Text = "Error"
            'SET CURSOR TO RIGHT
            txtDisplay.SelectionStart = txtDisplay.Text.Length
            txtDisplay.SelectionLength = 0
        End Try
    End Sub
    'BACKSPACE
    Private Sub btnBckSpc_Click(sender As Object, e As EventArgs) Handles btnBckSpc.Click
        If IsError() Then txtDisplay.Clear()
        If txtDisplay.Text.Length > 0 Then
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1)
        End If
    End Sub
    'CLEAR
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Clear()
    End Sub
    'USING KEYBOARD AND LIMITING THE CLIKS TO NUMBERS AND OPERATORS AND SUCH ONLY
    Dim IsKeyHandled As Boolean = False
    Private Sub txtDisplay_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDisplay.KeyDown
        'BACKSPACE
        If e.KeyCode = Keys.Back Then
            If IsError() Then
                txtDisplay.Clear()
                e.SuppressKeyPress = True
                Return
            ElseIf txtDisplay.Text.Length > 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1)
                txtDisplay.SelectionStart = txtDisplay.Text.Length
                txtDisplay.SelectionLength = 0
            End If
        End If

        'CHECK IF THE BUTTON CLICKED IS NUMBERS, OPERATOR, DECIMAL, BACKSPACE OR ENTER
        If (e.KeyCode >= Keys.D0 AndAlso e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 AndAlso e.KeyCode <= Keys.NumPad9) OrElse
        e.KeyCode = Keys.Add OrElse e.KeyCode = Keys.Subtract OrElse e.KeyCode = Keys.Multiply OrElse e.KeyCode = Keys.Divide OrElse
        e.KeyCode = Keys.OemPeriod OrElse e.KeyCode = Keys.Decimal OrElse e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Back Then

            e.SuppressKeyPress = True

            If IsError() Then Return
            If e.KeyCode >= Keys.D0 AndAlso e.KeyCode <= Keys.D9 Then
                UpdateDisplay((e.KeyCode - Keys.D0).ToString())
            ElseIf e.KeyCode >= Keys.NumPad0 AndAlso e.KeyCode <= Keys.NumPad9 Then
                UpdateDisplay((e.KeyCode - Keys.NumPad0).ToString())
            ElseIf e.KeyCode = Keys.Add Then
                OperatorButtonClicks(btnPlus)
            ElseIf e.KeyCode = Keys.Subtract Then
                OperatorButtonClicks(btnMinus)
            ElseIf e.KeyCode = Keys.Multiply Then
                OperatorButtonClicks(btnMultiply)
            ElseIf e.KeyCode = Keys.Divide Then
                OperatorButtonClicks(btnDivide)
            ElseIf e.KeyCode = Keys.OemPeriod OrElse e.KeyCode = Keys.Decimal Then
                UpdateDisplay(".")
            ElseIf e.KeyCode = Keys.Enter Then
                btnEqual.PerformClick()
            End If
            IsKeyHandled = True
        End If
        If Not IsKeyHandled Then
            e.SuppressKeyPress = True
        End If

        Dim btn As Button = Nothing
        Select Case e.KeyCode
            Case Keys.D0, Keys.NumPad0
                btn = btn0
            Case Keys.D1, Keys.NumPad1
                btn = btn1
            Case Keys.D2, Keys.NumPad2
                btn = btn2
            Case Keys.D3, Keys.NumPad3
                btn = btn3
            Case Keys.D4, Keys.NumPad4
                btn = btn4
            Case Keys.D5, Keys.NumPad5
                btn = btn5
            Case Keys.D6, Keys.NumPad6
                btn = btn6
            Case Keys.D7, Keys.NumPad7
                btn = btn7
            Case Keys.D8, Keys.NumPad8
                btn = btn8
            Case Keys.D9, Keys.NumPad9
                btn = btn9
            Case Keys.Add
                btn = btnPlus
            Case Keys.Subtract
                btn = btnMinus
            Case Keys.Multiply
                btn = btnMultiply
            Case Keys.Divide
                btn = btnDivide
            Case Keys.OemPeriod, Keys.Decimal
                btn = btnPoint
            Case Keys.Back
                btn = btnBckSpc
        End Select
        If btn IsNot Nothing Then
            btn.BackColor = Color.Gray
        End If
    End Sub
    'KEY UP
    Private Sub txtDisplay_KeyUp(sender As Object, e As KeyEventArgs) Handles txtDisplay.KeyUp
        'CHANGE COLOR
        Dim btn As Button = Nothing
        Select Case e.KeyCode
            Case Keys.D0, Keys.NumPad0
                btn = btn0
            Case Keys.D1, Keys.NumPad1
                btn = btn1
            Case Keys.D2, Keys.NumPad2
                btn = btn2
            Case Keys.D3, Keys.NumPad3
                btn = btn3
            Case Keys.D4, Keys.NumPad4
                btn = btn4
            Case Keys.D5, Keys.NumPad5
                btn = btn5
            Case Keys.D6, Keys.NumPad6
                btn = btn6
            Case Keys.D7, Keys.NumPad7
                btn = btn7
            Case Keys.D8, Keys.NumPad8
                btn = btn8
            Case Keys.D9, Keys.NumPad9
                btn = btn9
            Case Keys.Add
                btn = btnPlus
            Case Keys.Subtract
                btn = btnMinus
            Case Keys.Multiply
                btn = btnMultiply
            Case Keys.Divide
                btn = btnDivide
            Case Keys.OemPeriod, Keys.Decimal
                btn = btnPoint
            Case Keys.Back
                btn = btnBckSpc
        End Select
        If btn IsNot Nothing Then
            btn.BackColor = Color.FromArgb(173, 73, 225)
            btn.ForeColor = Color.FromArgb(235, 211, 248)
        End If
        IsKeyHandled = False
    End Sub
End Class
