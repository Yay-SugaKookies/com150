Public Class Form1


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim num1 As Double = CDbl(txtNum1.Text)
        Dim num2 As Double = CDbl(txtNum2.Text)
        Dim ans As Double = num1 + num2
        txtAdd.Text = ans
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        Dim num1 As Double = CDbl(txtNum1.Text)
        Dim num2 As Double = CDbl(txtNum2.Text)
        Dim ans As Double = num1 - num2
        txtMinus.Text = ans
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Dim num1 As Double = CDbl(txtNum1.Text)
        Dim num2 As Double = CDbl(txtNum2.Text)
        Dim ans As Double = num1 / num2
        txtDivide.Text = ans
    End Sub

    Private Sub BtnMultiply_Click(sender As Object, e As EventArgs) Handles BtnMultiply.Click
        Dim num1 As Double = CDbl(txtNum1.Text)
        Dim num2 As Double = CDbl(txtNum2.Text)
        Dim ans As Double = num1 * num2
        txtMultiply.Text = ans
    End Sub

    Private Sub btnExp_Click(sender As Object, e As EventArgs) Handles btnExp.Click
        Dim num1 As Double = CDbl(txtNum1.Text)
        Dim num2 As Double = CDbl(txtNum2.Text)
        Dim ans As Double = num1 ^ num2
        txtExp.Text = ans
    End Sub

    Private Sub txtExp_TextChanged(sender As Object, e As EventArgs) Handles txtExp.TextChanged

    End Sub

    Private Sub txtAdd_TextChanged(sender As Object, e As EventArgs) Handles txtAdd.TextChanged

    End Sub

    Private Sub txtMultiply_TextChanged(sender As Object, e As EventArgs) Handles txtMultiply.TextChanged

    End Sub

    Private Sub txtDivide_TextChanged(sender As Object, e As EventArgs) Handles txtDivide.TextChanged

    End Sub

    Private Sub txtMinus_TextChanged(sender As Object, e As EventArgs) Handles txtMinus.TextChanged

    End Sub
End Class
