Imports System.Net
Imports System.Net.Mail


Module EmailHelper

    Public Async Function SendVerificationEmail(email As String, username As String, code As String) As Task
        Try
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New NetworkCredential(
                "donaldobeso15@gmail.com",
                "lpxcrkayziiiicbl"
            )

            Dim mail As New MailMessage()
            mail.From = New MailAddress("yourgmail@gmail.com", "Pet Adoption System")
            mail.To.Add(email)
            mail.Subject = "Email Verification Code"
            mail.Body =
$"Hello {username},

Your verification code is:

{code}

Please enter this code to verify your account.

Thank you!"

            Await smtp.SendMailAsync(mail)

        Catch ex As Exception
            MessageBox.Show("Failed to send verification email: " & ex.Message)
            Throw ' IMPORTANT: rethrow so registration knows it failed
        End Try
    End Function

End Module
