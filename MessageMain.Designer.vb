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
        CboOptions = New ComboBox()
        LblOptions = New Label()
        BtnGenerate = New Button()
        RTBResult = New RichTextBox()
        LblResult = New Label()
        BtnCopy = New Button()
        Label1 = New Label()
        TxtVariable = New TextBox()
        SuspendLayout()
        ' 
        ' TxtCaption
        ' 
        TxtCaption.Location = New Point(113, 103)
        TxtCaption.Name = "TxtCaption"
        TxtCaption.Size = New Size(247, 23)
        TxtCaption.TabIndex = 1
        ' 
        ' LblMsgText
        ' 
        LblMsgText.AutoSize = True
        LblMsgText.Location = New Point(21, 31)
        LblMsgText.Name = "LblMsgText"
        LblMsgText.Size = New Size(65, 15)
        LblMsgText.TabIndex = 10
        LblMsgText.Text = "Dialog Text"
        ' 
        ' LblCaption
        ' 
        LblCaption.AutoSize = True
        LblCaption.Location = New Point(21, 108)
        LblCaption.Name = "LblCaption"
        LblCaption.Size = New Size(49, 15)
        LblCaption.TabIndex = 11
        LblCaption.Text = "Caption"
        ' 
        ' LblDefault
        ' 
        LblDefault.AutoSize = True
        LblDefault.Location = New Point(21, 184)
        LblDefault.Name = "LblDefault"
        LblDefault.Size = New Size(45, 15)
        LblDefault.TabIndex = 13
        LblDefault.Text = "Default"
        ' 
        ' LblButtonType
        ' 
        LblButtonType.AutoSize = True
        LblButtonType.Location = New Point(21, 140)
        LblButtonType.Name = "LblButtonType"
        LblButtonType.Size = New Size(48, 15)
        LblButtonType.TabIndex = 15
        LblButtonType.Text = "Buttons"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(113, 31)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(647, 55)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = ""
        ' 
        ' CboButtons
        ' 
        CboButtons.FormattingEnabled = True
        CboButtons.Location = New Point(113, 138)
        CboButtons.Name = "CboButtons"
        CboButtons.Size = New Size(247, 23)
        CboButtons.TabIndex = 2
        ' 
        ' CboIconSelection
        ' 
        CboIconSelection.FormattingEnabled = True
        CboIconSelection.Location = New Point(113, 218)
        CboIconSelection.Name = "CboIconSelection"
        CboIconSelection.Size = New Size(247, 23)
        CboIconSelection.TabIndex = 6
        ' 
        ' LblIcon
        ' 
        LblIcon.AutoSize = True
        LblIcon.Location = New Point(21, 220)
        LblIcon.Name = "LblIcon"
        LblIcon.Size = New Size(30, 15)
        LblIcon.TabIndex = 21
        LblIcon.Text = "Icon"
        ' 
        ' ButtonChoice1
        ' 
        ButtonChoice1.Location = New Point(113, 178)
        ButtonChoice1.Name = "ButtonChoice1"
        ButtonChoice1.Size = New Size(78, 23)
        ButtonChoice1.TabIndex = 3
        ButtonChoice1.Text = "Button1"
        ButtonChoice1.UseVisualStyleBackColor = True
        ' 
        ' ButtonChoice2
        ' 
        ButtonChoice2.Location = New Point(198, 178)
        ButtonChoice2.Name = "ButtonChoice2"
        ButtonChoice2.Size = New Size(78, 23)
        ButtonChoice2.TabIndex = 4
        ButtonChoice2.Text = "Button2"
        ButtonChoice2.UseVisualStyleBackColor = True
        ' 
        ' ButtonChoice3
        ' 
        ButtonChoice3.Location = New Point(282, 178)
        ButtonChoice3.Name = "ButtonChoice3"
        ButtonChoice3.Size = New Size(78, 23)
        ButtonChoice3.TabIndex = 5
        ButtonChoice3.Text = "Button3"
        ButtonChoice3.UseVisualStyleBackColor = True
        ' 
        ' BtnExit
        ' 
        BtnExit.Location = New Point(704, 393)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(78, 23)
        BtnExit.TabIndex = 12
        BtnExit.Text = "E&xit"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' CboOptions
        ' 
        CboOptions.FormattingEnabled = True
        CboOptions.Location = New Point(113, 252)
        CboOptions.Name = "CboOptions"
        CboOptions.Size = New Size(247, 23)
        CboOptions.TabIndex = 7
        ' 
        ' LblOptions
        ' 
        LblOptions.AutoSize = True
        LblOptions.Location = New Point(21, 254)
        LblOptions.Name = "LblOptions"
        LblOptions.Size = New Size(49, 15)
        LblOptions.TabIndex = 27
        LblOptions.Text = "Options"
        ' 
        ' BtnGenerate
        ' 
        BtnGenerate.Location = New Point(198, 324)
        BtnGenerate.Name = "BtnGenerate"
        BtnGenerate.Size = New Size(78, 23)
        BtnGenerate.TabIndex = 9
        BtnGenerate.Text = "&Generate"
        BtnGenerate.UseVisualStyleBackColor = True
        ' 
        ' RTBResult
        ' 
        RTBResult.Location = New Point(389, 138)
        RTBResult.Name = "RTBResult"
        RTBResult.Size = New Size(371, 169)
        RTBResult.TabIndex = 10
        RTBResult.Text = ""
        ' 
        ' LblResult
        ' 
        LblResult.AutoSize = True
        LblResult.Location = New Point(389, 106)
        LblResult.Name = "LblResult"
        LblResult.Size = New Size(73, 15)
        LblResult.TabIndex = 31
        LblResult.Text = "Code Result:"
        ' 
        ' BtnCopy
        ' 
        BtnCopy.Location = New Point(521, 324)
        BtnCopy.Name = "BtnCopy"
        BtnCopy.Size = New Size(78, 23)
        BtnCopy.TabIndex = 11
        BtnCopy.Text = "Copy &Text"
        BtnCopy.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 291)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 15)
        Label1.TabIndex = 34
        Label1.Text = "Variable Name"
        ' 
        ' TxtVariable
        ' 
        TxtVariable.Location = New Point(113, 286)
        TxtVariable.Name = "TxtVariable"
        TxtVariable.Size = New Size(247, 23)
        TxtVariable.TabIndex = 8
        ' 
        ' MessageMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(794, 428)
        Controls.Add(Label1)
        Controls.Add(TxtVariable)
        Controls.Add(BtnCopy)
        Controls.Add(LblResult)
        Controls.Add(RTBResult)
        Controls.Add(BtnGenerate)
        Controls.Add(CboOptions)
        Controls.Add(LblOptions)
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
    Friend WithEvents CboOptions As ComboBox
    Friend WithEvents LblOptions As Label
    Friend WithEvents BtnGenerate As Button
    Friend WithEvents RTBResult As RichTextBox
    Friend WithEvents LblResult As Label
    Friend WithEvents BtnCopy As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtVariable As TextBox

End Class
