'Title:     Loop Average
'Author:    Miguel Rodriguez
'Date:      3/22/2016
'Course:    CSC 162
'Section:   001
'Description:   This program will simulate the flip of a coin 100 times. it will
'   record how many times the coin has landed in head and tails. It then displays 
'   how many times that coin landed in head and and how many times the coin landed 
'   in tails. The user can play multiple times if he whishes to.
'
'Initial Algorithm:
'   1.  initilize counter to zero
'   2.  for a counter is less than 100
'   3.  create a random number in range between 1 to 2
'   4.  if random number is equal to 1 increase head counter by one
'   5.  if random number is equal to 2 increase the tails counter by one
'   6.  allows the user to keep playing if he wishes to
'   7.  provides the option to exit the program
'
'Data Requirements:
'   Input:
'       
'   Output:
'       Calculates how many heads and tails 
'       Displays how manay heads and tails to the user
'   Additional:
'       None
'
'Formulas:
'

Public Class frmFlipCoin


    Private Sub btnFlip_Click(sender As Object, e As EventArgs) Handles btnFlip.Click
        'Refined Algorithm
        ' Initialize global variables and contants
        ' Initialize local constants and variables
        '   FOR loopCounter is less than 100
        '       create a random number in range of 1 to 2
        '       IF random number is 1
        '          increase head counter by one
        '       ELSE
        '           increase tail counter by one
        '       END IF
        '     increase loop counter by one
        '  END FOR
        'Displays the head counter and tail counter
        ' Allows the user to exit the program by pressing a button
        ' Allows the user to repeat the program and initilizes the game
        '

        'Local constants


        'Local variables
        Dim headCounter As Integer
        Dim tailCounter As Integer
        Dim RanNum As Integer
        Dim loopCounter As Integer
        Dim counter As Integer

        For loopCounter = 1 To 100 'runs the loop from 1 to 100

            RanNum = Int((2 - 1 + 1) * Rnd()) + 1 'generates a random number from 1 to 2 and stores it into RanNum

            If RanNum = 1 Then 'if random number equals to 1 is heads
                headCounter += 1 'increase heads by one
            Else
                tailCounter += 1 'if random number is 2 increase tail by 1
            End If

        Next loopCounter

        'adds the total of heads and tails to a list box
        List1.Items.Add("Heads " & headCounter & " Tails " & tailCounter & vbTab)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'closes the application
        End
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        List1.Items.Clear() ' Remove all list items

    End Sub
End Class
