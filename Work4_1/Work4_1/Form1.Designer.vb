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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(172, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(467, 45)
        Label1.TabIndex = 0
        Label1.Text = "กรุณาป้อนข้อมูลคะแนนนักศึกษา"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(336, 79)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(307, 23)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(336, 118)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(307, 23)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(336, 157)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(307, 23)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(336, 196)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(307, 23)
        TextBox4.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(156, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 21)
        Label2.TabIndex = 5
        Label2.Text = "ชื่อนักศึกษา :"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(156, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 21)
        Label3.TabIndex = 6
        Label3.Text = "คะแนนเก็บ :"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(156, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 21)
        Label4.TabIndex = 7
        Label4.Text = "คะแนนกลางภาค :"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(156, 196)
        Label5.Name = "Label5"
        Label5.Size = New Size(133, 21)
        Label5.TabIndex = 8
        Label5.Text = "คะแนนปลายภาค :"' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(429, 246)
        Button1.Name = "Button1"
        Button1.Size = New Size(108, 32)
        Button1.TabIndex = 9
        Button1.Text = "คำนวณ"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(156, 304)
        Label6.Name = "Label6"
        Label6.Size = New Size(115, 21)
        Label6.TabIndex = 10
        Label6.Text = "คะแนนทั้งหมด :"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(156, 337)
        Label7.Name = "Label7"
        Label7.Size = New Size(51, 21)
        Label7.TabIndex = 11
        Label7.Text = "เกรด :"' 
        ' Label8
        ' 
        Label8.BorderStyle = BorderStyle.Fixed3D
        Label8.ImageAlign = ContentAlignment.BottomCenter
        Label8.Location = New Point(336, 304)
        Label8.Name = "Label8"
        Label8.Size = New Size(303, 23)
        Label8.TabIndex = 12
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.BorderStyle = BorderStyle.Fixed3D
        Label9.ImageAlign = ContentAlignment.BottomCenter
        Label9.Location = New Point(336, 335)
        Label9.Name = "Label9"
        Label9.Size = New Size(303, 23)
        Label9.TabIndex = 13
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(352, 377)
        Button2.Name = "Button2"
        Button2.Size = New Size(108, 32)
        Button2.TabIndex = 14
        Button2.Text = "เคลียร์"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(514, 377)
        Button3.Name = "Button3"
        Button3.Size = New Size(108, 32)
        Button3.TabIndex = 15
        Button3.Text = "ออก"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
