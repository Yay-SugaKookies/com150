Public Class Form1

    Private Sub btnScore_Click(sender As Object, e As EventArgs) Handles btnScore.Click
        Dim score As Double = CDbl(txtScore.Text)
        If score >= 80 Then
            MessageBox.Show("YOU PASSED!!!")
        ElseIf score < 80 Then
            MessageBox.Show("YOU FAILED!!!")
        End If
    End Sub
End Class
