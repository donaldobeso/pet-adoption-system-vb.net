Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient
' This module contains the database connection string for the MySQL database
Module dbConnection
    Public conn As New MySqlConnection("server=localhost;userid=root;password=;database=pet_adoption_system")
    Public Const connectionString As String = "server=localhost;userid=root;password=;database=pet_adoption_system"


    Public Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    Public Sub MarkEmailAsVerified(email As String)
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE users SET is_verified = 1 WHERE email = @email", conn)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error updating verification status: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Module

