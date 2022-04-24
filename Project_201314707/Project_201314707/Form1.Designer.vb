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
        Me.btn_addpl = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_edituser = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.pb_user = New System.Windows.Forms.PictureBox()
        Me.pnl_bottom = New System.Windows.Forms.Panel()
        Me.wmp = New AxWMPLib.AxWindowsMediaPlayer()
        Me.btn_vup = New System.Windows.Forms.Button()
        Me.btn_vdown = New System.Windows.Forms.Button()
        Me.btn_mute = New System.Windows.Forms.Button()
        Me.btn_cplaylist = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_stop = New System.Windows.Forms.Button()
        Me.btn_pause = New System.Windows.Forms.Button()
        Me.btn_play = New System.Windows.Forms.Button()
        Me.btn_prev = New System.Windows.Forms.Button()
        Me.pnl_nplaylist = New System.Windows.Forms.Panel()
        Me.btn_createplaylist = New System.Windows.Forms.Button()
        Me.lblpath = New System.Windows.Forms.Label()
        Me.btn_openimage = New System.Windows.Forms.Button()
        Me.lbl_path = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txt_plname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.lstbx_playlist = New System.Windows.Forms.ListBox()
        Me.lstbx_songs = New System.Windows.Forms.ListBox()
        Me.ofd_pic = New System.Windows.Forms.OpenFileDialog()
        Me.pnl_start = New System.Windows.Forms.Panel()
        Me.btn_admin = New System.Windows.Forms.Button()
        Me.pb_status1 = New System.Windows.Forms.PictureBox()
        Me.btn_register = New System.Windows.Forms.Button()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.txt_usrname = New System.Windows.Forms.TextBox()
        Me.pb_start = New System.Windows.Forms.PictureBox()
        Me.lbl_servidor = New System.Windows.Forms.Label()
        Me.btn_server = New System.Windows.Forms.Button()
        Me.btn_ver = New System.Windows.Forms.Button()
        Me.pb_pl = New System.Windows.Forms.PictureBox()
        Me.pl_date = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstbx_sngs = New System.Windows.Forms.ListBox()
        Me.lstbx_pls = New System.Windows.Forms.ListBox()
        Me.pnl_top.SuspendLayout()
        CType(Me.pb_status2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_left.SuspendLayout()
        CType(Me.pb_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_bottom.SuspendLayout()
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_nplaylist.SuspendLayout()
        Me.pnl_start.SuspendLayout()
        CType(Me.pb_status1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_start, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_pl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_close
        '
        Me.btn_close.BackgroundImage = Global.Project_201314707.My.Resources.Resources.close
        Me.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btn_close.Location = New System.Drawing.Point(659, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(26, 26)
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
        Me.btn_minimize.Location = New System.Drawing.Point(633, 0)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(26, 26)
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
        Me.pnl_top.Location = New System.Drawing.Point(129, 0)
        Me.pnl_top.Name = "pnl_top"
        Me.pnl_top.Size = New System.Drawing.Size(685, 26)
        Me.pnl_top.TabIndex = 2
        '
        'pb_status2
        '
        Me.pb_status2.BackgroundImage = Global.Project_201314707.My.Resources.Resources.conected
        Me.pb_status2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pb_status2.Location = New System.Drawing.Point(601, 3)
        Me.pb_status2.Name = "pb_status2"
        Me.pb_status2.Size = New System.Drawing.Size(21, 22)
        Me.pb_status2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_status2.TabIndex = 12
        Me.pb_status2.TabStop = False
        Me.pb_status2.Visible = False
        '
        'lbl_server
        '
        Me.lbl_server.AutoSize = True
        Me.lbl_server.Font = New System.Drawing.Font("Acumin Pro", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_server.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_server.Location = New System.Drawing.Point(541, 4)
        Me.lbl_server.Name = "lbl_server"
        Me.lbl_server.Size = New System.Drawing.Size(59, 20)
        Me.lbl_server.TabIndex = 3
        Me.lbl_server.Text = "Server:"
        Me.lbl_server.Visible = False
        '
        'pnl_left
        '
        Me.pnl_left.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.pnl_left.Controls.Add(Me.btn_addpl)
        Me.pnl_left.Controls.Add(Me.btn_logout)
        Me.pnl_left.Controls.Add(Me.btn_edituser)
        Me.pnl_left.Controls.Add(Me.Label6)
        Me.pnl_left.Controls.Add(Me.Label5)
        Me.pnl_left.Controls.Add(Me.lbl_username)
        Me.pnl_left.Controls.Add(Me.pb_user)
        Me.pnl_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_left.Location = New System.Drawing.Point(0, 0)
        Me.pnl_left.Name = "pnl_left"
        Me.pnl_left.Size = New System.Drawing.Size(129, 477)
        Me.pnl_left.TabIndex = 3
        Me.pnl_left.Visible = False
        '
        'btn_addpl
        '
        Me.btn_addpl.BackgroundImage = Global.Project_201314707.My.Resources.Resources.addplaylist
        Me.btn_addpl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_addpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addpl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_addpl.Location = New System.Drawing.Point(47, 244)
        Me.btn_addpl.Name = "btn_addpl"
        Me.btn_addpl.Size = New System.Drawing.Size(34, 35)
        Me.btn_addpl.TabIndex = 9
        Me.btn_addpl.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.BackgroundImage = Global.Project_201314707.My.Resources.Resources.logout
        Me.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_logout.Location = New System.Drawing.Point(51, 440)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(26, 26)
        Me.btn_logout.TabIndex = 9
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'btn_edituser
        '
        Me.btn_edituser.BackgroundImage = Global.Project_201314707.My.Resources.Resources.edit
        Me.btn_edituser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_edituser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edituser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_edituser.Location = New System.Drawing.Point(96, 21)
        Me.btn_edituser.Name = "btn_edituser"
        Me.btn_edituser.Size = New System.Drawing.Size(21, 22)
        Me.btn_edituser.TabIndex = 8
        Me.btn_edituser.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(21, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "New Playlist"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(25, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 21)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Username:"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_username.Location = New System.Drawing.Point(33, 169)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(28, 21)
        Me.lbl_username.TabIndex = 6
        Me.lbl_username.Text = "---"
        '
        'pb_user
        '
        Me.pb_user.BackgroundImage = Global.Project_201314707.My.Resources.Resources.user
        Me.pb_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pb_user.Location = New System.Drawing.Point(21, 31)
        Me.pb_user.Name = "pb_user"
        Me.pb_user.Size = New System.Drawing.Size(90, 90)
        Me.pb_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_user.TabIndex = 4
        Me.pb_user.TabStop = False
        '
        'pnl_bottom
        '
        Me.pnl_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.pnl_bottom.Controls.Add(Me.wmp)
        Me.pnl_bottom.Controls.Add(Me.btn_vup)
        Me.pnl_bottom.Controls.Add(Me.btn_vdown)
        Me.pnl_bottom.Controls.Add(Me.btn_mute)
        Me.pnl_bottom.Controls.Add(Me.btn_cplaylist)
        Me.pnl_bottom.Controls.Add(Me.btn_next)
        Me.pnl_bottom.Controls.Add(Me.btn_stop)
        Me.pnl_bottom.Controls.Add(Me.btn_pause)
        Me.pnl_bottom.Controls.Add(Me.btn_play)
        Me.pnl_bottom.Controls.Add(Me.btn_prev)
        Me.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_bottom.Location = New System.Drawing.Point(129, 390)
        Me.pnl_bottom.Name = "pnl_bottom"
        Me.pnl_bottom.Size = New System.Drawing.Size(685, 87)
        Me.pnl_bottom.TabIndex = 4
        Me.pnl_bottom.Visible = False
        '
        'wmp
        '
        Me.wmp.Enabled = True
        Me.wmp.Location = New System.Drawing.Point(219, 30)
        Me.wmp.Name = "wmp"
        Me.wmp.OcxState = CType(resources.GetObject("wmp.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmp.Size = New System.Drawing.Size(237, 45)
        Me.wmp.TabIndex = 17
        Me.wmp.Visible = False
        '
        'btn_vup
        '
        Me.btn_vup.BackgroundImage = Global.Project_201314707.My.Resources.Resources.v_up
        Me.btn_vup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_vup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_vup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn_vup.Location = New System.Drawing.Point(634, 33)
        Me.btn_vup.Name = "btn_vup"
        Me.btn_vup.Size = New System.Drawing.Size(26, 26)
        Me.btn_vup.TabIndex = 16
        Me.btn_vup.UseVisualStyleBackColor = True
        '
        'btn_vdown
        '
        Me.btn_vdown.BackgroundImage = Global.Project_201314707.My.Resources.Resources.v_down
        Me.btn_vdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_vdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_vdown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn_vdown.Location = New System.Drawing.Point(595, 33)
        Me.btn_vdown.Name = "btn_vdown"
        Me.btn_vdown.Size = New System.Drawing.Size(26, 26)
        Me.btn_vdown.TabIndex = 15
        Me.btn_vdown.UseVisualStyleBackColor = True
        '
        'btn_mute
        '
        Me.btn_mute.BackgroundImage = Global.Project_201314707.My.Resources.Resources.mute
        Me.btn_mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_mute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mute.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn_mute.Location = New System.Drawing.Point(555, 33)
        Me.btn_mute.Name = "btn_mute"
        Me.btn_mute.Size = New System.Drawing.Size(26, 26)
        Me.btn_mute.TabIndex = 14
        Me.btn_mute.UseVisualStyleBackColor = True
        '
        'btn_cplaylist
        '
        Me.btn_cplaylist.BackgroundImage = Global.Project_201314707.My.Resources.Resources.current_playlist
        Me.btn_cplaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cplaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cplaylist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn_cplaylist.Location = New System.Drawing.Point(516, 33)
        Me.btn_cplaylist.Name = "btn_cplaylist"
        Me.btn_cplaylist.Size = New System.Drawing.Size(26, 26)
        Me.btn_cplaylist.TabIndex = 13
        Me.btn_cplaylist.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.BackgroundImage = Global.Project_201314707.My.Resources.Resources._next
        Me.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_next.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn_next.Location = New System.Drawing.Point(161, 33)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(26, 26)
        Me.btn_next.TabIndex = 12
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_stop
        '
        Me.btn_stop.BackgroundImage = Global.Project_201314707.My.Resources.Resources._stop
        Me.btn_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn_stop.Location = New System.Drawing.Point(124, 33)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(26, 26)
        Me.btn_stop.TabIndex = 11
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'btn_pause
        '
        Me.btn_pause.BackgroundImage = Global.Project_201314707.My.Resources.Resources.pause
        Me.btn_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pause.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn_pause.Location = New System.Drawing.Point(92, 33)
        Me.btn_pause.Name = "btn_pause"
        Me.btn_pause.Size = New System.Drawing.Size(26, 26)
        Me.btn_pause.TabIndex = 11
        Me.btn_pause.UseVisualStyleBackColor = True
        '
        'btn_play
        '
        Me.btn_play.BackgroundImage = Global.Project_201314707.My.Resources.Resources.play
        Me.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_play.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn_play.Location = New System.Drawing.Point(60, 33)
        Me.btn_play.Name = "btn_play"
        Me.btn_play.Size = New System.Drawing.Size(26, 26)
        Me.btn_play.TabIndex = 11
        Me.btn_play.UseVisualStyleBackColor = True
        '
        'btn_prev
        '
        Me.btn_prev.BackgroundImage = Global.Project_201314707.My.Resources.Resources.prev
        Me.btn_prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_prev.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn_prev.Location = New System.Drawing.Point(21, 33)
        Me.btn_prev.Name = "btn_prev"
        Me.btn_prev.Size = New System.Drawing.Size(26, 26)
        Me.btn_prev.TabIndex = 10
        Me.btn_prev.UseVisualStyleBackColor = True
        '
        'pnl_nplaylist
        '
        Me.pnl_nplaylist.Controls.Add(Me.btn_createplaylist)
        Me.pnl_nplaylist.Controls.Add(Me.lblpath)
        Me.pnl_nplaylist.Controls.Add(Me.btn_openimage)
        Me.pnl_nplaylist.Controls.Add(Me.lbl_path)
        Me.pnl_nplaylist.Controls.Add(Me.lbl_name)
        Me.pnl_nplaylist.Controls.Add(Me.txt_plname)
        Me.pnl_nplaylist.Controls.Add(Me.Label1)
        Me.pnl_nplaylist.Controls.Add(Me.btn_back)
        Me.pnl_nplaylist.Controls.Add(Me.btn_remove)
        Me.pnl_nplaylist.Controls.Add(Me.btn_add)
        Me.pnl_nplaylist.Controls.Add(Me.lstbx_playlist)
        Me.pnl_nplaylist.Controls.Add(Me.lstbx_songs)
        Me.pnl_nplaylist.Location = New System.Drawing.Point(161, 31)
        Me.pnl_nplaylist.Name = "pnl_nplaylist"
        Me.pnl_nplaylist.Size = New System.Drawing.Size(618, 345)
        Me.pnl_nplaylist.TabIndex = 6
        Me.pnl_nplaylist.Visible = False
        '
        'btn_createplaylist
        '
        Me.btn_createplaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_createplaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_createplaylist.Font = New System.Drawing.Font("Acumin Pro", 12.0!)
        Me.btn_createplaylist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_createplaylist.Location = New System.Drawing.Point(243, 299)
        Me.btn_createplaylist.Name = "btn_createplaylist"
        Me.btn_createplaylist.Size = New System.Drawing.Size(86, 30)
        Me.btn_createplaylist.TabIndex = 27
        Me.btn_createplaylist.Text = "Crear"
        Me.btn_createplaylist.UseVisualStyleBackColor = True
        '
        'lblpath
        '
        Me.lblpath.AutoSize = True
        Me.lblpath.Font = New System.Drawing.Font("Acumin Pro", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblpath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lblpath.Location = New System.Drawing.Point(535, 88)
        Me.lblpath.Name = "lblpath"
        Me.lblpath.Size = New System.Drawing.Size(21, 20)
        Me.lblpath.TabIndex = 26
        Me.lblpath.Text = "--"
        '
        'btn_openimage
        '
        Me.btn_openimage.BackgroundImage = Global.Project_201314707.My.Resources.Resources.openfile
        Me.btn_openimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_openimage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_openimage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btn_openimage.Location = New System.Drawing.Point(503, 86)
        Me.btn_openimage.Name = "btn_openimage"
        Me.btn_openimage.Size = New System.Drawing.Size(26, 26)
        Me.btn_openimage.TabIndex = 25
        Me.btn_openimage.UseVisualStyleBackColor = True
        '
        'lbl_path
        '
        Me.lbl_path.AutoSize = True
        Me.lbl_path.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_path.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_path.Location = New System.Drawing.Point(333, 88)
        Me.lbl_path.Name = "lbl_path"
        Me.lbl_path.Size = New System.Drawing.Size(162, 21)
        Me.lbl_path.TabIndex = 24
        Me.lbl_path.Text = "Seleccionar Imagen:"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Acumin Pro", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_name.Location = New System.Drawing.Point(33, 56)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(160, 20)
        Me.lbl_name.TabIndex = 23
        Me.lbl_name.Text = "Nombre de la playlist:"
        '
        'txt_plname
        '
        Me.txt_plname.Font = New System.Drawing.Font("Acumin Pro", 12.0!)
        Me.txt_plname.Location = New System.Drawing.Point(33, 86)
        Me.txt_plname.Name = "txt_plname"
        Me.txt_plname.Size = New System.Drawing.Size(271, 27)
        Me.txt_plname.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Acumin Pro", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(4, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Regresar"
        '
        'btn_back
        '
        Me.btn_back.BackgroundImage = Global.Project_201314707.My.Resources.Resources.back
        Me.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btn_back.Location = New System.Drawing.Point(16, 19)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(26, 26)
        Me.btn_back.TabIndex = 20
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_remove
        '
        Me.btn_remove.BackgroundImage = Global.Project_201314707.My.Resources.Resources.left
        Me.btn_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_remove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btn_remove.Location = New System.Drawing.Point(269, 230)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(34, 35)
        Me.btn_remove.TabIndex = 19
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.BackgroundImage = Global.Project_201314707.My.Resources.Resources.right
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btn_add.Location = New System.Drawing.Point(269, 166)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(34, 35)
        Me.btn_add.TabIndex = 19
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'lstbx_playlist
        '
        Me.lstbx_playlist.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lstbx_playlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstbx_playlist.Font = New System.Drawing.Font("Acumin Pro", 9.749999!)
        Me.lstbx_playlist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lstbx_playlist.FormattingEnabled = True
        Me.lstbx_playlist.ItemHeight = 17
        Me.lstbx_playlist.Location = New System.Drawing.Point(363, 157)
        Me.lstbx_playlist.Name = "lstbx_playlist"
        Me.lstbx_playlist.Size = New System.Drawing.Size(172, 121)
        Me.lstbx_playlist.TabIndex = 18
        '
        'lstbx_songs
        '
        Me.lstbx_songs.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lstbx_songs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstbx_songs.Font = New System.Drawing.Font("Acumin Pro", 9.749999!)
        Me.lstbx_songs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lstbx_songs.FormattingEnabled = True
        Me.lstbx_songs.ItemHeight = 17
        Me.lstbx_songs.Location = New System.Drawing.Point(33, 157)
        Me.lstbx_songs.Name = "lstbx_songs"
        Me.lstbx_songs.Size = New System.Drawing.Size(172, 121)
        Me.lstbx_songs.TabIndex = 18
        '
        'ofd_pic
        '
        Me.ofd_pic.FileName = "OpenFileDialog1"
        '
        'pnl_start
        '
        Me.pnl_start.Controls.Add(Me.btn_admin)
        Me.pnl_start.Controls.Add(Me.pb_status1)
        Me.pnl_start.Controls.Add(Me.btn_register)
        Me.pnl_start.Controls.Add(Me.btn_login)
        Me.pnl_start.Controls.Add(Me.lbl_user)
        Me.pnl_start.Controls.Add(Me.txt_usrname)
        Me.pnl_start.Controls.Add(Me.pb_start)
        Me.pnl_start.Controls.Add(Me.lbl_servidor)
        Me.pnl_start.Controls.Add(Me.btn_server)
        Me.pnl_start.Location = New System.Drawing.Point(130, 27)
        Me.pnl_start.Name = "pnl_start"
        Me.pnl_start.Size = New System.Drawing.Size(649, 360)
        Me.pnl_start.TabIndex = 29
        '
        'btn_admin
        '
        Me.btn_admin.BackgroundImage = Global.Project_201314707.My.Resources.Resources.admin_g
        Me.btn_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_admin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btn_admin.Location = New System.Drawing.Point(573, 9)
        Me.btn_admin.Name = "btn_admin"
        Me.btn_admin.Size = New System.Drawing.Size(26, 26)
        Me.btn_admin.TabIndex = 12
        Me.btn_admin.UseVisualStyleBackColor = True
        '
        'pb_status1
        '
        Me.pb_status1.BackgroundImage = Global.Project_201314707.My.Resources.Resources.unplugged
        Me.pb_status1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pb_status1.Location = New System.Drawing.Point(126, 15)
        Me.pb_status1.Name = "pb_status1"
        Me.pb_status1.Size = New System.Drawing.Size(21, 22)
        Me.pb_status1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_status1.TabIndex = 11
        Me.pb_status1.TabStop = False
        '
        'btn_register
        '
        Me.btn_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_register.Enabled = False
        Me.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_register.Font = New System.Drawing.Font("Acumin Pro", 12.0!)
        Me.btn_register.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_register.Location = New System.Drawing.Point(261, 310)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(86, 30)
        Me.btn_register.TabIndex = 10
        Me.btn_register.Text = "Registrarse"
        Me.btn_register.UseVisualStyleBackColor = True
        '
        'btn_login
        '
        Me.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_login.Enabled = False
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Acumin Pro", 12.0!)
        Me.btn_login.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_login.Location = New System.Drawing.Point(261, 249)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(86, 30)
        Me.btn_login.TabIndex = 6
        Me.btn_login.Text = "Ingresar"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_user.Location = New System.Drawing.Point(137, 192)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(72, 21)
        Me.lbl_user.TabIndex = 5
        Me.lbl_user.Text = "Usuario:"
        '
        'txt_usrname
        '
        Me.txt_usrname.Font = New System.Drawing.Font("Acumin Pro", 12.0!)
        Me.txt_usrname.Location = New System.Drawing.Point(224, 189)
        Me.txt_usrname.Name = "txt_usrname"
        Me.txt_usrname.Size = New System.Drawing.Size(160, 27)
        Me.txt_usrname.TabIndex = 4
        '
        'pb_start
        '
        Me.pb_start.BackgroundImage = Global.Project_201314707.My.Resources.Resources.songs
        Me.pb_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pb_start.Location = New System.Drawing.Point(259, 60)
        Me.pb_start.Name = "pb_start"
        Me.pb_start.Size = New System.Drawing.Size(90, 90)
        Me.pb_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_start.TabIndex = 3
        Me.pb_start.TabStop = False
        '
        'lbl_servidor
        '
        Me.lbl_servidor.AutoSize = True
        Me.lbl_servidor.Font = New System.Drawing.Font("Acumin Pro", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_servidor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_servidor.Location = New System.Drawing.Point(50, 15)
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
        Me.btn_server.Size = New System.Drawing.Size(43, 43)
        Me.btn_server.TabIndex = 1
        Me.btn_server.UseVisualStyleBackColor = True
        '
        'btn_ver
        '
        Me.btn_ver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ver.Font = New System.Drawing.Font("Acumin Pro", 12.0!)
        Me.btn_ver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_ver.Location = New System.Drawing.Point(419, 304)
        Me.btn_ver.Name = "btn_ver"
        Me.btn_ver.Size = New System.Drawing.Size(86, 30)
        Me.btn_ver.TabIndex = 70
        Me.btn_ver.Text = "Ver"
        Me.btn_ver.UseVisualStyleBackColor = True
        '
        'pb_pl
        '
        Me.pb_pl.BackgroundImage = Global.Project_201314707.My.Resources.Resources.user
        Me.pb_pl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pb_pl.Location = New System.Drawing.Point(419, 206)
        Me.pb_pl.Name = "pb_pl"
        Me.pb_pl.Size = New System.Drawing.Size(86, 87)
        Me.pb_pl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_pl.TabIndex = 69
        Me.pb_pl.TabStop = False
        '
        'pl_date
        '
        Me.pl_date.AutoSize = True
        Me.pl_date.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Bold)
        Me.pl_date.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.pl_date.Location = New System.Drawing.Point(260, 366)
        Me.pl_date.Name = "pl_date"
        Me.pl_date.Size = New System.Drawing.Size(28, 21)
        Me.pl_date.TabIndex = 65
        Me.pl_date.Text = "---"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Acumin Pro", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(626, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 25)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Songs"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(132, 366)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 21)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Date created : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Acumin Pro", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(214, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 25)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Playlists"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Amsterdam Four_ttf", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(282, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(365, 135)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "My Playlists"
        '
        'lstbx_sngs
        '
        Me.lstbx_sngs.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lstbx_sngs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstbx_sngs.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lstbx_sngs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lstbx_sngs.FormattingEnabled = True
        Me.lstbx_sngs.ItemHeight = 21
        Me.lstbx_sngs.Location = New System.Drawing.Point(556, 206)
        Me.lstbx_sngs.Name = "lstbx_sngs"
        Me.lstbx_sngs.Size = New System.Drawing.Size(206, 128)
        Me.lstbx_sngs.TabIndex = 62
        '
        'lstbx_pls
        '
        Me.lstbx_pls.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lstbx_pls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstbx_pls.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lstbx_pls.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lstbx_pls.FormattingEnabled = True
        Me.lstbx_pls.ItemHeight = 21
        Me.lstbx_pls.Location = New System.Drawing.Point(151, 206)
        Me.lstbx_pls.Name = "lstbx_pls"
        Me.lstbx_pls.Size = New System.Drawing.Size(212, 128)
        Me.lstbx_pls.TabIndex = 63
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(814, 477)
        Me.Controls.Add(Me.pnl_start)
        Me.Controls.Add(Me.pnl_nplaylist)
        Me.Controls.Add(Me.btn_ver)
        Me.Controls.Add(Me.pb_pl)
        Me.Controls.Add(Me.pl_date)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstbx_sngs)
        Me.Controls.Add(Me.lstbx_pls)
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
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_nplaylist.ResumeLayout(False)
        Me.pnl_nplaylist.PerformLayout()
        Me.pnl_start.ResumeLayout(False)
        Me.pnl_start.PerformLayout()
        CType(Me.pb_status1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_start, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_pl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_close As Button
    Friend WithEvents btn_minimize As Button
    Friend WithEvents pnl_top As Panel
    Friend WithEvents pnl_left As Panel
    Friend WithEvents pnl_bottom As Panel
    Friend WithEvents lbl_username As Label
    Friend WithEvents pb_user As PictureBox
    Friend WithEvents lbl_server As Label
    Friend WithEvents btn_logout As Button
    Friend WithEvents btn_edituser As Button
    Friend WithEvents pb_status2 As PictureBox
    Friend WithEvents btn_play As Button
    Friend WithEvents btn_prev As Button
    Friend WithEvents btn_vup As Button
    Friend WithEvents btn_vdown As Button
    Friend WithEvents btn_mute As Button
    Friend WithEvents btn_cplaylist As Button
    Friend WithEvents btn_next As Button
    Friend WithEvents pnl_nplaylist As Panel
    Friend WithEvents lstbx_playlist As ListBox
    Friend WithEvents lstbx_songs As ListBox
    Friend WithEvents btn_remove As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents lbl_name As Label
    Friend WithEvents txt_plname As TextBox
    Friend WithEvents lblpath As Label
    Friend WithEvents btn_openimage As Button
    Friend WithEvents lbl_path As Label
    Friend WithEvents btn_createplaylist As Button
    Friend WithEvents ofd_pic As OpenFileDialog
    Friend WithEvents btn_addpl As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents wmp As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btn_stop As Button
    Friend WithEvents btn_pause As Button
    Friend WithEvents pnl_start As Panel
    Friend WithEvents btn_admin As Button
    Friend WithEvents pb_status1 As PictureBox
    Friend WithEvents btn_register As Button
    Friend WithEvents btn_login As Button
    Friend WithEvents lbl_user As Label
    Friend WithEvents txt_usrname As TextBox
    Friend WithEvents pb_start As PictureBox
    Friend WithEvents lbl_servidor As Label
    Friend WithEvents btn_server As Button
    Friend WithEvents btn_ver As Button
    Friend WithEvents pb_pl As PictureBox
    Friend WithEvents pl_date As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstbx_sngs As ListBox
    Friend WithEvents lstbx_pls As ListBox
End Class
