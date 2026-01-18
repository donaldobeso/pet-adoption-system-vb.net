Imports System.Windows.Forms
Imports Microsoft.Web.WebView2.Core

Public Class Main
    Private originalPanel3Controls As New List(Of Control)
    Private defaultProfileImage As Image = Image.FromFile("D:\Pet Adoption System\Obeso, Donald G\Obeso, Donald G\PetAdoptationSystem\Pictures\b.jpg")

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles group_summary.Enter

    End Sub

    Public Sub UpdateUIByRole()
        Dim role As String = GetCurrentUserRole()

        ' Example: Show/hide or enable/disable buttons based on role
        btn_home.Visible = True ' Home button is always visible
        btn_myprofile.Visible = True ' My Profile button is always visible
        btn_viewpets.Visible = (role = "adopter")
        btn_myadoptionrequest.Visible = (role = "adopter")
        btn_managepets.Visible = (role = "admin" Or role = "employee")
        btn_reviewrequests.Visible = (role = "admin" Or role = "employee")
        btn_accountmanagement.Visible = (role = "admin")


        ' Add more logic for other buttons as needed
    End Sub

    Private Function GetCurrentUserRole() As String
        Dim role As String = ""
        Try
            Using conn As New MySql.Data.MySqlClient.MySqlConnection(connectionString)
                conn.Open()
                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand("SELECT role FROM users WHERE id=@id", conn)
                cmd.Parameters.AddWithValue("@id", Form1.Session.currentUserId)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    role = result.ToString().ToLower()
                End If
            End Using
        Catch
            ' Handle error as needed
        End Try
        Return role
    End Function

    Public Sub LoadCurrentUserProfilePicture()
        Dim userProfileImage As Image = Nothing
        Try
            Using conn As New MySql.Data.MySqlClient.MySqlConnection(connectionString)
                conn.Open()
                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand("SELECT profile_picture FROM users WHERE id=@id", conn)
                cmd.Parameters.AddWithValue("@id", Form1.Session.currentUserId)
                Dim result = cmd.ExecuteScalar()
                If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                    Dim imgBytes As Byte() = CType(result, Byte())
                    Using ms As New IO.MemoryStream(imgBytes)
                        userProfileImage = Image.FromStream(ms)
                    End Using
                End If
            End Using
        Catch
            ' Optionally handle errors
        End Try

        If userProfileImage IsNot Nothing Then
            pb_profile.Image = userProfileImage
        Else
            pb_profile.Image = defaultProfileImage
        End If
    End Sub

    Private Sub OnProfilePictureChanged(newImage As Image)
        pb_profile.Image = newImage
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateUIByRole()
        For Each ctrl As Control In Panel3.Controls
            originalPanel3Controls.Add(ctrl)
        Next
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim mapUrl As String = "https://www.google.com/maps/dir/Linao-Lipata+Barangay+Hall,+Natalio+Bacalso+National+Highway,+Minglanilla,+Cebu/Naga+City,+Cebu/@10.2311318,123.7423577,9505m/data=!3m2!1e3!4b1!4m13!4m12!1m5!1m1!1s0x33a99d6f2db1fef1:0x1d1b216ef2df91e0!2m2!1d123.8099314!2d10.254583!1m5!1m1!1s0x33a9784dc23f97a3:0x6e1d801f07e82f31!2m2!1d123.7572942!2d10.2084984?entry=ttu"

        Try
            Process.Start(New ProcessStartInfo(mapUrl) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("Failed to open the link: " & ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles home_description.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btn_viewpets_Click(sender As Object, e As EventArgs) Handles btn_viewpets.Click
        Dim petsControl As New ucViewPets()
        Panel3.Controls.Clear()
        Panel3.Controls.Add(petsControl)
        petsControl.Dock = DockStyle.Fill
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_managepets.Click
        Panel3.Controls.Clear()
        Dim manageUC As New ucManagePets()
        Panel3.Controls.Add(manageUC)
        manageUC.Dock = DockStyle.Fill
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Panel3.Controls.Clear() ' Remove any UserControls

        ' Re-add original controls
        For Each ctrl As Control In originalPanel3Controls
            Panel3.Controls.Add(ctrl)
        Next
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        ' Confirm logout (optional)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Clear session
            Form1.Session.currentUserId = 0

            ' Return to login form
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btn_reviewrequests_Click(sender As Object, e As EventArgs) Handles btn_reviewrequests.Click
        Panel3.Controls.Clear()
        Dim reviewUC As New ucReviewRequests
        Panel3.Controls.Add(reviewUC)
        reviewUC.Dock = DockStyle.Fill
    End Sub

    Private Sub btn_myadoptionrequest_Click(sender As Object, e As EventArgs) Handles btn_myadoptionrequest.Click
        Panel3.Controls.Clear()
        Dim adoptionreqUC As New ucMyAdoptionRequests()

        Panel3.Controls.Add(adoptionreqUC)
        adoptionreqUC.Dock = DockStyle.Fill
    End Sub

    Private Sub btn_myprofile_Click(sender As Object, e As EventArgs) Handles btn_myprofile.Click
        Dim profileUC As New ucMyProfile()
        profileUC.currentUserId = Form1.Session.currentUserId
        Panel3.Controls.Clear()
        Panel3.Controls.Add(profileUC)
        profileUC.Dock = DockStyle.Fill
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pb_profile.Click
        Dim profileUC As New ucMyProfile()
        profileUC.currentUserId = Form1.Session.currentUserId
        AddHandler profileUC.ProfilePicChanged, AddressOf Me.OnProfilePictureChanged
        Panel3.Controls.Clear()
        Panel3.Controls.Add(profileUC)
        profileUC.Dock = DockStyle.Fill
    End Sub

    ' Event handler for ProfilePicChanged
    Private Sub OnProfilePicChanged(newImage As Image)
        MessageBox.Show("Profile picture has been updated.", "Profile Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_accountmanagement_Click(sender As Object, e As EventArgs) Handles btn_accountmanagement.Click
        Panel3.Controls.Clear()
        Dim accountUC As New ucAccountManagement()
        Panel3.Controls.Add(accountUC)
        accountUC.Dock = DockStyle.Fill
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class