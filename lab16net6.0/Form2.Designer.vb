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
        InsertDataToolStripMenuItem = New ToolStripMenuItem()
        DeleteDataToolStripMenuItem = New ToolStripMenuItem()
        ShowDataToolStripMenuItem = New ToolStripMenuItem()
        UpdateDataToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {InsertDataToolStripMenuItem, DeleteDataToolStripMenuItem, ShowDataToolStripMenuItem, UpdateDataToolStripMenuItem, ExitToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InsertDataToolStripMenuItem
        ' 
        InsertDataToolStripMenuItem.Name = "InsertDataToolStripMenuItem"
        InsertDataToolStripMenuItem.Size = New Size(75, 20)
        InsertDataToolStripMenuItem.Text = "Insert Data"
        ' 
        ' DeleteDataToolStripMenuItem
        ' 
        DeleteDataToolStripMenuItem.Name = "DeleteDataToolStripMenuItem"
        DeleteDataToolStripMenuItem.Size = New Size(79, 20)
        DeleteDataToolStripMenuItem.Text = "Delete Data"
        ' 
        ' ShowDataToolStripMenuItem
        ' 
        ShowDataToolStripMenuItem.Name = "ShowDataToolStripMenuItem"
        ShowDataToolStripMenuItem.Size = New Size(75, 20)
        ShowDataToolStripMenuItem.Text = "Show Data"
        ' 
        ' UpdateDataToolStripMenuItem
        ' 
        UpdateDataToolStripMenuItem.Name = "UpdateDataToolStripMenuItem"
        UpdateDataToolStripMenuItem.Size = New Size(84, 20)
        UpdateDataToolStripMenuItem.Text = "Update Data"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(38, 20)
        ExitToolStripMenuItem.Text = "Exit"
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
    Friend WithEvents InsertDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
