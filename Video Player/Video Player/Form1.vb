Public Class Form1
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If Me.OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            wmpVidPlayer.URL = OpenFileDialog.FileName
        End If
    End Sub
End Class
