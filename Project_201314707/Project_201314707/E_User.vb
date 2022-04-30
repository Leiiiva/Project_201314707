Public Class E_User

    Dim picpath As String
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click

        If ((txt_fullname.Text = "") Or (txt_username.Text = "") Or (txt_password.Text = "") Or (txt_cpassword.Text = "")) Then
            MsgBox("Ingrese todos lo campos")
        Else
            PM.UpdateU(txt_fullname.Text, txt_username.Text, txt_password.Text, txt_cpassword.Text, picturepath)
            Me.Visible = False
            Form1.Visible = True
        End If
    End Sub

    Private Sub btn_openimage_Click(sender As Object, e As EventArgs) Handles btn_openimage.Click
        ofd_pic.ShowDialog()
        picpath = ofd_pic.FileName()
        If Not (picpath = "") Then
            lbl_path.Text = picpath
        Else
            MsgBox("Seleccione una imagen por favor")
        End If
    End Sub


End Class