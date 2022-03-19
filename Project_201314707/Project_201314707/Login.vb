Public Class Login
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        user_id = ""
        user_name = ""
        user_username = ""
        user_password = ""
        user_type = ""
        user_picture = ""
        txt_password.Text = ""
        Me.Close()
        Form1.Visible = True
        Form1.txt_usrname.Text = ""
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        PM.ValidLoginP(txt_password.Text)
    End Sub
End Class