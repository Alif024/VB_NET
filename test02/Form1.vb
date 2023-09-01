Imports System.Net

Public Class Form1
    Dim Price1, Price2, Price3, Price4, Price5, Price6, Price7, Price8, Price9, Price10, Price11, Price12, totalPrice, dis, netPrice As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            Price1 = 89
        Else
            Price1 = 0
        End If
        If CheckBox2.Checked Then
            Price2 = 77
        Else
            Price2 = 0
        End If
        If CheckBox3.Checked Then
            Price3 = 59
        Else
            Price3 = 0
        End If
        If CheckBox4.Checked Then
            Price4 = 90
        Else
            Price4 = 0
        End If
        If CheckBox5.Checked Then
            Price5 = 79
        Else
            Price5 = 0
        End If
        If CheckBox6.Checked Then
            Price6 = 39
        Else
            Price6 = 0
        End If
        If CheckBox12.Checked Then
            Price12 = 35
        Else
            Price12 = 0
        End If
        If CheckBox11.Checked Then
            Price11 = 45
        Else
            Price11 = 0
        End If
        If CheckBox10.Checked Then
            Price10 = 35
        Else
            Price10 = 0
        End If
        If CheckBox9.Checked Then
            Price9 = 45
        Else
            Price9 = 0
        End If
        If CheckBox8.Checked Then
            Price8 = 35
        Else
            Price8 = 0
        End If
        If CheckBox7.Checked Then
            Price7 = 35
        Else
            Price7 = 0
        End If
        If RadioButton1.Checked Then
            dis = 0
        ElseIf RadioButton2.Checked Then
            dis = 0.1
        Else
            dis = 0.2
        End If
        totalPrice = Price1 + Price2 + Price3 + Price4 + Price5 + Price6 + Price7 + Price8 + Price9 + Price10 + Price11 + Price12
        netPrice = totalPrice - (totalPrice * dis)
        Label5.Text = CStr(Math.Round(totalPrice, 3))
        Label6.Text = CStr(Math.Round(totalPrice * dis, 3))
        Label7.Text = CStr(Math.Round(netPrice, 3))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Are you OK", "title", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
            CheckBox10.Checked = False
            CheckBox11.Checked = False
            CheckBox12.Checked = False
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            Label5.Text = CStr("")
            Label6.Text = CStr("")
            Label7.Text = CStr("")
        End If
    End Sub
End Class
