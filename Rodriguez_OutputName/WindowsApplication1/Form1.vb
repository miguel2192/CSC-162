Public Class Form1





    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        'variables
        Dim fName As String 'Stores user's first name
        Dim lName As String 'stores user's last name
        Dim Age As Integer  'stores user's the age
        Dim Message As String 'stores output for the user



        fName = txtFirst.Text

        lName = txtLast.Text

        Age = txtAge.Text

        Message = fName & " " & lName & " is " & Age & " years old."

        lblDisplay.Text = Message




    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        End
    End Sub
End Class
