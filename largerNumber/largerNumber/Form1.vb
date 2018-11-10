Public Class Form1

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        Dim num1, num2, larger As Double
        num1 = CDbl(txtFirst.Text)
        num2 = CDbl(txtSecond.Text)
        If num1 > num2 Then
            larger = num1
        Else
            larger = num2
        End If
        txtResult.Text = "Larger number: " & larger
    End Sub
End Class
