<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_songs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_songs))
        Me.pnl_login = New System.Windows.Forms.Panel()
        Me.btn_opensong = New System.Windows.Forms.Button()
        Me.lbl_artista = New System.Windows.Forms.Label()
        Me.lstbx_songs = New System.Windows.Forms.ListBox()
        Me.lstbx_artists = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_deletesong = New System.Windows.Forms.Button()
        Me.btn_addsong = New System.Windows.Forms.Button()
        Me.lbl_path = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txt_genre = New System.Windows.Forms.TextBox()
        Me.txt_songname = New System.Windows.Forms.TextBox()
        Me.pb_song = New System.Windows.Forms.PictureBox()
        Me.ofd_song = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnl_login.SuspendLayout()
        CType(Me.pb_song, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_login
        '
        Me.pnl_login.Controls.Add(Me.btn_opensong)
        Me.pnl_login.Controls.Add(Me.lbl_artista)
        Me.pnl_login.Controls.Add(Me.lstbx_songs)
        Me.pnl_login.Controls.Add(Me.lstbx_artists)
        Me.pnl_login.Controls.Add(Me.Label1)
        Me.pnl_login.Controls.Add(Me.btn_back)
        Me.pnl_login.Controls.Add(Me.btn_deletesong)
        Me.pnl_login.Controls.Add(Me.btn_addsong)
        Me.pnl_login.Controls.Add(Me.Label2)
        Me.pnl_login.Controls.Add(Me.lbl_path)
        Me.pnl_login.Controls.Add(Me.Label3)
        Me.pnl_login.Controls.Add(Me.lbl_name)
        Me.pnl_login.Controls.Add(Me.txt_genre)
        Me.pnl_login.Controls.Add(Me.txt_songname)
        Me.pnl_login.Controls.Add(Me.pb_song)
        Me.pnl_login.Location = New System.Drawing.Point(12, 11)
        Me.pnl_login.Name = "pnl_login"
        Me.pnl_login.Size = New System.Drawing.Size(361, 627)
        Me.pnl_login.TabIndex = 6
        '
        'btn_opensong
        '
        Me.btn_opensong.BackgroundImage = Global.Project_201314707.My.Resources.Resources.openfile
        Me.btn_opensong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_opensong.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_opensong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btn_opensong.Location = New System.Drawing.Point(259, 257)
        Me.btn_opensong.Name = "btn_opensong"
        Me.btn_opensong.Size = New System.Drawing.Size(30, 30)
        Me.btn_opensong.TabIndex = 19
        Me.btn_opensong.UseVisualStyleBackColor = True
        '
        'lbl_artista
        '
        Me.lbl_artista.AutoSize = True
        Me.lbl_artista.Font = New System.Drawing.Font("Acumin Pro", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_artista.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_artista.Location = New System.Drawing.Point(113, 313)
        Me.lbl_artista.Name = "lbl_artista"
        Me.lbl_artista.Size = New System.Drawing.Size(139, 20)
        Me.lbl_artista.TabIndex = 18
        Me.lbl_artista.Text = "Seleccione Artista:"
        '
        'lstbx_songs
        '
        Me.lstbx_songs.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lstbx_songs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstbx_songs.Font = New System.Drawing.Font("Acumin Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstbx_songs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lstbx_songs.FormattingEnabled = True
        Me.lstbx_songs.ItemHeight = 17
        Me.lstbx_songs.Location = New System.Drawing.Point(80, 486)
        Me.lstbx_songs.Name = "lstbx_songs"
        Me.lstbx_songs.Size = New System.Drawing.Size(200, 70)
        Me.lstbx_songs.TabIndex = 17
        '
        'lstbx_artists
        '
        Me.lstbx_artists.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lstbx_artists.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstbx_artists.Font = New System.Drawing.Font("Acumin Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstbx_artists.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lstbx_artists.FormattingEnabled = True
        Me.lstbx_artists.ItemHeight = 17
        Me.lstbx_artists.Location = New System.Drawing.Point(80, 336)
        Me.lstbx_artists.Name = "lstbx_artists"
        Me.lstbx_artists.Size = New System.Drawing.Size(200, 70)
        Me.lstbx_artists.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Acumin Pro", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(2, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Regresar"
        '
        'btn_back
        '
        Me.btn_back.BackgroundImage = Global.Project_201314707.My.Resources.Resources.back
        Me.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btn_back.Location = New System.Drawing.Point(16, 23)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(30, 30)
        Me.btn_back.TabIndex = 14
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_deletesong
        '
        Me.btn_deletesong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_deletesong.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deletesong.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_deletesong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_deletesong.Location = New System.Drawing.Point(130, 572)
        Me.btn_deletesong.Name = "btn_deletesong"
        Me.btn_deletesong.Size = New System.Drawing.Size(100, 35)
        Me.btn_deletesong.TabIndex = 13
        Me.btn_deletesong.Text = "Eliminar"
        Me.btn_deletesong.UseVisualStyleBackColor = True
        '
        'btn_addsong
        '
        Me.btn_addsong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_addsong.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addsong.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_addsong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_addsong.Location = New System.Drawing.Point(130, 422)
        Me.btn_addsong.Name = "btn_addsong"
        Me.btn_addsong.Size = New System.Drawing.Size(100, 35)
        Me.btn_addsong.TabIndex = 13
        Me.btn_addsong.Text = "Agregar"
        Me.btn_addsong.UseVisualStyleBackColor = True
        '
        'lbl_path
        '
        Me.lbl_path.AutoSize = True
        Me.lbl_path.Font = New System.Drawing.Font("Acumin Pro", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_path.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_path.Location = New System.Drawing.Point(298, 263)
        Me.lbl_path.Name = "lbl_path"
        Me.lbl_path.Size = New System.Drawing.Size(21, 20)
        Me.lbl_path.TabIndex = 6
        Me.lbl_path.Text = "--"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Acumin Pro", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_name.Location = New System.Drawing.Point(72, 127)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(69, 20)
        Me.lbl_name.TabIndex = 6
        Me.lbl_name.Text = "Nombre:"
        '
        'txt_genre
        '
        Me.txt_genre.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_genre.Location = New System.Drawing.Point(72, 208)
        Me.txt_genre.Name = "txt_genre"
        Me.txt_genre.Size = New System.Drawing.Size(217, 27)
        Me.txt_genre.TabIndex = 5
        '
        'txt_songname
        '
        Me.txt_songname.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_songname.Location = New System.Drawing.Point(72, 150)
        Me.txt_songname.Name = "txt_songname"
        Me.txt_songname.Size = New System.Drawing.Size(217, 27)
        Me.txt_songname.TabIndex = 5
        '
        'pb_song
        '
        Me.pb_song.Image = Global.Project_201314707.My.Resources.Resources.songs1
        Me.pb_song.Location = New System.Drawing.Point(140, 26)
        Me.pb_song.Name = "pb_song"
        Me.pb_song.Size = New System.Drawing.Size(80, 80)
        Me.pb_song.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_song.TabIndex = 3
        Me.pb_song.TabStop = False
        '
        'ofd_song
        '
        Me.ofd_song.FileName = "open_song"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(76, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Seleccione ubicación :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Acumin Pro", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(72, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Genero:"
        '
        'M_songs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(385, 650)
        Me.Controls.Add(Me.pnl_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "M_songs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "M_songs"
        Me.pnl_login.ResumeLayout(False)
        Me.pnl_login.PerformLayout()
        CType(Me.pb_song, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_login As Panel
    Friend WithEvents btn_addsong As Button
    Friend WithEvents pb_song As PictureBox
    Friend WithEvents btn_back As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents txt_songname As TextBox
    Friend WithEvents lstbx_artists As ListBox
    Friend WithEvents lbl_artista As Label
    Friend WithEvents btn_deletesong As Button
    Friend WithEvents lstbx_songs As ListBox
    Friend WithEvents btn_opensong As Button
    Friend WithEvents ofd_song As OpenFileDialog
    Friend WithEvents lbl_path As Label
    Friend WithEvents txt_genre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
