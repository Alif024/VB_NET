Public Class Form1
    Public Function all_close()
        Form2.Close()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
        Form8.Close()
        Form9.Close()
    End Function
    Private Sub ResumeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        all_close()
        Form2.MdiParent = Me
        Form2.Show()
    End Sub
    Private Sub โปรแกรมแบบลำดบToolStripMenuItem_Click(sender As Object, e As EventArgs)
        all_close()
        Form3.MdiParent = Me
        Form3.Show()
    End Sub

    Private Sub เงอนไขทางเดยวToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        all_close()
        Form4.MdiParent = Me
        Form4.Show()
    End Sub

    Private Sub เงอนไขสองทางToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        all_close()
        Form5.MdiParent = Me
        Form5.Show()
    End Sub

    Private Sub เงอนไขหลายๆทางToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        all_close()
        Form6.MdiParent = Me
        Form6.Show()
    End Sub

    Private Sub FornextToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        all_close()
        Form7.MdiParent = Me
        Form7.Show()
    End Sub

    Private Sub WhiledoToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        all_close()
        Form8.MdiParent = Me
        Form8.Show()
    End Sub

    Private Sub DowhileToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        all_close()
        Form9.MdiParent = Me
        Form9.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show("คุณต้องการปิดโปรแกรมใช่หรือไม่", "ออกจากโปรแกรม", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            End
        End If
    End Sub
End Class
