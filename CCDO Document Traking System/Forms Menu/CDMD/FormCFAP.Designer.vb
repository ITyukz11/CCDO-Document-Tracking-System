<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCFAP
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.welcomeLbl = New System.Windows.Forms.Label()
        Me.yearLbl = New System.Windows.Forms.Label()
        Me.chooseSearchCB = New System.Windows.Forms.ComboBox()
        Me.StatusTxt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.numLbl = New System.Windows.Forms.Label()
        Me.ChargeTxt = New System.Windows.Forms.TextBox()
        Me.CodeTxt = New System.Windows.Forms.TextBox()
        Me.AmountTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DescriptionTxt = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.yearCB = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SearchTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.walayRecordLbl = New System.Windows.Forms.Label()
        Me.refreshBtn = New FontAwesome.Sharp.IconButton()
        Me.addNewBtn = New FontAwesome.Sharp.IconButton()
        Me.logsBtn = New FontAwesome.Sharp.IconButton()
        Me.openBtn = New FontAwesome.Sharp.IconButton()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'welcomeLbl
        '
        Me.welcomeLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.welcomeLbl.AutoSize = True
        Me.welcomeLbl.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcomeLbl.ForeColor = System.Drawing.Color.Black
        Me.welcomeLbl.Location = New System.Drawing.Point(96, 783)
        Me.welcomeLbl.Name = "welcomeLbl"
        Me.welcomeLbl.Size = New System.Drawing.Size(0, 25)
        Me.welcomeLbl.TabIndex = 142
        '
        'yearLbl
        '
        Me.yearLbl.AutoSize = True
        Me.yearLbl.BackColor = System.Drawing.Color.Transparent
        Me.yearLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.yearLbl.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearLbl.ForeColor = System.Drawing.Color.White
        Me.yearLbl.Location = New System.Drawing.Point(340, 19)
        Me.yearLbl.Name = "yearLbl"
        Me.yearLbl.Size = New System.Drawing.Size(85, 28)
        Me.yearLbl.TabIndex = 135
        Me.yearLbl.Text = "| 2021"
        '
        'chooseSearchCB
        '
        Me.chooseSearchCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.chooseSearchCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chooseSearchCB.FormattingEnabled = True
        Me.chooseSearchCB.Items.AddRange(New Object() {"Description"})
        Me.chooseSearchCB.Location = New System.Drawing.Point(556, 37)
        Me.chooseSearchCB.Name = "chooseSearchCB"
        Me.chooseSearchCB.Size = New System.Drawing.Size(144, 23)
        Me.chooseSearchCB.TabIndex = 137
        '
        'StatusTxt
        '
        Me.StatusTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StatusTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusTxt.Location = New System.Drawing.Point(687, 20)
        Me.StatusTxt.Name = "StatusTxt"
        Me.StatusTxt.ReadOnly = True
        Me.StatusTxt.Size = New System.Drawing.Size(226, 27)
        Me.StatusTxt.TabIndex = 94
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(631, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 17)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "Status:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.StatusTxt)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.numLbl)
        Me.GroupBox3.Controls.Add(Me.ChargeTxt)
        Me.GroupBox3.Controls.Add(Me.CodeTxt)
        Me.GroupBox3.Controls.Add(Me.AmountTxt)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.DescriptionTxt)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox3.Location = New System.Drawing.Point(17, 710)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1203, 127)
        Me.GroupBox3.TabIndex = 146
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Document Overview"
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(604, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 17)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Total Docs:"
        '
        'numLbl
        '
        Me.numLbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.numLbl.AutoSize = True
        Me.numLbl.BackColor = System.Drawing.Color.White
        Me.numLbl.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numLbl.ForeColor = System.Drawing.Color.Black
        Me.numLbl.Location = New System.Drawing.Point(684, 59)
        Me.numLbl.Name = "numLbl"
        Me.numLbl.Size = New System.Drawing.Size(17, 17)
        Me.numLbl.TabIndex = 68
        Me.numLbl.Text = "#"
        '
        'ChargeTxt
        '
        Me.ChargeTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChargeTxt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChargeTxt.Location = New System.Drawing.Point(418, 20)
        Me.ChargeTxt.Name = "ChargeTxt"
        Me.ChargeTxt.ReadOnly = True
        Me.ChargeTxt.Size = New System.Drawing.Size(163, 23)
        Me.ChargeTxt.TabIndex = 72
        '
        'CodeTxt
        '
        Me.CodeTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CodeTxt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodeTxt.Location = New System.Drawing.Point(418, 56)
        Me.CodeTxt.Name = "CodeTxt"
        Me.CodeTxt.ReadOnly = True
        Me.CodeTxt.Size = New System.Drawing.Size(163, 23)
        Me.CodeTxt.TabIndex = 73
        '
        'AmountTxt
        '
        Me.AmountTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AmountTxt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountTxt.Location = New System.Drawing.Point(418, 92)
        Me.AmountTxt.Name = "AmountTxt"
        Me.AmountTxt.ReadOnly = True
        Me.AmountTxt.Size = New System.Drawing.Size(163, 23)
        Me.AmountTxt.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(347, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Charge:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(359, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Code:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(344, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Amount:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Description:"
        '
        'DescriptionTxt
        '
        Me.DescriptionTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DescriptionTxt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTxt.Location = New System.Drawing.Point(94, 20)
        Me.DescriptionTxt.Multiline = True
        Me.DescriptionTxt.Name = "DescriptionTxt"
        Me.DescriptionTxt.ReadOnly = True
        Me.DescriptionTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DescriptionTxt.Size = New System.Drawing.Size(193, 95)
        Me.DescriptionTxt.TabIndex = 70
        '
        'yearCB
        '
        Me.yearCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.yearCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearCB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.yearCB.FormattingEnabled = True
        Me.yearCB.Items.AddRange(New Object() {"2021", "2020", "2019", "2018", "2017", "2016"})
        Me.yearCB.Location = New System.Drawing.Point(556, 66)
        Me.yearCB.Name = "yearCB"
        Me.yearCB.Size = New System.Drawing.Size(144, 23)
        Me.yearCB.TabIndex = 140
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(459, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 16)
        Me.Label12.TabIndex = 138
        Me.Label12.Text = "Type of Search:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(517, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 16)
        Me.Label13.TabIndex = 139
        Me.Label13.Text = "Year:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 41
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.DataGridView1.Location = New System.Drawing.Point(13, 112)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(1207, 592)
        Me.DataGridView1.TabIndex = 148
        '
        'SearchTB
        '
        Me.SearchTB.BackColor = System.Drawing.SystemColors.HighlightText
        Me.SearchTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTB.Location = New System.Drawing.Point(15, 56)
        Me.SearchTB.Name = "SearchTB"
        Me.SearchTB.Size = New System.Drawing.Size(409, 47)
        Me.SearchTB.TabIndex = 134
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(327, 23)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "CCDO OFFICE DOCUMENT SEARCH"
        '
        'walayRecordLbl
        '
        Me.walayRecordLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.walayRecordLbl.BackColor = System.Drawing.Color.White
        Me.walayRecordLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.walayRecordLbl.Location = New System.Drawing.Point(101, 335)
        Me.walayRecordLbl.Name = "walayRecordLbl"
        Me.walayRecordLbl.Size = New System.Drawing.Size(1019, 153)
        Me.walayRecordLbl.TabIndex = 141
        Me.walayRecordLbl.Text = "qweqw"
        Me.walayRecordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'refreshBtn
        '
        Me.refreshBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.refreshBtn.FlatAppearance.BorderSize = 0
        Me.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.refreshBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.refreshBtn.IconChar = FontAwesome.Sharp.IconChar.SyncAlt
        Me.refreshBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.refreshBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.refreshBtn.IconSize = 32
        Me.refreshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.refreshBtn.Location = New System.Drawing.Point(1086, 18)
        Me.refreshBtn.Name = "refreshBtn"
        Me.refreshBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.refreshBtn.Size = New System.Drawing.Size(134, 85)
        Me.refreshBtn.TabIndex = 143
        Me.refreshBtn.Text = "Refresh"
        Me.refreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.refreshBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.refreshBtn.UseVisualStyleBackColor = True
        '
        'addNewBtn
        '
        Me.addNewBtn.FlatAppearance.BorderSize = 0
        Me.addNewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addNewBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addNewBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.addNewBtn.IconChar = FontAwesome.Sharp.IconChar.FolderPlus
        Me.addNewBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.addNewBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.addNewBtn.IconSize = 32
        Me.addNewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addNewBtn.Location = New System.Drawing.Point(720, 15)
        Me.addNewBtn.Name = "addNewBtn"
        Me.addNewBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.addNewBtn.Size = New System.Drawing.Size(115, 88)
        Me.addNewBtn.TabIndex = 145
        Me.addNewBtn.Text = "Add New"
        Me.addNewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addNewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.addNewBtn.UseVisualStyleBackColor = True
        '
        'logsBtn
        '
        Me.logsBtn.FlatAppearance.BorderSize = 0
        Me.logsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logsBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logsBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.logsBtn.IconChar = FontAwesome.Sharp.IconChar.Server
        Me.logsBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.logsBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.logsBtn.IconSize = 32
        Me.logsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logsBtn.Location = New System.Drawing.Point(841, 17)
        Me.logsBtn.Name = "logsBtn"
        Me.logsBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.logsBtn.Size = New System.Drawing.Size(115, 85)
        Me.logsBtn.TabIndex = 144
        Me.logsBtn.Text = "Logs"
        Me.logsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.logsBtn.UseVisualStyleBackColor = True
        '
        'openBtn
        '
        Me.openBtn.FlatAppearance.BorderSize = 0
        Me.openBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.openBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.openBtn.IconChar = FontAwesome.Sharp.IconChar.FolderOpen
        Me.openBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.openBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.openBtn.IconSize = 32
        Me.openBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.openBtn.Location = New System.Drawing.Point(962, 15)
        Me.openBtn.Name = "openBtn"
        Me.openBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.openBtn.Size = New System.Drawing.Size(117, 88)
        Me.openBtn.TabIndex = 147
        Me.openBtn.Text = "Open"
        Me.openBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.openBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.openBtn.UseVisualStyleBackColor = True
        '
        'FormCFAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1233, 852)
        Me.Controls.Add(Me.refreshBtn)
        Me.Controls.Add(Me.welcomeLbl)
        Me.Controls.Add(Me.addNewBtn)
        Me.Controls.Add(Me.yearLbl)
        Me.Controls.Add(Me.chooseSearchCB)
        Me.Controls.Add(Me.logsBtn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.openBtn)
        Me.Controls.Add(Me.yearCB)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.SearchTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.walayRecordLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormCFAP"
        Me.Text = "CFAP"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer2 As Timer
    Friend WithEvents refreshBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents welcomeLbl As Label
    Friend WithEvents addNewBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents yearLbl As Label
    Friend WithEvents chooseSearchCB As ComboBox
    Friend WithEvents logsBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents StatusTxt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents numLbl As Label
    Friend WithEvents ChargeTxt As TextBox
    Friend WithEvents CodeTxt As TextBox
    Friend WithEvents AmountTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DescriptionTxt As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents openBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents yearCB As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SearchTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents walayRecordLbl As Label
End Class
