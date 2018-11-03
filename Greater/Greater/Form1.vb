Public Class Form1

    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        Dim num1 As Double = CDbl(txtnum1.Text)
        Dim num2 As Double = CDbl(txtNum2.Text)
        If num1 > num2 Then
            MessageBox.Show(num1 & " is greater than " & num2 & ".")
        ElseIf num2 > num1 Then
            MessageBox.Show(num2 & " is greater than " & num1 & ".")
        ElseIf num2 = num1 Then
            MessageBox.Show("These numbers are equal.")
        End If
    End Sub
End Class
