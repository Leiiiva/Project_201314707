<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.pnl_login = New System.Windows.Forms.Panel()
        Me.lbl_admin = New System.Windows.Forms.Label()
        Me.lbl_logout = New System.Windows.Forms.Label()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_musers = New System.Windows.Forms.Button()
        Me.btn_msongs = New System.Windows.Forms.Button()
        Me.btn_martists = New System.Windows.Forms.Button()
        Me.btn_reports = New System.Windows.Forms.Button()
        Me.pb_admin = New System.Windows.Forms.PictureBox()
        Me.pnl_login.SuspendLayout()
        CType(Me.pb_admin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_login
        '
        Me.pnl_login.Controls.Add(Me.lbl_admin)
        Me.pnl_login.Controls.Add(Me.lbl_logout)
        Me.pnl_login.Controls.Add(Me.btn_logout)
        Me.pnl_login.Controls.Add(Me.btn_musers)
        Me.pnl_login.Controls.Add(Me.btn_msongs)
        Me.pnl_login.Controls.Add(Me.btn_martists)
        Me.pnl_login.Controls.Add(Me.btn_reports)
        Me.pnl_login.Controls.Add(Me.pb_admin)
        Me.pnl_login.Location = New System.Drawing.Point(12, 12)
        Me.pnl_login.Name = "pnl_login"
        Me.pnl_login.Size = New System.Drawing.Size(361, 457)
        Me.pnl_login.TabIndex = 6
        '
        'lbl_admin
        '
        Me.lbl_admin.AutoSize = True
        Me.lbl_admin.Font = New System.Drawing.Font("Acumin Pro", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_admin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_admin.Location = New System.Drawing.Point(153, 111)
        Me.lbl_admin.Name = "lbl_admin"
        Me.lbl_admin.Size = New System.Drawing.Size(54, 20)
        Me.lbl_admin.TabIndex = 16
        Me.lbl_admin.Text = "Admin"
        '
        'lbl_logout
        '
        Me.lbl_logout.AutoSize = True
        Me.lbl_logout.Font = New System.Drawing.Font("Acumin Pro", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_logout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_logout.Location = New System.Drawing.Point(2, 3)
        Me.lbl_logout.Name = "lbl_logout"
        Me.lbl_logout.Size = New System.Drawing.Size(46, 16)
        Me.lbl_logout.TabIndex = 15
        Me.lbl_logout.Text = "Logout"
        '
        'btn_logout
        '
        Me.btn_logout.BackgroundImage = Global.Project_201314707.My.Resources.Resources.logout
        Me.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btn_logout.Location = New System.Drawing.Point(10, 23)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(30, 30)
        Me.btn_logout.TabIndex = 14
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'btn_musers
        '
        Me.btn_musers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_musers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_musers.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_musers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_musers.Location = New System.Drawing.Point(130, 162)
        Me.btn_musers.Name = "btn_musers"
        Me.btn_musers.Size = New System.Drawing.Size(100, 35)
        Me.btn_musers.TabIndex = 13
        Me.btn_musers.Text = "Usuarios"
        Me.btn_musers.UseVisualStyleBackColor = True
        '
        'btn_msongs
        '
        Me.btn_msongs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_msongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_msongs.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_msongs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_msongs.Location = New System.Drawing.Point(130, 231)
        Me.btn_msongs.Name = "btn_msongs"
        Me.btn_msongs.Size = New System.Drawing.Size(100, 35)
        Me.btn_msongs.TabIndex = 13
        Me.btn_msongs.Text = "Canciones"
        Me.btn_msongs.UseVisualStyleBackColor = True
        '
        'btn_martists
        '
        Me.btn_martists.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_martists.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_martists.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_martists.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_martists.Location = New System.Drawing.Point(130, 300)
        Me.btn_martists.Name = "btn_martists"
        Me.btn_martists.Size = New System.Drawing.Size(100, 35)
        Me.btn_martists.TabIndex = 13
        Me.btn_martists.Text = "Artistas"
        Me.btn_martists.UseVisualStyleBackColor = True
        '
        'btn_reports
        '
        Me.btn_reports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reports.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_reports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_reports.Location = New System.Drawing.Point(130, 369)
        Me.btn_reports.Name = "btn_reports"
        Me.btn_reports.Size = New System.Drawing.Size(100, 35)
        Me.btn_reports.TabIndex = 13
        Me.btn_reports.Text = "Reportes"
        Me.btn_reports.UseVisualStyleBackColor = True
        '
        'pb_admin
        '
        Me.pb_admin.Image = Global.Project_201314707.My.Resources.Resources.admin
        Me.pb_admin.Location = New System.Drawing.Point(140, 23)
        Me.pb_admin.Name = "pb_admin"
        Me.pb_admin.Size = New System.Drawing.Size(80, 80)
        Me.pb_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_admin.TabIndex = 3
        Me.pb_admin.TabStop = False
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(385, 480)
        Me.Controls.Add(Me.pnl_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.pnl_login.ResumeLayout(False)
        Me.pnl_login.PerformLayout()
        CType(Me.pb_admin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_login As Panel
    Friend WithEvents btn_reports As Button
    Friend WithEvents pb_admin As PictureBox
    Friend WithEvents btn_logout As Button
    Friend WithEvents lbl_logout As Label
    Friend WithEvents lbl_admin As Label
    Friend WithEvents btn_musers As Button
    Friend WithEvents btn_msongs As Button
    Friend WithEvents btn_martists As Button
End Class
