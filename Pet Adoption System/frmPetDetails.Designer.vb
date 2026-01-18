<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPetDetails
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
        lbl_petname = New Label()
        lbl_species = New Label()
        lbl_age = New Label()
        lbl_gender = New Label()
        pb_petimage = New PictureBox()
        Label5 = New Label()
        rtb_description = New RichTextBox()
        lbl_breed = New Label()
        lbl_status = New Label()
        CType(pb_petimage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pb_petimage
        '  
        pb_petimage.Location = New Point(20, 20)
        pb_petimage.Name = "pb_petimage"
        pb_petimage.Size = New Size(180, 180)
        pb_petimage.SizeMode = PictureBoxSizeMode.StretchImage
        pb_petimage.TabIndex = 4
        pb_petimage.TabStop = False
        pb_petimage.BorderStyle = BorderStyle.FixedSingle
        ' 
        ' lbl_petname
        ' 
        lbl_petname.AutoSize = False
        lbl_petname.Location = New Point(220, 20)
        lbl_petname.Name = "lbl_petname"
        lbl_petname.Size = New Size(340, 25)
        lbl_petname.TabIndex = 0
        lbl_petname.Text = "Pet Name:"
        ' 
        ' lbl_species
        ' 
        lbl_species.AutoSize = False
        lbl_species.Location = New Point(220, 55)
        lbl_species.Name = "lbl_species"
        lbl_species.Size = New Size(340, 25)
        lbl_species.TabIndex = 1
        lbl_species.Text = "Species:"
        ' 
        ' lbl_breed
        ' 
        lbl_breed.AutoSize = False
        lbl_breed.Location = New Point(220, 90)
        lbl_breed.Name = "lbl_breed"
        lbl_breed.Size = New Size(340, 25)
        lbl_breed.TabIndex = 2
        lbl_breed.Text = "Breed:"
        ' 
        ' lbl_age
        ' 
        lbl_age.AutoSize = False
        lbl_age.Location = New Point(220, 125)
        lbl_age.Name = "lbl_age"
        lbl_age.Size = New Size(340, 25)
        lbl_age.TabIndex = 3
        lbl_age.Text = "Age:"
        ' 
        ' lbl_gender
        ' 
        lbl_gender.AutoSize = False
        lbl_gender.Location = New Point(220, 160)
        lbl_gender.Name = "lbl_gender"
        lbl_gender.Size = New Size(340, 25)
        lbl_gender.TabIndex = 4
        lbl_gender.Text = "Gender:"
        ' 
        ' lbl_status
        ' 
        lbl_status.AutoSize = False
        lbl_status.Location = New Point(220, 195)
        lbl_status.Name = "lbl_status"
        lbl_status.Size = New Size(340, 25)
        lbl_status.TabIndex = 5
        lbl_status.Text = "Status:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(20, 220)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 15)
        Label5.TabIndex = 6
        Label5.Text = "Description:"
        ' 
        ' rtb_description
        ' 
        rtb_description.Location = New Point(20, 250)
        rtb_description.Name = "rtb_description"
        rtb_description.Size = New Size(540, 100)
        rtb_description.TabIndex = 7
        rtb_description.Text = ""
        ' 
        ' frmPetDetails
        ' 
        ClientSize = New Size(600, 400)
        Controls.Add(lbl_status)
        Controls.Add(lbl_gender)
        Controls.Add(lbl_age)
        Controls.Add(lbl_breed)
        Controls.Add(lbl_species)
        Controls.Add(lbl_petname)
        Controls.Add(pb_petimage)
        Controls.Add(Label5)
        Controls.Add(rtb_description)
        Name = "frmPetDetails"
        Text = "Pet Details"
        CType(pb_petimage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_petname As Label
    Friend WithEvents lbl_species As Label
    Friend WithEvents lbl_age As Label
    Friend WithEvents lbl_gender As Label
    Friend WithEvents pb_petimage As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents rtb_description As RichTextBox
    Friend WithEvents lbl_breed As Label
    Friend WithEvents lbl_status As Label
End Class
