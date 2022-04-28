
Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography



Module PM

    Public conn As String = "Data Source=DESKTOP-OLRU951\SQLEXPRESS;Initial Catalog=DB_201314707;Integrated Security=True"
    Public myConn As New SqlConnection(conn)
    Public myCmd As SqlCommand
    Public myReader As SqlDataReader

    Public user_id As Integer
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
                user_id = myReader.GetInt32(0)
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
                Update_PLS()
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
                                Update_PLS()
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
    Sub Update_AL2()
        M_songs.lstbx_artists.Items.Clear()
        myConn.ConnectionString = conn
        myConn.Open()
        Try
            myCmd = myConn.CreateCommand
            Dim consulta As String = "SELECT * FROM Artist"
            myCmd.CommandText = consulta

            myReader = myCmd.ExecuteReader()

            Do While myReader.Read()
                M_songs.lstbx_artists.Items.Add(myReader.GetString(1))
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

    Sub UpdateU(name As String, username As String, password As String, cpassword As String, picpath As String)
        If password = cpassword Then
            If ValidRegisterP(password) = True Then
                user_password = Cypher(password)
                Try
                    Dim query As String = String.Empty
                    query &= "UPDATE Users(name, username, password, type, picture) VALUES (@name,@username,@password,@type,@picture) WHERE username = '" & Form1.lbl_username.Text & "'"
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
                                .Parameters.AddWithValue("@picture", picpath)
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
                                Form1.pb_user.Image = Image.FromFile(picpath)
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


    'Song Management

    Sub RegisterNS(name As String, genre As String, location As String, artist As Integer)
        Try
            Dim query As String = String.Empty
            query &= "INSERT INTO Song(name, genre, location, artist_id) VALUES (@name, @genre, @location, @artist_id)"
            Using myConn
                Using myCmd As New SqlCommand()
                    With myCmd
                        .Connection = myConn
                        .CommandType = CommandType.Text
                        .CommandText = query
                        .Parameters.AddWithValue("@name", name)
                        .Parameters.AddWithValue("@genre", genre)
                        .Parameters.AddWithValue("@location", location)
                        .Parameters.AddWithValue("@artist_id", artist)
                    End With
                    Try
                        myConn.Open()
                        myCmd.ExecuteNonQuery()
                        MsgBox("Song registration completed !", vbInformation, "Completed !")
                        myConn.Close()
                    Catch ex As SqlException
                        MsgBox(ex.Message.ToString(), vbExclamation, "Error")
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error entering data", vbExclamation, "Error")
        End Try
        Update_SL()
        Update_AL()
    End Sub

    Sub Update_SL()
        M_songs.lstbx_songs.Items.Clear()
        myConn.ConnectionString = conn
        myConn.Open()
        Try
            myCmd = myConn.CreateCommand
            Dim consulta As String = "SELECT * FROM Song"
            myCmd.CommandText = consulta

            myReader = myCmd.ExecuteReader()

            Do While myReader.Read()
                M_songs.lstbx_songs.Items.Add(myReader.GetString(1))
            Loop

        Catch ex As Exception
            MsgBox(ex.Message.ToString(), vbExclamation, "Error")
        End Try
        myConn.Close()
    End Sub

    Sub Update_SL2()
        Form1.lstbx_songs.Items.Clear()
        myConn.ConnectionString = conn
        myConn.Open()
        Try
            myCmd = myConn.CreateCommand
            Dim consulta As String = "SELECT * FROM Song"
            myCmd.CommandText = consulta

            myReader = myCmd.ExecuteReader()

            Do While myReader.Read()
                Form1.lstbx_songs.Items.Add(myReader.GetString(1))
            Loop

        Catch ex As Exception
            MsgBox(ex.Message.ToString(), vbExclamation, "Error")
        End Try
        myConn.Close()
    End Sub

    Sub Update_SL3(npl As String)
        Form1.lstbx_sngs.Items.Clear()
        myConn.ConnectionString = conn
        myConn.Open()
        Try
            myCmd = myConn.CreateCommand
            Dim consulta As String = "SELECT dbo.Song.name, dbo.Playlist.picture, dbo.Playlist.date_created FROM dbo.Playlist INNER JOIN dbo.PlaylistDetails ON dbo.Playlist.ID = dbo.PlaylistDetails.playlist_id INNER JOIN dbo.Song ON dbo.PlaylistDetails.song_id = dbo.Song.ID INNER JOIN dbo.Users ON dbo.Playlist.user_id = dbo.Users.ID AND dbo.Playlist.user_id = dbo.Users.ID WHERE (dbo.Users.ID = " & user_id & ") AND (dbo.Playlist.name = '" & npl & "')"
            myCmd.CommandText = consulta

            myReader = myCmd.ExecuteReader()

            Do While myReader.Read()
                Form1.lstbx_sngs.Items.Add(myReader.GetString(0))
                Form1.pb_pl.Image = Image.FromFile(myReader.GetString(1))
                Form1.pl_date.Text = Convert.ToDateTime(myReader.GetDateTime(2)).ToString("yyyy/MM/dd")
            Loop

        Catch ex As Exception
            MsgBox(ex.Message.ToString(), vbExclamation, "Error")
        End Try
        myConn.Close()
    End Sub

    Sub DeleteS(name As String)
        Try
            Dim query As String = String.Empty
            Dim consulta As String = "DELETE FROM Song WHERE name = '" & name & "'"
            myCmd = New SqlCommand(consulta, myConn)
            myConn.Open()
            myCmd.ExecuteNonQuery()
            MsgBox("Username deleted !", vbInformation, "Completed !")
            myConn.Close()
        Catch ex As SqlException
            MsgBox(ex.Message.ToString(), vbExclamation, "Error")
        End Try

        Update_SL()
    End Sub

    Function GetAID(artista) As Integer
        Dim ID As Integer
        myConn.ConnectionString = conn
        myConn.Open()
        Try
            myCmd = myConn.CreateCommand
            Dim consulta As String = "SELECT * FROM Artist WHERE name = '" & artista & "'"
            myCmd.CommandText = consulta

            myReader = myCmd.ExecuteReader()

            Do While myReader.Read()
                ID = myReader.GetInt32(0)
            Loop

        Catch ex As Exception
            MsgBox(ex.Message.ToString(), vbExclamation, "Error")
        End Try
        myConn.Close()
        Return ID
    End Function

    'Playlist Management

    Sub CreatePlaylist(name As String, picpath As String)
        Try
            Dim query As String = String.Empty
            query &= "INSERT INTO Playlist(name, date_created, picture, user_id) VALUES (@name, GETDATE(), @picture, @user_id)"
            Using myConn
                Using myCmd As New SqlCommand()
                    With myCmd
                        .Connection = myConn
                        .CommandType = CommandType.Text
                        .CommandText = query
                        .Parameters.AddWithValue("@name", name)
                        .Parameters.AddWithValue("@picture", picpath)
                        .Parameters.AddWithValue("@user_id", user_id)
                    End With
                    Try
                        myConn.Open()
                        myCmd.ExecuteNonQuery()
                        MsgBox("Playlist registration completed !", vbInformation, "Completed !")
                        myConn.Close()
                    Catch ex As SqlException
                        MsgBox(ex.Message.ToString(), vbExclamation, "Error")
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error entering data", vbExclamation, "Error")
        End Try
    End Sub

    Sub CreatePlaylistDetail(playlist_id As Integer, song_id As Integer)
        Try
            Dim query As String = String.Empty
            query &= "INSERT INTO PlaylistDetails(playlist_id, song_id) VALUES (@playlist_id, @song_id)"
            Using myConn
                Using myCmd As New SqlCommand()
                    With myCmd
                        .Connection = myConn
                        .CommandType = CommandType.Text
                        .CommandText = query
                        .Parameters.AddWithValue("@playlist_id", playlist_id)
                        .Parameters.AddWithValue("@song_id", song_id)
                    End With
                    Try
                        myConn.Open()
                        myCmd.ExecuteNonQuery()
                        MsgBox("Playlist detail registration completed !", vbInformation, "Completed !")
                        myConn.Close()
                    Catch ex As SqlException
                        MsgBox(ex.Message.ToString(), vbExclamation, "Error")
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error entering data", vbExclamation, "Error")
        End Try

    End Sub

    Function GetPID(pname As String) As Integer
        Dim ID As Integer
        myConn.ConnectionString = conn
        myConn.Open()
        Try
            myCmd = myConn.CreateCommand
            Dim consulta As String = "SELECT * FROM Playlist WHERE name = '" & pname & "' AND user_id =" & user_id & ""
            myCmd.CommandText = consulta

            myReader = myCmd.ExecuteReader()

            Do While myReader.Read()
                ID = myReader.GetInt32(0)
            Loop

        Catch ex As Exception
            MsgBox(ex.Message.ToString(), vbExclamation, "Error")
        End Try
        myConn.Close()
        Return ID
    End Function

    Function GetSID(sname As String) As Integer
        Dim sID As Integer
        myConn.ConnectionString = conn
        Try
            myConn.Open()
            myCmd = myConn.CreateCommand
            Dim consulta As String = "SELECT * FROM Song WHERE name = '" & sname & "'"
            myCmd.CommandText = consulta

            myReader = myCmd.ExecuteReader()

            Do While myReader.Read()
                sID = myReader.GetInt32(0)
            Loop

            myConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), vbExclamation, "Error")
        End Try
        Return sID
    End Function

    Sub Update_PLS()
        Form1.lstbx_pls.Items.Clear()
        myConn.ConnectionString = conn
        myConn.Open()
        Try
            myCmd = myConn.CreateCommand
            Dim consulta As String = "SELECT * FROM Playlist WHERE user_id = " & user_id
            myCmd.CommandText = consulta

            myReader = myCmd.ExecuteReader()

            Do While myReader.Read()
                Form1.lstbx_pls.Items.Add(myReader.GetString(1))
            Loop

        Catch ex As Exception
            MsgBox(ex.Message.ToString(), vbExclamation, "Error")
        End Try
        myConn.Close()
    End Sub

    Function GetSPath(name As String) As String
        Dim ID As String = ""
        myConn.ConnectionString = conn
        myConn.Open()
        Try
            myCmd = myConn.CreateCommand
            Dim consulta As String = "SELECT location FROM Song WHERE name = '" & name & "'"
            myCmd.CommandText = consulta

            myReader = myCmd.ExecuteReader()

            Do While myReader.Read()
                ID = myReader.GetString(0)
            Loop

        Catch ex As Exception
            MsgBox(ex.Message.ToString(), vbExclamation, "Error")
        End Try
        myConn.Close()
        Return ID
    End Function

    'Reporting
    Sub GenerateReport(sqlstr As String)
        Try
            myConn.ConnectionString = conn
            myConn.Open()
            Dim cmd As New SqlCommand(sqlstr, myConn)
            Dim da As New SqlDataAdapter
            'cmd.Connection = myConn
            da.SelectCommand = cmd
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            Reports.DataGridView1.DataSource = Nothing
            Reports.DataGridView1.Rows.Clear()
            Reports.DataGridView1.DataSource = dt
            myConn.Close()
        Catch ex As Exception

            MsgBox(ex.Message.ToString(), vbExclamation, "Error")

        End Try
    End Sub

End Module
