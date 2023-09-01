Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "12345" Then
            Form2.Show()
            MessageBox.Show("Welcom admin mode")
        ElseIf TextBox1.Text = "user" And TextBox2.Text = "12345" Then
            MessageBox.Show("Welcom user mode")
        Else
            MessageBox.Show("password incorrect")
        End If
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    If MessageBox.Show("", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
    '        Me.Close()
    '    End If
    'End Sub

End Class
