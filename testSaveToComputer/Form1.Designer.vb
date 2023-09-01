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
        RichTextBox1 = New RichTextBox()
        SaveCommend = New Button()
        Upload = New Button()
        RichTextBox2 = New RichTextBox()
        OpenFileDialog1 = New OpenFileDialog()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(12, 12)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(307, 175)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = ""' 
        ' SaveCommend
        ' 
        SaveCommend.Location = New Point(37, 207)
        SaveCommend.Name = "SaveCommend"
        SaveCommend.Size = New Size(143, 23)
        SaveCommend.TabIndex = 1
        SaveCommend.Text = "Save Commend"
        SaveCommend.UseVisualStyleBackColor = True
        ' 
        ' Upload
        ' 
        Upload.Location = New Point(206, 207)
        Upload.Name = "Upload"
        Upload.Size = New Size(75, 23)
        Upload.TabIndex = 2
        Upload.Text = "Upload"
        Upload.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Location = New Point(346, 12)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.ReadOnly = True
        RichTextBox2.Size = New Size(307, 175)
        RichTextBox2.TabIndex = 3
        RichTextBox2.Text = ""' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(671, 296)
        Controls.Add(RichTextBox2)
        Controls.Add(Upload)
        Controls.Add(SaveCommend)
        Controls.Add(RichTextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents SaveCommend As Button
    Friend WithEvents Upload As Button
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
