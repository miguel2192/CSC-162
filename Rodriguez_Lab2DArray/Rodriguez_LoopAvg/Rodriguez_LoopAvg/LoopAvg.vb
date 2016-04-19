
'Title:     Loop Average
'Author:    Miguel Rodriguez
'Date:      3/22/2016
'Course:    CSC 162
'Section:   001
'Description:   This program calculates the running total
'   of as many different grades that the user enter using
'   a counter controlled while loop. After the program is done
'   the program displays the total average of all the grades.
'
'Initial Algorithm:
'   1.  Get number of the grades that the user wishes to enter
'   2.  run a while loop for as many times the number of grades
'   3.  Get the grades from the user and test whether they are numeric
'   4.  Compute the running total as the user enter the grades
'   5.  When loop is done compute the average
'   6.  provides the option to exit the program
'
'Data Requirements:
'   Input:
'       Enter the number of grades
'       Enter the grade
'   Output:
'       Calculates the running total as we go
'       calculates the average at the end
'       Displays the running total as the user enters the grades and the average at the end
'   Additional:
'       None
'
'Formulas:
'

Public Class frmLoopAvg

    Private Sub btnRunProgram_Click(sender As Object, e As EventArgs) Handles btnRunProgram.Click
        'Refined Algorithm
        ' Initialize global and local constants
        ' Initialize global and local variables
        ' Create a counter and initialize it to zero
        ' Get number of grades that the user whishes to enter
        ' store value in numGrade
        ' Hides the input textbox
        ' IF numGrade is numeric
        '    WHILE counter < numGrade
        '       prompt the user to enter a grade
        '       store gradeRec
        '       IF gradeRec is numeric
        '          IF gradeRec >=0 AND gradeRec <=100
        '             runningTotal + runningTotal + graderec
        '             Display the runningTotal
        '          ELSE
        '             Display Please enter a number in the range of 0 to 100
        '          END IF
        '        ELSE
        '           Display Please enter a numeric value
        '       END IF
        ' ELSE 
        '   Invalid input. Please enter a numeric value!
        ' END IF
        ' Allows the user to exit the program by pressing a button
        ' Tests for empty space input

        'Local Constants

        'Local Variables
        Dim counter As Integer
        Dim gradeRec As Double
        Dim validGrade As Integer
        Dim runningTotal As Integer
        Dim numGrade As Integer

        counter = 0 'iniitializes the counter equal to zero

        If IsNumeric(txtNumGrade.Text) Then    'returns true or false
            numGrade = Val(txtNumGrade.Text)   'stores a numeric value in score

            'Displays a Message to the user asking them to enter a number in the range from 0 to 100
            MessageBox.Show("Please enter a number in range of 0 to 100.", "Please follow this directions", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            While counter < numGrade ' test whether the counter is less than the number of grades
                txtNumGrade.Visible = False 'sets the textbox invisible
                gradeRec = InputBox("Enter the grade recieved: ", "Please enter a grade!", 0) 'prompt for a grade
                If IsNumeric(gradeRec) Then  'check for numeric input
                    validGrade = Val(gradeRec) 'convert to integer
                    If validGrade >= 0 And validGrade <= 100 Then 'checks to see if the grade is in range

                        runningTotal += validGrade 'adds all the grades

                        txtRunningTotal.Text = runningTotal 'outputs the running total as the user enters the numbers
                    Else
                        'warning message telling the user that their grade is not in range
                        MessageBox.Show("Please enter a number in range between 0 to 100", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning) 'tell user to enter number
                    End If
                Else
                    'warning message to the user that the input that they enter is a letter not a number
                    MessageBox.Show("Please enter a number not a letter", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error) 'tell user to enter number
                End If

                counter += 1 'increase counter by one each time
            End While
        Else
            'Displays a Message to the user asking them to enter a valid input
            MessageBox.Show("You did not enter a valid number.", "Enter a valid number!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        'Displays the total grade average
        txtAvg.Text = runningTotal / counter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close() 'closes the application
        End
    End Sub

End Class
