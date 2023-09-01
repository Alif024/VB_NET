Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports SystemData

Public Class Form2
    Dim conn As MySqlConnection

    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Dim SQL As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection()
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=alif_db"
        Try
            conn.Open()
            SQL = "Select * From `tbl_employee`"

            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)

            DataGridView1.DataSource = myData

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As New MySqlCommand("DELETE FROM `tbl_employee` WHERE `Emp_ID` = @id", conn)
        command.Parameters.Add("@id", MySqlDbType.Int64).Value = TextBox1.Text
        conn.Open()
        Try
            If command.ExecuteNonQuery() = 1 Then
                If MessageBox.Show("Are you sure you want to delete?", "You Deleted",
                MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    MessageBox.Show("Data Deleted")
                End If
            Else
                MessageBox.Show("Error")
            End If
        Catch ex As Exception
            MessageBox.Show("Something Wrong")
        End Try
        conn.Close()

        DataGridView1.DataSource.Clear()
        Try
            conn.Open()
            SQL = "Select * From tbl_employee"

            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)

            DataGridView1.DataSource = myData

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conn = New MySqlConnection()
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=alif_db"
        Dim command As New MySqlCommand("UPDATE `tbl_employee` SET 
                                        `emp_name`=@emp_name,
                                        `emp_lastname`=@emp_lastname,
                                        `emp_address`=@emp_address,
                                        `emp_tell`=@emp_tell WHERE `emp_id`=@emp_id", conn)
        command.Parameters.Add("@emp_id", MySqlDbType.Int64).Value = TextBox2.Text
        command.Parameters.Add("@emp_name", MySqlDbType.VarChar).Value = TextBox3.Text
        command.Parameters.Add("@emp_lastname", MySqlDbType.VarChar).Value = TextBox4.Text
        command.Parameters.Add("@emp_address", MySqlDbType.VarChar).Value = TextBox5.Text
        command.Parameters.Add("@emp_tell", MySqlDbType.VarChar).Value = TextBox6.Text
        conn.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Successfully")
        Else
            MessageBox.Show("error")
        End If
        conn.Close()

        DataGridView1.DataSource.Clear()
        Try
            conn.Open()
            SQL = "Select * From tbl_employee"

            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)

            DataGridView1.DataSource = myData

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class