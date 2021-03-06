﻿
'Title:     Letter Grade Calculator
'Author:    Miguel Rodriguez
'Date:      3/08/2016
'Course:    CSC 162
'Section:   001
'Description:   This program calculates the letter grade
'               based on a number grade that the user enters
'               using a if/else/elseif statements.
'
'Initial Algorithm:
'   1.  Get course name enter by user
'   2.  Get course grade enter by user
'   3.  use if/else/elseif to compute the letter grade
'   4.  Display the letter grades accordingly
'   5.  Provide option to exit program
'   6.  provide option to clear screen
'   7.  uses the accelerator shorcuts
'
'Data Requirements:
'   Input:
'       Enter the course name
'       Enter the course grade
'   Output:
'       Calculates letter grade based on the number grade
'       Displays letter grade accordingly
'   Additional:
'       None
'
'Formulas:
'
Public Class frmLetterGrade

    'Global Variables
    Dim courseName As String     'holds a course name
    Dim numberGrade As Integer   'holds a number grade

    Private Sub btnCmd_Click(sender As Object, e As EventArgs) Handles btnCmd.Click
        'Refined Algorithm
        ' IF value numberGrade is a number THEN
        '   Get value courseName from the text box
        '   Get value numberGrade from the text box
        '       IF numberGrade > 90
        '           Display the courseName and the letterGrade A
        '       ELSE IF numberGrade > 80
        '           Display the courseName and the letterGrade B
        '       ELSE IF numberGrade > 70
        '           Display the courseName and the letterGrade C
        '       Else
        '           Display the courseName and the letterGrade F
        '       END IF
        ' ELSE 
        '   Display value numberGrade is not an integer
        ' END IF
        ' Allows the user to exit the program by pressing a button
        ' Allows the user to clear the screen by pressing a button
        ' Uses the Accelerator(shortcut keys)

        Static displayOut As String  'holds the data to be display
        courseName = txtCourse.Text  'sets textCourse equals to courseName

        If IsNumeric(txtGrade.Text) Then       'returns true or false
            numberGrade = Val(txtGrade.Text)   'stores a numeric value in score

            'assings the proper lettergrade based on the user's input
            If numberGrade >= 90 Then
                displayOut = courseName & " A" & ControlChars.NewLine
                txtDisplay.Text = displayOut
            ElseIf numberGrade >= 80 Then
                displayOut = courseName & " B" & ControlChars.NewLine
                txtDisplay.Text += displayOut
            ElseIf numberGrade >= 70 Then
                displayOut = courseName & " C" & ControlChars.NewLine
                txtDisplay.Text += displayOut
            ElseIf numberGrade >= 60 Then
                displayOut = courseName & " D" & ControlChars.NewLine
                txtDisplay.Text += displayOut
            Else
                displayOut = courseName & " F"
                txtDisplay.Text += displayOut
            End If
        Else
            'Displays a Message to the user asking them to enter a valid input
            MessageBox.Show("You did not enter a valid Grade.", "Invalid Grade", MessageBoxButtons.OK)
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'closes the application
        End
    End Sub

    Private Sub btnCmdClear_Click(sender As Object, e As EventArgs) Handles btnCmdClear.Click
        'This button clears out all text boxes
        txtCourse.Text = ""

        'Re-initialize grade to zero
        txtGrade.Text = 0

        'Set focus back to text box
        txtCourse.Focus()
    End Sub
End Class
