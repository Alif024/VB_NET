Public Class Form1
    Dim sales, commission, totalIncome, salary As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sales = Val(TextBox4.Text)
        salary = Val(TextBox5.Text)
        If sales >= 100000 Then
            commission = 25 / 100
            totalIncome = salary + (commission * salary)
        Else
            totalIncome = salary
        End If
        Label9.Text = CStr(totalIncome)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        Label9.Text = CStr("")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
