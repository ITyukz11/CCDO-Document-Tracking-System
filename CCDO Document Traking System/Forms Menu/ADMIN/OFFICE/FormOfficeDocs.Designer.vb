<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormOfficeDocs
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOfficeDocs))
        Me.SearchTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.yearCB = New System.Windows.Forms.ComboBox()
        Me.inc_out_CB = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.walayRecordLbl = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.yearLbl = New System.Windows.Forms.Label()
        Me.welcomeLbl = New System.Windows.Forms.Label()
        Me.refreshBtn = New FontAwesome.Sharp.IconButton()
        Me.logsBtn = New FontAwesome.Sharp.IconButton()
        Me.addNewBtn = New FontAwesome.Sharp.IconButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TransactionTxt = New System.Windows.Forms.TextBox()
        Me.dateRRLB = New System.Windows.Forms.Label()
        Me.dateRRTB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.forwardTB = New System.Windows.Forms.TextBox()
        Me.remarksTB = New System.Windows.Forms.TextBox()
        Me.districtTB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.refTB = New System.Windows.Forms.TextBox()
        Me.subTB = New System.Windows.Forms.TextBox()
        Me.divTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.particularTB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.viewBtn = New FontAwesome.Sharp.IconButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pdfName = New System.Windows.Forms.TextBox()
        Me.pathTxt = New System.Windows.Forms.TextBox()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.PrintBtn = New FontAwesome.Sharp.IconButton()
        Me.NoTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchTB
        '
        Me.SearchTB.BackColor = System.Drawing.SystemColors.HighlightText
        Me.SearchTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTB.Location = New System.Drawing.Point(12, 55)
        Me.SearchTB.Name = "SearchTB"
        Me.SearchTB.Size = New System.Drawing.Size(409, 47)
        Me.SearchTB.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(327, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CCDO OFFICE DOCUMENT SEARCH"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(510, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 17)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "Year:"
        '
        'yearCB
        '
        Me.yearCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.yearCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearCB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.yearCB.FormattingEnabled = True
        Me.yearCB.Items.AddRange(New Object() {"2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016"})
        Me.yearCB.Location = New System.Drawing.Point(553, 50)
        Me.yearCB.Name = "yearCB"
        Me.yearCB.Size = New System.Drawing.Size(125, 23)
        Me.yearCB.TabIndex = 71
        '
        'inc_out_CB
        '
        Me.inc_out_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.inc_out_CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inc_out_CB.FormattingEnabled = True
        Me.inc_out_CB.Items.AddRange(New Object() {"Incoming", "Outgoing"})
        Me.inc_out_CB.Location = New System.Drawing.Point(553, 22)
        Me.inc_out_CB.Name = "inc_out_CB"
        Me.inc_out_CB.Size = New System.Drawing.Size(125, 23)
        Me.inc_out_CB.TabIndex = 72
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(421, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(127, 17)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "Incoming/Outgoing:"
        '
        'walayRecordLbl
        '
        Me.walayRecordLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.walayRecordLbl.BackColor = System.Drawing.Color.White
        Me.walayRecordLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!)
        Me.walayRecordLbl.Location = New System.Drawing.Point(94, 334)
        Me.walayRecordLbl.Name = "walayRecordLbl"
        Me.walayRecordLbl.Size = New System.Drawing.Size(584, 70)
        Me.walayRecordLbl.TabIndex = 85
        Me.walayRecordLbl.Text = "Way Record!"
        Me.walayRecordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'yearLbl
        '
        Me.yearLbl.AutoSize = True
        Me.yearLbl.BackColor = System.Drawing.Color.Transparent
        Me.yearLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.yearLbl.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearLbl.ForeColor = System.Drawing.Color.White
        Me.yearLbl.Location = New System.Drawing.Point(337, 18)
        Me.yearLbl.Name = "yearLbl"
        Me.yearLbl.Size = New System.Drawing.Size(85, 28)
        Me.yearLbl.TabIndex = 1
        Me.yearLbl.Text = "| 2023"
        '
        'welcomeLbl
        '
        Me.welcomeLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.welcomeLbl.AutoSize = True
        Me.welcomeLbl.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcomeLbl.ForeColor = System.Drawing.Color.Black
        Me.welcomeLbl.Location = New System.Drawing.Point(93, 699)
        Me.welcomeLbl.Name = "welcomeLbl"
        Me.welcomeLbl.Size = New System.Drawing.Size(0, 25)
        Me.welcomeLbl.TabIndex = 89
        '
        'refreshBtn
        '
        Me.refreshBtn.FlatAppearance.BorderSize = 0
        Me.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.refreshBtn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.refreshBtn.IconChar = FontAwesome.Sharp.IconChar.SyncAlt
        Me.refreshBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.refreshBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.refreshBtn.IconSize = 32
        Me.refreshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.refreshBtn.Location = New System.Drawing.Point(819, 18)
        Me.refreshBtn.Name = "refreshBtn"
        Me.refreshBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.refreshBtn.Size = New System.Drawing.Size(127, 84)
        Me.refreshBtn.TabIndex = 93
        Me.refreshBtn.Text = "Refresh"
        Me.refreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.refreshBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.refreshBtn.UseVisualStyleBackColor = True
        '
        'logsBtn
        '
        Me.logsBtn.FlatAppearance.BorderSize = 0
        Me.logsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.logsBtn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logsBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.logsBtn.IconChar = FontAwesome.Sharp.IconChar.Server
        Me.logsBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.logsBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.logsBtn.IconSize = 32
        Me.logsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logsBtn.Location = New System.Drawing.Point(684, 17)
        Me.logsBtn.Name = "logsBtn"
        Me.logsBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.logsBtn.Size = New System.Drawing.Size(127, 41)
        Me.logsBtn.TabIndex = 94
        Me.logsBtn.Text = "Logs"
        Me.logsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.logsBtn.UseVisualStyleBackColor = True
        '
        'addNewBtn
        '
        Me.addNewBtn.FlatAppearance.BorderSize = 0
        Me.addNewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addNewBtn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addNewBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.addNewBtn.IconChar = FontAwesome.Sharp.IconChar.FolderPlus
        Me.addNewBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.addNewBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.addNewBtn.IconSize = 32
        Me.addNewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addNewBtn.Location = New System.Drawing.Point(686, 64)
        Me.addNewBtn.Name = "addNewBtn"
        Me.addNewBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.addNewBtn.Size = New System.Drawing.Size(127, 39)
        Me.addNewBtn.TabIndex = 95
        Me.addNewBtn.Text = "Add New"
        Me.addNewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addNewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.addNewBtn.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.TransactionTxt)
        Me.GroupBox3.Controls.Add(Me.dateRRLB)
        Me.GroupBox3.Controls.Add(Me.dateRRTB)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.forwardTB)
        Me.GroupBox3.Controls.Add(Me.remarksTB)
        Me.GroupBox3.Controls.Add(Me.districtTB)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.refTB)
        Me.GroupBox3.Controls.Add(Me.subTB)
        Me.GroupBox3.Controls.Add(Me.divTB)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.particularTB)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox3.Location = New System.Drawing.Point(16, 626)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1026, 132)
        Me.GroupBox3.TabIndex = 97
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Document Overview"
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(779, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 17)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "Transaction Type:"
        '
        'TransactionTxt
        '
        Me.TransactionTxt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionTxt.Location = New System.Drawing.Point(782, 40)
        Me.TransactionTxt.Multiline = True
        Me.TransactionTxt.Name = "TransactionTxt"
        Me.TransactionTxt.ReadOnly = True
        Me.TransactionTxt.Size = New System.Drawing.Size(130, 23)
        Me.TransactionTxt.TabIndex = 86
        '
        'dateRRLB
        '
        Me.dateRRLB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dateRRLB.AutoSize = True
        Me.dateRRLB.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateRRLB.ForeColor = System.Drawing.Color.White
        Me.dateRRLB.Location = New System.Drawing.Point(632, 78)
        Me.dateRRLB.Name = "dateRRLB"
        Me.dateRRLB.Size = New System.Drawing.Size(108, 17)
        Me.dateRRLB.TabIndex = 85
        Me.dateRRLB.Text = "Date Received:"
        '
        'dateRRTB
        '
        Me.dateRRTB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dateRRTB.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateRRTB.Location = New System.Drawing.Point(635, 98)
        Me.dateRRTB.Name = "dateRRTB"
        Me.dateRRTB.ReadOnly = True
        Me.dateRRTB.Size = New System.Drawing.Size(130, 23)
        Me.dateRRTB.TabIndex = 84
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(779, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 17)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "Remarks:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(632, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 17)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Forwarded To:"
        '
        'forwardTB
        '
        Me.forwardTB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.forwardTB.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forwardTB.Location = New System.Drawing.Point(635, 41)
        Me.forwardTB.Name = "forwardTB"
        Me.forwardTB.ReadOnly = True
        Me.forwardTB.Size = New System.Drawing.Size(130, 23)
        Me.forwardTB.TabIndex = 79
        '
        'remarksTB
        '
        Me.remarksTB.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remarksTB.Location = New System.Drawing.Point(782, 98)
        Me.remarksTB.Multiline = True
        Me.remarksTB.Name = "remarksTB"
        Me.remarksTB.ReadOnly = True
        Me.remarksTB.Size = New System.Drawing.Size(130, 23)
        Me.remarksTB.TabIndex = 80
        '
        'districtTB
        '
        Me.districtTB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.districtTB.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.districtTB.Location = New System.Drawing.Point(472, 98)
        Me.districtTB.Name = "districtTB"
        Me.districtTB.ReadOnly = True
        Me.districtTB.Size = New System.Drawing.Size(151, 23)
        Me.districtTB.TabIndex = 78
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(469, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 17)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "District:"
        '
        'refTB
        '
        Me.refTB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.refTB.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refTB.Location = New System.Drawing.Point(309, 41)
        Me.refTB.Name = "refTB"
        Me.refTB.ReadOnly = True
        Me.refTB.Size = New System.Drawing.Size(151, 23)
        Me.refTB.TabIndex = 72
        '
        'subTB
        '
        Me.subTB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.subTB.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subTB.Location = New System.Drawing.Point(310, 98)
        Me.subTB.Name = "subTB"
        Me.subTB.ReadOnly = True
        Me.subTB.Size = New System.Drawing.Size(151, 23)
        Me.subTB.TabIndex = 73
        '
        'divTB
        '
        Me.divTB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.divTB.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.divTB.Location = New System.Drawing.Point(472, 41)
        Me.divTB.Name = "divTB"
        Me.divTB.ReadOnly = True
        Me.divTB.Size = New System.Drawing.Size(151, 23)
        Me.divTB.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(306, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 17)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Reference Number:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(307, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Submitted By:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(469, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 17)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Department / Division:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Particulars:"
        '
        'particularTB
        '
        Me.particularTB.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.particularTB.Location = New System.Drawing.Point(15, 40)
        Me.particularTB.Multiline = True
        Me.particularTB.Name = "particularTB"
        Me.particularTB.ReadOnly = True
        Me.particularTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.particularTB.Size = New System.Drawing.Size(286, 81)
        Me.particularTB.TabIndex = 70
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(437, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 17)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Total Documents:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.ColumnHeadersHeight = 55
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(12, 111)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(755, 509)
        Me.DataGridView1.TabIndex = 56
        '
        'viewBtn
        '
        Me.viewBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewBtn.FlatAppearance.BorderSize = 0
        Me.viewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.viewBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.viewBtn.IconChar = FontAwesome.Sharp.IconChar.FileUpload
        Me.viewBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.viewBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.viewBtn.IconSize = 32
        Me.viewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.viewBtn.Location = New System.Drawing.Point(911, 580)
        Me.viewBtn.Name = "viewBtn"
        Me.viewBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.viewBtn.Size = New System.Drawing.Size(131, 39)
        Me.viewBtn.TabIndex = 105
        Me.viewBtn.Text = "View"
        Me.viewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.viewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.viewBtn.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(782, 497)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 17)
        Me.Label11.TabIndex = 104
        Me.Label11.Text = "Path:"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(773, 552)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 17)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "Name:"
        '
        'pdfName
        '
        Me.pdfName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pdfName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pdfName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pdfName.Location = New System.Drawing.Point(826, 552)
        Me.pdfName.Multiline = True
        Me.pdfName.Name = "pdfName"
        Me.pdfName.Size = New System.Drawing.Size(216, 20)
        Me.pdfName.TabIndex = 102
        '
        'pathTxt
        '
        Me.pathTxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pathTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pathTxt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathTxt.Location = New System.Drawing.Point(826, 498)
        Me.pathTxt.Multiline = True
        Me.pathTxt.Name = "pathTxt"
        Me.pathTxt.Size = New System.Drawing.Size(216, 48)
        Me.pathTxt.TabIndex = 101
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(776, 111)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(266, 381)
        Me.AxAcroPDF1.TabIndex = 100
        '
        'PrintBtn
        '
        Me.PrintBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintBtn.FlatAppearance.BorderSize = 0
        Me.PrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PrintBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.PrintBtn.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.PrintBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.PrintBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.PrintBtn.IconSize = 32
        Me.PrintBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintBtn.Location = New System.Drawing.Point(773, 580)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.PrintBtn.Size = New System.Drawing.Size(131, 39)
        Me.PrintBtn.TabIndex = 106
        Me.PrintBtn.Text = "Print"
        Me.PrintBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PrintBtn.UseVisualStyleBackColor = True
        '
        'NoTxt
        '
        Me.NoTxt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoTxt.Location = New System.Drawing.Point(553, 79)
        Me.NoTxt.Name = "NoTxt"
        Me.NoTxt.ReadOnly = True
        Me.NoTxt.Size = New System.Drawing.Size(125, 23)
        Me.NoTxt.TabIndex = 86
        '
        'FormOfficeDocs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1054, 765)
        Me.Controls.Add(Me.NoTxt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.walayRecordLbl)
        Me.Controls.Add(Me.PrintBtn)
        Me.Controls.Add(Me.viewBtn)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.pdfName)
        Me.Controls.Add(Me.pathTxt)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.addNewBtn)
        Me.Controls.Add(Me.inc_out_CB)
        Me.Controls.Add(Me.logsBtn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.refreshBtn)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.welcomeLbl)
        Me.Controls.Add(Me.yearCB)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.yearLbl)
        Me.Controls.Add(Me.SearchTB)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormOfficeDocs"
        Me.Text = "Office Document"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents yearCB As ComboBox
    Friend WithEvents inc_out_CB As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents walayRecordLbl As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents yearLbl As Label
    Friend WithEvents welcomeLbl As Label
    Friend WithEvents refreshBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents logsBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents addNewBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents particularTB As TextBox
    Friend WithEvents refTB As TextBox
    Friend WithEvents subTB As TextBox
    Friend WithEvents divTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents forwardTB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents districtTB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents remarksTB As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dateRRLB As Label
    Friend WithEvents dateRRTB As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents viewBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents pdfName As TextBox
    Friend WithEvents pathTxt As TextBox
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents PrintBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents NoTxt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TransactionTxt As TextBox
End Class
