Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.Configuration
Public Class Form1
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



End Class
