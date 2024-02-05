Imports System.IO
Imports MySql.Data.MySqlClient
Public Class FormAddInventory
    Private Sub FormAddInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        unitCB.SelectedIndex = 0
        dateTb.Text = Date.Now

        If FormInventory.suppliesCB.SelectedIndex = 0 Then
            OLabel0.Show()

        ElseIf FormInventory.suppliesCB.SelectedIndex = 1 Then
            CLabel1.Show()

        Else
            JLabel2.Show()

        End If
    End Sub
    Private Sub BrowseBtn_Click(sender As Object, e As EventArgs) Handles BrowseBtn.Click

        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                InventoryImageBox.Load(Me.OpenFileDialog1.FileName)
                filePathTxt.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)

            Else
                MessageBox.Show("Please Choose Image", "Browse File", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Please Choose Image", "Browse File", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try

    End Sub

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        InventoryActionLog = "Saved"


        If filePathTxt.Text = "" Then

            MessageBox.Show("Please include photo of the item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf descTb.Text = "" Or unitCB.Text = "" Or qtyTb.Text = "" Then

            MessageBox.Show("Please dont leave unit or quantity blank", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Dim ms As New MemoryStream

            Try
                InventoryImageBox.Image.Save(ms, InventoryImageBox.Image.RawFormat)

            Catch ex As Exception

            End Try

            Dim dbtable

            If FormInventory.suppliesCB.SelectedIndex = 0 Then

                dbtable = "`office_supplies`"
            ElseIf FormInventory.suppliesCB.SelectedIndex = 1 Then

                dbtable = "`comp_smpa`"
            ElseIf FormInventory.suppliesCB.SelectedIndex = 2 Then
                dbtable = "`janitorial_gmsm`"
            Else
                dbtable = "`it_equipment`"
            End If


            Dim command As New MySqlCommand("INSERT INTO  " & dbtable & "(`Description`, `Unit`, `QTY`, `Remarks`,`Image`) 
                                        VALUES (@DES,@UNI,@QTY,@RMK,@IMG)", connection)

            ' filling inventory Database table
            command.Parameters.Add("@DES", MySqlDbType.VarChar).Value = descTb.Text
            command.Parameters.Add("@UNI", MySqlDbType.VarChar).Value = unitCB.Text
            command.Parameters.Add("@QTY", MySqlDbType.VarChar).Value = qtyTb.Text
            command.Parameters.Add("@RMK", MySqlDbType.VarChar).Value = remarksTb.Text
            command.Parameters.Add("@IMG", MySqlDbType.MediumBlob).Value = ms.ToArray()

            Dim command2 As New MySqlCommand("INSERT INTO  `inventory_logs_actions`( `Name`, `ItemDescription`,`Unit`,`Qty`, `Date`, `Action`) 
                                        VALUES (@NME,@IDS,@UNT,@QTY,@DTE,@ACT)", connection)

            ' filling inventory Database table
            command2.Parameters.Add("@NME", MySqlDbType.VarChar).Value = DocTrackLogin.TxtBoxUsername.Text
            command2.Parameters.Add("@IDS", MySqlDbType.VarChar).Value = descTb.Text
            command2.Parameters.Add("@UNT", MySqlDbType.VarChar).Value = unitCB.Text
            command2.Parameters.Add("@QTY", MySqlDbType.VarChar).Value = qtyTb.Text
            command2.Parameters.Add("@DTE", MySqlDbType.VarChar).Value = dateTb.Text
            command2.Parameters.Add("@ACT", MySqlDbType.VarChar).Value = InventoryActionLog

            connection.Open()

            Try
                If command.ExecuteNonQuery() And command2.ExecuteNonQuery = 1 Then
                    MessageBox.Show("New item " & descTb.Text & " has been successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RefreshDataGridViewInventory() 'ok
                    ClearTextsFormAddInventory() 'ok
                    InventoryImageBox.Image = Image.FromFile("" & DoctrackServer & "\Inventory Images\No_images_available.png ") 'ok
                    connection.Close()
                End If

                'ok
                'ok 



            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                connection.Close()
            End Try




        End If

    End Sub


    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click

        RefreshDataGridViewInventory()
        'Auto select the row that have been recently selected in datagridview

        FormInventory.DataGridView1.Rows(DatagridviewIndexNumberInInventory).Selected = True
        updateBTN.Enabled = False
        deleteBtn.Enabled = False
        Me.Close()
    End Sub

    Private Sub updateBTN_Click(sender As Object, e As EventArgs) Handles updateBTN.Click
        InventoryActionLog = "Updated"
        Dim ms As New MemoryStream
        Dim dbtable

        If FormInventory.suppliesCB.SelectedIndex = 0 Then

            dbtable = "`office_supplies`"
        ElseIf FormInventory.suppliesCB.SelectedIndex = 1 Then

            dbtable = "`comp_smpa`"
        ElseIf FormInventory.suppliesCB.SelectedIndex = 2 Then
            dbtable = "`janitorial_gmsm`"
        Else
            dbtable = "`it_equipment`"
        End If



        Try
            InventoryImageBox.Image.Save(ms, InventoryImageBox.Image.RawFormat)

        Catch ex As Exception

        End Try


        Dim command As New MySqlCommand("UPDATE " & dbtable & " SET `Description`=@DESC, `Unit`=@UNI, `QTY`=@QTY, `Remarks`=@RMK, `Image`=@IMG WHERE `No`=@NO", connection)

        command.Parameters.Add("@NO", MySqlDbType.Int32).Value = NoLbl.Text
        command.Parameters.Add("@DESC", MySqlDbType.VarChar).Value = descTb.Text
        command.Parameters.Add("@UNI", MySqlDbType.VarChar).Value = unitCB.Text
        command.Parameters.Add("@QTY", MySqlDbType.Int32).Value = qtyTb.Text
        command.Parameters.Add("@RMK", MySqlDbType.VarChar).Value = remarksTb.Text
        command.Parameters.Add("@IMG", MySqlDbType.MediumBlob).Value = ms.ToArray()


        Dim command2 As New MySqlCommand("INSERT INTO  `inventory_logs_actions`( `Name`, `ItemDescription`,`Unit`,`Qty`, `Date`, `Action`) 
                                        VALUES (@NME,@IDS,@UNT,@QTY,@DTE,@ACT)", connection)

        ' filling inventory Database table
        command2.Parameters.Add("@NME", MySqlDbType.VarChar).Value = DocTrackLogin.TxtBoxUsername.Text
        command2.Parameters.Add("@IDS", MySqlDbType.VarChar).Value = descTb.Text
        command2.Parameters.Add("@UNT", MySqlDbType.VarChar).Value = unitCB.Text
        command2.Parameters.Add("@QTY", MySqlDbType.VarChar).Value = qtyTb.Text
        command2.Parameters.Add("@DTE", MySqlDbType.VarChar).Value = dateTb.Text
        command2.Parameters.Add("@ACT", MySqlDbType.VarChar).Value = InventoryActionLog


        connection.Open()

        Try
            If command.ExecuteNonQuery() And command2.ExecuteNonQuery = 1 Then
                MessageBox.Show(descTb.Text & " item has been successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                connection.Close()
                NoLbl.Text = ""
                LoadsImage()
                If FormInventory.SearchTB.ForeColor = Color.Black Then
                    searchInventory()
                    FormInventory.DataGridView1.Rows(DatagridviewIndexNumberInInventory).Selected = True
                    'SaveLogsToDatabase()

                    Me.Close()
                Else
                    'Auto select the row that have been recently selected in datagridview

                    RefreshDataGridViewInventory()
                    FormInventory.DataGridView1.Rows(DatagridviewIndexNumberInInventory).Selected = True

                    Me.Close()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Can't save to database, please contact team CMIS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        connection.Close()
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        InventoryActionLog = "Deleted"
        If DocTrackLogin.TxtBoxUsername.Text = "ading" Or DocTrackLogin.TxtBoxUsername.Text = "dimple" Then

            Dim result = MessageBox.Show("Are you sure you want to delete?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


            If (result = DialogResult.Yes) Then

                Dim result2 = MessageBox.Show("Sure najud?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

                If (result2 = DialogResult.Yes) Then
                    Dim dbtable

                    If FormInventory.suppliesCB.SelectedIndex = 0 Then

                        dbtable = "`office_supplies`"
                    ElseIf FormInventory.suppliesCB.SelectedIndex = 1 Then

                        dbtable = "`comp_smpa`"
                    ElseIf FormInventory.suppliesCB.SelectedIndex = 2 Then
                        dbtable = "`janitorial_gmsm`"
                    Else
                        dbtable = "`it_equipment`"
                    End If

                    Dim delete_command As New MySqlCommand("DELETE FROM " & dbtable & " WHERE `No`=@NO", connection)
                    delete_command.Parameters.Add("@NO", MySqlDbType.Int64).Value = NoLbl.Text

                    Dim command2 As New MySqlCommand("INSERT INTO  `inventory_logs_actions`( `Name`, `ItemDescription`,`Unit`,`Qty`, `Date`, `Action`) 
                                        VALUES (@NME,@IDS,@UNT,@QTY,@DTE,@ACT)", connection)

                    ' filling inventory Database table
                    command2.Parameters.Add("@NME", MySqlDbType.VarChar).Value = DocTrackLogin.TxtBoxUsername.Text
                    command2.Parameters.Add("@IDS", MySqlDbType.VarChar).Value = descTb.Text
                    command2.Parameters.Add("@UNT", MySqlDbType.VarChar).Value = unitCB.Text
                    command2.Parameters.Add("@QTY", MySqlDbType.VarChar).Value = qtyTb.Text
                    command2.Parameters.Add("@DTE", MySqlDbType.VarChar).Value = dateTb.Text
                    command2.Parameters.Add("@ACT", MySqlDbType.VarChar).Value = InventoryActionLog


                    connection.Open()


                    If command2.ExecuteNonQuery() And delete_command.ExecuteNonQuery() = 1 Then
                        MessageBox.Show("AWTS GEGE!", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearInventoryReport()
                        RefreshDataGridViewInventory()
                        'SaveLogsToDatabase()
                        connection.Close()
                        Me.Close()

                    Else
                        MessageBox.Show("Fail to delete please contact team CMIS", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    MessageBox.Show("Double check if dili sure!", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            Else

            End If


            Me.Close()

        Else
            Dim result2 = MessageBox.Show("You don't have the authority to delete data!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
        connection.Close()
    End Sub

    Private Sub FormAddInventory_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            updateBTN.Enabled = False
            Me.Close()
        End If

    End Sub

    Private Sub FormAddInventory_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        updateBTN.Enabled = False
        deleteBtn.Enabled = False
    End Sub

    Sub ClearTextsFormAddInventory()
        NoLbl.Text = ""
        descTb.Text = ""
        unitCB.Text = ""
        qtyTb.Text = ""
        remarksTb.Text = ""
        filePathTxt.Text = ""
        unitCB.SelectedIndex = 0
    End Sub

    Sub ClearInventoryReport()

        FormInventory.inventoryPictureBox.Image = Image.FromFile("" & DoctrackServer & "\Inventory Images\No_images_available.png ")
        FormInventory.descTxt.Text = ""
        FormInventory.lastDateReqTxt.Text = ""
        FormInventory.lastReqByTxt.Text = ""
        FormInventory.noOfItemsTxt.Text = ""
        FormInventory.noTimesRequestedTxt.Text = ""
        FormInventory.totalDocTxt.Text = ""
        FormInventory.officeTxt.Text = ""
        FormInventory.qtyTxt.Text = ""
        FormInventory.totalDocTxt.Text = ""
        FormInventory.unitTxt.Text = ""


    End Sub

End Class