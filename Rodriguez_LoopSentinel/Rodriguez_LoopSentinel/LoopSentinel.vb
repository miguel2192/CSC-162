
'Title:     Loop Sentinel
'Author:    Miguel Rodriguez
'Date:      3/27/2016
'Course:    CSC 162
'Section:   001
'Description:   This program calutes the overal end grades
'   marking period. It makes use of a sentinel and a while loop 
'   to run for as many times as the user wishes to.
'
'Initial Algorithm:
'   1.  initilize a sentinel to Y
'   2.  while the user enters Y keeps the program running
'   3.  Get the grades from the user and test whether they are numeric
'   4.  Compute the marking period grades for each student
'   5.  Display marking period grades fro each student
'   6.  Computes the overall marking period grades for entire class
'   7.  keeps track of how many students were processed by the professor
'   8.  Displays number of students and overall marking period grades for entire class
'   9.  Provides an exit button to quit the program
'
'Data Requirements:
'   Input:
'       Enter the student's full name
'       Enter the average quiz grade
'       Enter the average home work grade
'       Enter the average final grade
'   Output:
'       Displays the overall quiz grade
'       Displays the overall home work grade
'       Displays the overall final grade
'       Displays the marking period grades for student
'       Displays how many students were processed
'       Displays the overall marking period gradess for entire class
'   Additional:
'       None
'
'Formulas:
'       overall quiz = average * .3
'       overall homework = average * .2
'       overall final grade = average * .5


Public Class LoopSentinel

    'Global Constants

    'Gloabal Variables


    Private Sub btnRunProgram_Click(sender As Object, e As EventArgs) Handles btnRunProgram.Click
        'Refined Algorithm
        ' Initialize global and local constants
        ' Initialize global and local variables
        ' Create a counter and initialize it to zero
        ' provide the user with information about the program
        ' WHILE sentinel = y or sentinel = Y
        '    prompt for student's full name
        '    prompt for the avg quiz grade
        '    test whether input is numeric
        '    prompt for the avg homwwork grade
        '    test whether input is numeric
        '    prompt for the avg final grade
        '    test whether input is numeric
        '    overall quiz = average * .3
        '    overall homework = average * .2
        '    overall final grade = average * .5
        '    markign period grade = overall quiz + overall homwork + overall final grade
        '    Displays the computed information above
        '    increase counter by one each time
        '    total for entire class +=  marking period grades
        '    Dsiplay " do you want to continue <y or n>?
        ' End WHILE
        ' Display the number of students using the counter
        ' Display the total for entire class

        ' Allows the user to exit the program by pressing a button
        ' Tests for empty space input

        'Local Constants


        'Local Variables
        Dim counter As Integer           'holds the counter for students
        Dim quizGrade As String          'holds the quiz grade
        Dim homeGrade As String          'holds the homw work grade
        Dim finalGrade As String         'holds the final grade
        Dim sName As String              'holds the studen't name
        Dim validQuiz As Integer         'holds a valid quiz grade
        Dim validHome As Integer         'holds a valid home work grade
        Dim validFinal As Integer        'holds a valid final grade
        Dim oveQuiz As Double            'holds the overal quiz grade
        Dim oveHome As Double            'holds the overal home work grade
        Dim oveFinal As Double           'holds the overal final grade
        Dim sentinel As String = "y"     'holds the setinel that keeps the program running
        Dim classGrade As Double         'holds the overal class grade
        Dim AverageClassGrade As Double  'holds the average class grade


        counter = 0 'iniitializes the counter equal to zero

        'Displays a Message to the user asking them to enter a number in the range from 0 to 100
        MessageBox.Show("Please enter a name and the average of each number!", "Please follow this directions", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        'test whether the user has enter's y if not it closes the program
        While sentinel = "y" Or sentinel = "Y"

            btnRunProgram.Visible = False 'sets the compute button invisible

            sName = InputBox("Enter the student's full name: ", "Please enter a Name", "") 'prompt for student's name
Line1:
            quizGrade = InputBox("Please enter the average quiz grade: ", "Average Quiz Grade", 0) 'prompt's for the quiz grade
            If IsNumeric(quizGrade) Then  'check for numeric input
                validQuiz = Val(quizGrade) 'convert to integer

                'calculates the overal quiz grade
                oveQuiz = validQuiz * 0.3

            Else
                'warning message to the user that the input that they enter is a letter not a number
                MessageBox.Show("Please enter a number not a letter", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error) 'tell user to enter number
                GoTo Line1 'jumps to line1

            End If

Line2:
            homeGrade = InputBox("Please enter the average homework Grade: ", "Average Homework Grade", 0) 'prompt for the homw work grade
            If IsNumeric(homeGrade) Then  'check for numeric input
                validHome = Val(homeGrade) 'convert to integer

                'calculate the overal homework grade
                oveHome = validHome * 0.2

            Else
                'warning message to the user that the input that they enter is a letter not a number
                MessageBox.Show("Please enter a number not a letter", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error) 'tell user to enter number
                GoTo Line2 'jumps to line2

            End If

LastLine:
            finalGrade = InputBox("Please enter the average final grade: ", "Average Final Grade", 0) 'prompt for the final grade
            If IsNumeric(finalGrade) Then  'check for numeric input
                validFinal = Val(finalGrade) 'convert to integer

                'calculates the overal final grade
                oveFinal = validFinal * 0.5

            Else

                'warning message to the user that the input that they enter is a letter not a number
                MessageBox.Show("Please enter a number not a letter", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error) 'tell user to enter number
                GoTo LastLine 'jumps to lastline

            End If

            'calculates the overal grade
            finalGrade = oveQuiz + oveHome + oveFinal

            'displays the student name, overal home grade,
            MessageBox.Show("Overall Quiz:                " & oveQuiz & ControlChars.NewLine & "Overall Homework:    " & oveHome & ControlChars.NewLine & "Overall Final:                " &
                            oveFinal & ControlChars.NewLine & ControlChars.NewLine & "Marking Period Grade:  " & finalGrade, sName, MessageBoxButtons.OK, MessageBoxIcon.Information)

            'prompts the user if they want to cotinue
            sentinel = InputBox("Do you want to continue <y or n>?:  ", "Want to process more students!?", "") 'prompt for a grade

            counter += 1 'increase counter by one each time

            'holds the overall making period grades fro entire class
            classGrade += finalGrade
        End While
        AverageClassGrade = classGrade / counter


        'outputs the student's processed and the overall marking period grades for the entire class
        MessageBox.Show("Students Processed: " & counter & ControlChars.NewLine & "Overal Marking Period Grade: " & AverageClassGrade, "Average Marking Period Grades For The Class", MessageBoxButtons.OK, MessageBoxIcon.Information) 'tell user to enter number

        btnRunProgram.Visible = True 'sets the button to visible

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close() 'closes the application
        End
    End Sub

End Class
