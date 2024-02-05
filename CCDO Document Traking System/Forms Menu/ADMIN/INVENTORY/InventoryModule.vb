
Imports System.ComponentModel
Imports System.IO
Imports MySql.Data.MySqlClient
Module InventoryModule



    Public DatabaseTable As String
    Public DatagridviewIndexNumberInInventory As Integer
    Public InventoryActionLog As String
    Public PrimaryKey As String


    Sub RefreshDataGridViewInventory()

        OpenConnection()
        Try
            If FormInventory.suppliesCB.SelectedIndex = 0 Then

                Dim table As New DataTable()
                Dim adapter As New MySqlDataAdapter("SELECT `No`, `Description`, `Unit`, `QTY`, `Remarks` FROM `office_supplies`", connection)
                adapter.Fill(table)
                FormInventory.DataGridView1.DataSource = table

                Dim cmd As New MySqlCommand("Select COUNT(*) FROM office_supplies", connection)
                Dim i As Integer = cmd.ExecuteScalar()
                FormInventory.totalDocTxt.Text = i

                FormInventory.DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                FormInventory.DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                FormInventory.DataGridView1.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                FormInventory.DataGridView1.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells



            ElseIf FormInventory.suppliesCB.SelectedIndex = 1 Then

                Dim table As New DataTable()
                Dim adapter As New MySqlDataAdapter("SELECT `No`, `Description`, `Unit`, `QTY`, `Remarks` FROM `comp_smpa`", connection)
                adapter.Fill(table)
                FormInventory.DataGridView1.DataSource = table



                Dim cmd As New MySqlCommand("Select COUNT(*) FROM comp_smpa", connection)
                Dim i As Integer = cmd.ExecuteScalar()
                FormInventory.totalDocTxt.Text = i
            ElseIf FormInventory.suppliesCB.SelectedIndex = 2 Then

                Dim table As New DataTable()
                Dim adapter As New MySqlDataAdapter("SELECT `No`, `Description`, `Unit`, `QTY`, `Remarks` FROM `janitorial_gmsm`", connection)
                adapter.Fill(table)
                FormInventory.DataGridView1.DataSource = table

                Dim cmd As New MySqlCommand("Select COUNT(*) FROM janitorial_gmsm", connection)
                Dim i As Integer = cmd.ExecuteScalar()
                FormInventory.totalDocTxt.Text = i
            Else
                Dim table As New DataTable()
                Dim adapter As New MySqlDataAdapter("SELECT `No`, `Description`, `Unit`, `QTY`, `Remarks` FROM `IT_Equipment`", connection)
                adapter.Fill(table)
                FormInventory.DataGridView1.DataSource = table

                Dim cmd As New MySqlCommand("Select COUNT(*) FROM IT_Equipment", connection)
                Dim i As Integer = cmd.ExecuteScalar()
                FormInventory.totalDocTxt.Text = i

            End If

            connection.Close()
            FormInventory.DataGridView1.Sort(FormInventory.DataGridView1.Columns(0), ListSortDirection.Descending)

        Catch ex As Exception

            MessageBox.Show("There is a problem, please contact your IT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try








        ''  FormInventory.DataGridView1.Rows.Clear()
        ''
        ''  OpenConnection()
        ''  Dim cmd As New MySqlCommand("SELECT * from  inventory", connection)
        ''  Dim dr = cmd.ExecuteReader
        ''
        ''  While dr.Read
        ''      FormInventory.DataGridView1.Rows.Add(dr.Item("No").ToString, dr.Item("Description").ToString, dr.Item("Unit").ToString, dr.Item("QTY").ToString, dr.Item("Remarks").ToString)
        ''  End While
        ''
        ''  'FormInventory.DataGridView1.Sort(FormInventory.DataGridView1.Columns(0), ListSortDirection.Descending)
        ''
        ''  dr.Close()
        ''  connection.Close()






    End Sub

    Sub LoadsReportDetailsAfterAddingNewData()

        Dim table As New DataTable()



        Dim selectedRow As DataGridViewRow
        selectedRow = FormInventory.DataGridView1.Rows(DatagridviewIndexNumberInInventory)


        ' now show data from the selected row to textboxes
        FormInventory.totalDocTxt.Text = selectedRow.Cells(0).Value.ToString()
        FormInventory.descTxt.Text = selectedRow.Cells(1).Value.ToString()
        FormInventory.unitTxt.Text = selectedRow.Cells(2).Value.ToString()
        FormInventory.qtyTxt.Text = selectedRow.Cells(3).Value.ToString()

        Try

            Dim ConvertingNoTxtToInt = Convert.ToInt32(FormInventory.totalDocTxt.Text)
            Dim NewNoPlusOne = ConvertingNoTxtToInt + 1



            Dim imgByte() As Byte


            Dim command As New MySqlCommand("SELECT `no`, `Image` FROM" & DatabaseTable & "WHERE `no` = @NO", connection)
            command.Parameters.Add("@NO", MySqlDbType.Int64).Value = NewNoPlusOne





            Dim adapter As New MySqlDataAdapter(command)

            Try
                adapter.Fill(table)
                If table.Rows.Count = 1 Then

                    imgByte = table(0)(1)

                    Dim ms As New MemoryStream(imgByte)
                    FormInventory.inventoryPictureBox.Image = Image.FromStream(ms)
                    connection.Close()

                End If
            Catch ex As Exception

                FormInventory.inventoryPictureBox.Image = Image.FromFile("" & DoctrackServer & "\Inventory Images\No_images_available.png ")
                '   MessageBox.Show("Picture not found " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message, "Inventory Module", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try





    End Sub

    'Searching in Inventory
    Sub searchInventory()
        connection.Open()
        Dim da As MySqlDataAdapter
        Dim dt As DataTable

        If FormInventory.suppliesCB.SelectedIndex = 0 Then

            da = New MySqlDataAdapter("SELECT `No`, `Description`, `Unit`, `QTY`, `Remarks` FROM `office_supplies` WHERE " & FormInventory.chooseSearchCB.Text & " Like '%" & FormInventory.SearchTB.Text & "%'", connection)
            dt = New DataTable
            da.Fill(dt)
            FormInventory.DataGridView1.DataSource = dt
            FormInventory.DataGridView1.Sort(FormInventory.DataGridView1.Columns(0), ListSortDirection.Descending)
            da.Dispose()


        ElseIf FormInventory.suppliesCB.SelectedIndex = 1 Then

            da = New MySqlDataAdapter("SELECT `No`, `Description`, `Unit`, `QTY`, `Remarks` FROM `comp_smpa` WHERE " & FormInventory.chooseSearchCB.Text & " Like '%" & FormInventory.SearchTB.Text & "%'", connection)
            dt = New DataTable
            da.Fill(dt)
            FormInventory.DataGridView1.DataSource = dt
            FormInventory.DataGridView1.Sort(FormInventory.DataGridView1.Columns(0), ListSortDirection.Descending)
            da.Dispose()
        ElseIf FormInventory.suppliesCB.SelectedIndex = 2 Then
            da = New MySqlDataAdapter("SELECT `No`, `Description`, `Unit`, `QTY`, `Remarks` FROM `janitorial_gmsm` WHERE " & FormInventory.chooseSearchCB.Text & " Like '%" & FormInventory.SearchTB.Text & "%'", connection)
            dt = New DataTable
            da.Fill(dt)
            FormInventory.DataGridView1.DataSource = dt
            FormInventory.DataGridView1.Sort(FormInventory.DataGridView1.Columns(0), ListSortDirection.Descending)
            da.Dispose()
        Else
            da = New MySqlDataAdapter("Select `No`, `Description`, `Unit`, `QTY`, `Remarks` FROM `" & DatabaseTable & "` WHERE " & FormInventory.chooseSearchCB.Text & " Like '%" & FormInventory.SearchTB.Text & "%'", connection)



            dt = New DataTable
            da.Fill(dt)
            FormInventory.DataGridView1.DataSource = dt
            FormInventory.DataGridView1.Sort(FormInventory.DataGridView1.Columns(0), ListSortDirection.Descending)
            da.Dispose()

        End If


        If dt IsNot Nothing AndAlso dt.Rows.Count = 0 Then
            FormInventory.walayRecordLbl.Show()


        Else
            FormInventory.walayRecordLbl.Hide()
        End If

        connection.Close()
    End Sub

    ''' INVENTORY FORM 
    Sub LoadsReportData()
        OpenConnection()




        'getting first row in database
        Dim cmd As New MySqlCommand("SELECT * FROM `inventory_ros` WHERE `ItemDescription` = '" & FormInventory.descTxt.Text & "' ORDER BY No DESC LIMIT 1", connection)
        Dim reader = cmd.ExecuteReader

        'check if mysql table has rows
        If reader.HasRows Then
            Try

                While reader.Read()

                    FormInventory.lastDateReqTxt.Text = reader.Item(6)
                    FormInventory.lastReqByTxt.Text = reader.Item(7) 'Last person who request the item
                    FormInventory.officeTxt.Text = reader.item(8)
                    FormInventory.noOfItemsTxt.Text = reader.item(4)
                End While
                reader.Close()
                cmd.Dispose()
                connection.Close()

            Catch ex As Exception

                MessageBox.Show("There is a problem loading the report side please contact your I.T", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End Try
        Else
            FormInventory.lastDateReqTxt.Text = ""
            FormInventory.lastReqByTxt.Text = ""
            FormInventory.officeTxt.Text = ""
            FormInventory.noOfItemsTxt.Text = ""
        End If

        connection.Close()
    End Sub
    Sub LoadsImage()

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

        Dim command As New MySqlCommand("SELECT `no`, `Image` FROM" & dbtable & "WHERE `no` = @NO", connection)
        command.Parameters.Add("@NO", MySqlDbType.Int64).Value = FormInventory.totalDocTxt.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()



        Try

            adapter.Fill(table)

            Dim imgByte() As Byte
            Try
                If table.Rows.Count = 1 Then

                    imgByte = table(0)(1)

                    Dim ms As New MemoryStream(imgByte)
                    FormInventory.inventoryPictureBox.Image = Image.FromStream(ms)
                    FormRequestProperty.InventoryImageBox.Image = Image.FromStream(ms)
                    FormRequestSupplies.InventoryImageBox.Image = Image.FromStream(ms)
                    FormAddInventory.InventoryImageBox.Image = Image.FromStream(ms)
                    connection.Close()

                End If
            Catch ex As Exception
                FormInventory.inventoryPictureBox.Image = Image.FromFile("" & DoctrackServer & "\Inventory Images\No_images_available.png ")
                '  MessageBox.Show("Picture not found " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        Catch ex As Exception


            'If no image available
            FormInventory.inventoryPictureBox.Image = Image.FromFile("" & DoctrackServer & "\Inventory Images\No_images_available.png ")
            FormRequestProperty.InventoryImageBox.Image = Image.FromFile("" & DoctrackServer & "\Inventory Images\No_images_available.png ")
            FormRequestSupplies.InventoryImageBox.Image = Image.FromFile("" & DoctrackServer & "\Inventory Images\No_images_available.png ")


            connection.Close()

        End Try
    End Sub

    Sub LoadsImageInLogs()




        Dim command As New MySqlCommand("SELECT `No`,`Image` FROM " & DatabaseTable & " WHERE `No` = " & PrimaryKey & "", connection)
        '    command.Parameters.Add("@NO", MySqlDbType.Int64).Value = FormInventory.noTxt.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()



        Try

            adapter.Fill(table)

            Dim imgByte() As Byte
            Try
                If table.Rows.Count = 1 Then

                    imgByte = table(0)(1)

                    Dim ms As New MemoryStream(imgByte)
                    FormRequestProperty.InventoryImageBox.Image = Image.FromStream(ms)
                    FormRequestSupplies.InventoryImageBox.Image = Image.FromStream(ms)


                End If
            Catch ex As Exception
                '  FormInventory.inventoryPictureBox.Image = Image.FromFile("" & DoctrackServer & "\Inventory Images\No_images_available.png ")
                '  '  MessageBox.Show("Picture not found " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        Catch ex As Exception


            'If no image available
            '  FormInventory.inventoryPictureBox.Image = Image.FromFile("" & DoctrackServer & "\Inventory Images\No_images_available.png ")
            '  FormRequestProperty.InventoryImageBox.Image = Image.FromFile("" & DoctrackServer & "\Inventory Images\No_images_available.png ")
            '  FormRequestSupplies.InventoryImageBox.Image = Image.FromFile("" & DoctrackServer & "\Inventory Images\No_images_available.png ")


            connection.Close()

        End Try
    End Sub



End Module
