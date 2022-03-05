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
        Me.pnl_left = New System.Windows.Forms.Panel()
        Me.pnl_bottom = New System.Windows.Forms.Panel()
        Me.pnl_start = New System.Windows.Forms.Panel()
        Me.btn_register = New System.Windows.Forms.Button()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_servidor = New System.Windows.Forms.Label()
        Me.btn_server = New System.Windows.Forms.Button()
        Me.pnl_top.SuspendLayout()
        Me.pnl_start.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnl_top.Controls.Add(Me.btn_minimize)
        Me.pnl_top.Controls.Add(Me.btn_close)
        Me.pnl_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_top.Location = New System.Drawing.Point(150, 0)
        Me.pnl_top.Name = "pnl_top"
        Me.pnl_top.Size = New System.Drawing.Size(800, 30)
        Me.pnl_top.TabIndex = 2
        '
        'pnl_left
        '
        Me.pnl_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_left.Location = New System.Drawing.Point(0, 0)
        Me.pnl_left.Name = "pnl_left"
        Me.pnl_left.Size = New System.Drawing.Size(150, 550)
        Me.pnl_left.TabIndex = 3
        Me.pnl_left.Visible = False
        '
        'pnl_bottom
        '
        Me.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_bottom.Location = New System.Drawing.Point(150, 450)
        Me.pnl_bottom.Name = "pnl_bottom"
        Me.pnl_bottom.Size = New System.Drawing.Size(800, 100)
        Me.pnl_bottom.TabIndex = 4
        Me.pnl_bottom.Visible = False
        '
        'pnl_start
        '
        Me.pnl_start.Controls.Add(Me.btn_register)
        Me.pnl_start.Controls.Add(Me.btn_login)
        Me.pnl_start.Controls.Add(Me.lbl_username)
        Me.pnl_start.Controls.Add(Me.TextBox1)
        Me.pnl_start.Controls.Add(Me.PictureBox1)
        Me.pnl_start.Controls.Add(Me.lbl_servidor)
        Me.pnl_start.Controls.Add(Me.btn_server)
        Me.pnl_start.Location = New System.Drawing.Point(156, 36)
        Me.pnl_start.Name = "pnl_start"
        Me.pnl_start.Size = New System.Drawing.Size(670, 410)
        Me.pnl_start.TabIndex = 5
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
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_username.Location = New System.Drawing.Point(183, 241)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(72, 21)
        Me.lbl_username.TabIndex = 5
        Me.lbl_username.Text = "Usuario:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(270, 238)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(150, 27)
        Me.TextBox1.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Project_201314707.My.Resources.Resources.user
        Me.PictureBox1.Location = New System.Drawing.Point(295, 102)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lbl_servidor
        '
        Me.lbl_servidor.AutoSize = True
        Me.lbl_servidor.Font = New System.Drawing.Font("Acumin Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_servidor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_servidor.Location = New System.Drawing.Point(81, 22)
        Me.lbl_servidor.Name = "lbl_servidor"
        Me.lbl_servidor.Size = New System.Drawing.Size(157, 25)
        Me.lbl_servidor.TabIndex = 2
        Me.lbl_servidor.Text = "Servidor: Offline"
        '
        'btn_server
        '
        Me.btn_server.BackgroundImage = Global.Project_201314707.My.Resources.Resources.server
        Me.btn_server.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_server.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_server.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btn_server.Location = New System.Drawing.Point(0, 0)
        Me.btn_server.Name = "btn_server"
        Me.btn_server.Size = New System.Drawing.Size(75, 75)
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
        Me.pnl_start.ResumeLayout(False)
        Me.pnl_start.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lbl_username As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_register As Button
End Class
