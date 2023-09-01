Imports System.IO

Public Class Form1
    Private Sub SaveCommend_Click(sender As Object, e As EventArgs) Handles SaveCommend.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "txt file (*.txt) | *.txt | All file(*.*) | *.*"
        sfd.FilterIndex = 1
        sfd.RestoreDirectory = True
        If sfd.ShowDialog() = DialogResult.OK Then
            Dim FileName As String = sfd.FileName
            Dim sw As New System.IO.StreamWriter(FileName, False)
            sw.WriteLine(RichTextBox1.Text)
            sw.Close()
        End If
    End Sub

    Private Sub Upload_Click(sender As Object, e As EventArgs) Handles Upload.Click
        Dim str As String = Application.StartupPath + "VB_file\"
        Dim dlg As New OpenFileDialog()
        If dlg.ShowDialog() = DialogResult.OK Then
        End If
        If Not Directory.Exists(str) Then
            Directory.CreateDirectory(str)
        End If
        Dim filepath As String = dlg.FileName
        Dim filename As String = System.IO.Path.GetFileName(filepath)
        File.Copy(filepath, str & filename, True)
        MessageBox.Show("Successfully")
    End Sub
End Class
