Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim tax, netPrice, totalPrice, amount, price As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        price = Val(TextBox2.Text)
        amount = Val(TextBox3.Text)
        totalPrice = price * amount
        Label7.Text = CStr(totalPrice)

        '• ถ้า ราคาสินค้าทั้งหมด  >= 100000  ภาษี คือ  0.15 
        '• ถ้า ราคาสินค้าทั้งหมด  >=50000    ภาษี คือ  0.12
        '• ถ้า ราคาสินค้าทั้งหมด  >=  10000   ภาษี คือ  0.1
        '• ถ้า ราคาสินค้าทั้งหมด  <   9999      ภาษี คือ  0.07
        If totalPrice >= 100000 Then
            tax = 0.15
        ElseIf totalPrice >= 50000 Then
            tax = 0.12
        ElseIf totalPrice >= 10000 Then
            tax = 0.1
        ElseIf totalPrice < 9999 Then
            tax = 0.07
        End If
        netPrice = totalPrice + (totalPrice * tax)
        Label8.Text = CStr(Math.Round(tax * totalPrice, 3))
        Label9.Text = CStr(Math.Round(netPrice, 3))

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Label7.Text = CStr("")
        Label8.Text = CStr("")
        Label9.Text = CStr("")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
