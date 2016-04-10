
'Author: Miguel Rodriguez
Public Class frmArray
    'Global Constants
    Const MAX_SIZE As Integer = 10


    'Global Variables
    Dim numbers(MAX_SIZE) As Integer     'initialize a fixed array to 10

    Private Sub btnCMD_Click(sender As Object, e As EventArgs) Handles btnCMD.Click

        'Local contants

        'local variables
        Dim number As String           'holds the user's number
        Dim validNumber As Integer     'holds a valid number
        Dim counter As Integer         'holds the counter
        Dim RanNum As Integer          'holds the random number
        Dim counter2 As Integer        'holds a second counter
        Dim found As Integer           'holds how many times was found
        Dim sentinel As String = "y"   'holds a sentinel value


        'makes sure the number is random
        Randomize()

        While sentinel = "y" Or sentinel = "Y"

            'enables the main button
            btnCMD.Enabled = True

            'warning message telling the user that their grade is not in range
            MessageBox.Show("Please enter a number in range between 1 to 20", "Instructions!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            RanNum = Int((20 - 1 + 1) * Rnd()) + 1 'generates a random number from 1 to 20 and stores it into RanNum

            'rusn 10 times
            For counter = 0 To 9

                number = InputBox("Please enter a number: ", "Enter a number between 1 to 20", 0) 'prompt's for the user's guess
                If IsNumeric(number) Then  'check for numeric input
                    validNumber = Val(number) 'convert to integer

                    'checks for range
                    If number <= 20 And number >= 1 Then

                        If counter < 10 Then

                            'fills the array
                            numbers(counter) = validNumber
                            ' Else

                            'sets the counter to 11 wich exits the program
                            'counter = 10
                        End If

                    Else

                        'warning
                        MessageBox.Show("Please enter a number in range between 1 to 20", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                        'decrease counter
                        counter -= 1

                    End If

                Else
                    'warning message to the user that the input that they entered is a letter not a number
                    MessageBox.Show("Please enter a numeric value!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    'decrease counter by one
                    counter -= 1
                End If
            Next counter

            For counter2 = 0 To 9

                'checks if the random num is equal to index
                If RanNum = numbers(counter2) Then

                    'increase counter
                    found += 1

                End If
            Next counter2


            If found > 0 Then

                'displays random number
                lblDisplay2.Text = "This random number was searched: " & RanNum

                'displays was found
                lblDisplay.Text = "The number was found " & found & " time(s)!"
            Else

                'displays random num
                lblDisplay2.Text = "This random number was searched: " & RanNum

                'Displays was not found
                lblDisplay.Text = "The number did not occur at all in your list"

            End If


            'runs 10 times
            For index = 0 To 9

                'lists the array elements using a list box
                List1.Items.Add("Index " & index & " -----" & numbers(index))

            Next index

            'disables the main button
            btnCMD.Enabled = False

            'asks the user if they wich to continue
            sentinel = InputBox("Do you wish to continue [y or n]?", "Please enter [y] for yes or [n] for no", " ") 'Do you wich to continue?

            If sentinel = "y" Then
                're-nitializes counter
                counter = 0

                're-initializes the list box
                List1.Items.Clear()

                're-initializes found
                found = 0

            End If
           

        End While

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close() 'closes the application
        End
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSortAsc.Click
        Dim temp As Integer
        Dim index As Integer
        Dim swap As Boolean = True 'set swap to true to enter loop 

        While swap = True 'continue looping if a swap has occurred
            swap = False 'set swap to false to prep for this run through

            'for loop makes one pass through the array
            For index = 0 To UBound(numbers) - 1
                'compare element in current position to the one to the right
                If numbers(index) > numbers(index + 1) Then
                    swap = True 'if current position is greater a swap must occur
                    temp = numbers(index) 'store element from current position in temp 
                    numbers(index) = numbers(index + 1) 'move element from position on right to current position
                    numbers(index + 1) = temp 'move element from current position to position on right
                End If
            Next index
        End While

        'clear the listbox
        List1.Items.Clear()

        'display the list
        For index = 1 To UBound(numbers)
            List1.Items.Add(numbers(index))
        Next index

    End Sub

    Private Sub btnSortDesc_Click(sender As Object, e As EventArgs) Handles btnSortDesc.Click
        Dim temp As Integer
        Dim index As Integer
        Dim swap As Boolean = True 'set swap to true to enter loop 

        While swap = True 'continue looping if a swap has occurred
            swap = False 'set swap to false to prep for this run through

            'for loop makes one pass through the array
            For index = 0 To UBound(numbers) - 1
                'compare element in current position to the one to the right
                If numbers(index) < numbers(index + 1) Then
                    swap = True 'if current position is less than position on right a swap must occur
                    temp = numbers(index) 'store element from current position in temp 
                    numbers(index) = numbers(index + 1) 'move element from position on right to current position
                    numbers(index + 1) = temp 'move element from current position to position on right
                End If
            Next index
        End While

        'clear the listbox
        List1.Items.Clear()

        'display the list
        For index = 0 To UBound(numbers) - 1
            List1.Items.Add(numbers(index))
        Next index
    End Sub
End Class
