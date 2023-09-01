Public Class Form1
    Dim grade As String
    'กรอกค่า A ให้แสดงข้อความว่า MessageBox.Show ผลการเรียนดีเยี่ยม
    'กรอกค่า B ให้แสดงข้อความว่า MessageBox.Show ผลการเรียนดี
    'กรอกค่า C ให้แสดงข้อความว่า MessageBox.Show ผลการเรียนพอใช้
    'กรอกค่า D ให้แสดงข้อความว่า MessageBox.Show ผลการเรียนผ่าน
    'Else กรอกมั่ว
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        grade = TextBox1.Text
        Select Case grade
            Case "A", "a" : MessageBox.Show("ผลการเรียนดีเยี่ยม")
            Case "B", "b" : MessageBox.Show("ผลการเรียนดี")
            Case "C", "c" : MessageBox.Show("ผลการเรียนพอใช้")
            Case "D", "d" : MessageBox.Show("ผลการเรียนผ่าน")
            Case Else : MessageBox.Show("กรอกเฉพาะ A-D เท่านั้น")
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("กด OK เพื่อต้องการเคลียร์", "แน่ใจแล้วหรือไม่", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            TextBox1.Clear()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
