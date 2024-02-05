
Imports MySql.Data.MySqlClient
Public Class deleteForm
    'Database Tables
    'Database Tables Incoming

    'Database Tables 
    Dim doctrack2022IncomingTable As String = "doctrack2022incomingtb"
    Dim doctrack2021IncomingTable As String = "doctrack2021incomingtb"
    Dim doctrack2020IncomingTable As String = "doctrack2020incomingtb"
    Dim doctrack2019IncomingTable As String = "doctrack2019incomingtb"
    Dim doctrack2018IncomingTable As String = "doctrack2018incomingtb"
    Dim doctrack2017IncomingTable As String = "doctrack2017incomingtb"
    Dim doctrack2016IncomingTable As String = "doctrack2016incomingtb"

    'Database Tables Outgoing
    Dim doctrack2022OutgoingTable As String = "doctrack2022outgoingtb"
    Dim doctrack2021OutgoingTable As String = "doctrack2021outgoingtb"
    Dim doctrack2020OutgoingTable As String = "doctrack2020outgoingtb"
    Dim doctrack2019OutgoingTable As String = "doctrack2019outgoingtb"
    Dim doctrack2018OutgoingTable As String = "doctrack2018outgoingtb"
    Dim doctrack2017OutgoingTable As String = "doctrack2017outgoingtb"
    Dim doctrack2016OutgoingTable As String = "doctrack2016outgoingtb"
    Dim logdelete = "Deleted"


    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
        If delPassTxt.Text = DocTrackLogin.TxtBoxPassword.Text Then

            Dim result = MessageBox.Show("Are you sure you want to delete?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


            If (result = DialogResult.Yes) Then

                If FormOfficeDocs.inc_out_CB.Text = "Incoming" Then




                    Dim delete_command As New MySqlCommand("DELETE FROM doctrack" & FormOfficeDocs.yearCB.Text & "incomingtb WHERE `No`=@NO", connection)
                    delete_command.Parameters.Add("@NO", MySqlDbType.Int64).Value = addform.NoLbl.Text

                    Dim log_command As New MySqlCommand("INSERT INTO logs ( `ReferenceNo`,`Document`,`Action`,`Name`) 
                                        VALUES (@REF,@YR,@AC,@NM)", connection)

                    log_command.Parameters.Add("@REF", MySqlDbType.VarChar).Value = addform.refTB.Text
                    log_command.Parameters.Add("@AC", MySqlDbType.VarChar).Value = logdelete
                    log_command.Parameters.Add("@YR", MySqlDbType.VarChar).Value = FormOfficeDocs.yearCB.Text & "/" & FormOfficeDocs.inc_out_CB.Text
                    log_command.Parameters.Add("@NM", MySqlDbType.VarChar).Value = DocTrackLogin.TxtBoxUsername.Text

                    connection.Open()


                    If delete_command.ExecuteNonQuery() And log_command.ExecuteNonQuery = 1 Then
                        MessageBox.Show("Data Successfully Deleted!")
                        addform.delete_clearTxts()
                        refreshdataAfterDeleting()
                        Me.Hide()
                    Else
                        MessageBox.Show("Data NOT Deleted")
                    End If

                Else



                    Dim delete_command As New MySqlCommand("DELETE FROM doctrack" & FormOfficeDocs.yearCB.Text & "outgoingtb WHERE `No`=@NO", connection)
                    delete_command.Parameters.Add("@NO", MySqlDbType.Int64).Value = addform.NoLbl.Text

                    Dim log_command As New MySqlCommand("INSERT INTO logs ( `ReferenceNo`,`Action`,`Name`) 
                                        VALUES (@REF,@AC,@NM)", connection)

                    log_command.Parameters.Add("@REF", MySqlDbType.VarChar).Value = addform.refTB.Text
                    log_command.Parameters.Add("@AC", MySqlDbType.VarChar).Value = logdelete
                    log_command.Parameters.Add("@NM", MySqlDbType.VarChar).Value = DocTrackLogin.TxtBoxUsername.Text

                    connection.Open()


                    If delete_command.ExecuteNonQuery() And log_command.ExecuteNonQuery = 1 Then
                        MessageBox.Show("Data Successfully Deleted!")
                        addform.delete_clearTxts()
                        refreshdataAfterDeleting()
                        Me.Close()
                    Else
                        MessageBox.Show("Data NOT Deleted")
                    End If
                End If

                connection.Close()
            Else
                delPassTxt.Clear()
            End If

            Me.Close()

        Else
            Dim result2 = MessageBox.Show("Incorrect!", "WARNING", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
            If (result2 = DialogResult.Cancel) Then

                Me.Close()

            Else
                delPassTxt.Select()
                delPassTxt.Clear()
            End If
        End If
    End Sub

    Private Sub deleteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = BtnEnter
    End Sub

    Sub refreshdataAfterDeleting()

        RefreshDataGridView()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        delPassTxt.Clear()
        Me.Close()
    End Sub


End Class