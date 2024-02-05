<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRequestSupplies
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
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.descTb = New System.Windows.Forms.TextBox()
        Me.begBalanceTxt = New System.Windows.Forms.TextBox()
        Me.dateDelvTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.JLabel2 = New System.Windows.Forms.Label()
        Me.CLabel1 = New System.Windows.Forms.Label()
        Me.OLabel0 = New System.Windows.Forms.Label()
        Me.unitTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.endBalanceTxt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.numItemReqTxt = New System.Windows.Forms.TextBox()
        Me.officesCb = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.reqByTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dateReqTxt = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ActionGB = New System.Windows.Forms.GroupBox()
        Me.closeBtn = New FontAwesome.Sharp.IconButton()
        Me.deleteBtn = New FontAwesome.Sharp.IconButton()
        Me.updateBTN = New FontAwesome.Sharp.IconButton()
        Me.submitBtn = New FontAwesome.Sharp.IconButton()
        Me.InventoryImageBox = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dateTb = New System.Windows.Forms.TextBox()
        Me.NoLbl = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ActionGB.SuspendLayout()
        CType(Me.InventoryImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 21)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "# of Items Requested:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(42, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Item Description:"
        '
        'descTb
        '
        Me.descTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descTb.Location = New System.Drawing.Point(189, 49)
        Me.descTb.Multiline = True
        Me.descTb.Name = "descTb"
        Me.descTb.ReadOnly = True
        Me.descTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.descTb.Size = New System.Drawing.Size(275, 116)
        Me.descTb.TabIndex = 0
        Me.descTb.TabStop = False
        '
        'begBalanceTxt
        '
        Me.begBalanceTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.begBalanceTxt.Location = New System.Drawing.Point(189, 171)
        Me.begBalanceTxt.Name = "begBalanceTxt"
        Me.begBalanceTxt.ReadOnly = True
        Me.begBalanceTxt.Size = New System.Drawing.Size(275, 27)
        Me.begBalanceTxt.TabIndex = 1
        Me.begBalanceTxt.TabStop = False
        '
        'dateDelvTxt
        '
        Me.dateDelvTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateDelvTxt.Location = New System.Drawing.Point(189, 207)
        Me.dateDelvTxt.Name = "dateDelvTxt"
        Me.dateDelvTxt.ReadOnly = True
        Me.dateDelvTxt.Size = New System.Drawing.Size(275, 27)
        Me.dateDelvTxt.TabIndex = 2
        Me.dateDelvTxt.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(25, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 21)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Beginning Balance:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(51, 213)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(132, 21)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Date Delivered:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.JLabel2)
        Me.GroupBox2.Controls.Add(Me.CLabel1)
        Me.GroupBox2.Controls.Add(Me.OLabel0)
        Me.GroupBox2.Controls.Add(Me.unitTxt)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.ActionGB)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.descTb)
        Me.GroupBox2.Controls.Add(Me.begBalanceTxt)
        Me.GroupBox2.Controls.Add(Me.dateDelvTxt)
        Me.GroupBox2.Controls.Add(Me.InventoryImageBox)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox2.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(693, 575)
        Me.GroupBox2.TabIndex = 86
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Form"
        '
        'JLabel2
        '
        Me.JLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.JLabel2.AutoSize = True
        Me.JLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JLabel2.ForeColor = System.Drawing.Color.White
        Me.JLabel2.Location = New System.Drawing.Point(137, -3)
        Me.JLabel2.Name = "JLabel2"
        Me.JLabel2.Size = New System.Drawing.Size(416, 21)
        Me.JLabel2.TabIndex = 112
        Me.JLabel2.Text = "Janitorial, Groceries and Medical Supplies & Materials"
        Me.JLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.JLabel2.Visible = False
        '
        'CLabel1
        '
        Me.CLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CLabel1.AutoSize = True
        Me.CLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLabel1.ForeColor = System.Drawing.Color.White
        Me.CLabel1.Location = New System.Drawing.Point(113, -3)
        Me.CLabel1.Name = "CLabel1"
        Me.CLabel1.Size = New System.Drawing.Size(462, 21)
        Me.CLabel1.TabIndex = 111
        Me.CLabel1.Text = "Computer Supplies, Materials, Peripherals and Accessories"
        Me.CLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CLabel1.Visible = False
        '
        'OLabel0
        '
        Me.OLabel0.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.OLabel0.AutoSize = True
        Me.OLabel0.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OLabel0.ForeColor = System.Drawing.Color.White
        Me.OLabel0.Location = New System.Drawing.Point(268, -3)
        Me.OLabel0.Name = "OLabel0"
        Me.OLabel0.Size = New System.Drawing.Size(130, 21)
        Me.OLabel0.TabIndex = 110
        Me.OLabel0.Text = "OFFICE SUPPLIES"
        Me.OLabel0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.OLabel0.Visible = False
        '
        'unitTxt
        '
        Me.unitTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unitTxt.Location = New System.Drawing.Point(188, 243)
        Me.unitTxt.Name = "unitTxt"
        Me.unitTxt.ReadOnly = True
        Me.unitTxt.Size = New System.Drawing.Size(276, 27)
        Me.unitTxt.TabIndex = 109
        Me.unitTxt.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.endBalanceTxt)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.numItemReqTxt)
        Me.GroupBox3.Controls.Add(Me.officesCb)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.reqByTxt)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.dateReqTxt)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.ForeColor = System.Drawing.Color.LightGray
        Me.GroupBox3.Location = New System.Drawing.Point(7, 276)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(676, 172)
        Me.GroupBox3.TabIndex = 99
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Request "
        '
        'endBalanceTxt
        '
        Me.endBalanceTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.endBalanceTxt.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endBalanceTxt.Location = New System.Drawing.Point(516, 87)
        Me.endBalanceTxt.Multiline = True
        Me.endBalanceTxt.Name = "endBalanceTxt"
        Me.endBalanceTxt.ReadOnly = True
        Me.endBalanceTxt.Size = New System.Drawing.Size(128, 27)
        Me.endBalanceTxt.TabIndex = 108
        Me.endBalanceTxt.TabStop = False
        Me.endBalanceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(512, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 21)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "Ending Balance:"
        '
        'numItemReqTxt
        '
        Me.numItemReqTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numItemReqTxt.Location = New System.Drawing.Point(24, 51)
        Me.numItemReqTxt.Name = "numItemReqTxt"
        Me.numItemReqTxt.Size = New System.Drawing.Size(223, 27)
        Me.numItemReqTxt.TabIndex = 0
        '
        'officesCb
        '
        Me.officesCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.officesCb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officesCb.FormattingEnabled = True
        Me.officesCb.Items.AddRange(New Object() {"Main-Admin", "Main-CDMD", "Main-PMEU", "Main-IETD", "Main-CMIS", "CLTC", "Poblaction", "Agdao", "Bunawan", "Paquibato", "Talomo", "Tugbok", "Toril", "Marilog", "Baguio", "Calinan", "Buhangin"})
        Me.officesCb.Location = New System.Drawing.Point(24, 118)
        Me.officesCb.Name = "officesCb"
        Me.officesCb.Size = New System.Drawing.Size(223, 29)
        Me.officesCb.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(20, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 21)
        Me.Label10.TabIndex = 105
        Me.Label10.Text = "Division/District"
        '
        'reqByTxt
        '
        Me.reqByTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reqByTxt.Location = New System.Drawing.Point(265, 51)
        Me.reqByTxt.Name = "reqByTxt"
        Me.reqByTxt.Size = New System.Drawing.Size(227, 27)
        Me.reqByTxt.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(261, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 21)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "Requested By:"
        '
        'dateReqTxt
        '
        Me.dateReqTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateReqTxt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateReqTxt.Location = New System.Drawing.Point(265, 120)
        Me.dateReqTxt.Name = "dateReqTxt"
        Me.dateReqTxt.Size = New System.Drawing.Size(227, 27)
        Me.dateReqTxt.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(261, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 21)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Date Requested:"
        '
        'ActionGB
        '
        Me.ActionGB.Controls.Add(Me.closeBtn)
        Me.ActionGB.Controls.Add(Me.deleteBtn)
        Me.ActionGB.Controls.Add(Me.updateBTN)
        Me.ActionGB.Controls.Add(Me.submitBtn)
        Me.ActionGB.ForeColor = System.Drawing.Color.DarkGray
        Me.ActionGB.Location = New System.Drawing.Point(7, 454)
        Me.ActionGB.Name = "ActionGB"
        Me.ActionGB.Size = New System.Drawing.Size(676, 114)
        Me.ActionGB.TabIndex = 87
        Me.ActionGB.TabStop = False
        Me.ActionGB.Text = "Action"
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.closeBtn.FlatAppearance.BorderSize = 0
        Me.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.closeBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.closeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.closeBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.closeBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.closeBtn.IconSize = 32
        Me.closeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.closeBtn.Location = New System.Drawing.Point(520, 12)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.closeBtn.Size = New System.Drawing.Size(150, 96)
        Me.closeBtn.TabIndex = 7
        Me.closeBtn.Text = "Refresh &Close"
        Me.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.closeBtn.UseVisualStyleBackColor = False
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.deleteBtn.Enabled = False
        Me.deleteBtn.FlatAppearance.BorderSize = 0
        Me.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.deleteBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.deleteBtn.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.deleteBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.deleteBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.deleteBtn.IconSize = 32
        Me.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.deleteBtn.Location = New System.Drawing.Point(348, 10)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.deleteBtn.Size = New System.Drawing.Size(150, 99)
        Me.deleteBtn.TabIndex = 6
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'updateBTN
        '
        Me.updateBTN.Enabled = False
        Me.updateBTN.FlatAppearance.BorderSize = 0
        Me.updateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.updateBTN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBTN.ForeColor = System.Drawing.Color.Gainsboro
        Me.updateBTN.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.updateBTN.IconColor = System.Drawing.Color.Gainsboro
        Me.updateBTN.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.updateBTN.IconSize = 32
        Me.updateBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.updateBTN.Location = New System.Drawing.Point(177, 11)
        Me.updateBTN.Name = "updateBTN"
        Me.updateBTN.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.updateBTN.Size = New System.Drawing.Size(150, 96)
        Me.updateBTN.TabIndex = 5
        Me.updateBTN.Text = "Update"
        Me.updateBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.updateBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.updateBTN.UseVisualStyleBackColor = True
        '
        'submitBtn
        '
        Me.submitBtn.FlatAppearance.BorderSize = 0
        Me.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.submitBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.submitBtn.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.submitBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.submitBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.submitBtn.IconSize = 32
        Me.submitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.submitBtn.Location = New System.Drawing.Point(6, 12)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.submitBtn.Size = New System.Drawing.Size(149, 96)
        Me.submitBtn.TabIndex = 4
        Me.submitBtn.Text = "Submit"
        Me.submitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.submitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.submitBtn.UseVisualStyleBackColor = True
        '
        'InventoryImageBox
        '
        Me.InventoryImageBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.InventoryImageBox.Location = New System.Drawing.Point(470, 49)
        Me.InventoryImageBox.Name = "InventoryImageBox"
        Me.InventoryImageBox.Size = New System.Drawing.Size(213, 221)
        Me.InventoryImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.InventoryImageBox.TabIndex = 71
        Me.InventoryImageBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(137, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 21)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Unit:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(18, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 21)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "No."
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(384, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 21)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Date/Time"
        '
        'dateTb
        '
        Me.dateTb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.dateTb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dateTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTb.ForeColor = System.Drawing.Color.Red
        Me.dateTb.Location = New System.Drawing.Point(481, 16)
        Me.dateTb.Name = "dateTb"
        Me.dateTb.Size = New System.Drawing.Size(176, 20)
        Me.dateTb.TabIndex = 27
        Me.dateTb.TabStop = False
        Me.dateTb.Text = "11/11/2019 11:11:00"
        '
        'NoLbl
        '
        Me.NoLbl.AutoSize = True
        Me.NoLbl.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoLbl.ForeColor = System.Drawing.Color.Red
        Me.NoLbl.Location = New System.Drawing.Point(57, 15)
        Me.NoLbl.Name = "NoLbl"
        Me.NoLbl.Size = New System.Drawing.Size(0, 21)
        Me.NoLbl.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dateTb)
        Me.GroupBox1.Controls.Add(Me.NoLbl)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(697, 48)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1295, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Image"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormRequestSupplies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(717, 646)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRequestSupplies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Request of Supplies"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ActionGB.ResumeLayout(False)
        CType(Me.InventoryImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents descTb As TextBox
    Friend WithEvents begBalanceTxt As TextBox
    Friend WithEvents dateDelvTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents InventoryImageBox As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dateTb As TextBox
    Friend WithEvents NoLbl As Label
    Friend WithEvents ActionGB As GroupBox
    Friend WithEvents closeBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents deleteBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents updateBTN As FontAwesome.Sharp.IconButton
    Friend WithEvents submitBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents officesCb As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents reqByTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dateReqTxt As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents numItemReqTxt As TextBox
    Friend WithEvents endBalanceTxt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents unitTxt As TextBox
    Friend WithEvents OLabel0 As Label
    Friend WithEvents CLabel1 As Label
    Friend WithEvents JLabel2 As Label
End Class
