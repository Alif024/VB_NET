<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label8 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label7 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox4 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(322, 155)
        Label8.Name = "Label8"
        Label8.Size = New Size(35, 21)
        Label8.TabIndex = 40
        Label8.Text = "บาท"' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(322, 113)
        Label12.Name = "Label12"
        Label12.Size = New Size(30, 21)
        Label12.TabIndex = 36
        Label12.Text = "ชิ้น"' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(322, 74)
        Label13.Name = "Label13"
        Label13.Size = New Size(35, 21)
        Label13.TabIndex = 35
        Label13.Text = "บาท"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(38, 155)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 21)
        Label7.TabIndex = 34
        Label7.Text = "ราคาทั้งหมด"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(68, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 21)
        Label3.TabIndex = 30
        Label3.Text = "จำนวน"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(80, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 21)
        Label2.TabIndex = 29
        Label2.Text = "ราคา"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(57, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 21)
        Label1.TabIndex = 28
        Label1.Text = "ชื่อสินค้า"' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(152, 72)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(164, 23)
        TextBox4.TabIndex = 24
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(152, 111)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(164, 23)
        TextBox2.TabIndex = 22
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(152, 33)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(230, 23)
        TextBox1.TabIndex = 21
        ' 
        ' Label4
        ' 
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Location = New Point(153, 152)
        Label4.Name = "Label4"
        Label4.Size = New Size(161, 31)
        Label4.TabIndex = 41
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(57, 210)
        Button1.Name = "Button1"
        Button1.Size = New Size(78, 43)
        Button1.TabIndex = 42
        Button1.Text = "คำนวณ"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(180, 210)
        Button2.Name = "Button2"
        Button2.Size = New Size(78, 43)
        Button2.TabIndex = 43
        Button2.Text = "เคลียร์"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(303, 210)
        Button3.Name = "Button3"
        Button3.Size = New Size(78, 43)
        Button3.TabIndex = 44
        Button3.Text = "ออก"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(447, 304)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label8)
        Controls.Add(Label12)
        Controls.Add(Label13)
        Controls.Add(Label7)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form3"
        StartPosition = FormStartPosition.Manual
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
