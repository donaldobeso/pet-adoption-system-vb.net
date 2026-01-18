<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPet
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txt_name = New TextBox()
        txt_species = New TextBox()
        txt_breed = New TextBox()
        num_age = New NumericUpDown()
        cb_gender = New ComboBox()
        rtb_description = New RichTextBox()
        cb_status = New ComboBox()
        txt_imagepath = New TextBox()
        btn_browseimage = New Button()
        btn_cancel = New Button()
        btn_save = New Button()
        CType(num_age, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 15)
        Label1.TabIndex = 0
        Label1.Text = "Pet Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(207, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 15)
        Label2.TabIndex = 1
        Label2.Text = "Species:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(384, 29)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 15)
        Label3.TabIndex = 2
        Label3.Text = "Breed:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(46, 61)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 15)
        Label4.TabIndex = 3
        Label4.Text = "Age:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(208, 61)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 15)
        Label5.TabIndex = 4
        Label5.Text = "Gender:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(382, 66)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 15)
        Label6.TabIndex = 5
        Label6.Text = "Status:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(7, 97)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 15)
        Label7.TabIndex = 6
        Label7.Text = "Description:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(7, 168)
        Label8.Name = "Label8"
        Label8.Size = New Size(70, 15)
        Label8.TabIndex = 7
        Label8.Text = "Image Path:"
        ' 
        ' txt_name
        ' 
        txt_name.Location = New Point(88, 22)
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(107, 23)
        txt_name.TabIndex = 8
        ' 
        ' txt_species
        ' 
        txt_species.Location = New Point(262, 25)
        txt_species.Name = "txt_species"
        txt_species.Size = New Size(107, 23)
        txt_species.TabIndex = 9
        ' 
        ' txt_breed
        ' 
        txt_breed.Location = New Point(430, 26)
        txt_breed.Name = "txt_breed"
        txt_breed.Size = New Size(107, 23)
        txt_breed.TabIndex = 10
        ' 
        ' num_age
        ' 
        num_age.Location = New Point(88, 59)
        num_age.Name = "num_age"
        num_age.Size = New Size(56, 23)
        num_age.TabIndex = 11
        ' 
        ' cb_gender
        ' 
        cb_gender.FormattingEnabled = True
        cb_gender.Location = New Point(262, 61)
        cb_gender.Name = "cb_gender"
        cb_gender.Size = New Size(77, 23)
        cb_gender.TabIndex = 12
        ' 
        ' rtb_description
        ' 
        rtb_description.Location = New Point(88, 97)
        rtb_description.Name = "rtb_description"
        rtb_description.Size = New Size(449, 45)
        rtb_description.TabIndex = 14
        rtb_description.Text = ""
        ' 
        ' cb_status
        ' 
        cb_status.FormattingEnabled = True
        cb_status.Location = New Point(430, 61)
        cb_status.Name = "cb_status"
        cb_status.Size = New Size(107, 23)
        cb_status.TabIndex = 15
        ' 
        ' txt_imagepath
        ' 
        txt_imagepath.Location = New Point(88, 165)
        txt_imagepath.Name = "txt_imagepath"
        txt_imagepath.Size = New Size(318, 23)
        txt_imagepath.TabIndex = 16
        ' 
        ' btn_browseimage
        ' 
        btn_browseimage.Location = New Point(446, 165)
        btn_browseimage.Name = "btn_browseimage"
        btn_browseimage.Size = New Size(91, 23)
        btn_browseimage.TabIndex = 17
        btn_browseimage.Text = "Browse Image"
        btn_browseimage.UseVisualStyleBackColor = True
        ' 
        ' btn_cancel
        ' 
        btn_cancel.Location = New Point(158, 211)
        btn_cancel.Name = "btn_cancel"
        btn_cancel.Size = New Size(65, 23)
        btn_cancel.TabIndex = 18
        btn_cancel.Text = "Cancel"
        btn_cancel.UseVisualStyleBackColor = True
        ' 
        ' btn_save
        ' 
        btn_save.Location = New Point(317, 211)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(65, 23)
        btn_save.TabIndex = 19
        btn_save.Text = "Save"
        btn_save.UseVisualStyleBackColor = True
        ' 
        ' EditPet
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(566, 268)
        Controls.Add(btn_save)
        Controls.Add(btn_cancel)
        Controls.Add(btn_browseimage)
        Controls.Add(txt_imagepath)
        Controls.Add(cb_status)
        Controls.Add(rtb_description)
        Controls.Add(cb_gender)
        Controls.Add(num_age)
        Controls.Add(txt_breed)
        Controls.Add(txt_species)
        Controls.Add(txt_name)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "EditPet"
        Text = "EditPet"
        CType(num_age, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_species As TextBox
    Friend WithEvents txt_breed As TextBox
    Friend WithEvents num_age As NumericUpDown
    Friend WithEvents cb_gender As ComboBox
    Friend WithEvents rtb_description As RichTextBox
    Friend WithEvents cb_status As ComboBox
    Friend WithEvents txt_imagepath As TextBox
    Friend WithEvents btn_browseimage As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_save As Button
End Class
