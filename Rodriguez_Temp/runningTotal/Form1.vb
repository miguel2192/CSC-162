Option Explicit On

'Title:     Fah2Celcius
'Author:    Miguel Rodriguez
'Date:      2/16/2016
'Course:    CSC 162
'Section:   001
'Description:   This program demonstrates how to convert a 
'   fahrenheit temperature to Celcius
'
'Initial Algorithm:
'   1.  Get fahrenheit temperature
'   2.  check to see if the input is valid
'   3.  Convert from fahrenheit to Celcius
'   4.  Diplays the Celcius temperature
'
'Data Requirements:
'   Input:
'       Fahrenheit temperature
'   Output:
'       Celcius converted temperature
'   Additional:
'       None
'
'Formulas:
'   celciusTemp = 5 / 9 * (tempEntered - 32)
'
'Refined Algorithm:
'   1.  Get fahrenheit temperature
'   2.  check for valid input(numeric)
'           celciusTemp = 5 / 9 * (tempEntered - 32)
'   3.  Display the Celcius temperature
'   4.  provide the user with option to clear the screen
'   5.  provides the option of quitting the program

Public Class frmTempConverter
    Inherits System.Windows.Forms.Form

    'Global Variable Section
    Dim celciusTemp As Double 'Running Total

    Dim count As Integer 'counts everytime the user enters a number


    Private Sub cmdAdd_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdConvert.Click
        'This command button adds the number entered to the running total

        'Declare local variables
        Dim tempEntered As Integer 'Number entered by user

        'Get number entered into text box and put into variable
        tempEntered = Val(txtInputTemp.Text)

        'Calculate running total
        celciusTemp = 5 / 9 * (tempEntered - 32)


        'Place new total into label
        txtDisplayTemp.Text = celciusTemp

        'Clear out text box for next number
        txtInputTemp.Text = ""

        'Return cursor to text box for next number
        txtInputTemp.Focus()


    End Sub

    Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
        'This button clears out all text boxes
        txtInputTemp.Text = ""

        'Re-initialize celcius temperature
        txtDisplayTemp.Text = 0

        'Set focus back to text box
        txtInputTemp.Focus()

    End Sub

    Private Sub cmdEnd_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEnd.Click
        'This command button ends the program
        Me.Close() 'Remove active window
        End 'End program
    End Sub

    Private Sub frmRunningTotal_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'Initialize Text Boxes, labels, and variables to zero when form is loaded
        txtInputTemp.Text = ""
        txtDisplayTemp.Text = 0
        lblInfo.Text = "Converts Fahrenheit to Celcius"
    End Sub

End Class
