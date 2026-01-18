<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateAccount
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
        cb_role = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txt_username = New TextBox()
        txt_email = New TextBox()
        txt_password = New TextBox()
        txt_confirmpassword = New TextBox()
        btn_cancel = New Button()
        btn_save = New Button()
        lbl_status = New Label()
        pb_profilepicture = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        btn_update = New Button()
        btn_refresh = New Button()
        CType(pb_profilepicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cb_role
        ' 
        cb_role.DropDownStyle = ComboBoxStyle.DropDownList
        cb_role.FormattingEnabled = True
        cb_role.Items.AddRange(New Object() {"Admin", "Staff", "Adopter"})
        cb_role.Location = New Point(129, 251)
        cb_role.Name = "cb_role"
        cb_role.Size = New Size(121, 23)
        cb_role.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(60, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 1
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(81, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 2
        Label2.Text = "Email:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(63, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 3
        Label3.Text = "Password:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(16, 197)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 15)
        Label4.TabIndex = 4
        Label4.Text = "Confirm Password:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(63, 254)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 15)
        Label5.TabIndex = 5
        Label5.Text = "UserType:"
        ' 
        ' txt_username
        ' 
        txt_username.Location = New Point(129, 44)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(127, 23)
        txt_username.TabIndex = 6
        ' 
        ' txt_email
        ' 
        txt_email.Location = New Point(129, 94)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(127, 23)
        txt_email.TabIndex = 7
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(129, 145)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(127, 23)
        txt_password.TabIndex = 8
        ' 
        ' txt_confirmpassword
        ' 
        txt_confirmpassword.Location = New Point(129, 197)
        txt_confirmpassword.Name = "txt_confirmpassword"
        txt_confirmpassword.Size = New Size(127, 23)
        txt_confirmpassword.TabIndex = 9
        ' 
        ' btn_cancel
        ' 
        btn_cancel.Location = New Point(45, 340)
        btn_cancel.Name = "btn_cancel"
        btn_cancel.Size = New Size(75, 23)
        btn_cancel.TabIndex = 10
        btn_cancel.Text = "Cancel"
        btn_cancel.UseVisualStyleBackColor = True
        ' 
        ' btn_save
        ' 
        btn_save.Location = New Point(175, 340)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(75, 23)
        btn_save.TabIndex = 11
        btn_save.Text = "Save"
        btn_save.UseVisualStyleBackColor = True
        ' 
        ' lbl_status
        ' 
        lbl_status.AutoSize = True
        lbl_status.Location = New Point(12, 9)
        lbl_status.Name = "lbl_status"
        lbl_status.Size = New Size(42, 15)
        lbl_status.TabIndex = 12
        lbl_status.Text = "Status:"
        ' 
        ' pb_profilepicture
        ' 
        pb_profilepicture.Location = New Point(311, 41)
        pb_profilepicture.Name = "pb_profilepicture"
        pb_profilepicture.Size = New Size(150, 129)
        pb_profilepicture.SizeMode = PictureBoxSizeMode.StretchImage
        pb_profilepicture.TabIndex = 13
        pb_profilepicture.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' btn_update
        ' 
        btn_update.Location = New Point(325, 181)
        btn_update.Name = "btn_update"
        btn_update.Size = New Size(61, 27)
        btn_update.TabIndex = 14
        btn_update.Text = "Update"
        btn_update.UseVisualStyleBackColor = True
        ' 
        ' btn_refresh
        ' 
        btn_refresh.Location = New Point(382, 182)
        btn_refresh.Name = "btn_refresh"
        btn_refresh.Size = New Size(59, 27)
        btn_refresh.TabIndex = 15
        btn_refresh.Text = "Refresh"
        btn_refresh.UseVisualStyleBackColor = True
        ' 
        ' frmCreateAccount
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(479, 400)
        Controls.Add(btn_refresh)
        Controls.Add(btn_update)
        Controls.Add(pb_profilepicture)
        Controls.Add(lbl_status)
        Controls.Add(btn_save)
        Controls.Add(btn_cancel)
        Controls.Add(txt_confirmpassword)
        Controls.Add(txt_password)
        Controls.Add(txt_email)
        Controls.Add(txt_username)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cb_role)
        Name = "frmCreateAccount"
        Text = "frmCreateAccount"
        CType(pb_profilepicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cb_role As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_confirmpassword As TextBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents lbl_status As Label
    Friend WithEvents pb_profilepicture As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_refresh As Button
End Class
