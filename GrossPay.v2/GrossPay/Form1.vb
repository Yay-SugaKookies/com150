Public Class Form1


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnGross_Click(sender As Object, e As EventArgs) Handles btnGross.Click
        Dim hours As Double = CInt(txtHours.Text)
        Dim rate As Double = CDbl(txtPay.Text)
        Dim gross As Double = hours * rate
        lblResult.Text = "$" & gross
        If gross > 400 Then
            txt400.Text = "Your pay is greater than $400."
        ElseIf gross = 400 Then
            txt400.Text = "Your pay is exactly $400."
        Else
            txt400.Text = "Your pay is less than $400"
        End If
    End Sub
End Class
