Imports System.ComponentModel
Imports ClosedXML.Excel
Imports DocumentFormat.OpenXml.Spreadsheet
Imports MySql.Data.MySqlClient
Public Class FormReport

    Dim exceltable As New DataTable()
    Private Sub FormReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        monthCB.SelectedIndex = 0
        officeCB.SelectedIndex = 0



        Dim checked As Boolean = True   ' Set to True or False, as required.
        For i As Integer = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, checked)
        Next

        LoadsTotalNoTxt()

    End Sub

    Sub LoadsReport()
        OpenConnection()

        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `No`, `ItemDescription`, `BegBalance`, `DateDelivered`, `NumofItemsReq`, `Unit`, `DateReq`, `ReqBy`, `Office`, `EndBalance` FROM `inventory_ros` WHERE `DateReq` LIKE ""%" & monthCB.Text & "%"" AND `Office` LIKE ""%" & officeCB.Text & "%""", connection)
        adapter.Fill(table)
        DataGridView1.DataSource = table
        DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Descending)



        connection.Close()
    End Sub

    Sub LoadsTotalNoTxt()
        OpenConnection()
        Dim cmd As New MySqlCommand("Select COUNT(*) FROM `inventory_ros` WHERE `DateReq` LIKE ""%" & monthCB.Text & "%"" AND `Office` LIKE ""%" & officeCB.Text & "%"" ", connection)
        Dim i As Integer = cmd.ExecuteScalar()

        connection.Close()
        totalNoLabelTxt.Text = "Total No: " & i
    End Sub

    Private Sub monthCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles monthCB.SelectedIndexChanged
        LoadsReport()
        LoadsTotalNoTxt()
    End Sub

    Private Sub officeCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles officeCB.SelectedIndexChanged
        LoadsReport()
        LoadsTotalNoTxt()
    End Sub

    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        'Collection array
        Dim collection As New List(Of String)()

        For i As Integer = 0 To CheckedListBox1.Items.Count - 1


            Dim Item As Object = CheckedListBox1.Items(i)

            'We ask if this item is checked or not
            If CheckedListBox1.GetItemChecked(i) Then
                'Do something if Item is checked
                'Adding item checked inside the array + the ` ` for the syntax of mysql 
                collection.Add("`" & CheckedListBox1.GetItemText(CheckedListBox1.Items(i)) & "`")

            Else
                'Do something else if Item is not checked
            End If
        Next

        Dim data As String

        ' , as separator + the array string
        data = String.Join(",", collection)



        Console.WriteLine(data)

        OpenConnection()

        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT " & data & " FROM `inventory_ros` WHERE `DateReq` LIKE ""%" & monthCB.Text & "%"" AND `Office` LIKE ""%" & officeCB.Text & "%""", connection)
        Try
            If data = "" Then
                MessageBox.Show("Please select column!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                adapter.Fill(table)
                DataGridView1.DataSource = table
                DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Descending)
            End If

        Catch ex As Exception
            MessageBox.Show("You have 0 Column!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try




        connection.Close()
    End Sub

    Private Sub exportToExcelTBtn_Click(sender As Object, e As EventArgs) Handles exportToExcelTBtn.Click
        Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "excelWorkbook |*.xlsx"}
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using workbook As XLWorkbook = New XLWorkbook()
                        Dim asd = workbook.Worksheets.Add(Me.DataGridView1.DataSource, "Inventory Report").Columns.AdjustToContents()
                        workbook.SaveAs(sfd.FileName)



                        MessageBox.Show("You have successfully exported inventory report to an excel file", "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub
End Class