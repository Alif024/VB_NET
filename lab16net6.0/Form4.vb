Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports SystemData
Public Class Form4
    Dim conn As MySqlConnection
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Dim SQL As String

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection()
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=alif_db"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As New MySqlCommand("DELETE FROM `tbl_customer` WHERE `customer_id` = @customer_id", conn)
        command.Parameters.Add("@customer_id", MySqlDbType.Int64).Value = TextBox1.Text
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
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim command As New MySqlCommand("DELETE FROM `tbl_product` WHERE `product_id` = @product_id", conn)
        command.Parameters.Add("@product_id", MySqlDbType.Int64).Value = TextBox1.Text
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
    End Sub
End Class