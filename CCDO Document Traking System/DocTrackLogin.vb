Imports System.IO
Imports MySql.Data.MySqlClient

Public Class DocTrackLogin

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = btnEnter
        TxtBoxUsername.Select()
        TxtBoxPassword.Clear()
        TxtBoxUsername.Clear()



    End Sub


    Private isMouseDown As Boolean = False
    Private mouseOffset As Point


    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click


        OpenConnection()
        Dim command As New MySqlCommand("SELECT `user`, `pass` FROM `user` WHERE `user` = @username AND `pass` = @password", connection)

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = TxtBoxUsername.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = TxtBoxPassword.Text


        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        Try
            adapter.Fill(table)
            If table.Rows.Count = 0 Then

                MessageBox.Show("Invalid credentials!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                connection.Close()

            Else

                If TxtBoxUsername.Text = "ading" Or TxtBoxUsername.Text = "dimple" Then
                    FormInventory.addNewBtn.Enabled = True
                    MessageBox.Show("Successfully Logged In! Welcome " & TxtBoxUsername.Text & "!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'FORM MENU
                    FormMainMenu.SliderOpenBtn.Select()
                    FormMainMenu.UserLbl.Text = TxtBoxUsername.Text
                    FormMainMenu.ProfileBtn.Enabled = True


                    'FORM INVENTORY
                    FormInventory.chooseSearchCB.SelectedIndex = 0
                    FormInventory.suppliesCB.SelectedIndex = 0


                    LoadProfileImage()
                    connection.Close()

                    Me.Hide()
                    FormMainMenu.Show()
                Else
                    MessageBox.Show("Successfully Logged In! Welcome " & TxtBoxUsername.Text & "!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    FormMainMenu.SliderOpenBtn.Select()
                    FormMainMenu.UserLbl.Text = TxtBoxUsername.Text
                    FormMainMenu.ProfileBtn.Enabled = True


                    FormOfficeDocs.welcomeLbl.Show()
                    FormOfficeDocs.welcomeLbl.Text = "Welcome " & TxtBoxUsername.Text & "! :)"

                    addform.SaveBtn.Show()
                    addform.deleteBtn.Show()
                    LoadProfileImage()

                    connection.Close()
                    FormMainMenu.Show()
                    Me.Hide()
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Somethings wrong with logging in! Please contact your I.T: " & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub



    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Application.Exit()
    End Sub
    Private Sub ClearTexts()

        TxtBoxUsername.Clear()
        TxtBoxPassword.Clear()

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click


        TxtBoxUsername.Clear()
        FormMainMenu.Show()
        FormMainMenu.ProfilePictureBox.Load(DoctrackServer & "Profile\view.png")
        FormMainMenu.UserLbl.Text = "View Only"
        FormMainMenu.ProfileBtn.Enabled = False

        FormAddPRPO.updateBTN.Enabled = False
        FormAddPRPO.SaveBtn.Enabled = False
        FormAddPRPO.DeleteBtn.Enabled = False


        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TxtBoxPassword.PasswordChar = ""
        Else
            TxtBoxPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub SignUpBtn_Click(sender As Object, e As EventArgs) Handles SignUpBtn.Click
        FormSignUp.ShowDialog()
    End Sub

    ' Left mouse button pressed
    Private Sub DocTrackLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub



    ' MouseMove used to check if mouse cursor is moving
    Private Sub DocTrackLogin_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    ' Left mouse button released, form should stop moving
    Private Sub DocTrackLogin_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Sub LoadProfileImage()
        Dim command As New MySqlCommand("SELECT `id`, `Image` FROM `user` WHERE `user` = '" & TxtBoxUsername.Text & "'", connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()



        Dim imgByte() As Byte
        Try

            adapter.Fill(table)
            If table.Rows.Count = 1 Then

                imgByte = table(0)(1)

                Dim ms As New MemoryStream(imgByte)
                FormMainMenu.ProfilePictureBox.Image = Image.FromStream(ms)

                connection.Close()

            End If
        Catch ex As Exception

            FormMainMenu.ProfilePictureBox.Image = Image.FromFile("" & DoctrackServer & "\Profile\view.png ")

        End Try



    End Sub
End Class