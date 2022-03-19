
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.Configuration

Module PM

    Public conn As String = "Data Source=DESKTOP-OLRU951\SQLEXPRESS;Initial Catalog=DB_201314707;Integrated Security=True"
    Public myConn As New SqlConnection(conn)
    Public myCmd As SqlCommand
    Public myReader As SqlDataReader
    Function ValidPassword(myPassword As String) As Boolean
        If myPassword.Length < 8 Then Return False
        If Not myPassword.Any(Function(c) Char.IsDigit(c)) Then Return False
        If Not myPassword.Any(Function(c) Char.IsLower(c)) Then Return False
        If Not myPassword.Any(Function(c) Char.IsUpper(c)) Then Return False
        Return True
    End Function

End Module
