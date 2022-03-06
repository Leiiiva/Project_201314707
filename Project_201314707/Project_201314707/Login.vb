Public Class Login
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
        Form1.Visible = True
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Me.Close()
        Form1.pnl_start.Visible = False
        Form1.pnl_left.Visible = True
        Form1.pnl_bottom.Visible = True
        Form1.lbl_server.Visible = True
        Form1.pb_status2.Visible = True
        Form1.Visible = True
    End Sub
End Class