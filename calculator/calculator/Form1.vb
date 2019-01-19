Public Class Form1
    Dim n1, n2 As Double
    Dim result As Double = 0
    Dim op As String = ""
    Dim mem As Double = 0
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If (txtShow.Text = op) Then
            txtShow.Text = ""
            txtShow.Text = Val(txtShow.Text)
        End If
        If txtShow.Text = 0 Then
            txtShow.Text = 0
        Else
            txtShow.Text &= 0
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If (txtShow.Text = op) Then
            txtShow.Text = ""
            txtShow.Text = Val(txtShow.Text)
        End If
        If txtShow.Text = 0 Then
            txtShow.Text = 1
        Else
            txtShow.Text &= 1
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If (txtShow.Text = op) Then
            txtShow.Text = ""
            txtShow.Text = Val(txtShow.Text)
        End If
        If txtShow.Text = 0 Then
            txtShow.Text = 2
        Else
            txtShow.Text &= 2
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If (txtShow.Text = op) Then
            txtShow.Text = ""
            txtShow.Text = Val(txtShow.Text)
        End If
        If txtShow.Text = 0 Then
            txtShow.Text = 3
        Else
            txtShow.Text &= 3
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If (txtShow.Text = op) Then
            txtShow.Text = ""
            txtShow.Text = Val(txtShow.Text)
        End If
        If txtShow.Text = 0 Then
            txtShow.Text = 4
        Else
            txtShow.Text &= 4
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If (txtShow.Text = op) Then
            txtShow.Text = ""
            txtShow.Text = Val(txtShow.Text)
        End If
        If txtShow.Text = 0 Then
            txtShow.Text = 5
        Else
            txtShow.Text &= 5
        End If
    End Sub

    Private Sub bnt6_Click(sender As Object, e As EventArgs) Handles bnt6.Click
        If (txtShow.Text = op) Then
            txtShow.Text = ""
            txtShow.Text = Val(txtShow.Text)
        End If
        If txtShow.Text = 0 Then
            txtShow.Text = 6
        Else
            txtShow.Text &= 6
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If (txtShow.Text = op) Then
            txtShow.Text = ""
            txtShow.Text = Val(txtShow.Text)
        End If
        If txtShow.Text = 0 Then
            txtShow.Text = 7
        Else
            txtShow.Text &= 7
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If (txtShow.Text = op) Then
            txtShow.Text = ""
            txtShow.Text = Val(txtShow.Text)
        End If
        If txtShow.Text = 0 Then
            txtShow.Text = 8
        Else
            txtShow.Text &= 8
        End If
    End Sub

    Private Sub bnt9_Click(sender As Object, e As EventArgs) Handles bnt9.Click
        If (txtShow.Text = op) Then
            txtShow.Text = ""
            txtShow.Text = Val(txtShow.Text)
        End If
        If txtShow.Text = 0 Then
            txtShow.Text = 9
        Else
            txtShow.Text &= 9
        End If
    End Sub

    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
        txtShow.Clear()
        txtShow.Text = 0
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtShow.Clear()
        txtShow.Text = 0
    End Sub

    Private Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click
        txtShow.Text = -1 * txtShow.Text
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        btnDivide.Select()
        If Not IsNumeric(txtShow.Text) Then
            MsgBox("Please enter numbers only", vbInformation)
        End If
        n1 = Val(txtShow.Text)
        op = "/"
        txtShow.Text = op
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        btnMultiply.Select()
        If Not IsNumeric(txtShow.Text) Then
            MsgBox("Please enter numbers only", vbInformation)
        End If
        n1 = Val(txtShow.Text)
        op = "*"
        txtShow.Text = op
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        btnSubtract.Select()
        If Not IsNumeric(txtShow.Text) Then
            MsgBox("Please enter numbers only", vbInformation)
        End If
        n1 = Val(txtShow.Text)
        op = "-"
        txtShow.Text = op
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnAdd.Select()
        If Not IsNumeric(txtShow.Text) Then
            MsgBox("Please enter numbers only", vbInformation)
        End If
        n1 = Val(txtShow.Text)
        op = "+"
        txtShow.Text = op
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If Not IsNumeric(txtShow.Text) Then
            MsgBox("Please enter numbers only", vbInformation)
        End If
        n2 = Val(txtShow.Text)
        If op = "+" Then
            result = n1 + n2
        End If
        If op = "-" Then
            result = n1 - n2
        End If
        If op = "/" Then
            result = n1 / n2
        End If
        If op = "*" Then
            result = n1 * n2
        End If
        txtShow.Text = CStr(result)
    End Sub

    Private Sub btnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        txtShow.Text = txtShow.Text.Substring(0, txtShow.Text.Length - 1)
        If txtShow.Text.Length = 0 Then
            txtShow.Text = 0
        End If
    End Sub

    Private Sub btnSqrt_Click(sender As Object, e As EventArgs) Handles btnSqrt.Click
        n1 = Val(txtShow.Text)
        result = n1 ^ (0.5)
        txtShow.Text = result
    End Sub
End Class
