Public Class Form5
    Dim wage, result, OT As Double
    Dim day As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        wage = Val(wagePerDay.Text)
        day = Val(numDays.Text)
        If day > 25 Then
            OT = (day - 25) * wage * 2
            result = wage * 25 + OT
        Else
            result = wage * day
        End If
        showResult.Text = CStr(Math.Round(result, 2))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        wagePerDay.Clear()
        numDays.Clear()
        showResult.Text = CStr("")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class