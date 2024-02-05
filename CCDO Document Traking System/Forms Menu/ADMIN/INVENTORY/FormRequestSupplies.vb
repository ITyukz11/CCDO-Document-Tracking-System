Imports System.IO
Imports MySql.Data.MySqlClient
Public Class FormRequestSupplies



    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        If reqByTxt.Text = "" Then

            MessageBox.Show("Please input who requested the item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf endBalanceTxt.Text < 0 Then

            MessageBox.Show("Negative ending balance! Please change your # of items requested", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim ms As New MemoryStream

            InventoryImageBox.Image.Save(MS, InventoryImageBox.Image.RawFormat)

            Dim NewQty = Convert.ToInt32(begBalanceTxt.Text) - Convert.ToInt32(numItemReqTxt.Text)

            Dim command As New MySqlCommand("INSERT INTO `inventory_ros`(`ItemDescription`, `BegBalance`, `DateDelivered`, `NumofItemsReq`, `Unit`, `DateReq`, `ReqBy`, `Office`, `EndBalance`,`Image`) 
                                        VALUES (@IDES,@BGB,@DAD,@NIR,@UNT,@DTR,@RQB,@OFC,@EB,@IMG)", connection)

            ' filling inventory Database table         
            command.Parameters.Add("@IDES", MySqlDbType.VarChar).Value = descTb.Text
            command.Parameters.Add("@BGB", MySqlDbType.VarChar).Value = begBalanceTxt.Text
            command.Parameters.Add("@DAD", MySqlDbType.VarChar).Value = dateDelvTxt.Text
            command.Parameters.Add("@NIR", MySqlDbType.VarChar).Value = numItemReqTxt.Text
            command.Parameters.Add("@UNT", MySqlDbType.VarChar).Value = unitTxt.Text
            command.Parameters.Add("@DTR", MySqlDbType.VarChar).Value = dateReqTxt.Text
            command.Parameters.Add("@RQB", MySqlDbType.VarChar).Value = reqByTxt.Text
            command.Parameters.Add("@OFC", MySqlDbType.VarChar).Value = officesCb.Text
            command.Parameters.Add("@EB", MySqlDbType.VarChar).Value = endBalanceTxt.Text
            command.Parameters.Add("@IMG", MySqlDbType.MediumBlob).Value = MS.ToArray()


            If FormInventory.suppliesCB.SelectedIndex = 0 Then

                databaseTable = "`office_supplies`"
            ElseIf FormInventory.suppliesCB.SelectedIndex = 1 Then

                databaseTable = "`comp_smpa`"
            Else
                databaseTable = "`janitorial_gmsm`"
            End If

            Dim command2 As New MySqlCommand("UPDATE " & databaseTable & " SET `QTY`=@QTY WHERE `No`=@NO", connection)

            command2.Parameters.Add("@NO", MySqlDbType.Int32).Value = NoLbl.Text
            command2.Parameters.Add("@QTY", MySqlDbType.Int32).Value = NewQty

            connection.Open()
            If endBalanceTxt.Text = "0" Then
                Dim result = MessageBox.Show("This item will now be deleted because it has 0 ending balance, do you still want to continue?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If (result = DialogResult.Yes) Then
                    Try

                        DeleteDataIfEndbalanceIsZero()

                        connection.Close()
                        RefreshDataGridViewInventory()
                        NoLbl.Text = ""
                        ClearFormRequestSuppliesTexts()

                        'Auto select the row that have been recently selected in datagridview
                        FormInventory.DataGridView1.Rows(DatagridviewIndexNumberInInventory).Selected = True
                        Me.Close()
                    Catch ex As Exception
                        MessageBox.Show("Can't save to database, please contact team CMIS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Else
                    'do nothing
                End If
            Else

                Try
                    If command.ExecuteNonQuery() And command2.ExecuteNonQuery() = 1 Then
                        MessageBox.Show("Submitted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        connection.Close()

                        NoLbl.Text = ""
                        ClearFormRequestSuppliesTexts()

                        'loads the report found in the right side of inventoryform automatically after submitting data
                        LoadsReportData()


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
                    MessageBox.Show("Can't save to database, please contact team CMIS Error Message: " & ex.Message & "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If





        End If

    End Sub

    Sub ClearFormRequestSuppliesTexts()
        descTb.Text = ""
        begBalanceTxt.Text = ""
        dateDelvTxt.Text = ""
        numItemReqTxt.Text = ""
        unitTxt.Text = ""
        dateReqTxt.Text = ""
        reqByTxt.Text = ""
        officesCb.Text = ""
        endBalanceTxt.Text = ""
    End Sub

    Sub DeleteDataIfEndbalanceIsZero()



        Dim delete_command As New MySqlCommand("DELETE FROM " & databaseTable & " WHERE `No`=@NO", connection)
        delete_command.Parameters.Add("@NO", MySqlDbType.Int64).Value = NoLbl.Text
        Try
                    delete_command.ExecuteNonQuery()


            MessageBox.Show("" & descTb.Text & " Item has been successfully deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            connection.Close()
                    RefreshDataGridViewInventory()
                    NoLbl.Text = ""
                    ClearFormRequestSuppliesTexts()
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message & " Please contact your I.T", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try





    End Sub

    Private Sub numItemReqTxt_TextChanged(sender As Object, e As EventArgs) Handles numItemReqTxt.TextChanged
        Try
            If numItemReqTxt.Text = "" Then


            Else
                endBalanceTxt.Text = Convert.ToInt32(begBalanceTxt.Text) - Convert.ToInt32(numItemReqTxt.Text)

            End If

        Catch ex As Exception
            MessageBox.Show("Please Chill, Error Message: " & ex.Message & "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            numItemReqTxt.Text = ""
        End Try


    End Sub

    Private Sub RequestSupplies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FormInventory.suppliesCB.SelectedIndex = 0 Then
            OLabel0.Show()

        ElseIf FormInventory.suppliesCB.SelectedIndex = 1 Then
            CLabel1.Show()

        Else
            JLabel2.Show()

        End If


    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click

        RefreshDataGridViewInventory()
        OLabel0.Hide()
        CLabel1.Hide()
        JLabel2.Hide()

        FormInventory.DataGridView1.Rows(DatagridviewIndexNumberInInventory).Selected = True
        Me.Close()

    End Sub

    Private Sub RequestSupplies_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ClearFormRequestSuppliesTexts()
        OLabel0.Hide()
        CLabel1.Hide()
        JLabel2.Hide()
    End Sub

    Private Sub updateBTN_Click(sender As Object, e As EventArgs) Handles updateBTN.Click

    End Sub
End Class