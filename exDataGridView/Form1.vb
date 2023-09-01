Public Class Form1
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.FileSystem.WriteAllText("I:\lif024\text_file\test01.txt", TextBox1.Text, False) 'false: เขียนทับ, true: ต่อท้าย
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Label7.Text = My.Computer.FileSystem.ReadAllText("I:\lif024\text_file\test01.txt")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.Rows.Add(TextBox3.Text, TextBox4.Text, TextBox5.Text, ComboBox1.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("คุณต้องการเคลียร์ข้อมูลใน Data Grid หรือไม่", "เคลียร์ข้อมูล", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            DataGridView1.Rows.Clear()
        End If
    End Sub
End Class