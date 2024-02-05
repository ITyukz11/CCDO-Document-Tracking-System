Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Public Class Addform



    Dim logupdate = "Updated"
    Dim logsave = "Saved"



    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click


        If particularTB.Text = String.Empty And refTB.Text = String.Empty Then
            MessageBox.Show("Cannot Save Empty Particulars and Reference No", "D mag kalimot kalimot", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else


            If FormOfficeDocs.inc_out_CB.Text = "Incoming" Then 'INCOMING


                Dim command As New MySqlCommand("INSERT INTO doctrack" & FormOfficeDocs.yearCB.Text & "incomingtb( `Particulars`, `ReferenceNo`,`Date`, `SubmittedBy`, `Division`, `District`, `ForwardedTo`, `Remarks`, `DateReceived`,`TransactionType`) 
                                        VALUES (@PRT,@REF,@DTE,@SBT,@DIV,@DIS,@FRW,@RMK,@DR,@TT)", connection)

                ' filling addItemTB Database table
                command.Parameters.Add("@PRT", MySqlDbType.VarChar).Value = particularTB.Text
                command.Parameters.Add("@REF", MySqlDbType.VarChar).Value = refTB.Text
                command.Parameters.Add("@DTE", MySqlDbType.VarChar).Value = dateTb.Text
                command.Parameters.Add("@SBT", MySqlDbType.VarChar).Value = subTB.Text
                command.Parameters.Add("@DIV", MySqlDbType.VarChar).Value = divTB.Text
                command.Parameters.Add("@DIS", MySqlDbType.VarChar).Value = districtTB.Text
                command.Parameters.Add("@FRW", MySqlDbType.VarChar).Value = forwardTB.Text
                command.Parameters.Add("@RMK", MySqlDbType.VarChar).Value = remarksTB.Text
                ' command.Parameters.Add("@FN", MySqlDbType.VarChar).Value = pathTxt.Text
                command.Parameters.Add("@DR", MySqlDbType.VarChar).Value = dateRRTB.Text
                command.Parameters.Add("@TT", MySqlDbType.Text).Value = TransactionCB.Text


                Dim log_command As New MySqlCommand("INSERT INTO logs ( `ReferenceNo`,`Document`,`Action`,`Name`) 
                                        VALUES (@REF,@YR,@AC,@NM)", connection)

                log_command.Parameters.Add("@REF", MySqlDbType.VarChar).Value = refTB.Text
                log_command.Parameters.Add("@AC", MySqlDbType.VarChar).Value = logsave
                log_command.Parameters.Add("@YR", MySqlDbType.VarChar).Value = FormOfficeDocs.yearCB.Text & "/" & FormOfficeDocs.inc_out_CB.Text
                log_command.Parameters.Add("@NM", MySqlDbType.VarChar).Value = DocTrackLogin.TxtBoxUsername.Text


                connection.Open()

                'check if data is inserted to database

                If command.ExecuteNonQuery() And log_command.ExecuteNonQuery = 1 Then

                    MessageBox.Show("Successfully Saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'clear Txts code on module1
                    addform_save_clearTxts()
                Else
                    MessageBox.Show("not saved!")

                End If

            Else 'OUTGOING

                Dim command As New MySqlCommand("INSERT INTO doctrack" & FormOfficeDocs.yearCB.Text & "outgoingtb(`Particulars`, `ReferenceNo`,`Date`, `SubmittedBy`, `Division`, `District`, `ForwardedTo`, `Remarks`, `DateReleased`,`TransactionType`) 
                                        VALUES (@PRT,@REF,@DTE,@SBT,@DIV,@DIS,@FRW,@RMK,@DR,@TT)", connection)

                ' filling addItemTB Database table
                command.Parameters.Add("@PRT", MySqlDbType.VarChar).Value = particularTB.Text
                command.Parameters.Add("@REF", MySqlDbType.VarChar).Value = refTB.Text
                command.Parameters.Add("@DTE", MySqlDbType.VarChar).Value = dateTb.Text
                command.Parameters.Add("@SBT", MySqlDbType.VarChar).Value = subTB.Text
                command.Parameters.Add("@DIV", MySqlDbType.VarChar).Value = divTB.Text
                command.Parameters.Add("@DIS", MySqlDbType.VarChar).Value = districtTB.Text
                command.Parameters.Add("@FRW", MySqlDbType.VarChar).Value = forwardTB.Text
                command.Parameters.Add("@RMK", MySqlDbType.VarChar).Value = remarksTB.Text
                'command.Parameters.Add("@FN", MySqlDbType.VarChar).Value = pathTxt.Text
                command.Parameters.Add("@DR", MySqlDbType.VarChar).Value = dateRRTB.Text
                command.Parameters.Add("@TT", MySqlDbType.Text).Value = TransactionCB.Text

                Dim log_command As New MySqlCommand("INSERT INTO logs ( `ReferenceNo`,`Document`,`Action`,`Name`) 
                                        VALUES (@REF,@YR,@AC,@NM)", connection)

                log_command.Parameters.Add("@REF", MySqlDbType.VarChar).Value = refTB.Text
                log_command.Parameters.Add("@AC", MySqlDbType.VarChar).Value = logsave
                log_command.Parameters.Add("@YR", MySqlDbType.VarChar).Value = FormOfficeDocs.yearCB.Text & "/" & FormOfficeDocs.inc_out_CB.Text
                log_command.Parameters.Add("@NM", MySqlDbType.VarChar).Value = DocTrackLogin.TxtBoxUsername.Text

                connection.Open()

                'check if data is inserted to database

                If command.ExecuteNonQuery() And log_command.ExecuteNonQuery = 1 Then

                    MessageBox.Show("Successfully Saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'clear Txts code on module1
                    addform_save_clearTxts()
                Else
                    MessageBox.Show("not saved!")

                End If


            End If

        End If




        'close connection
        connection.Close()

    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click



        dateTb.Clear()
        districtTB.Clear()
        forwardTB.Clear()
        remarksTB.Clear()
        particularTB.Clear()
        ' refTB.Clear()
        subTB.Clear()
        divTB.Clear()
        'dateRRTB.Clear()


        ''ABOUTPDF AxAcroPDF1.LoadFile("DONTEXISTS.pdf")




        FormOfficeDocs.DataGridView1.Sort(FormOfficeDocs.DataGridView1.Columns(0), ListSortDirection.Descending)
        FormOfficeDocs.DataGridView1.Rows(OfficeDGVIndex).Selected = True
        updateBTN.Enabled = False
        deleteBtn.Enabled = False
        If FormOfficeDocs.SearchTB.ForeColor = Color.Black Then
            SearchOfficeDocuments()

            Me.Close()
        ElseIf BlankSearch = True Then
            BlankSearchRefreshDataGridView()

            Me.Close()
        Else
            RefreshDataGridView()

            Me.Close()
        End If
        FormOfficeDocs.DataGridView1.Rows(OfficeDGVIndex).Selected = True

    End Sub

    'ABOUT PDF FILE
    ' Private Sub BrowseBtn_Click(sender As Object, e As EventArgs) Handles BrowseBtn.Click
    '
    '     If pathTxt.Text = "" Then
    '         Try
    '
    '             OpenFileDialog1.Filter = " Choose File (*.pdf) | *.pdf;"
    '             OpenFileDialog1.FileName = ""
    '             OpenFileDialog1.Title = "Select File Pdf.."
    '
    '             If OpenFileDialog1.ShowDialog = DialogResult.OK Then
    '                 '  AxAcroPDFLib.AxAcroPDF Is Not defined
    '
    '                 pathTxt.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
    '                 pdfName.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
    '                 AxAcroPDF1.src = PDF_FILE
    '                 AxAcroPDF1.src = OpenFileDialog1.FileName
    '             End If
    '         Catch ex As Exception
    '             MsgBox(ex.Message)
    '         End Try
    '     Else
    '         deleteForm.Show()
    '
    '
    '     End If
    '
    '
    '
    '
    ' End Sub
    '  Private Sub viewBtn_Click(sender As Object, e As EventArgs) Handles viewBtn.Click
    '      If pathTxt.Text = "" And pdfName.Text = "" Then
    '          MsgBox("Nothing to view!", MsgBoxStyle.Exclamation, "Access Denied!!")
    '      Else
    '          PDF_FILE = AxAcroPDF1.src
    '          FormViewPDF.AxAcroPDF2.src = PDF_FILE
    '
    '          FormViewPDF.ShowDialog()
    '      End If
    '  End Sub

    '  Private Sub printBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
    '      If pathTxt.Text = "" And pdfName.Text = "" Then
    '          MsgBox("Nothing to print!", MsgBoxStyle.Exclamation, "Access Denied!!")
    '      Else
    '          AxAcroPDF1.Print()
    '          MsgBox("wtf!", MsgBoxStyle.Exclamation, "Access Denied!!")
    '      End If
    '  End Sub

    Private Sub UpdateBTN_Click(sender As Object, e As EventArgs) Handles updateBTN.Click

        If particularTB.Text = String.Empty And refTB.Text = String.Empty Then
            MessageBox.Show("Cannot Update Empty Particulars and Reference No", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            connection.Open()

            Dim command As New MySqlCommand("UPDATE `doctrack" & FormOfficeDocs.yearCB.Text & "" & FormOfficeDocs.inc_out_CB.Text & "tb` 
           SET `Particulars`= '" & particularTB.Text & "',
           `ReferenceNo`= '" & refTB.Text & "',
           `Date`= '" & dateTb.Text & "',
           `SubmittedBy`= '" & subTB.Text & "',
           `Division`= '" & divTB.Text & "',
           `District`= '" & districtTB.Text & "',
           `ForwardedTo`='" & forwardTB.Text & "',
           `Remarks`='" & remarksTB.Text & "',
           `" & DateReceived_or_Released & "`='" & dateRRTB.Text & "',
           `TransactionType`='" & TransactionCB.Text & "'
            WHERE `No`= '" & NoLbl.Text & "'", connection)


            Dim log_command As New MySqlCommand("INSERT INTO logs ( `ReferenceNo`,`Document`,`Action`,`Name`) 
                                         VALUES (@REF,@YR,@AC,@NM)", connection)

            log_command.Parameters.Add("@REF", MySqlDbType.VarChar).Value = refTB.Text
            log_command.Parameters.Add("@AC", MySqlDbType.VarChar).Value = logupdate
            log_command.Parameters.Add("@YR", MySqlDbType.VarChar).Value = FormOfficeDocs.yearCB.Text & "/" & FormOfficeDocs.inc_out_CB.Text
            log_command.Parameters.Add("@NM", MySqlDbType.VarChar).Value = DocTrackLogin.TxtBoxUsername.Text


            Try
                If command.ExecuteNonQuery() And log_command.ExecuteNonQuery = 1 Then
                    MessageBox.Show("Successfully Updated!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    connection.Close()
                    If FormOfficeDocs.SearchTB.Text = "Search document here" Then
                        If BlankSearch = True Then
                            BlankSearchRefreshDataGridView()
                            Me.Close()
                        Else
                            RefreshDataGridView()
                            Me.Close()
                        End If

                    Else
                        SearchOfficeDocuments()
                        Me.Close()
                    End If
                    FormOfficeDocs.DataGridView1.Sort(FormOfficeDocs.DataGridView1.Columns(0), ListSortDirection.Descending)
                    FormOfficeDocs.DataGridView1.Rows(OfficeDGVIndex).Selected = True




                End If
            Catch ex As MySqlException
                MessageBox.Show("Fail to update! Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            connection.Close()

        End If





    End Sub
    Sub delete_clearTxts()
        districtTB.Clear()
        forwardTB.Clear()
        remarksTB.Clear()
        particularTB.Clear()
        refTB.Clear()
        subTB.Clear()
        divTB.Clear()
        dateRRTB.Clear()
        Me.Hide()
    End Sub
    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        deleteForm.ShowDialog()
        deleteForm.delPassTxt.Clear()
        deleteForm.delPassTxt.Select()
    End Sub


    Private Sub addform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Whenever client opens the add form, particular text box would be selected and insertion point would be place to last
        particularTB.Select()
        particularTB.SelectionStart = particularTB.TextLength










        If FormOfficeDocs.inc_out_CB.SelectedIndex = 0 Then
            dateRRLB.Text = "Date Received:"
        Else
            dateRRLB.Text = "Date Released:"
        End If

    End Sub

    Private Sub closeXbtn_Click(sender As Object, e As EventArgs)
        dateTb.Clear()
        districtTB.Clear()
        forwardTB.Clear()
        remarksTB.Clear()
        particularTB.Clear()
        refTB.Clear()
        subTB.Clear()
        divTB.Clear()
        dateRRTB.Clear()

        'Aboutpdf AxAcroPDF1.LoadFile("DONTEXISTS.pdf")


        Me.Close()
    End Sub

    Private Sub addform_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        dateTb.Clear()
        districtTB.Clear()
        forwardTB.Clear()
        remarksTB.Clear()
        particularTB.Clear()
        ' refTB.Clear()
        subTB.Clear()
        divTB.Clear()
        '  dateRRTB.Clear()

        'aboutpdf pathTxt.Clear()
        ' aboutpdf  pdfName.Clear()
        ' aboutpdf   AxAcroPDF1.LoadFile("DONTEXISTS.pdf")


        Me.Close()
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs)

    End Sub
End Class