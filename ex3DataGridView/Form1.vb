Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Rows.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, ComboBox1.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text, TextBox12.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("ต้องการเคลียร์ข้อมูลทั้งหมดใน Data Grid หรือไม่", "เคลียร์ข้อมูล", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            DataGridView1.Rows.Clear()
        End If
    End Sub
End Class
