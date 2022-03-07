<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_artists
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_artists))
        Me.pnl_login = New System.Windows.Forms.Panel()
        Me.lstbx_artists = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_addartist = New System.Windows.Forms.Button()
        Me.btn_deleteartist = New System.Windows.Forms.Button()
        Me.lbl_country = New System.Windows.Forms.Label()
        Me.lbl_artistname = New System.Windows.Forms.Label()
        Me.txt_country = New System.Windows.Forms.TextBox()
        Me.txt_artistname = New System.Windows.Forms.TextBox()
        Me.pb_artist = New System.Windows.Forms.PictureBox()
        Me.pnl_login.SuspendLayout()
        CType(Me.pb_artist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_login
        '
        Me.pnl_login.Controls.Add(Me.lstbx_artists)
        Me.pnl_login.Controls.Add(Me.Label1)
        Me.pnl_login.Controls.Add(Me.btn_back)
        Me.pnl_login.Controls.Add(Me.btn_addartist)
        Me.pnl_login.Controls.Add(Me.btn_deleteartist)
        Me.pnl_login.Controls.Add(Me.lbl_country)
        Me.pnl_login.Controls.Add(Me.lbl_artistname)
        Me.pnl_login.Controls.Add(Me.txt_country)
        Me.pnl_login.Controls.Add(Me.txt_artistname)
        Me.pnl_login.Controls.Add(Me.pb_artist)
        Me.pnl_login.Location = New System.Drawing.Point(12, 12)
        Me.pnl_login.Name = "pnl_login"
        Me.pnl_login.Size = New System.Drawing.Size(361, 457)
        Me.pnl_login.TabIndex = 6
        '
        'lstbx_artists
        '
        Me.lstbx_artists.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lstbx_artists.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstbx_artists.Font = New System.Drawing.Font("Acumin Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstbx_artists.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lstbx_artists.FormattingEnabled = True
        Me.lstbx_artists.ItemHeight = 17
        Me.lstbx_artists.Location = New System.Drawing.Point(81, 311)
        Me.lstbx_artists.Name = "lstbx_artists"
        Me.lstbx_artists.Size = New System.Drawing.Size(200, 70)
        Me.lstbx_artists.TabIndex = 18
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
        'btn_addartist
        '
        Me.btn_addartist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_addartist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addartist.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_addartist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_addartist.Location = New System.Drawing.Point(131, 262)
        Me.btn_addartist.Name = "btn_addartist"
        Me.btn_addartist.Size = New System.Drawing.Size(100, 35)
        Me.btn_addartist.TabIndex = 13
        Me.btn_addartist.Text = "Agregar"
        Me.btn_addartist.UseVisualStyleBackColor = True
        '
        'btn_deleteartist
        '
        Me.btn_deleteartist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_deleteartist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deleteartist.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_deleteartist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_deleteartist.Location = New System.Drawing.Point(131, 395)
        Me.btn_deleteartist.Name = "btn_deleteartist"
        Me.btn_deleteartist.Size = New System.Drawing.Size(100, 35)
        Me.btn_deleteartist.TabIndex = 13
        Me.btn_deleteartist.Text = "Eliminar"
        Me.btn_deleteartist.UseVisualStyleBackColor = True
        '
        'lbl_country
        '
        Me.lbl_country.AutoSize = True
        Me.lbl_country.Font = New System.Drawing.Font("Acumin Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_country.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_country.Location = New System.Drawing.Point(44, 190)
        Me.lbl_country.Name = "lbl_country"
        Me.lbl_country.Size = New System.Drawing.Size(94, 17)
        Me.lbl_country.TabIndex = 6
        Me.lbl_country.Text = "Nacionalidad:"
        '
        'lbl_artistname
        '
        Me.lbl_artistname.AutoSize = True
        Me.lbl_artistname.Font = New System.Drawing.Font("Acumin Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_artistname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_artistname.Location = New System.Drawing.Point(44, 118)
        Me.lbl_artistname.Name = "lbl_artistname"
        Me.lbl_artistname.Size = New System.Drawing.Size(61, 17)
        Me.lbl_artistname.TabIndex = 6
        Me.lbl_artistname.Text = "Nombre:"
        '
        'txt_country
        '
        Me.txt_country.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_country.Location = New System.Drawing.Point(41, 221)
        Me.txt_country.Name = "txt_country"
        Me.txt_country.Size = New System.Drawing.Size(281, 27)
        Me.txt_country.TabIndex = 5
        Me.txt_country.UseSystemPasswordChar = True
        '
        'txt_artistname
        '
        Me.txt_artistname.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_artistname.Location = New System.Drawing.Point(41, 149)
        Me.txt_artistname.Name = "txt_artistname"
        Me.txt_artistname.Size = New System.Drawing.Size(281, 27)
        Me.txt_artistname.TabIndex = 5
        Me.txt_artistname.UseSystemPasswordChar = True
        '
        'pb_artist
        '
        Me.pb_artist.Image = Global.Project_201314707.My.Resources.Resources.artist_g
        Me.pb_artist.Location = New System.Drawing.Point(141, 26)
        Me.pb_artist.Name = "pb_artist"
        Me.pb_artist.Size = New System.Drawing.Size(80, 80)
        Me.pb_artist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_artist.TabIndex = 3
        Me.pb_artist.TabStop = False
        '
        'M_artists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(385, 480)
        Me.Controls.Add(Me.pnl_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "M_artists"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "M_artists"
        Me.pnl_login.ResumeLayout(False)
        Me.pnl_login.PerformLayout()
        CType(Me.pb_artist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_login As Panel
    Friend WithEvents btn_deleteartist As Button
    Friend WithEvents lbl_artistname As Label
    Friend WithEvents txt_artistname As TextBox
    Friend WithEvents pb_artist As PictureBox
    Friend WithEvents txt_country As TextBox
    Friend WithEvents lbl_country As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_addartist As Button
    Friend WithEvents lstbx_artists As ListBox
End Class
