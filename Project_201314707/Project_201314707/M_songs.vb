﻿Public Class M_songs

    Dim songpath As String
    Dim ID As Integer
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
        Admin.Visible = True
    End Sub

    Private Sub btn_opensong_Click(sender As Object, e As EventArgs) Handles btn_opensong.Click
        ofd_song.ShowDialog()
        songpath = ofd_song.FileName()
        If Not (songpath = "") Then
            lbl_path.Text = "Ok"
        Else
            MsgBox("Seleccione una canción por favor")
        End If
    End Sub

    Private Sub btn_addsong_Click(sender As Object, e As EventArgs) Handles btn_addsong.Click
        If (txt_songname.Text = "" Or txt_genre.Text = "" Or songpath = "") Then
            MsgBox("Introduzca todos los campos por favor")
        Else
            ID = GetAID(lstbx_artists.SelectedItem.ToString)
            RegisterNS(txt_songname.Text, txt_genre.Text, songpath, ID)
        End If
    End Sub

    Private Sub btn_deletesong_Click(sender As Object, e As EventArgs) Handles btn_deletesong.Click
        DeleteS(lstbx_songs.SelectedItem.ToString)
    End Sub

    Private Sub M_songs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Update_AL2()
        Update_SL()
    End Sub
End Class