Public Class Form1

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim base As Integer = CInt(txtBase.Text)
        Dim height As Integer = CInt(txtHeight.Text)
        Dim area As Integer
        area = base * height * 0.5
        txtArea.Text = ("The area of a " & base & " by " & height & "  triangle is " & area & ".")
    End Sub

End Class
