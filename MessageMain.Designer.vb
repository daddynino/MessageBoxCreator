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
        BtnExit = New Button()
        RTBResult = New RichTextBox()
        LblResult = New Label()
        BtnCopy = New Button()
        Label1 = New Label()
        TxtVariable = New TextBox()
        BtnAbout = New Button()
        SuspendLayout()
        ' 
        ' TxtCaption
        ' 
        TxtCaption.Location = New Point(129, 123)
        TxtCaption.Margin = New Padding(4)
        TxtCaption.Name = "TxtCaption"
        TxtCaption.Size = New Size(340, 29)
        TxtCaption.TabIndex = 1
        ' 
        ' LblMsgText
        ' 
        LblMsgText.AutoSize = True
        LblMsgText.Font = New Font("Segoe UI", 12F)
        LblMsgText.Location = New Point(11, 15)
        LblMsgText.Margin = New Padding(4, 0, 4, 0)
        LblMsgText.Name = "LblMsgText"
        LblMsgText.Size = New Size(85, 21)
        LblMsgText.TabIndex = 10
        LblMsgText.Text = "Dialog Text"
        ' 
        ' LblCaption
        ' 
        LblCaption.AutoSize = True
        LblCaption.Font = New Font("Segoe UI", 12F)
        LblCaption.Location = New Point(15, 131)
        LblCaption.Margin = New Padding(4, 0, 4, 0)
        LblCaption.Name = "LblCaption"
        LblCaption.Size = New Size(64, 21)
        LblCaption.TabIndex = 11
        LblCaption.Text = "Caption"
        ' 
        ' LblDefault
        ' 
        LblDefault.AutoSize = True
        LblDefault.Font = New Font("Segoe UI", 12F)
        LblDefault.Location = New Point(15, 240)
        LblDefault.Margin = New Padding(4, 0, 4, 0)
        LblDefault.Name = "LblDefault"
        LblDefault.Size = New Size(60, 21)
        LblDefault.TabIndex = 13
        LblDefault.Text = "Default"
        ' 
        ' LblButtonType
        ' 
        LblButtonType.AutoSize = True
        LblButtonType.Font = New Font("Segoe UI", 12F)
        LblButtonType.Location = New Point(15, 185)
        LblButtonType.Margin = New Padding(4, 0, 4, 0)
        LblButtonType.Name = "LblButtonType"
        LblButtonType.Size = New Size(63, 21)
        LblButtonType.TabIndex = 15
        LblButtonType.Text = "Buttons"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(129, 15)
        RichTextBox1.Margin = New Padding(4)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(831, 75)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = ""
        ' 
        ' CboButtons
        ' 
        CboButtons.FormattingEnabled = True
        CboButtons.Location = New Point(129, 181)
        CboButtons.Margin = New Padding(4)
        CboButtons.Name = "CboButtons"
        CboButtons.Size = New Size(340, 29)
        CboButtons.TabIndex = 2
        ' 
        ' CboIconSelection
        ' 
        CboIconSelection.FormattingEnabled = True
        CboIconSelection.Location = New Point(620, 123)
        CboIconSelection.Margin = New Padding(4)
        CboIconSelection.Name = "CboIconSelection"
        CboIconSelection.Size = New Size(340, 29)
        CboIconSelection.TabIndex = 6
        ' 
        ' LblIcon
        ' 
        LblIcon.AutoSize = True
        LblIcon.Font = New Font("Segoe UI", 12F)
        LblIcon.Location = New Point(500, 132)
        LblIcon.Margin = New Padding(4, 0, 4, 0)
        LblIcon.Name = "LblIcon"
        LblIcon.Size = New Size(39, 21)
        LblIcon.TabIndex = 21
        LblIcon.Text = "Icon"
        ' 
        ' ButtonChoice1
        ' 
        ButtonChoice1.Location = New Point(137, 234)
        ButtonChoice1.Margin = New Padding(4)
        ButtonChoice1.Name = "ButtonChoice1"
        ButtonChoice1.Size = New Size(100, 32)
        ButtonChoice1.TabIndex = 3
        ButtonChoice1.Text = "Button1"
        ButtonChoice1.UseVisualStyleBackColor = True
        ' 
        ' ButtonChoice2
        ' 
        ButtonChoice2.Location = New Point(246, 234)
        ButtonChoice2.Margin = New Padding(4)
        ButtonChoice2.Name = "ButtonChoice2"
        ButtonChoice2.Size = New Size(100, 32)
        ButtonChoice2.TabIndex = 4
        ButtonChoice2.Text = "Button2"
        ButtonChoice2.UseVisualStyleBackColor = True
        ' 
        ' ButtonChoice3
        ' 
        ButtonChoice3.Location = New Point(354, 234)
        ButtonChoice3.Margin = New Padding(4)
        ButtonChoice3.Name = "ButtonChoice3"
        ButtonChoice3.Size = New Size(100, 32)
        ButtonChoice3.TabIndex = 5
        ButtonChoice3.Text = "Button3"
        ButtonChoice3.UseVisualStyleBackColor = True
        ' 
        ' BtnExit
        ' 
        BtnExit.Location = New Point(860, 543)
        BtnExit.Margin = New Padding(4)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(100, 32)
        BtnExit.TabIndex = 12
        BtnExit.Text = "E&xit"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' RTBResult
        ' 
        RTBResult.Location = New Point(129, 293)
        RTBResult.Margin = New Padding(4)
        RTBResult.Name = "RTBResult"
        RTBResult.Size = New Size(831, 179)
        RTBResult.TabIndex = 10
        RTBResult.Text = ""
        ' 
        ' LblResult
        ' 
        LblResult.AutoSize = True
        LblResult.Location = New Point(15, 293)
        LblResult.Margin = New Padding(4, 0, 4, 0)
        LblResult.Name = "LblResult"
        LblResult.Size = New Size(96, 21)
        LblResult.TabIndex = 31
        LblResult.Text = "Code Result:"
        ' 
        ' BtnCopy
        ' 
        BtnCopy.Location = New Point(473, 492)
        BtnCopy.Margin = New Padding(4)
        BtnCopy.Name = "BtnCopy"
        BtnCopy.Size = New Size(100, 32)
        BtnCopy.TabIndex = 11
        BtnCopy.Text = "Copy &Text"
        BtnCopy.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(500, 186)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 21)
        Label1.TabIndex = 34
        Label1.Text = "Variable Name"
        ' 
        ' TxtVariable
        ' 
        TxtVariable.Location = New Point(620, 181)
        TxtVariable.Margin = New Padding(4)
        TxtVariable.Name = "TxtVariable"
        TxtVariable.Size = New Size(340, 29)
        TxtVariable.TabIndex = 8
        ' 
        ' BtnAbout
        ' 
        BtnAbout.FlatAppearance.BorderSize = 0
        BtnAbout.FlatStyle = FlatStyle.Flat
        BtnAbout.Location = New Point(11, 546)
        BtnAbout.Margin = New Padding(4)
        BtnAbout.Name = "BtnAbout"
        BtnAbout.Size = New Size(75, 32)
        BtnAbout.TabIndex = 35
        BtnAbout.Text = "&About"
        BtnAbout.UseVisualStyleBackColor = True
        ' 
        ' MessageMain
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(975, 592)
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
        Margin = New Padding(4)
        Name = "MessageMain"
        Text = "MessageBox Creator"
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
    Friend WithEvents BtnExit As Button
    Friend WithEvents RTBResult As RichTextBox
    Friend WithEvents LblResult As Label
    Friend WithEvents BtnCopy As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtVariable As TextBox
    Friend WithEvents BtnAbout As Button

End Class
