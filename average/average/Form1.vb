Public Class Form1

    Private Sub btnAvg_Click(sender As Object, e As EventArgs) Handles btnAvg.Click
        Dim num1 As Double = CDbl(txtNum1.Text)
        Dim num2 As Double = CDbl(txtNum2.Text)
        Dim avg As Double = (num1 + num2) / 2
        txtAvg.Text = ("The average of " & num1 & " and " & num2 & " is " & avg & ".")
    End Sub
End Class
