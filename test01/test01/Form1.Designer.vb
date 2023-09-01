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
        wagePerDay = New TextBox()
        numDays = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        showResult = New Label()
        Label5 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' wagePerDay
        ' 
        wagePerDay.Location = New Point(169, 63)
        wagePerDay.Name = "wagePerDay"
        wagePerDay.Size = New Size(170, 23)
        wagePerDay.TabIndex = 0
        ' 
        ' numDays
        ' 
        numDays.Location = New Point(169, 107)
        numDays.Name = "numDays"
        numDays.Size = New Size(170, 23)
        numDays.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(34, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 21)
        Label1.TabIndex = 2
        Label1.Text = "ค่าจ้างต่อวัน"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(34, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 21)
        Label2.TabIndex = 3
        Label2.Text = "จำนวนวัน"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(34, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 21)
        Label3.TabIndex = 4
        Label3.Text = "รายได้สุทธิทั้งหมด"' 
        ' showResult
        ' 
        showResult.BorderStyle = BorderStyle.Fixed3D
        showResult.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        showResult.Location = New Point(169, 151)
        showResult.Name = "showResult"
        showResult.Size = New Size(170, 27)
        showResult.TabIndex = 5
        showResult.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(47, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(267, 30)
        Label5.TabIndex = 6
        Label5.Text = "คำนวณรายได้ของพนักงาน"' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(40, 208)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 29)
        Button1.TabIndex = 7
        Button1.Text = "คำนวณ"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(149, 208)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 29)
        Button2.TabIndex = 8
        Button2.Text = "เคลียร์"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(258, 208)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 29)
        Button3.TabIndex = 9
        Button3.Text = "ออก"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(376, 289)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(showResult)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(numDays)
        Controls.Add(wagePerDay)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents wagePerDay As TextBox
    Friend WithEvents numDays As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents showResult As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
