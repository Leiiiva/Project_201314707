Public Class M_users

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
        Admin.Visible = True
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        DeleteU(lstbx_users.SelectedItem.ToString)
    End Sub

    Private Sub M_users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Update_UL()
    End Sub
End Class