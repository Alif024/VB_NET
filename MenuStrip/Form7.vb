Public Class Form7
    Dim startNum, endNum As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        startNum = Val(TextBox1.Text)
        endNum = Val(TextBox2.Text)
        For counter As Integer = startNum To endNum
            ListBox1.Items.Add(counter)
        Next
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MessageBox.Show("คุณต้องการเคลียร์ข้อมูลในลิสต์ใช่หรือไม่", "เคลียร์ลิสต์", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ListBox1.Items.Clear()
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If MessageBox.Show("คุณต้องการปิดโปรแกรมใช่หรือไม่", "ออกจากโปรแกรม", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class