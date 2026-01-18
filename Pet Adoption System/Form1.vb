Imports MySql.Data.MySqlClient

Public Class Form1

    Public Class Session
        Public Shared currentUserId As Integer
        Public Shared currentUserRole As String ' e.g. "admin" or "adopter"
        Public Shared currentUsername As String ' optional, for "Welcome" message
    End Class


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function GenerateVerificationCode() As String
        Dim rand As New Random()
        Return rand.Next(100000, 999999).ToString() ' returns 6-digit string
    End Function

    Private Sub link_register_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_register.LinkClicked
        form_register.Show()
        Me.Hide()
    End Sub

    ' Helper function to get user ID by username and email
    Private Function GetUserIdByUsernameAndEmail(username As String, email As String) As Integer
        Try
            Using getIdConn As New MySqlConnection(conn.ConnectionString)
                getIdConn.Open()
                Using cmd As New MySqlCommand("SELECT id FROM users WHERE username=@username AND email=@email", getIdConn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@email", email)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        Return Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch
            ' Ignore, will return 0
        End Try
        Return 0
    End Function

    Private Async Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            Session.currentUserId = 0
            Session.currentUserRole = ""
            Session.currentUsername = ""
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM users WHERE username=@username AND email=@email AND password_hash=@password_hash", conn)
            cmd.Parameters.AddWithValue("@username", txt_username.Text.Trim())
            cmd.Parameters.AddWithValue("@email", txt_email.Text.Trim())
            cmd.Parameters.AddWithValue("@password_hash", HashPassword(txt_password.Text.Trim())) ' HASH before checking

            Dim reader = cmd.ExecuteReader()

            Dim userFound As Boolean = False
            Dim isVerified As Boolean = False
            Dim role As String = ""
            Dim username As String = txt_username.Text.Trim()
            Dim email As String = txt_email.Text.Trim()

            If reader.Read() Then
                userFound = True
                isVerified = Convert.ToBoolean(reader("is_verified"))
                role = reader("role").ToString()
                Session.currentUserId = Convert.ToInt32(reader("id"))
                Session.currentUserRole = reader("role").ToString()
                Session.currentUsername = reader("username").ToString()
            End If

            reader.Close()

            If userFound Then
                If Not isVerified Then
                    Dim result As DialogResult = MessageBox.Show("Your email is not verified. Would you like to resend the verification code?", "Email Not Verified", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If result = DialogResult.Yes Then
                        ' Generate and update verification code
                        Dim newCode As String = GenerateVerificationCode()

                        ' Close the main connection before opening a new one
                        conn.Close()

                        Using updateConn As New MySqlConnection(conn.ConnectionString)
                            updateConn.Open()
                            Using updateCmd As New MySqlCommand("UPDATE users SET verification_code = @code WHERE email = @email", updateConn)
                                updateCmd.Parameters.AddWithValue("@code", newCode)
                                updateCmd.Parameters.AddWithValue("@email", email)
                                updateCmd.ExecuteNonQuery()
                            End Using
                        End Using

                        ' Resend email
                        Await SendVerificationEmail(txt_email.Text, txt_username.Text, newCode)

                        ' Show verification form again
                        Dim verifyForm As New VerifyForm(email, newCode)
                        verifyForm.ShowDialog()
                    End If

                    Return ' Block login if not verified
                Else
                    ' Set session values ONLY after successful login and verification
                    Session.currentUserId = GetUserIdByUsernameAndEmail(username, email)
                    Session.currentUserRole = role
                    Session.currentUsername = username
                    Main.LoadCurrentUserProfilePicture()
                    Main.UpdateUIByRole()
                    MessageBox.Show("Login successful as " & role)
                    Main.Show()
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Invalid credentials.")
            End If

        Catch ex As Exception
            MessageBox.Show("Login error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub txt_username_TextChanged(sender As Object, e As EventArgs) Handles txt_username.TextChanged

    End Sub
End Class
