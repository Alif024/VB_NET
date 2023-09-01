<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        txtSimple = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        SuspendLayout()
        ' 
        ' txtSimple
        ' 
        txtSimple.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtSimple.Location = New Point(91, 170)
        txtSimple.Multiline = True
        txtSimple.Name = "txtSimple"
        txtSimple.Size = New Size(663, 228)
        txtSimple.TabIndex = 13
        txtSimple.Text = "ALIF WAEHAYEE"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(49, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 30)
        Label2.TabIndex = 12
        Label2.Text = "ตัวอย่างผลลัพธ์"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(49, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 30)
        Label1.TabIndex = 11
        Label1.Text = "รูปแบบตัวอักษร"' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox4.Location = New Point(389, 83)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(104, 29)
        CheckBox4.TabIndex = 10
        CheckBox4.Text = "strikeout"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox3.Location = New Point(549, 83)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(114, 29)
        CheckBox3.TabIndex = 9
        CheckBox3.Text = "Underline"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox2.Location = New Point(262, 83)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(71, 29)
        CheckBox2.TabIndex = 8
        CheckBox2.Text = "Italic"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox1.Location = New Point(137, 83)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(69, 29)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "Bold"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(802, 435)
        Controls.Add(txtSimple)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Name = "Form4"
        StartPosition = FormStartPosition.Manual
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSimple As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
