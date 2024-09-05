Public Class frmForm
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick
        lblTime.Text = DateTime.Now.ToString("hh:mm")
        lblAM.Text = DateTime.Now.ToString("tt")
        lblDay.Text = DateTime.Now.ToString("dddd")
        lblMonth.Text = DateTime.Now.ToString("MMMM")
        lblDate.Text = DateTime.Now.ToString("dd, yyyy")
    End Sub

End Class
