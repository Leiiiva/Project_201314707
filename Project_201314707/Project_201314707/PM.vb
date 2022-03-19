
Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography

Module PM

    Public conn As String = "Data Source=DESKTOP-OLRU951\SQLEXPRESS;Initial Catalog=DB_201314707;Integrated Security=True"
    Public myConn As New SqlConnection(conn)
    Public myCmd As SqlCommand
    Public myReader As SqlDataReader

    Public user_id As String = ""
    Public user_name As String = ""
    Public user_username As String = ""
    Public user_password As String = ""
    Public user_type As String = ""
    Public user_picture As String = ""

    Public picturepath As String = ""

    Sub ValidUsername(username As String)
        Try
            myCmd = myConn.CreateCommand
            Dim consulta As String = "SELECT * FROM Users WHERE username = '" & username & "'"
            myCmd.CommandText = consulta

            myConn.Open()
            myReader = myCmd.ExecuteReader()

            Do While myReader.Read()
                user_id = myReader.GetInt32(0).ToString
                user_name = myReader.GetString(1)
                user_username = myReader.GetString(2)
                user_type = myReader.GetString(4)
                user_picture = myReader.GetString(5)
            Loop

            If Not (PM.user_username = "") Then
                MsgBox("Bienvenido " + username)
                Login.lbl_username.Text = user_username
                Login.pb_user.Image = Image.FromFile(user_picture)
                Form1.Visible = False
                Login.Visible = True
            Else
                MsgBox("Usuario no encontrado")
            End If

            myConn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Sub ValidLoginP(password As String)
        If (Cypher(password) = user_password) Then
            MsgBox("Login exitoso")
            Login.Close()
            If (user_type = "admin") Then
                Admin.Visible = True
            Else
                Login.Close()
                Form1.pnl_start.Visible = False
                Form1.pnl_left.Visible = True
                Form1.pnl_bottom.Visible = True
                Form1.lbl_server.Visible = True
                Form1.pb_status2.Visible = True
                Form1.pb_user.Image = Image.FromFile(user_picture)
                Form1.lbl_username.Text = user_username
                Form1.Visible = True
            End If

        Else
            MsgBox("Contraseña incorrecta")
        End If
    End Sub

    Sub Logout()
        user_id = ""
        user_name = ""
        user_username = ""
        user_password = ""
        user_type = ""
        user_picture = ""
        Login.txt_password.Text = ""
        Form1.txt_usrname.Text = ""
        Form1.pnl_left.Visible = False
        Form1.pnl_bottom.Visible = False
        Form1.lbl_server.Visible = False
        Form1.pb_status2.Visible = False
        Form1.pnl_start.Visible = True
    End Sub

    Sub RegisterNU(name As String, username As String, myPassword As String, cpassword As String, picture As String)
        If myPassword = cpassword Then
            If ValidRegisterP(myPassword) Then
                user_password = Cypher(myPassword)
                Try
                    myCmd = myConn.CreateCommand
                    Dim consulta As String = "SELECT * FROM Users WHERE username = '" & username & "'"
                    myCmd.CommandText = consulta

                    myConn.Open()
                    myReader = myCmd.ExecuteReader()

                    Do While myReader.Read()
                        user_username = myReader.GetString(2)
                    Loop

                    If (user_username = username) Then
                        MsgBox("El usuario ya existe")
                    Else
                        Dim ingreso As String = "INSERT INTO Users(name, username, password, type, picture) VALUES ('" & name & "', '" & username & "', '" & user_password & "', " & "'cliente', '" & picture & "')"
                        MsgBox("Usuario creado correctamente")
                        Register.Close()
                        Form1.pnl_start.Visible = False
                        Form1.pnl_left.Visible = True
                        Form1.pnl_bottom.Visible = True
                        Form1.lbl_server.Visible = True
                        Form1.pb_status2.Visible = True
                        Form1.pb_user.Image = Image.FromFile(picture)
                        Form1.lbl_username.Text = username
                        Form1.Visible = True
                    End If

                    myConn.Close()

                Catch ex As Exception
                    MsgBox("Error al ingresar datos a la base de datos")
                End Try

            Else
                MsgBox("Las contraseñas no coinciden")
            End If
        Else
            MsgBox("Contraseña invalida")
        End If
    End Sub

    Function ValidRegisterP(myPassword As String) As Boolean
        If myPassword.Length < 8 Then Return False
        If Not myPassword.Any(Function(c) Char.IsDigit(c)) Then Return False
        If Not myPassword.Any(Function(c) Char.IsLower(c)) Then Return False
        If Not myPassword.Any(Function(c) Char.IsUpper(c)) Then Return False
        If Not myPassword.Any(Function(c) Char.IsSymbol(c)) Then Return False
        Return True
    End Function

    Function Cypher(ByVal Input As String) As String
        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi")
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPVIvVLlrcmtzPU9/c67Gkj7yL1S5")
        Dim buffer() As Byte = Encoding.UTF8.GetBytes(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV

        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))
    End Function

End Module
