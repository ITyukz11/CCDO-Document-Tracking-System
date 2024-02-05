Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class FormLogs




    Private Sub requestOfSuppliesBTN_Click(sender As Object, e As EventArgs) Handles requestOfSuppliesBTN.Click
        databaseTable = "inventory_ros"
        walayRecordLbl.Hide()
        OpenConnection()

        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM `inventory_ros` ", connection)
        adapter.Fill(table)
        DataGridView1.DataSource = table
        DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Descending)
        DirectCast(DataGridView1.Columns(10), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom
        connection.Close()

    End Sub

    Private Sub requestOfPropertyBTN_Click(sender As Object, e As EventArgs) Handles requestOfPropertyBTN.Click
        databaseTable = "inventory_rop"
        walayRecordLbl.Hide()

        OpenConnection()

        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM `inventory_rop` ", connection)
        adapter.Fill(table)
        DataGridView1.DataSource = table

        DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Descending)



        connection.Close()

    End Sub

    Private Sub ActionLogsBTN_Click(sender As Object, e As EventArgs) Handles ActionLogsBTN.Click
        DatabaseTable = "inventory_logs_actions"
        walayRecordLbl.Hide()
        OpenConnection()

        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM `inventory_logs_actions` ", connection)
        adapter.Fill(table)
        DataGridView1.DataSource = table
        DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Descending)
        connection.Close()
    End Sub
    Private Sub SearchTB_MouseEnter(sender As Object, e As EventArgs) Handles SearchTB.MouseEnter

        If SearchTB.Text = "Search" Then
            SearchTB.Text = ""
            SearchTB.ForeColor = Color.Black
        End If

    End Sub

    Private Sub SearchTB_MouseLeave(sender As Object, e As EventArgs) Handles SearchTB.MouseLeave
        If SearchTB.Text = "" Then
            SearchTB.Text = "Search"
            SearchTB.ForeColor = Color.Gray
            DataGridView1.Select()
        End If

    End Sub

    Private Sub chooseSearchCB_SelectedIndexChanged(sender As Object, e As EventArgs)
        SearchTB.Text = "Search"

        SearchTB.ForeColor = Color.Gray
    End Sub
    Private Sub SearchTB_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchTB.KeyDown

        If (e.KeyCode = Keys.Enter) Then
            If databaseTable = "" Then

                MessageBox.Show("Please choose what type of logs your looking:", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim da As MySqlDataAdapter
                Dim dt As DataTable


                If databaseTable = "inventory_ros" Then
                    da = New MySqlDataAdapter("SELECT * FROM `" & databaseTable & "` 
                                             WHERE `No` LIKE '%ever%' 
                                             OR `ItemDescription` LIKE '%" & SearchTB.Text & "%'
                                             OR `BegBalance` LIKE '%" & SearchTB.Text & "%' 
                                             OR `DateDelivered` LIKE '%" & SearchTB.Text & "%'
                                             OR `NumofItemsReq` LIKE '%" & SearchTB.Text & "%'
                                             OR `Unit` LIKE '%" & SearchTB.Text & "%'  
                                             OR `DateReq` LIKE '%" & SearchTB.Text & "%'
                                             OR `ReqBy` LIKE '%" & SearchTB.Text & "%'
                                             OR `Office` LIKE '%" & SearchTB.Text & "%'
                                             OR `EndBalance` LIKE '%" & SearchTB.Text & "%'", connection)
                    dt = New DataTable
                    Try
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                        DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Descending)
                        da.Dispose()
                        connection.Close()
                    Catch ex As Exception
                        MessageBox.Show("There is an error in your database please contact your I.T", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                ElseIf databaseTable = "inventory_rop" Then

                    da = New MySqlDataAdapter("SELECT * FROM `" & databaseTable & "` 
                                             WHERE `No` LIKE '%ever%' 
                                             OR `propertyDescription` LIKE '%" & SearchTB.Text & "%'
                                             OR `propertyNo` LIKE '%" & SearchTB.Text & "%' 
                                             OR `condi` LIKE '%" & SearchTB.Text & "%'
                                             OR `reqBy` LIKE '%" & SearchTB.Text & "%'
                                             OR `reqOn` LIKE '%" & SearchTB.Text & "%'  
                                             OR `purpose` LIKE '%" & SearchTB.Text & "%'
                                             OR `returnedOn` LIKE '%" & SearchTB.Text & "%'
                                             OR `returnedBy` LIKE '%" & SearchTB.Text & "%'
                                             OR `condi2` LIKE '%" & SearchTB.Text & "%'
                                             Or `remarks` Like '%" & SearchTB.Text & "%'", connection)
                    dt = New DataTable
                    Try
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                        DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Descending)
                        da.Dispose()
                        connection.Close()
                    Catch ex As Exception
                        MessageBox.Show("There is an error in your database please contact your I.T", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try

                Else
                    da = New MySqlDataAdapter("SELECT * FROM `" & databaseTable & "` 
                                             WHERE `No` LIKE '%ever%' 
                                             OR `propertyDescription` LIKE '%" & SearchTB.Text & "%'
                                             OR `propertyNo` LIKE '%" & SearchTB.Text & "%' 
                                             OR `condi` LIKE '%" & SearchTB.Text & "%'
                                             OR `reqBy` LIKE '%" & SearchTB.Text & "%'
                                             OR `reqOn` LIKE '%" & SearchTB.Text & "%'  
                                             OR `purpose` LIKE '%" & SearchTB.Text & "%'
                                             OR `returnedOn` LIKE '%" & SearchTB.Text & "%'
                                             OR `returnedBy` LIKE '%" & SearchTB.Text & "%'
                                             OR `condi2` LIKE '%" & SearchTB.Text & "%'
                                             Or `remarks` Like '%" & SearchTB.Text & "%'", connection)
                    dt = New DataTable
                    Try
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                        DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Descending)
                        da.Dispose()
                        connection.Close()
                    Catch ex As Exception
                        MessageBox.Show("There is an error in your database please contact your I.T", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try


                End If

                If dt IsNot Nothing AndAlso dt.Rows.Count = 0 Then
                    walayRecordLbl.Show()


                Else
                    walayRecordLbl.Hide()
                End If

            End If


        End If
    End Sub





    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        Dim index As Integer

        ' get the index of the selected datagridview row
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow

        Select Case DatabaseTable
            Case "inventory_rop"


                Try

                    selectedRow = DataGridView1.Rows(Index)

                    FormRequestProperty.NoLbl.Text = selectedRow.Cells(0).Value.ToString()
                    FormRequestProperty.propNoTxt.Text = selectedRow.Cells(0).Value.ToString()
                    FormRequestProperty.descTxt.Text = selectedRow.Cells(1).Value.ToString()
                    FormRequestProperty.condTxt.Text = selectedRow.Cells(3).Value.ToString()
                    FormRequestProperty.reqByTxt.Text = selectedRow.Cells(4).Value.ToString()
                    '  FormRequestProperty.reqon.Text = selectedRow.Cells(5).Value.ToString()
                    FormRequestProperty.purposeTxt.Text = selectedRow.Cells(6).Value.ToString()
                    FormRequestProperty.returnOnCb.Text = selectedRow.Cells(7).Value.ToString()
                    FormRequestProperty.returnByTxt.Text = selectedRow.Cells(8).Value.ToString()
                    'condi2(9)
                    FormRequestProperty.remarksTxt.Text = selectedRow.Cells(10).Value.ToString()

                    LoadsImageInLogs()
                    FormRequestProperty.ShowDialog()

                Catch

                    MessageBox.Show("Error: " & ErrorToString(), "Form Logs", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try




            Case "inventory_ros"

                Try

                    selectedRow = DataGridView1.Rows(index)

                    FormRequestSupplies.NoLbl.Text = selectedRow.Cells(0).Value.ToString()
                    FormRequestSupplies.descTb.Text = selectedRow.Cells(1).Value.ToString()
                    FormRequestSupplies.begBalanceTxt.Text = selectedRow.Cells(2).Value.ToString()
                    FormRequestSupplies.dateDelvTxt.Text = selectedRow.Cells(3).Value.ToString()
                    FormRequestSupplies.numItemReqTxt.Text = selectedRow.Cells(4).Value.ToString()
                    FormRequestSupplies.unitTxt.Text = selectedRow.Cells(5).Value.ToString()
                    FormRequestSupplies.dateReqTxt.Text = selectedRow.Cells(6).Value.ToString()
                    FormRequestSupplies.reqByTxt.Text = selectedRow.Cells(7).Value.ToString()
                    FormRequestSupplies.officesCb.Text = selectedRow.Cells(8).Value.ToString()
                    FormRequestSupplies.endBalanceTxt.Text = selectedRow.Cells(9).Value.ToString()

                    LoadsImageInLogs()
                    FormRequestSupplies.ShowDialog()

                Catch

                    MessageBox.Show("Error: " & ErrorToString(), "Form Logs", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try


        End Select

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer

        ' get the index of the selected datagridview row
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow

        If index = -1 Then
            'do nothing
        Else
            selectedRow = DataGridView1.Rows(index)
            PrimaryKey = selectedRow.Cells(0).Value.ToString()
        End If


        'Store the value for the item description whenever user click the datagridview so that the image will be fetch from the database, see inventorymodule

    End Sub

    Private Sub FormLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SearchTB.Text = "Search"
        SearchTB.ForeColor = Color.Gray

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        FormReport.ShowDialog()
    End Sub
End Class