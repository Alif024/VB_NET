Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class Form3
    Dim connection As New MySqlConnection("datasource=localhost;
                            port=3306;
                            username=root;
                            password='';
                            database=alif_db")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As New MySqlCommand("INSERT INTO `tbl_customer`(`customer_id`, `customer_name`, `customer_lastname`, `customer_address`, `customer_tel`)
                                        values(@customer_id, @customer_name, @customer_lastname, @customer_address, @customer_tel)", connection)
        command.Parameters.Add("@customer_id", MySqlDbType.Int64).Value = TextBox1.Text
        command.Parameters.Add("@customer_name", MySqlDbType.VarChar).Value = TextBox2.Text
        command.Parameters.Add("@customer_lastname", MySqlDbType.VarChar).Value = TextBox3.Text
        command.Parameters.Add("@customer_address", MySqlDbType.VarChar).Value = TextBox4.Text
        command.Parameters.Add("@customer_tel", MySqlDbType.VarChar).Value = TextBox5.Text
        connection.Open()
        If command.ExecuteNonQuery = 1 Then
            MsgBox("Success")
        Else
            MsgBox("Failed")
        End If
        connection.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim command As New MySqlCommand("INSERT INTO `tbl_product`(`product_id`, `product_name`, `product_price`, `product_count`, `product_tel`) 
                                        VALUES (@product_id, @product_name, @product_price, @product_count, @product_tel)", connection)
        command.Parameters.Add("@product_id", MySqlDbType.Int64).Value = TextBox10.Text
        command.Parameters.Add("@product_name", MySqlDbType.VarChar).Value = TextBox9.Text
        command.Parameters.Add("@product_price", MySqlDbType.VarChar).Value = TextBox8.Text
        command.Parameters.Add("@product_count", MySqlDbType.VarChar).Value = TextBox7.Text
        command.Parameters.Add("@product_tel", MySqlDbType.VarChar).Value = TextBox6.Text
        connection.Open()
        If command.ExecuteNonQuery = 1 Then
            MsgBox("Success")
        Else
            MsgBox("Failed")
        End If
        connection.Close()
    End Sub
End Class