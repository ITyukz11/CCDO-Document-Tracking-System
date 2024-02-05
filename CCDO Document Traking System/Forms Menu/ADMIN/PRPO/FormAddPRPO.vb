
Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Public Class FormAddPRPO

    Public PDF_FILE
    Dim CBstatus_Changed = False
    Dim DateUpdated = Date.Now.ToString("yyyy/MM/dd HH:mm:ss")
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        RefreshDataGridViewPRPO()

        NoLbl.Text = ""
        CBupdateStatus.Checked = False

        Me.Close()

    End Sub



    Sub clearTxt()

        PRDetailsTxt.Clear()
        DNumberTxt.Clear()
        DPDraftPRTxt.Clear()
        DRFinalPRTxt.Clear()
        PRNumberTxt.Clear()
        DPCDraftTxt.Clear()
        DPCFinalTxt.Clear()
        DProcessedPOTxt.Clear()
        DApprovePOTxt.Clear()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click


        If PRDetailsTxt.Text = String.Empty And PRNumberTxt.Text = String.Empty Then
            MessageBox.Show("Cannot Save Empty P.R Draft Details", "D mag kalimot kalimot", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            If DocTrackLogin.TxtBoxUsername.Text = "" Then

                MessageBox.Show("You are not logged in!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Dim result = MessageBox.Show("Do you want to logged in ?", "Pangutanang e tubag", MessageBoxButtons.YesNo, MessageBoxIcon.Question)



                If (result = DialogResult.Yes) Then

                    FormMainMenu.ProfilePictureBox.Image = Nothing
                    DocTrackLogin.TxtBoxUsername.Clear()
                    DocTrackLogin.TxtBoxPassword.Clear()
                    DocTrackLogin.TxtBoxUsername.Select()



                    Me.Hide()
                    FormMainMenu.Hide()
                    DocTrackLogin.Show()



                End If
            Else
                    Dim command As New MySqlCommand("INSERT INTO `pr_po` (`No`,`PR_details`, `Doctrack#`, `DateProcessed_Draft_PR`, `DateReturned_Final_PR`, `PR#`, 
`DateProcessed_CanvasDraft`, `DateProcessed_CanvasFinal`, `DateProcessed_PO`, `DateApproved_PO`, `Date`, `Status`) 
                                        VALUES (@NO,@PRD,@DNO,@DPDPR,@DRFPR,@PRNo,@DPCD,@DPCF,@DPPO,@DAPO,@DTE, @STAT)", connection)

                ' filling pr_po Database table
                command.Parameters.Add("@NO", MySqlDbType.VarChar).Value = NoLbl.Text
                command.Parameters.Add("@PRD", MySqlDbType.VarChar).Value = PRDetailsTxt.Text
                command.Parameters.Add("@DNO", MySqlDbType.VarChar).Value = DNumberTxt.Text
                command.Parameters.Add("@DPDPR", MySqlDbType.VarChar).Value = DPDraftPRTxt.Text
                command.Parameters.Add("@DRFPR", MySqlDbType.VarChar).Value = DRFinalPRTxt.Text
                command.Parameters.Add("@PRNo", MySqlDbType.VarChar).Value = PRNumberTxt.Text
                command.Parameters.Add("@DPCD", MySqlDbType.VarChar).Value = DPCDraftTxt.Text
                command.Parameters.Add("@DPCF", MySqlDbType.VarChar).Value = DPCFinalTxt.Text
                command.Parameters.Add("@DPPO", MySqlDbType.VarChar).Value = DProcessedPOTxt.Text
                command.Parameters.Add("@DAPO", MySqlDbType.VarChar).Value = DApprovePOTxt.Text
                command.Parameters.Add("@DTE", MySqlDbType.VarChar).Value = dateTxt.Text
                command.Parameters.Add("@STAT", MySqlDbType.VarChar).Value = "Encoded by: " & DocTrackLogin.TxtBoxUsername.Text



                Dim command2 As New MySqlCommand("INSERT INTO `logs_admin`(`ForeignNo`,`Details`, `Date`, `Action`, `User`, `Status`) VALUES (@FNO,@DET,@DTE,@ACT,@USR,@STA)", connection)

                ' filling logsadmin Database table
                command2.Parameters.Add("@FNO", MySqlDbType.VarChar).Value = NoLbl.Text
                command2.Parameters.Add("@DET", MySqlDbType.VarChar).Value = PRDetailsTxt.Text
                command2.Parameters.Add("@DTE", MySqlDbType.VarChar).Value = dateTxt.Text
                command2.Parameters.Add("@ACT", MySqlDbType.VarChar).Value = "Save"
                command2.Parameters.Add("@USR", MySqlDbType.VarChar).Value = DocTrackLogin.TxtBoxUsername.Text
                command2.Parameters.Add("@STA", MySqlDbType.VarChar).Value = "Encoded by: " & DocTrackLogin.TxtBoxUsername.Text

                Dim command3 As New MySqlCommand("INSERT INTO `pr_po_status_guide`(`ForeignNo`, `Status`,`Status2`,`Status3`,`Status4`,`DateEncoded`,`DateUpdated`,`ProcessedTime`) 
                                                VALUES (@FNO,@STAT,@STAT2,@STAT3,@STAT4,@DTC,@DUP,@PRT)", connection)

                ' filling logsadmin Database table
                command3.Parameters.Add("@FNO", MySqlDbType.VarChar).Value = NoLbl.Text
                command3.Parameters.Add("@STAT", MySqlDbType.VarChar).Value = "Encoded by: " & DocTrackLogin.TxtBoxUsername.Text
                command3.Parameters.Add("@STAT2", MySqlDbType.VarChar).Value = "_____________________"
                command3.Parameters.Add("@STAT3", MySqlDbType.VarChar).Value = "_____________________"
                command3.Parameters.Add("@STAT4", MySqlDbType.VarChar).Value = "_____________________"
                command3.Parameters.Add("@DTC", MySqlDbType.VarChar).Value = "Date Encoded: " & dateTxt.Text
                command3.Parameters.Add("@DUP", MySqlDbType.VarChar).Value = "Date Updated:" & dateTxt.Text
                command3.Parameters.Add("@PRT", MySqlDbType.VarChar).Value = ""


                connection.Open()


                'check if data is inserted to database

                If command.ExecuteNonQuery() And command2.ExecuteNonQuery() And command3.ExecuteNonQuery = 1 Then

                    MessageBox.Show("Successfully Saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'clear Txts code on module1
                    clearTxt()
                    NoLbl.Text = Convert.ToInt32(NoLbl.Text) + 1


                Else
                    MessageBox.Show("not saved! ask help for yowki")

                End If


            End If

        End If




        'close connection
        connection.Close()

    End Sub



    Private Sub updateBTN_Click(sender As Object, e As EventArgs) Handles updateBTN.Click
        If PRDetailsTxt.Text = String.Empty And DNumberTxt.Text = String.Empty Then
            MessageBox.Show("Cannot Save Empty P.R Draft Details", "D mag kalimot kalimot", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else


            Dim command As New MySqlCommand("UPDATE `pr_po` SET `PR_details`= @PRD,`Doctrack#`=@DNO,`DateProcessed_Draft_PR`=@DPDPR,`DateReturned_Final_PR`=@DRFPR,
                                               `PR#`=@PRNo,`DateProcessed_CanvasDraft`=@DPCD,`DateProcessed_CanvasFinal`=@DPCF,`DateProcessed_PO`=@DPPO,
                                            `DateApproved_PO`=@DAPO, `Status`=@STAT WHERE `No`=@NO", connection)

            command.Parameters.Add("@NO", MySqlDbType.VarChar).Value = NoLbl.Text
            command.Parameters.Add("@PRD", MySqlDbType.VarChar).Value = PRDetailsTxt.Text
            command.Parameters.Add("@DNO", MySqlDbType.VarChar).Value = DNumberTxt.Text
            command.Parameters.Add("@DPDPR", MySqlDbType.VarChar).Value = DPDraftPRTxt.Text
            command.Parameters.Add("@DRFPR", MySqlDbType.VarChar).Value = DRFinalPRTxt.Text
            command.Parameters.Add("@PRNo", MySqlDbType.VarChar).Value = PRNumberTxt.Text
            command.Parameters.Add("@DPCD", MySqlDbType.VarChar).Value = DPCDraftTxt.Text
            command.Parameters.Add("@DPCF", MySqlDbType.VarChar).Value = DPCFinalTxt.Text
            command.Parameters.Add("@DPPO", MySqlDbType.VarChar).Value = DProcessedPOTxt.Text
            command.Parameters.Add("@DAPO", MySqlDbType.VarChar).Value = DApprovePOTxt.Text
            command.Parameters.Add("@STAT", MySqlDbType.VarChar).Value = StatusTxt.Text


            Dim commandStatUpdate As New MySqlCommand("UPDATE `pr_po_status_guide` SET `DateUpdated`=@DUP WHERE `ForeignNo` = @FNO", connection)
            commandStatUpdate.Parameters.Add("@FNO", MySqlDbType.VarChar).Value = NoLbl.Text
            commandStatUpdate.Parameters.Add("@DUP", MySqlDbType.VarChar).Value = Date.Now.ToString("yyyy/MM/dd HH:mm:ss")



            Dim command2 As New MySqlCommand("INSERT INTO `logs_admin`(`ForeignNo`,`Details`, `Date`, `Action`, `User`, `Status`) VALUES (@FNO,@DET,@DTE,@ACT,@USR,@STA)", connection)

            ' filling logsadmin Database table
            command2.Parameters.Add("@FNO", MySqlDbType.VarChar).Value = NoLbl.Text
            command2.Parameters.Add("@DET", MySqlDbType.VarChar).Value = PRDetailsTxt.Text
            command2.Parameters.Add("@DTE", MySqlDbType.VarChar).Value = dateTxt.Text
            command2.Parameters.Add("@ACT", MySqlDbType.VarChar).Value = "Update"
            command2.Parameters.Add("@USR", MySqlDbType.VarChar).Value = DocTrackLogin.TxtBoxUsername.Text
            command2.Parameters.Add("@STA", MySqlDbType.VarChar).Value = StatusTxt.Text

            connection.Open()
            If CBstatus_Changed = True Then

                If CBstatus.Text = "Ma'am Luz for Signature" Then
                    Dim commandStat2 As New MySqlCommand("UPDATE `pr_po_status_guide` SET `Status2`= @STAT2, `DateUpdated`=@DUP WHERE `ForeignNo` = @FNO", connection)
                    commandStat2.Parameters.Add("@FNO", MySqlDbType.VarChar).Value = NoLbl.Text
                    commandStat2.Parameters.Add("@STAT2", MySqlDbType.VarChar).Value = StatusTxt.Text
                    commandStat2.Parameters.Add("@DUP", MySqlDbType.VarChar).Value = "Date Updated: " & DateUpdated

                    commandStat2.ExecuteNonQuery()

                ElseIf LBLstatGuide3.Text = "_____________________" And LBLstatGuide2.Text = "Ma'am Luz for Signature" Then
                    Dim commandStat3 As New MySqlCommand("UPDATE `pr_po_status_guide` SET `Status3`= @STAT3, `DateUpdated`=@DUP WHERE `ForeignNo` = @FNO", connection)
                    commandStat3.Parameters.Add("@FNO", MySqlDbType.VarChar).Value = NoLbl.Text
                    commandStat3.Parameters.Add("@STAT3", MySqlDbType.VarChar).Value = StatusTxt.Text
                    commandStat3.Parameters.Add("@DUP", MySqlDbType.VarChar).Value = "Date Updated: " & DateUpdated

                    commandStat3.ExecuteNonQuery()
                ElseIf LBLstatGuide4.Text = "_____________________" And CBstatus.SelectedIndex = 1 Or CBstatus.SelectedIndex = 2 Then
                    Dim commandStat4 As New MySqlCommand("UPDATE `pr_po_status_guide` SET `Status4`= @STAT4, `DateUpdated`=@DUP,`ProcessedTime`=@PRT  WHERE `ForeignNo` = @FNO", connection)

                    'getting difference between 2 dates for processed time
                    Dim date2 As Date = Date.Parse(DateUpdated)
                    Dim date1 As Date = dateTxt.Text
                    Dim processedTime As Long = DateDiff(DateInterval.Day, date1, date2)

                    commandStat4.Parameters.Add("@FNO", MySqlDbType.VarChar).Value = NoLbl.Text
                    commandStat4.Parameters.Add("@STAT4", MySqlDbType.VarChar).Value = StatusTxt.Text
                    commandStat4.Parameters.Add("@DUP", MySqlDbType.VarChar).Value = "Date Updated: " & DateUpdated
                    commandStat4.Parameters.Add("@PRT", MySqlDbType.VarChar).Value = "Processed Time: " & processedTime & "days"




                    commandStat4.ExecuteNonQuery()
                End If

            End If

            'check if data is inserted to database
            Try
                command.ExecuteNonQuery()
                command2.ExecuteNonQuery()
                commandStatUpdate.ExecuteNonQuery()

                MessageBox.Show("Successfully Updated!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    updateBTN.Select()
                '  pr_po_statusGuide()
                CBupdateStatus.Checked = False

            Catch ex As Exception
                    MessageBox.Show("Failed to UPDATE! Please contact your I.T", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If


            'close connection
            connection.Close()
    End Sub



    Private Sub FormAddPRPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        'authorizing to update status
        Dim user = DocTrackLogin.TxtBoxUsername.Text

        Select Case user
            Case "janry"
                CBstatus.Items.AddRange(items:={"Received by: Janry", "CBO Received", "GSO Received"})
            Case "lhem"
                CBstatus.Items.AddRange(items:={"Received by: Lhem", "CBO Received", "GSO Received"})
            Case "leah"
                CBstatus.Items.AddRange(items:={"Received by: Leah", "CBO Received", "GSO Received"})
            Case "marissa"
                CBstatus.Items.AddRange(items:={"Received by: Marissa", "CBO Received", "GSO Received"})
            Case "christine"
                CBstatus.Items.AddRange(items:={"Received by: Christine", "CBO Received", "GSO Received"})
            Case "dimple"
                CBstatus.Items.AddRange(items:={"Ma'am Luz for Signature"})
            Case "Damyu"
                CBstatus.Items.AddRange(items:={"Ma'am Luz for Signature"})
            Case "che"
                CBstatus.Items.AddRange(items:={"Ma'am Luz for Signature"})
            Case Else
                CBupdateStatus.Enabled = False
        End Select


        CBstatus.Enabled = False

    End Sub

    Private Sub CBupdateStatus_CheckedChanged(sender As Object, e As EventArgs) Handles CBupdateStatus.CheckedChanged
        'Enabling Logged In user to update document status
        If CBupdateStatus.Checked Then

            If DocTrackLogin.TxtBoxUsername.Text = "" Then
                MessageBox.Show("You are not logged in!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                CBupdateStatus.Checked = False
            Else
                CBstatus.Enabled = True
                StatusTxt.Enabled = True
            End If
        Else
            CBstatus.Enabled = False
            StatusTxt.Enabled = False
        End If
    End Sub


    'handles when form is closed
    Private Sub FormAddPRPO_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        NoLbl.Text = ""
        CBupdateStatus.Checked = False
    End Sub


    Private Sub CBstatus_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBstatus.SelectedValueChanged
        CBstatus_Changed = True
    End Sub

    Private Sub CBstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBstatus.SelectedIndexChanged
        StatusTxt.Text = CBstatus.Text
    End Sub


    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        '   showLogPRPObaseOnFNO()
        '    FormAdminLogs.Show()
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Dim result = MessageBox.Show("Are you sure you want to delete?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        If (result = DialogResult.Yes) Then


            Dim result2 = MessageBox.Show("All the documents of this item will be deleted, still continue?", "Sure najud?!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

            Dim delete_command As New MySqlCommand("DELETE FROM `pr_po` WHERE `No` = " & NoLbl.Text & "", connection)

            Dim command As New MySqlCommand("DELETE FROM `pr_po_status_guide` WHERE `No` = " & NoLbl.Text & "", connection)

            Dim command2 As New MySqlCommand("INSERT INTO `logs_admin`( `ForeignNo`, `Details`, `Date`, `Action`, `User`, `Status`) 
                                VALUES (@FNO,@DET,@DAT,@ACT,@USR,@STAT)", connection)

            command2.Parameters.Add("@FNO", MySqlDbType.VarChar).Value = NoLbl.Text
            command2.Parameters.Add("@DET", MySqlDbType.VarChar).Value = PRDetailsTxt.Text
            command2.Parameters.Add("@DAT", MySqlDbType.VarChar).Value = dateTxt.Text
            command2.Parameters.Add("@ACT", MySqlDbType.VarChar).Value = "Deleted"
            command2.Parameters.Add("@USR", MySqlDbType.VarChar).Value = DocTrackLogin.TxtBoxUsername.Text
            command2.Parameters.Add("@STAT", MySqlDbType.VarChar).Value = StatusTxt.Text

            connection.Open()

            Try
                delete_command.ExecuteNonQuery()
                command.ExecuteNonQuery()
                command2.ExecuteNonQuery()

                MessageBox.Show("Data Successfully Deleted!", "Form Add PR PO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NoLbl.Text = ""
                RefreshDataGridViewPRPO()
                Me.Hide()

            Catch ex As Exception


                MessageBox.Show("Data not Deleted!", "Form Add PR PO", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End Try




            connection.Close()

        End If

        Me.Hide()
    End Sub
End Class