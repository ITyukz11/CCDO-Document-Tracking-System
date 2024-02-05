Imports System.ComponentModel
Public Class FormOfficeLogs
    Private Sub Logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressReport()
        'DataGridView2.Sort(DataGridView2.Columns(0), ListSortDirection.Descending)
        chooseSearchCB.SelectedIndex = 0
        Panel1.BackColor = Color.FromArgb(20, 25, 72)
        SearchTB2.Text = "Search..."
        SearchTB2.ForeColor = Color.Gray
        DataGridView3.Sort(DataGridView3.Columns(0), ListSortDirection.Descending)
    End Sub
    Private Sub SearchTB2_MouseEnter(sender As Object, e As EventArgs) Handles SearchTB2.MouseEnter
        If SearchTB2.Text = "Search..." Then
            SearchTB2.Text = ""
            SearchTB2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub SearchTB2_MouseLeave(sender As Object, e As EventArgs) Handles SearchTB2.MouseLeave
        If SearchTB2.Text = "" Then
            SearchTB2.Text = "Search..."
            SearchTB2.ForeColor = Color.Gray
        End If

    End Sub
    Private Sub SearchTB2_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchTB2.KeyDown
        If (e.KeyCode = Keys.Enter) Then

            searchLogs()

        End If

    End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub
End Class