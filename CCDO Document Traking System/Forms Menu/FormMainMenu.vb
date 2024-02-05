Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient
Public Class FormMainMenu
    'Fields'
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    Private panelshow = ""
    'Creating FormTrapping to prevent error on clicking Forms repeatedly
    Private FormTrapping = ""

    'Constructor'
    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.'
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 44)
        PanelMenu.Controls.Add(leftBorderBtn)
        'Form'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub
    'Methods'
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon'
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(26, 25, 62)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub
    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text
    End Sub
    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.MediumPurple
        lblFormTitle.Text = "Home"
    End Sub
    'Events'
    'Reset'
    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
            FormTrapping = "OpenImgHome"
        End If
        Reset()

    End Sub
    'Menu buttons Cliks'
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click


        If FormTrapping = "OpenDashboard" Then
            'Do Nothing
        Else
            ActivateButton(sender, RGBColors.color1)
            OpenChildForm(New FormDashboard)
            FormTrapping = "OpenDashboard"
        End If

    End Sub
    Private Sub btnOfficeDocs_Click(sender As Object, e As EventArgs) Handles btnOfficeDocs.Click

        If FormTrapping = "OpenOfficeDocs" Then
            'Do Nothing
        Else

            ActivateButton(sender, RGBColors.color2)
            OpenChildForm(FormOfficeDocs)


            FormTrapping = "OpenOfficeDocs"
        End If


    End Sub
    Private Sub BtnPrPo_Click(sender As Object, e As EventArgs) Handles btnPrPo.Click


        If FormTrapping = "OpenFormPrPo" Then
            'Do Nothing
        Else

            ActivateButton(sender, RGBColors.color3)
            OpenChildForm(FormPRPO)
            RefreshDataGridViewPRPO()
            FormTrapping = "OpenFormPrPo"
        End If


    End Sub



    Private Sub FormCFAPbtn_Click(sender As Object, e As EventArgs) Handles FormCFAPbtn.Click



        If FormTrapping = "OpenFormCFAP" Then
            'Do Nothing
        Else
            ActivateButton(sender, RGBColors.color7)
            OpenChildForm(FormCFAP)

            FormTrapping = "OpenFormCFAP"
        End If

    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click


        If FormTrapping = "OpenFormInventory" Then
            'Do Nothing
        Else
            ActivateButton(sender, RGBColors.color6)
            OpenChildForm(FormInventory)

            FormTrapping = "OpenFormInventory"
        End If
    End Sub
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click


        If FormTrapping = "OpenFormSettings" Then
            'Do Nothing
        Else
            ActivateButton(sender, RGBColors.color8)
            OpenChildForm(New FormSettings)
            FormTrapping = "OpenFormSettings"
        End If
    End Sub

    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    'Close-Maximize-Minimize'
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal

        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
    'Remove transparent border in maximized state'
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub SliderOpenBtn_Click(sender As Object, e As EventArgs) Handles SliderOpenBtn.Click
        If panelshow = "panelmenuhide" Then
            PanelMenu.Show()
            panelshow = "panelmenushow"
        Else
            PanelMenu.Hide()
            panelshow = "panelmenuhide"
        End If
    End Sub



    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Dim result = MessageBox.Show("Are you sure you want to logout?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If (result = DialogResult.Yes) Then

            Me.Hide()
            ProfilePictureBox.Image = Nothing
            DocTrackLogin.TxtBoxUsername.Clear()
            DocTrackLogin.TxtBoxPassword.Clear()
            DocTrackLogin.TxtBoxUsername.Select()

            FormAddPRPO.updateBTN.Enabled = True
            FormAddPRPO.SaveBtn.Enabled = True
            FormAddPRPO.DeleteBtn.Enabled = True


            DocTrackLogin.Show()

        Else

        End If

    End Sub

    Private Sub ProfileBtn_Click(sender As Object, e As EventArgs) Handles ProfileBtn.Click
        DisplayProfile()

    End Sub

    Private Sub FormMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'To avoid FLICKERING
        modMain.DoubleBufferedPanel(PanelDesktop, True)
        modMain.DoubleBufferedPanel(PanelLogo, True)
        modMain.DoubleBufferedPanel(PanelMenu, True)
        modMain.DoubleBufferedPanel(PanelTitleBar, True)






    End Sub



    'To Avoid Flickering
    'https://www.vbforums.com/showthread.php?851055-RESOLVED-How-to-remove-blinking-when-load-form
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property



    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FormSuggestionBox.Show()
    End Sub


End Class
'............................................'
