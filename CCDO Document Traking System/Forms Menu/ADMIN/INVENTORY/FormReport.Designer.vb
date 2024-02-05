<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReport
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.totalNoLabelTxt = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.monthCB = New System.Windows.Forms.ComboBox()
        Me.officeCB = New System.Windows.Forms.ComboBox()
        Me.exportToExcelTBtn = New FontAwesome.Sharp.IconButton()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.refreshBtn = New FontAwesome.Sharp.IconButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Month:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(306, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Office:"
        '
        'totalNoLabelTxt
        '
        Me.totalNoLabelTxt.AutoSize = True
        Me.totalNoLabelTxt.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalNoLabelTxt.Location = New System.Drawing.Point(538, 149)
        Me.totalNoLabelTxt.Name = "totalNoLabelTxt"
        Me.totalNoLabelTxt.Size = New System.Drawing.Size(60, 17)
        Me.totalNoLabelTxt.TabIndex = 5
        Me.totalNoLabelTxt.Text = "Total No:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.ColumnHeadersHeight = 55
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(12, 172)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.RowTemplate.Height = 100
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(1189, 340)
        Me.DataGridView1.TabIndex = 59
        '
        'monthCB
        '
        Me.monthCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.monthCB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monthCB.FormattingEnabled = True
        Me.monthCB.Items.AddRange(New Object() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"})
        Me.monthCB.Location = New System.Drawing.Point(309, 137)
        Me.monthCB.Name = "monthCB"
        Me.monthCB.Size = New System.Drawing.Size(223, 29)
        Me.monthCB.TabIndex = 60
        '
        'officeCB
        '
        Me.officeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.officeCB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeCB.FormattingEnabled = True
        Me.officeCB.Items.AddRange(New Object() {"Main-Admin", "Main-CDMD", "Main-PMEU", "Main-IETD", "Main-CMIS", "CLTC", "Poblaction", "Agdao", "Bunawan", "Paquibato", "Talomo", "Tugbok", "Toril", "Marilog", "Baguio", "Calinan", "Buhangin"})
        Me.officeCB.Location = New System.Drawing.Point(309, 82)
        Me.officeCB.Name = "officeCB"
        Me.officeCB.Size = New System.Drawing.Size(223, 29)
        Me.officeCB.TabIndex = 61
        '
        'exportToExcelTBtn
        '
        Me.exportToExcelTBtn.FlatAppearance.BorderSize = 0
        Me.exportToExcelTBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.exportToExcelTBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exportToExcelTBtn.ForeColor = System.Drawing.Color.Black
        Me.exportToExcelTBtn.IconChar = FontAwesome.Sharp.IconChar.FileExport
        Me.exportToExcelTBtn.IconColor = System.Drawing.Color.Black
        Me.exportToExcelTBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.exportToExcelTBtn.IconSize = 32
        Me.exportToExcelTBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.exportToExcelTBtn.Location = New System.Drawing.Point(130, 116)
        Me.exportToExcelTBtn.Name = "exportToExcelTBtn"
        Me.exportToExcelTBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.exportToExcelTBtn.Size = New System.Drawing.Size(173, 50)
        Me.exportToExcelTBtn.TabIndex = 144
        Me.exportToExcelTBtn.Text = "Export to Excel"
        Me.exportToExcelTBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.exportToExcelTBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.exportToExcelTBtn.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"No", "ItemDescription", "BegBalance", "DateDelivered", "NumofItemsReq", "Unit", "DateReq", "ReqBy", "Office", "EndBalance"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(15, 12)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(109, 154)
        Me.CheckedListBox1.TabIndex = 145
        '
        'refreshBtn
        '
        Me.refreshBtn.FlatAppearance.BorderSize = 0
        Me.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.refreshBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshBtn.ForeColor = System.Drawing.Color.Black
        Me.refreshBtn.IconChar = FontAwesome.Sharp.IconChar.SyncAlt
        Me.refreshBtn.IconColor = System.Drawing.Color.Black
        Me.refreshBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.refreshBtn.IconSize = 32
        Me.refreshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.refreshBtn.Location = New System.Drawing.Point(130, 61)
        Me.refreshBtn.Name = "refreshBtn"
        Me.refreshBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.refreshBtn.Size = New System.Drawing.Size(173, 50)
        Me.refreshBtn.TabIndex = 147
        Me.refreshBtn.Text = "Refresh Database"
        Me.refreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.refreshBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.refreshBtn.UseVisualStyleBackColor = True
        '
        'FormReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1213, 524)
        Me.Controls.Add(Me.refreshBtn)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.exportToExcelTBtn)
        Me.Controls.Add(Me.officeCB)
        Me.Controls.Add(Me.monthCB)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.totalNoLabelTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "FormReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormReport"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents totalNoLabelTxt As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents monthCB As ComboBox
    Friend WithEvents officeCB As ComboBox
    Friend WithEvents exportToExcelTBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents refreshBtn As FontAwesome.Sharp.IconButton
End Class
