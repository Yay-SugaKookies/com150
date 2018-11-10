Public Class Form1

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim side As Integer
        side = CInt(txtSide.Text)
        Dim area As Integer = side ^ 2
        txtArea.Text = ("The area square with a length of " & side & " is " & area & ".")
    End Sub

End Class
