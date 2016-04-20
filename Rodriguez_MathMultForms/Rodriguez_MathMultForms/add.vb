Public Class add

    
    Private Sub btnCMD_Click(sender As Object, e As EventArgs) Handles btnCMD.Click

        'local constnats

        'local variables
        Dim validNum1 As Integer
        Dim validNum2 As Integer
        Dim ans As Integer


        If IsNumeric(txtNum1.Text) And IsNumeric(txtNum2.Text) Then  'check for numeric input
            validNum1 = Val(txtNum1.Text) 'convert to integer
            validNum2 = Val(txtNum2.Text) 'convert to integer

            ans = validNum1 + validNum2

            txtResult.Text = ans
        Else

            'warning message to the user that the input that they entered is a letter not a number
            MessageBox.Show("Please enter a numeric value!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'clears everything
            txtResult.Text = ""
            txtNum1.Text = ""
            txtNum2.Text = ""


            'Set focus back to text box
            txtNum1.Focus()

        End If


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmMain.Show()
    End Sub
End Class