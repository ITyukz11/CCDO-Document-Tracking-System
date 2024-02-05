<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRequestProperty
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
        Me.ActionGB = New System.Windows.Forms.GroupBox()
        Me.closeBtn = New FontAwesome.Sharp.IconButton()
        Me.deleteBtn = New FontAwesome.Sharp.IconButton()
        Me.updateBTN = New FontAwesome.Sharp.IconButton()
        Me.submitBtn = New FontAwesome.Sharp.IconButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dateTb = New System.Windows.Forms.TextBox()
        Me.NoLbl = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.reqByTxt = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.descTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dateReqTxt = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.qtyTb = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.propNoTxt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.OLabel0 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.purposeTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.remarksTxt = New System.Windows.Forms.TextBox()
        Me.returnByTxt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.returnOnCb = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.condTxt = New System.Windows.Forms.TextBox()
        Me.InventoryImageBox = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ActionGB.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.InventoryImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ActionGB
        '
        Me.ActionGB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActionGB.Controls.Add(Me.closeBtn)
        Me.ActionGB.Controls.Add(Me.deleteBtn)
        Me.ActionGB.Controls.Add(Me.updateBTN)
        Me.ActionGB.Controls.Add(Me.submitBtn)
        Me.ActionGB.ForeColor = System.Drawing.Color.DarkGray
        Me.ActionGB.Location = New System.Drawing.Point(7, 411)
        Me.ActionGB.Name = "ActionGB"
        Me.ActionGB.Size = New System.Drawing.Size(734, 114)
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
        Me.closeBtn.Location = New System.Drawing.Point(572, 14)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.closeBtn.Size = New System.Drawing.Size(150, 94)
        Me.closeBtn.TabIndex = 12
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
        Me.deleteBtn.Location = New System.Drawing.Point(382, 15)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.deleteBtn.Size = New System.Drawing.Size(150, 94)
        Me.deleteBtn.TabIndex = 11
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
        Me.updateBTN.Location = New System.Drawing.Point(191, 15)
        Me.updateBTN.Name = "updateBTN"
        Me.updateBTN.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.updateBTN.Size = New System.Drawing.Size(150, 94)
        Me.updateBTN.TabIndex = 10
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
        Me.submitBtn.Location = New System.Drawing.Point(4, 14)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.submitBtn.Size = New System.Drawing.Size(149, 94)
        Me.submitBtn.TabIndex = 4
        Me.submitBtn.Text = "Submit"
        Me.submitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.submitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.submitBtn.UseVisualStyleBackColor = True
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
        Me.Label9.Location = New System.Drawing.Point(438, 16)
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
        Me.dateTb.Location = New System.Drawing.Point(535, 16)
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
        Me.GroupBox1.Location = New System.Drawing.Point(1, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(751, 48)
        Me.GroupBox1.TabIndex = 88
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1284, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Image"
        '
        'reqByTxt
        '
        Me.reqByTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reqByTxt.Location = New System.Drawing.Point(11, 51)
        Me.reqByTxt.Name = "reqByTxt"
        Me.reqByTxt.Size = New System.Drawing.Size(227, 27)
        Me.reqByTxt.TabIndex = 2
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(14, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Property Description:"
        '
        'descTxt
        '
        Me.descTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descTxt.Location = New System.Drawing.Point(189, 55)
        Me.descTxt.Multiline = True
        Me.descTxt.Name = "descTxt"
        Me.descTxt.ReadOnly = True
        Me.descTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.descTxt.Size = New System.Drawing.Size(275, 117)
        Me.descTxt.TabIndex = 0
        Me.descTxt.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(93, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 21)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Condition:"
        '
        'dateReqTxt
        '
        Me.dateReqTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateReqTxt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateReqTxt.Location = New System.Drawing.Point(11, 120)
        Me.dateReqTxt.Name = "dateReqTxt"
        Me.dateReqTxt.Size = New System.Drawing.Size(227, 27)
        Me.dateReqTxt.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.qtyTb)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.propNoTxt)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.OLabel0)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.ActionGB)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.descTxt)
        Me.GroupBox2.Controls.Add(Me.condTxt)
        Me.GroupBox2.Controls.Add(Me.InventoryImageBox)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox2.Location = New System.Drawing.Point(1, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(751, 531)
        Me.GroupBox2.TabIndex = 89
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Form"
        '
        'qtyTb
        '
        Me.qtyTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtyTb.Location = New System.Drawing.Point(189, 211)
        Me.qtyTb.Name = "qtyTb"
        Me.qtyTb.Size = New System.Drawing.Size(275, 27)
        Me.qtyTb.TabIndex = 115
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(99, 214)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 21)
        Me.Label12.TabIndex = 116
        Me.Label12.Text = "Quantity:"
        '
        'propNoTxt
        '
        Me.propNoTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.propNoTxt.Location = New System.Drawing.Point(189, 22)
        Me.propNoTxt.Name = "propNoTxt"
        Me.propNoTxt.ReadOnly = True
        Me.propNoTxt.Size = New System.Drawing.Size(65, 27)
        Me.propNoTxt.TabIndex = 113
        Me.propNoTxt.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(93, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 21)
        Me.Label13.TabIndex = 114
        Me.Label13.Text = "Property#:"
        '
        'OLabel0
        '
        Me.OLabel0.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OLabel0.AutoSize = True
        Me.OLabel0.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OLabel0.ForeColor = System.Drawing.Color.White
        Me.OLabel0.Location = New System.Drawing.Point(278, 0)
        Me.OLabel0.Name = "OLabel0"
        Me.OLabel0.Size = New System.Drawing.Size(113, 21)
        Me.OLabel0.TabIndex = 110
        Me.OLabel0.Text = "I.T Equipment"
        Me.OLabel0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.OLabel0.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.purposeTxt)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.remarksTxt)
        Me.GroupBox3.Controls.Add(Me.returnByTxt)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.returnOnCb)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.reqByTxt)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.dateReqTxt)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.ForeColor = System.Drawing.Color.LightGray
        Me.GroupBox3.Location = New System.Drawing.Point(7, 245)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(734, 160)
        Me.GroupBox3.TabIndex = 99
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Request "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(491, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 21)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Purpose:"
        '
        'purposeTxt
        '
        Me.purposeTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purposeTxt.Location = New System.Drawing.Point(495, 120)
        Me.purposeTxt.Name = "purposeTxt"
        Me.purposeTxt.Size = New System.Drawing.Size(227, 27)
        Me.purposeTxt.TabIndex = 116
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(491, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 21)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Remarks:"
        '
        'remarksTxt
        '
        Me.remarksTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remarksTxt.Location = New System.Drawing.Point(495, 51)
        Me.remarksTxt.Multiline = True
        Me.remarksTxt.Name = "remarksTxt"
        Me.remarksTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.remarksTxt.Size = New System.Drawing.Size(227, 27)
        Me.remarksTxt.TabIndex = 115
        Me.remarksTxt.TabStop = False
        '
        'returnByTxt
        '
        Me.returnByTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.returnByTxt.Location = New System.Drawing.Point(253, 51)
        Me.returnByTxt.Name = "returnByTxt"
        Me.returnByTxt.Size = New System.Drawing.Size(227, 27)
        Me.returnByTxt.TabIndex = 106
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(249, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 21)
        Me.Label11.TabIndex = 109
        Me.Label11.Text = "Returned On:"
        '
        'returnOnCb
        '
        Me.returnOnCb.CustomFormat = ""
        Me.returnOnCb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.returnOnCb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.returnOnCb.Location = New System.Drawing.Point(253, 120)
        Me.returnOnCb.Name = "returnOnCb"
        Me.returnOnCb.Size = New System.Drawing.Size(227, 27)
        Me.returnOnCb.TabIndex = 107
        Me.returnOnCb.Value = New Date(2022, 6, 28, 14, 19, 42, 0)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(249, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 21)
        Me.Label14.TabIndex = 108
        Me.Label14.Text = "Returned By:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(7, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 21)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "Requested By:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 21)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Requested On:"
        '
        'condTxt
        '
        Me.condTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.condTxt.Location = New System.Drawing.Point(189, 178)
        Me.condTxt.Name = "condTxt"
        Me.condTxt.ReadOnly = True
        Me.condTxt.Size = New System.Drawing.Size(275, 27)
        Me.condTxt.TabIndex = 1
        Me.condTxt.TabStop = False
        '
        'InventoryImageBox
        '
        Me.InventoryImageBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.InventoryImageBox.Location = New System.Drawing.Point(470, 25)
        Me.InventoryImageBox.Name = "InventoryImageBox"
        Me.InventoryImageBox.Size = New System.Drawing.Size(270, 213)
        Me.InventoryImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.InventoryImageBox.TabIndex = 71
        Me.InventoryImageBox.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormRequestProperty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(756, 591)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRequestProperty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Request of Property"
        Me.ActionGB.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.InventoryImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ActionGB As GroupBox
    Friend WithEvents closeBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents deleteBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents updateBTN As FontAwesome.Sharp.IconButton
    Friend WithEvents submitBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents InventoryImageBox As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dateTb As TextBox
    Friend WithEvents NoLbl As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents reqByTxt As TextBox
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents Label5 As Label
    Friend WithEvents descTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dateReqTxt As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents OLabel0 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents propNoTxt As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents condTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents remarksTxt As TextBox
    Friend WithEvents returnByTxt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents returnOnCb As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents qtyTb As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents purposeTxt As TextBox
End Class
