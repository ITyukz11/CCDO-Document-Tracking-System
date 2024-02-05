<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogs
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.requestOfPropertyBTN = New FontAwesome.Sharp.IconButton()
        Me.requestOfSuppliesBTN = New FontAwesome.Sharp.IconButton()
        Me.ActionLogsBTN = New FontAwesome.Sharp.IconButton()
        Me.SearchTB = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.walayRecordLbl = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 55
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(0, 206)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowTemplate.Height = 100
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(1427, 407)
        Me.DataGridView1.TabIndex = 58
        '
        'requestOfPropertyBTN
        '
        Me.requestOfPropertyBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.requestOfPropertyBTN.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.requestOfPropertyBTN.FlatAppearance.BorderSize = 0
        Me.requestOfPropertyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.requestOfPropertyBTN.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestOfPropertyBTN.ForeColor = System.Drawing.Color.Black
        Me.requestOfPropertyBTN.IconChar = FontAwesome.Sharp.IconChar.FolderOpen
        Me.requestOfPropertyBTN.IconColor = System.Drawing.Color.Black
        Me.requestOfPropertyBTN.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.requestOfPropertyBTN.IconSize = 32
        Me.requestOfPropertyBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.requestOfPropertyBTN.Location = New System.Drawing.Point(899, 112)
        Me.requestOfPropertyBTN.Name = "requestOfPropertyBTN"
        Me.requestOfPropertyBTN.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.requestOfPropertyBTN.Size = New System.Drawing.Size(168, 88)
        Me.requestOfPropertyBTN.TabIndex = 135
        Me.requestOfPropertyBTN.Text = "Request Property Logs"
        Me.requestOfPropertyBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.requestOfPropertyBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.requestOfPropertyBTN.UseVisualStyleBackColor = False
        '
        'requestOfSuppliesBTN
        '
        Me.requestOfSuppliesBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.requestOfSuppliesBTN.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.requestOfSuppliesBTN.FlatAppearance.BorderSize = 0
        Me.requestOfSuppliesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.requestOfSuppliesBTN.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestOfSuppliesBTN.ForeColor = System.Drawing.Color.Black
        Me.requestOfSuppliesBTN.IconChar = FontAwesome.Sharp.IconChar.FolderOpen
        Me.requestOfSuppliesBTN.IconColor = System.Drawing.Color.Black
        Me.requestOfSuppliesBTN.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.requestOfSuppliesBTN.IconSize = 32
        Me.requestOfSuppliesBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.requestOfSuppliesBTN.Location = New System.Drawing.Point(1073, 112)
        Me.requestOfSuppliesBTN.Name = "requestOfSuppliesBTN"
        Me.requestOfSuppliesBTN.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.requestOfSuppliesBTN.Size = New System.Drawing.Size(168, 88)
        Me.requestOfSuppliesBTN.TabIndex = 136
        Me.requestOfSuppliesBTN.Text = "Request Supplies Logs"
        Me.requestOfSuppliesBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.requestOfSuppliesBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.requestOfSuppliesBTN.UseVisualStyleBackColor = False
        '
        'ActionLogsBTN
        '
        Me.ActionLogsBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActionLogsBTN.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ActionLogsBTN.FlatAppearance.BorderSize = 0
        Me.ActionLogsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ActionLogsBTN.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActionLogsBTN.ForeColor = System.Drawing.Color.Black
        Me.ActionLogsBTN.IconChar = FontAwesome.Sharp.IconChar.FolderOpen
        Me.ActionLogsBTN.IconColor = System.Drawing.Color.Black
        Me.ActionLogsBTN.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ActionLogsBTN.IconSize = 32
        Me.ActionLogsBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ActionLogsBTN.Location = New System.Drawing.Point(1247, 112)
        Me.ActionLogsBTN.Name = "ActionLogsBTN"
        Me.ActionLogsBTN.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.ActionLogsBTN.Size = New System.Drawing.Size(168, 88)
        Me.ActionLogsBTN.TabIndex = 137
        Me.ActionLogsBTN.Text = "Action Logs"
        Me.ActionLogsBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ActionLogsBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ActionLogsBTN.UseVisualStyleBackColor = False
        '
        'SearchTB
        '
        Me.SearchTB.BackColor = System.Drawing.SystemColors.HighlightText
        Me.SearchTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTB.Location = New System.Drawing.Point(295, 153)
        Me.SearchTB.Name = "SearchTB"
        Me.SearchTB.Size = New System.Drawing.Size(422, 47)
        Me.SearchTB.TabIndex = 139
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CCDO_Document_Traking_System.My.Resources.Resources.logs
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(277, 188)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 138
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(899, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(425, 22)
        Me.Label1.TabIndex = 140
        Me.Label1.Text = "Please choose what type of logs your looking:"
        '
        'walayRecordLbl
        '
        Me.walayRecordLbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.walayRecordLbl.BackColor = System.Drawing.Color.White
        Me.walayRecordLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.walayRecordLbl.Location = New System.Drawing.Point(382, 367)
        Me.walayRecordLbl.Name = "walayRecordLbl"
        Me.walayRecordLbl.Size = New System.Drawing.Size(687, 96)
        Me.walayRecordLbl.TabIndex = 141
        Me.walayRecordLbl.Text = "No Record Found"
        Me.walayRecordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.walayRecordLbl.Visible = False
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IconButton1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.Black
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.FolderOpen
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 32
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(723, 112)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton1.Size = New System.Drawing.Size(170, 88)
        Me.IconButton1.TabIndex = 142
        Me.IconButton1.Text = "Print Report"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'FormLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1427, 618)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.walayRecordLbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchTB)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ActionLogsBTN)
        Me.Controls.Add(Me.requestOfSuppliesBTN)
        Me.Controls.Add(Me.requestOfPropertyBTN)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.Name = "FormLogs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLogs"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents requestOfPropertyBTN As FontAwesome.Sharp.IconButton
    Friend WithEvents requestOfSuppliesBTN As FontAwesome.Sharp.IconButton
    Friend WithEvents ActionLogsBTN As FontAwesome.Sharp.IconButton
    Friend WithEvents SearchTB As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents walayRecordLbl As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
