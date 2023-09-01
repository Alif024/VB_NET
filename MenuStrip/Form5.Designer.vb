<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label5 = New Label()
        showResult = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        numDays = New TextBox()
        wagePerDay = New TextBox()
        SuspendLayout()
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(257, 228)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 29)
        Button3.TabIndex = 19
        Button3.Text = "ออก"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(148, 228)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 29)
        Button2.TabIndex = 18
        Button2.Text = "เคลียร์"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(39, 228)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 29)
        Button1.TabIndex = 17
        Button1.Text = "คำนวณ"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(46, 29)
        Label5.Name = "Label5"
        Label5.Size = New Size(267, 30)
        Label5.TabIndex = 16
        Label5.Text = "คำนวณรายได้ของพนักงาน"' 
        ' showResult
        ' 
        showResult.BorderStyle = BorderStyle.Fixed3D
        showResult.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        showResult.Location = New Point(168, 171)
        showResult.Name = "showResult"
        showResult.Size = New Size(170, 27)
        showResult.TabIndex = 15
        showResult.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(33, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 21)
        Label3.TabIndex = 14
        Label3.Text = "รายได้สุทธิทั้งหมด"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(33, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 21)
        Label2.TabIndex = 13
        Label2.Text = "จำนวนวัน"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(33, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 21)
        Label1.TabIndex = 12
        Label1.Text = "ค่าจ้างต่อวัน"' 
        ' numDays
        ' 
        numDays.Location = New Point(168, 127)
        numDays.Name = "numDays"
        numDays.Size = New Size(170, 23)
        numDays.TabIndex = 11
        ' 
        ' wagePerDay
        ' 
        wagePerDay.Location = New Point(168, 83)
        wagePerDay.Name = "wagePerDay"
        wagePerDay.Size = New Size(170, 23)
        wagePerDay.TabIndex = 10
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(378, 315)
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
        Name = "Form5"
        StartPosition = FormStartPosition.Manual
        Text = "Form5"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents showResult As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents numDays As TextBox
    Friend WithEvents wagePerDay As TextBox
End Class
