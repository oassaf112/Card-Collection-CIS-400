Option Explicit On
Option Infer Off
Option Strict On
'Final Project - Soccer Collection
'Name : Omar Assaf

Imports System.ComponentModel

Public Class frmMain
    Private cards(100) As Card
    Private intCardIndex As Integer = 0
    Private boolUnsaved As Boolean
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click, mnuExitFile.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add team names to the combo box
        cboTeam.Items.Add("Manchester United")
        cboTeam.Items.Add("Atlético Madrid")
        cboTeam.Items.Add("Manchester City")
        cboTeam.Items.Add("Bayern Munich")
        cboTeam.Items.Add("Real Madrid")
        cboTeam.Items.Add("Barcelona")
        cboTeam.Items.Add("Liverpool")
        cboTeam.Items.Add("Arsenal")

        ' Disable delete and update buttons
        btnDelete.Enabled = False
        btnUpdate.Enabled = False


    End Sub

    ' Populates the list box with the cards
    Private Sub populateListBox()
        Dim cards As Card() = Me.cards
        Dim index As Integer = 0
        While index < cards.Length
            Dim card As Card = cards(index)
            If card IsNot Nothing Then
                lstCards.Items.Add(DirectCast(card.ToString(), Object))
            End If
            index += 1
        End While
    End Sub

    ' Saves the cards to a text file
    Private Sub saveCards()
        Dim text As IO.StreamWriter = IO.File.AppendText("cards.txt")
        Dim cards As Card() = Me.cards
        Dim index As Integer = 0
        While index < cards.Length
            Dim card As Card = cards(index)
            If card IsNot Nothing Then
                text.WriteLine(card.PlayerName & "|" & card.Year.ToString() & "|" & card.Team & "|" & card.Graded.ToString() & "|" & card.Signed.ToString())
            End If
            index += 1
        End While
        text.Close()
        boolUnsaved = False
    End Sub

    ' Validates the user input
    Private Sub ValidateForm()
        ' Checks if the Player's Name is empty
        If txtPlayerName.Text.Trim = String.Empty Then
            MessageBox.Show("Please enter the Player's Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            ' Checks if the Year is not a 4-digit number
        ElseIf txtYear.Text.Length <> 4 Then
            MessageBox.Show("Please provide a 4-digit Year", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            ' Checks if the Team is empty
        ElseIf cboTeam.Text.Trim = String.Empty Then
            MessageBox.Show("Please choose or enter a Team", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub

    ' Converts the string to proper case
    Private Function properCase(strInput As String) As String
        Dim str1 As String = ""
        strInput = strInput.Trim()
        While strInput.Contains("  ")
            strInput = strInput.Replace("  ", " ")
        End While
        Dim strArray As String() = strInput.Split(" "c)
        Dim index As Integer = 0
        While index < strArray.Length
            Dim str2 As String = strArray(index)
            str1 = str1 & str2(0).ToString().ToUpper() & str2.Substring(1).ToLower() & " "
            index += 1
        End While
        Return str1.Trim()
    End Function

    'Selects all text in the text box
    Private Sub selectAll(sender As Object, e As EventArgs) Handles txtYear.Enter, txtPlayerName.Enter
        DirectCast(sender, TextBox).SelectAll()
    End Sub

    'Save the current list of cards to a file
    Private Sub mnuSaveFile_Click(sender As Object, e As EventArgs) Handles mnuSaveFile.Click
        Me.saveCards()
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        'check that the input fields are valid
        ValidateForm()

        Dim strPlayerName As String = properCase(txtPlayerName.Text)
        Dim strTeam As String = properCase(cboTeam.Text)
        Dim result As Integer

        'If txtYear.Text cannot be parsed as an Integer, an error message is displayed
        If Not Integer.TryParse(txtYear.Text, result) Then
            Dim num1 As Integer = MessageBox.Show("Error loading " & txtYear.Text & " into intYear", "Parse Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            Dim boolGraded As Boolean = chkGraded.Checked
            Dim boolSigned As Boolean = rdoYes.Checked
            cards(intCardIndex) = New Card(strPlayerName, result, strTeam, boolGraded, boolSigned)
            boolUnsaved = True
            'update the card list box with the new card
            populateListBox()
        End If
    End Sub

    'User can only enter numbers in txtYear
    Private Sub txtYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtYear.KeyPress
        ' Allow only digits and backspace key to be entered into the text box
        If e.KeyChar >= "0" AndAlso e.KeyChar <= "9" OrElse e.KeyChar = ControlChars.Back Then
            Return
        End If
        ' Block all other characters from being entered into the text box
        e.Handled = True
    End Sub

    Private Sub lstCards_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCards.SelectedIndexChanged
        If lstCards.SelectedIndex = -1 Then
            ' Disable the update and delete buttons when no card is selected
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
        Else
            ' Populate the text boxes with the selected card's information
            Dim card As Card = cards(lstCards.SelectedIndex)
            txtPlayerName.Text = card.PlayerName
            txtYear.Text = card.Year.ToString()
            cboTeam.Text = card.Team
            chkGraded.Checked = card.Graded
            rdoYes.Checked = card.Signed

            ' Enable the update and delete buttons when a card is selected
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ValidateForm()
        ' Get the player name and team name from the form
        Dim st1 As String = properCase(txtPlayerName.Text)
        Dim st2 As String = properCase(cboTeam.Text)

        ' Convert the year text to an integer
        Dim res As Integer
        If Not Integer.TryParse(txtYear.Text, res) Then
            ' If the year text can't be converted to an integer, show an error message
            Dim num1 As Integer = MessageBox.Show("Error loading " & txtYear.Text & " into intYear", "Parse Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            ' Get the graded and signed status from the form
            Dim fl1 As Boolean = chkGraded.Checked
            Dim fl2 As Boolean = rdoYes.Checked
            cards(lstCards.SelectedIndex).PlayerName = st1
            cards(lstCards.SelectedIndex).Year = res
            cards(lstCards.SelectedIndex).Team = st2
            cards(lstCards.SelectedIndex).Graded = fl1
            cards(lstCards.SelectedIndex).Signed = fl2
            ' Mark the file as unsaved
            boolUnsaved = True
            ' Refresh the list box
            populateListBox()
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        ' Clear the form and deselect any selected card
        clearForm(True)
        lstCards.SelectedIndex = -1
    End Sub

    Private Sub clearForm(ByVal boolConfirm As Boolean)
        'If confirmation is requested and form fields are not empty
        'Show a confirmation dialog and check if the user selected "No"
        If boolConfirm AndAlso (txtPlayerName.Text <> String.Empty OrElse txtYear.Text <> String.Empty OrElse cboTeam.Text <> String.Empty) AndAlso MessageBox.Show(
            "Are you sure you want to clear this form?",
            "Are you sure?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        'Clear all form fields and reset radio buttons
        txtPlayerName.Text = String.Empty
        txtYear.Text = String.Empty
        cboTeam.Text = String.Empty
        chkGraded.Checked = False
        rdoNo.Checked = True
    End Sub

    Private Sub mnuOpenFile_Click(sender As Object, e As EventArgs) Handles mnuOpenFile.Click
        LoadCards()
        populateListBox()
    End Sub

    Private Sub LoadCards()
        ' Check if the "cards.txt" file exists
        If Not IO.File.Exists("cards.txt") Then
            Return
        End If

        ' Open the "cards.txt" file for reading
        Dim load As IO.StreamReader = IO.File.OpenText("cards.txt")

        ' Loop through each line in the file
        While load.Peek() <> -1
            Dim strArray As String() = load.ReadLine().Split("|"c)
            Dim strPlayerName As String = strArray(0)
            Dim year As Integer
            Integer.TryParse(strArray(1), year)
            Dim strTeam As String = strArray(2)
            Dim boolGraded As Boolean = String.Compare(strArray(3), "True", False) = 0
            Dim boolSigned As Boolean = String.Compare(strArray(4), "True", False) = 0

            ' Create a new Card object with the retrieved values and add it to the "cards" array
            cards(intCardIndex) = New Card(strPlayerName, year, strTeam, boolGraded, boolSigned)
            ' Increment the "intCardIndex" variable to point to the next index in the "cards" array
            intCardIndex += 1
        End While

        load.Close()
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to delete this card?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        ' Get the index of the selected item in the list box
        Dim delete As Integer = lstCards.SelectedIndex
        ' Remove the selected item from the list box
        lstCards.Items.RemoveAt(delete)
        ' Set the corresponding element in the "cards" array to "Nothing" to delete it
        cards(delete) = Nothing
        ' Set the "boolUnsaved" flag to "True" to indicate that changes have been made
        boolUnsaved = True
        clearForm(False)
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' Check if the user has unsaved work
        If Not boolUnsaved Then
            ' If there are no unsaved changes, return nothing
            Return
        End If

        ' If there are unsaved changes, prompt the user to save before closing
        Dim dialogResult As DialogResult = MessageBox.Show("You have not saved your work. Save before closing?", "Warning: Not Saved", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        ' If the user chooses to cancel closing, set CancelEventArgs.Cancel to True
        If dialogResult = DialogResult.Cancel Then
            e.Cancel = True
        End If

        ' If the user chooses to save before closing, call saveCards() function
        If dialogResult = DialogResult.Yes Then
            saveCards()
        End If
    End Sub


End Class
