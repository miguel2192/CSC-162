
'Title: Lab 2D Array
'Author:    Miguel Rodriguez
'Date:      4/07/2016
'Course:    CSC 162
'Section:   001
'Description:   This program creates a 2d array. It them lets the user 
'   store the number of votes for four diferrent cities and three 
'   different voting groups in the United States. It then proceeds
'   and prints out everything in a table fashion to the user
'
'Initial Algorithm:
'   1.  Initialize a voter group array to 3
'   2.  Initialize a city array to 4
'   3.  Iniutialize a 2d array to size (4,3)
'   4.  ask the user for the number of votes for each city
'   5.  Fills the 2 dimentional array with user input
'   6.  Prints the array to the user in a table fashion
'   7.  provides the user with the option to repeat the program
'   8.  provides the option to exit the program
'
'Data Requirements:
'   Input:
'       Enter votes
'   Output:
'       None
'   Additional:
'       None
'
'Formulas:
'
Public Class frm2dArray

    'global constants

    'global variables
    Dim voterGroup(3) As String     'holds the voter groups array
    Dim CityArray(4) As String      'holds the city array
    Dim Votes(4, 3) As String       'holds the 2 dimesional array

    Private Sub btnCMD_Click(sender As Object, e As EventArgs) Handles btnCMD.Click

        'local constants

        'local variables
        Dim row As Integer               'row counter
        Dim col As Integer               'column counter
        Dim voteNum As String            'holds the voteNum (not tested)
        Dim validNumber As Integer       'holds valid votes


        voterGroup(1) = "Democrats"      'inserts democrats in index 1 in array voterGroup
        voterGroup(2) = "Republicans"    'inserts Republicans in index 2 in array voterGroup
        voterGroup(3) = "Independents"   'inserts Independents in index 3 in array voterGroup
        CityArray(1) = "East Side"       'inserts East Side in index 1 in array CityArray
        CityArray(2) = "West Side"       'inserts West Side in index 2 in array CityArray
        CityArray(3) = "South side"      'inserts South side in index 3 in array CityArray
        CityArray(4) = "North Side"      'inserts North Side in index 4 in array CityArray

        For row = 1 To 4 'while on a row

            For col = 1 To 3 'cycle through it's columns
                voteNum = InputBox("Please Enter number of " & voterGroup(col) & " votes for " & CityArray(row), "Area")
                If IsNumeric(voteNum) Then  'check for numeric input
                    validNumber = Val(voteNum) 'convert to integer
                    Votes(row, col) = validNumber 'inserts calid votes into the 2 dimensional array
                Else

                    'warning message to the user that the input that they entered is a letter not a number
                    MessageBox.Show("Please enter a numeric value!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    col -= 1 'decrease counter by one

                End If

            Next col
        Next row

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        'Local Constants

        'Local variables
        Dim outputString As String
        'Print out 2-D Array
        outputString = String.Format("{0, 15}", " ") 'print 15 spaces before column header is printed

        For col = 1 To 3 'print column header

            'print each Product name on field width of 10 and stay on same line
            outputString = outputString & String.Format("{0, 15}", voterGroup(col))
        Next col

        'print outputString in Listbox
        List1.Items.Add(outputString) 'will automatically go to next line

        For row = 1 To 4 'while on a row

            'print the city on field width of 15 and stay on same line
            outputString = String.Format("{0, 20}", CityArray(row))
            For col = 1 To 3 'cycle through it's columns
                'print product of row x col on field width of 4
                'stay on same line for each column value
                outputString = outputString + String.Format("{0, 10}", Votes(row, col))
            Next col
            'print outputString in Listbox
            List1.Items.Add(outputString) 'Move down to next row
        Next row

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'closes the application
        End
    End Sub
End Class
