Public Class Form1
    Dim Price1, Price2, Price3, Price4, dis, discount, sum, total As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            Price1 = 40
        Else
            Price1 = 0
        End If
        If CheckBox2.Checked Then
            Price2 = 35
        Else
            Price2 = 0
        End If
        If CheckBox3.Checked Then
            Price3 = 25
        Else
            Price3 = 0
        End If
        If CheckBox4.Checked Then
            Price4 = 30
        Else
            Price4 = 0
        End If
        If RadioButton1.Checked Then
            dis = 0.05
        ElseIf RadioButton2.Checked Then
            dis = 0.1
        End If
        sum = Price1 + Price2 + Price3 + Price4
        discount = sum * dis
        total = sum - discount
        TextBox1.Text = CStr(sum)
        TextBox2.Text = CStr(discount)
        TextBox3.Text = CStr(total)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
