Public Class Form1
    Private Sub btnFindArea_Click(sender As Object, e As EventArgs) Handles btnFindArea.Click
        Dim radius As Double = CDbl(txtRadius.Text)
        Const pi As Double = 3.14
        Dim area As Double = pi * radius ^ 2
        txtArea.Text = ("The area of a circle is " & area & ".")
    End Sub
End Class
