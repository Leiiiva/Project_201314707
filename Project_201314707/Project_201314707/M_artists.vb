Public Class M_artists

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
        Admin.Visible = True
    End Sub

    Private Sub btn_addartist_Click(sender As Object, e As EventArgs) Handles btn_addartist.Click
        If (Not (txt_artistname.Text = "") And Not (txt_country.Text = "")) Then
            PM.RegisterNA(txt_artistname.Text, txt_country.Text)
        Else
            MsgBox("Ingrese todos lo campos")
        End If
    End Sub

    Private Sub btn_deleteartist_Click(sender As Object, e As EventArgs) Handles btn_deleteartist.Click
        DeleteA(lstbx_artists.SelectedItem.ToString)
    End Sub

    Private Sub M_artists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Update_AL()
    End Sub
End Class