<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        LogoPictureBox = New PictureBox()
        TxtProductName = New TextBox()
        TxtVersion = New TextBox()
        TxtCopyright = New TextBox()
        TextBoxDescription = New TextBox()
        Panel2 = New Panel()
        LblXToClose = New Label()
        LblTitle = New Label()
        Panel1 = New Panel()
        BtnExit = New Button()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' LogoPictureBox
        ' 
        LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), Image)
        LogoPictureBox.Location = New Point(0, 43)
        LogoPictureBox.Margin = New Padding(4, 3, 4, 3)
        LogoPictureBox.Name = "LogoPictureBox"
        LogoPictureBox.Size = New Size(149, 286)
        LogoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage
        LogoPictureBox.TabIndex = 0
        LogoPictureBox.TabStop = False
        ' 
        ' TxtProductName
        ' 
        TxtProductName.BackColor = Color.FromArgb(CByte(22), CByte(24), CByte(32))
        TxtProductName.BorderStyle = BorderStyle.None
        TxtProductName.Font = New Font("Segoe UI", 14.25F)
        TxtProductName.ForeColor = Color.White
        TxtProductName.Location = New Point(155, 52)
        TxtProductName.Margin = New Padding(7, 3, 4, 3)
        TxtProductName.Multiline = True
        TxtProductName.Name = "TxtProductName"
        TxtProductName.ReadOnly = True
        TxtProductName.Size = New Size(309, 24)
        TxtProductName.TabIndex = 1
        TxtProductName.TabStop = False
        TxtProductName.Text = "Product Name:"
        ' 
        ' TxtVersion
        ' 
        TxtVersion.BackColor = Color.FromArgb(CByte(22), CByte(24), CByte(32))
        TxtVersion.BorderStyle = BorderStyle.None
        TxtVersion.Font = New Font("Segoe UI", 14.25F)
        TxtVersion.ForeColor = Color.White
        TxtVersion.Location = New Point(155, 82)
        TxtVersion.Margin = New Padding(7, 3, 4, 3)
        TxtVersion.Multiline = True
        TxtVersion.Name = "TxtVersion"
        TxtVersion.ReadOnly = True
        TxtVersion.Size = New Size(309, 24)
        TxtVersion.TabIndex = 2
        TxtVersion.TabStop = False
        TxtVersion.Text = "Version:"
        ' 
        ' TxtCopyright
        ' 
        TxtCopyright.BackColor = Color.FromArgb(CByte(22), CByte(24), CByte(32))
        TxtCopyright.BorderStyle = BorderStyle.None
        TxtCopyright.Font = New Font("Segoe UI", 14.25F)
        TxtCopyright.ForeColor = Color.White
        TxtCopyright.Location = New Point(155, 112)
        TxtCopyright.Margin = New Padding(7, 3, 4, 3)
        TxtCopyright.Multiline = True
        TxtCopyright.Name = "TxtCopyright"
        TxtCopyright.ReadOnly = True
        TxtCopyright.Size = New Size(309, 24)
        TxtCopyright.TabIndex = 3
        TxtCopyright.TabStop = False
        TxtCopyright.Text = "Copyright:"
        ' 
        ' TextBoxDescription
        ' 
        TextBoxDescription.BackColor = Color.FromArgb(CByte(22), CByte(24), CByte(32))
        TextBoxDescription.BorderStyle = BorderStyle.None
        TextBoxDescription.Font = New Font("Segoe UI", 14.25F)
        TextBoxDescription.ForeColor = Color.White
        TextBoxDescription.Location = New Point(155, 156)
        TextBoxDescription.Margin = New Padding(7, 3, 4, 3)
        TextBoxDescription.Multiline = True
        TextBoxDescription.Name = "TextBoxDescription"
        TextBoxDescription.ReadOnly = True
        TextBoxDescription.Size = New Size(303, 135)
        TextBoxDescription.TabIndex = 0
        TextBoxDescription.TabStop = False
        TextBoxDescription.Text = "What it does..." & vbCrLf & vbCrLf & "Simple GUI to input messagebox options and output related code"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(136), CByte(48), CByte(0))
        Panel2.Controls.Add(LblXToClose)
        Panel2.Controls.Add(LblTitle)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(458, 43)
        Panel2.TabIndex = 12
        ' 
        ' LblXToClose
        ' 
        LblXToClose.AutoSize = True
        LblXToClose.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblXToClose.ForeColor = Color.White
        LblXToClose.Location = New Point(430, 11)
        LblXToClose.Name = "LblXToClose"
        LblXToClose.Size = New Size(24, 24)
        LblXToClose.TabIndex = 1
        LblXToClose.Text = "&X"
        ' 
        ' LblTitle
        ' 
        LblTitle.AutoSize = True
        LblTitle.Font = New Font("Microsoft Sans Serif", 14.25F)
        LblTitle.ForeColor = Color.White
        LblTitle.Location = New Point(11, 12)
        LblTitle.Name = "LblTitle"
        LblTitle.Size = New Size(186, 24)
        LblTitle.TabIndex = 0
        LblTitle.Text = "MessageBox Creator"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(136), CByte(48), CByte(0))
        Panel1.Location = New Point(194, 145)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(223, 5)
        Panel1.TabIndex = 13
        ' 
        ' BtnExit
        ' 
        BtnExit.FlatAppearance.BorderSize = 0
        BtnExit.FlatStyle = FlatStyle.Flat
        BtnExit.Font = New Font("Microsoft Sans Serif", 14.25F)
        BtnExit.ForeColor = Color.White
        BtnExit.Location = New Point(373, 286)
        BtnExit.Margin = New Padding(4)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(72, 32)
        BtnExit.TabIndex = 14
        BtnExit.Text = "&Close"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(136), CByte(48), CByte(0))
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(455, 43)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(3, 286)
        Panel3.TabIndex = 40
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(136), CByte(48), CByte(0))
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(0, 43)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(3, 286)
        Panel4.TabIndex = 41
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(136), CByte(48), CByte(0))
        Panel5.Dock = DockStyle.Bottom
        Panel5.Location = New Point(3, 326)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(452, 3)
        Panel5.TabIndex = 42
        ' 
        ' About
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(22), CByte(24), CByte(32))
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(458, 329)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(BtnExit)
        Controls.Add(Panel1)
        Controls.Add(TextBoxDescription)
        Controls.Add(TxtCopyright)
        Controls.Add(TxtVersion)
        Controls.Add(TxtProductName)
        Controls.Add(LogoPictureBox)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "About"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "About App Folder Generator"
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblXToClose As Label
    Friend WithEvents LblTitle As Label
    Friend WithEvents TxtProductName As TextBox
    Friend WithEvents TxtVersion As TextBox
    Friend WithEvents TxtCopyright As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnExit As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel

End Class
