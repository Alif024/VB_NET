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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(38, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 25)
        Label1.TabIndex = 0
        Label1.Text = "ชื่อสินค้า :"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(38, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 25)
        Label2.TabIndex = 1
        Label2.Text = "ราคา :"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(38, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 25)
        Label3.TabIndex = 2
        Label3.Text = "จำนวน :"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(38, 229)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 25)
        Label4.TabIndex = 5
        Label4.Text = "ราคาสุทธิ :"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(38, 190)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 25)
        Label5.TabIndex = 4
        Label5.Text = "ภาษี :"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(38, 151)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 25)
        Label6.TabIndex = 3
        Label6.Text = "ราคารวม :"' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(183, 284)
        Button1.Name = "Button1"
        Button1.Size = New Size(108, 32)
        Button1.TabIndex = 10
        Button1.Text = "คำนวณ"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(441, 284)
        Button3.Name = "Button3"
        Button3.Size = New Size(108, 32)
        Button3.TabIndex = 17
        Button3.Text = "ออก"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(312, 284)
        Button2.Name = "Button2"
        Button2.Size = New Size(108, 32)
        Button2.TabIndex = 16
        Button2.Text = "เคลียร์"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.BorderStyle = BorderStyle.Fixed3D
        Label7.Location = New Point(183, 151)
        Label7.Name = "Label7"
        Label7.Size = New Size(366, 32)
        Label7.TabIndex = 18
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.BorderStyle = BorderStyle.Fixed3D
        Label8.Location = New Point(183, 190)
        Label8.Name = "Label8"
        Label8.Size = New Size(366, 32)
        Label8.TabIndex = 19
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.BorderStyle = BorderStyle.Fixed3D
        Label9.Location = New Point(183, 229)
        Label9.Name = "Label9"
        Label9.Size = New Size(366, 32)
        Label9.TabIndex = 20
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(184, 37)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(365, 27)
        TextBox1.TabIndex = 21
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(183, 74)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(366, 27)
        TextBox2.TabIndex = 22
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(183, 111)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(366, 27)
        TextBox3.TabIndex = 23
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(587, 351)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
