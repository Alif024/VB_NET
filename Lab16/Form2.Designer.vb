<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        MenuStrip1 = New MenuStrip()
        AsdToolStripMenuItem = New ToolStripMenuItem()
        AsdToolStripMenuItem1 = New ToolStripMenuItem()
        AsdasdddToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {AsdToolStripMenuItem, AsdToolStripMenuItem1, AsdasdddToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AsdToolStripMenuItem
        ' 
        AsdToolStripMenuItem.Name = "AsdToolStripMenuItem"
        AsdToolStripMenuItem.Size = New Size(37, 20)
        AsdToolStripMenuItem.Text = "asd"
        ' 
        ' AsdToolStripMenuItem1
        ' 
        AsdToolStripMenuItem1.Name = "AsdToolStripMenuItem1"
        AsdToolStripMenuItem1.Size = New Size(61, 20)
        AsdToolStripMenuItem1.Text = "asdasda"
        ' 
        ' AsdasdddToolStripMenuItem
        ' 
        AsdasdddToolStripMenuItem.Name = "AsdasdddToolStripMenuItem"
        AsdasdddToolStripMenuItem.Size = New Size(69, 20)
        AsdasdddToolStripMenuItem.Text = "asdasddd"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Form2"
        Text = "Form2"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AsdToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsdToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AsdasdddToolStripMenuItem As ToolStripMenuItem
End Class
