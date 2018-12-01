Public Class Form1


    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        lstWhyNot.Items.Clear()
        Dim num As Integer
        If rdFour.Checked = True Then
            num = 4
        ElseIf rdFive.Checked = True Then
            num = 5
        ElseIf rdSix.Checked = True Then
            num = 6
        End If
        If RdTimes.Checked = True Then
            For i As Integer = 1 To 1000 Step 1
                lstWhyNot.Items.Add(num & " + " & i & " = " & i + num)
            Next
        ElseIf rdPlus.Checked = True Then
            For i As Integer = 1 To 1000 Step 1
                lstWhyNot.Items.Add(num & " x " & i & " = " & i * num)
            Next
        End If

    End Sub
End Class
