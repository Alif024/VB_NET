Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label5.Text = Math.Round(Val(TextBox1.Text) + Val(TextBox2.Text), 3)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label5.Text = Math.Round(Val(TextBox1.Text) - Val(TextBox2.Text), 3)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label5.Text = Math.Round(Val(TextBox1.Text) * Val(TextBox2.Text), 3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label5.Text = Math.Round(Val(TextBox1.Text) / Val(TextBox2.Text), 3)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class
