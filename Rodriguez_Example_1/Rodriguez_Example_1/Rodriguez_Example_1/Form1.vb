Public Class frmExample_1
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '' Author: Miguel A Rodriguez
    '' class: CSC 162
    '' Description: This is a simple visual basic program  that creates three buttons 
    ''     Each one of the buttons is assigned a color. When the user
    ''     clicks on the button there is some text that appears in the screen
    ''     based on the color that they chosed.
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub btnRED_Click(sender As Object, e As EventArgs) Handles btnRED.Click
        Me.BackColor = Color.Red
        lblDisplay.Text = "This is the color red"
    End Sub

    Private Sub btnGREEN_Click(sender As Object, e As EventArgs) Handles btnGREEN.Click
        Me.BackColor = Color.Green
        lblDisplay.Text = "This is the color Green"
    End Sub

    Private Sub btnBLUE_Click(sender As Object, e As EventArgs) Handles btnBLUE.Click
        Me.BackColor = Color.Blue
        lblDisplay.Text = "This is the color Blue"
    End Sub
End Class
