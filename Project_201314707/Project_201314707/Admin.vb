Public Class Admin

    Private Sub btn_musers_Click(sender As Object, e As EventArgs) Handles btn_musers.Click
        Me.Close()
        M_users.Visible = True
    End Sub

    Private Sub btn_msongs_Click(sender As Object, e As EventArgs) Handles btn_msongs.Click
        Me.Close()
        M_songs.Visible = True
    End Sub

    Private Sub btn_martists_Click(sender As Object, e As EventArgs) Handles btn_martists.Click
        Me.Close()
        M_artists.Visible = True
    End Sub

    Private Sub btn_reports_Click(sender As Object, e As EventArgs) Handles btn_reports.Click
        Me.Close()
        Reports.Visible = True
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        Form1.Visible = True
        Form1.pnl_left.Visible = False
        Form1.pnl_bottom.Visible = False
        Form1.lbl_server.Visible = False
        Form1.pb_status2.Visible = False
        Form1.pnl_start.Visible = True
    End Sub
End Class