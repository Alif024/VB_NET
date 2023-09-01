Public Class Form1
    Dim grade As Integer
    'Select Case Score
    'Case 80 To 100
    'Messagebox.show( "ได้เกรด A") 
    'Case 70 To 79
    'Messagebox.show( "ได้เกรด B") 
    'Case 60 To 69
    'Messagebox.show( "ได้เกรด C") 
    'Case 50 To 59
    'Messagebox.show( "ได้เกรด D")
    'Case Else
    'Messagebox.show( "ได้เกรด F")
    'End Select
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        grade = Val(TextBox1.Text)
        Select Case grade
            Case 80 To 100 : MessageBox.Show("ได้เกรด A")
            Case 70 To 79 : MessageBox.Show("ได้เกรด B")
            Case 60 To 69 : MessageBox.Show("ได้เกรด C")
            Case 50 To 59 : MessageBox.Show("ได้เกรด D")
            Case 0 To 49 : MessageBox.Show("ได้เกรด F")
            Case Else : MessageBox.Show("กรอก 0-100 เท่านั้น")
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
