Public Class MessageMain
    Dim ButtonSelection As String
    Dim ButtonDefault As Integer
    Dim IconSelection As String
    Dim OptionSelection As String

    Private tooltips As New ToolTip()

    Private Sub MessageMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadButtons()
        LoadIcons()
        'LoadOptions()
        SetTooltips()
        LockItems(Not String.IsNullOrWhiteSpace(RichTextBox1.Text))
    End Sub

    Sub LoadButtons()
        ' Create a list of Item objects
        Dim items As New List(Of Item) From {
            New Item("Abort, Retry, Ignore"),
            New Item("Cancel, Try Again, Continue"),
            New Item("Ok"),
            New Item("Ok, Cancel"),
            New Item("Retry, Cancel"),
            New Item("Yes, No"),
            New Item("Yes, No, Cancel")
        }

        ' Set the ComboBox DataSource to the list of items
        CboButtons.DataSource = items

        ' Set the DisplayMember to the property you want to display (in this case, "Name")
        CboButtons.DisplayMember = "Name"

        ' Optionally, set the ValueMember if you want to retrieve the selected object later
        'CboButtons.ValueMember = "ID"

        ' You can also set other properties as needed, e.g., selected item, etc.
        CboButtons.SelectedIndex = 2
        ButtonSelection = "MessageBoxButtons.Ok"
    End Sub

    Sub LoadIcons()
        ' Create a list of Item objects
        Dim items As New List(Of Item) From {
            New Item("Asterisk"),
            New Item("Error"),
            New Item("Exclamation"),
            New Item("Hand"),
            New Item("Information"),
            New Item("None"),
            New Item("Question"),
            New Item("Stop"),
            New Item("Warning")
        }

        ' Set the ComboBox DataSource to the list of items
        CboIconSelection.DataSource = items

        ' Set the DisplayMember to the property you want to display (in this case, "Name")
        CboIconSelection.DisplayMember = "Name"

        ' Optionally, set the ValueMember if you want to retrieve the selected object later
        'CboIconSelection.ValueMember = "ID"

        ' You can also set other properties as needed, e.g., selected item, etc.
        CboIconSelection.SelectedIndex = 5 '"MessageBoxIcon.Information"
    End Sub

    Private Sub CboButtons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboButtons.SelectedIndexChanged

        Select Case CInt(CboButtons.SelectedIndex.ToString)
            Case 0
                ButtonSelection = "MessageBoxButtons.AbortRetryIgnore"
                ChangeActiveButton(1)
                ButtonChoice1.Visible = True
                ButtonChoice2.Visible = True
                ButtonChoice3.Visible = True
                ButtonChoice1.Text = "Abort"
                ButtonChoice2.Text = "Retry"
                ButtonChoice3.Text = "Ignore"
            Case 1
                ButtonSelection = "MessageBoxButtons.CancelTryContinue"
                ChangeActiveButton(1)
                ButtonChoice1.Visible = True
                ButtonChoice2.Visible = True
                ButtonChoice3.Visible = True
                ButtonChoice1.Text = "Cancel"
                ButtonChoice2.Text = "Try"
                ButtonChoice3.Text = "Continue"
            Case 2
                ButtonSelection = "MessageBoxButtons.OK"
                ChangeActiveButton(1)
                ButtonChoice1.Text = "Ok"
                ButtonChoice1.Visible = True
                ButtonChoice2.Visible = False
                ButtonChoice3.Visible = False

            Case 3
                ButtonSelection = "MessageBoxButtons.OKCancel"
                ChangeActiveButton(2)
                ButtonChoice1.Text = "Ok"
                ButtonChoice2.Text = "Cancel"
                ButtonChoice1.Visible = True
                ButtonChoice2.Visible = True
                ButtonChoice3.Visible = False

            Case 4
                ButtonSelection = "MessageBoxButtons.RetryCancel"
                ChangeActiveButton(2)
                ButtonChoice1.Text = "Retry"
                ButtonChoice2.Text = "Cancel"
                ButtonChoice1.Visible = True
                ButtonChoice2.Visible = True
                ButtonChoice3.Visible = False
            Case 5
                ButtonSelection = "MessageBoxButtons.YesNo"
                ChangeActiveButton(2)
                ButtonChoice1.Text = "Yes"
                ButtonChoice2.Text = "No"
                ButtonChoice1.Visible = True
                ButtonChoice2.Visible = True
                ButtonChoice3.Visible = False
            Case 6
                ButtonSelection = "MessageBoxButtons.YesNoCancel"
                ChangeActiveButton(3)
                ButtonChoice1.Text = "Yes"
                ButtonChoice2.Text = "No"
                ButtonChoice3.Text = "Cancel"
                ButtonChoice1.Visible = True
                ButtonChoice2.Visible = True
                ButtonChoice3.Visible = True
            Case Else
                ' Handle other cases or do nothing, defaults to OK
                ButtonSelection = "MessageBoxButtons.OK"
                ChangeActiveButton(1)
                ButtonChoice1.Text = "Ok"
                ButtonChoice1.Visible = True
                ButtonChoice2.Visible = False
                ButtonChoice3.Visible = False
        End Select
        Generate()
    End Sub

    Private Sub CboIconSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboIconSelection.SelectedIndexChanged
        Select Case CInt(CboIconSelection.SelectedIndex.ToString)
            Case 0
                IconSelection = "MessageBoxIcon.Asterisk"
            Case 1
                IconSelection = "MessageBoxIcon.Error"
            Case 2
                IconSelection = "MessageBoxIcon.Exclamation"
            Case 3
                IconSelection = "MessageBoxIcon.Hand"
            Case 4
                IconSelection = "MessageBoxIcon.Information"
            Case 5
                IconSelection = "MessageBoxIcon.None"
            Case 6
                IconSelection = "MessageBoxIcon.Question"
            Case 7
                IconSelection = "MessageBoxIcon.Stop"
            Case 8
                IconSelection = "MessageBoxIcon.Warning"
            Case Else
                IconSelection = "MessageBoxIcon.None"
        End Select
        Generate()
    End Sub

    Sub ChangeActiveButton(ButtonNumber As Integer)
        Select Case ButtonNumber
            Case 1
                ButtonChoice1.FlatStyle = FlatStyle.Flat
                ButtonChoice1.FlatAppearance.BorderSize = 1
                ButtonChoice2.FlatStyle = FlatStyle.Standard
                ButtonChoice2.FlatAppearance.BorderSize = 0
                ButtonChoice3.FlatStyle = FlatStyle.Standard
                ButtonChoice3.FlatAppearance.BorderSize = 0
                ButtonDefault = 1
            Case 2
                ButtonChoice1.FlatStyle = FlatStyle.Standard
                ButtonChoice1.FlatAppearance.BorderSize = 0
                ButtonChoice2.FlatStyle = FlatStyle.Flat
                ButtonChoice2.FlatAppearance.BorderSize = 1
                ButtonChoice3.FlatStyle = FlatStyle.Standard
                ButtonChoice3.FlatAppearance.BorderSize = 0
                ButtonDefault = 2
            Case 3
                ButtonChoice1.FlatStyle = FlatStyle.Standard
                ButtonChoice1.FlatAppearance.BorderSize = 0
                ButtonChoice2.FlatStyle = FlatStyle.Standard
                ButtonChoice2.FlatAppearance.BorderSize = 0
                ButtonChoice3.FlatStyle = FlatStyle.Flat
                ButtonChoice3.FlatAppearance.BorderSize = 1
                ButtonDefault = 3
            Case Else
                ButtonChoice1.FlatStyle = FlatStyle.Standard
                ButtonChoice1.FlatAppearance.BorderSize = 0
                ButtonChoice2.FlatStyle = FlatStyle.Standard
                ButtonChoice2.FlatAppearance.BorderSize = 0
                ButtonChoice3.FlatStyle = FlatStyle.Standard
                ButtonChoice3.FlatAppearance.BorderSize = 0
                ButtonDefault = 1
        End Select
        Generate()
    End Sub

    Private Sub ButtonChoice1_Click(sender As Object, e As EventArgs) Handles ButtonChoice1.Click
        ChangeActiveButton(1)
    End Sub

    Private Sub ButtonChoice2_Click(sender As Object, e As EventArgs) Handles ButtonChoice2.Click
        ChangeActiveButton(2)
    End Sub

    Private Sub ButtonChoice3_Click(sender As Object, e As EventArgs) Handles ButtonChoice3.Click
        ChangeActiveButton(3)
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub


    Sub SetTooltips()
        ' Clear existing tooltips
        tooltips.RemoveAll()

        tooltips.SetToolTip(RichTextBox1, "Primary message to display")
        tooltips.SetToolTip(TxtCaption, "Title of message box")
        tooltips.SetToolTip(CboButtons, "Choose which buttons to display")
        tooltips.SetToolTip(ButtonChoice1, "Select to make this the default button")
        tooltips.SetToolTip(ButtonChoice2, "Select to make this the default button")
        tooltips.SetToolTip(ButtonChoice3, "Select to make this the default button")
        tooltips.SetToolTip(CboIconSelection, "Choose which icon to display")
        tooltips.SetToolTip(TxtVariable, "Save user response to this varible")
        tooltips.SetToolTip(BtnAbout, "Open the application About form")
        tooltips.SetToolTip(BtnExit, "Exit the app")
    End Sub

    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs)
        Generate()
    End Sub

    Sub Generate()
        Dim strResults As String = String.Empty
        RTBResult.Text = String.Empty
        If String.IsNullOrWhiteSpace(RichTextBox1.Text) Then
            RTBResult.Text = ""
            Exit Sub
        End If


        If Len(TxtVariable.Text) > 0 Then ' use as variable
            strResults = "Dim " & TxtVariable.Text & " As DialogResult = "
        End If

        strResults &= "MessageBox.Show("
        strResults = strResults & """" & RichTextBox1.Text & ""","
        strResults = strResults & """" & TxtCaption.Text & ""","

        strResults = strResults & " " & ButtonSelection & ","

        strResults = strResults & " " & IconSelection & ","


        If ButtonChoice1.FlatStyle = FlatStyle.Flat Then
            strResults &= "MessageBoxDefaultButton.Button1"
        End If

        If ButtonChoice2.FlatStyle = FlatStyle.Flat Then
            strResults &= "MessageBoxDefaultButton.Button2"
        End If

        If ButtonChoice3.FlatStyle = FlatStyle.Flat Then
            strResults &= "MessageBoxDefaultButton.Button3"
        End If

        strResults &= ")"

        RTBResult.Text = strResults

    End Sub

    Shared Function ButtonConvert(Selection As Integer) As String
        'Dim strReturn As String = String.Empty
        'OK  0
        'The Message box contains an OK button.

        'OKCancel    1
        'The Message box contains OK And Cancel buttons.

        'RetryCancel 5
        'The Message box contains Retry And Cancel buttons.

        'YesNo   4
        'The Message box contains Yes And No buttons.

        'YesNoCancel 3
        'The Message box contains Yes, No, And Cancel buttons.

        Select Case Selection
            Case 0
                Return "System.Windows.Forms.MessageBoxButtons.AbortRetryIgnore"
            Case 1
                Return "System.Windows.Forms.MessageBoxButtons.CancelTryContinue"
            Case 2
                Return "System.Windows.Forms.MessageBoxButtons.Ok"
            Case 3
                Return "System.Windows.Forms.MessageBoxButtons.OkCancel"
            Case 4
                Return "System.Windows.Forms.MessageBoxButtons.RetryCancel"
            Case 5
                Return "System.Windows.Forms.MessageBoxButtons.YesNo"
            Case 6
                Return "System.Windows.Forms.MessageBoxButtons.YesNoCancel"
            Case Else
                Return "System.Windows.Forms.MessageBoxButtons.Ok"
        End Select
    End Function

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click
        ' Check if the TextBox has text
        If RTBResult.Text.Length > 0 Then
            ' Copy the text to the clipboard
            Clipboard.SetText(RTBResult.Text)
        End If

    End Sub

    Private Sub LockItems(ValidText As Boolean)
        ' Enable or disable controls based on the ValidText value
        Me.TxtCaption.Enabled = ValidText
        Me.CboButtons.Enabled = ValidText
        Me.ButtonChoice1.Enabled = ValidText
        Me.ButtonChoice2.Enabled = ValidText
        Me.ButtonChoice3.Enabled = ValidText
        Me.CboIconSelection.Enabled = ValidText
        Me.TxtVariable.Enabled = ValidText
        Me.BtnCopy.Enabled = ValidText
        Me.RTBResult.Enabled = ValidText

    End Sub

    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
        About.Show()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

        LockItems(Not String.IsNullOrWhiteSpace(RichTextBox1.Text))
        Generate()
    End Sub

    Private Sub TxtCaption_TextChanged(sender As Object, e As EventArgs) Handles TxtCaption.TextChanged
        Generate()
    End Sub

    Private Sub TxtVariable_TextChanged(sender As Object, e As EventArgs) Handles TxtVariable.TextChanged
        Generate()
    End Sub

End Class

Public Class Item

    'Public Property ID As Integer
    Public Property Name As String

    ' Constructor
    Public Sub New(name As String)
        'Me.ID = Id
        Me.Name = name
    End Sub

End Class