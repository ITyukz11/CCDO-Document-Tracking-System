Imports MySql.Data.MySqlClient
Public Class FormPRPO
    Private Sub PR_PO_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        walayRecordLbl.Hide()
        chooseSearchCB.Text = "PR_Details"





    End Sub

    Private Sub addNewBtn_Click(sender As Object, e As EventArgs) Handles addNewBtn.Click
        'getting the value of ManualNo
        GettingNumber()

        FormAddPRPO.PRDetailsTxt.Select()


        FormAddPRPO.PRDetailsTxt.Text = ""
        FormAddPRPO.DNumberTxt.Text = ""
        FormAddPRPO.DPDraftPRTxt.Text = ""
        FormAddPRPO.DRFinalPRTxt.Text = ""
        FormAddPRPO.PRNumberTxt.Text = ""
        FormAddPRPO.DPCDraftTxt.Text = ""
        FormAddPRPO.DPCFinalTxt.Text = ""
        FormAddPRPO.DProcessedPOTxt.Text = ""
        FormAddPRPO.DApprovePOTxt.Text = ""
        FormAddPRPO.CBstatus.Text = ""
        FormAddPRPO.StatusTxt.Text = ""

        FormAddPRPO.SaveBtn.Enabled = True
        FormAddPRPO.CBupdateStatus.Enabled = False
        FormAddPRPO.updateBTN.Enabled = False
        FormAddPRPO.PrintBtn.Enabled = False
        FormAddPRPO.SaveBtn.Enabled = True
        FormAddPRPO.DeleteBtn.Enabled = False

        FormAddPRPO.LBLstatGuide1.Text = "_____________________"
        FormAddPRPO.LBLstatGuide2.Text = "_____________________"
        FormAddPRPO.LBLstatGuide3.Text = "_____________________"
        FormAddPRPO.LBLstatGuide4.Text = "_____________________"


        FormAddPRPO.dateTxt.Text = Date.Now.ToString("yyyy/MM/dd HH:mm:ss")


        FormAddPRPO.ShowDialog()
    End Sub



    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        RefreshDataGridViewPRPO()
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

            '  searchPRPO()
        End If

    End Sub

    Private Sub openBtn_Click(sender As Object, e As EventArgs) Handles openBtn.Click
        'This will catch the error unabling to click COLUMN HEADER Chmba coding is real
        If FormAddPRPO.NoLbl.Text.Any Then

            FormAddPRPO.updateBTN.Select()
            FormAddPRPO.CBupdateStatus.Enabled = True
            FormAddPRPO.updateBTN.Enabled = True
            FormAddPRPO.PrintBtn.Enabled = True
            FormAddPRPO.SaveBtn.Enabled = False
            FormAddPRPO.DeleteBtn.Enabled = True


            FormAddPRPO.ShowDialog()

            'clear cbstatus to override and avoid duplication of entry
            FormAddPRPO.CBstatus.Items.Clear()
        Else

            MessageBox.Show("Please click the document you want to open", "Tagapag-paalala", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        DataGridView1.Columns(5).DefaultCellStyle.BackColor = Color.Yellow

    End Sub

    Private Sub logsBtn_Click(sender As Object, e As EventArgs) Handles logsBtn.Click
        '    RefreshDataGridViewAdminLogs()
        '    FormAdminLogs.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer

        ' get the index of the selected datagridview row
        index = e.RowIndex


        Try
            If index = -1 Then
                'do nothing
            Else
                Dim selectedRow As DataGridViewRow
                selectedRow = DataGridView1.Rows(index)


                ' now show data from the selected row to textboxes
                FormAddPRPO.NoLbl.Text = selectedRow.Cells(0).Value.ToString()
                FormAddPRPO.PRDetailsTxt.Text = selectedRow.Cells(1).Value.ToString()
                FormAddPRPO.DNumberTxt.Text = selectedRow.Cells(2).Value.ToString()
                FormAddPRPO.PRNumberTxt.Text = selectedRow.Cells(3).Value.ToString()
                FormAddPRPO.dateTxt.Text = selectedRow.Cells(4).Value.ToString()
                FormAddPRPO.StatusTxt.Text = selectedRow.Cells(5).Value.ToString()




                FormAddPRPO.SaveBtn.Enabled = False

                'Reader
                '  pr_po_statusGuide()
                '   DisplayPRPOOverview()
                DisplayPRPOOtherInfo()

                'This will catch the error unabling to click COLUMN HEADER Chmba coding is real
                If FormAddPRPO.NoLbl.Text.Any Then

                    'Do nothing

                End If

                If DocTrackLogin.TxtBoxUsername.Text.Length > 0 Then
                    FormAddPRPO.SaveBtn.Enabled = True
                    FormAddPRPO.updateBTN.Enabled = True
                    FormAddPRPO.DeleteBtn.Enabled = True


                End If


            End If
        Catch

            MessageBox.Show("Error: " & ErrorToString(), "Form PR PO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        'This will catch the error unabling to click COLUMN HEADER Chmba coding is real


        FormAddPRPO.updateBTN.Select()
            FormAddPRPO.CBupdateStatus.Enabled = True
            FormAddPRPO.updateBTN.Enabled = True
            FormAddPRPO.PrintBtn.Enabled = True
            FormAddPRPO.SaveBtn.Enabled = False
            FormAddPRPO.DeleteBtn.Enabled = True


            FormAddPRPO.ShowDialog()

            'clear cbstatus to override and avoid duplication of entry
            FormAddPRPO.CBstatus.Items.Clear()

    End Sub
End Class