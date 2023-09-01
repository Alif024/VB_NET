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
        testConnect = New Button()
        ReadData = New Button()
        AddData = New Button()
        SuspendLayout()
        ' 
        ' testConnect
        ' 
        testConnect.Location = New Point(103, 78)
        testConnect.Name = "testConnect"
        testConnect.Size = New Size(183, 64)
        testConnect.TabIndex = 0
        testConnect.Text = "test_connect"
        testConnect.UseVisualStyleBackColor = True
        ' 
        ' ReadData
        ' 
        ReadData.Location = New Point(102, 175)
        ReadData.Name = "ReadData"
        ReadData.Size = New Size(183, 64)
        ReadData.TabIndex = 1
        ReadData.Text = "ReadData"
        ReadData.UseVisualStyleBackColor = True
        ' 
        ' AddData
        ' 
        AddData.Location = New Point(103, 272)
        AddData.Name = "AddData"
        AddData.Size = New Size(183, 64)
        AddData.TabIndex = 2
        AddData.Text = "AddData"
        AddData.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(AddData)
        Controls.Add(ReadData)
        Controls.Add(testConnect)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents testConnect As Button
    Friend WithEvents ReadData As Button
    Friend WithEvents AddData As Button
End Class
