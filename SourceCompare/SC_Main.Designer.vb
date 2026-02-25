<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		MenuStrip1 = New MenuStrip()
		FileToolStripMenuItem = New ToolStripMenuItem()
		mnuSelect = New ToolStripMenuItem()
		mnuExit = New ToolStripTextBox()
		HelpToolStripMenuItem = New ToolStripMenuItem()
		mnuAbout = New ToolStripMenuItem()
		VScrollBar1 = New VScrollBar()
		SplitContainer1 = New SplitContainer()
		lblPane1 = New Label()
		HScrollBar1 = New HScrollBar()
		lblPane2 = New Label()
		HScrollBar2 = New HScrollBar()
		MenuStrip1.SuspendLayout()
		CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
		SplitContainer1.Panel1.SuspendLayout()
		SplitContainer1.Panel2.SuspendLayout()
		SplitContainer1.SuspendLayout()
		SuspendLayout()
		' 
		' MenuStrip1
		' 
		MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Size = New Size(800, 24)
		MenuStrip1.TabIndex = 0
		MenuStrip1.Text = "MenuStrip1"
		' 
		' FileToolStripMenuItem
		' 
		FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuSelect, mnuExit})
		FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		FileToolStripMenuItem.Size = New Size(37, 20)
		FileToolStripMenuItem.Text = "&File"
		' 
		' mnuSelect
		' 
		mnuSelect.Name = "mnuSelect"
		mnuSelect.Size = New Size(180, 22)
		mnuSelect.Text = "Select &Files"
		' 
		' mnuExit
		' 
		mnuExit.Name = "mnuExit"
		mnuExit.Size = New Size(100, 23)
		mnuExit.Text = "Exit"
		' 
		' HelpToolStripMenuItem
		' 
		HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuAbout})
		HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
		HelpToolStripMenuItem.Size = New Size(44, 20)
		HelpToolStripMenuItem.Text = "&Help"
		' 
		' mnuAbout
		' 
		mnuAbout.Name = "mnuAbout"
		mnuAbout.Size = New Size(195, 22)
		mnuAbout.Text = "&About SourceCompare"
		' 
		' VScrollBar1
		' 
		VScrollBar1.Dock = DockStyle.Right
		VScrollBar1.Location = New Point(783, 24)
		VScrollBar1.Name = "VScrollBar1"
		VScrollBar1.Size = New Size(17, 426)
		VScrollBar1.TabIndex = 1
		' 
		' SplitContainer1
		' 
		SplitContainer1.Dock = DockStyle.Fill
		SplitContainer1.Location = New Point(0, 24)
		SplitContainer1.Name = "SplitContainer1"
		' 
		' SplitContainer1.Panel1
		' 
		SplitContainer1.Panel1.Controls.Add(lblPane1)
		SplitContainer1.Panel1.Controls.Add(HScrollBar1)
		' 
		' SplitContainer1.Panel2
		' 
		SplitContainer1.Panel2.Controls.Add(lblPane2)
		SplitContainer1.Panel2.Controls.Add(HScrollBar2)
		SplitContainer1.Size = New Size(783, 426)
		SplitContainer1.SplitterDistance = 385
		SplitContainer1.TabIndex = 2
		' 
		' lblPane1
		' 
		lblPane1.Dock = DockStyle.Top
		lblPane1.Location = New Point(0, 0)
		lblPane1.Name = "lblPane1"
		lblPane1.Size = New Size(385, 15)
		lblPane1.TabIndex = 1
		' 
		' HScrollBar1
		' 
		HScrollBar1.Dock = DockStyle.Bottom
		HScrollBar1.Location = New Point(0, 409)
		HScrollBar1.Name = "HScrollBar1"
		HScrollBar1.Size = New Size(385, 17)
		HScrollBar1.TabIndex = 0
		' 
		' lblPane2
		' 
		lblPane2.Dock = DockStyle.Top
		lblPane2.Location = New Point(0, 0)
		lblPane2.Name = "lblPane2"
		lblPane2.Size = New Size(394, 15)
		lblPane2.TabIndex = 2
		' 
		' HScrollBar2
		' 
		HScrollBar2.Dock = DockStyle.Bottom
		HScrollBar2.Location = New Point(0, 409)
		HScrollBar2.Name = "HScrollBar2"
		HScrollBar2.Size = New Size(394, 17)
		HScrollBar2.TabIndex = 1
		' 
		' frmMain
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(SplitContainer1)
		Controls.Add(VScrollBar1)
		Controls.Add(MenuStrip1)
		Icon = CType(resources.GetObject("$this.Icon"), Icon)
		MainMenuStrip = MenuStrip1
		Name = "frmMain"
		Text = "Source Compare"
		MenuStrip1.ResumeLayout(False)
		MenuStrip1.PerformLayout()
		SplitContainer1.Panel1.ResumeLayout(False)
		SplitContainer1.Panel2.ResumeLayout(False)
		CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
		SplitContainer1.ResumeLayout(False)
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents mnuSelect As ToolStripMenuItem
	Friend WithEvents mnuExit As ToolStripTextBox
	Friend WithEvents VScrollBar1 As VScrollBar
	Friend WithEvents SplitContainer1 As SplitContainer
	Friend WithEvents HScrollBar1 As HScrollBar
	Friend WithEvents HScrollBar2 As HScrollBar
	Friend WithEvents lblPane1 As Label
	Friend WithEvents lblPane2 As Label
	Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents mnuAbout As ToolStripMenuItem
End Class
