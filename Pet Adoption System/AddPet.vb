Imports MySql.Data.MySqlClient
Imports System.Drawing ' Correct namespace for Image  
Imports System.IO
Imports System.Net.Mime.MediaTypeNames

Public Class AddPet
    Private isEditMode As Boolean = False
    Private editingPetId As Integer = -1
    Private selectedImageBytes As Byte()


    Public Sub LoadPetForEdit(petId As Integer)
        isEditMode = True
        editingPetId = petId

        Dim query As String = "SELECT * FROM pets WHERE id = @id"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@id", petId)

        conn.Open()
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            txt_name.Text = reader("name").ToString()
            cb_species.Text = reader("species").ToString()
            txt_breed.Text = reader("breed").ToString()
            num_age.Value = Convert.ToInt32(reader("age"))
            cb_gender.Text = reader("gender").ToString()
            rtb_description.Text = reader("description").ToString()

            If Not IsDBNull(reader("image")) Then
                Dim imgBytes As Byte() = CType(reader("image"), Byte())
                Using ms As New MemoryStream(imgBytes)
                    pb_petimage.Image = Drawing.Image.FromStream(ms)
                    selectedImageBytes = imgBytes
                End Using
            End If
        End If
        conn.Close()

        btn_save.Text = "Update Pet"
        Me.Text = "Edit Pet"
    End Sub

    Private Sub btn_browseimage_Click(sender As Object, e As EventArgs) Handles btn_browseimage.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If ofd.ShowDialog() = DialogResult.OK Then
            selectedImageBytes = File.ReadAllBytes(ofd.FileName)
            pb_petimage.Image = Drawing.Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_name.Text = "" Or cb_species.Text = "" Or txt_breed.Text = "" Or num_age.Text = "" Or cb_gender.Text = "" Then
            MessageBox.Show("Please fill out all fields.")
            Return
        End If

        Try
            conn.Open()
            Dim query As String
            Dim cmd As New MySqlCommand()
            cmd.Connection = conn

            If isEditMode Then
                query = "UPDATE pets SET name=@name, species=@species, breed=@breed, age=@age, gender=@gender, description=@description, image=@image, status=@status WHERE id=@id"
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@id", editingPetId)
            Else
                query = "INSERT INTO pets (name, species, breed, age, gender, description, image, status) VALUES (@name, @species, @breed, @age, @gender, @description, @image, @status)"
                cmd.CommandText = query
            End If

            cmd.Parameters.AddWithValue("@name", txt_name.Text)
            cmd.Parameters.AddWithValue("@species", cb_species.Text)
            cmd.Parameters.AddWithValue("@breed", txt_breed.Text)
            cmd.Parameters.AddWithValue("@age", num_age.Value)
            cmd.Parameters.AddWithValue("@gender", cb_gender.Text)
            cmd.Parameters.AddWithValue("@description", rtb_description.Text)
            cmd.Parameters.AddWithValue("@image", If(selectedImageBytes IsNot Nothing, selectedImageBytes, DBNull.Value))
            cmd.Parameters.AddWithValue("@status", cb_status.Text)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show(If(isEditMode, "Pet updated successfully!", "Pet added successfully!"))
            Me.Close()

            Dim ucManagePets As New ucManagePets()
            ' Optional: Refresh ManagePets  
            ucManagePets.LoadPets()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub AddPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pb_petimage_Click(sender As Object, e As EventArgs) Handles pb_petimage.Click

    End Sub
End Class