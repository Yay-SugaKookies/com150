Public Class Form1

    Private Sub btnLuck_Click(sender As Object, e As EventArgs) Handles btnLuck.Click
        Dim num1, num2, num3, num4, num5 As Integer
        num1 = Int(Rnd() * 10)
        num2 = Int(Rnd() * 10)
        num3 = Int(Rnd() * 10)
        num4 = Int(Rnd() * 10)
        num5 = Int(Rnd() * 10)
        txtLuck1.ForeColor = Color.Red
        txtLuck1.Text = num1
        txtLuck.Text = " " & num2 & " " & num3 & " " & num4 & " " & num5
    End Sub
End Class
