Public Class Form1
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

End Class
