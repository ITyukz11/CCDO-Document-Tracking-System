
Imports System.ComponentModel
Imports System.IO
Imports MySql.Data.MySqlClient


Module Module1

    Public connection As MySqlConnection

    Public ProfilePictureSave As String

    Public OfficeDGVIndex As Integer

    Public PDF_FILE

    Public DateReceived_or_Released As String



    Public BlankSearch As Boolean


    Public DoctrackServer As String = "\\192.168.167.48\Users\DOCTRACK SERVER\"
    Public DoctrackServerImage As String = "\\192.168.167.48\Users\DOCTRACK SERVER\Profile\"


    'Progress Report 
    Const TotalDocs2016Incoming = 1872
    Const TotalDocs2016Outgoing = 524

    Const TotalDocs2017Incoming = 3240
    Const TotalDocs2017Outgoing = 900

    Const TotalDocs2018Incoming = 4558
    Const TotalDocs2018Outgoing = 800

    Const TotalDocs2019Incoming = 4384
    Const TotalDocs2019Outgoing = 1084

    Const TotalDocs2020Incoming = 2311
    Const TotalDocs2020Outgoing = 744

    Const TotalDocs2021Incoming = 1971
    Const TotalDocs2021Outgoing = 662

    Const TotalDocs2022Incoming = 3624
    Const TotalDocs2022Outgoing = 1336



    Sub OpenConnection()

        'Database Info
        Dim Server As String = "192.168.167.48" 'yukz pc 192.168.167.106 (LEAH server -> "192.168.167.21" /  '192.168.167.41  / 192.168.167.35 if WIFI network
        Dim Database As String = "doctrackdb"
        Dim username As String = "root"
        Dim password As String = ""
        Dim port As String = "3306"

        Try
            Dim query As String = "Server=" & Server & ";Database=" & Database & "; username=" & username & ";password=" & password & "; port=" & port & ";Convert Zero Datetime=True"
            connection = New MySqlConnection(query)
            If connection.State = ConnectionState.Closed Then
                connection.Open()
                ' MessageBox.Show("LOADING, Sorry computer is lagging", "WARNING",
                'MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception



            Dim result = MessageBox.Show("Cannot connect to Database! Please check your LAN or WIFI connection", "Closing Program", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation)

            If (result = DialogResult.Retry) Then

                RefreshDataGridView()

            Else
                Application.Exit()
            End If

        End Try
    End Sub


    Sub RefreshDataGridView()

        OpenConnection()




        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `No`, `Particulars`,  `ReferenceNo` FROM doctrack" & FormOfficeDocs.yearCB.Text & "" & FormOfficeDocs.inc_out_CB.Text & "tb ORDER BY `No` DESC LIMIT 20", connection)
        adapter.Fill(table)
            FormOfficeDocs.DataGridView1.DataSource = table

            Dim cmd As New MySqlCommand("Select COUNT(*) FROM doctrack" & FormOfficeDocs.yearCB.Text & "" & FormOfficeDocs.inc_out_CB.Text & "tb", connection)
            Dim i As Integer = cmd.ExecuteScalar()
            cmd = Nothing
            connection.Close()
        FormOfficeDocs.NoTxt.Text = i

        FormOfficeDocs.DataGridView1.Sort(FormOfficeDocs.DataGridView1.Columns(0), ListSortDirection.Descending)


        FormOfficeDocs.DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        FormOfficeDocs.DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FormOfficeDocs.DataGridView1.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells





    End Sub

    Sub BlankSearchRefreshDataGridView()

        OpenConnection()




        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `No`, `Particulars`,  `ReferenceNo` FROM doctrack" & FormOfficeDocs.yearCB.Text & "" & FormOfficeDocs.inc_out_CB.Text & "tb", connection)
        adapter.Fill(table)
        FormOfficeDocs.DataGridView1.DataSource = table

        connection.Close()

        FormOfficeDocs.DataGridView1.Sort(FormOfficeDocs.DataGridView1.Columns(0), ListSortDirection.Descending)
        FormOfficeDocs.DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        FormOfficeDocs.DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FormOfficeDocs.DataGridView1.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells





    End Sub


    Sub Signup()
        OpenConnection()
        Dim command As New MySqlCommand("INSERT INTO `user`(`user`, `pass`, `DivisionDistrict`, `profilePicture`) 
                                        VALUES (@USR, @PSS, @DDT, @PFP)", connection)

        ' filling profile Database table
        command.Parameters.Add("@USR", MySqlDbType.VarChar).Value = FormSignUp.UsernameTxt.Text
        command.Parameters.Add("@PSS", MySqlDbType.VarChar).Value = FormSignUp.PasswordTxt.Text
        command.Parameters.Add("@DDT", MySqlDbType.VarChar).Value = FormSignUp.DivDistTxt.Text
        command.Parameters.Add("@PFP", MySqlDbType.VarChar).Value = ProfilePictureSave







        'check if data is inserted to database

        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Registered Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)


            FormSignUp.UsernameTxt.Clear()
            FormSignUp.PasswordTxt.Clear()
            FormSignUp.ReTypePasswordTxt.Clear()
            FormSignUp.DivDistTxt.Clear()
            FormSignUp.AdminPasswordTxt.Clear()
            FormSignUp.ProfilePicFilePath.Clear()
            '  FormSignUp.ProfilePictureBox.Nothing()
            FormSignUp.Hide()
            connection.Close()
        Else
            MessageBox.Show("not saved! ask help for yowki")

        End If
    End Sub
    Sub DisplayProfilePicture()
        OpenConnection()


        Try
            'getting string in database 
            Dim cmd As New MySqlCommand("Select * FROM user WHERE user = '" & DocTrackLogin.TxtBoxUsername.Text & "'", connection)
            Dim reader = cmd.ExecuteReader

            While reader.Read()

                FormMainMenu.ProfilePictureBoxFilePath.Text = reader.Item(4)

                'loads profile picture from filepath


            End While
            reader.Close()
            cmd.Dispose()
            connection.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try



    End Sub
    Sub DisplayProfile()


        Try
            OpenConnection()


            'getting string in database 
            Dim cmd As New MySqlCommand("Select * FROM user WHERE user = '" & DocTrackLogin.TxtBoxUsername.Text & "'", connection)

            Dim reader = cmd.ExecuteReader


            While reader.Read()
                FormProfile.UsernameTxt.Text = reader.Item(1)
                FormProfile.currentPassword = reader.Item(2)
                FormProfile.DivDistTxt.Text = reader.Item(3)


            End While



            connection.Close()
            reader.Close()
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End Try

        FormProfile.ShowDialog()



    End Sub

    Sub DisplayProfile2()
        Dim command As New MySqlCommand("SELECT  `user`, `Image` FROM `user` WHERE `user` = '" & DocTrackLogin.TxtBoxUsername.Text & "'", connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()



        Dim imgByte() As Byte
        Try

            adapter.Fill(table)
            If table.Rows.Count = 1 Then

                imgByte = table(0)(1)

                Dim ms As New MemoryStream(imgByte)
                FormProfile.ProfilePictureBox.Image = Image.FromStream(ms)

                connection.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub


    Sub ProgressReport()


        OpenConnection()

        Dim cmd As New MySqlCommand("Select COUNT(*) FROM doctrack2016incomingtb", connection)
        Dim CurrentIncoming2016 As Integer = cmd.ExecuteScalar()

        Dim cmd1 As New MySqlCommand("Select COUNT(*) FROM doctrack2016outgoingtb", connection)
        Dim CurrentOutgoing2016 As Integer = cmd1.ExecuteScalar()

        Dim cmd2 As New MySqlCommand("Select COUNT(*) FROM doctrack2017incomingtb", connection)
        Dim CurrentIncoming2017 As Integer = cmd2.ExecuteScalar()

        Dim cmd3 As New MySqlCommand("Select COUNT(*) FROM doctrack2017outgoingtb", connection)
        Dim CurrentOutgoing2017 As Integer = cmd3.ExecuteScalar()

        Dim cmd4 As New MySqlCommand("Select COUNT(*) FROM doctrack2018incomingtb", connection)
        Dim CurrentIncoming2018 As Integer = cmd4.ExecuteScalar()

        Dim cmd5 As New MySqlCommand("Select COUNT(*) FROM doctrack2018outgoingtb", connection)
        Dim CurrentOutgoing2018 As Integer = cmd5.ExecuteScalar()

        Dim cmd6 As New MySqlCommand("Select COUNT(*) FROM doctrack2019incomingtb", connection)
        Dim CurrentIncoming2019 As Integer = cmd6.ExecuteScalar()

        Dim cmd7 As New MySqlCommand("Select COUNT(*) FROM doctrack2019outgoingtb", connection)
        Dim CurrentOutgoing2019 As Integer = cmd7.ExecuteScalar()

        Dim cmd8 As New MySqlCommand("Select COUNT(*) FROM doctrack2020incomingtb", connection)
        Dim CurrentIncoming2020 As Integer = cmd8.ExecuteScalar()

        Dim cmd9 As New MySqlCommand("Select COUNT(*) FROM doctrack2020outgoingtb", connection)
        Dim CurrentOutgoing2020 As Integer = cmd9.ExecuteScalar()

        Dim cmd10 As New MySqlCommand("Select COUNT(*) FROM doctrack2021incomingtb", connection)
        Dim CurrentIncoming2021 As Integer = cmd10.ExecuteScalar()

        Dim cmd11 As New MySqlCommand("Select COUNT(*) FROM doctrack2021outgoingtb", connection)
        Dim CurrentOutgoing2021 As Integer = cmd11.ExecuteScalar()


        Dim cmd12 As New MySqlCommand("Select COUNT(*) FROM doctrack2022incomingtb", connection)
        Dim CurrentIncoming2022 As Integer = cmd10.ExecuteScalar()

        Dim cmd13 As New MySqlCommand("Select COUNT(*) FROM doctrack2022outgoingtb", connection)
        Dim CurrentOutgoing2022 As Integer = cmd11.ExecuteScalar()



        Dim Total2016in = (CurrentIncoming2016 / TotalDocs2016Incoming) * 100
        Dim Total2016out = (CurrentOutgoing2016 / TotalDocs2016Outgoing) * 100

        Dim Total2017in = (CurrentIncoming2017 / TotalDocs2017Incoming) * 100
        Dim Total2017out = (CurrentOutgoing2017 / TotalDocs2017Outgoing) * 100

        Dim Total2018in = (CurrentIncoming2018 / TotalDocs2018Incoming) * 100
        Dim Total2018out = (CurrentOutgoing2018 / TotalDocs2018Outgoing) * 100

        Dim Total2019in = (CurrentIncoming2019 / TotalDocs2019Incoming) * 100
        Dim Total2019out = (CurrentOutgoing2019 / TotalDocs2019Outgoing) * 100

        Dim Total2020in = (CurrentIncoming2020 / TotalDocs2020Incoming) * 100
        Dim Total2020out = (CurrentOutgoing2020 / TotalDocs2020Outgoing) * 100

        Dim Total2021in = (CurrentIncoming2021 / TotalDocs2021Incoming) * 100
        Dim Total2021out = (CurrentOutgoing2021 / TotalDocs2021Outgoing) * 100

        Dim Total2022in = (CurrentIncoming2022 / TotalDocs2022Incoming) * 100
        Dim Total2022out = (CurrentOutgoing2022 / TotalDocs2022Outgoing) * 100


        FormOfficeLogs.ProgressBar1.Value = Math.Floor(Total2016in)
        FormOfficeLogs.ProgressBar2.Value = Math.Floor(Total2016out)
        FormOfficeLogs.ProgressBar3.Value = Math.Floor(Total2017in)
        FormOfficeLogs.ProgressBar4.Value = Math.Floor(Total2017out)
        FormOfficeLogs.ProgressBar5.Value = Math.Floor(Total2018in)
        FormOfficeLogs.ProgressBar6.Value = Math.Floor(Total2018out)
        FormOfficeLogs.ProgressBar7.Value = Math.Floor(Total2019in)
        FormOfficeLogs.ProgressBar8.Value = Math.Floor(Total2019out)
        FormOfficeLogs.ProgressBar9.Value = Math.Floor(Total2020in)
        FormOfficeLogs.ProgressBar10.Value = Math.Floor(Total2020out)
        FormOfficeLogs.ProgressBar12.Value = Math.Floor(Total2021in)
        FormOfficeLogs.ProgressBar13.Value = Math.Floor(Total2021out)
        FormOfficeLogs.ProgressBar14.Value = Math.Floor(Total2022in)
        FormOfficeLogs.ProgressBar15.Value = Math.Floor(Total2022out)


        FormOfficeLogs.Label15.Text = Math.Floor(Total2016in) & "%"
        FormOfficeLogs.Label16.Text = Math.Floor(Total2016out) & "%"
        FormOfficeLogs.Label17.Text = Math.Floor(Total2017in) & "%"
        FormOfficeLogs.Label18.Text = Math.Floor(Total2017out) & "%"
        FormOfficeLogs.Label19.Text = Math.Floor(Total2018in) & "%"
        FormOfficeLogs.Label20.Text = Math.Floor(Total2018out) & "%"
        FormOfficeLogs.Label21.Text = Math.Floor(Total2019in) & "%"
        FormOfficeLogs.Label22.Text = Math.Floor(Total2019out) & "%"
        FormOfficeLogs.Label23.Text = Math.Floor(Total2020in) & "%"
        FormOfficeLogs.Label24.Text = Math.Floor(Total2020out) & "%"
        FormOfficeLogs.Label32.Text = Math.Floor(Total2021in) & "%"
        FormOfficeLogs.Label33.Text = Math.Floor(Total2021out) & "%"
        FormOfficeLogs.Label2.Text = Math.Floor(Total2022in) & "%"
        FormOfficeLogs.Label4.Text = Math.Floor(Total2022out) & "%"

        Dim OverallResult = (Total2016in + Total2016out + Total2017in + Total2017out + Total2018in + Total2018out + Total2019in + Total2019out + Total2020in + Total2020out + Total2021in + Total2021out + Total2022in + Total2022out) / 14

        FormOfficeLogs.ProgressBar11.Value = Math.Floor(OverallResult)
        FormOfficeLogs.Label26.Text = Math.Floor(OverallResult) & " % - Completed"
        connection.Close()
    End Sub




    Sub ShowLogDGV()

        OpenConnection()

        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("Select * FROM logs ORDER BY `Id` DESC LIMIT 200", connection)
        adapter.Fill(table)
        FormOfficeLogs.DataGridView22.DataSource = table
        FormOfficeLogs.DataGridView22.Sort(FormOfficeLogs.DataGridView22.Columns(0), ListSortDirection.Descending)

        connection.Close()
    End Sub





    Sub logStatsDGV()

        OpenConnection()

        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `Name`, `Action`, COUNT(*) FROM logs WHERE Name='Mary' OR Name='Tintin' OR Name='Mydel' OR Name='Admin' OR Name='Joan' And Action='Updated' OR Action ='Saved' GROUP BY Name, Action", connection)
        adapter.Fill(table)
        FormOfficeLogs.DataGridView3.DataSource = table

        Dim cmd1 As New MySqlCommand("select count(*) as count from logs where Name='Mary'", connection)
        Dim i1 As Integer = cmd1.ExecuteScalar()

        Dim cmd2 As New MySqlCommand("select count(*) as count from logs where Name='Mydel'", connection)
        Dim i2 As Integer = cmd2.ExecuteScalar()

        Dim cmd3 As New MySqlCommand("select count(*) as count from logs where Name='Tintin'", connection)
        Dim i3 As Integer = cmd3.ExecuteScalar()

        Dim cmd4 As New MySqlCommand("select count(*) as count from logs where Name='Joan'", connection)
        Dim i4 As Integer = cmd4.ExecuteScalar()

        Dim cmd5 As New MySqlCommand("select count(*) as count from logs where Name='Admin'", connection)
        Dim i5 As Integer = cmd5.ExecuteScalar()
        ' cmd = Nothing
        connection.Close()


    End Sub
    Sub SearchOfficeDocuments()
        connection.Open()
        Dim da As MySqlDataAdapter
        Dim dt As DataTable


        If FormOfficeDocs.inc_out_CB.SelectedIndex = 0 Then
            DateReceived_or_Released = "DateReceived"
        Else
            DateReceived_or_Released = "DateReleased"
        End If

        da = New MySqlDataAdapter("SELECT `No`, `Particulars`,  `ReferenceNo` FROM doctrack" & FormOfficeDocs.yearCB.Text & "" & FormOfficeDocs.inc_out_CB.Text & "tb
                                            WHERE `No` LIKE '%" & FormOfficeDocs.SearchTB.Text & "%'
                                            OR `Particulars` LIKE '%" & FormOfficeDocs.SearchTB.Text & "%'
                                            OR `Date` LIKE '%" & FormOfficeDocs.SearchTB.Text & "%' 
                                            OR `ReferenceNo` LIKE '%" & FormOfficeDocs.SearchTB.Text & "%'
                                            OR `SubmittedBy` LIKE '%" & FormOfficeDocs.SearchTB.Text & "%'
                                            OR `Division` LIKE '%" & FormOfficeDocs.SearchTB.Text & "%'  
                                            OR `District` LIKE '%" & FormOfficeDocs.SearchTB.Text & "%'
                                            OR `ForwardedTo` LIKE '%" & FormOfficeDocs.SearchTB.Text & "%'
                                            OR `Remarks` LIKE '%" & FormOfficeDocs.SearchTB.Text & "%'
                                            OR `" & DateReceived_or_Released & "` LIKE '%" & FormOfficeDocs.SearchTB.Text & "%'", connection)


        dt = New DataTable
        da.Fill(dt)
        FormOfficeDocs.DataGridView1.DataSource = dt
        FormOfficeDocs.DataGridView1.Sort(FormOfficeDocs.DataGridView1.Columns(0), ListSortDirection.Descending)
        FormOfficeDocs.DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        FormOfficeDocs.DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FormOfficeDocs.DataGridView1.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        da.Dispose()


        'End if Incoming/Outgoing
        If dt IsNot Nothing AndAlso dt.Rows.Count = 0 Then
            FormOfficeDocs.walayRecordLbl.Show()
            FormOfficeDocs.walayRecordLbl.Text = "'Walay Record'"

        Else
            FormOfficeDocs.walayRecordLbl.Hide()
        End If

        connection.Close()

    End Sub








    Sub addform_save_clearTxts()


        addform.districtTB.Clear()
        addform.forwardTB.Clear()
        addform.remarksTB.Clear()
        addform.particularTB.Clear()
        ' addform.refTB.Clear()
        addform.subTB.Clear()
        addform.divTB.Clear()

        ' addform.dateRRTB.Clear()
        addform.particularTB.Select()


    End Sub
    Sub searchLogs()
        connection.Open()
        Dim da As MySqlDataAdapter
        Dim dt As DataTable



        da = New MySqlDataAdapter("SELECT `Id`, `Date`, `ReferenceNo`, `Document`, `Action`, `Name` FROM `logs` WHERE " & FormOfficeLogs.chooseSearchCB.Text & " Like '%" & FormOfficeLogs.SearchTB2.Text & "%'", connection)
        dt = New DataTable
        da.Fill(dt)
        FormOfficeLogs.DataGridView22.DataSource = dt
        da.Dispose()






        If dt IsNot Nothing AndAlso dt.Rows.Count = 0 Then
            MessageBox.Show("NO RECORD! :P", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

        End If

        connection.Close()

    End Sub




End Module
