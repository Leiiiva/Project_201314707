
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
                user_password = myReader.GetString(3)
                user_type = myReader.GetString(4)
                user_picture = myReader.GetString(5)
            Loop

            If Not (PM.user_username = "") Then
                MsgBox("Welcome: " + username, vbInformation, "Welcome !")
                Login.lbl_username.Text = user_username
                Login.pb_user.Image = Image.FromFile(user_picture)
                Form1.Visible = False
                Login.Visible = True
            Else
                MsgBox("User not found", vbExclamation, "Warning !")
            End If

            myConn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Sub ValidLoginP(password As String)
        If (Cypher(password) = user_password) Then
            MsgBox("Login successful!", vbInformation, "Login Ok !")
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
            MsgBox("Wrong Password !", vbExclamation, "Warning !")
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
        MsgBox("Logout successful!", vbInformation, "Logout Ok !")
    End Sub

    Sub RegisterNU(name As String, username As String, myPassword As String, cpassword As String, picture As String)
        If myPassword = cpassword Then
            If ValidRegisterP(myPassword) = True Then
                user_password = Cypher(myPassword)
                Try
                    Dim query As String = String.Empty
                    query &= "INSERT INTO Users(name, username, password, type, picture) VALUES (@name,@username,@password,@type,@picture)"
                    Using myConn
                        Using myCmd As New SqlCommand()
                            With myCmd
                                .Connection = myConn
                                .CommandType = CommandType.Text
                                .CommandText = query
                                .Parameters.AddWithValue("@name", name)
                                .Parameters.AddWithValue("@username", username)
                                .Parameters.AddWithValue("@password", user_password)
                                .Parameters.AddWithValue("@type", "cliente")
                                .Parameters.AddWithValue("@picture", picture)
                            End With
                            Try
                                myConn.Open()
                                myCmd.ExecuteNonQuery()
                                MsgBox("User registration completed !", vbInformation, "Completed !")
                                Register.Close()
                                Form1.pnl_start.Visible = False
                                Form1.pnl_left.Visible = True
                                Form1.pnl_bottom.Visible = True
                                Form1.lbl_server.Visible = True
                                Form1.pb_status2.Visible = True
                                Form1.pb_user.Image = Image.FromFile(picture)
                                Form1.lbl_username.Text = username
                                Form1.Visible = True
                                myConn.Close()
                            Catch ex As SqlException
                                MsgBox(ex.Message.ToString(), vbExclamation, "Error")
                            End Try
                        End Using
                    End Using
                Catch ex As Exception
                    MsgBox("Error entering data", vbExclamation, "Error")
                End Try
            Else
                MsgBox("Invalid Password", vbExclamation, "Check Password")
            End If
        Else
            MsgBox("Passwords don't match", vbExclamation, "Check Password")
        End If
    End Sub

    Function ValidRegisterP(myPassword As String) As Boolean
        If myPassword.Length < 8 Then Return False
        If Not myPassword.Any(Function(c) Char.IsDigit(c)) Then Return False
        If Not myPassword.Any(Function(c) Char.IsLower(c)) Then Return False
        If Not myPassword.Any(Function(c) Char.IsUpper(c)) Then Return False
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


    'ADMIN SECTION

    'Artist Management

    Sub RegisterNA(name As String, country As String)
        Try
            Dim query As String = String.Empty
            query &= "INSERT INTO Artist(name, Nationality) VALUES (@name,@Nationality)"
            Using myConn
                Using myCmd As New SqlCommand()
                    With myCmd
                        .Connection = myConn
                        .CommandType = CommandType.Text
                        .CommandText = query
                        .Parameters.AddWithValue("@name", name)
                        .Parameters.AddWithValue("@Nationality", country)
                    End With
                    Try
                        myConn.Open()
                        myCmd.ExecuteNonQuery()
                        MsgBox("Artist registration completed !", vbInformation, "Completed !")
                        myConn.Close()
                    Catch ex As SqlException
                        MsgBox(ex.Message.ToString(), vbExclamation, "Error")
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error entering data", vbExclamation, "Error")
        End Try

        Update_AL()
    End Sub

    Sub DeleteA(name As String)
        Try
            Dim query As String = String.Empty
            Dim consulta As String = "DELETE FROM Artist WHERE name = '" & name & "'"
            myCmd = New SqlCommand(consulta, myConn)
            myConn.Open()
            myCmd.ExecuteNonQuery()
            MsgBox("Artist deleted !", vbInformation, "Completed !")
            myConn.Close()
        Catch ex As SqlException
            MsgBox(ex.Message.ToString(), vbExclamation, "Error")
        End Try

        Update_AL()
    End Sub

    Sub Update_AL()
        M_artists.lstbx_artists.Items.Clear()
        myConn.ConnectionString = conn
        myConn.Open()
        Try
            myCmd = myConn.CreateCommand
            Dim consulta As String = "SELECT * FROM Artist"
            myCmd.CommandText = consulta

            myReader = myCmd.ExecuteReader()

            Do While myReader.Read()
                M_artists.lstbx_artists.Items.Add(myReader.GetString(1))
            Loop

        Catch ex As Exception
            MsgBox(ex.Message.ToString(), vbExclamation, "Error")
        End Try
        myConn.Close()
    End Sub

    'User Management
    Sub DeleteU(username As String)
        Try
            Dim query As String = String.Empty
            Dim consulta As String = "DELETE FROM Users WHERE username = '" & username & "'"
            myCmd = New SqlCommand(consulta, myConn)
            myConn.Open()
            myCmd.ExecuteNonQuery()
            MsgBox("Username deleted !", vbInformation, "Completed !")
            myConn.Close()
        Catch ex As SqlException
            MsgBox(ex.Message.ToString(), vbExclamation, "Error")
        End Try

        Update_UL()
    End Sub

    Sub Update_UL()
        M_users.lstbx_users.Items.Clear()
        myConn.ConnectionString = conn
        myConn.Open()
        Try
            myCmd = myConn.CreateCommand
            Dim consulta As String = "SELECT * FROM Users"
            myCmd.CommandText = consulta

            myReader = myCmd.ExecuteReader()

            Do While myReader.Read()
                M_users.lstbx_users.Items.Add(myReader.GetString(2))
            Loop

        Catch ex As Exception
            MsgBox(ex.Message.ToString(), vbExclamation, "Error")
        End Try
        myConn.Close()
    End Sub

    'Song Management

End Module
