Public Class Register

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
        Form1.Visible = True
    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        If (Not (txt_fullname.Text = "") And Not (txt_username.Text = "") And Not (txt_password.Text = "") And Not (txt_cpassword.Text = "") And Not (picturepath = "")) Then
            PM.RegisterNU(txt_fullname.Text, txt_username.Text, txt_password.Text, txt_cpassword.Text, picturepath)
        Else
            MsgBox("Ingrese todos lo campos")
        End If
    End Sub

    Private Sub btn_openimage_Click(sender As Object, e As EventArgs) Handles btn_openimage.Click
        ofd_register.ShowDialog()
        picturepath = ofd_register.FileName()
        If Not (picturepath = "") Then
            lbl_path.Text = picturepath
        Else
            MsgBox("Seleccione una imagen por favor")
        End If
    End Sub
End Class