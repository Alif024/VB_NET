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
        Mr = New RadioButton()
        Miss = New RadioButton()
        Mrs = New RadioButton()
        Boy = New RadioButton()
        Girl = New RadioButton()
        Label2 = New Label()
        TextBox1 = New TextBox()
        btnMessage = New Button()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(56, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 21)
        Label1.TabIndex = 0
        Label1.Text = "กรุณาเลือกคำนำหน้า ชื่อ-สกุล"' 
        ' Mr
        ' 
        Mr.AutoSize = True
        Mr.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Mr.Location = New Point(109, 92)
        Mr.Name = "Mr"
        Mr.Size = New Size(53, 25)
        Mr.TabIndex = 1
        Mr.TabStop = True
        Mr.Text = "นาย"
        Mr.UseVisualStyleBackColor = True
        ' 
        ' Miss
        ' 
        Miss.AutoSize = True
        Miss.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Miss.Location = New Point(296, 92)
        Miss.Name = "Miss"
        Miss.Size = New Size(51, 25)
        Miss.TabIndex = 2
        Miss.TabStop = True
        Miss.Text = "นาง"
        Miss.UseVisualStyleBackColor = True
        ' 
        ' Mrs
        ' 
        Mrs.AutoSize = True
        Mrs.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Mrs.Location = New Point(195, 92)
        Mrs.Name = "Mrs"
        Mrs.Size = New Size(74, 25)
        Mrs.TabIndex = 3
        Mrs.TabStop = True
        Mrs.Text = "นางสาว"
        Mrs.UseVisualStyleBackColor = True
        ' 
        ' Boy
        ' 
        Boy.AutoSize = True
        Boy.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Boy.Location = New Point(381, 92)
        Boy.Name = "Boy"
        Boy.Size = New Size(75, 25)
        Boy.TabIndex = 4
        Boy.TabStop = True
        Boy.Text = "เด็กชาย"
        Boy.UseVisualStyleBackColor = True
        ' 
        ' Girl
        ' 
        Girl.AutoSize = True
        Girl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Girl.Location = New Point(484, 92)
        Girl.Name = "Girl"
        Girl.Size = New Size(78, 25)
        Girl.TabIndex = 5
        Girl.TabStop = True
        Girl.Text = "เด็กหญิง"
        Girl.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(56, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 21)
        Label2.TabIndex = 6
        Label2.Text = "ชื่อ-สกุล"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(123, 160)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(439, 23)
        TextBox1.TabIndex = 7
        ' 
        ' btnMessage
        ' 
        btnMessage.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnMessage.Location = New Point(580, 147)
        btnMessage.Name = "btnMessage"
        btnMessage.Size = New Size(84, 42)
        btnMessage.TabIndex = 8
        btnMessage.Text = "แสดงผล"
        btnMessage.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(31, 68)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(97, 19)
        RadioButton1.TabIndex = 9
        RadioButton1.TabStop = True
        RadioButton1.Text = "RadioButton1"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(178, 68)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(97, 19)
        RadioButton2.TabIndex = 10
        RadioButton2.TabStop = True
        RadioButton2.Text = "RadioButton2"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(33, 35)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 11
        Label3.Text = "Label3"' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.ForeColor = SystemColors.ControlText
        GroupBox1.Location = New Point(38, 216)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(309, 125)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"' 
        ' Button1
        ' 
        Button1.Location = New Point(116, 88)
        Button1.Name = "Button1"
        Button1.Size = New Size(59, 25)
        Button1.TabIndex = 12
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(742, 380)
        Controls.Add(GroupBox1)
        Controls.Add(btnMessage)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Girl)
        Controls.Add(Boy)
        Controls.Add(Mrs)
        Controls.Add(Miss)
        Controls.Add(Mr)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "ข้อมูลบุคลากร"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Mr As RadioButton
    Friend WithEvents Miss As RadioButton
    Friend WithEvents Mrs As RadioButton
    Friend WithEvents Boy As RadioButton
    Friend WithEvents Girl As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnMessage As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
End Class
