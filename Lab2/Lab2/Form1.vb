Public Class Form1
    Dim C, F As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        F = Val(TextBox1.Text)
        C = 5 / 9 * (F - 32)
        TextBox2.Text = CStr(Math.Round(C, 4))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        C = Val(TextBox2.Text)
        F = (9 / 5 * C) + 32
        TextBox1.Text = CStr(Math.Round(F, 4))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

End Class
