Imports MySql.Data.MySqlClient

Public Class frmCreateAccount
    Public Event ProfilePictureChanged(newImage As Image)
    Private isEditMode As Boolean = False
    Private editingUserId As Integer = -1
    Private originalUsername As String = ""
    Private originalEmail As String = ""
    Private defaultProfileImage As Image = Image.FromFile("D:\Pet Adoption System\Obeso, Donald G\Obeso, Donald G\PetAdoptationSystem\Pictures\b.jpg") ' Default profile image path")
    Private profileImageBytes As Byte() = Nothing

    Public Sub LoadUserForEdit(userId As Integer)
        isEditMode = True
        editingUserId = userId

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT username, email, role, profile_picture FROM users WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", userId)

            Dim reader = cmd.ExecuteReader()
            If reader.Read() Then
                txt_username.Text = reader("username").ToString()
                txt_email.Text = reader("email").ToString()
                originalUsername = txt_username.Text
                originalEmail = txt_email.Text
                Dim roleDb As String = reader("role").ToString()
                Select Case roleDb
                    Case "admin"
                        cb_role.SelectedItem = "Admin"
                    Case "staff"
                        cb_role.SelectedItem = "Employee"
                    Case "adopter"
                        cb_role.SelectedItem = "Adopter"
                End Select
            End If
            If Not IsDBNull(reader("profile_picture")) AndAlso reader("profile_picture") IsNot Nothing Then
                profileImageBytes = CType(reader("profile_picture"), Byte())
                Using ms As New IO.MemoryStream(profileImageBytes)
                    pb_profilepicture.Image = Image.FromStream(ms)
                End Using
            Else
                profileImageBytes = Nothing
                pb_profilepicture.Image = defaultProfileImage
            End If
            conn.Close()
            txt_password.Text = ""
            txt_confirmpassword.Text = ""
            btn_save.Text = "Update"
            Me.Text = "Edit Account"
        Catch ex As Exception
            MessageBox.Show("Error loading user: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    Private Function UsernameExists(username As String) As Boolean
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM users WHERE username = @username", conn)
            cmd.Parameters.AddWithValue("@username", username)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            conn.Close()
            Return count > 0
        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
            Return True
        End Try
    End Function

    Private Function EmailExists(email As String) As Boolean
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM users WHERE email = @email", conn)
            cmd.Parameters.AddWithValue("@email", email)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            conn.Close()
            Return count > 0
        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
            Return True
        End Try
    End Function

    Private Sub frmCreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_role.Items.Clear()
        cb_role.Items.AddRange(New Object() {"Admin", "Employee", "Adopter"})
        cb_role.SelectedIndex = 0
        lbl_status.Text = ""
        pb_profilepicture.Image = defaultProfileImage
        profileImageBytes = Nothing
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        lbl_status.Text = ""

        ' Validate fields
        If String.IsNullOrWhiteSpace(txt_username.Text) OrElse
           String.IsNullOrWhiteSpace(txt_email.Text) OrElse
           String.IsNullOrWhiteSpace(txt_password.Text) OrElse
           String.IsNullOrWhiteSpace(txt_confirmpassword.Text) Then
            lbl_status.Text = "All fields are required."
            Return
        End If

        If txt_password.Text <> txt_confirmpassword.Text Then
            lbl_status.Text = "Passwords do not match."
            Return
        End If

        If isEditMode Then
            ' Only check for username/email uniqueness if changed
            If txt_username.Text.Trim() <> originalUsername AndAlso UsernameExists(txt_username.Text.Trim()) Then
                lbl_status.Text = "Username already exists."
                Return
            End If
            If txt_email.Text.Trim() <> originalEmail AndAlso EmailExists(txt_email.Text.Trim()) Then
                lbl_status.Text = "Email already exists."
                Return
            End If
        Else
            If UsernameExists(txt_username.Text.Trim()) Then
                lbl_status.Text = "Username already exists."
                Return
            End If
            If EmailExists(txt_email.Text.Trim()) Then
                lbl_status.Text = "Email already exists."
                Return
            End If
        End If

        Dim roleValue As String
        Select Case cb_role.SelectedItem.ToString()
            Case "Admin"
                roleValue = "admin"
            Case "Employee"
                roleValue = "employee"
            Case "Adopter"
                roleValue = "adopter"
            Case Else
                roleValue = "employee"
        End Select

        Try
            conn.Open()
            If isEditMode Then
                ' Only update password if a new one is entered
                Dim updateSql As String
                If profileImageBytes IsNot Nothing Then
                    updateSql = "UPDATE users SET username=@username, email=@email, role=@role, profile_picture=@profile_picture{0} WHERE id=@id"
                Else
                    updateSql = "UPDATE users SET username=@username, email=@email, role=@role{0} WHERE id=@id"
                End If
                If Not String.IsNullOrWhiteSpace(txt_password.Text) Then
                    updateSql = String.Format(updateSql, ", password=@password")
                Else
                    updateSql = String.Format(updateSql, "")
                End If

                Dim cmd As New MySqlCommand(updateSql, conn)
                cmd.Parameters.AddWithValue("@username", txt_username.Text.Trim())
                cmd.Parameters.AddWithValue("@email", txt_email.Text.Trim())
                cmd.Parameters.AddWithValue("@role", roleValue)
                cmd.Parameters.AddWithValue("@id", editingUserId)
                If Not String.IsNullOrWhiteSpace(txt_password.Text) Then
                    cmd.Parameters.AddWithValue("@password_hash", HashPassword(txt_password.Text.Trim()))
                End If
                If profileImageBytes IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@profile_picture", profileImageBytes)
                End If
                cmd.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Account updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Insert logic (as before)
                Dim cmd As New MySqlCommand("INSERT INTO users (username, email, password_hash, role, profile_picture, is_verified) VALUES (@username, @email, @password_hash, @role, @profile_picture, 1)", conn)
                cmd.Parameters.AddWithValue("@username", txt_username.Text.Trim())
                cmd.Parameters.AddWithValue("@email", txt_email.Text.Trim())
                cmd.Parameters.AddWithValue("@password_hash", HashPassword(txt_password.Text.Trim()))
                cmd.Parameters.AddWithValue("@role", roleValue)
                If profileImageBytes IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@profile_picture", profileImageBytes)
                Else
                    cmd.Parameters.AddWithValue("@profile_picture", DBNull.Value)
                End If
                cmd.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            If pb_profilepicture.Image IsNot Nothing Then
                RaiseEvent ProfilePictureChanged(pb_profilepicture.Image)
            End If

            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error saving account: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
                profileImageBytes = IO.File.ReadAllBytes(ofd.FileName)
                Using ms As New IO.MemoryStream(profileImageBytes)
                    pb_profilepicture.Image = Image.FromStream(ms)
                End Using
            End If
        End Using
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        pb_profilepicture.Image = defaultProfileImage
        profileImageBytes = Nothing
    End Sub
End Class