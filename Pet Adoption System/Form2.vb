Imports MySql.Data.MySqlClient

Public Class form_register

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Async Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        If txt_username2.Text = "" Or txt_email.Text = "" Or txt_conpass.Text = "" Or txt_password2.Text = "" Then
            MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txt_password2.Text <> txt_conpass.Text Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("INSERT INTO users (username, password_hash, email) VALUES (@username, @password_hash, @email)", conn)
                cmd.Parameters.AddWithValue("@username", txt_username2.Text.Trim())
                cmd.Parameters.AddWithValue("@password_hash", HashPassword(txt_password2.Text.Trim())) ' HASH before saving
                cmd.Parameters.AddWithValue("@email", txt_email.Text.Trim())

                Dim code As String = New Random().Next(100000, 999999).ToString()

                cmd.CommandText =
                "INSERT INTO users (username, password_hash, email, verification_code, is_verified)
                VALUES (@username, @password_hash, @email, @code, 0)"

                cmd.Parameters.AddWithValue("@code", code)
                cmd.ExecuteNonQuery()
                conn.Close()

                Await SendVerificationEmail(txt_email.Text, txt_username2.Text, code)

                Dim verifyForm As New VerifyForm(txt_email.Text, code)
                verifyForm.Show()

                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close() ' Close registration form
                Form1.Show() ' Open Login Form
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class