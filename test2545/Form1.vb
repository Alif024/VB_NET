Imports System.Reflection

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Do While MessageBox.Show("คุณต้องการซื้อเศษขยะในราคา 1,000,000 หรือไม่", "สินค้าใหม่มานำเสนอ", MessageBoxButtons.YesNo) = DialogResult.No
            Do While MessageBox.Show("คุณแน่ใจแล้วหรอที่จะไม่ซื้อมัน!?", "จะไม่ซื้อแน่หรอ", MessageBoxButtons.YesNo) = DialogResult.Yes

            Loop
        Loop
        MessageBox.Show("ขอบคุณที่เข้ามาอุดหนุน", "ยินดีด้วย")
        'MessageBox.Show("คุณแน่ใจแล้วหรอที่จะไม่ซื้อมัน!?", "จะไม่ซื้อแน่หรอ", MessageBoxButtons.YesNo) = DialogResult.No
        'MessageBox.Show("ขอบคุณที่เข้ามาอุดหนุน", "ยินดีด้วย")
        'If DialogResult.Yes Then

        'End If
    End Sub
End Class
