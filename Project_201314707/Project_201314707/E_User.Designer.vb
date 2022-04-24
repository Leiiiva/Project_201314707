<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_User
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_User))
        Me.pnl_login = New System.Windows.Forms.Panel()
        Me.lblpath = New System.Windows.Forms.Label()
        Me.btn_openimage = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_register = New System.Windows.Forms.Button()
        Me.lbl_path = New System.Windows.Forms.Label()
        Me.lbl_c_passoword = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_fullname = New System.Windows.Forms.Label()
        Me.txt_cpassword = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_fullname = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ofd_pic = New System.Windows.Forms.OpenFileDialog()
        Me.pnl_login.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_login
        '
        Me.pnl_login.Controls.Add(Me.lblpath)
        Me.pnl_login.Controls.Add(Me.btn_openimage)
        Me.pnl_login.Controls.Add(Me.Label1)
        Me.pnl_login.Controls.Add(Me.btn_back)
        Me.pnl_login.Controls.Add(Me.btn_register)
        Me.pnl_login.Controls.Add(Me.lbl_path)
        Me.pnl_login.Controls.Add(Me.lbl_c_passoword)
        Me.pnl_login.Controls.Add(Me.lbl_password)
        Me.pnl_login.Controls.Add(Me.lbl_username)
        Me.pnl_login.Controls.Add(Me.lbl_fullname)
        Me.pnl_login.Controls.Add(Me.txt_cpassword)
        Me.pnl_login.Controls.Add(Me.txt_password)
        Me.pnl_login.Controls.Add(Me.txt_username)
        Me.pnl_login.Controls.Add(Me.txt_fullname)
        Me.pnl_login.Controls.Add(Me.PictureBox1)
        Me.pnl_login.Location = New System.Drawing.Point(10, 10)
        Me.pnl_login.Name = "pnl_login"
        Me.pnl_login.Size = New System.Drawing.Size(309, 536)
        Me.pnl_login.TabIndex = 6
        '
        'lblpath
        '
        Me.lblpath.AutoSize = True
        Me.lblpath.Font = New System.Drawing.Font("Acumin Pro", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblpath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lblpath.Location = New System.Drawing.Point(229, 413)
        Me.lblpath.Name = "lblpath"
        Me.lblpath.Size = New System.Drawing.Size(21, 20)
        Me.lblpath.TabIndex = 21
        Me.lblpath.Text = "--"
        '
        'btn_openimage
        '
        Me.btn_openimage.BackgroundImage = Global.Project_201314707.My.Resources.Resources.openfile
        Me.btn_openimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_openimage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_openimage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btn_openimage.Location = New System.Drawing.Point(197, 411)
        Me.btn_openimage.Name = "btn_openimage"
        Me.btn_openimage.Size = New System.Drawing.Size(26, 26)
        Me.btn_openimage.TabIndex = 20
        Me.btn_openimage.UseVisualStyleBackColor = True
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
        'btn_register
        '
        Me.btn_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_register.Font = New System.Drawing.Font("Acumin Pro", 12.0!)
        Me.btn_register.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_register.Location = New System.Drawing.Point(107, 472)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(99, 30)
        Me.btn_register.TabIndex = 13
        Me.btn_register.Text = "Actualizar"
        Me.btn_register.UseVisualStyleBackColor = True
        '
        'lbl_path
        '
        Me.lbl_path.AutoSize = True
        Me.lbl_path.Font = New System.Drawing.Font("Acumin Pro", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.lbl_path.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_path.Location = New System.Drawing.Point(46, 415)
        Me.lbl_path.Name = "lbl_path"
        Me.lbl_path.Size = New System.Drawing.Size(132, 17)
        Me.lbl_path.TabIndex = 6
        Me.lbl_path.Text = "Seleccionar Imagen:"
        '
        'lbl_c_passoword
        '
        Me.lbl_c_passoword.AutoSize = True
        Me.lbl_c_passoword.Font = New System.Drawing.Font("Acumin Pro", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.lbl_c_passoword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_c_passoword.Location = New System.Drawing.Point(33, 341)
        Me.lbl_c_passoword.Name = "lbl_c_passoword"
        Me.lbl_c_passoword.Size = New System.Drawing.Size(147, 17)
        Me.lbl_c_passoword.TabIndex = 6
        Me.lbl_c_passoword.Text = "Confirmar Contraseña:"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("Acumin Pro", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.lbl_password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_password.Location = New System.Drawing.Point(33, 281)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(83, 17)
        Me.lbl_password.TabIndex = 6
        Me.lbl_password.Text = "Contraseña:"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Acumin Pro", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.lbl_username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_username.Location = New System.Drawing.Point(33, 220)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(60, 17)
        Me.lbl_username.TabIndex = 6
        Me.lbl_username.Text = "Usuario:"
        '
        'lbl_fullname
        '
        Me.lbl_fullname.AutoSize = True
        Me.lbl_fullname.Font = New System.Drawing.Font("Acumin Pro", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.lbl_fullname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbl_fullname.Location = New System.Drawing.Point(33, 159)
        Me.lbl_fullname.Name = "lbl_fullname"
        Me.lbl_fullname.Size = New System.Drawing.Size(124, 17)
        Me.lbl_fullname.TabIndex = 6
        Me.lbl_fullname.Text = "Nombre Completo:"
        '
        'txt_cpassword
        '
        Me.txt_cpassword.Font = New System.Drawing.Font("Acumin Pro", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpassword.Location = New System.Drawing.Point(33, 359)
        Me.txt_cpassword.Name = "txt_cpassword"
        Me.txt_cpassword.Size = New System.Drawing.Size(241, 22)
        Me.txt_cpassword.TabIndex = 5
        Me.txt_cpassword.UseSystemPasswordChar = True
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Acumin Pro", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(33, 298)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(241, 22)
        Me.txt_password.TabIndex = 5
        Me.txt_password.UseSystemPasswordChar = True
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Acumin Pro", 12.0!)
        Me.txt_username.Location = New System.Drawing.Point(33, 237)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(241, 27)
        Me.txt_username.TabIndex = 5
        '
        'txt_fullname
        '
        Me.txt_fullname.Font = New System.Drawing.Font("Acumin Pro", 12.0!)
        Me.txt_fullname.Location = New System.Drawing.Point(33, 177)
        Me.txt_fullname.Name = "txt_fullname"
        Me.txt_fullname.Size = New System.Drawing.Size(241, 27)
        Me.txt_fullname.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project_201314707.My.Resources.Resources.adduser
        Me.PictureBox1.Location = New System.Drawing.Point(111, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'ofd_pic
        '
        Me.ofd_pic.FileName = "OpenFileDialog1"
        '
        'E_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(330, 556)
        Me.Controls.Add(Me.pnl_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "E_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E_User"
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
    Friend WithEvents lbl_path As Label
    Friend WithEvents btn_openimage As Button
    Friend WithEvents lblpath As Label
    Friend WithEvents ofd_pic As OpenFileDialog
End Class
