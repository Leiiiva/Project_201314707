<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_minimize = New System.Windows.Forms.Button()
        Me.pnl_top = New System.Windows.Forms.Panel()
        Me.pb_status2 = New System.Windows.Forms.PictureBox()
        Me.lbl_server = New System.Windows.Forms.Label()
        Me.pnl_left = New System.Windows.Forms.Panel()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_edituser = New System.Windows.Forms.Button()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.pb_user = New System.Windows.Forms.PictureBox()
        Me.pnl_bottom = New System.Windows.Forms.Panel()
        Me.btn_vup = New System.Windows.Forms.Button()
        Me.btn_vdown = New System.Windows.Forms.Button()
        Me.btn_mute = New System.Windows.Forms.Button()
        Me.btn_cplaylist = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_play = New System.Windows.Forms.Button()
        Me.btn_prev = New System.Windows.Forms.Button()
        Me.pnl_start = New System.Windows.Forms.Panel()
        Me.btn_admin = New System.Windows.Forms.Button()
        Me.pb_status1 = New System.Windows.Forms.PictureBox()
        Me.btn_register = New System.Windows.Forms.Button()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pb_start = New System.Windows.Forms.PictureBox()
        Me.lbl_servidor = New System.Windows.Forms.Label()
        Me.btn_server = New System.Windows.Forms.Button()
        Me.pnl_top.SuspendLayout()
        CType(Me.pb_status2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_left.SuspendLayout()
        CType(Me.pb_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_bottom.SuspendLayout()
        Me.pnl_start.SuspendLayout()
        CType(Me.pb_status1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_start, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_close
        '
        Me.btn_close.BackgroundImage = Global.Project_201314707.My.Resources.Resources.close
        Me.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btn_close.Location = New System.Drawing.Point(770, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(30, 30)
        Me.btn_close.TabIndex = 0
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_minimize
        '
        Me.btn_minimize.BackgroundImage = Global.Project_201314707.My.Resources.Resources.minimize
        Me.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_minimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btn_minimize.Location = New System.Drawing.Point(740, 0)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(30, 30)
        Me.btn_minimize.TabIndex = 1
        Me.btn_minimize.UseVisualStyleBackColor = True
        '
        'pnl_top
        '
        Me.pnl_top.Controls.Add(Me.pb_status2)
        Me.pnl_top.Controls.Add(Me.lbl_server)
        Me.pnl_top.Controls.Add(Me.btn_minimize)
        Me.pnl_top.Controls.Add(Me.btn_close)
        Me.pnl_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_top.Location = New System.Drawing.Point(150, 0)
        Me.pnl_top.Name = "pnl_top"
        Me.pnl_top.Size = New System.Drawing.Size(800, 30)
        Me.pnl_top.TabIndex = 2
        '
        'pb_status2
        '
        Me.pb_status2.BackgroundImage = Global.Project_201314707.My.Resources.Resources.conected
        Me.pb_status2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pb_status2.Location = New System.Drawing.Point(710, 3)
        Me.pb_status2.Name = "pb_status2"
        Me.pb_status2.Size = New System.Drawing.Size(25, 25)
        Me.pb_status2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_status2.TabIndex = 12
        Me.pb_status2.TabStop = False
        Me.pb_status2.Visible = False
        '
        'lbl_server
        '
        Me.lbl_server.AutoSize = True
        Me.lbl_server.Font = New System.Drawing.Font("Acumin Pro", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_server.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_server.Location = New System.Drawing.Point(631, 5)
        Me.lbl_server.Name = "lbl_server"
        Me.lbl_server.Size = New System.Drawing.Size(73, 20)
        Me.lbl_server.TabIndex = 3
        Me.lbl_server.Text = "Servidor:"
        Me.lbl_server.Visible = False
        '
        'pnl_left
        '
        Me.pnl_left.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.pnl_left.Controls.Add(Me.btn_logout)
        Me.pnl_left.Controls.Add(Me.btn_edituser)
        Me.pnl_left.Controls.Add(Me.lbl_username)
        Me.pnl_left.Controls.Add(Me.pb_user)
        Me.pnl_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_left.Location = New System.Drawing.Point(0, 0)
        Me.pnl_left.Name = "pnl_left"
        Me.pnl_left.Size = New System.Drawing.Size(150, 550)
        Me.pnl_left.TabIndex = 3
        Me.pnl_left.Visible = False
        '
        'btn_logout
        '
        Me.btn_logout.BackgroundImage = Global.Project_201314707.My.Resources.Resources.logout
        Me.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_logout.Location = New System.Drawing.Point(60, 508)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(30, 30)
        Me.btn_logout.TabIndex = 9
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'btn_edituser
        '
        Me.btn_edituser.BackgroundImage = Global.Project_201314707.My.Resources.Resources.edit
        Me.btn_edituser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_edituser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edituser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_edituser.Location = New System.Drawing.Point(112, 24)
        Me.btn_edituser.Name = "btn_edituser"
        Me.btn_edituser.Size = New System.Drawing.Size(25, 25)
        Me.btn_edituser.TabIndex = 8
        Me.btn_edituser.UseVisualStyleBackColor = True
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_username.Location = New System.Drawing.Point(39, 157)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(72, 21)
        Me.lbl_username.TabIndex = 6
        Me.lbl_username.Text = "Usuario:"
        '
        'pb_user
        '
        Me.pb_user.BackgroundImage = Global.Project_201314707.My.Resources.Resources.user
        Me.pb_user.Location = New System.Drawing.Point(25, 36)
        Me.pb_user.Name = "pb_user"
        Me.pb_user.Size = New System.Drawing.Size(100, 100)
        Me.pb_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_user.TabIndex = 4
        Me.pb_user.TabStop = False
        '
        'pnl_bottom
        '
        Me.pnl_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.pnl_bottom.Controls.Add(Me.btn_vup)
        Me.pnl_bottom.Controls.Add(Me.btn_vdown)
        Me.pnl_bottom.Controls.Add(Me.btn_mute)
        Me.pnl_bottom.Controls.Add(Me.btn_cplaylist)
        Me.pnl_bottom.Controls.Add(Me.btn_next)
        Me.pnl_bottom.Controls.Add(Me.btn_play)
        Me.pnl_bottom.Controls.Add(Me.btn_prev)
        Me.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_bottom.Location = New System.Drawing.Point(150, 450)
        Me.pnl_bottom.Name = "pnl_bottom"
        Me.pnl_bottom.Size = New System.Drawing.Size(800, 100)
        Me.pnl_bottom.TabIndex = 4
        Me.pnl_bottom.Visible = False
        '
        'btn_vup
        '
        Me.btn_vup.BackgroundImage = Global.Project_201314707.My.Resources.Resources.v_up
        Me.btn_vup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_vup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_vup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn_vup.Location = New System.Drawing.Point(740, 38)
        Me.btn_vup.Name = "btn_vup"
        Me.btn_vup.Size = New System.Drawing.Size(30, 30)
        Me.btn_vup.TabIndex = 16
        Me.btn_vup.UseVisualStyleBackColor = True
        '
        'btn_vdown
        '
        Me.btn_vdown.BackgroundImage = Global.Project_201314707.My.Resources.Resources.v_down
        Me.btn_vdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_vdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_vdown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn_vdown.Location = New System.Drawing.Point(694, 38)
        Me.btn_vdown.Name = "btn_vdown"
        Me.btn_vdown.Size = New System.Drawing.Size(30, 30)
        Me.btn_vdown.TabIndex = 15
        Me.btn_vdown.UseVisualStyleBackColor = True
        '
        'btn_mute
        '
        Me.btn_mute.BackgroundImage = Global.Project_201314707.My.Resources.Resources.mute
        Me.btn_mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_mute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mute.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn_mute.Location = New System.Drawing.Point(648, 38)
        Me.btn_mute.Name = "btn_mute"
        Me.btn_mute.Size = New System.Drawing.Size(30, 30)
        Me.btn_mute.TabIndex = 14
        Me.btn_mute.UseVisualStyleBackColor = True
        '
        'btn_cplaylist
        '
        Me.btn_cplaylist.BackgroundImage = Global.Project_201314707.My.Resources.Resources.current_playlist
        Me.btn_cplaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cplaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cplaylist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn_cplaylist.Location = New System.Drawing.Point(602, 38)
        Me.btn_cplaylist.Name = "btn_cplaylist"
        Me.btn_cplaylist.Size = New System.Drawing.Size(30, 30)
        Me.btn_cplaylist.TabIndex = 13
        Me.btn_cplaylist.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.BackgroundImage = Global.Project_201314707.My.Resources.Resources._next
        Me.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_next.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn_next.Location = New System.Drawing.Point(116, 38)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(30, 30)
        Me.btn_next.TabIndex = 12
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_play
        '
        Me.btn_play.BackgroundImage = Global.Project_201314707.My.Resources.Resources.play
        Me.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_play.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn_play.Location = New System.Drawing.Point(70, 38)
        Me.btn_play.Name = "btn_play"
        Me.btn_play.Size = New System.Drawing.Size(30, 30)
        Me.btn_play.TabIndex = 11
        Me.btn_play.UseVisualStyleBackColor = True
        '
        'btn_prev
        '
        Me.btn_prev.BackgroundImage = Global.Project_201314707.My.Resources.Resources.prev
        Me.btn_prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_prev.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn_prev.Location = New System.Drawing.Point(24, 38)
        Me.btn_prev.Name = "btn_prev"
        Me.btn_prev.Size = New System.Drawing.Size(30, 30)
        Me.btn_prev.TabIndex = 10
        Me.btn_prev.UseVisualStyleBackColor = True
        '
        'pnl_start
        '
        Me.pnl_start.Controls.Add(Me.btn_admin)
        Me.pnl_start.Controls.Add(Me.pb_status1)
        Me.pnl_start.Controls.Add(Me.btn_register)
        Me.pnl_start.Controls.Add(Me.btn_login)
        Me.pnl_start.Controls.Add(Me.lbl_user)
        Me.pnl_start.Controls.Add(Me.TextBox1)
        Me.pnl_start.Controls.Add(Me.pb_start)
        Me.pnl_start.Controls.Add(Me.lbl_servidor)
        Me.pnl_start.Controls.Add(Me.btn_server)
        Me.pnl_start.Location = New System.Drawing.Point(156, 36)
        Me.pnl_start.Name = "pnl_start"
        Me.pnl_start.Size = New System.Drawing.Size(670, 410)
        Me.pnl_start.TabIndex = 5
        '
        'btn_admin
        '
        Me.btn_admin.BackgroundImage = Global.Project_201314707.My.Resources.Resources.admin_g
        Me.btn_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_admin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btn_admin.Location = New System.Drawing.Point(637, 3)
        Me.btn_admin.Name = "btn_admin"
        Me.btn_admin.Size = New System.Drawing.Size(30, 30)
        Me.btn_admin.TabIndex = 12
        Me.btn_admin.UseVisualStyleBackColor = True
        '
        'pb_status1
        '
        Me.pb_status1.BackgroundImage = Global.Project_201314707.My.Resources.Resources.unplugged
        Me.pb_status1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pb_status1.Location = New System.Drawing.Point(137, 15)
        Me.pb_status1.Name = "pb_status1"
        Me.pb_status1.Size = New System.Drawing.Size(25, 25)
        Me.pb_status1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_status1.TabIndex = 11
        Me.pb_status1.TabStop = False
        '
        'btn_register
        '
        Me.btn_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_register.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_register.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_register.Location = New System.Drawing.Point(295, 357)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(100, 35)
        Me.btn_register.TabIndex = 10
        Me.btn_register.Text = "Registrarse"
        Me.btn_register.UseVisualStyleBackColor = True
        '
        'btn_login
        '
        Me.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_login.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_login.Location = New System.Drawing.Point(295, 301)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(100, 35)
        Me.btn_login.TabIndex = 6
        Me.btn_login.Text = "Ingresar"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_user.Location = New System.Drawing.Point(183, 241)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(72, 21)
        Me.lbl_user.TabIndex = 5
        Me.lbl_user.Text = "Usuario:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(270, 238)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(150, 27)
        Me.TextBox1.TabIndex = 4
        '
        'pb_start
        '
        Me.pb_start.BackgroundImage = Global.Project_201314707.My.Resources.Resources.user
        Me.pb_start.Location = New System.Drawing.Point(295, 102)
        Me.pb_start.Name = "pb_start"
        Me.pb_start.Size = New System.Drawing.Size(100, 100)
        Me.pb_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_start.TabIndex = 3
        Me.pb_start.TabStop = False
        '
        'lbl_servidor
        '
        Me.lbl_servidor.AutoSize = True
        Me.lbl_servidor.Font = New System.Drawing.Font("Acumin Pro", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_servidor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_servidor.Location = New System.Drawing.Point(58, 17)
        Me.lbl_servidor.Name = "lbl_servidor"
        Me.lbl_servidor.Size = New System.Drawing.Size(73, 20)
        Me.lbl_servidor.TabIndex = 2
        Me.lbl_servidor.Text = "Servidor:"
        '
        'btn_server
        '
        Me.btn_server.BackgroundImage = Global.Project_201314707.My.Resources.Resources.server_g
        Me.btn_server.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_server.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_server.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btn_server.Location = New System.Drawing.Point(2, 2)
        Me.btn_server.Name = "btn_server"
        Me.btn_server.Size = New System.Drawing.Size(50, 50)
        Me.btn_server.TabIndex = 1
        Me.btn_server.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(950, 550)
        Me.Controls.Add(Me.pnl_start)
        Me.Controls.Add(Me.pnl_bottom)
        Me.Controls.Add(Me.pnl_top)
        Me.Controls.Add(Me.pnl_left)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnl_top.ResumeLayout(False)
        Me.pnl_top.PerformLayout()
        CType(Me.pb_status2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_left.ResumeLayout(False)
        Me.pnl_left.PerformLayout()
        CType(Me.pb_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_bottom.ResumeLayout(False)
        Me.pnl_start.ResumeLayout(False)
        Me.pnl_start.PerformLayout()
        CType(Me.pb_status1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_start, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_close As Button
    Friend WithEvents btn_minimize As Button
    Friend WithEvents pnl_top As Panel
    Friend WithEvents pnl_left As Panel
    Friend WithEvents pnl_bottom As Panel
    Friend WithEvents pnl_start As Panel
    Friend WithEvents lbl_servidor As Label
    Friend WithEvents btn_server As Button
    Friend WithEvents lbl_user As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents pb_start As PictureBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_register As Button
    Friend WithEvents lbl_username As Label
    Friend WithEvents pb_user As PictureBox
    Friend WithEvents lbl_server As Label
    Friend WithEvents btn_logout As Button
    Friend WithEvents btn_edituser As Button
    Friend WithEvents pb_status2 As PictureBox
    Friend WithEvents btn_play As Button
    Friend WithEvents btn_prev As Button
    Friend WithEvents pb_status1 As PictureBox
    Friend WithEvents btn_vup As Button
    Friend WithEvents btn_vdown As Button
    Friend WithEvents btn_mute As Button
    Friend WithEvents btn_cplaylist As Button
    Friend WithEvents btn_next As Button
    Friend WithEvents btn_admin As Button
End Class
