<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DocTrackLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocTrackLogin))
        Me.backBtn = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBoxPassword = New System.Windows.Forms.TextBox()
        Me.TxtBoxUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SignUpBtn = New FontAwesome.Sharp.IconButton()
        Me.btnView = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'backBtn
        '
        Me.backBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.backBtn.BackColor = System.Drawing.Color.Firebrick
        Me.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backBtn.ForeColor = System.Drawing.Color.White
        Me.backBtn.Location = New System.Drawing.Point(28, 423)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(318, 38)
        Me.backBtn.TabIndex = 44
        Me.backBtn.Text = "Exit"
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'btnEnter
        '
        Me.btnEnter.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnter.BackColor = System.Drawing.Color.SeaGreen
        Me.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.White
        Me.btnEnter.Location = New System.Drawing.Point(28, 379)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(318, 38)
        Me.btnEnter.TabIndex = 43
        Me.btnEnter.Text = "LOGIN"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 320)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 22)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 22)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Username:"
        '
        'TxtBoxPassword
        '
        Me.TxtBoxPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBoxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxPassword.ForeColor = System.Drawing.Color.Black
        Me.TxtBoxPassword.Location = New System.Drawing.Point(130, 316)
        Me.TxtBoxPassword.Name = "TxtBoxPassword"
        Me.TxtBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtBoxPassword.Size = New System.Drawing.Size(200, 29)
        Me.TxtBoxPassword.TabIndex = 47
        '
        'TxtBoxUsername
        '
        Me.TxtBoxUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBoxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxUsername.Location = New System.Drawing.Point(130, 275)
        Me.TxtBoxUsername.Name = "TxtBoxUsername"
        Me.TxtBoxUsername.Size = New System.Drawing.Size(200, 29)
        Me.TxtBoxUsername.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(35, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(311, 37)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Document Tracking"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(75, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 37)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "System Login"
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.ForeColor = System.Drawing.Color.Silver
        Me.CheckBox1.Location = New System.Drawing.Point(130, 352)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox1.TabIndex = 53
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'SignUpBtn
        '
        Me.SignUpBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SignUpBtn.FlatAppearance.BorderSize = 0
        Me.SignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignUpBtn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignUpBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.SignUpBtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.SignUpBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.SignUpBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SignUpBtn.IconSize = 25
        Me.SignUpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SignUpBtn.Location = New System.Drawing.Point(276, -4)
        Me.SignUpBtn.Name = "SignUpBtn"
        Me.SignUpBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.SignUpBtn.Size = New System.Drawing.Size(116, 50)
        Me.SignUpBtn.TabIndex = 55
        Me.SignUpBtn.Text = "Sign up"
        Me.SignUpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SignUpBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SignUpBtn.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnView.FlatAppearance.BorderSize = 0
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnView.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.btnView.IconColor = System.Drawing.Color.Gainsboro
        Me.btnView.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnView.IconSize = 32
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.Location = New System.Drawing.Point(105, 462)
        Me.btnView.Name = "btnView"
        Me.btnView.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnView.Size = New System.Drawing.Size(165, 35)
        Me.btnView.TabIndex = 54
        Me.btnView.Text = "Viewing Only"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnView.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(105, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 166)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'DocTrackLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(372, 509)
        Me.Controls.Add(Me.SignUpBtn)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBoxPassword)
        Me.Controls.Add(Me.TxtBoxUsername)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.btnEnter)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DocTrackLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DocTrackLogin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents backBtn As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBoxPassword As TextBox
    Friend WithEvents TxtBoxUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnView As FontAwesome.Sharp.IconButton
    Friend WithEvents SignUpBtn As FontAwesome.Sharp.IconButton
End Class
