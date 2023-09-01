Public Class Form1

    Private Sub CheckBox_Changed() Handles CheckBox1.CheckedChanged, CheckBox2.CheckedChanged, CheckBox3.CheckedChanged, CheckBox4.CheckedChanged, txtSimple.TextChanged, txtSimple.TextChanged
        Dim fs As FontStyle = FontStyle.Regular

        If CheckBox1.Checked Then
            fs += FontStyle.Bold
        End If

        If CheckBox2.Checked Then
            fs += FontStyle.Italic
        End If

        If CheckBox3.Checked Then
            fs += FontStyle.Strikeout
        End If

        If CheckBox4.Checked Then
            fs += FontStyle.Underline
        End If

        Dim fnt As New Font("Arial", 20, fs)
        txtSimple.Font = fnt

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
