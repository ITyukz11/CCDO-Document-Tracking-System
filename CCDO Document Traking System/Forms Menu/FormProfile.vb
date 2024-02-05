Imports System.IO
Imports MySql.Data.MySqlClient


Public Class FormProfile

    Public currentPassword As String

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        connection.Open()
        Dim ms As New MemoryStream


        Dim command As New MySqlCommand("Update `user` Set 
                                        `user`='" & UsernameTxt.Text & "',
                                        `DivisionDistrict`='" & DivDistTxt.Text & "',
                                        `Image`=@IMG 
                                        WHERE user ='" & DocTrackLogin.TxtBoxUsername.Text & "'", connection)

        ProfilePictureBox.Image.Save(ms, ProfilePictureBox.Image.RawFormat)
        command.Parameters.Add("@IMG", MySqlDbType.MediumBlob).Value = ms.ToArray()



        Try
            If command.ExecuteNonQuery() = 1 Then
                DisplayProfilePicture()
                MessageBox.Show("Successfully Updated!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                connection.Close()
                Me.Close()
            End If


        Catch ex As MySqlException

            MessageBox.Show("Failed to update! Please contact your I.T administrator. Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            connection.Close()

        End Try





    End Sub

    Private Sub BrowseBtn_Click(sender As Object, e As EventArgs) Handles BrowseBtn.Click
        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                ProfilePictureBox.Load(Me.OpenFileDialog1.FileName)
                ProfilePicFilePath.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)

            Else
                MsgBox("Please Choose Image", "Browse File", MessageBoxIcon.Information)
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub FormProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayProfile2()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormChangePassword.ShowDialog()
    End Sub
End Class