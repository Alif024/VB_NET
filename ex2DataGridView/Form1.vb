Public Class Form1
    Dim salary As Integer
    Dim netSalary, tax As Double
    Dim tax_text As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        salary = Val(TextBox3.Text)
        tax = Val(TextBox4.Text) / 100
        netSalary = salary - salary * tax
        Label9.Text = CStr(Math.Round(netSalary, 2))
        tax_text = TextBox4.Text + " %"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.Rows.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text, tax_text, Label9.Text)
    End Sub
End Class
