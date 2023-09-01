Public Class Form1
    Private Sub btnMessage_Click(sender As Object, e As EventArgs)

        Dim title As String = ""

        If Mr.Checked Then
            title = Mr.Text
        End If
        If Miss.Checked Then
            title = Miss.Text
        End If
        If Mrs.Checked Then
            title = Mrs.Text
        End If
        If Boy.Checked Then
            title = Boy.Text
        End If
        If Girl.Checked Then
            title = Girl.Text
        End If
        MessageBox.Show("คุณชื่อ: " & title & TextBox1.Text)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
