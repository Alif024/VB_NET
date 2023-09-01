Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "12345" Then
            Form2.Show()
            MsgBox("Welcom admin mode")
        ElseIf TextBox1.Text = "user" And TextBox2.Text = "12345" Then
            MsgBox("Welcom user mode")
        Else
            MsgBox("password incorrect")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
