Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub testConnect_Click(sender As Object, e As EventArgs) Handles testConnect.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=alif_db"
        Try
            conn.Open()
            MessageBox.Show("Successfully", "Test Connect")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub ReadData_Click(sender As Object, e As EventArgs) Handles ReadData.Click
        Form2.Show()
    End Sub
    Private Sub AddData_Click(sender As Object, e As EventArgs) Handles AddData.Click
        Form3.Show()
    End Sub
End Class
