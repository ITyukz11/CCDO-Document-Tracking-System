Imports MySql.Data.MySqlClient
Public Class FormRequestProperty
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        'Auto select the row that have been recently selected in datagridview
        RefreshDataGridViewInventory()
        FormInventory.DataGridView1.Rows(DatagridviewIndexNumberInInventory).Selected = True
        Me.Close()
    End Sub

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        If reqByTxt.Text = "" Or returnByTxt.Text = "" Then

            MessageBox.Show("Please input who requested the item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        Else


            Dim command As New MySqlCommand("INSERT INTO `inventory_rop`(`propertyDescription`, `propertyNo`, `condi`, `reqBy`, `purpose`, `returnedOn`, `returnedBy`, `remarks`) 
                                        VALUES (@PD,@PN,@CON,@REQB,@PUR,@RO,@RB,@RMK)", connection)

            ' filling inventory Database table         
            command.Parameters.Add("@PD", MySqlDbType.VarChar).Value = descTxt.Text
            command.Parameters.Add("@PN", MySqlDbType.VarChar).Value = propNoTxt.Text
            command.Parameters.Add("@CON", MySqlDbType.VarChar).Value = condTxt.Text
            command.Parameters.Add("@REQB", MySqlDbType.VarChar).Value = reqByTxt.Text
            command.Parameters.Add("@PUR", MySqlDbType.VarChar).Value = purposeTxt.Text
            command.Parameters.Add("@RO", MySqlDbType.VarChar).Value = returnOnCb.Text
            command.Parameters.Add("@RB", MySqlDbType.VarChar).Value = returnByTxt.Text
            command.Parameters.Add("@RMK", MySqlDbType.VarChar).Value = remarksTxt.Text

            Dim dbtable

            If FormInventory.suppliesCB.SelectedIndex = 0 Then

                dbtable = "`office_supplies`"
            ElseIf FormInventory.suppliesCB.SelectedIndex = 1 Then

                dbtable = "`comp_smpa`"
            Else
                dbtable = "`janitorial_gmsm`"
            End If




            connection.Open()

            Try
                command.ExecuteNonQuery()


                MessageBox.Show("Success!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                connection.Close()
                RefreshDataGridViewInventory()
                NoLbl.Text = ""
                ClearAllText()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Can't save to database, please contact team CMIS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If


    End Sub

    Sub ClearAllText()
        descTxt.Text = ""
        propNoTxt.Text = ""
        condTxt.Text = ""
        reqByTxt.Text = ""
        purposeTxt.Text = ""
        returnOnCb.Text = ""
        returnByTxt.Text = ""
        remarksTxt.Text = ""
    End Sub

    Private Sub FormRequestProperty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateTb.Text = Date.Now
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click

    End Sub
End Class