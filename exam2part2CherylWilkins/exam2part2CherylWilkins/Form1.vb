Public Class Form1
    Dim color() As String = {"blue", "red", "purple"}
    Dim vote() As Integer = {0, 0, 0}
    Dim win As Integer = 0
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
                win = i
            End If
        Next
    End Sub

    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click
        lstresult.Items.Clear()
        lstresult.Items.Add("The superior color is " & color(win) & "!")
        For x = 0 To 2 Step 1
            lstresult.Items.Add(color(x) & ": " & vote(x))
        Next
    End Sub
End Class
