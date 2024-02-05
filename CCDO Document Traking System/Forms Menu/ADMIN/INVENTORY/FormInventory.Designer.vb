<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInventory))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.suppliesCB = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SearchTB = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.welcomeLbl = New System.Windows.Forms.Label()
        Me.yearLbl = New System.Windows.Forms.Label()
        Me.chooseSearchCB = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.descTxt = New System.Windows.Forms.TextBox()
        Me.totalDocTxt = New System.Windows.Forms.TextBox()
        Me.qtyTxt = New System.Windows.Forms.TextBox()
        Me.unitTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.noOfItemsTxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.officeTxt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.inventoryPictureBox = New System.Windows.Forms.PictureBox()
        Me.noTimesRequestedTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lastDateReqTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lastReqByTxt = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rosBtn = New FontAwesome.Sharp.IconButton()
        Me.reqProperty = New FontAwesome.Sharp.IconButton()
        Me.addNewBtn = New FontAwesome.Sharp.IconButton()
        Me.refreshBtn = New FontAwesome.Sharp.IconButton()
        Me.logsBtn = New FontAwesome.Sharp.IconButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.walayRecordLbl = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        CType(Me.inventoryPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'suppliesCB
        '
        Me.suppliesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.suppliesCB.DropDownWidth = 340
        Me.suppliesCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suppliesCB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.suppliesCB.FormattingEnabled = True
        Me.suppliesCB.Items.AddRange(New Object() {"Office Supplies", "Computer Supplies, Materials, Peripherals and Accessories", "Janitorial, Groceries and Medical Supplies & Materials ", "I.T Equipment"})
        Me.suppliesCB.Location = New System.Drawing.Point(551, 51)
        Me.suppliesCB.Name = "suppliesCB"
        Me.suppliesCB.Size = New System.Drawing.Size(144, 24)
        Me.suppliesCB.TabIndex = 125
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(454, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 16)
        Me.Label12.TabIndex = 123
        Me.Label12.Text = "Type of Search:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(490, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 16)
        Me.Label13.TabIndex = 124
        Me.Label13.Text = "Supplies:"
        '
        'SearchTB
        '
        Me.SearchTB.BackColor = System.Drawing.SystemColors.HighlightText
        Me.SearchTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTB.Location = New System.Drawing.Point(10, 41)
        Me.SearchTB.Name = "SearchTB"
        Me.SearchTB.Size = New System.Drawing.Size(409, 47)
        Me.SearchTB.TabIndex = 119
        '
        'welcomeLbl
        '
        Me.welcomeLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.welcomeLbl.AutoSize = True
        Me.welcomeLbl.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcomeLbl.ForeColor = System.Drawing.Color.Black
        Me.welcomeLbl.Location = New System.Drawing.Point(91, 746)
        Me.welcomeLbl.Name = "welcomeLbl"
        Me.welcomeLbl.Size = New System.Drawing.Size(0, 25)
        Me.welcomeLbl.TabIndex = 127
        '
        'yearLbl
        '
        Me.yearLbl.AutoSize = True
        Me.yearLbl.BackColor = System.Drawing.Color.Transparent
        Me.yearLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.yearLbl.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearLbl.ForeColor = System.Drawing.Color.White
        Me.yearLbl.Location = New System.Drawing.Point(268, 4)
        Me.yearLbl.Name = "yearLbl"
        Me.yearLbl.Size = New System.Drawing.Size(85, 28)
        Me.yearLbl.TabIndex = 120
        Me.yearLbl.Text = "| 2022"
        '
        'chooseSearchCB
        '
        Me.chooseSearchCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.chooseSearchCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chooseSearchCB.FormattingEnabled = True
        Me.chooseSearchCB.Items.AddRange(New Object() {"No", "Description", "Unit", "Qty", "Remarks"})
        Me.chooseSearchCB.Location = New System.Drawing.Point(551, 22)
        Me.chooseSearchCB.Name = "chooseSearchCB"
        Me.chooseSearchCB.Size = New System.Drawing.Size(144, 24)
        Me.chooseSearchCB.TabIndex = 122
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 323)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Description:"
        '
        'descTxt
        '
        Me.descTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.descTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.descTxt.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descTxt.Location = New System.Drawing.Point(10, 342)
        Me.descTxt.Multiline = True
        Me.descTxt.Name = "descTxt"
        Me.descTxt.ReadOnly = True
        Me.descTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.descTxt.Size = New System.Drawing.Size(336, 82)
        Me.descTxt.TabIndex = 70
        '
        'totalDocTxt
        '
        Me.totalDocTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totalDocTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalDocTxt.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalDocTxt.Location = New System.Drawing.Point(10, 290)
        Me.totalDocTxt.Name = "totalDocTxt"
        Me.totalDocTxt.ReadOnly = True
        Me.totalDocTxt.Size = New System.Drawing.Size(138, 26)
        Me.totalDocTxt.TabIndex = 100
        '
        'qtyTxt
        '
        Me.qtyTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.qtyTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.qtyTxt.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtyTxt.Location = New System.Drawing.Point(14, 446)
        Me.qtyTxt.Name = "qtyTxt"
        Me.qtyTxt.ReadOnly = True
        Me.qtyTxt.Size = New System.Drawing.Size(138, 26)
        Me.qtyTxt.TabIndex = 99
        '
        'unitTxt
        '
        Me.unitTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.unitTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.unitTxt.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unitTxt.Location = New System.Drawing.Point(189, 446)
        Me.unitTxt.Name = "unitTxt"
        Me.unitTxt.ReadOnly = True
        Me.unitTxt.Size = New System.Drawing.Size(139, 26)
        Me.unitTxt.TabIndex = 98
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 427)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Quantity:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(185, 427)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Unit:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 23)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "INVENTORY MANAGEMENT"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.noOfItemsTxt)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.officeTxt)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.inventoryPictureBox)
        Me.Panel1.Controls.Add(Me.qtyTxt)
        Me.Panel1.Controls.Add(Me.unitTxt)
        Me.Panel1.Controls.Add(Me.totalDocTxt)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.noTimesRequestedTxt)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lastDateReqTxt)
        Me.Panel1.Controls.Add(Me.descTxt)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lastReqByTxt)
        Me.Panel1.Location = New System.Drawing.Point(955, 141)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(367, 647)
        Me.Panel1.TabIndex = 135
        '
        'noOfItemsTxt
        '
        Me.noOfItemsTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.noOfItemsTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.noOfItemsTxt.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noOfItemsTxt.Location = New System.Drawing.Point(189, 542)
        Me.noOfItemsTxt.Name = "noOfItemsTxt"
        Me.noOfItemsTxt.ReadOnly = True
        Me.noOfItemsTxt.Size = New System.Drawing.Size(139, 26)
        Me.noOfItemsTxt.TabIndex = 108
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(187, 523)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 16)
        Me.Label10.TabIndex = 107
        Me.Label10.Text = "# of Items"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 523)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Office:"
        '
        'officeTxt
        '
        Me.officeTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.officeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.officeTxt.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeTxt.Location = New System.Drawing.Point(14, 542)
        Me.officeTxt.Name = "officeTxt"
        Me.officeTxt.ReadOnly = True
        Me.officeTxt.Size = New System.Drawing.Size(138, 26)
        Me.officeTxt.TabIndex = 106
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(7, 271)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 16)
        Me.Label14.TabIndex = 102
        Me.Label14.Text = "Total Items:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(182, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 16)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "Times Requested:"
        '
        'inventoryPictureBox
        '
        Me.inventoryPictureBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.inventoryPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inventoryPictureBox.ErrorImage = CType(resources.GetObject("inventoryPictureBox.ErrorImage"), System.Drawing.Image)
        Me.inventoryPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.inventoryPictureBox.Name = "inventoryPictureBox"
        Me.inventoryPictureBox.Size = New System.Drawing.Size(367, 267)
        Me.inventoryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.inventoryPictureBox.TabIndex = 0
        Me.inventoryPictureBox.TabStop = False
        '
        'noTimesRequestedTxt
        '
        Me.noTimesRequestedTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.noTimesRequestedTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.noTimesRequestedTxt.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noTimesRequestedTxt.Location = New System.Drawing.Point(185, 290)
        Me.noTimesRequestedTxt.Name = "noTimesRequestedTxt"
        Me.noTimesRequestedTxt.ReadOnly = True
        Me.noTimesRequestedTxt.Size = New System.Drawing.Size(140, 26)
        Me.noTimesRequestedTxt.TabIndex = 101
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(185, 475)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 16)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "Last date requested:"
        '
        'lastDateReqTxt
        '
        Me.lastDateReqTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lastDateReqTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lastDateReqTxt.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastDateReqTxt.Location = New System.Drawing.Point(189, 494)
        Me.lastDateReqTxt.Name = "lastDateReqTxt"
        Me.lastDateReqTxt.ReadOnly = True
        Me.lastDateReqTxt.Size = New System.Drawing.Size(139, 26)
        Me.lastDateReqTxt.TabIndex = 104
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(12, 475)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 16)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "Last requested by:"
        '
        'lastReqByTxt
        '
        Me.lastReqByTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lastReqByTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lastReqByTxt.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastReqByTxt.Location = New System.Drawing.Point(15, 494)
        Me.lastReqByTxt.Name = "lastReqByTxt"
        Me.lastReqByTxt.ReadOnly = True
        Me.lastReqByTxt.Size = New System.Drawing.Size(138, 26)
        Me.lastReqByTxt.TabIndex = 103
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(954, 98)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(368, 42)
        Me.Panel2.TabIndex = 136
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(154, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Image"
        '
        'rosBtn
        '
        Me.rosBtn.FlatAppearance.BorderSize = 0
        Me.rosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rosBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rosBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.rosBtn.IconChar = FontAwesome.Sharp.IconChar.FolderOpen
        Me.rosBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.rosBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.rosBtn.IconSize = 32
        Me.rosBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rosBtn.Location = New System.Drawing.Point(867, 50)
        Me.rosBtn.Name = "rosBtn"
        Me.rosBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.rosBtn.Size = New System.Drawing.Size(188, 37)
        Me.rosBtn.TabIndex = 134
        Me.rosBtn.Text = "Request Supplies"
        Me.rosBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rosBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.rosBtn.UseVisualStyleBackColor = True
        '
        'reqProperty
        '
        Me.reqProperty.FlatAppearance.BorderSize = 0
        Me.reqProperty.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.reqProperty.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reqProperty.ForeColor = System.Drawing.Color.Gainsboro
        Me.reqProperty.IconChar = FontAwesome.Sharp.IconChar.FolderOpen
        Me.reqProperty.IconColor = System.Drawing.Color.Gainsboro
        Me.reqProperty.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.reqProperty.IconSize = 32
        Me.reqProperty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.reqProperty.Location = New System.Drawing.Point(866, 8)
        Me.reqProperty.Name = "reqProperty"
        Me.reqProperty.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.reqProperty.Size = New System.Drawing.Size(188, 37)
        Me.reqProperty.TabIndex = 132
        Me.reqProperty.Text = "Request Property"
        Me.reqProperty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.reqProperty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.reqProperty.UseVisualStyleBackColor = True
        '
        'addNewBtn
        '
        Me.addNewBtn.FlatAppearance.BorderSize = 0
        Me.addNewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addNewBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addNewBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.addNewBtn.IconChar = FontAwesome.Sharp.IconChar.FolderPlus
        Me.addNewBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.addNewBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.addNewBtn.IconSize = 32
        Me.addNewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addNewBtn.Location = New System.Drawing.Point(706, 8)
        Me.addNewBtn.Name = "addNewBtn"
        Me.addNewBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.addNewBtn.Size = New System.Drawing.Size(154, 37)
        Me.addNewBtn.TabIndex = 130
        Me.addNewBtn.Text = "Add New"
        Me.addNewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addNewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.addNewBtn.UseVisualStyleBackColor = True
        '
        'refreshBtn
        '
        Me.refreshBtn.FlatAppearance.BorderSize = 0
        Me.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.refreshBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.refreshBtn.IconChar = FontAwesome.Sharp.IconChar.SyncAlt
        Me.refreshBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.refreshBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.refreshBtn.IconSize = 32
        Me.refreshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.refreshBtn.Location = New System.Drawing.Point(1061, 52)
        Me.refreshBtn.Name = "refreshBtn"
        Me.refreshBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.refreshBtn.Size = New System.Drawing.Size(134, 36)
        Me.refreshBtn.TabIndex = 128
        Me.refreshBtn.Text = "Refresh"
        Me.refreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.refreshBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.refreshBtn.UseVisualStyleBackColor = True
        '
        'logsBtn
        '
        Me.logsBtn.FlatAppearance.BorderSize = 0
        Me.logsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.logsBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logsBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.logsBtn.IconChar = FontAwesome.Sharp.IconChar.Server
        Me.logsBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.logsBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.logsBtn.IconSize = 32
        Me.logsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logsBtn.Location = New System.Drawing.Point(706, 51)
        Me.logsBtn.Name = "logsBtn"
        Me.logsBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.logsBtn.Size = New System.Drawing.Size(154, 36)
        Me.logsBtn.TabIndex = 129
        Me.logsBtn.Text = "Logs"
        Me.logsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.logsBtn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 42
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(10, 98)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(938, 690)
        Me.DataGridView1.TabIndex = 137
        '
        'walayRecordLbl
        '
        Me.walayRecordLbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.walayRecordLbl.BackColor = System.Drawing.Color.White
        Me.walayRecordLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.walayRecordLbl.Location = New System.Drawing.Point(178, 310)
        Me.walayRecordLbl.Name = "walayRecordLbl"
        Me.walayRecordLbl.Size = New System.Drawing.Size(566, 98)
        Me.walayRecordLbl.TabIndex = 142
        Me.walayRecordLbl.Text = "No Record Found"
        Me.walayRecordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.walayRecordLbl.Visible = False
        '
        'IconButton1
        '
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IconButton1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.IconButton1.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 32
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(1061, 8)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton1.Size = New System.Drawing.Size(134, 38)
        Me.IconButton1.TabIndex = 143
        Me.IconButton1.Text = "Report"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'FormInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1332, 812)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.walayRecordLbl)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.rosBtn)
        Me.Controls.Add(Me.reqProperty)
        Me.Controls.Add(Me.suppliesCB)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.SearchTB)
        Me.Controls.Add(Me.addNewBtn)
        Me.Controls.Add(Me.refreshBtn)
        Me.Controls.Add(Me.welcomeLbl)
        Me.Controls.Add(Me.yearLbl)
        Me.Controls.Add(Me.chooseSearchCB)
        Me.Controls.Add(Me.logsBtn)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormInventory"
        Me.Text = "Inventory"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.inventoryPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents reqProperty As FontAwesome.Sharp.IconButton
    Friend WithEvents suppliesCB As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SearchTB As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents addNewBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents refreshBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents welcomeLbl As Label
    Friend WithEvents yearLbl As Label
    Friend WithEvents chooseSearchCB As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents descTxt As TextBox
    Friend WithEvents logsBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents rosBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents qtyTxt As TextBox
    Friend WithEvents unitTxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents inventoryPictureBox As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents totalDocTxt As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lastDateReqTxt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lastReqByTxt As TextBox
    Friend WithEvents noTimesRequestedTxt As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents noOfItemsTxt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents officeTxt As TextBox
    Friend WithEvents walayRecordLbl As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
