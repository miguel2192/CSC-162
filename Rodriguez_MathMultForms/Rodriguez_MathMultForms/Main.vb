Public Class frmMain


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Hide()
        add.Show()
    End Sub

    Private Sub btnSubstract_Click(sender As Object, e As EventArgs) Handles btnSubstract.Click
        Me.Hide()
        substract.Show()
    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        Me.Hide()
        multiply.Show()
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Me.Hide()
        divide.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'closes the application
        End
    End Sub
End Class
