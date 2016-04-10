'Title:     Guessing Game
'Author:    Miguel Rodriguez
'Date:      4/03/2016
'Course:    CSC 162
'Section:   001
'Description:   This program plays a guessing game with the 
'   user. It generates a random number between 1 to 100 and asks
'   the user to guess it. If the user is unsucessful to guess the
'   random number it instructs the user to guess higher or lower 
'   deoending on the user's guess.
'
'Initial Algorithm:
'   1.  Get  the number from the user (check for errors)
'   2.  Generate a random number from 1 to 100
'   3.  compare the two numbers
'   4.  if numbers are the same displays congratulations
'   5.  elsr if the numbers are not the same instruct the user whether they are high or low
'   6.  provide option to quit the program

'Data Requirements:
'   Input:
'       Enter a number
'   Output:
'       Displays if the guess is correct, too high or too low
'   Additional:
'       None
'
'Formulas:

Public Class frmGuessGame
  
    Private Sub btnCMD_Click(sender As Object, e As EventArgs) Handles btnCMD.Click
        'Refined Algorithm
        ' Please enter a number
        ' initialize sentinel to "y"
        ' WHILE sentinel = "y"
        '   Generate a random number between 1 and 100
        '   FOR run ten times
        '       check whether the number is numeric
        '       check whether the number is in range
        '        add the counter to a label
        '       IF number = random number
        '          Display a congratulating message
        '          Add label to a list
        '          change the color of the label to yellow
        '       ELSE IF number is less than random number
        '           Display "your guess is too low"
        '       ELSE IF number greater than random number
        '           Display "your guess is too high"
        '       END IF
        '    END FOR
        '    disable the main button
        '    Ask the user if they wish to continue
        '    reset everything
        ' Allows the user to exit the program by pressing a button
       

        'Local constants

        'Local variables
        Dim guess As String                'holds the user's guess
        Dim validGuess As Integer          'holds the valid Guess
        Dim RanNum As Integer              'holds the random number
        Dim counter As Integer             'holds the counter
        Dim sentinel As String = "y"       'holds a sentinel value for the while loop

        'makes sure that the number is random
        Randomize()

        'creates repetition
        While sentinel = "y" Or sentinel = "Y"

            'enable the main button
            btnCMD.Enabled = True

            RanNum = Int((100 - 1 + 1) * Rnd()) + 1 'generates a random number from 1 to 100 and stores it into RanNum

            'runs ten times
            For counter = 1 To 10

                guess = InputBox("Please enter a number: ", "Guess A Number", 0) 'prompt's for the user's guess
                If IsNumeric(guess) Then  'check for numeric input
                    validGuess = Val(guess) 'convert to integer

                    If validGuess > 0 And validGuess <= 100 Then 'checks to see if the grade is in range

                        'keeps track of the guesses
                        lblCounter.Text = "Guess #: " & counter

                        'checks to see if the validGuess is equal to the random number
                        If validGuess = RanNum Then

                            'displays guess is correct
                            lblGuess.Text = "  [Guess is Correct.] "

                            'changed the background color of the label to yellow
                            lblGuess.BackColor = Color.Yellow

                            'Displays the guess is correct
                            List1.Items.Add(lblGuess.Text & validGuess & vbTab)

                            'checks to see if counter is less than 5
                            If counter < 5 Then

                                'displays a message to the user
                                MessageBox.Show("Either you know the secret or you got lucky!", "You Guessed The Correct Number!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                'sets the counter to 11 wich exits the for loop
                                counter = 11
                                'checks to see whther counter is equal to 5,6,7
                            ElseIf counter = 5 Or counter = 6 Or counter = 7 Then

                                'displays a message
                                MessageBox.Show("You're pretty good at this!", "You Guessed The Correct Number!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                'sets the counters equals to 11 wich exits for loop
                                counter = 11
                            Else

                                'dislplys a message
                                MessageBox.Show("You'll do better next time.", "You Guessed The Correct Number!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                'sets the counter equals to 11 wich exits the for loop
                                counter = 11
                            End If

                            'checks to see if the validGuess is less than random number
                        ElseIf validGuess < RanNum Then

                            'Displays the guess is too low
                            lblGuess.Text = "  [Guess is too low  (but within range).] "

                            'sets the label color to blue
                            lblGuess.BackColor = Color.Blue

                            'Displays the guess is correct
                            List1.Items.Add(lblGuess.Text & validGuess & vbTab)

                            'checks to see if validGuess is less than random number
                        ElseIf validGuess > RanNum Then

                            'Displays the guess is too high
                            lblGuess.Text = "  [Guess is too high (but within range).] "

                            'sets the color to red
                            lblGuess.BackColor = Color.Red

                            'Displays the guess is correct
                            List1.Items.Add(lblGuess.Text & validGuess & vbTab)

                        End If

                    Else
                        'warning message telling the user that their grade is not in range
                        MessageBox.Show("Please enter a number in range between 1 to 100", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                        'decrease counter by one
                        counter -= 1

                    End If

                    Else
                        'warning message to the user that the input that they entered is a letter not a number
                        MessageBox.Show("Please enter a numeric value!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    'decrease counter by one
                    counter -= 1

                    End If
            Next counter

            'disable the main button
            btnCMD.Enabled = False

            'displays a message
            MessageBox.Show("Sorry - You have taken too many guesses.", "You Guessed The Correct Number!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'asks the user if they wich to continue
            sentinel = InputBox("Do you wish to continue [y or n]?", "Please enter [y] for yes or [n] for no", " ") 'Do you wich to continue?

            're-nitializes counter
            counter = 0

            're-initializes the list box
            List1.Items.Clear()

        End While

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'closes the application
        End
    End Sub

   
End Class
