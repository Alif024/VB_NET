Public Class Form3
    Dim Price As Double
    Dim count As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Price = Val(TextBox4.Text)
        count = Val(TextBox2.Text)
        Label4.Text = Price * count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox4.Clear()
        TextBox2.Clear()
        Label4.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class