<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPet
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
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txt_name = New TextBox()
        txt_breed = New TextBox()
        num_age = New NumericUpDown()
        cb_gender = New ComboBox()
        rtb_description = New RichTextBox()
        btn_save = New Button()
        btn_cancel = New Button()
        btn_browseimage = New Button()
        pb_petimage = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        cb_species = New ComboBox()
        Label2 = New Label()
        cb_status = New ComboBox()
        Label7 = New Label()
        CType(num_age, ComponentModel.ISupportInitialize).BeginInit()
        CType(pb_petimage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 15)
        Label1.TabIndex = 0
        Label1.Text = "Pet Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(391, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 15)
        Label3.TabIndex = 2
        Label3.Text = "Breed:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(56, 62)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 15)
        Label4.TabIndex = 3
        Label4.Text = "Age:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(214, 67)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 15)
        Label5.TabIndex = 4
        Label5.Text = "Gender:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(245, 125)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 15)
        Label6.TabIndex = 5
        Label6.Text = "Description:"
        ' 
        ' txt_name
        ' 
        txt_name.Location = New Point(95, 21)
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(107, 23)
        txt_name.TabIndex = 8
        ' 
        ' txt_breed
        ' 
        txt_breed.Location = New Point(439, 19)
        txt_breed.Name = "txt_breed"
        txt_breed.Size = New Size(106, 23)
        txt_breed.TabIndex = 10
        ' 
        ' num_age
        ' 
        num_age.Location = New Point(95, 60)
        num_age.Name = "num_age"
        num_age.Size = New Size(57, 23)
        num_age.TabIndex = 11
        ' 
        ' cb_gender
        ' 
        cb_gender.FormattingEnabled = True
        cb_gender.Items.AddRange(New Object() {"Male", "Female"})
        cb_gender.Location = New Point(270, 64)
        cb_gender.Name = "cb_gender"
        cb_gender.Size = New Size(80, 23)
        cb_gender.TabIndex = 12
        ' 
        ' rtb_description
        ' 
        rtb_description.Location = New Point(245, 143)
        rtb_description.Name = "rtb_description"
        rtb_description.Size = New Size(300, 120)
        rtb_description.TabIndex = 15
        rtb_description.Text = ""
        ' 
        ' btn_save
        ' 
        btn_save.Location = New Point(480, 269)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(65, 23)
        btn_save.TabIndex = 17
        btn_save.Text = "Save"
        btn_save.UseVisualStyleBackColor = True
        ' 
        ' btn_cancel
        ' 
        btn_cancel.Location = New Point(409, 269)
        btn_cancel.Name = "btn_cancel"
        btn_cancel.Size = New Size(65, 23)
        btn_cancel.TabIndex = 18
        btn_cancel.Text = "Cancel"
        btn_cancel.UseVisualStyleBackColor = True
        ' 
        ' btn_browseimage
        ' 
        btn_browseimage.Location = New Point(80, 269)
        btn_browseimage.Name = "btn_browseimage"
        btn_browseimage.Size = New Size(91, 23)
        btn_browseimage.TabIndex = 19
        btn_browseimage.Text = "Browse Image"
        btn_browseimage.UseVisualStyleBackColor = True
        ' 
        ' pb_petimage
        ' 
        pb_petimage.Location = New Point(17, 112)
        pb_petimage.Name = "pb_petimage"
        pb_petimage.Size = New Size(212, 151)
        pb_petimage.SizeMode = PictureBoxSizeMode.StretchImage
        pb_petimage.TabIndex = 20
        pb_petimage.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' cb_species
        ' 
        cb_species.FormattingEnabled = True
        cb_species.Items.AddRange(New Object() {"Bird", "Cat", "Dog", "Hamster", "Rabbit", "Squirrel"})
        cb_species.Location = New Point(268, 21)
        cb_species.Name = "cb_species"
        cb_species.Size = New Size(109, 23)
        cb_species.TabIndex = 21
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(213, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 15)
        Label2.TabIndex = 22
        Label2.Text = "Species:"
        ' 
        ' cb_status
        ' 
        cb_status.FormattingEnabled = True
        cb_status.Items.AddRange(New Object() {"Available", "Euthanasia"})
        cb_status.Location = New Point(439, 67)
        cb_status.Name = "cb_status"
        cb_status.Size = New Size(106, 23)
        cb_status.TabIndex = 23
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(391, 70)
        Label7.Name = "Label7"
        Label7.Size = New Size(42, 15)
        Label7.TabIndex = 24
        Label7.Text = "Status:"
        ' 
        ' AddPet
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(566, 301)
        Controls.Add(Label7)
        Controls.Add(cb_status)
        Controls.Add(Label2)
        Controls.Add(cb_species)
        Controls.Add(pb_petimage)
        Controls.Add(btn_browseimage)
        Controls.Add(btn_cancel)
        Controls.Add(btn_save)
        Controls.Add(rtb_description)
        Controls.Add(cb_gender)
        Controls.Add(num_age)
        Controls.Add(txt_breed)
        Controls.Add(txt_name)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Name = "AddPet"
        Text = "AddPet"
        CType(num_age, ComponentModel.ISupportInitialize).EndInit()
        CType(pb_petimage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_breed As TextBox
    Friend WithEvents num_age As NumericUpDown
    Friend WithEvents cb_gender As ComboBox
    Friend WithEvents rtb_description As RichTextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_browseimage As Button
    Friend WithEvents pb_petimage As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cb_species As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_status As ComboBox
    Friend WithEvents Label7 As Label
End Class
