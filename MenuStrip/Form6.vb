Public Class Form6
    Dim collectScore, midtermExamScores, finalExamScores As Double
    Dim grade As Char
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        collectScore = Val(TextBox2.Text)
        midtermExamScores = Val(TextBox3.Text)
        finalExamScores = Val(TextBox4.Text)
        Label8.Text = CStr(Math.Round(collectScore + midtermExamScores + finalExamScores, 4))

        If collectScore + midtermExamScores + finalExamScores >= 80 Then
            grade = "A"
        ElseIf collectScore + midtermExamScores + finalExamScores >= 70 Then
            grade = "B"
        ElseIf collectScore + midtermExamScores + finalExamScores >= 60 Then
            grade = "C"
        ElseIf collectScore + midtermExamScores + finalExamScores >= 50 Then
            grade = "D"
        Else
            grade = "F"
        End If
        Label9.Text = CStr(grade)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        Label8.Text = CStr("")
        Label9.Text = CStr("")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class