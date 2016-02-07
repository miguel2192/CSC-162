Public Class frmPrint_Message


    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click


        Dim firstName As String 'Stores user's first name
        Dim lastName As String  'Stores user's last name
        Dim welcome As String   'Stores the welcome message
        Dim Message1 As String  'stores the fullname

        'sets a string to the variable welcome
        welcome = "Welcome to Visual Basic"

        firstName = txtFname.Text

        lastName = txtlName.Text

        'adds the firstname and the lastname
        Message1 = firstName & " " & lastName

        'displays the welcome message, skips a line and displays the fullname
        lblDisplay.Text = welcome & vbCrLf & Message1


    End Sub
    'closes the aplication as soon as the exit button is press
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        End
    End Sub
End Class
