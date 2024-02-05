Imports MySql.Data.MySqlClient

Public Class FormInventory



    Private Sub addNewBtn_Click(sender As Object, e As EventArgs) Handles addNewBtn.Click
        FormAddInventory.submitBtn.Enabled = True
        FormAddInventoryClearText()
        FormAddInventory.descTb.Select()
        FormAddInventory.ShowDialog()
    End Sub

    Private Sub FormAddInventoryClearText()
        FormAddInventory.NoLbl.Text = ""
        FormAddInventory.descTb.Text = ""
        FormAddInventory.unitCB.Text = ""
        FormAddInventory.qtyTb.Text = ""
        FormAddInventory.remarksTb.Text = ""
        FormAddInventory.InventoryImageBox.Image = Nothing
    End Sub

    Private Sub FormInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        walayRecordLbl.Hide()
        chooseSearchCB.SelectedIndex = 1
        suppliesCB.SelectedIndex = 0
        CountsTheNumberOfTimesRequested()





    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer

        ' get the index of the selected datagridview row
        index = e.RowIndex




        Try
            If index = -1 Then
                'do nothing
            Else
                'to get the index from datagridview, declared in module as public 
                DatagridviewIndexNumberInInventory = index


                'If its request supplies category
                If suppliesCB.SelectedIndex <> 3 Then
                    Dim selectedRow As DataGridViewRow
                    selectedRow = DataGridView1.Rows(index)


                    ' now show data from the selected row to textboxes
                    totalDocTxt.Text = selectedRow.Cells(0).Value.ToString()
                    descTxt.Text = selectedRow.Cells(1).Value.ToString()
                    unitTxt.Text = selectedRow.Cells(2).Value.ToString()
                    qtyTxt.Text = selectedRow.Cells(3).Value.ToString()

                    FormRequestSupplies.NoLbl.Text = selectedRow.Cells(0).Value.ToString()
                    FormRequestSupplies.descTb.Text = selectedRow.Cells(1).Value.ToString()
                    FormRequestSupplies.unitTxt.Text = selectedRow.Cells(2).Value.ToString()
                    FormRequestSupplies.begBalanceTxt.Text = selectedRow.Cells(3).Value.ToString()

                    'This will catch the error unabling to click COLUMN HEADER 
                    If FormAddInventory.NoLbl.Text.Any Then

                        'Do nothing

                    End If

                    'If its request property
                Else
                    Dim selectedRow As DataGridViewRow
                    selectedRow = DataGridView1.Rows(index)

                    totalDocTxt.Text = selectedRow.Cells(0).Value.ToString()
                    descTxt.Text = selectedRow.Cells(1).Value.ToString()
                    unitTxt.Text = selectedRow.Cells(2).Value.ToString()
                    qtyTxt.Text = selectedRow.Cells(3).Value.ToString()


                    FormRequestProperty.NoLbl.Text = selectedRow.Cells(0).Value.ToString()
                    FormRequestProperty.propNoTxt.Text = selectedRow.Cells(0).Value.ToString()
                    FormRequestProperty.descTxt.Text = selectedRow.Cells(1).Value.ToString()
                    FormRequestProperty.qtyTb.Text = selectedRow.Cells(3).Value.ToString()

                    'This will catch the error unabling to click COLUMN HEADER 
                    If FormAddInventory.NoLbl.Text.Any Then

                        'Do nothing

                    End If

                End If



            End If
        Catch

            MessageBox.Show("Error: " & ErrorToString(), "Form Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        CountsTheNumberOfTimesRequested()
        LoadsReportData()
        LoadsImage()


    End Sub



    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim index As Integer

        ' get the index of the selected datagridview row
        index = e.RowIndex


        'Detect if user is not ading
        If DocTrackLogin.TxtBoxUsername.Text = "ading" Or DocTrackLogin.TxtBoxUsername.Text = "dimple" Then

            Try
                If index = -1 Then
                    'do nothing
                Else

                    Dim selectedRow As DataGridViewRow
                    selectedRow = DataGridView1.Rows(index)

                    FormAddInventory.NoLbl.Text = selectedRow.Cells(0).Value.ToString()
                    FormAddInventory.descTb.Text = selectedRow.Cells(1).Value.ToString()
                    FormAddInventory.unitCB.Text = selectedRow.Cells(2).Value.ToString()
                    FormAddInventory.qtyTb.Text = selectedRow.Cells(3).Value.ToString()
                    FormAddInventory.remarksTb.Text = selectedRow.Cells(4).Value.ToString()

                    'This will catch the error unabling to click COLUMN HEADER 
                    If FormAddInventory.NoLbl.Text.Any Then

                        'Do nothing

                    End If
                    FormAddInventory.submitBtn.Enabled = False
                    FormAddInventory.updateBTN.Enabled = True
                    FormAddInventory.deleteBtn.Enabled = True
                    FormAddInventory.ShowDialog()

                End If
            Catch

                MessageBox.Show("Error: " & ErrorToString(), "Form Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            'do nothing
        End If



    End Sub



    Private Sub RosBtn_Click(sender As Object, e As EventArgs) Handles rosBtn.Click

        FormRequestSupplies.officesCb.SelectedIndex = 0

        If suppliesCB.SelectedIndex = 3 Then

            suppliesCB.SelectedIndex = 0
        Else
            Try
                If FormRequestSupplies.NoLbl.Text = "" Then
                    MessageBox.Show("Please select the item first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    FormRequestSupplies.numItemReqTxt.Select()
                    FormRequestSupplies.ShowDialog()
                End If
            Catch ex As Exception
                MessageBox.Show("There is a problem opening Request Supplies Form", "Error Form Inventory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If

    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click



        RefreshDataGridViewInventory()


    End Sub

    Private Sub SuppliesCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles suppliesCB.SelectedIndexChanged
        RefreshDataGridViewInventory()
        walayRecordLbl.Hide()
    End Sub

    Private Sub SearchTB_MouseEnter(sender As Object, e As EventArgs) Handles SearchTB.MouseEnter

        If SearchTB.Text = "Search for " & chooseSearchCB.Text & "" Then
            SearchTB.Text = ""
            SearchTB.ForeColor = Color.Black
        End If




    End Sub

    Private Sub SearchTB_MouseLeave(sender As Object, e As EventArgs) Handles SearchTB.MouseLeave
        If SearchTB.Text = "" Then
            SearchTB.Text = "Search for " & chooseSearchCB.Text & ""
            SearchTB.ForeColor = Color.Gray
            DataGridView1.Select()
        End If

    End Sub

    Private Sub chooseSearchCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chooseSearchCB.SelectedIndexChanged
        SearchTB.Text = "Search for " & chooseSearchCB.SelectedItem.ToString() & ""

        SearchTB.ForeColor = Color.Gray
    End Sub
    Private Sub SearchTB_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchTB.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            searchInventory()

        End If



    End Sub



    Private Sub reqProperty_Click(sender As Object, e As EventArgs) Handles reqProperty.Click
        If suppliesCB.SelectedIndex <> 3 Then
            suppliesCB.SelectedIndex = 3
        Else
            Try
                If FormRequestProperty.NoLbl.Text = "" Then
                    MessageBox.Show("Please select the item first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    FormRequestProperty.ShowDialog()
                End If
            Catch ex As Exception
                MessageBox.Show("There is a problem opening Request Property Form", "Error Form Inventory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If

    End Sub

    Private Sub logsBtn_Click(sender As Object, e As EventArgs) Handles logsBtn.Click

        FormLogs.ShowDialog()

    End Sub





    Sub CountsTheNumberOfTimesRequested()

        OpenConnection()
        Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM inventory_ros WHERE `ItemDescription` = '" & descTxt.Text & "'", connection)
        Try
            Dim i As Integer = cmd.ExecuteScalar()


            connection.Close()


            noTimesRequestedTxt.Text = i
        Catch ex As Exception
            MessageBox.Show("There is a problem loading the number times requested side please contact your I.T", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try


    End Sub



    Private Sub FormInventory_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F9 Then
            FormAddInventory.ShowDialog()
            MessageBox.Show("qweqweqweqweqw")
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        FormReport.ShowDialog()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class