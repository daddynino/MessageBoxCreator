Imports System.Globalization

Public Class MessageMain
    Dim ButtonSelection As String
    Dim ButtonDefault As Integer
    Dim IconSelection As String
    Dim OptionSelection As String

    Dim dragging As Boolean
    Dim startPoint As Point

    Private tooltips As New ToolTip()

    Private Sub MessageMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadButtons()
        LoadIcons()
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
        CboButtons.DisplayMember = "Name"
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
        CboIconSelection.DisplayMember = "Name"
        CboIconSelection.SelectedIndex = 5 '"MessageBoxIcon.Information"
    End Sub

    Private Sub CboButtons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboButtons.SelectedIndexChanged
        Dim selectedIndex As Integer = CboButtons.SelectedIndex

        Select Case selectedIndex
            Case 0
                ButtonSelection = "MessageBoxButtons.AbortRetryIgnore"
                ChangeActiveButton(1)
                SetButtonVisibility(True, True, True)
                SetButtonText("Abort", "Retry", "Ignore")
            Case 1
                ButtonSelection = "MessageBoxButtons.CancelTryContinue"
                ChangeActiveButton(1)
                SetButtonVisibility(True, True, True)
                SetButtonText("Cancel", "Try", "Continue")
            Case 2
                ButtonSelection = "MessageBoxButtons.OK"
                ChangeActiveButton(1)
                SetButtonVisibility(True, False, False)
                SetButtonText("Ok", "", "")
            Case 3
                ButtonSelection = "MessageBoxButtons.OKCancel"
                ChangeActiveButton(2)
                SetButtonVisibility(True, True, False)
                SetButtonText("Ok", "Cancel", "")
            Case 4
                ButtonSelection = "MessageBoxButtons.RetryCancel"
                ChangeActiveButton(2)
                SetButtonVisibility(True, True, False)
                SetButtonText("Retry", "Cancel", "")
            Case 5
                ButtonSelection = "MessageBoxButtons.YesNo"
                ChangeActiveButton(2)
                SetButtonVisibility(True, True, False)
                SetButtonText("Yes", "No", "")
            Case 6
                ButtonSelection = "MessageBoxButtons.YesNoCancel"
                ChangeActiveButton(3)
                SetButtonVisibility(True, True, True)
                SetButtonText("Yes", "No", "Cancel")
            Case Else
                ButtonSelection = "MessageBoxButtons.OK"
                ChangeActiveButton(1)
                SetButtonVisibility(True, False, False)
                SetButtonText("Ok", "", "")
        End Select

        Generate()
    End Sub

    Private Sub SetButtonVisibility(visible1 As Boolean, visible2 As Boolean, visible3 As Boolean)
        ButtonChoice1.Visible = visible1
        ButtonChoice2.Visible = visible2
        ButtonChoice3.Visible = visible3
    End Sub

    Private Sub SetButtonText(text1 As String, text2 As String, text3 As String)
        ButtonChoice1.Text = text1
        ButtonChoice2.Text = text2
        ButtonChoice3.Text = text3
    End Sub

    Private Sub CboIconSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboIconSelection.SelectedIndexChanged
        Dim selectedIndex As Integer = CInt(CboIconSelection.SelectedIndex)
        Dim selectedValue As String = selectedIndex.ToString(CultureInfo.InvariantCulture) ' Using CultureInfo.InvariantCulture as the format provider
        ' Use the selectedValue as needed
        Select Case selectedValue'CInt(CboIconSelection.SelectedIndex.ToString)
            Case "0"
                IconSelection = "MessageBoxIcon.Asterisk"
            Case "1"
                IconSelection = "MessageBoxIcon.Error"
            Case "2"
                IconSelection = "MessageBoxIcon.Exclamation"
            Case "3"
                IconSelection = "MessageBoxIcon.Hand"
            Case "4"
                IconSelection = "MessageBoxIcon.Information"
            Case "5"
                IconSelection = "MessageBoxIcon.None"
            Case "6"
                IconSelection = "MessageBoxIcon.Question"
            Case "7"
                IconSelection = "MessageBoxIcon.Stop"
            Case "8"
                IconSelection = "MessageBoxIcon.Warning"
            Case Else
                IconSelection = "MessageBoxIcon.None"
        End Select
        Generate()
    End Sub

    Sub ChangeActiveButton(ButtonNumber As Integer)

        Const NumberOfButtons As Integer = 3
        Dim Buttons() As Button = {ButtonChoice1, ButtonChoice2, ButtonChoice3}

        ' Clear all buttons to default state
        For Each btn In Buttons
            btn.FlatAppearance.BorderSize = 1
        Next

        ' Set active button based on ButtonNumber
        If ButtonNumber >= 1 AndAlso ButtonNumber <= NumberOfButtons Then
            Buttons(ButtonNumber - 1).FlatAppearance.BorderSize = 3 ' ButtonNumber is 1-based, array index is 0-based
            ButtonDefault = ButtonNumber
        Else
            Buttons(0).FlatAppearance.BorderSize = 3 ' Default to first button if ButtonNumber is invalid
            ButtonDefault = 1
        End If

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
        tooltips.SetToolTip(LblXToClose, "Exit the app")
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

        If ButtonDefault > 0 Then
            strResults &= "MessageBoxDefaultButton.Button" & ButtonDefault & ")"
        Else
            strResults &= "MessageBoxDefaultButton.Button1)"
        End If

        RTBResult.Text = strResults

    End Sub

    Shared Function ButtonConvert(Selection As Integer) As String

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

    Private Sub LblXToClose_Click(sender As Object, e As EventArgs) Handles LblXToClose.Click
        Me.Close()
    End Sub

    Private Sub MessageMain_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            dragging = True
            startPoint = New Point(e.X, e.Y)
        End If
    End Sub

    Private Sub MessageMain_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If dragging Then
            Dim p As Point = Me.PointToScreen(New Point(e.X, e.Y))
            Me.Location = New Point(p.X - startPoint.X, p.Y - startPoint.Y)
        End If
    End Sub

    Private Sub MessageMain_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = MouseButtons.Left Then
            dragging = False
        End If
    End Sub

    Private Sub PanelTitleHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitleHeader.MouseDown
        If e.Button = MouseButtons.Left Then
            dragging = True
            startPoint = New Point(e.X, e.Y)
        End If
    End Sub

    Private Sub PanelTitleHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTitleHeader.MouseMove
        If dragging Then
            Dim p As Point = Me.PointToScreen(New Point(e.X, e.Y))
            Me.Location = New Point(p.X - startPoint.X, p.Y - startPoint.Y)
        End If
    End Sub

    Private Sub PanelTitleHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelTitleHeader.MouseUp
        If e.Button = MouseButtons.Left Then
            dragging = False
        End If
    End Sub

    Private Sub LabelTitleHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles LabelTitleHeader.MouseDown
        If e.Button = MouseButtons.Left Then
            dragging = True
            startPoint = New Point(e.X, e.Y)
        End If
    End Sub

    Private Sub LabelTitleHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles LabelTitleHeader.MouseMove
        If dragging Then
            Dim p = PointToScreen(New Point(e.X, e.Y))
            Location = New Point(p.X - startPoint.X, p.Y - startPoint.Y)
        End If
    End Sub

    Private Sub LabelTitleHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles LabelTitleHeader.MouseUp
        If e.Button = MouseButtons.Left Then
            dragging = False
        End If
    End Sub

End Class

Public Class Item

    'Public Property ID As Integer
    Public Property Name As String

    ' Constructor
    Public Sub New(name As String)
        Me.Name = name
    End Sub

End Class