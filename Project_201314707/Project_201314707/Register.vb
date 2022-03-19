Public Class Register

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
        Form1.Visible = True
    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        Dim myPassword As String = txt_password.Text
        Dim cPassword As String = txt_cpassword.Text
        If myPassword = cPassword Then
            If PM.ValidRegisterP(myPassword) Then
                Me.Close()
                Form1.pnl_start.Visible = False
                Form1.pnl_left.Visible = True
                Form1.pnl_bottom.Visible = True
                Form1.lbl_server.Visible = True
                Form1.pb_status2.Visible = True
                Form1.Visible = True
            Else
                MsgBox("Passwords {0} do not match")
            End If
        Else
            MsgBox("Password {0} is invalid")
        End If
    End Sub
End Class