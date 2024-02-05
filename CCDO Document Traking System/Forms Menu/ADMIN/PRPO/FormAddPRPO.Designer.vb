<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAddPRPO
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
        Me.closeBtn = New FontAwesome.Sharp.IconButton()
        Me.DeleteBtn = New FontAwesome.Sharp.IconButton()
        Me.updateBTN = New FontAwesome.Sharp.IconButton()
        Me.SaveBtn = New FontAwesome.Sharp.IconButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PrintBtn = New FontAwesome.Sharp.IconButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dateTxt = New System.Windows.Forms.TextBox()
        Me.NoLbl = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dateEncodedLbl = New System.Windows.Forms.Label()
        Me.dateUpdatedLbl = New System.Windows.Forms.Label()
        Me.processedTimeLbl = New System.Windows.Forms.Label()
        Me.StatusTxt = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LBLstatGuide4 = New System.Windows.Forms.Label()
        Me.LBLstatGuide3 = New System.Windows.Forms.Label()
        Me.LBLstatGuide2 = New System.Windows.Forms.Label()
        Me.LBLstatGuide1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CBupdateStatus = New System.Windows.Forms.CheckBox()
        Me.CBstatus = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DApprovePOTxt = New System.Windows.Forms.TextBox()
        Me.dateRRLB = New System.Windows.Forms.Label()
        Me.DProcessedPOTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PRDetailsTxt = New System.Windows.Forms.TextBox()
        Me.PRNumberTxt = New System.Windows.Forms.TextBox()
        Me.DPDraftPRTxt = New System.Windows.Forms.TextBox()
        Me.DRFinalPRTxt = New System.Windows.Forms.TextBox()
        Me.DPCDraftTxt = New System.Windows.Forms.TextBox()
        Me.DNumberTxt = New System.Windows.Forms.TextBox()
        Me.DPCFinalTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.closeBtn.FlatAppearance.BorderSize = 0
        Me.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.closeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.closeBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.closeBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.closeBtn.IconSize = 32
        Me.closeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.closeBtn.Location = New System.Drawing.Point(629, 9)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.closeBtn.Size = New System.Drawing.Size(150, 97)
        Me.closeBtn.TabIndex = 14
        Me.closeBtn.Text = "Refresh &Close"
        Me.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.closeBtn.UseVisualStyleBackColor = False
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.DeleteBtn.FlatAppearance.BorderSize = 0
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.DeleteBtn.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.DeleteBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.DeleteBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.DeleteBtn.IconSize = 32
        Me.DeleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteBtn.Location = New System.Drawing.Point(473, 9)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.DeleteBtn.Size = New System.Drawing.Size(150, 97)
        Me.DeleteBtn.TabIndex = 13
        Me.DeleteBtn.Text = "&Delete"
        Me.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'updateBTN
        '
        Me.updateBTN.FlatAppearance.BorderSize = 0
        Me.updateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateBTN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBTN.ForeColor = System.Drawing.Color.Gainsboro
        Me.updateBTN.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.updateBTN.IconColor = System.Drawing.Color.Gainsboro
        Me.updateBTN.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.updateBTN.IconSize = 32
        Me.updateBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.updateBTN.Location = New System.Drawing.Point(317, 9)
        Me.updateBTN.Name = "updateBTN"
        Me.updateBTN.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.updateBTN.Size = New System.Drawing.Size(150, 97)
        Me.updateBTN.TabIndex = 12
        Me.updateBTN.Text = "&Update"
        Me.updateBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.updateBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.updateBTN.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.FlatAppearance.BorderSize = 0
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.SaveBtn.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.SaveBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.SaveBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SaveBtn.IconSize = 32
        Me.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveBtn.Location = New System.Drawing.Point(162, 9)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.SaveBtn.Size = New System.Drawing.Size(149, 97)
        Me.SaveBtn.TabIndex = 11
        Me.SaveBtn.Text = "&Save"
        Me.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.closeBtn)
        Me.GroupBox3.Controls.Add(Me.DeleteBtn)
        Me.GroupBox3.Controls.Add(Me.updateBTN)
        Me.GroupBox3.Controls.Add(Me.PrintBtn)
        Me.GroupBox3.Controls.Add(Me.SaveBtn)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox3.Location = New System.Drawing.Point(12, 526)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(787, 114)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        '
        'PrintBtn
        '
        Me.PrintBtn.FlatAppearance.BorderSize = 0
        Me.PrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.PrintBtn.IconChar = FontAwesome.Sharp.IconChar.Server
        Me.PrintBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.PrintBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.PrintBtn.IconSize = 32
        Me.PrintBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintBtn.Location = New System.Drawing.Point(6, 9)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.PrintBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PrintBtn.Size = New System.Drawing.Size(150, 97)
        Me.PrintBtn.TabIndex = 97
        Me.PrintBtn.Text = "History &Log"
        Me.PrintBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PrintBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dateTxt)
        Me.GroupBox1.Controls.Add(Me.NoLbl)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(787, 48)
        Me.GroupBox1.TabIndex = 45
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
        Me.Label9.Location = New System.Drawing.Point(474, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 21)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Date/Time"
        '
        'dateTxt
        '
        Me.dateTxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.dateTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dateTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTxt.ForeColor = System.Drawing.Color.Red
        Me.dateTxt.Location = New System.Drawing.Point(571, 16)
        Me.dateTxt.Name = "dateTxt"
        Me.dateTxt.ReadOnly = True
        Me.dateTxt.Size = New System.Drawing.Size(176, 20)
        Me.dateTxt.TabIndex = 27
        Me.dateTxt.Text = "11/11/2019 11:11:00"
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
        Me.GroupBox2.Controls.Add(Me.dateEncodedLbl)
        Me.GroupBox2.Controls.Add(Me.dateUpdatedLbl)
        Me.GroupBox2.Controls.Add(Me.processedTimeLbl)
        Me.GroupBox2.Controls.Add(Me.StatusTxt)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.LBLstatGuide4)
        Me.GroupBox2.Controls.Add(Me.LBLstatGuide3)
        Me.GroupBox2.Controls.Add(Me.LBLstatGuide2)
        Me.GroupBox2.Controls.Add(Me.LBLstatGuide1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.CBupdateStatus)
        Me.GroupBox2.Controls.Add(Me.CBstatus)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.DApprovePOTxt)
        Me.GroupBox2.Controls.Add(Me.dateRRLB)
        Me.GroupBox2.Controls.Add(Me.DProcessedPOTxt)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.PRDetailsTxt)
        Me.GroupBox2.Controls.Add(Me.PRNumberTxt)
        Me.GroupBox2.Controls.Add(Me.DPDraftPRTxt)
        Me.GroupBox2.Controls.Add(Me.DRFinalPRTxt)
        Me.GroupBox2.Controls.Add(Me.DPCDraftTxt)
        Me.GroupBox2.Controls.Add(Me.DNumberTxt)
        Me.GroupBox2.Controls.Add(Me.DPCFinalTxt)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox2.Location = New System.Drawing.Point(12, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(787, 451)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Form"
        '
        'dateEncodedLbl
        '
        Me.dateEncodedLbl.AutoSize = True
        Me.dateEncodedLbl.Location = New System.Drawing.Point(524, 358)
        Me.dateEncodedLbl.Name = "dateEncodedLbl"
        Me.dateEncodedLbl.Size = New System.Drawing.Size(79, 13)
        Me.dateEncodedLbl.TabIndex = 114
        Me.dateEncodedLbl.Text = "Date Encoded:"
        '
        'dateUpdatedLbl
        '
        Me.dateUpdatedLbl.AutoSize = True
        Me.dateUpdatedLbl.Location = New System.Drawing.Point(524, 377)
        Me.dateUpdatedLbl.Name = "dateUpdatedLbl"
        Me.dateUpdatedLbl.Size = New System.Drawing.Size(77, 13)
        Me.dateUpdatedLbl.TabIndex = 113
        Me.dateUpdatedLbl.Text = "Date Updated:"
        '
        'processedTimeLbl
        '
        Me.processedTimeLbl.AutoSize = True
        Me.processedTimeLbl.ForeColor = System.Drawing.Color.White
        Me.processedTimeLbl.Location = New System.Drawing.Point(524, 405)
        Me.processedTimeLbl.Name = "processedTimeLbl"
        Me.processedTimeLbl.Size = New System.Drawing.Size(86, 13)
        Me.processedTimeLbl.TabIndex = 112
        Me.processedTimeLbl.Text = "Processed Time:"
        '
        'StatusTxt
        '
        Me.StatusTxt.Enabled = False
        Me.StatusTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusTxt.Location = New System.Drawing.Point(198, 396)
        Me.StatusTxt.Multiline = True
        Me.StatusTxt.Name = "StatusTxt"
        Me.StatusTxt.ReadOnly = True
        Me.StatusTxt.Size = New System.Drawing.Size(253, 29)
        Me.StatusTxt.TabIndex = 111
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(728, 303)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(19, 21)
        Me.Label20.TabIndex = 110
        Me.Label20.Text = "4"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(728, 158)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(19, 21)
        Me.Label19.TabIndex = 109
        Me.Label19.Text = "2"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(728, 231)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(19, 21)
        Me.Label18.TabIndex = 109
        Me.Label18.Text = "3"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(728, 86)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(19, 21)
        Me.Label17.TabIndex = 108
        Me.Label17.Text = "1"
        '
        'LBLstatGuide4
        '
        Me.LBLstatGuide4.AutoSize = True
        Me.LBLstatGuide4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLstatGuide4.ForeColor = System.Drawing.Color.Yellow
        Me.LBLstatGuide4.Location = New System.Drawing.Point(518, 303)
        Me.LBLstatGuide4.Name = "LBLstatGuide4"
        Me.LBLstatGuide4.Size = New System.Drawing.Size(178, 21)
        Me.LBLstatGuide4.TabIndex = 107
        Me.LBLstatGuide4.Text = "_____________________"
        '
        'LBLstatGuide3
        '
        Me.LBLstatGuide3.AutoSize = True
        Me.LBLstatGuide3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLstatGuide3.ForeColor = System.Drawing.Color.Yellow
        Me.LBLstatGuide3.Location = New System.Drawing.Point(518, 231)
        Me.LBLstatGuide3.Name = "LBLstatGuide3"
        Me.LBLstatGuide3.Size = New System.Drawing.Size(178, 21)
        Me.LBLstatGuide3.TabIndex = 106
        Me.LBLstatGuide3.Text = "_____________________"
        '
        'LBLstatGuide2
        '
        Me.LBLstatGuide2.AutoSize = True
        Me.LBLstatGuide2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLstatGuide2.ForeColor = System.Drawing.Color.Yellow
        Me.LBLstatGuide2.Location = New System.Drawing.Point(518, 158)
        Me.LBLstatGuide2.Name = "LBLstatGuide2"
        Me.LBLstatGuide2.Size = New System.Drawing.Size(178, 21)
        Me.LBLstatGuide2.TabIndex = 105
        Me.LBLstatGuide2.Text = "_____________________"
        '
        'LBLstatGuide1
        '
        Me.LBLstatGuide1.AutoSize = True
        Me.LBLstatGuide1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLstatGuide1.ForeColor = System.Drawing.Color.Yellow
        Me.LBLstatGuide1.Location = New System.Drawing.Point(518, 86)
        Me.LBLstatGuide1.Name = "LBLstatGuide1"
        Me.LBLstatGuide1.Size = New System.Drawing.Size(178, 21)
        Me.LBLstatGuide1.TabIndex = 104
        Me.LBLstatGuide1.Text = "_____________________"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(518, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 21)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "Status Guide:"
        '
        'CBupdateStatus
        '
        Me.CBupdateStatus.AutoSize = True
        Me.CBupdateStatus.ForeColor = System.Drawing.Color.Yellow
        Me.CBupdateStatus.Location = New System.Drawing.Point(195, 428)
        Me.CBupdateStatus.Name = "CBupdateStatus"
        Me.CBupdateStatus.Size = New System.Drawing.Size(94, 17)
        Me.CBupdateStatus.TabIndex = 9
        Me.CBupdateStatus.Text = "Update Status"
        Me.CBupdateStatus.UseVisualStyleBackColor = True
        '
        'CBstatus
        '
        Me.CBstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBstatus.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBstatus.FormattingEnabled = True
        Me.CBstatus.Location = New System.Drawing.Point(198, 396)
        Me.CBstatus.Name = "CBstatus"
        Me.CBstatus.Size = New System.Drawing.Size(295, 29)
        Me.CBstatus.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(134, 399)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 21)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "Status:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(35, 334)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(162, 21)
        Me.Label12.TabIndex = 99
        Me.Label12.Text = "Date Processed PO:"
        '
        'DApprovePOTxt
        '
        Me.DApprovePOTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DApprovePOTxt.Location = New System.Drawing.Point(198, 363)
        Me.DApprovePOTxt.Name = "DApprovePOTxt"
        Me.DApprovePOTxt.Size = New System.Drawing.Size(295, 27)
        Me.DApprovePOTxt.TabIndex = 8
        '
        'dateRRLB
        '
        Me.dateRRLB.AutoSize = True
        Me.dateRRLB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateRRLB.ForeColor = System.Drawing.Color.White
        Me.dateRRLB.Location = New System.Drawing.Point(42, 366)
        Me.dateRRLB.Name = "dateRRLB"
        Me.dateRRLB.Size = New System.Drawing.Size(155, 21)
        Me.dateRRLB.TabIndex = 38
        Me.dateRRLB.Text = "Date Approve PO:"
        '
        'DProcessedPOTxt
        '
        Me.DProcessedPOTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DProcessedPOTxt.Location = New System.Drawing.Point(198, 330)
        Me.DProcessedPOTxt.Name = "DProcessedPOTxt"
        Me.DProcessedPOTxt.Size = New System.Drawing.Size(295, 27)
        Me.DProcessedPOTxt.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(99, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "PR Details:"
        '
        'PRDetailsTxt
        '
        Me.PRDetailsTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRDetailsTxt.Location = New System.Drawing.Point(195, 19)
        Me.PRDetailsTxt.Multiline = True
        Me.PRDetailsTxt.Name = "PRDetailsTxt"
        Me.PRDetailsTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.PRDetailsTxt.Size = New System.Drawing.Size(298, 107)
        Me.PRDetailsTxt.TabIndex = 0
        '
        'PRNumberTxt
        '
        Me.PRNumberTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRNumberTxt.Location = New System.Drawing.Point(195, 165)
        Me.PRNumberTxt.Name = "PRNumberTxt"
        Me.PRNumberTxt.Size = New System.Drawing.Size(298, 27)
        Me.PRNumberTxt.TabIndex = 2
        '
        'DPDraftPRTxt
        '
        Me.DPDraftPRTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DPDraftPRTxt.Location = New System.Drawing.Point(246, 198)
        Me.DPDraftPRTxt.Name = "DPDraftPRTxt"
        Me.DPDraftPRTxt.Size = New System.Drawing.Size(247, 27)
        Me.DPDraftPRTxt.TabIndex = 3
        '
        'DRFinalPRTxt
        '
        Me.DRFinalPRTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DRFinalPRTxt.Location = New System.Drawing.Point(246, 231)
        Me.DRFinalPRTxt.Name = "DRFinalPRTxt"
        Me.DRFinalPRTxt.Size = New System.Drawing.Size(247, 27)
        Me.DRFinalPRTxt.TabIndex = 4
        '
        'DPCDraftTxt
        '
        Me.DPCDraftTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DPCDraftTxt.Location = New System.Drawing.Point(247, 264)
        Me.DPCDraftTxt.Name = "DPCDraftTxt"
        Me.DPCDraftTxt.Size = New System.Drawing.Size(246, 27)
        Me.DPCDraftTxt.TabIndex = 5
        '
        'DNumberTxt
        '
        Me.DNumberTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DNumberTxt.Location = New System.Drawing.Point(195, 132)
        Me.DNumberTxt.Name = "DNumberTxt"
        Me.DNumberTxt.Size = New System.Drawing.Size(298, 27)
        Me.DNumberTxt.TabIndex = 1
        '
        'DPCFinalTxt
        '
        Me.DPCFinalTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DPCFinalTxt.Location = New System.Drawing.Point(246, 297)
        Me.DPCFinalTxt.Name = "DPCFinalTxt"
        Me.DPCFinalTxt.Size = New System.Drawing.Size(246, 27)
        Me.DPCFinalTxt.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(93, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "PR Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(7, 299)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(239, 21)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Date Processed Canvas Final:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(42, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 21)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Date Processed Draft PR:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(2, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(244, 21)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Date Processed Canvas Draft:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(51, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Date Returned Final PR:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(39, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 21)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Doctrack Number:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormAddPRPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(811, 652)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormAddPRPO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PR PO Form"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents closeBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents DeleteBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents updateBTN As FontAwesome.Sharp.IconButton
    Friend WithEvents SaveBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PrintBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dateTxt As TextBox
    Friend WithEvents NoLbl As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dateRRLB As Label
    Friend WithEvents DProcessedPOTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PRDetailsTxt As TextBox
    Friend WithEvents PRNumberTxt As TextBox
    Friend WithEvents DPDraftPRTxt As TextBox
    Friend WithEvents DRFinalPRTxt As TextBox
    Friend WithEvents DPCDraftTxt As TextBox
    Friend WithEvents DNumberTxt As TextBox
    Friend WithEvents DPCFinalTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label12 As Label
    Friend WithEvents DApprovePOTxt As TextBox
    Friend WithEvents CBstatus As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents CBupdateStatus As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LBLstatGuide4 As Label
    Friend WithEvents LBLstatGuide3 As Label
    Friend WithEvents LBLstatGuide2 As Label
    Friend WithEvents LBLstatGuide1 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents StatusTxt As TextBox
    Friend WithEvents dateEncodedLbl As Label
    Friend WithEvents dateUpdatedLbl As Label
    Friend WithEvents processedTimeLbl As Label
End Class
