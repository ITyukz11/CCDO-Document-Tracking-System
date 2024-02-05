Imports MySql.Data.MySqlClient
Public Class FormSuggestionBox
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' System.Console.WriteLine(TextBox1.Text)

        If TextBox1.Text = String.Empty Then
            MessageBox.Show("Suggestion Box is empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            MessageBox.Show("Under Maintenance!", "Sareh nemen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Try
            '    Dim command As New MySqlCommand("INSERT INTO `suggestion`(`Info`) VALUES (@inf", connection)
            '
            '    command.Parameters.Add("@inf", MySqlDbType.VarChar).Value = TextBox1.Text
            '
            '
            '
            '
            '
            '    connection.Open()
            '
            '    'check if data is inserted to database
            '
            '    If command.ExecuteNonQuery() = 1 Then
            '
            '        MessageBox.Show("Successfully Sent!", "Form Suggestion Box", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '        'clear Txts code on module1
            '        TextBox1.Clear()
            '        Me.Hide()
            '    Else
            '        MessageBox.Show("Message not sent!", "Form Suggestion Box", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '
            '    End If
            'Catch ex As Exception
            '
            '    MessageBox.Show("There is an Error! Message not Sent! ERROR: " & ErrorToString(), "Form Suggestion Box", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '
            'End Try



        End If




        'close connection
        connection.Close()
    End Sub
End Class