Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double, b As Double, c As Double, d As Double
        Dim ei As Integer

        d = Val(AmountBox.Text)
        ei = Val(PriceBox.Text)
        a = ei * d
        b = a * 5 / 100
        c = a - b
        totalPriceBox.Text = CStr(a) + " บาท"
        DiscountBox.Text = CStr(b) + " บาท"
        netPriceBox.Text = CStr(c) + " บาท"

    End Sub

End Class
