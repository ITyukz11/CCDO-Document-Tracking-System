Imports MySql.Data.MySqlClient
Public Class FormSignUp


    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If UsernameTxt.Text = String.Empty And PasswordTxt.Text = String.Empty Then

            MessageBox.Show("Cannot signup! kulang ang detalye ghorl ", "D mag kalimot kalimot", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        ElseIf DivDistTxt.Text = String.Empty Then
            MessageBox.Show("Division/District EMPTY! ", "Taga pag alala lamang", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            If PasswordTxt.Text = ReTypePasswordTxt.Text Then

                If AdminPasswordTxt.Text = "citycoopcmis2021" Then
                    If ProfilePicFilePath.Text = "" Then

                        MessageBox.Show("Ayaw kaulaw ibutang imong nawng!", "amen", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Else
                        ProfilePictureSave = DoctrackServerImage & UsernameTxt.Text & ".png"
                        ProfilePictureBox.Image.Save(DoctrackServerImage & UsernameTxt.Text & ".png")

                        Signup()
                    End If


                Else

                    MessageBox.Show("Admin password incorrect!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)


                End If
            Else
                MessageBox.Show("Password not the same!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        End If



    End Sub

    Private Sub BrowseBtn_Click(sender As Object, e As EventArgs) Handles BrowseBtn.Click
        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                ProfilePictureBox.Load(Me.OpenFileDialog1.FileName)
                ProfilePicFilePath.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)

            Else
                MessageBox.Show("Please Choose Image", "Browse File", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Please Choose Image", "Browse File", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try

    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        UsernameTxt.Clear()
        PasswordTxt.Clear()
        ReTypePasswordTxt.Clear()
        DivDistTxt.Clear()
        AdminPasswordTxt.Clear()
        ProfilePicFilePath.Clear()
    End Sub

    Private Sub FormSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UsernameTxt.Select()
    End Sub
End Class