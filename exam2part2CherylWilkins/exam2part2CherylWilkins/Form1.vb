Public Class Form1
    Dim color() As String = {"blue", "red", "purple"}
    Dim vote() As Integer = {0, 0, 0}
    Dim win As Integer = -1
    Dim x, y, z As Integer
    Private Sub btnVote_Click(sender As Object, e As EventArgs) Handles btnVote.Click
        If rb1.Checked = True Then
            vote(0) += 1
        End If
        If rb2.Checked = True Then
            vote(1) += 1
        End If
        If rb3.Checked = True Then
            vote(2) += 1
        End If
        For i = 0 To 2 Step 1
            If win < vote(i) Then
                win = vote(i)
                x = i
            ElseIf win = vote(i) Then
                y = win
                z = i
            End If
        Next
    End Sub

    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click
        lstresult.Items.Clear()
        If vote(0) = vote(1) And vote(1) = vote(2) Then
            lstresult.Items.Add("All colors have the same vote. Try again!")
        ElseIf win = y Then
            lstresult.Items.Add("It's a tie!The best colors are " & color(x) & " and " & color(z) & "!")
        Else
            lstresult.Items.Add("The superior color is " & color(x) & "!")
        End If
        For z = 0 To 2 Step 1
            lstresult.Items.Add(color(z) & ": " & vote(z))
        Next
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        win = -1
        For i = 0 To 2
            vote(i) = 0
        Next
        lstresult.Items.Clear()
    End Sub
End Class
