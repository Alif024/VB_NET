Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports SystemData
Public Class Form5
    Dim conn As MySqlConnection
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Dim SQL As String

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection()
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=alif_db"
        Try
            conn.Open()
            SQL = "Select * From `tbl_customer`"

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

        conn = New MySqlConnection()
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=alif_db"

        Try
            conn.Open()
            SQL = "Select * From `tbl_product`"

            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)

            DataGridView2.DataSource = myData

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class