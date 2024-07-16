<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MessageMain
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
        TxtCaption = New TextBox()
        LblMsgText = New Label()
        LblCaption = New Label()
        LblDefault = New Label()
        LblButtonType = New Label()
        RichTextBox1 = New RichTextBox()
        CboButtons = New ComboBox()
        CboIconSelection = New ComboBox()
        LblIcon = New Label()
        ButtonChoice1 = New Button()
        ButtonChoice2 = New Button()
        ButtonChoice3 = New Button()
        RTBResult = New RichTextBox()
        LblResult = New Label()
        BtnCopy = New Button()
        Label1 = New Label()
        TxtVariable = New TextBox()
        BtnAbout = New Button()
        PanelTitleHeader = New Panel()
        LblXToClose = New Label()
        LabelTitleHeader = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        BtnExit = New Button()
        Panel4 = New Panel()
        Panel5 = New Panel()
        PanelTitleHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' TxtCaption
        ' 
        TxtCaption.Font = New Font("Microsoft Sans Serif", 14.25F)
        TxtCaption.Location = New Point(13, 206)
        TxtCaption.Margin = New Padding(4)
        TxtCaption.Name = "TxtCaption"
        TxtCaption.Size = New Size(389, 29)
        TxtCaption.TabIndex = 1
        ' 
        ' LblMsgText
        ' 
        LblMsgText.AutoSize = True
        LblMsgText.Font = New Font("Microsoft Sans Serif", 14.25F)
        LblMsgText.ForeColor = Color.White
        LblMsgText.Location = New Point(13, 51)
        LblMsgText.Margin = New Padding(4, 0, 4, 0)
        LblMsgText.Name = "LblMsgText"
        LblMsgText.Size = New Size(200, 24)
        LblMsgText.TabIndex = 10
        LblMsgText.Text = "Dialog Text (Required)"
        ' 
        ' LblCaption
        ' 
        LblCaption.AutoSize = True
        LblCaption.Font = New Font("Microsoft Sans Serif", 14.25F)
        LblCaption.ForeColor = Color.White
        LblCaption.Location = New Point(13, 180)
        LblCaption.Margin = New Padding(4, 0, 4, 0)
        LblCaption.Name = "LblCaption"
        LblCaption.Size = New Size(74, 24)
        LblCaption.TabIndex = 11
        LblCaption.Text = "Caption"
        ' 
        ' LblDefault
        ' 
        LblDefault.AutoSize = True
        LblDefault.Font = New Font("Microsoft Sans Serif", 14.25F)
        LblDefault.ForeColor = Color.White
        LblDefault.Location = New Point(13, 349)
        LblDefault.Margin = New Padding(4, 0, 4, 0)
        LblDefault.Name = "LblDefault"
        LblDefault.Size = New Size(125, 24)
        LblDefault.TabIndex = 13
        LblDefault.Text = "Default Button"
        ' 
        ' LblButtonType
        ' 
        LblButtonType.AutoSize = True
        LblButtonType.Font = New Font("Microsoft Sans Serif", 14.25F)
        LblButtonType.ForeColor = Color.White
        LblButtonType.Location = New Point(13, 266)
        LblButtonType.Margin = New Padding(4, 0, 4, 0)
        LblButtonType.Name = "LblButtonType"
        LblButtonType.Size = New Size(72, 24)
        LblButtonType.TabIndex = 15
        LblButtonType.Text = "Buttons"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Font = New Font("Microsoft Sans Serif", 14.25F)
        RichTextBox1.Location = New Point(13, 77)
        RichTextBox1.Margin = New Padding(4)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(823, 75)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = ""
        ' 
        ' CboButtons
        ' 
        CboButtons.Font = New Font("Microsoft Sans Serif", 14.25F)
        CboButtons.FormattingEnabled = True
        CboButtons.Location = New Point(13, 292)
        CboButtons.Margin = New Padding(4)
        CboButtons.Name = "CboButtons"
        CboButtons.Size = New Size(389, 32)
        CboButtons.TabIndex = 2
        ' 
        ' CboIconSelection
        ' 
        CboIconSelection.Font = New Font("Microsoft Sans Serif", 14.25F)
        CboIconSelection.FormattingEnabled = True
        CboIconSelection.Location = New Point(13, 460)
        CboIconSelection.Margin = New Padding(4)
        CboIconSelection.Name = "CboIconSelection"
        CboIconSelection.Size = New Size(389, 32)
        CboIconSelection.TabIndex = 6
        ' 
        ' LblIcon
        ' 
        LblIcon.AutoSize = True
        LblIcon.Font = New Font("Microsoft Sans Serif", 14.25F)
        LblIcon.ForeColor = Color.White
        LblIcon.Location = New Point(13, 434)
        LblIcon.Margin = New Padding(4, 0, 4, 0)
        LblIcon.Name = "LblIcon"
        LblIcon.Size = New Size(46, 24)
        LblIcon.TabIndex = 21
        LblIcon.Text = "Icon"
        ' 
        ' ButtonChoice1
        ' 
        ButtonChoice1.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ButtonChoice1.FlatStyle = FlatStyle.Flat
        ButtonChoice1.Font = New Font("Microsoft Sans Serif", 12F)
        ButtonChoice1.ForeColor = Color.White
        ButtonChoice1.Location = New Point(13, 375)
        ButtonChoice1.Margin = New Padding(4)
        ButtonChoice1.Name = "ButtonChoice1"
        ButtonChoice1.Size = New Size(129, 32)
        ButtonChoice1.TabIndex = 3
        ButtonChoice1.Text = "Button1"
        ButtonChoice1.UseVisualStyleBackColor = True
        ' 
        ' ButtonChoice2
        ' 
        ButtonChoice2.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ButtonChoice2.FlatStyle = FlatStyle.Flat
        ButtonChoice2.Font = New Font("Microsoft Sans Serif", 12F)
        ButtonChoice2.ForeColor = Color.White
        ButtonChoice2.Location = New Point(143, 375)
        ButtonChoice2.Margin = New Padding(4)
        ButtonChoice2.Name = "ButtonChoice2"
        ButtonChoice2.Size = New Size(129, 32)
        ButtonChoice2.TabIndex = 4
        ButtonChoice2.Text = "Button2"
        ButtonChoice2.UseVisualStyleBackColor = True
        ' 
        ' ButtonChoice3
        ' 
        ButtonChoice3.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ButtonChoice3.FlatStyle = FlatStyle.Flat
        ButtonChoice3.Font = New Font("Microsoft Sans Serif", 12F)
        ButtonChoice3.ForeColor = Color.White
        ButtonChoice3.Location = New Point(273, 375)
        ButtonChoice3.Margin = New Padding(4)
        ButtonChoice3.Name = "ButtonChoice3"
        ButtonChoice3.Size = New Size(129, 32)
        ButtonChoice3.TabIndex = 5
        ButtonChoice3.Text = "Button3"
        ButtonChoice3.UseVisualStyleBackColor = True
        ' 
        ' RTBResult
        ' 
        RTBResult.Font = New Font("Microsoft Sans Serif", 14.25F)
        RTBResult.Location = New Point(417, 207)
        RTBResult.Margin = New Padding(4)
        RTBResult.Name = "RTBResult"
        RTBResult.Size = New Size(419, 285)
        RTBResult.TabIndex = 8
        RTBResult.Text = ""
        ' 
        ' LblResult
        ' 
        LblResult.AutoSize = True
        LblResult.Font = New Font("Microsoft Sans Serif", 14.25F)
        LblResult.ForeColor = Color.White
        LblResult.Location = New Point(417, 178)
        LblResult.Margin = New Padding(4, 0, 4, 0)
        LblResult.Name = "LblResult"
        LblResult.Size = New Size(113, 24)
        LblResult.TabIndex = 31
        LblResult.Text = "Code Result"
        ' 
        ' BtnCopy
        ' 
        BtnCopy.BackColor = Color.FromArgb(CByte(136), CByte(48), CByte(0))
        BtnCopy.FlatAppearance.BorderSize = 0
        BtnCopy.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BtnCopy.FlatStyle = FlatStyle.Flat
        BtnCopy.ForeColor = Color.White
        BtnCopy.Location = New Point(583, 500)
        BtnCopy.Margin = New Padding(4)
        BtnCopy.Name = "BtnCopy"
        BtnCopy.Size = New Size(100, 32)
        BtnCopy.TabIndex = 9
        BtnCopy.Text = "Copy &Text"
        BtnCopy.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 517)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(222, 24)
        Label1.TabIndex = 34
        Label1.Text = "Variable Name (Optional)"
        ' 
        ' TxtVariable
        ' 
        TxtVariable.Font = New Font("Microsoft Sans Serif", 14.25F)
        TxtVariable.Location = New Point(12, 543)
        TxtVariable.Margin = New Padding(4)
        TxtVariable.Name = "TxtVariable"
        TxtVariable.Size = New Size(389, 29)
        TxtVariable.TabIndex = 7
        ' 
        ' BtnAbout
        ' 
        BtnAbout.BackColor = Color.FromArgb(CByte(136), CByte(48), CByte(0))
        BtnAbout.FlatAppearance.BorderSize = 0
        BtnAbout.FlatAppearance.MouseDownBackColor = Color.Maroon
        BtnAbout.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BtnAbout.FlatStyle = FlatStyle.Flat
        BtnAbout.Font = New Font("Segoe UI", 12F)
        BtnAbout.ForeColor = Color.White
        BtnAbout.Location = New Point(13, 605)
        BtnAbout.Margin = New Padding(0)
        BtnAbout.Name = "BtnAbout"
        BtnAbout.Size = New Size(86, 32)
        BtnAbout.TabIndex = 10
        BtnAbout.Text = "&About"
        BtnAbout.UseVisualStyleBackColor = False
        ' 
        ' PanelTitleHeader
        ' 
        PanelTitleHeader.BackColor = Color.FromArgb(CByte(136), CByte(48), CByte(0))
        PanelTitleHeader.Controls.Add(LblXToClose)
        PanelTitleHeader.Controls.Add(LabelTitleHeader)
        PanelTitleHeader.Dock = DockStyle.Top
        PanelTitleHeader.Location = New Point(0, 0)
        PanelTitleHeader.Name = "PanelTitleHeader"
        PanelTitleHeader.Size = New Size(849, 43)
        PanelTitleHeader.TabIndex = 37
        ' 
        ' LblXToClose
        ' 
        LblXToClose.AutoSize = True
        LblXToClose.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblXToClose.ForeColor = Color.White
        LblXToClose.Location = New Point(819, 9)
        LblXToClose.Name = "LblXToClose"
        LblXToClose.Size = New Size(24, 24)
        LblXToClose.TabIndex = 1
        LblXToClose.Text = "X"
        ' 
        ' LabelTitleHeader
        ' 
        LabelTitleHeader.AutoSize = True
        LabelTitleHeader.Font = New Font("Microsoft Sans Serif", 14.25F)
        LabelTitleHeader.ForeColor = Color.White
        LabelTitleHeader.Location = New Point(12, 9)
        LabelTitleHeader.Name = "LabelTitleHeader"
        LabelTitleHeader.Size = New Size(186, 24)
        LabelTitleHeader.TabIndex = 0
        LabelTitleHeader.Text = "MessageBox Creator"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(136), CByte(48), CByte(0))
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 43)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(3, 610)
        Panel1.TabIndex = 38
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(136), CByte(48), CByte(0))
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(3, 650)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(846, 3)
        Panel2.TabIndex = 39
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(136), CByte(48), CByte(0))
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(846, 43)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(3, 607)
        Panel3.TabIndex = 39
        ' 
        ' BtnExit
        ' 
        BtnExit.BackColor = Color.FromArgb(CByte(136), CByte(48), CByte(0))
        BtnExit.FlatAppearance.BorderSize = 0
        BtnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BtnExit.FlatStyle = FlatStyle.Flat
        BtnExit.Font = New Font("Segoe UI", 12F)
        BtnExit.ForeColor = Color.White
        BtnExit.Location = New Point(764, 605)
        BtnExit.Margin = New Padding(4)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(72, 32)
        BtnExit.TabIndex = 11
        BtnExit.Text = "E&xit"
        BtnExit.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(136), CByte(48), CByte(0))
        Panel4.Location = New Point(408, 178)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(3, 459)
        Panel4.TabIndex = 40
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(136), CByte(48), CByte(0))
        Panel5.Location = New Point(13, 163)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(823, 3)
        Panel5.TabIndex = 41
        ' 
        ' MessageMain
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(22), CByte(24), CByte(32))
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(849, 653)
        Controls.Add(Panel4)
        Controls.Add(Panel5)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PanelTitleHeader)
        Controls.Add(BtnAbout)
        Controls.Add(Label1)
        Controls.Add(TxtVariable)
        Controls.Add(BtnCopy)
        Controls.Add(LblResult)
        Controls.Add(RTBResult)
        Controls.Add(BtnExit)
        Controls.Add(ButtonChoice3)
        Controls.Add(ButtonChoice2)
        Controls.Add(ButtonChoice1)
        Controls.Add(CboIconSelection)
        Controls.Add(LblIcon)
        Controls.Add(CboButtons)
        Controls.Add(RichTextBox1)
        Controls.Add(LblButtonType)
        Controls.Add(LblDefault)
        Controls.Add(LblCaption)
        Controls.Add(LblMsgText)
        Controls.Add(TxtCaption)
        Font = New Font("Segoe UI", 12F)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        MaximizeBox = False
        Name = "MessageMain"
        Text = "MessageBox Creator"
        PanelTitleHeader.ResumeLayout(False)
        PanelTitleHeader.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TxtCaption As TextBox
    Friend WithEvents LblMsgText As Label
    Friend WithEvents LblCaption As Label
    Friend WithEvents LblDefault As Label
    Friend WithEvents LblButtonType As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents CboButtons As ComboBox
    Friend WithEvents CboIconSelection As ComboBox
    Friend WithEvents LblIcon As Label
    Friend WithEvents ButtonChoice1 As Button
    Friend WithEvents ButtonChoice2 As Button
    Friend WithEvents ButtonChoice3 As Button
    Friend WithEvents RTBResult As RichTextBox
    Friend WithEvents LblResult As Label
    Friend WithEvents BtnCopy As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtVariable As TextBox
    Friend WithEvents BtnAbout As Button
    Friend WithEvents PanelTitleHeader As Panel
    Friend WithEvents LblXToClose As Label
    Friend WithEvents LabelTitleHeader As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnExit As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel

End Class
