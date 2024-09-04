Public Class frmClock
    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick
        'lblClock1.Text = TimeString ' 24 hour time
        lblClock2.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

End Class
