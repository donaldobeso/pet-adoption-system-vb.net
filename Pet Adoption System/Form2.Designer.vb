<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_register))
        Panel1 = New Panel()
        GroupBox1 = New GroupBox()
        txt_email = New TextBox()
        Label4 = New Label()
        btn_back = New Button()
        btn_register = New Button()
        txt_conpass = New TextBox()
        txt_password2 = New TextBox()
        txt_username2 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Label6 = New Label()
        Label5 = New Label()
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
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(btn_back)
        GroupBox1.Controls.Add(btn_register)
        GroupBox1.Controls.Add(txt_conpass)
        GroupBox1.Controls.Add(txt_password2)
        GroupBox1.Controls.Add(txt_username2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold)
        GroupBox1.Location = New Point(20, 20)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(360, 460)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Register Account"
        ' 
        ' txt_email
        ' 
        txt_email.Font = New Font("Arial", 12F)
        txt_email.Location = New Point(20, 140)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(320, 26)
        txt_email.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label4.Location = New Point(20, 120)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 19)
        Label4.TabIndex = 0
        Label4.Text = "Email:"
        ' 
        ' btn_back
        ' 
        btn_back.BackColor = Color.LightCoral
        btn_back.Font = New Font("Arial", 12F, FontStyle.Bold)
        btn_back.Location = New Point(20, 400)
        btn_back.Name = "btn_back"
        btn_back.Size = New Size(140, 40)
        btn_back.TabIndex = 4
        btn_back.Text = "Back"
        btn_back.UseVisualStyleBackColor = False
        ' 
        ' btn_register
        ' 
        btn_register.BackColor = Color.LightGreen
        btn_register.Font = New Font("Arial", 12F, FontStyle.Bold)
        btn_register.Location = New Point(200, 400)
        btn_register.Name = "btn_register"
        btn_register.Size = New Size(140, 40)
        btn_register.TabIndex = 3
        btn_register.Text = "Register"
        btn_register.UseVisualStyleBackColor = False
        ' 
        ' txt_conpass
        ' 
        txt_conpass.Font = New Font("Arial", 12F)
        txt_conpass.Location = New Point(20, 320)
        txt_conpass.Name = "txt_conpass"
        txt_conpass.Size = New Size(320, 26)
        txt_conpass.TabIndex = 2
        txt_conpass.UseSystemPasswordChar = True
        ' 
        ' txt_password2
        ' 
        txt_password2.Font = New Font("Arial", 12F)
        txt_password2.Location = New Point(20, 240)
        txt_password2.Name = "txt_password2"
        txt_password2.Size = New Size(320, 26)
        txt_password2.TabIndex = 1
        txt_password2.UseSystemPasswordChar = True
        ' 
        ' txt_username2
        ' 
        txt_username2.Font = New Font("Arial", 12F)
        txt_username2.Location = New Point(20, 80)
        txt_username2.Name = "txt_username2"
        txt_username2.Size = New Size(320, 26)
        txt_username2.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label3.Location = New Point(20, 300)
        Label3.Name = "Label3"
        Label3.Size = New Size(157, 19)
        Label3.TabIndex = 0
        Label3.Text = "Confirm Password:"
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
        Panel2.Controls.Add(Label5)
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
        Label6.Size = New Size(203, 22)
        Label6.TabIndex = 0
        Label6.Text = "Register to get started."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial", 16F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(80, 120)
        Label5.Name = "Label5"
        Label5.Size = New Size(210, 52)
        Label5.TabIndex = 0
        Label5.Text = "Welcome to" & vbCrLf & " Pet Friend FurEver"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' form_register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 500)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "form_register"
        Text = "Register Form"
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_conpass As TextBox
    Friend WithEvents txt_password2 As TextBox
    Friend WithEvents txt_username2 As TextBox
    Friend WithEvents btn_register As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label4 As Label
End Class
