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
        components = New ComponentModel.Container()
        MenuStrip1 = New Windows.Forms.MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        โปรแกรมแบบลำดบToolStripMenuItem = New ToolStripMenuItem()
        โปรแกรมแบบเงอนไขToolStripMenuItem = New ToolStripMenuItem()
        เงอนไขทางเดยวToolStripMenuItem = New ToolStripMenuItem()
        เงอนไขสองทางToolStripMenuItem = New ToolStripMenuItem()
        เงอนไขหลายๆทางToolStripMenuItem = New ToolStripMenuItem()
        โปรแกรมแบบวนซำToolStripMenuItem = New ToolStripMenuItem()
        FornextToolStripMenuItem = New ToolStripMenuItem()
        WhiledoToolStripMenuItem = New ToolStripMenuItem()
        DowhileToolStripMenuItem = New ToolStripMenuItem()
        ResumeToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        BindingSource1 = New BindingSource(components)
        MenuStrip1.SuspendLayout()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, ResumeToolStripMenuItem, ExitToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {โปรแกรมแบบลำดบToolStripMenuItem, โปรแกรมแบบเงอนไขToolStripMenuItem, โปรแกรมแบบวนซำToolStripMenuItem})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(61, 20)
        ToolStripMenuItem1.Text = "โปรแกรม"' 
        ' โปรแกรมแบบลำดบToolStripMenuItem
        ' 
        โปรแกรมแบบลำดบToolStripMenuItem.Name = "โปรแกรมแบบลำดบToolStripMenuItem"
        โปรแกรมแบบลำดบToolStripMenuItem.Size = New Size(167, 22)
        โปรแกรมแบบลำดบToolStripMenuItem.Text = "&โปรแกรมแบบลำดับ"' 
        ' โปรแกรมแบบเงอนไขToolStripMenuItem
        ' 
        โปรแกรมแบบเงอนไขToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {เงอนไขทางเดยวToolStripMenuItem, เงอนไขสองทางToolStripMenuItem, เงอนไขหลายๆทางToolStripMenuItem})
        โปรแกรมแบบเงอนไขToolStripMenuItem.Name = "โปรแกรมแบบเงอนไขToolStripMenuItem"
        โปรแกรมแบบเงอนไขToolStripMenuItem.Size = New Size(167, 22)
        โปรแกรมแบบเงอนไขToolStripMenuItem.Text = "&โปรแกรมแบบเงื่ิอนไข"' 
        ' เงอนไขทางเดยวToolStripMenuItem
        ' 
        เงอนไขทางเดยวToolStripMenuItem.Name = "เงอนไขทางเดยวToolStripMenuItem"
        เงอนไขทางเดยวToolStripMenuItem.Size = New Size(151, 22)
        เงอนไขทางเดยวToolStripMenuItem.Text = "&เงื่อนไขทางเดียว"' 
        ' เงอนไขสองทางToolStripMenuItem
        ' 
        เงอนไขสองทางToolStripMenuItem.Name = "เงอนไขสองทางToolStripMenuItem"
        เงอนไขสองทางToolStripMenuItem.Size = New Size(151, 22)
        เงอนไขสองทางToolStripMenuItem.Text = "&เงื่อนไขสองทาง"' 
        ' เงอนไขหลายๆทางToolStripMenuItem
        ' 
        เงอนไขหลายๆทางToolStripMenuItem.Name = "เงอนไขหลายๆทางToolStripMenuItem"
        เงอนไขหลายๆทางToolStripMenuItem.Size = New Size(151, 22)
        เงอนไขหลายๆทางToolStripMenuItem.Text = "&เงื่อนไขหลายๆทาง"' 
        ' โปรแกรมแบบวนซำToolStripMenuItem
        ' 
        โปรแกรมแบบวนซำToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FornextToolStripMenuItem, WhiledoToolStripMenuItem, DowhileToolStripMenuItem})
        โปรแกรมแบบวนซำToolStripMenuItem.Name = "โปรแกรมแบบวนซำToolStripMenuItem"
        โปรแกรมแบบวนซำToolStripMenuItem.Size = New Size(167, 22)
        โปรแกรมแบบวนซำToolStripMenuItem.Text = "&โปรแกรมแบบวนซ้ำ"' 
        ' FornextToolStripMenuItem
        ' 
        FornextToolStripMenuItem.Name = "FornextToolStripMenuItem"
        FornextToolStripMenuItem.Size = New Size(127, 22)
        FornextToolStripMenuItem.Text = "&For...next"' 
        ' WhiledoToolStripMenuItem
        ' 
        WhiledoToolStripMenuItem.Name = "WhiledoToolStripMenuItem"
        WhiledoToolStripMenuItem.Size = New Size(127, 22)
        WhiledoToolStripMenuItem.Text = "&While...do"' 
        ' DowhileToolStripMenuItem
        ' 
        DowhileToolStripMenuItem.Name = "DowhileToolStripMenuItem"
        DowhileToolStripMenuItem.Size = New Size(127, 22)
        DowhileToolStripMenuItem.Text = "&Do...while"' 
        ' ResumeToolStripMenuItem
        ' 
        ResumeToolStripMenuItem.Name = "ResumeToolStripMenuItem"
        ResumeToolStripMenuItem.Size = New Size(61, 20)
        ResumeToolStripMenuItem.Text = "Resume"' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(38, 20)
        ExitToolStripMenuItem.Text = "Exit"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnablePreventFocusChange
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ResumeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents โปรแกรมแบบลำดบToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents โปรแกรมแบบเงอนไขToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents เงอนไขทางเดยวToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents เงอนไขสองทางToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents เงอนไขหลายๆทางToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents โปรแกรมแบบวนซำToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FornextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhiledoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DowhileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BindingSource1 As BindingSource
End Class
