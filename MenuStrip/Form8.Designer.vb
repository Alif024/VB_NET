<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Button6 = New Button()
        Button5 = New Button()
        GroupBox1 = New GroupBox()
        Button2 = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        ListBox1 = New ListBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button6.Location = New Point(32, 281)
        Button6.Name = "Button6"
        Button6.Size = New Size(175, 40)
        Button6.TabIndex = 13
        Button6.Text = "Exit"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Location = New Point(32, 219)
        Button5.Name = "Button5"
        Button5.Size = New Size(175, 40)
        Button5.TabIndex = 12
        Button5.Text = "Clear List"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button6)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(27, 10)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(248, 342)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "ประเภทของ Loop การทำซ้ำ"' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(32, 157)
        Button2.Name = "Button2"
        Button2.Size = New Size(175, 40)
        Button2.TabIndex = 5
        Button2.Text = "Do while loop"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(108, 90)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(117, 34)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(108, 50)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(117, 34)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(22, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 21)
        Label2.TabIndex = 1
        Label2.Text = "ค่าสุดท้าย"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(22, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 21)
        Label1.TabIndex = 0
        Label1.Text = "ค่าเริ่มต้น"' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 28
        ListBox1.Location = New Point(295, 12)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(228, 340)
        ListBox1.TabIndex = 10
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(571, 382)
        Controls.Add(GroupBox1)
        Controls.Add(ListBox1)
        Name = "Form8"
        StartPosition = FormStartPosition.Manual
        Text = "Form8"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
End Class
