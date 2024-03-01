'Imports System.Threading.Channels
'Imports System.Windows.Forms.VisualStyles.VisualStyleElement
'Imports Microsoft.VisualBasic.Devices

Public Class MessageMain
    Dim ButtonSelection As String 'System.Windows.Forms.MessageBoxButtons = Nothing
    Dim ButtonDefault As Integer
    Dim IconSelection As String 'System.Windows.Forms.MessageBoxIcon = Nothing
    Dim OptionSelection As String 'System.Windows.Forms.MessageBoxOptions = Nothing

    Private tooltips As New ToolTip()

    Private Sub MessageMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadButtons()
        LoadIcons()
        LoadOptions()
        SetTooltips()
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

    Sub LoadOptions()
        ' Create a list of Item objects
        Dim items As New List(Of Item) From {
            New Item("None"),
            New Item("Default Desktop Only"),
            New Item("Right-Align Text"),
            New Item("Right-To-Left Reading"),
            New Item("Service Notification")
        }



        ' Set the ComboBox DataSource to the list of items
        CboOptions.DataSource = items

        ' Set the DisplayMember to the property you want to display (in this case, "Name")
        CboOptions.DisplayMember = "Name"

        ' Optionally, set the ValueMember if you want to retrieve the selected object later
        'CboIconSelection.ValueMember = "ID"

        ' You can also set other properties as needed, e.g., selected item, etc.
        CboOptions.SelectedIndex = 0
        OptionSelection = Nothing
    End Sub
    Private Sub CboButtons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboButtons.SelectedIndexChanged
        'MsgBox("selected index Is:" & CboButtons.SelectedIndex.ToString)
        'MsgBox("selected item is: " & CboButtons.SelectedIndex.ToString)
        Select Case CboButtons.SelectedIndex.ToString
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
    End Sub

    Private Sub CboIconSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboIconSelection.SelectedIndexChanged
        Select Case CboIconSelection.SelectedIndex.ToString
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
    End Sub

    Sub ChangeActiveButton(ButtonNumber As Integer)
        Select Case ButtonNumber
            Case "1"
                ButtonChoice1.FlatStyle = FlatStyle.Flat
                ButtonChoice1.FlatAppearance.BorderSize = 1
                ButtonChoice2.FlatStyle = FlatStyle.Standard
                ButtonChoice2.FlatAppearance.BorderSize = 0
                ButtonChoice3.FlatStyle = FlatStyle.Standard
                ButtonChoice3.FlatAppearance.BorderSize = 0
                ButtonDefault = 1
            Case "2"
                ButtonChoice1.FlatStyle = FlatStyle.Standard
                ButtonChoice1.FlatAppearance.BorderSize = 0
                ButtonChoice2.FlatStyle = FlatStyle.Flat
                ButtonChoice2.FlatAppearance.BorderSize = 1
                ButtonChoice3.FlatStyle = FlatStyle.Standard
                ButtonChoice3.FlatAppearance.BorderSize = 0
                ButtonDefault = 2
            Case "3"
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

    Private Sub CboOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboOptions.SelectedIndexChanged
        Select Case CboOptions.SelectedIndex.ToString
            Case 0
                OptionSelection = Nothing
            Case 1
                OptionSelection = "System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly"
            Case 2
                OptionSelection = "System.Windows.Forms.MessageBoxOptions.RightAlign"
            Case 3
                OptionSelection = "System.Windows.Forms.MessageBoxOptions.RtlReading"
            Case 4
                OptionSelection = "System.Windows.Forms.MessageBoxOptions.ServiceNotification"
            Case Else
                OptionSelection = Nothing
        End Select
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
        tooltips.SetToolTip(CboOptions, "Choose which option to use. Default is none")
        tooltips.SetToolTip(TxtVariable, "Save user response to this varible")
        tooltips.SetToolTip(BtnExit, "Exit the app")
    End Sub

    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles BtnGenerate.Click
        Dim strResults As String = String.Empty
        RTBResult.Text = String.Empty

        'sanity check
        If Len(RichTextBox1.Text) = 0 Then
            'MsgBox("No text to display", vbOK, "Blank entry?")
            MessageBox.Show("No dialog text to display", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        If Len(TxtVariable.Text) > 0 Then ' use as variable
            strResults = "Dim " & TxtVariable.Text & " As DialogResult = " 'System.Windows.Forms.MessageBox.Show("
        End If

        strResults &= "MessageBox.Show(" 'System.Windows.Forms.
        'strResults = strResults & "owner:me,"
        strResults = strResults & """" & RichTextBox1.Text & ""","
        strResults = strResults & """" & TxtCaption.Text & ""","

        strResults = strResults & " " & ButtonSelection & "," 'System.Windows.Forms.


        strResults = strResults & " " & IconSelection & "," 'System.Windows.Forms.
        'End If

        If ButtonChoice1.FlatStyle = FlatStyle.Flat Then
            strResults &= "MessageBoxDefaultButton.Button1" 'System.Windows.Forms.
        End If

        If ButtonChoice2.FlatStyle = FlatStyle.Flat Then
            strResults &= "MessageBoxDefaultButton.Button2" 'System.Windows.Forms.
        End If

        If ButtonChoice3.FlatStyle = FlatStyle.Flat Then
            strResults &= "MessageBoxDefaultButton.Button3" 'System.Windows.Forms.
        End If

        strResults &= ")"

        'If Len(OptionSelection) > 0 Then
        '    strResults = strResults & " " & OptionSelection ' & ","
        'Else
        '    strResults = strResults & " MessageBoxOptions.DefaultDesktopOnly" 'System.Windows.Forms.
        'End If

        'strResults = strResults & "helpFilePath:="""","
        'strResults = strResults & "keyword:=""PickSomething"""

        RTBResult.Text = strResults


        'strResults = strResults & "icon:=" Then
        'end if
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        About.Show()
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