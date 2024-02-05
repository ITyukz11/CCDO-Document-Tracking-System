Public Class LoadingForm

    Dim X As Integer
   
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        FormOfficeDocs.Show()
        Timer2.Start()
        Timer1.Stop()




    End Sub

    Private Sub LoadingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FormOfficeDocs.WindowState = FormWindowState.Minimized
        Timer1.Start()
        ' ProgressBar1.Increment(20)


    End Sub



    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


        ProgressBar1.Value += 5
        X = ProgressBar1.Value
        Label2.Text = "Fetching Database " & ProgressBar1.Value.ToString & "%"

        If ProgressBar1.Value + 5 >= ProgressBar1.Maximum Then
            ProgressBar1.Value = ProgressBar1.Maximum
            ' MsgBox("Posting Completed!")
            Label2.Text = "Fetching Data Successfully " & ProgressBar1.Value.ToString & "%"
            FormOfficeDocs.BringToFront()
            FormOfficeDocs.WindowState = FormWindowState.Maximized
            Me.Hide()
            FormOfficeDocs.Show()

            Timer2.Stop()
            Timer1.Stop()




        ElseIf ProgressBar1.Value = 30 Then
            'default combo box search -particulars, -2019year and -incoming
            Label2.Text = "Loads Data Table " & ProgressBar1.Value.ToString & "%"

            FormOfficeDocs.yearCB.SelectedIndex = 0
            FormOfficeDocs.inc_out_CB.SelectedIndex = 0

        ElseIf ProgressBar1.Value = 40 Then
            Label1.Text = "Loading."

        ElseIf ProgressBar1.Value = 45 Then
            Label1.Text = "Loading.."
            Label2.Text = "Fetching Data Design " & ProgressBar1.Value.ToString & "%"





        ElseIf ProgressBar1.Value = 50 Then
            Label1.Text = "Loading..."
            Label2.Text = "Fetching User Data " & ProgressBar1.Value.ToString & "%"

        ElseIf ProgressBar1.Value = 55 Then
            Label1.Text = "Loading"
            Label2.Text = "Loads all credentials " & ProgressBar1.Value.ToString & "%"


        ElseIf ProgressBar1.Value = 60 Then
            Label1.Text = "Loading."
            Label2.Text = "Loads all credentials " & ProgressBar1.Value.ToString & "%"

        ElseIf ProgressBar1.Value = 65 Then
            Label1.Text = "Loading.."
            Label2.Text = "Fetching User Data " & ProgressBar1.Value.ToString & "%"

        ElseIf ProgressBar1.Value = 80 Then
            Label1.Text = "Loading..."
            Label2.Text = "Fetching User Data " & ProgressBar1.Value.ToString & "%"

        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class