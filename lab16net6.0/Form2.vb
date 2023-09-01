Public Class Form2
    Private Sub InsertDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertDataToolStripMenuItem.Click
        Form3.MdiParent = Me
        Form3.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show("Confirm?", "Exit", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Form1.Close()
        End If
    End Sub

    Private Sub DeleteDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteDataToolStripMenuItem.Click
        Form4.MdiParent = Me
        Form4.Show()
    End Sub

    Private Sub ShowDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowDataToolStripMenuItem.Click
        Form5.MdiParent = Me
        Form5.Show()
    End Sub
End Class