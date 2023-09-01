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
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        Label1 = New Label()
        Label2 = New Label()
        txtSimple = New TextBox()
        SuspendLayout()
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox1.Location = New Point(129, 65)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(69, 29)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Bold"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox2.Location = New Point(254, 65)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(71, 29)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Italic"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox3.Location = New Point(541, 65)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(114, 29)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Underline"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox4.Location = New Point(381, 65)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(104, 29)
        CheckBox4.TabIndex = 3
        CheckBox4.Text = "strikeout"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(41, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 30)
        Label1.TabIndex = 4
        Label1.Text = "รูปแบบตัวอักษร"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(41, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 30)
        Label2.TabIndex = 5
        Label2.Text = "ตัวอย่างผลลัพธ์"' 
        ' txtSimple
        ' 
        txtSimple.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtSimple.Location = New Point(83, 152)
        txtSimple.Multiline = True
        txtSimple.Name = "txtSimple"
        txtSimple.Size = New Size(663, 228)
        txtSimple.TabIndex = 6
        txtSimple.Text = "ALIF WAEHAYEE"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(885, 449)
        Controls.Add(txtSimple)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSimple As TextBox
End Class
