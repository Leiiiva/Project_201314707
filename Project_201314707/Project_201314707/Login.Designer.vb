﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.pnl_login = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.pb_user = New System.Windows.Forms.PictureBox()
        Me.pnl_login.SuspendLayout()
        CType(Me.pb_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_login
        '
        Me.pnl_login.Controls.Add(Me.Label1)
        Me.pnl_login.Controls.Add(Me.btn_back)
        Me.pnl_login.Controls.Add(Me.lbl_username)
        Me.pnl_login.Controls.Add(Me.lbl_password)
        Me.pnl_login.Controls.Add(Me.btn_login)
        Me.pnl_login.Controls.Add(Me.txt_password)
        Me.pnl_login.Controls.Add(Me.pb_user)
        Me.pnl_login.Location = New System.Drawing.Point(9, 10)
        Me.pnl_login.Name = "pnl_login"
        Me.pnl_login.Size = New System.Drawing.Size(309, 396)
        Me.pnl_login.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Acumin Pro", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(2, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Regresar"
        '
        'btn_back
        '
        Me.btn_back.BackgroundImage = Global.Project_201314707.My.Resources.Resources.back
        Me.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btn_back.Location = New System.Drawing.Point(14, 20)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(26, 26)
        Me.btn_back.TabIndex = 16
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Acumin Pro", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.lbl_username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_username.Location = New System.Drawing.Point(129, 170)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(83, 17)
        Me.lbl_username.TabIndex = 6
        Me.lbl_username.Text = "Contraseña:"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("Acumin Pro", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.lbl_password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_password.Location = New System.Drawing.Point(73, 207)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(83, 17)
        Me.lbl_password.TabIndex = 6
        Me.lbl_password.Text = "Contraseña:"
        '
        'btn_login
        '
        Me.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Acumin Pro", 12.0!)
        Me.btn_login.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_login.Location = New System.Drawing.Point(117, 271)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(86, 30)
        Me.btn_login.TabIndex = 12
        Me.btn_login.Text = "Ingresar"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Acumin Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(73, 224)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(172, 23)
        Me.txt_password.TabIndex = 5
        Me.txt_password.UseSystemPasswordChar = True
        '
        'pb_user
        '
        Me.pb_user.Image = Global.Project_201314707.My.Resources.Resources.password
        Me.pb_user.Location = New System.Drawing.Point(117, 76)
        Me.pb_user.Name = "pb_user"
        Me.pb_user.Size = New System.Drawing.Size(86, 87)
        Me.pb_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_user.TabIndex = 3
        Me.pb_user.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(330, 416)
        Me.Controls.Add(Me.pnl_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.pnl_login.ResumeLayout(False)
        Me.pnl_login.PerformLayout()
        CType(Me.pb_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_login As Panel
    Friend WithEvents txt_password As TextBox
    Friend WithEvents lbl_password As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents lbl_username As Label
    Friend WithEvents pb_user As PictureBox
End Class
