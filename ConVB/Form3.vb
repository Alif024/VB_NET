Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Form3
    Dim connection As New MySqlConnection("datasource=localhost;
                            port=3306;
                            username=root;
                            password='';
                            database=alif_db")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As New MySqlCommand("INSERT INTO tbl_employee(emp_id, emp_name, emp_lastname, emp_address, emp_tell)
        values(@emp_id, @emp_name, @emp_lastname, @emp_address, @emp_tell)", connection)
        command.Parameters.Add("@emp_id", MySqlDbType.Int64).Value = TextBox1.Text
        command.Parameters.Add("@emp_name", MySqlDbType.VarChar).Value = TextBox2.Text
        command.Parameters.Add("@emp_lastname", MySqlDbType.VarChar).Value = TextBox3.Text
        command.Parameters.Add("@emp_address", MySqlDbType.VarChar).Value = TextBox4.Text
        command.Parameters.Add("@emp_tell", MySqlDbType.VarChar).Value = TextBox5.Text
        connection.Open()
        If command.ExecuteNonQuery = 1 Then
            MessageBox.Show("Success")
        Else
            MessageBox.Show("Failed")
        End If
        connection.Close()
    End Sub
End Class