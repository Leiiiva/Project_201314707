<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reports))
        Me.pnl_login = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.grpbx_reports = New System.Windows.Forms.GroupBox()
        Me.rbtn_top3genre = New System.Windows.Forms.RadioButton()
        Me.rbtn_top3songs = New System.Windows.Forms.RadioButton()
        Me.rbtn_top3artists = New System.Windows.Forms.RadioButton()
        Me.rbtn_playlistscreated = New System.Windows.Forms.RadioButton()
        Me.rbtn_timesinplaylist = New System.Windows.Forms.RadioButton()
        Me.rbtn_sngartist = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_generate = New System.Windows.Forms.Button()
        Me.pb_reports = New System.Windows.Forms.PictureBox()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.pnl_login.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbx_reports.SuspendLayout()
        CType(Me.pb_reports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_login
        '
        Me.pnl_login.Controls.Add(Me.DataGridView1)
        Me.pnl_login.Controls.Add(Me.grpbx_reports)
        Me.pnl_login.Controls.Add(Me.Label1)
        Me.pnl_login.Controls.Add(Me.btn_back)
        Me.pnl_login.Controls.Add(Me.btn_save)
        Me.pnl_login.Controls.Add(Me.btn_generate)
        Me.pnl_login.Controls.Add(Me.pb_reports)
        Me.pnl_login.Location = New System.Drawing.Point(12, 12)
        Me.pnl_login.Name = "pnl_login"
        Me.pnl_login.Size = New System.Drawing.Size(664, 886)
        Me.pnl_login.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(47, 448)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(570, 398)
        Me.DataGridView1.TabIndex = 18
        '
        'grpbx_reports
        '
        Me.grpbx_reports.Controls.Add(Me.rbtn_top3genre)
        Me.grpbx_reports.Controls.Add(Me.rbtn_top3songs)
        Me.grpbx_reports.Controls.Add(Me.rbtn_top3artists)
        Me.grpbx_reports.Controls.Add(Me.rbtn_playlistscreated)
        Me.grpbx_reports.Controls.Add(Me.rbtn_timesinplaylist)
        Me.grpbx_reports.Controls.Add(Me.rbtn_sngartist)
        Me.grpbx_reports.Font = New System.Drawing.Font("Acumin Pro", 11.25!)
        Me.grpbx_reports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.grpbx_reports.Location = New System.Drawing.Point(53, 132)
        Me.grpbx_reports.Name = "grpbx_reports"
        Me.grpbx_reports.Size = New System.Drawing.Size(315, 219)
        Me.grpbx_reports.TabIndex = 17
        Me.grpbx_reports.TabStop = False
        Me.grpbx_reports.Text = "Seleccione el reporte a generar"
        '
        'rbtn_top3genre
        '
        Me.rbtn_top3genre.AutoSize = True
        Me.rbtn_top3genre.Font = New System.Drawing.Font("Acumin Pro", 9.749999!)
        Me.rbtn_top3genre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.rbtn_top3genre.Location = New System.Drawing.Point(168, 158)
        Me.rbtn_top3genre.Name = "rbtn_top3genre"
        Me.rbtn_top3genre.Size = New System.Drawing.Size(127, 21)
        Me.rbtn_top3genre.TabIndex = 17
        Me.rbtn_top3genre.TabStop = True
        Me.rbtn_top3genre.Text = "TOP 3 de géneros"
        Me.rbtn_top3genre.UseVisualStyleBackColor = True
        '
        'rbtn_top3songs
        '
        Me.rbtn_top3songs.AutoSize = True
        Me.rbtn_top3songs.Font = New System.Drawing.Font("Acumin Pro", 9.749999!)
        Me.rbtn_top3songs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.rbtn_top3songs.Location = New System.Drawing.Point(17, 158)
        Me.rbtn_top3songs.Name = "rbtn_top3songs"
        Me.rbtn_top3songs.Size = New System.Drawing.Size(139, 21)
        Me.rbtn_top3songs.TabIndex = 18
        Me.rbtn_top3songs.TabStop = True
        Me.rbtn_top3songs.Text = "TOP 3 de canciones"
        Me.rbtn_top3songs.UseVisualStyleBackColor = True
        '
        'rbtn_top3artists
        '
        Me.rbtn_top3artists.AutoSize = True
        Me.rbtn_top3artists.Font = New System.Drawing.Font("Acumin Pro", 9.749999!)
        Me.rbtn_top3artists.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.rbtn_top3artists.Location = New System.Drawing.Point(168, 104)
        Me.rbtn_top3artists.Name = "rbtn_top3artists"
        Me.rbtn_top3artists.Size = New System.Drawing.Size(123, 21)
        Me.rbtn_top3artists.TabIndex = 19
        Me.rbtn_top3artists.TabStop = True
        Me.rbtn_top3artists.Text = "TOP 3 de artistas"
        Me.rbtn_top3artists.UseVisualStyleBackColor = True
        '
        'rbtn_playlistscreated
        '
        Me.rbtn_playlistscreated.AutoSize = True
        Me.rbtn_playlistscreated.Font = New System.Drawing.Font("Acumin Pro", 9.749999!)
        Me.rbtn_playlistscreated.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.rbtn_playlistscreated.Location = New System.Drawing.Point(17, 104)
        Me.rbtn_playlistscreated.Name = "rbtn_playlistscreated"
        Me.rbtn_playlistscreated.Size = New System.Drawing.Size(144, 21)
        Me.rbtn_playlistscreated.TabIndex = 20
        Me.rbtn_playlistscreated.TabStop = True
        Me.rbtn_playlistscreated.Text = "No. Playlists creadas"
        Me.rbtn_playlistscreated.UseVisualStyleBackColor = True
        '
        'rbtn_timesinplaylist
        '
        Me.rbtn_timesinplaylist.AutoSize = True
        Me.rbtn_timesinplaylist.Font = New System.Drawing.Font("Acumin Pro", 9.749999!)
        Me.rbtn_timesinplaylist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.rbtn_timesinplaylist.Location = New System.Drawing.Point(168, 50)
        Me.rbtn_timesinplaylist.Name = "rbtn_timesinplaylist"
        Me.rbtn_timesinplaylist.Size = New System.Drawing.Size(142, 21)
        Me.rbtn_timesinplaylist.TabIndex = 21
        Me.rbtn_timesinplaylist.TabStop = True
        Me.rbtn_timesinplaylist.Text = "No. Veces en playlist"
        Me.rbtn_timesinplaylist.UseVisualStyleBackColor = True
        '
        'rbtn_sngartist
        '
        Me.rbtn_sngartist.AutoSize = True
        Me.rbtn_sngartist.Font = New System.Drawing.Font("Acumin Pro", 9.749999!)
        Me.rbtn_sngartist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.rbtn_sngartist.Location = New System.Drawing.Point(17, 50)
        Me.rbtn_sngartist.Name = "rbtn_sngartist"
        Me.rbtn_sngartist.Size = New System.Drawing.Size(149, 21)
        Me.rbtn_sngartist.TabIndex = 22
        Me.rbtn_sngartist.TabStop = True
        Me.rbtn_sngartist.Text = "Canciones por Artista"
        Me.rbtn_sngartist.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Acumin Pro", 9.0!, System.Drawing.FontStyle.Bold)
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
        Me.btn_back.Location = New System.Drawing.Point(14, 20)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(26, 26)
        Me.btn_back.TabIndex = 14
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Acumin Pro", 12.0!)
        Me.btn_save.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_save.Location = New System.Drawing.Point(475, 284)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(86, 30)
        Me.btn_save.TabIndex = 13
        Me.btn_save.Text = "Guardar"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_generate
        '
        Me.btn_generate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_generate.Font = New System.Drawing.Font("Acumin Pro", 12.0!)
        Me.btn_generate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_generate.Location = New System.Drawing.Point(475, 176)
        Me.btn_generate.Name = "btn_generate"
        Me.btn_generate.Size = New System.Drawing.Size(86, 30)
        Me.btn_generate.TabIndex = 13
        Me.btn_generate.Text = "Generar"
        Me.btn_generate.UseVisualStyleBackColor = True
        '
        'pb_reports
        '
        Me.pb_reports.Image = Global.Project_201314707.My.Resources.Resources.reports_g
        Me.pb_reports.Location = New System.Drawing.Point(299, 43)
        Me.pb_reports.Name = "pb_reports"
        Me.pb_reports.Size = New System.Drawing.Size(69, 69)
        Me.pb_reports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_reports.TabIndex = 3
        Me.pb_reports.TabStop = False
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(690, 906)
        Me.Controls.Add(Me.pnl_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        Me.pnl_login.ResumeLayout(False)
        Me.pnl_login.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbx_reports.ResumeLayout(False)
        Me.grpbx_reports.PerformLayout()
        CType(Me.pb_reports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_login As Panel
    Friend WithEvents btn_generate As Button
    Friend WithEvents pb_reports As PictureBox
    Friend WithEvents btn_back As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents grpbx_reports As GroupBox
    Friend WithEvents rbtn_top3genre As RadioButton
    Friend WithEvents rbtn_top3songs As RadioButton
    Friend WithEvents rbtn_top3artists As RadioButton
    Friend WithEvents rbtn_playlistscreated As RadioButton
    Friend WithEvents rbtn_timesinplaylist As RadioButton
    Friend WithEvents rbtn_sngartist As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_save As Button
    Friend WithEvents sfd As SaveFileDialog
End Class
