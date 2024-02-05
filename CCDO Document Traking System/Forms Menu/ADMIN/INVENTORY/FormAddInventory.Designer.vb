<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddInventory
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
        Me.filePathTxt = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ActionGB = New System.Windows.Forms.GroupBox()
        Me.closeBtn = New FontAwesome.Sharp.IconButton()
        Me.deleteBtn = New FontAwesome.Sharp.IconButton()
        Me.updateBTN = New FontAwesome.Sharp.IconButton()
        Me.submitBtn = New FontAwesome.Sharp.IconButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dateTb = New System.Windows.Forms.TextBox()
        Me.NoLbl = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.unitCB = New System.Windows.Forms.ComboBox()
        Me.remarksTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BrowseBtn = New FontAwesome.Sharp.IconButton()
        Me.descTb = New System.Windows.Forms.TextBox()
        Me.qtyTb = New System.Windows.Forms.TextBox()
        Me.InventoryImageBox = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.CLabel1 = New System.Windows.Forms.Label()
        Me.JLabel2 = New System.Windows.Forms.Label()
        Me.OLabel0 = New System.Windows.Forms.Label()
        Me.ActionGB.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.InventoryImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'filePathTxt
        '
        Me.filePathTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filePathTxt.ForeColor = System.Drawing.Color.DarkGray
        Me.filePathTxt.Location = New System.Drawing.Point(382, 254)
        Me.filePathTxt.Name = "filePathTxt"
        Me.filePathTxt.ReadOnly = True
        Me.filePathTxt.Size = New System.Drawing.Size(237, 20)
        Me.filePathTxt.TabIndex = 72
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1295, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Image"
        '
        'ActionGB
        '
        Me.ActionGB.Controls.Add(Me.closeBtn)
        Me.ActionGB.Controls.Add(Me.deleteBtn)
        Me.ActionGB.Controls.Add(Me.updateBTN)
        Me.ActionGB.Controls.Add(Me.submitBtn)
        Me.ActionGB.ForeColor = System.Drawing.Color.DarkGray
        Me.ActionGB.Location = New System.Drawing.Point(12, 399)
        Me.ActionGB.Name = "ActionGB"
        Me.ActionGB.Size = New System.Drawing.Size(627, 81)
        Me.ActionGB.TabIndex = 83
        Me.ActionGB.TabStop = False
        Me.ActionGB.Text = "Action"
        '
        'closeBtn
        '
        Me.closeBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeBtn.AutoSize = True
        Me.closeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.closeBtn.FlatAppearance.BorderSize = 0
        Me.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.closeBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.closeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.closeBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.closeBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.closeBtn.IconSize = 32
        Me.closeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.closeBtn.Location = New System.Drawing.Point(465, 18)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.closeBtn.Size = New System.Drawing.Size(151, 50)
        Me.closeBtn.TabIndex = 6
        Me.closeBtn.Text = "Ref&Close"
        Me.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.closeBtn.UseVisualStyleBackColor = False
        '
        'deleteBtn
        '
        Me.deleteBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.deleteBtn.AutoSize = True
        Me.deleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.deleteBtn.Enabled = False
        Me.deleteBtn.FlatAppearance.BorderSize = 0
        Me.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.deleteBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.deleteBtn.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.deleteBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.deleteBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.deleteBtn.IconSize = 32
        Me.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.deleteBtn.Location = New System.Drawing.Point(312, 18)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.deleteBtn.Size = New System.Drawing.Size(152, 50)
        Me.deleteBtn.TabIndex = 11
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'updateBTN
        '
        Me.updateBTN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.updateBTN.AutoSize = True
        Me.updateBTN.Enabled = False
        Me.updateBTN.FlatAppearance.BorderSize = 0
        Me.updateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.updateBTN.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBTN.ForeColor = System.Drawing.Color.Gainsboro
        Me.updateBTN.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.updateBTN.IconColor = System.Drawing.Color.Gainsboro
        Me.updateBTN.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.updateBTN.IconSize = 32
        Me.updateBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.updateBTN.Location = New System.Drawing.Point(159, 18)
        Me.updateBTN.Name = "updateBTN"
        Me.updateBTN.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.updateBTN.Size = New System.Drawing.Size(152, 51)
        Me.updateBTN.TabIndex = 10
        Me.updateBTN.Text = "Update"
        Me.updateBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.updateBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.updateBTN.UseVisualStyleBackColor = True
        '
        'submitBtn
        '
        Me.submitBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.submitBtn.AutoSize = True
        Me.submitBtn.FlatAppearance.BorderSize = 0
        Me.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.submitBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.submitBtn.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.submitBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.submitBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.submitBtn.IconSize = 32
        Me.submitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.submitBtn.Location = New System.Drawing.Point(7, 18)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.submitBtn.Size = New System.Drawing.Size(151, 51)
        Me.submitBtn.TabIndex = 5
        Me.submitBtn.Text = "Save"
        Me.submitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.submitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.submitBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dateTb)
        Me.GroupBox1.Controls.Add(Me.NoLbl)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(627, 48)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
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
        Me.Label9.Location = New System.Drawing.Point(312, 16)
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
        Me.dateTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTb.ForeColor = System.Drawing.Color.White
        Me.dateTb.Location = New System.Drawing.Point(443, 16)
        Me.dateTb.Name = "dateTb"
        Me.dateTb.ReadOnly = True
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.JLabel2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.OLabel0)
        Me.GroupBox2.Controls.Add(Me.unitCB)
        Me.GroupBox2.Controls.Add(Me.remarksTb)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.BrowseBtn)
        Me.GroupBox2.Controls.Add(Me.descTb)
        Me.GroupBox2.Controls.Add(Me.qtyTb)
        Me.GroupBox2.Controls.Add(Me.InventoryImageBox)
        Me.GroupBox2.Controls.Add(Me.filePathTxt)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox2.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(627, 327)
        Me.GroupBox2.TabIndex = 82
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Form"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 21)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Description:"
        '
        'unitCB
        '
        Me.unitCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.unitCB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unitCB.FormattingEnabled = True
        Me.unitCB.Items.AddRange(New Object() {"piece", "pack", "unit", "box", "bottle", "ream", "roll", "can"})
        Me.unitCB.Location = New System.Drawing.Point(112, 139)
        Me.unitCB.Name = "unitCB"
        Me.unitCB.Size = New System.Drawing.Size(264, 29)
        Me.unitCB.TabIndex = 98
        '
        'remarksTb
        '
        Me.remarksTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remarksTb.Location = New System.Drawing.Point(112, 214)
        Me.remarksTb.Multiline = True
        Me.remarksTb.Name = "remarksTb"
        Me.remarksTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.remarksTb.Size = New System.Drawing.Size(264, 89)
        Me.remarksTb.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 21)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Remarks:"
        '
        'BrowseBtn
        '
        Me.BrowseBtn.AutoSize = True
        Me.BrowseBtn.FlatAppearance.BorderSize = 0
        Me.BrowseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BrowseBtn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.BrowseBtn.IconChar = FontAwesome.Sharp.IconChar.FileUpload
        Me.BrowseBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.BrowseBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BrowseBtn.IconSize = 32
        Me.BrowseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BrowseBtn.Location = New System.Drawing.Point(437, 280)
        Me.BrowseBtn.Name = "BrowseBtn"
        Me.BrowseBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BrowseBtn.Size = New System.Drawing.Size(124, 38)
        Me.BrowseBtn.TabIndex = 4
        Me.BrowseBtn.Text = "Upload"
        Me.BrowseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BrowseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BrowseBtn.UseVisualStyleBackColor = True
        '
        'descTb
        '
        Me.descTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descTb.Location = New System.Drawing.Point(112, 19)
        Me.descTb.Multiline = True
        Me.descTb.Name = "descTb"
        Me.descTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.descTb.Size = New System.Drawing.Size(264, 107)
        Me.descTb.TabIndex = 0
        '
        'qtyTb
        '
        Me.qtyTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtyTb.Location = New System.Drawing.Point(112, 177)
        Me.qtyTb.Name = "qtyTb"
        Me.qtyTb.Size = New System.Drawing.Size(264, 27)
        Me.qtyTb.TabIndex = 2
        '
        'InventoryImageBox
        '
        Me.InventoryImageBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.InventoryImageBox.Location = New System.Drawing.Point(382, 19)
        Me.InventoryImageBox.Name = "InventoryImageBox"
        Me.InventoryImageBox.Size = New System.Drawing.Size(237, 229)
        Me.InventoryImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.InventoryImageBox.TabIndex = 71
        Me.InventoryImageBox.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(61, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 21)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Unit:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(22, 183)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 21)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Quantity:"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        '
        'CLabel1
        '
        Me.CLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CLabel1.AutoSize = True
        Me.CLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLabel1.ForeColor = System.Drawing.Color.White
        Me.CLabel1.Location = New System.Drawing.Point(89, 61)
        Me.CLabel1.Name = "CLabel1"
        Me.CLabel1.Size = New System.Drawing.Size(462, 21)
        Me.CLabel1.TabIndex = 114
        Me.CLabel1.Text = "Computer Supplies, Materials, Peripherals and Accessories"
        Me.CLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CLabel1.Visible = False
        '
        'JLabel2
        '
        Me.JLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.JLabel2.AutoSize = True
        Me.JLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JLabel2.ForeColor = System.Drawing.Color.White
        Me.JLabel2.Location = New System.Drawing.Point(108, -5)
        Me.JLabel2.Name = "JLabel2"
        Me.JLabel2.Size = New System.Drawing.Size(416, 21)
        Me.JLabel2.TabIndex = 115
        Me.JLabel2.Text = "Janitorial, Groceries and Medical Supplies & Materials"
        Me.JLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.JLabel2.Visible = False
        '
        'OLabel0
        '
        Me.OLabel0.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.OLabel0.AutoSize = True
        Me.OLabel0.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OLabel0.ForeColor = System.Drawing.Color.White
        Me.OLabel0.Location = New System.Drawing.Point(232, -5)
        Me.OLabel0.Name = "OLabel0"
        Me.OLabel0.Size = New System.Drawing.Size(130, 21)
        Me.OLabel0.TabIndex = 113
        Me.OLabel0.Text = "OFFICE SUPPLIES"
        Me.OLabel0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.OLabel0.Visible = False
        '
        'FormAddInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(645, 487)
        Me.Controls.Add(Me.CLabel1)
        Me.Controls.Add(Me.ActionGB)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FormAddInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAddInventory"
        Me.ActionGB.ResumeLayout(False)
        Me.ActionGB.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.InventoryImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents filePathTxt As TextBox
    Friend WithEvents InventoryImageBox As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents closeBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents deleteBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents updateBTN As FontAwesome.Sharp.IconButton
    Friend WithEvents submitBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents ActionGB As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dateTb As TextBox
    Friend WithEvents NoLbl As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents remarksTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BrowseBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents descTb As TextBox
    Friend WithEvents qtyTb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents unitCB As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents JLabel2 As Label
    Friend WithEvents OLabel0 As Label
    Friend WithEvents CLabel1 As Label
End Class
