<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.pnl_login = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_register = New System.Windows.Forms.Button()
        Me.lbl_c_passoword = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_fullname = New System.Windows.Forms.Label()
        Me.txt_cpassword = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_fullname = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_openimage = New System.Windows.Forms.Button()
        Me.ofd_register = New System.Windows.Forms.OpenFileDialog()
        Me.pnl_login.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_login
        '
        Me.pnl_login.Controls.Add(Me.btn_openimage)
        Me.pnl_login.Controls.Add(Me.Label1)
        Me.pnl_login.Controls.Add(Me.btn_back)
        Me.pnl_login.Controls.Add(Me.btn_register)
        Me.pnl_login.Controls.Add(Me.Label2)
        Me.pnl_login.Controls.Add(Me.lbl_c_passoword)
        Me.pnl_login.Controls.Add(Me.lbl_password)
        Me.pnl_login.Controls.Add(Me.lbl_username)
        Me.pnl_login.Controls.Add(Me.lbl_fullname)
        Me.pnl_login.Controls.Add(Me.txt_cpassword)
        Me.pnl_login.Controls.Add(Me.txt_password)
        Me.pnl_login.Controls.Add(Me.txt_username)
        Me.pnl_login.Controls.Add(Me.txt_fullname)
        Me.pnl_login.Controls.Add(Me.PictureBox1)
        Me.pnl_login.Location = New System.Drawing.Point(12, 12)
        Me.pnl_login.Name = "pnl_login"
        Me.pnl_login.Size = New System.Drawing.Size(361, 457)
        Me.pnl_login.TabIndex = 6
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
        'btn_register
        '
        Me.btn_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_register.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_register.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_register.Location = New System.Drawing.Point(142, 409)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(100, 35)
        Me.btn_register.TabIndex = 13
        Me.btn_register.Text = "Registrarse"
        Me.btn_register.UseVisualStyleBackColor = True
        '
        'lbl_c_passoword
        '
        Me.lbl_c_passoword.AutoSize = True
        Me.lbl_c_passoword.Font = New System.Drawing.Font("Acumin Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_c_passoword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_c_passoword.Location = New System.Drawing.Point(43, 305)
        Me.lbl_c_passoword.Name = "lbl_c_passoword"
        Me.lbl_c_passoword.Size = New System.Drawing.Size(147, 17)
        Me.lbl_c_passoword.TabIndex = 6
        Me.lbl_c_passoword.Text = "Confirmar Contraseña:"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("Acumin Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_password.Location = New System.Drawing.Point(43, 245)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(83, 17)
        Me.lbl_password.TabIndex = 6
        Me.lbl_password.Text = "Contraseña:"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Acumin Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_username.Location = New System.Drawing.Point(43, 185)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(60, 17)
        Me.lbl_username.TabIndex = 6
        Me.lbl_username.Text = "Usuario:"
        '
        'lbl_fullname
        '
        Me.lbl_fullname.AutoSize = True
        Me.lbl_fullname.Font = New System.Drawing.Font("Acumin Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_fullname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_fullname.Location = New System.Drawing.Point(43, 126)
        Me.lbl_fullname.Name = "lbl_fullname"
        Me.lbl_fullname.Size = New System.Drawing.Size(124, 17)
        Me.lbl_fullname.TabIndex = 6
        Me.lbl_fullname.Text = "Nombre Completo:"
        '
        'txt_cpassword
        '
        Me.txt_cpassword.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_cpassword.Location = New System.Drawing.Point(43, 325)
        Me.txt_cpassword.Name = "txt_cpassword"
        Me.txt_cpassword.Size = New System.Drawing.Size(281, 27)
        Me.txt_cpassword.TabIndex = 5
        Me.txt_cpassword.UseSystemPasswordChar = True
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_password.Location = New System.Drawing.Point(43, 265)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(281, 27)
        Me.txt_password.TabIndex = 5
        Me.txt_password.UseSystemPasswordChar = True
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_username.Location = New System.Drawing.Point(43, 205)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(281, 27)
        Me.txt_username.TabIndex = 5
        Me.txt_username.UseSystemPasswordChar = True
        '
        'txt_fullname
        '
        Me.txt_fullname.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_fullname.Location = New System.Drawing.Point(43, 146)
        Me.txt_fullname.Name = "txt_fullname"
        Me.txt_fullname.Size = New System.Drawing.Size(281, 27)
        Me.txt_fullname.TabIndex = 5
        Me.txt_fullname.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project_201314707.My.Resources.Resources.adduser
        Me.PictureBox1.Location = New System.Drawing.Point(142, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Acumin Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(94, 370)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Elegir imagen:"
        '
        'btn_openimage
        '
        Me.btn_openimage.BackgroundImage = Global.Project_201314707.My.Resources.Resources.openfile
        Me.btn_openimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_openimage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_openimage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btn_openimage.Location = New System.Drawing.Point(226, 364)
        Me.btn_openimage.Name = "btn_openimage"
        Me.btn_openimage.Size = New System.Drawing.Size(30, 30)
        Me.btn_openimage.TabIndex = 20
        Me.btn_openimage.UseVisualStyleBackColor = True
        '
        'ofd_register
        '
        Me.ofd_register.FileName = "OpenFileDialog1"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(385, 480)
        Me.Controls.Add(Me.pnl_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.pnl_login.ResumeLayout(False)
        Me.pnl_login.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_login As Panel
    Friend WithEvents btn_register As Button
    Friend WithEvents lbl_fullname As Label
    Friend WithEvents txt_fullname As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_c_passoword As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents txt_cpassword As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents lbl_username As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_openimage As Button
    Friend WithEvents ofd_register As OpenFileDialog
End Class
