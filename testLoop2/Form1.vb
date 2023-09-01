Public Class Form1
    Dim startNum, endNum As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        startNum = Val(TextBox1.Text)
        endNum = Val(TextBox2.Text)
        For counter As Integer = startNum To endNum
            ListBox1.Items.Add(counter)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        startNum = Val(TextBox1.Text)
        endNum = Val(TextBox2.Text)
        Do While startNum < endNum
            ListBox1.Items.Add(startNum)
            startNum += 1
        Loop
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        startNum = Val(TextBox1.Text)
        endNum = Val(TextBox2.Text)
        Do
            startNum += 1
            ListBox1.Items.Add(startNum)
        Loop While startNum < endNum
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ListBox1.Items.Clear()
        startNum = Val(TextBox1.Text)
        endNum = Val(TextBox2.Text)
        Do Until startNum = endNum + 1
            ListBox1.Items.Add(startNum)
            startNum += 1
        Loop
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        startNum = Val(TextBox1.Text)
        endNum = Val(TextBox2.Text)
        Do
            startNum += 1
            ListBox1.Items.Add(startNum)
        Loop Until startNum = endNum + 1
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If MessageBox.Show("คุณต้องการปิดโปรแกรมใช่หรือไม่", "ออกจากโปรแกรม", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MessageBox.Show("คุณต้องการเคลียร์ข้อมูลในลิสต์ใช่หรือไม่", "เคลียร์ลิสต์", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ListBox1.Items.Clear()
        End If
    End Sub
End Class
