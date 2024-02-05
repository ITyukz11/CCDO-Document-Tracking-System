Imports MySql.Data.MySqlClient

Public Class FormChangePassword
    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        connection.Open()

        If CurPassTxt.Text = DocTrackLogin.TxtBoxPassword.Text Then
            If NewPassTxt.Text = ReTypePassTxt.Text Then
                Dim command As New MySqlCommand("Update `user` Set 
                                        `pass`='" & NewPassTxt.Text & "'
                                        WHERE user ='" & DocTrackLogin.TxtBoxUsername.Text & "'", connection)



                Try
                    If command.ExecuteNonQuery() = 1 Then

                        MessageBox.Show("Password successfully changed!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DocTrackLogin.TxtBoxPassword.Text = NewPassTxt.Text
                        CurPassTxt.Text = ""
                        NewPassTxt.Text = ""
                        ReTypePassTxt.Text = ""
                        Me.Close()
                    End If


                Catch ex As MySqlException

                    MessageBox.Show("Failed to update! Please contact your I.T administrator. Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


                End Try
            Else
                MessageBox.Show("New password and re-type password do not match!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            MessageBox.Show("Wrong current password!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        connection.Close()



    End Sub
End Class