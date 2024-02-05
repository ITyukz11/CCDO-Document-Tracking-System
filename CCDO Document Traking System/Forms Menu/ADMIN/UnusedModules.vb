Imports System.ComponentModel
Imports System.IO
Imports MySql.Data.MySqlClient
Module UnusedModules
    Sub RefreshDataGridViewPRPO()
        OpenConnection()


        FormPRPO.yearCB.Text = "2021"




        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `No`, `PR_Details`, `Doctrack#`, `PR#`, `Date` ,`Status` FROM `pr_po` ", connection)
        adapter.Fill(table)
        FormPRPO.DataGridView1.DataSource = table




        Dim cmd As New MySqlCommand("Select COUNT(*) FROM pr_po", connection)
        Dim i As Integer = cmd.ExecuteScalar()


        connection.Close()


        FormPRPO.numLbl.Text = i
        FormPRPO.DataGridView1.Sort(FormPRPO.DataGridView1.Columns(0), ListSortDirection.Descending)




    End Sub


    Sub RefreshDataGridViewLiquidation()
        OpenConnection()


        FormCFAP.yearCB.Text = "2021"




        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM `liquidation`", connection)
        adapter.Fill(table)
        FormCFAP.DataGridView1.DataSource = table

        Dim cmd As New MySqlCommand("Select COUNT(*) FROM liquidation", connection)
        Dim i As Integer = cmd.ExecuteScalar()
        cmd = Nothing
        connection.Close()
        FormCFAP.numLbl.Text = i
        FormCFAP.DataGridView1.Sort(FormCFAP.DataGridView1.Columns(0), ListSortDirection.Descending)
    End Sub


    Sub GettingNumber()

        Try
            OpenConnection()


            'getting string in database 
            Dim cmd As New MySqlCommand("SELECT No FROM pr_po ORDER BY No DESC LIMIT 1", connection)
            Dim latestNo As Integer = cmd.ExecuteScalar()



            FormAddPRPO.NoLbl.Text = latestNo + 1


            cmd.Dispose()
            connection.Close()

        Catch ex As Exception

            MsgBox("Error has occured:" & ErrorToString())

        End Try
    End Sub
    Sub DisplayPRPOOtherInfo()
        Try
            OpenConnection()


            'getting string in database 
            Dim cmd As New MySqlCommand("Select * FROM pr_po WHERE No = " & FormAddPRPO.NoLbl.Text & "", connection)
            Dim reader = cmd.ExecuteReader

            While reader.Read()


                FormAddPRPO.PRDetailsTxt.Text = reader.Item(1)
                FormAddPRPO.DNumberTxt.Text = reader.Item(2)
                FormAddPRPO.DPDraftPRTxt.Text = reader.Item(3)
                FormAddPRPO.DRFinalPRTxt.Text = reader.Item(4)
                FormAddPRPO.DPCDraftTxt.Text = reader.Item(6)
                FormAddPRPO.DPCFinalTxt.Text = reader.Item(7)
                FormAddPRPO.DProcessedPOTxt.Text = reader.Item(8)
                FormAddPRPO.DApprovePOTxt.Text = reader.Item(9)
            End While
            reader.Close()
            cmd.Dispose()
            connection.Close()

        Catch ex As Exception

            MsgBox("Error has occured:" & ErrorToString())

        End Try
    End Sub
    Sub DisplayPRPOOverview()

        Try
            OpenConnection()


            'getting string in database 
            Dim cmd As New MySqlCommand("Select * FROM pr_po WHERE No = " & FormAddPRPO.NoLbl.Text & "", connection)
            Dim reader = cmd.ExecuteReader

            While reader.Read()
                FormPRPO.PRDetailsTxt.Text = reader.Item(1)
                FormPRPO.DoctrackNumTxt.Text = reader.Item(2)
                FormPRPO.DPDraftPRTxt.Text = reader.Item(3)
                FormPRPO.DRFinalPRTxt.Text = reader.Item(4)
                FormPRPO.PRnumberTxt.Text = reader.item(5)
                FormPRPO.DPCDraftTxt.Text = reader.Item(6)
                FormPRPO.DPCFinalTxt.Text = reader.Item(7)
                FormPRPO.DProcessedPOTxt.Text = reader.Item(8)
                FormPRPO.DApprovePOTxt.Text = reader.Item(9)
                FormPRPO.StatusTxt.Text = reader.Item(11)


            End While
            reader.Close()
            cmd.Dispose()
            connection.Close()

        Catch ex As Exception

            MsgBox("Error has occured:" & ErrorToString())

        End Try

    End Sub




    Sub DisplayLiquidationOverview()

        Try
            OpenConnection()


            'getting string in database 
            Dim cmd As New MySqlCommand("SELECT * FROM `liquidation` WHERE No = " & FormAddCFAP.NoLbl.Text & "", connection)
            Dim reader = cmd.ExecuteReader

            While reader.Read()
                FormCFAP.ChargeTxt.Text = reader.Item(1)
                FormCFAP.CodeTxt.Text = reader.Item(2)
                FormCFAP.DescriptionTxt.Text = reader.Item(3)
                FormCFAP.AmountTxt.Text = reader.Item(4)
                FormCFAP.StatusTxt.Text = reader.item(6)


            End While
            reader.Close()
            cmd.Dispose()
            connection.Close()

        Catch ex As Exception

            MsgBox("Error has occured:" & ErrorToString())

        End Try

    End Sub
    Sub pr_po_statusGuide()
        Try
            OpenConnection()


            'getting string in database 
            Dim cmd As New MySqlCommand("SELECT `Status`,`Status2`,`Status3`,`Status4` ,`DateEncoded`,`DateUpdated`,`ProcessedTime` FROM `pr_po_status_guide` WHERE `ForeignNo` =" & FormAddPRPO.NoLbl.Text & "", connection)
            Dim reader = cmd.ExecuteReader

            While reader.Read()
                FormAddPRPO.LBLstatGuide1.Text = reader.Item(0)
                FormAddPRPO.LBLstatGuide2.Text = reader.Item(1)
                FormAddPRPO.LBLstatGuide3.Text = reader.Item(2)
                FormAddPRPO.LBLstatGuide4.Text = reader.Item(3)
                FormAddPRPO.dateEncodedLbl.Text = reader.Item(4)
                FormAddPRPO.dateUpdatedLbl.Text = reader.Item(5)
                FormAddPRPO.processedTimeLbl.Text = reader.Item(6)




            End While
            reader.Close()
            cmd.Dispose()
            connection.Close()

        Catch ex As Exception

            MsgBox("Error has occured:" & ErrorToString())

        End Try
    End Sub






End Module
