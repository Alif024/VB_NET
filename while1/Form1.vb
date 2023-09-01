Imports System.Diagnostics.CodeAnalysis
Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("คุณต้องการล้างข้อมูลหรือไม่", "ล้างข้อมูลทั้งหมด", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ListBox1.Items.Clear()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("ต้องออกจากโปรแกรมหรือไม่", "ออกจากโปรแกรม", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    Dim i, sum, total, num As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        ListBox1.Items.Add("ป้อนแม่สูตรคูณ : " & num)
        ListBox1.Items.Add("===================")
        num = Val(TextBox1.Text)
        i = 1
        While i <= 12
            sum = num * i
            total = total + sum
            ListBox1.Items.Add(num & " * " & i & " = " & sum)
            i += 1
        End While
        ListBox1.Items.Add("===================")
        ListBox1.Items.Add("รวมทังหมด : " & total)
    End Sub
End Class
