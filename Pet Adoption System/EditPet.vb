Imports MySql.Data.MySqlClient
Imports System.Net.Mime.MediaTypeNames

Public Class EditPet
    Private petId As Integer

    Public Sub New(selectedPetId As Integer)
        InitializeComponent()
        petId = selectedPetId
    End Sub

    Private Sub EditPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT * FROM pets WHERE id = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", petId)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txt_name.Text = reader("name").ToString()
                            txt_species.Text = reader("species").ToString()
                            txt_breed.Text = reader("breed").ToString()
                            num_age.Value = Convert.ToInt32(reader("age"))
                            cb_gender.Text = reader("gender").ToString()
                            cb_status.Text = reader("status").ToString()
                            rtb_description.Text = reader("description").ToString()
                            txt_imagepath.Text = reader("image_path").ToString()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading pet: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "UPDATE pets SET name=@name, species=@species, breed=@breed, age=@age, gender=@gender, status=@status, description=@description, image_path=@image_path WHERE id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", txt_name.Text.Trim())
                    cmd.Parameters.AddWithValue("@species", txt_species.Text.Trim())
                    cmd.Parameters.AddWithValue("@breed", txt_breed.Text.Trim())
                    cmd.Parameters.AddWithValue("@age", num_age.Value)
                    cmd.Parameters.AddWithValue("@gender", cb_gender.Text)
                    cmd.Parameters.AddWithValue("@status", cb_status.Text)
                    cmd.Parameters.AddWithValue("@description", rtb_description.Text.Trim())
                    cmd.Parameters.AddWithValue("@image_path", txt_imagepath.Text.Trim())
                    cmd.Parameters.AddWithValue("@id", petId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Pet updated successfully.")
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error updating pet: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_browseimage_Click(sender As Object, e As EventArgs) Handles btn_browseimage.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg"

        If ofd.ShowDialog() = DialogResult.OK Then
            txt_imagepath.Text = ofd.FileName
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class