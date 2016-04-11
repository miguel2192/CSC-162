'Title: Array Fill & Search
'Author:    Miguel Rodriguez
'Date:      4/07/2016
'Course:    CSC 162
'Section:   001
'Description:   This program creates an array of size 10.
'   it then proceeds to ask the user for 10 names and fills
'   the array with the 10 names. More after it then provides
'   an option to the user to search the array for an specific 
'   name. It also provides the option to exit the program by
'   clicking on a button.
'
'Initial Algorithm:
'   1.  Iniutialize the array of names to 10
'   2.  ask the user for 10 names
'   3.  Fills the array with the 10 names
'   4.  provides the user an option to search the array for a name
'   5.  provides the user with the option to repeat the program
'   6.  provides the option to exit the program
'
'Data Requirements:
'   Input:
'       Enter 10 names
'       Enter name that you wish to search for
'   Output:
'       None
'   Additional:
'       None
'
'Formulas:
'
Public Class frmArray

    'Global Constants
    Const MAX_SIZE As Integer = 10


    'Global variables
    Dim names(MAX_SIZE) As String     'initialize a fixed array to 10
    Dim counter As Integer         'holds the counter
    Dim sentinel As String = "y"   'holds a sentinel value
    Private Sub btnFill_Click(sender As Object, e As EventArgs) Handles btnFill.Click
        'Refined Algorithm
        ' Initialize global and local constants
        ' Initialize global and local variables
        ' create a names array an initialize to 10
        ' initilize counter to 0
        ' WHILE sentinel equals y
        '    FOR counter less 9
        '       Get 10 names from the user
        '       check for numeric input
        '       IF name is not a numbers
        '          store names in names array
        '       ELSE
        '          display an error
        '       END IF
        '    END FOR
        '    Do you wish to continue
        '    IF sentinel equals y
        '       re-inilize everything
        '    END IF
        ' END WHILE
        ' create a buttom to search for names
        ' WHILE sentinel equals y
        '    For counter < 9
        '       IF searchname is equal to array index
        '          display name was found in cell #
        '          increase variable found by one
        '       END IF
        '    END FOR
        '    IF found <= 0
        '       Display name wasn't found
        '    END IF
        '    Do you wish to continue y or n
        '    IF sentinel equals y
        '       re-inilize everything
        '    END IF
        ' END WHILE
        ' Allows the user to exit the program by pressing a button
        ' Tests for empty space input

        'Local Constants


        'Local Variables
        Dim name As String           'holds the user's number
        Dim index As Integer

        While sentinel = "y" Or sentinel = "Y"

            'enables the main button
            btnFill.Enabled = True

            'warning message telling the user that their grade is not in range
            MessageBox.Show("Please enter a name!", "Instructions!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            
            'rusn 10 times
            For counter = 0 To 9

                name = InputBox("Please enter a name: ", "Enter a name!", "") 'prompt's for name
                If IsNumeric(name) Then  'check for numeric input

                    'warning
                    MessageBox.Show("Please enter a name NOT a numeric input!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    'decrease counter
                    counter -= 1

                Else

                    'fills array with name
                    names(counter) = name
                End If

            Next counter

            'displays array is full
            MessageBox.Show("All names have been entered and stored successfully!", "Thank you for your input!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'disables the main buttom
            btnFill.Enabled = False

            sentinel = InputBox("Do you want to continue[y or n]?: ", "Enter y or n!", "") 'prompt's for name

            're-initializes everything
            If sentinel = "y" Or sentinel = "Y" Then

                'enables the main buttom
                btnFill.Enabled = True

                're-initializes counter
                counter = 0

            End If

        End While
        'runs 10 times
        For index = 0 To 9

            'lists the array elements using a list box
            List1.Items.Add("Index " & index & " -----" & names(index))

        Next index

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'closes the application
        End
    End Sub

    Private Sub bntSearch_Click(sender As Object, e As EventArgs) Handles bntSearch.Click

        'Local Contants

        'Local variables
        Dim SearchName As String       'holds the name being search
        Dim found As Integer           'holds how many times was found
        Dim counter1 As Integer = 0        'holds a value for counter1
Line1:
        'sets sentinel to true
        sentinel = "y"

        'stores the name that is been search for
        SearchName = InputBox("Enter the name that you wish to search for: ", "Enter a name!", "") 'prompt's for the user's guess

        While sentinel = "y" Or sentinel = "Y"
            For counter1 = 0 To 9

                'checks if the random num is equal to index
                If SearchName = names(counter1) Then

                    'Displays name was found in cell "#" 
                    MessageBox.Show(SearchName & " was found in cell " & counter1, "Thank you for your input!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'increase found by one
                    found += 1

                End If

            Next counter1

            'if name is not found
            If found <= 0 Then
                MessageBox.Show("We search the array for " & SearchName & " but we cound't find it!", "Thank you for your input!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            'asks the user if they want to repeat
            sentinel = InputBox("Do you want to continue[y or n]?: ", "Enter y or n!", "") 'prompt's for name

            If sentinel = "y" Or sentinel = "Y" Then

                're-initializes found 
                found = 0

                're-initilizes counter1
                counter1 = 0
                GoTo Line1

            End If
        End While
    End Sub
End Class
