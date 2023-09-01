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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(143, 56)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(281, 23)
        TextBox1.TabIndex = 0
        TextBox1.TextAlign = HorizontalAlignment.Right
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(143, 150)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(281, 23)
        TextBox2.TabIndex = 1
        TextBox2.TextAlign = HorizontalAlignment.Right
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(485, 49)
        Button1.Name = "Button1"
        Button1.Size = New Size(142, 28)
        Button1.TabIndex = 2
        Button1.Text = "convert °C"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(485, 145)
        Button2.Name = "Button2"
        Button2.Size = New Size(146, 28)
        Button2.TabIndex = 3
        Button2.Text = "convert °F"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(485, 179)
        Button3.Name = "Button3"
        Button3.Size = New Size(70, 28)
        Button3.TabIndex = 4
        Button3.Text = "clear"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(561, 179)
        Button4.Name = "Button4"
        Button4.Size = New Size(70, 28)
        Button4.TabIndex = 5
        Button4.Text = "exit"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(38, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 15)
        Label1.TabIndex = 6
        Label1.Text = "อุณหภูมิหน่วย °F"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(38, 153)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 15)
        Label2.TabIndex = 7
        Label2.Text = "อุณหภูมิหน่วย °C"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(430, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(24, 21)
        Label3.TabIndex = 8
        Label3.Text = "°F"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(430, 152)
        Label4.Name = "Label4"
        Label4.Size = New Size(26, 21)
        Label4.TabIndex = 9
        Label4.Text = "°C"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(673, 272)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
