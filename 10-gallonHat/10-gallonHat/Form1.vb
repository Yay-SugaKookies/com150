Public Class Form1

  

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSol.Click
        Dim ans As Double = CDbl(txtAns.Text)
        If (ans >= 0.5) And (ans <= 1) Then
            txtSol.Text = "Good, "
        Else
            txtSol.Text = "No, "
        End If
        txtSol.Text &= "it holds about 3/4 gals."
    End Sub
End Class
