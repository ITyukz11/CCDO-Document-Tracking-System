<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSignUp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.UsernameTxt = New System.Windows.Forms.TextBox()
        Me.ReTypePasswordTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BrowseBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AdminPasswordTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.DivDistTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProfilePicFilePath = New System.Windows.Forms.TextBox()
        Me.ProfilePictureBox = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.ProfilePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(86, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 22)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(80, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 22)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Username:"
        '
        'PasswordTxt
        '
        Me.PasswordTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PasswordTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTxt.ForeColor = System.Drawing.Color.Black
        Me.PasswordTxt.Location = New System.Drawing.Point(200, 143)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTxt.Size = New System.Drawing.Size(236, 29)
        Me.PasswordTxt.TabIndex = 2
        '
        'UsernameTxt
        '
        Me.UsernameTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsernameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTxt.Location = New System.Drawing.Point(200, 98)
        Me.UsernameTxt.Name = "UsernameTxt"
        Me.UsernameTxt.Size = New System.Drawing.Size(236, 29)
        Me.UsernameTxt.TabIndex = 1
        '
        'ReTypePasswordTxt
        '
        Me.ReTypePasswordTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReTypePasswordTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReTypePasswordTxt.ForeColor = System.Drawing.Color.Black
        Me.ReTypePasswordTxt.Location = New System.Drawing.Point(200, 189)
        Me.ReTypePasswordTxt.Name = "ReTypePasswordTxt"
        Me.ReTypePasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ReTypePasswordTxt.Size = New System.Drawing.Size(236, 29)
        Me.ReTypePasswordTxt.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 22)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Re-type Password:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(27, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 22)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Division / District:"
        '
        'BrowseBtn
        '
        Me.BrowseBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseBtn.Location = New System.Drawing.Point(504, 313)
        Me.BrowseBtn.Name = "BrowseBtn"
        Me.BrowseBtn.Size = New System.Drawing.Size(75, 23)
        Me.BrowseBtn.TabIndex = 6
        Me.BrowseBtn.Text = "Browse"
        Me.BrowseBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(21, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 22)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Admin Password:"
        '
        'AdminPasswordTxt
        '
        Me.AdminPasswordTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdminPasswordTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminPasswordTxt.ForeColor = System.Drawing.Color.Black
        Me.AdminPasswordTxt.Location = New System.Drawing.Point(200, 285)
        Me.AdminPasswordTxt.Name = "AdminPasswordTxt"
        Me.AdminPasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.AdminPasswordTxt.Size = New System.Drawing.Size(236, 29)
        Me.AdminPasswordTxt.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(186, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(273, 33)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Create your account:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(477, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 22)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Profile Picture:"
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.Firebrick
        Me.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backBtn.ForeColor = System.Drawing.Color.White
        Me.backBtn.Location = New System.Drawing.Point(156, 347)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(161, 38)
        Me.backBtn.TabIndex = 8
        Me.backBtn.Text = "Sign in instead"
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.SeaGreen
        Me.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.White
        Me.btnEnter.Location = New System.Drawing.Point(323, 347)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(161, 38)
        Me.btnEnter.TabIndex = 7
        Me.btnEnter.Text = "Sign up"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'DivDistTxt
        '
        Me.DivDistTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DivDistTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DivDistTxt.ForeColor = System.Drawing.Color.Black
        Me.DivDistTxt.Location = New System.Drawing.Point(200, 236)
        Me.DivDistTxt.Name = "DivDistTxt"
        Me.DivDistTxt.Size = New System.Drawing.Size(236, 29)
        Me.DivDistTxt.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(232, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 15)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Created by: CMIS TEAM Yukz"
        '
        'ProfilePicFilePath
        '
        Me.ProfilePicFilePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProfilePicFilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfilePicFilePath.ForeColor = System.Drawing.Color.DarkGray
        Me.ProfilePicFilePath.Location = New System.Drawing.Point(457, 287)
        Me.ProfilePicFilePath.Name = "ProfilePicFilePath"
        Me.ProfilePicFilePath.Size = New System.Drawing.Size(177, 20)
        Me.ProfilePicFilePath.TabIndex = 69
        '
        'ProfilePictureBox
        '
        Me.ProfilePictureBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProfilePictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ProfilePictureBox.Location = New System.Drawing.Point(457, 95)
        Me.ProfilePictureBox.Name = "ProfilePictureBox"
        Me.ProfilePictureBox.Size = New System.Drawing.Size(177, 187)
        Me.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ProfilePictureBox.TabIndex = 61
        Me.ProfilePictureBox.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(665, 423)
        Me.Controls.Add(Me.ProfilePicFilePath)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ProfilePictureBox)
        Me.Controls.Add(Me.AdminPasswordTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BrowseBtn)
        Me.Controls.Add(Me.DivDistTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ReTypePasswordTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PasswordTxt)
        Me.Controls.Add(Me.UsernameTxt)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormSignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSignUp"
        CType(Me.ProfilePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PasswordTxt As TextBox
    Friend WithEvents UsernameTxt As TextBox
    Friend WithEvents ReTypePasswordTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BrowseBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents AdminPasswordTxt As TextBox
    Friend WithEvents ProfilePictureBox As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents backBtn As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents DivDistTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ProfilePicFilePath As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
