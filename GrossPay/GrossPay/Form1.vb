Public Class Form1


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnGross_Click(sender As Object, e As EventArgs) Handles btnGross.Click
        Dim hours As Integer = CInt(txtHours.Text)
        Dim rate As Double = CDbl(txtPay.Text)
        Dim gross As Double = hours * rate
        lblResult.Text = "$" & gross
    End Sub
End Class
