Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.Configuration
Imports WMPLib
Public Class Form1
    Dim picpath As String
    Dim vol As Integer
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        End
    End Sub

    Private Sub btn_server_Click(sender As Object, e As EventArgs) Handles btn_server.Click
        Try
            myConn.Open()
            pb_status1.Image = Image.FromFile("D:\Documents\GitHub\Project_201314707\Project_201314707\resources\interfaz\conected.png")
            btn_login.Enabled = True
            btn_register.Enabled = True
            myConn.Close()
            MsgBox("Connection successful!", vbInformation, "Server Ok !")
        Catch ex As Exception
            MsgBox("Error al conectar")
        End Try
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        PM.ValidUsername(txt_usrname.Text)
    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        Me.Visible = False
        Register.Visible = True
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        PM.Logout()
    End Sub

    Private Sub btn_admin_Click(sender As Object, e As EventArgs) Handles btn_admin.Click
        Me.Visible = False
        Admin.Visible = True
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        pnl_nplaylist.Visible = False
        Update_PLS()
    End Sub

    Private Sub btn_openimage_Click(sender As Object, e As EventArgs) Handles btn_openimage.Click
        ofd_pic.ShowDialog()
        picpath = ofd_pic.FileName()
        If Not (picpath = "") Then
            lblpath.Text = "Ok !"
        Else
            MsgBox("Seleccione una imagen por favor")
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            Dim selectedsong As String = lstbx_songs.SelectedItem().ToString()
            lstbx_playlist.Items.Add(selectedsong)
        Catch ex As Exception
            MsgBox("Error entering data", vbExclamation, "Error")
        End Try
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        Try
            lstbx_playlist.SelectedItem.Remove()
        Catch ex As Exception
            MsgBox("Error entering data", vbExclamation, "Error")
        End Try
    End Sub

    Private Sub btn_createplaylist_Click(sender As Object, e As EventArgs) Handles btn_createplaylist.Click
        If txt_plname.Text = "" Or picpath = "" Then
            MsgBox("Ingrese todos lo campos")
        Else
            PM.CreatePlaylist(txt_plname.Text, picpath)
        End If

        Dim pID As Integer = GetPID(txt_plname.Text)
        Try
            For Each currentsong As String In lstbx_playlist.Items
                Dim sID As Integer = GetSID(currentsong)
                CreatePlaylistDetail(pID, sID)
            Next
        Catch ex As SqlException
            MsgBox(ex.Message.ToString(), vbExclamation, "Error")
        End Try
    End Sub

    Private Sub btn_addpl_Click(sender As Object, e As EventArgs) Handles btn_addpl.Click
        pnl_nplaylist.Visible = True
        Update_SL2()
    End Sub

    Private Sub btn_edituser_Click(sender As Object, e As EventArgs) Handles btn_edituser.Click
        Me.Visible = False
        E_User.Visible = True
    End Sub

    Private Sub btn_ver_Click(sender As Object, e As EventArgs) Handles btn_ver.Click
        Update_SL3(lstbx_pls.SelectedItem.ToString)
    End Sub

    Private Sub btn_play_Click(sender As Object, e As EventArgs) Handles btn_play.Click
        wmp.Ctlcontrols.play()
    End Sub

    Private Sub btn_pause_Click(sender As Object, e As EventArgs) Handles btn_pause.Click
        wmp.Ctlcontrols.pause()
    End Sub
    Private Sub btn_stop_Click(sender As Object, e As EventArgs) Handles btn_stop.Click
        wmp.Ctlcontrols.stop()
    End Sub

    Private Sub btn_cplaylist_Click(sender As Object, e As EventArgs) Handles btn_cplaylist.Click
        Dim playlist As WMPLib.IWMPPlaylist = wmp.playlistCollection.newPlaylist("myplaylist")
        Dim media As WMPLib.IWMPMedia
        For Each song In lstbx_sngs.Items
            media = wmp.newMedia(GetSPath(song))
            playlist.appendItem(media)
        Next
        wmp.currentPlaylist = playlist
        vol = 50
        wmp.settings.volume = vol
        wmp.Ctlcontrols.play()
    End Sub

    Private Sub btn_mute_Click(sender As Object, e As EventArgs) Handles btn_mute.Click
        If (wmp.settings.mute = True) Then
            wmp.settings.mute = False
        Else
            wmp.settings.mute = True
        End If
    End Sub

    Private Sub btn_prev_Click(sender As Object, e As EventArgs) Handles btn_prev.Click
        wmp.Ctlcontrols.previous()
        wmp.Ctlcontrols.play()
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        wmp.Ctlcontrols.next()
        wmp.Ctlcontrols.play()
    End Sub

    Private Sub btn_vdown_Click(sender As Object, e As EventArgs) Handles btn_vdown.Click
        If Not (wmp.settings.volume = 0) Then
            wmp.settings.volume = wmp.settings.volume - 10
        End If
    End Sub

    Private Sub btn_vup_Click(sender As Object, e As EventArgs) Handles btn_vup.Click
        If Not (wmp.settings.volume = 100) Then
            wmp.settings.volume = wmp.settings.volume + 10
        End If
    End Sub

End Class
