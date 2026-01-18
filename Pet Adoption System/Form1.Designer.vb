<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        GroupBox1 = New GroupBox()
        txt_email = New TextBox()
        Label3 = New Label()
        link_register = New LinkLabel()
        Label5 = New Label()
        btn_login = New Button()
        txt_password = New TextBox()
        txt_username = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Label6 = New Label()
        Label4 = New Label()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightBlue
        Panel1.Controls.Add(GroupBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(400, 500)
        Panel1.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txt_email)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(link_register)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(btn_login)
        GroupBox1.Controls.Add(txt_password)
        GroupBox1.Controls.Add(txt_username)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold)
        GroupBox1.Location = New Point(20, 20)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(360, 460)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Login to System"
        ' 
        ' txt_email
        ' 
        txt_email.Font = New Font("Arial", 12F)
        txt_email.Location = New Point(20, 140)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(320, 26)
        txt_email.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label3.Location = New Point(20, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 19)
        Label3.TabIndex = 0
        Label3.Text = "Email:"
        ' 
        ' link_register
        ' 
        link_register.AutoSize = True
        link_register.Font = New Font("Arial", 12F, FontStyle.Underline)
        link_register.Location = New Point(250, 400)
        link_register.Name = "link_register"
        link_register.Size = New Size(67, 18)
        link_register.TabIndex = 4
        link_register.TabStop = True
        link_register.Text = "Register"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12F, FontStyle.Italic)
        Label5.Location = New Point(20, 400)
        Label5.Name = "Label5"
        Label5.Size = New Size(176, 19)
        Label5.TabIndex = 3
        Label5.Text = "Don't have an account?"
        ' 
        ' btn_login
        ' 
        btn_login.BackColor = Color.LightGreen
        btn_login.Font = New Font("Arial", 12F, FontStyle.Bold)
        btn_login.Location = New Point(20, 340)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(320, 40)
        btn_login.TabIndex = 2
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = False
        ' 
        ' txt_password
        ' 
        txt_password.Font = New Font("Arial", 12F)
        txt_password.Location = New Point(20, 240)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(320, 26)
        txt_password.TabIndex = 1
        txt_password.UseSystemPasswordChar = True
        ' 
        ' txt_username
        ' 
        txt_username.Font = New Font("Arial", 12F)
        txt_username.Location = New Point(20, 80)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(320, 26)
        txt_username.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label2.Location = New Point(20, 220)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 19)
        Label2.TabIndex = 0
        Label2.Text = "Password:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label1.Location = New Point(20, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 19)
        Label1.TabIndex = 0
        Label1.Text = "Username:"
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label4)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(400, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(400, 500)
        Panel2.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Arial", 14F)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(100, 200)
        Label6.Name = "Label6"
        Label6.Size = New Size(217, 22)
        Label6.TabIndex = 0
        Label6.Text = "Login to access the app."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial", 16F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(80, 120)
        Label4.Name = "Label4"
        Label4.Size = New Size(204, 52)
        Label4.TabIndex = 0
        Label4.Text = "Welcome to " & vbCrLf & "Pet Friend FurEver"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 500)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Login Form"
        Panel1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents link_register As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label3 As Label

End Class
