

Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class FormOfficeDocs



    Dim No As Integer
    Dim dt As DataTable
    Dim i As Integer






    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        yearCB.SelectedIndex = 0
        inc_out_CB.SelectedIndex = 0
        walayRecordLbl.Hide()



        'addform
        addform.SaveBtn.Enabled = False
        addform.deleteBtn.Enabled = False
        addform.updateBTN.Enabled = False


        welcomeLbl.Hide()

        SearchTB.Text = "Search document here"
        SearchTB.ForeColor = Color.Gray




    End Sub

    'SEARCH
    Private Sub SearchTB_MouseEnter(sender As Object, e As EventArgs) Handles SearchTB.MouseEnter

        If SearchTB.Text = "Search document here" Then
            SearchTB.Text = ""
            SearchTB.ForeColor = Color.Black
        End If




    End Sub
    Private Sub SearchTB_MouseLeave(sender As Object, e As EventArgs) Handles SearchTB.MouseLeave

        If SearchTB.Text = "" Then
            SearchTB.Text = "Search document here"
            SearchTB.ForeColor = Color.Gray
            DataGridView1.Select()
        End If

    End Sub
    Private Sub SearchTB_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchTB.KeyDown

        If (e.KeyCode = Keys.Enter) Then
            If SearchTB.Text = "" Then

                BlankSearch = True

            End If
            SearchOfficeDocuments()

        End If



    End Sub



    Private Sub yearCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles yearCB.SelectedIndexChanged
        walayRecordLbl.Text = ""
        walayRecordLbl.Hide()
        yearLbl.Text = yearCB.SelectedItem

        If inc_out_CB.Text = "Incoming" Or inc_out_CB.Text = "Outgoing" Then
            RefreshDataGridView()
        End If


        DataGridView1.Select()
    End Sub


    Private Sub addNewBtn_Click(sender As Object, e As EventArgs) Handles addNewBtn.Click
        addform.particularTB.Text = ""
        addform.refTB.Text = "8761-"

        addform.subTB.Text = ""
        addform.divTB.Text = ""
        addform.districtTB.Text = ""
        addform.forwardTB.Text = ""
        addform.remarksTB.Text = ""

        addform.dateTb.Text = ""
        addform.SaveBtn.Enabled = True
        addform.dateTb.Text = Date.Now.ToString("MM/dd/yyyy HH:mm:ss")

        Addform.TransactionCB.SelectedIndex = 0
        Addform.updateBTN.Enabled = False
        Addform.ShowDialog()

        If inc_out_CB.Text = "Incoming" Then
            addform.dateRRLB.Text = "Date Received"
        Else
            addform.dateRRLB.Text = "Date Released"
        End If
    End Sub

    Private Sub Inc_out_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles inc_out_CB.SelectedIndexChanged

        walayRecordLbl.Text = ""
        walayRecordLbl.Hide()

        ' RefreshDataGridView() 'changesyuki




        If inc_out_CB.Text = "Incoming" Then
            addform.dateRRLB.Text = "Date Received:"
            RefreshDataGridView()
        ElseIf inc_out_CB.Text = "Outgoing" Then
            addform.dateRRLB.Text = "Date Released:"
            RefreshDataGridView()
        End If

        DataGridView1.Select()

    End Sub

    Private Sub DataGridView1_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles DataGridView1.ColumnAdded
        For i = 0 To DataGridView1.Columns.Count - 1
            DataGridView1.Columns.Item(i).SortMode = DataGridViewColumnSortMode.Programmatic
        Next i
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click

        RefreshDataGridView()
        DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Descending)

    End Sub

    Private Sub LogsBtn_Click(sender As Object, e As EventArgs) Handles logsBtn.Click
        logStatsDGV()
        ShowLogDGV()

        FormOfficeLogs.ShowDialog()
    End Sub





    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer

        ' get the index of the selected datagridview row
        index = e.RowIndex

        Dim selectedRow As DataGridViewRow


        OfficeDGVIndex = index


        If index = -1 Then
            'do nothing
        Else

            OpenConnection()

            selectedRow = DataGridView1.Rows(index)
            No = selectedRow.Cells(0).Value.ToString()
            'getting string in database 
            Dim cmd As New MySqlCommand("SELECT * FROM doctrack" & yearCB.Text & "" & inc_out_CB.Text & "tb WHERE `No` = " & No & "", connection)
            Dim reader = cmd.ExecuteReader

            Try

                While reader.Read()

                    Addform.NoLbl.Text = reader.item(0)
                    Addform.particularTB.Text = reader.item(1)
                    Addform.dateTb.Text = reader.item(2)
                    Addform.refTB.Text = reader.item(3)
                    Addform.subTB.Text = reader.item(4)
                    Addform.divTB.Text = reader.item(5)
                    Addform.districtTB.Text = reader.item(6)
                    Addform.forwardTB.Text = reader.item(7)
                    Addform.remarksTB.Text = reader.item(8)
                    Addform.dateRRTB.Text = reader.item(9)
                    Addform.TransactionCB.Text = reader.item(10)


                    particularTB.Text = reader.item(1)
                    refTB.Text = reader.item(3)
                    subTB.Text = reader.item(4)
                    divTB.Text = reader.item(5)
                    districtTB.Text = reader.item(6)
                    forwardTB.Text = reader.item(7)
                    remarksTB.Text = reader.item(8)
                    dateRRTB.Text = reader.item(9)
                    TransactionTxt.Text = reader.item(10)

                    pathTxt.Text = DoctrackServer & "" & inc_out_CB.Text & " " & yearCB.Text & "\" & refTB.Text & ".pdf"
                    pdfName.Text = refTB.Text

                End While
                reader.Close()
                cmd.Dispose()
                connection.Close()

            Catch ex As Exception

                MsgBox("REMINDER: Pag upload ug profile picture d mag sigeg ulaw ulaw, e click lang ang profile! -_- ")

            End Try

            addform.SaveBtn.Enabled = False





        End If

        If AxAcroPDF1 Is Nothing Then
            AxAcroPDF1.src = PDF_FILE



        Else
            'do nothing
        End If



    End Sub
    Private Sub ViewBtn_Click(sender As Object, e As EventArgs) Handles viewBtn.Click


        If pathTxt.Text = "" And pdfName.Text = "" Then
            MsgBox("Nothing to view!", MsgBoxStyle.Exclamation, "Access Denied!!")
        Else
            PDF_FILE = AxAcroPDF1.src
            FormViewPDF.AxAcroPDF2.src = PDF_FILE

            FormViewPDF.Show()
        End If
    End Sub
    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        If pathTxt.Text = "" And pdfName.Text = "" Then
            MsgBox("Nothing to print!", MsgBoxStyle.Exclamation, "Access Denied!!")
        Else
            AxAcroPDF1.Print()
        End If
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If DocTrackLogin.TxtBoxUsername.Text = "totets" Or DocTrackLogin.TxtBoxUsername.Text = "thea" Or DocTrackLogin.TxtBoxUsername.Text = "admin" Or DocTrackLogin.TxtBoxUsername.Text = "earl" Then

            If inc_out_CB.SelectedIndex = 0 Then
                DateReceived_or_Released = "DateReceived"
            Else
                DateReceived_or_Released = "DateReleased"
            End If
            Addform.updateBTN.Enabled = True
            Addform.deleteBtn.Enabled = True
        Else

        End If

        addform.ShowDialog()
    End Sub

    Private Sub pathTxt_TextChanged(sender As Object, e As EventArgs) Handles pathTxt.TextChanged
        AxAcroPDF1.LoadFile(pathTxt.Text)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
