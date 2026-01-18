Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp
Imports System.IO

Public Class frmPetDetails
    Public Sub LoadPetDetails(petId As Integer)
        Try
            Dim query As String = "SELECT name, species, breed, age, gender, description, status, image FROM pets WHERE id = @id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", petId)

            conn.Open()
            Dim reader = cmd.ExecuteReader()
            If reader.Read() Then
                lbl_petname.Text = "Pet Name: " & reader("name").ToString()
                lbl_species.Text = "Species: " & reader("species").ToString()
                lbl_breed.Text = "Breed: " & reader("breed").ToString()
                lbl_age.Text = "Age: " & reader("age").ToString()
                lbl_gender.Text = "Gender: " & reader("gender").ToString()
                lbl_status.Text = "Status: " & reader("status").ToString()
                rtb_description.Text = reader("description").ToString()

                If Not IsDBNull(reader("image")) Then
                    Dim imgBytes As Byte() = CType(reader("image"), Byte())
                    Using ms As New MemoryStream(imgBytes)
                        pb_petimage.Image = Image.FromStream(ms)
                    End Using
                Else
                    pb_petimage.Image = Nothing
                End If
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading pet details: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lbl_gender.Click

    End Sub

    Private Sub frmPetDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class