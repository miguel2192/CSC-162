'Title:     Tic Tac Toe
'Author:    Miguel Rodriguez
'Date:      4/20/2016
'Course:    CSC 162
'Section:   001
'Description:   This program will allow the user to play tic tac toe.
'   it allows two users to play against themselves. Users can win by
'   getting x's or o's in rows of 3, columns of 3 or 3 diagonal.
'   Once somebody wins or it's a tie, an option to restart the game is provided.
'
'Initial Algorithm:
'   1.  allows the user to select player
'   2.  create 9 buttons and click events for each
'   3.  if button is clicked disabled button
'   4.  displays x if user chose x or o if user chose o
'   5.  store seither x or 0 in 2d array depending on user's choice
'   6.  create a sub-prcedure to check for wins
'   7.  allows the user to restart game byt making visble a button
'   8.  provides a button to exit the program
'
'Data Requirements:
'   Input:
'       
'   Output:
'       displays which player won(if none displays it's a tie) 
'   Additional:
'       None
'Formulas:
'

Public Class frmTic
    'Refined Algorithm
    ' Initialize global variables and contants
    ' initialize a global 2d array to 2,2
    ' Initialize local constants and variables
    ' creates 9 buttons with click events for each
    ' creates 2 radiobuttons X and O
    ' check for each click event
    ' IF x radiobutton is check
    '   set button text to X
    '   disable the button
    '   store x in 2d array
    '   increments counter 
    '   calls subprocedure
    ' ELSE
    '   set button text to O
    '   disable the button
    '   store O in 2d array
    '   calls subprocedure
    ' END IF
    ' Repeats previous steps for each button
    ' creates a subprocedure with a ByRef counter
    ' each time the user clicks a button counter increase by one
    ' IF 
    ' Allows the user to exit the program by pressing a button
    ' Allows the user to repeat the program and initilizes the game
    ' checks to see if somebody won each time a button is click
    ' IF counter = 9
    '   Displays "Its's a tie!"
    ' END IF
    'global constants

    'global variables
    Dim tic(2, 2) As String  'creates an array to hold x and o
    Dim flag As Boolean
    Dim counter As Integer


    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click


        If rdnPlayer1.Checked = True Then


            btn1.Text = "X"        'sets the text to x
            btn1.Enabled = False   'disables the button
            tic(0, 0) = "X"        'stores x in array
            counter += 1           'increase counter by one
            win(counter)           'calls subprocedure

        Else

            btn1.Text = "O"        'sets the text to x
            btn1.Enabled = False   'disables the button
            tic(0, 0) = "O"        'stores x in array
            counter += 1           'increase counter by one
            win(counter)           'calls subprocedure

        End If

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If rdnPlayer1.Checked = True Then

            btn2.Text = "X"        'sets the text to x
            btn2.Enabled = False   'disables the button
            tic(0, 1) = "X"        'stores x in array
            counter += 1           'increase counter by one
            win(counter)           'calls subprocedure

        Else

            btn2.Text = "O"        'sets the text to x
            btn2.Enabled = False   'disables the button
            tic(0, 1) = "O"        'stores x in array
            counter += 1           'increase counter by one
            win(counter)           'calls subprocedure

        End If

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If rdnPlayer1.Checked = True Then

            btn3.Text = "X"         'sets the text to x
            btn3.Enabled = False    'disables the button
            tic(0, 2) = "X"         'stores x in array
            counter += 1            'increase counter by one
            win(counter)            'calls subprocedure


        Else

            btn3.Text = "O"         'sets the text to x
            btn3.Enabled = False    'disables the button
            tic(0, 2) = "O"         'stores x in array
            counter += 1            'increase counter by one
            win(counter)            'calls subprocedure


        End If

    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If rdnPlayer1.Checked = True Then

            btn4.Text = "X"          'sets the text to x
            btn4.Enabled = False     'disables the button
            tic(1, 0) = "X"          'stores x in array
            counter += 1             'increase counter by one
            win(counter)             'calls subprocedure

        Else

            btn4.Text = "O"          'sets the text to x
            btn4.Enabled = False     'disables the button
            tic(1, 0) = "O"          'stores x in array
            counter += 1             'increase counter by one
            win(counter)             'calls subprocedure

        End If

    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If rdnPlayer1.Checked = True Then

            btn5.Text = "X"          'sets the text to x
            btn5.Enabled = False     'disables the button
            tic(1, 1) = "X"           'stores x in array
            counter += 1              'increase counter by one
            win(counter)             'calls subprocedure

        Else

            btn5.Text = "O"          'sets the text to x
            btn5.Enabled = False     'disables the button
            tic(1, 1) = "O"           'stores x in array
            counter += 1              'increase counter by one
            win(counter)             'calls subprocedure

        End If

    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If rdnPlayer1.Checked = True Then

            btn6.Text = "X"          'sets the text to x
            btn6.Enabled = False     'disables the button
            tic(1, 2) = "X"          'stores x in array
            counter += 1            'increase counter by one
            win(counter)            'calls subprocedure

        Else

            btn6.Text = "O"          'sets the text to x
            btn6.Enabled = False     'disables the button
            tic(1, 2) = "O"          'stores x in array
            counter += 1            'increase counter by one
            win(counter)            'calls subprocedure

        End If

    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If rdnPlayer1.Checked = True Then

            btn7.Text = "X"         'sets the text to x
            btn7.Enabled = False    'disables the button
            tic(2, 0) = "X"         'stores x in array
            counter += 1            'increase counter by one
            win(counter)            'calls subprocedure

        Else

            btn7.Text = "O"         'sets the text to x
            btn7.Enabled = False    'disables the button
            tic(2, 0) = "O"         'stores x in array
            counter += 1            'increase counter by one
            win(counter)            'calls subprocedure

        End If

    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If rdnPlayer1.Checked = True Then

            btn8.Text = "X"       'sets the text to x
            btn8.Enabled = False  'disables the button
            tic(2, 1) = "X"       'stores x in array
            counter += 1          'increase counter by one
            win(counter)          'calls subprocedure

        Else

            btn8.Text = "O"        'sets the text to o
            btn8.Enabled = False   'disables the button
            tic(2, 1) = "O"        'stores x in array
            counter += 1           'increase counter by one
            win(counter)           'calls subprocedure

        End If

    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If rdnPlayer1.Checked = True Then

            btn9.Text = "X"          'sets the text to x
            btn9.Enabled = False    'disables the button
            tic(2, 2) = "X"         'stores x in array
            counter += 1            'increase counter by one
            win(counter)            'calls subprocedure

        Else

            btn9.Text = "O"         'sets the text to o
            btn9.Enabled = False    'disables the button
            tic(2, 2) = "O"         'stores x in array
            counter += 1            'increase counter by one
            win(counter)            'calls subprocedure

        End If

    End Sub


    Private Sub win(ByRef counter As Integer)
        
        'Local constants

        'local variables

        'holds counter values for different checks
        Dim col As Integer
        Dim row As Integer = 0

        Dim col2 As Integer = 0
        Dim row2 As Integer = 0

        Dim col3 As Integer = 0
        Dim row3 As Integer = 0

        Dim col4 As Integer = 0
        Dim row4 As Integer = 0

        Dim col5 As Integer = 0
        Dim row5 As Integer = 0

        Dim col6 As Integer = 0
        Dim row6 As Integer = 0


        For col = 0 To 2 'cycle through it's columns

            If tic(col, row) = "X" And tic(col, row + 1) = "X" And tic(col, row + 2) = "X" Then
                'player one won
                lblDisplay.Text = "Player X Won, Congratulations!"

                'disables all buttons
                btn1.Enabled = False
                btn2.Enabled = False
                btn3.Enabled = False
                btn4.Enabled = False
                btn5.Enabled = False
                btn6.Enabled = False
                btn7.Enabled = False
                btn8.Enabled = False
                btn9.Enabled = False

                'sets the clear button to visible
                btnClear.Visible = True

            End If
            If tic(col, row) = "O" And tic(col, row + 1) = "O" And tic(col, row + 2) = "O" Then
                'player 2 won
                lblDisplay.Text = "Player O Won, Congratulations!"

                'disables all buttons
                btn1.Enabled = False
                btn2.Enabled = False
                btn3.Enabled = False
                btn4.Enabled = False
                btn5.Enabled = False
                btn6.Enabled = False
                btn7.Enabled = False
                btn8.Enabled = False
                btn9.Enabled = False

                'sets the clear button to visible
                btnClear.Visible = True

            End If

            If counter = 9 Then
                lblDisplay.Text = "It's a tie!"
                btn1.Enabled = False
                btn2.Enabled = False
                btn3.Enabled = False
                btn4.Enabled = False
                btn5.Enabled = False
                btn6.Enabled = False
                btn7.Enabled = False
                btn8.Enabled = False
                btn9.Enabled = False

                'sets the clear button to visible
                btnClear.Visible = True
            End If

            If tic(col2, row2) = "X" And tic(col2 + 1, row2 + 1) = "X" And tic(col2 + 2, row2 + 2) = "X" Then
                'player one won
                lblDisplay.Text = "Player X Won, Congratulations!"

                'disables all buttons
                btn1.Enabled = False
                btn2.Enabled = False
                btn3.Enabled = False
                btn4.Enabled = False
                btn5.Enabled = False
                btn6.Enabled = False
                btn7.Enabled = False
                btn8.Enabled = False
                btn9.Enabled = False

                'sets the clear button to visible
                btnClear.Visible = True

            End If
            If tic(col2, row2) = "O" And tic(col2 + 1, row2 + 1) = "O" And tic(col2 + 2, row2 + 2) = "O" Then
                'player 2 won
                lblDisplay.Text = "Player O Won, Congratulations!"

                'disables all buttons
                btn1.Enabled = False
                btn2.Enabled = False
                btn3.Enabled = False
                btn4.Enabled = False
                btn5.Enabled = False
                btn6.Enabled = False
                btn7.Enabled = False
                btn8.Enabled = False
                btn9.Enabled = False

                'sets the clear button to visible
                btnClear.Visible = True

            End If

            If tic(col3, row3 + 2) = "X" And tic(col3 + 1, row3 + 1) = "X" And tic(col3 + 2, row3) = "X" Then
                'player one won
                lblDisplay.Text = "Player X Won, Congratulations!"

                'disables all buttons
                btn1.Enabled = False
                btn2.Enabled = False
                btn3.Enabled = False
                btn4.Enabled = False
                btn5.Enabled = False
                btn6.Enabled = False
                btn7.Enabled = False
                btn8.Enabled = False
                btn9.Enabled = False

                'sets the clear button to visible
                btnClear.Visible = True

            End If
            If tic(col3, row3 + 2) = "O" And tic(col3 + 1, row3 + 1) = "O" And tic(col3 + 2, row3) = "O" Then
                'player 2 won
                lblDisplay.Text = "Player O Won, Congratulations!"

                'disables all buttons
                btn1.Enabled = False
                btn2.Enabled = False
                btn3.Enabled = False
                btn4.Enabled = False
                btn5.Enabled = False
                btn6.Enabled = False
                btn7.Enabled = False
                btn8.Enabled = False
                btn9.Enabled = False

                'sets the clear button to visible
                btnClear.Visible = True

            End If
            If tic(col4, row4) = "X" And tic(col4 + 1, row4) = "X" And tic(col4 + 2, row4) = "X" Then
                'player one won
                lblDisplay.Text = "Player X Won, Congratulations!"

                'disables all buttons
                btn1.Enabled = False
                btn2.Enabled = False
                btn3.Enabled = False
                btn4.Enabled = False
                btn5.Enabled = False
                btn6.Enabled = False
                btn7.Enabled = False
                btn8.Enabled = False
                btn9.Enabled = False

                'sets the clear button to visible
                btnClear.Visible = True

            End If
            If tic(col4, row4) = "O" And tic(col4 + 1, row4) = "O" And tic(col4 + 2, row4) = "O" Then
                'player 2 won
                lblDisplay.Text = "Player O Won, Congratulations!"

                'disables all buttons
                btn1.Enabled = False
                btn2.Enabled = False
                btn3.Enabled = False
                btn4.Enabled = False
                btn5.Enabled = False
                btn6.Enabled = False
                btn7.Enabled = False
                btn8.Enabled = False
                btn9.Enabled = False

                'sets the clear button to visible
                btnClear.Visible = True

            End If

            If tic(col5, row4 + 1) = "X" And tic(col5 + 1, row5 + 1) = "X" And tic(col5 + 2, row5 + 1) = "X" Then
                'player one won
                lblDisplay.Text = "Player X Won, Congratulations!"

                'disables all buttons
                btn1.Enabled = False
                btn2.Enabled = False
                btn3.Enabled = False
                btn4.Enabled = False
                btn5.Enabled = False
                btn6.Enabled = False
                btn7.Enabled = False
                btn8.Enabled = False
                btn9.Enabled = False

                'sets the clear button to visible
                btnClear.Visible = True

            End If
            If tic(col5, row5 + 1) = "O" And tic(col5 + 1, row5 + 1) = "O" And tic(col5 + 2, row5 + 1) = "O" Then
                'player 2 won
                lblDisplay.Text = "Player O Won, Congratulations!"

                'disables all buttons
                btn1.Enabled = False
                btn2.Enabled = False
                btn3.Enabled = False
                btn4.Enabled = False
                btn5.Enabled = False
                btn6.Enabled = False
                btn7.Enabled = False
                btn8.Enabled = False
                btn9.Enabled = False

                'sets the clear button to visible
                btnClear.Visible = True

            End If
            If tic(col6, row6 + 2) = "X" And tic(col6 + 1, row6 + 2) = "X" And tic(col6 + 2, row6 + 2) = "X" Then
                'player one won
                lblDisplay.Text = "Player X Won, Congratulations!"

                'disables all buttons
                btn1.Enabled = False
                btn2.Enabled = False
                btn3.Enabled = False
                btn4.Enabled = False
                btn5.Enabled = False
                btn6.Enabled = False
                btn7.Enabled = False
                btn8.Enabled = False
                btn9.Enabled = False

                'sets the clear button to visible
                btnClear.Visible = True

            End If
            If tic(col6, row6 + 2) = "O" And tic(col6 + 1, row6 + 2) = "O" And tic(col6 + 2, row6 + 2) = "O" Then
                'player 2 won
                lblDisplay.Text = "Player O Won, Congratulations!" 'sets text 

                'disables all buttons
                btn1.Enabled = False
                btn2.Enabled = False
                btn3.Enabled = False
                btn4.Enabled = False
                btn5.Enabled = False
                btn6.Enabled = False
                btn7.Enabled = False
                btn8.Enabled = False
                btn9.Enabled = False

                'sets the clear button to visible
                btnClear.Visible = True

            End If

        Next col

    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close() 'closes the application
        End


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'local constants

        'local variables
        Dim row As Integer       'holds a counter's value
        Dim col As Integer       'holds a coutner's value


        're-initilizes everything to it's default state
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True
        counter = 0
        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""

        'sets the label text to empty
        lblDisplay.Text = ""

        're-initilizes 2d array
        For row = 0 To 2 'while on a row
            For col = 0 To 2 'cycle through it's columns
                tic(col, row) = ""
            Next col
        Next row

        'sets the reastart button to visisble
        btnClear.Visible = False

    End Sub


End Class
