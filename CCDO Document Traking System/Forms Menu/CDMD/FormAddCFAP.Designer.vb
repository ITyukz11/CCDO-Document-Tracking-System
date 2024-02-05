<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAddCFAP
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.processedTimeLbl = New System.Windows.Forms.Label()
        Me.StatusTxt = New System.Windows.Forms.TextBox()
        Me.CBupdateStatus = New System.Windows.Forms.CheckBox()
        Me.CBstatus = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DescriptionTxt = New System.Windows.Forms.TextBox()
        Me.ChargeTxt = New System.Windows.Forms.TextBox()
        Me.AmountTxt = New System.Windows.Forms.TextBox()
        Me.CodeTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PrintBtn = New FontAwesome.Sharp.IconButton()
        Me.closeBtn = New FontAwesome.Sharp.IconButton()
        Me.deleteBtn = New FontAwesome.Sharp.IconButton()
        Me.updateBTN = New FontAwesome.Sharp.IconButton()
        Me.SaveBtn = New FontAwesome.Sharp.IconButton()
        Me.NoLbl = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dateTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.processedTimeLbl)
        Me.GroupBox2.Controls.Add(Me.StatusTxt)
        Me.GroupBox2.Controls.Add(Me.CBupdateStatus)
        Me.GroupBox2.Controls.Add(Me.CBstatus)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.DescriptionTxt)
        Me.GroupBox2.Controls.Add(Me.ChargeTxt)
        Me.GroupBox2.Controls.Add(Me.AmountTxt)
        Me.GroupBox2.Controls.Add(Me.CodeTxt)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox2.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(787, 367)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Form"
        '
        'processedTimeLbl
        '
        Me.processedTimeLbl.AutoSize = True
        Me.processedTimeLbl.ForeColor = System.Drawing.Color.Yellow
        Me.processedTimeLbl.Location = New System.Drawing.Point(314, 339)
        Me.processedTimeLbl.Name = "processedTimeLbl"
        Me.processedTimeLbl.Size = New System.Drawing.Size(86, 13)
        Me.processedTimeLbl.TabIndex = 124
        Me.processedTimeLbl.Text = "Processed Time:"
        '
        'StatusTxt
        '
        Me.StatusTxt.Enabled = False
        Me.StatusTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusTxt.Location = New System.Drawing.Point(197, 274)
        Me.StatusTxt.Multiline = True
        Me.StatusTxt.Name = "StatusTxt"
        Me.StatusTxt.ReadOnly = True
        Me.StatusTxt.Size = New System.Drawing.Size(253, 29)
        Me.StatusTxt.TabIndex = 123
        '
        'CBupdateStatus
        '
        Me.CBupdateStatus.AutoSize = True
        Me.CBupdateStatus.ForeColor = System.Drawing.Color.Yellow
        Me.CBupdateStatus.Location = New System.Drawing.Point(194, 306)
        Me.CBupdateStatus.Name = "CBupdateStatus"
        Me.CBupdateStatus.Size = New System.Drawing.Size(94, 17)
        Me.CBupdateStatus.TabIndex = 8
        Me.CBupdateStatus.Text = "Update Status"
        Me.CBupdateStatus.UseVisualStyleBackColor = True
        '
        'CBstatus
        '
        Me.CBstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBstatus.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBstatus.FormattingEnabled = True
        Me.CBstatus.Location = New System.Drawing.Point(197, 274)
        Me.CBstatus.Name = "CBstatus"
        Me.CBstatus.Size = New System.Drawing.Size(298, 29)
        Me.CBstatus.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(133, 277)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 21)
        Me.Label13.TabIndex = 122
        Me.Label13.Text = "Status:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(87, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Description:"
        '
        'DescriptionTxt
        '
        Me.DescriptionTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTxt.Location = New System.Drawing.Point(197, 26)
        Me.DescriptionTxt.Multiline = True
        Me.DescriptionTxt.Name = "DescriptionTxt"
        Me.DescriptionTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DescriptionTxt.Size = New System.Drawing.Size(298, 107)
        Me.DescriptionTxt.TabIndex = 0
        '
        'ChargeTxt
        '
        Me.ChargeTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChargeTxt.Location = New System.Drawing.Point(197, 139)
        Me.ChargeTxt.Name = "ChargeTxt"
        Me.ChargeTxt.Size = New System.Drawing.Size(298, 27)
        Me.ChargeTxt.TabIndex = 1
        '
        'AmountTxt
        '
        Me.AmountTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountTxt.Location = New System.Drawing.Point(196, 205)
        Me.AmountTxt.Name = "AmountTxt"
        Me.AmountTxt.Size = New System.Drawing.Size(298, 27)
        Me.AmountTxt.TabIndex = 3
        '
        'CodeTxt
        '
        Me.CodeTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodeTxt.Location = New System.Drawing.Point(196, 172)
        Me.CodeTxt.Name = "CodeTxt"
        Me.CodeTxt.Size = New System.Drawing.Size(298, 27)
        Me.CodeTxt.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(114, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Charge:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(109, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 21)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Amount:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(130, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 21)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Code:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PrintBtn)
        Me.GroupBox3.Controls.Add(Me.closeBtn)
        Me.GroupBox3.Controls.Add(Me.deleteBtn)
        Me.GroupBox3.Controls.Add(Me.updateBTN)
        Me.GroupBox3.Controls.Add(Me.SaveBtn)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox3.Location = New System.Drawing.Point(12, 438)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(787, 114)
        Me.GroupBox3.TabIndex = 56
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
        Me.PrintBtn.Location = New System.Drawing.Point(5, 11)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.PrintBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PrintBtn.Size = New System.Drawing.Size(145, 97)
        Me.PrintBtn.TabIndex = 102
        Me.PrintBtn.Text = "History &Log"
        Me.PrintBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PrintBtn.UseVisualStyleBackColor = True
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
        Me.closeBtn.Location = New System.Drawing.Point(629, 19)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.closeBtn.Size = New System.Drawing.Size(150, 89)
        Me.closeBtn.TabIndex = 12
        Me.closeBtn.Text = "Refresh &Close"
        Me.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.closeBtn.UseVisualStyleBackColor = False
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.deleteBtn.FlatAppearance.BorderSize = 0
        Me.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.deleteBtn.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.deleteBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.deleteBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.deleteBtn.IconSize = 32
        Me.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.deleteBtn.Location = New System.Drawing.Point(473, 19)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.deleteBtn.Size = New System.Drawing.Size(150, 89)
        Me.deleteBtn.TabIndex = 11
        Me.deleteBtn.Text = "&Delete"
        Me.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.deleteBtn.UseVisualStyleBackColor = False
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
        Me.updateBTN.Location = New System.Drawing.Point(317, 19)
        Me.updateBTN.Name = "updateBTN"
        Me.updateBTN.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.updateBTN.Size = New System.Drawing.Size(150, 89)
        Me.updateBTN.TabIndex = 10
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
        Me.SaveBtn.Location = New System.Drawing.Point(162, 19)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.SaveBtn.Size = New System.Drawing.Size(149, 89)
        Me.SaveBtn.TabIndex = 9
        Me.SaveBtn.Text = "&Save"
        Me.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SaveBtn.UseVisualStyleBackColor = True
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
        Me.dateTxt.Size = New System.Drawing.Size(176, 20)
        Me.dateTxt.TabIndex = 27
        Me.dateTxt.Text = "11/11/2019 11:11:00"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dateTxt)
        Me.GroupBox1.Controls.Add(Me.NoLbl)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(787, 48)
        Me.GroupBox1.TabIndex = 54
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
        'FormAddCFAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(811, 559)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormAddCFAP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAddLiquidation"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents processedTimeLbl As Label
    Friend WithEvents StatusTxt As TextBox
    Friend WithEvents CBupdateStatus As CheckBox
    Friend WithEvents CBstatus As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DescriptionTxt As TextBox
    Friend WithEvents ChargeTxt As TextBox
    Friend WithEvents AmountTxt As TextBox
    Friend WithEvents CodeTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PrintBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents closeBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents deleteBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents updateBTN As FontAwesome.Sharp.IconButton
    Friend WithEvents SaveBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents NoLbl As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dateTxt As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
End Class
