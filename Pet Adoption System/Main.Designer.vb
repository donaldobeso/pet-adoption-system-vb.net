<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Panel1 = New Panel()
        pb_profile = New PictureBox()
        btn_logout = New Button()
        lbl_welcome = New Label()
        Panel2 = New Panel()
        btn_accountmanagement = New Button()
        btn_reviewrequests = New Button()
        btn_managepets = New Button()
        btn_home = New Button()
        btn_myadoptionrequest = New Button()
        btn_viewpets = New Button()
        btn_myprofile = New Button()
        Panel3 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        home_description = New Label()
        LinkLabel1 = New LinkLabel()
        PictureBox2 = New PictureBox()
        group_summary = New GroupBox()
        lbl_approvedAdoptions = New Label()
        lbl_adoptionReq = New Label()
        lbl_petCount = New Label()
        Panel1.SuspendLayout()
        CType(pb_profile, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        group_summary.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightBlue
        Panel1.Controls.Add(pb_profile)
        Panel1.Controls.Add(btn_logout)
        Panel1.Controls.Add(lbl_welcome)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 97)
        Panel1.TabIndex = 1
        ' 
        ' pb_profile
        ' 
        pb_profile.Image = CType(resources.GetObject("pb_profile.Image"), Image)
        pb_profile.Location = New Point(3, 3)
        pb_profile.Name = "pb_profile"
        pb_profile.Size = New Size(87, 91)
        pb_profile.SizeMode = PictureBoxSizeMode.StretchImage
        pb_profile.TabIndex = 2
        pb_profile.TabStop = False
        ' 
        ' btn_logout
        ' 
        btn_logout.BackColor = Color.LightCoral
        btn_logout.Font = New Font("Arial", 10F, FontStyle.Bold)
        btn_logout.Location = New Point(683, 35)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(100, 30)
        btn_logout.TabIndex = 1
        btn_logout.Text = "Logout"
        btn_logout.UseVisualStyleBackColor = False
        ' 
        ' lbl_welcome
        ' 
        lbl_welcome.AutoSize = True
        lbl_welcome.Font = New Font("Arial", 12F, FontStyle.Bold)
        lbl_welcome.ForeColor = Color.DarkBlue
        lbl_welcome.Location = New Point(120, 40)
        lbl_welcome.Name = "lbl_welcome"
        lbl_welcome.Size = New Size(177, 19)
        lbl_welcome.TabIndex = 0
        lbl_welcome.Text = "Welcome , [username]"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightGray
        Panel2.Controls.Add(btn_accountmanagement)
        Panel2.Controls.Add(btn_reviewrequests)
        Panel2.Controls.Add(btn_managepets)
        Panel2.Controls.Add(btn_home)
        Panel2.Controls.Add(btn_myadoptionrequest)
        Panel2.Controls.Add(btn_viewpets)
        Panel2.Controls.Add(btn_myprofile)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 97)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(149, 475)
        Panel2.TabIndex = 2
        ' 
        ' btn_accountmanagement
        ' 
        btn_accountmanagement.BackColor = Color.LightGreen
        btn_accountmanagement.Font = New Font("Arial", 10F, FontStyle.Bold)
        btn_accountmanagement.Location = New Point(18, 321)
        btn_accountmanagement.Name = "btn_accountmanagement"
        btn_accountmanagement.Size = New Size(113, 40)
        btn_accountmanagement.TabIndex = 8
        btn_accountmanagement.Text = "Account Management"
        btn_accountmanagement.UseVisualStyleBackColor = False
        ' 
        ' btn_reviewrequests
        ' 
        btn_reviewrequests.BackColor = Color.LightGreen
        btn_reviewrequests.Font = New Font("Arial", 10F, FontStyle.Bold)
        btn_reviewrequests.Location = New Point(15, 263)
        btn_reviewrequests.Name = "btn_reviewrequests"
        btn_reviewrequests.Size = New Size(113, 40)
        btn_reviewrequests.TabIndex = 7
        btn_reviewrequests.Text = "Review Requests"
        btn_reviewrequests.UseVisualStyleBackColor = False
        ' 
        ' btn_managepets
        ' 
        btn_managepets.BackColor = Color.LightGreen
        btn_managepets.Font = New Font("Arial", 10F, FontStyle.Bold)
        btn_managepets.Location = New Point(18, 217)
        btn_managepets.Name = "btn_managepets"
        btn_managepets.Size = New Size(113, 40)
        btn_managepets.TabIndex = 6
        btn_managepets.Text = "Manage Pets"
        btn_managepets.UseVisualStyleBackColor = False
        ' 
        ' btn_home
        ' 
        btn_home.BackColor = Color.LightGreen
        btn_home.Font = New Font("Arial", 10F, FontStyle.Bold)
        btn_home.Location = New Point(14, 29)
        btn_home.Name = "btn_home"
        btn_home.Size = New Size(113, 40)
        btn_home.TabIndex = 5
        btn_home.Text = "Home"
        btn_home.UseVisualStyleBackColor = False
        ' 
        ' btn_myadoptionrequest
        ' 
        btn_myadoptionrequest.BackColor = Color.LightGreen
        btn_myadoptionrequest.Font = New Font("Arial", 10F, FontStyle.Bold)
        btn_myadoptionrequest.Location = New Point(15, 166)
        btn_myadoptionrequest.Name = "btn_myadoptionrequest"
        btn_myadoptionrequest.Size = New Size(113, 40)
        btn_myadoptionrequest.TabIndex = 4
        btn_myadoptionrequest.Text = "My Adoption Request"
        btn_myadoptionrequest.UseVisualStyleBackColor = False
        ' 
        ' btn_viewpets
        ' 
        btn_viewpets.BackColor = Color.LightGreen
        btn_viewpets.Font = New Font("Arial", 10F, FontStyle.Bold)
        btn_viewpets.Location = New Point(15, 116)
        btn_viewpets.Name = "btn_viewpets"
        btn_viewpets.Size = New Size(113, 40)
        btn_viewpets.TabIndex = 3
        btn_viewpets.Text = "View Pets"
        btn_viewpets.UseVisualStyleBackColor = False
        ' 
        ' btn_myprofile
        ' 
        btn_myprofile.BackColor = Color.LightGreen
        btn_myprofile.Font = New Font("Arial", 10F, FontStyle.Bold)
        btn_myprofile.Location = New Point(14, 72)
        btn_myprofile.Name = "btn_myprofile"
        btn_myprofile.Size = New Size(113, 40)
        btn_myprofile.TabIndex = 2
        btn_myprofile.Text = "My Profile"
        btn_myprofile.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.WhiteSmoke
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(home_description)
        Panel3.Controls.Add(LinkLabel1)
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(group_summary)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(149, 97)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(651, 475)
        Panel3.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 9F, FontStyle.Italic)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(37, 246)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 15)
        Label3.TabIndex = 11
        Label3.Text = "Click map to enlarge or:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(350, 320)
        Label2.Name = "Label2"
        Label2.Size = New Size(286, 126)
        Label2.TabIndex = 10
        Label2.Text = "Already submitted your form? Visit us at:" & vbCrLf & vbCrLf & "112 Linao-Lipata, Barangay Linao" & vbCrLf & "Minglanilla, Cebu, 6046" & vbCrLf & vbCrLf & "**BY APPOINTMENT ONLY**" & vbCrLf & vbCrLf
        ' 
        ' home_description
        ' 
        home_description.AutoSize = True
        home_description.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        home_description.ForeColor = Color.DarkSlateGray
        home_description.Location = New Point(20, 20)
        home_description.Name = "home_description"
        home_description.Size = New Size(473, 38)
        home_description.TabIndex = 8
        home_description.Text = "Welcome to Pet Friend Furever! Navigate through the options" & vbCrLf & "on the left to get started."
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Arial", 9F, FontStyle.Underline)
        LinkLabel1.ForeColor = Color.Blue
        LinkLabel1.Location = New Point(181, 246)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(133, 15)
        LinkLabel1.TabIndex = 7
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "View Google Map here."
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(20, 264)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(305, 195)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' group_summary
        ' 
        group_summary.BackColor = Color.White
        group_summary.Controls.Add(lbl_approvedAdoptions)
        group_summary.Controls.Add(lbl_adoptionReq)
        group_summary.Controls.Add(lbl_petCount)
        group_summary.Font = New Font("Arial", 10F, FontStyle.Bold)
        group_summary.ForeColor = Color.DarkSlateGray
        group_summary.Location = New Point(20, 95)
        group_summary.Name = "group_summary"
        group_summary.Size = New Size(180, 120)
        group_summary.TabIndex = 1
        group_summary.TabStop = False
        group_summary.Text = "Adoption Summary"
        ' 
        ' lbl_approvedAdoptions
        ' 
        lbl_approvedAdoptions.AutoSize = True
        lbl_approvedAdoptions.Font = New Font("Arial", 9F)
        lbl_approvedAdoptions.ForeColor = Color.DarkGreen
        lbl_approvedAdoptions.Location = New Point(10, 80)
        lbl_approvedAdoptions.Name = "lbl_approvedAdoptions"
        lbl_approvedAdoptions.Size = New Size(127, 15)
        lbl_approvedAdoptions.TabIndex = 2
        lbl_approvedAdoptions.Text = "Approved Adoptions: []"
        ' 
        ' lbl_adoptionReq
        ' 
        lbl_adoptionReq.AutoSize = True
        lbl_adoptionReq.Font = New Font("Arial", 9F)
        lbl_adoptionReq.ForeColor = Color.DarkOrange
        lbl_adoptionReq.Location = New Point(10, 50)
        lbl_adoptionReq.Name = "lbl_adoptionReq"
        lbl_adoptionReq.Size = New Size(172, 15)
        lbl_adoptionReq.TabIndex = 1
        lbl_adoptionReq.Text = "Pending Adoption Requests: []"
        ' 
        ' lbl_petCount
        ' 
        lbl_petCount.AutoSize = True
        lbl_petCount.Font = New Font("Arial", 9F)
        lbl_petCount.ForeColor = Color.DarkBlue
        lbl_petCount.Location = New Point(10, 20)
        lbl_petCount.Name = "lbl_petCount"
        lbl_petCount.Size = New Size(132, 15)
        lbl_petCount.TabIndex = 0
        lbl_petCount.Text = "Available Pets Count: []"
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 572)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(pb_profile, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        group_summary.ResumeLayout(False)
        group_summary.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_welcome As Label
    Friend WithEvents btn_logout As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_myadoptionrequest As Button
    Friend WithEvents btn_viewpets As Button
    Friend WithEvents btn_myprofile As Button
    Friend WithEvents lbl_petCount As Label
    Friend WithEvents group_summary As GroupBox
    Friend WithEvents lbl_approvedAdoptions As Label
    Friend WithEvents lbl_adoptionReq As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btn_home As Button
    Friend WithEvents home_description As Label
    Friend WithEvents pb_profile As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_managepets As Button
    Friend WithEvents btn_reviewrequests As Button
    Friend WithEvents btn_accountmanagement As Button
End Class
