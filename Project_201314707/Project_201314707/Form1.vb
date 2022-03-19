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
            myConn.Close()
        Catch ex As Exception
            MsgBox("Error al conectar")
        End Try
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Me.Visible = False
        Login.Visible = True
    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        Me.Visible = False
        Register.Visible = True
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        pnl_left.Visible = False
        pnl_bottom.Visible = False
        lbl_server.Visible = False
        pb_status2.Visible = False
        pnl_start.Visible = True
    End Sub

    Private Sub btn_admin_Click(sender As Object, e As EventArgs) Handles btn_admin.Click
        Me.Visible = False
        Admin.Visible = True
    End Sub



End Class
