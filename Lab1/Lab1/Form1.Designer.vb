<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        AmountBox = New TextBox()
        Button1 = New Button()
        PriceBox = New TextBox()
        totalPriceBox = New TextBox()
        DiscountBox = New TextBox()
        netPriceBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' AmountBox
        ' 
        AmountBox.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        AmountBox.Location = New Point(159, 35)
        AmountBox.Name = "AmountBox"
        AmountBox.Size = New Size(441, 36)
        AmountBox.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(289, 163)
        Button1.Name = "Button1"
        Button1.Size = New Size(134, 45)
        Button1.TabIndex = 1
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PriceBox
        ' 
        PriceBox.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        PriceBox.Location = New Point(159, 103)
        PriceBox.Name = "PriceBox"
        PriceBox.Size = New Size(441, 36)
        PriceBox.TabIndex = 2
        ' 
        ' totalPriceBox
        ' 
        totalPriceBox.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        totalPriceBox.Location = New Point(159, 226)
        totalPriceBox.Name = "totalPriceBox"
        totalPriceBox.Size = New Size(441, 36)
        totalPriceBox.TabIndex = 3
        ' 
        ' DiscountBox
        ' 
        DiscountBox.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        DiscountBox.Location = New Point(159, 290)
        DiscountBox.Name = "DiscountBox"
        DiscountBox.Size = New Size(441, 36)
        DiscountBox.TabIndex = 4
        ' 
        ' netPriceBox
        ' 
        netPriceBox.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        netPriceBox.Location = New Point(159, 356)
        netPriceBox.Name = "netPriceBox"
        netPriceBox.Size = New Size(441, 36)
        netPriceBox.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(35, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 30)
        Label1.TabIndex = 6
        Label1.Text = "จำนวนสินค้า"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(35, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 30)
        Label2.TabIndex = 7
        Label2.Text = "ราคาสินค้า"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(34, 229)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 30)
        Label3.TabIndex = 8
        Label3.Text = "ราคาทั้งหมด"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(35, 293)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 30)
        Label4.TabIndex = 9
        Label4.Text = "ส่วนลด"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(34, 359)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 30)
        Label5.TabIndex = 10
        Label5.Text = "ราคาสุทธิ"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(681, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(netPriceBox)
        Controls.Add(DiscountBox)
        Controls.Add(totalPriceBox)
        Controls.Add(PriceBox)
        Controls.Add(Button1)
        Controls.Add(AmountBox)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AmountBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PriceBox As TextBox
    Friend WithEvents totalPriceBox As TextBox
    Friend WithEvents DiscountBox As TextBox
    Friend WithEvents netPriceBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
