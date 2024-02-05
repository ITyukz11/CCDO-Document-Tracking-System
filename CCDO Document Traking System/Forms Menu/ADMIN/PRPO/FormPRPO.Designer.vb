<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPRPO
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.StatusTxt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DProcessedPOTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DApprovePOTxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dateRRLB = New System.Windows.Forms.Label()
        Me.DPCFinalTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DPCDraftTxt = New System.Windows.Forms.TextBox()
        Me.DoctrackNumTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.numLbl = New System.Windows.Forms.Label()
        Me.PRnumberTxt = New System.Windows.Forms.TextBox()
        Me.DPDraftPRTxt = New System.Windows.Forms.TextBox()
        Me.DRFinalPRTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PRDetailsTxt = New System.Windows.Forms.TextBox()
        Me.welcomeLbl = New System.Windows.Forms.Label()
        Me.yearLbl = New System.Windows.Forms.Label()
        Me.chooseSearchCB = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchTB = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.walayRecordLbl = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.yearCB = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.openBtn = New FontAwesome.Sharp.IconButton()
        Me.addNewBtn = New FontAwesome.Sharp.IconButton()
        Me.logsBtn = New FontAwesome.Sharp.IconButton()
        Me.refreshBtn = New FontAwesome.Sharp.IconButton()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(252, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 17)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Total Docs:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.StatusTxt)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.DProcessedPOTxt)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.DApprovePOTxt)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.dateRRLB)
        Me.GroupBox3.Controls.Add(Me.DPCFinalTxt)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.DPCDraftTxt)
        Me.GroupBox3.Controls.Add(Me.DoctrackNumTxt)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.numLbl)
        Me.GroupBox3.Controls.Add(Me.PRnumberTxt)
        Me.GroupBox3.Controls.Add(Me.DPDraftPRTxt)
        Me.GroupBox3.Controls.Add(Me.DRFinalPRTxt)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.PRDetailsTxt)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox3.Location = New System.Drawing.Point(16, 710)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1243, 127)
        Me.GroupBox3.TabIndex = 115
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Document Overview"
        '
        'StatusTxt
        '
        Me.StatusTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusTxt.Location = New System.Drawing.Point(1061, 16)
        Me.StatusTxt.Name = "StatusTxt"
        Me.StatusTxt.ReadOnly = True
        Me.StatusTxt.Size = New System.Drawing.Size(163, 27)
        Me.StatusTxt.TabIndex = 94
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(1005, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 17)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "Status:"
        '
        'DProcessedPOTxt
        '
        Me.DProcessedPOTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DProcessedPOTxt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DProcessedPOTxt.Location = New System.Drawing.Point(1094, 53)
        Me.DProcessedPOTxt.Name = "DProcessedPOTxt"
        Me.DProcessedPOTxt.ReadOnly = True
        Me.DProcessedPOTxt.Size = New System.Drawing.Size(130, 23)
        Me.DProcessedPOTxt.TabIndex = 91
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(961, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 17)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Date Approve PO:"
        '
        'DApprovePOTxt
        '
        Me.DApprovePOTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DApprovePOTxt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DApprovePOTxt.Location = New System.Drawing.Point(1094, 90)
        Me.DApprovePOTxt.Name = "DApprovePOTxt"
        Me.DApprovePOTxt.ReadOnly = True
        Me.DApprovePOTxt.Size = New System.Drawing.Size(130, 23)
        Me.DApprovePOTxt.TabIndex = 89
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(720, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 17)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "Doctrack #:"
        '
        'dateRRLB
        '
        Me.dateRRLB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateRRLB.AutoSize = True
        Me.dateRRLB.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateRRLB.ForeColor = System.Drawing.Color.White
        Me.dateRRLB.Location = New System.Drawing.Point(710, 94)
        Me.dateRRLB.Name = "dateRRLB"
        Me.dateRRLB.Size = New System.Drawing.Size(95, 17)
        Me.dateRRLB.TabIndex = 85
        Me.dateRRLB.Text = "Canvas Final:"
        '
        'DPCFinalTxt
        '
        Me.DPCFinalTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DPCFinalTxt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DPCFinalTxt.Location = New System.Drawing.Point(811, 91)
        Me.DPCFinalTxt.Name = "DPCFinalTxt"
        Me.DPCFinalTxt.ReadOnly = True
        Me.DPCFinalTxt.Size = New System.Drawing.Size(130, 23)
        Me.DPCFinalTxt.TabIndex = 84
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(945, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 17)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Date Proccessed PO:"
        '
        'DPCDraftTxt
        '
        Me.DPCDraftTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DPCDraftTxt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DPCDraftTxt.Location = New System.Drawing.Point(811, 54)
        Me.DPCDraftTxt.Name = "DPCDraftTxt"
        Me.DPCDraftTxt.ReadOnly = True
        Me.DPCDraftTxt.Size = New System.Drawing.Size(130, 23)
        Me.DPCDraftTxt.TabIndex = 79
        '
        'DoctrackNumTxt
        '
        Me.DoctrackNumTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DoctrackNumTxt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoctrackNumTxt.Location = New System.Drawing.Point(811, 18)
        Me.DoctrackNumTxt.Name = "DoctrackNumTxt"
        Me.DoctrackNumTxt.ReadOnly = True
        Me.DoctrackNumTxt.Size = New System.Drawing.Size(130, 23)
        Me.DoctrackNumTxt.TabIndex = 78
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(707, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 17)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Canvas Draft:"
        '
        'numLbl
        '
        Me.numLbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.numLbl.AutoSize = True
        Me.numLbl.BackColor = System.Drawing.Color.White
        Me.numLbl.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numLbl.ForeColor = System.Drawing.Color.Black
        Me.numLbl.Location = New System.Drawing.Point(332, 24)
        Me.numLbl.Name = "numLbl"
        Me.numLbl.Size = New System.Drawing.Size(17, 17)
        Me.numLbl.TabIndex = 68
        Me.numLbl.Text = "#"
        '
        'PRnumberTxt
        '
        Me.PRnumberTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PRnumberTxt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRnumberTxt.Location = New System.Drawing.Point(427, 19)
        Me.PRnumberTxt.Name = "PRnumberTxt"
        Me.PRnumberTxt.ReadOnly = True
        Me.PRnumberTxt.Size = New System.Drawing.Size(130, 23)
        Me.PRnumberTxt.TabIndex = 72
        '
        'DPDraftPRTxt
        '
        Me.DPDraftPRTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DPDraftPRTxt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DPDraftPRTxt.Location = New System.Drawing.Point(427, 55)
        Me.DPDraftPRTxt.Name = "DPDraftPRTxt"
        Me.DPDraftPRTxt.ReadOnly = True
        Me.DPDraftPRTxt.Size = New System.Drawing.Size(130, 23)
        Me.DPDraftPRTxt.TabIndex = 73
        '
        'DRFinalPRTxt
        '
        Me.DRFinalPRTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DRFinalPRTxt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DRFinalPRTxt.Location = New System.Drawing.Point(427, 91)
        Me.DRFinalPRTxt.Name = "DRFinalPRTxt"
        Me.DRFinalPRTxt.ReadOnly = True
        Me.DRFinalPRTxt.Size = New System.Drawing.Size(130, 23)
        Me.DRFinalPRTxt.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(381, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 17)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "PR#:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(250, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 17)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Date Processed Draft PR:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(259, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 17)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Date Returned Final PR:"
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
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "PR Details:"
        '
        'PRDetailsTxt
        '
        Me.PRDetailsTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PRDetailsTxt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRDetailsTxt.Location = New System.Drawing.Point(94, 20)
        Me.PRDetailsTxt.Multiline = True
        Me.PRDetailsTxt.Name = "PRDetailsTxt"
        Me.PRDetailsTxt.ReadOnly = True
        Me.PRDetailsTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.PRDetailsTxt.Size = New System.Drawing.Size(149, 95)
        Me.PRDetailsTxt.TabIndex = 70
        '
        'welcomeLbl
        '
        Me.welcomeLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.welcomeLbl.AutoSize = True
        Me.welcomeLbl.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcomeLbl.ForeColor = System.Drawing.Color.Black
        Me.welcomeLbl.Location = New System.Drawing.Point(95, 783)
        Me.welcomeLbl.Name = "welcomeLbl"
        Me.welcomeLbl.Size = New System.Drawing.Size(0, 25)
        Me.welcomeLbl.TabIndex = 111
        '
        'yearLbl
        '
        Me.yearLbl.AutoSize = True
        Me.yearLbl.BackColor = System.Drawing.Color.Transparent
        Me.yearLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.yearLbl.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearLbl.ForeColor = System.Drawing.Color.White
        Me.yearLbl.Location = New System.Drawing.Point(339, 19)
        Me.yearLbl.Name = "yearLbl"
        Me.yearLbl.Size = New System.Drawing.Size(85, 28)
        Me.yearLbl.TabIndex = 101
        Me.yearLbl.Text = "| 2021"
        '
        'chooseSearchCB
        '
        Me.chooseSearchCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.chooseSearchCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chooseSearchCB.FormattingEnabled = True
        Me.chooseSearchCB.Items.AddRange(New Object() {"PR_Details", "Doctrack#", "DateProcessed_Draft_PR", "DateReturned_Final_PR", "PR#", "DateProcessed_CanvasDraft", "DateProcessed_CanvasFinal", "DateProcessed_PO", "DateApproved_PO", "Date", ""})
        Me.chooseSearchCB.Location = New System.Drawing.Point(555, 37)
        Me.chooseSearchCB.Name = "chooseSearchCB"
        Me.chooseSearchCB.Size = New System.Drawing.Size(144, 23)
        Me.chooseSearchCB.TabIndex = 104
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(327, 23)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "CCDO OFFICE DOCUMENT SEARCH"
        '
        'SearchTB
        '
        Me.SearchTB.BackColor = System.Drawing.SystemColors.HighlightText
        Me.SearchTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTB.Location = New System.Drawing.Point(14, 56)
        Me.SearchTB.Name = "SearchTB"
        Me.SearchTB.Size = New System.Drawing.Size(409, 47)
        Me.SearchTB.TabIndex = 100
        '
        'walayRecordLbl
        '
        Me.walayRecordLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.walayRecordLbl.BackColor = System.Drawing.Color.White
        Me.walayRecordLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.walayRecordLbl.Location = New System.Drawing.Point(120, 335)
        Me.walayRecordLbl.Name = "walayRecordLbl"
        Me.walayRecordLbl.Size = New System.Drawing.Size(1019, 153)
        Me.walayRecordLbl.TabIndex = 110
        Me.walayRecordLbl.Text = "qweqw"
        Me.walayRecordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(458, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 16)
        Me.Label12.TabIndex = 105
        Me.Label12.Text = "Type of Search:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(516, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 16)
        Me.Label13.TabIndex = 106
        Me.Label13.Text = "Year:"
        '
        'yearCB
        '
        Me.yearCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.yearCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearCB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.yearCB.FormattingEnabled = True
        Me.yearCB.Items.AddRange(New Object() {"2021", "2020", "2019", "2018", "2017", "2016"})
        Me.yearCB.Location = New System.Drawing.Point(555, 66)
        Me.yearCB.Name = "yearCB"
        Me.yearCB.Size = New System.Drawing.Size(144, 23)
        Me.yearCB.TabIndex = 107
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
        Me.DataGridView1.Location = New System.Drawing.Point(12, 112)
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
        Me.DataGridView1.Size = New System.Drawing.Size(1247, 592)
        Me.DataGridView1.TabIndex = 118
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
        Me.openBtn.Location = New System.Drawing.Point(961, 15)
        Me.openBtn.Name = "openBtn"
        Me.openBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.openBtn.Size = New System.Drawing.Size(117, 88)
        Me.openBtn.TabIndex = 117
        Me.openBtn.Text = "Open"
        Me.openBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.openBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.openBtn.UseVisualStyleBackColor = True
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
        Me.addNewBtn.Location = New System.Drawing.Point(719, 15)
        Me.addNewBtn.Name = "addNewBtn"
        Me.addNewBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.addNewBtn.Size = New System.Drawing.Size(115, 88)
        Me.addNewBtn.TabIndex = 114
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
        Me.logsBtn.Location = New System.Drawing.Point(840, 17)
        Me.logsBtn.Name = "logsBtn"
        Me.logsBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.logsBtn.Size = New System.Drawing.Size(115, 85)
        Me.logsBtn.TabIndex = 113
        Me.logsBtn.Text = "Logs"
        Me.logsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.logsBtn.UseVisualStyleBackColor = True
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
        Me.refreshBtn.Location = New System.Drawing.Point(1125, 18)
        Me.refreshBtn.Name = "refreshBtn"
        Me.refreshBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.refreshBtn.Size = New System.Drawing.Size(134, 85)
        Me.refreshBtn.TabIndex = 112
        Me.refreshBtn.Text = "Refresh"
        Me.refreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.refreshBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.refreshBtn.UseVisualStyleBackColor = True
        '
        'FormPRPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1273, 852)
        Me.Controls.Add(Me.openBtn)
        Me.Controls.Add(Me.addNewBtn)
        Me.Controls.Add(Me.logsBtn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.refreshBtn)
        Me.Controls.Add(Me.welcomeLbl)
        Me.Controls.Add(Me.yearLbl)
        Me.Controls.Add(Me.chooseSearchCB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SearchTB)
        Me.Controls.Add(Me.walayRecordLbl)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.yearCB)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormPRPO"
        Me.Text = "PR_PO_form"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents openBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents Label9 As Label
    Friend WithEvents addNewBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents logsBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dateRRLB As Label
    Friend WithEvents DPCFinalTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DPCDraftTxt As TextBox
    Friend WithEvents DoctrackNumTxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents numLbl As Label
    Friend WithEvents PRnumberTxt As TextBox
    Friend WithEvents DPDraftPRTxt As TextBox
    Friend WithEvents DRFinalPRTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PRDetailsTxt As TextBox
    Friend WithEvents refreshBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents welcomeLbl As Label
    Friend WithEvents yearLbl As Label
    Friend WithEvents chooseSearchCB As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SearchTB As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents walayRecordLbl As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents yearCB As ComboBox
    Friend WithEvents DApprovePOTxt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DProcessedPOTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StatusTxt As TextBox
    Friend WithEvents Label11 As Label
End Class
