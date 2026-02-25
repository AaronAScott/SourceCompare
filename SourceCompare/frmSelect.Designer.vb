<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectFiles
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
		txtFile1Name = New PromptedTextBox_Net10.PromptedTextBox()
		txtFile2Name = New PromptedTextBox_Net10.PromptedTextBox()
		btnBrowse1 = New Button()
		btnBrowse2 = New Button()
		btnCompare = New Button()
		btnClose = New Button()
		SuspendLayout()
		' 
		' txtFile1Name
		' 
		txtFile1Name.Location = New Point(22, 16)
		txtFile1Name.Name = "txtFile1Name"
		txtFile1Name.Prompt = "Select NEWEST File"
		txtFile1Name.Size = New Size(157, 23)
		txtFile1Name.TabIndex = 0
		' 
		' txtFile2Name
		' 
		txtFile2Name.Location = New Point(22, 54)
		txtFile2Name.Name = "txtFile2Name"
		txtFile2Name.Prompt = "Select OLDEST File"
		txtFile2Name.Size = New Size(157, 23)
		txtFile2Name.TabIndex = 1
		' 
		' btnBrowse1
		' 
		btnBrowse1.Location = New Point(220, 18)
		btnBrowse1.Name = "btnBrowse1"
		btnBrowse1.Size = New Size(75, 23)
		btnBrowse1.TabIndex = 2
		btnBrowse1.Text = "Browse"
		btnBrowse1.UseVisualStyleBackColor = True
		' 
		' btnBrowse2
		' 
		btnBrowse2.Location = New Point(220, 53)
		btnBrowse2.Name = "btnBrowse2"
		btnBrowse2.Size = New Size(75, 23)
		btnBrowse2.TabIndex = 3
		btnBrowse2.Text = "Browse"
		btnBrowse2.UseVisualStyleBackColor = True
		' 
		' btnCompare
		' 
		btnCompare.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
		btnCompare.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
		btnCompare.FlatStyle = FlatStyle.Flat
		btnCompare.Location = New Point(322, 16)
		btnCompare.Name = "btnCompare"
		btnCompare.Size = New Size(75, 23)
		btnCompare.TabIndex = 4
		btnCompare.Text = "Browse"
		btnCompare.UseVisualStyleBackColor = True
		' 
		' btnClose
		' 
		btnClose.FlatAppearance.MouseDownBackColor = Color.Blue
		btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
		btnClose.FlatStyle = FlatStyle.Flat
		btnClose.Location = New Point(322, 54)
		btnClose.Name = "btnClose"
		btnClose.Size = New Size(75, 23)
		btnClose.TabIndex = 5
		btnClose.Text = "Browse"
		btnClose.UseVisualStyleBackColor = True
		' 
		' frmSelectFiles
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(426, 93)
		ControlBox = False
		Controls.Add(btnClose)
		Controls.Add(btnCompare)
		Controls.Add(btnBrowse2)
		Controls.Add(btnBrowse1)
		Controls.Add(txtFile2Name)
		Controls.Add(txtFile1Name)
		FormBorderStyle = FormBorderStyle.FixedSingle
		MaximizeBox = False
		MinimizeBox = False
		Name = "frmSelectFiles"
		ShowIcon = False
		ShowInTaskbar = False
		StartPosition = FormStartPosition.CenterParent
		Text = "Select Files to Compare"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents txtFile1Name As PromptedTextBox_Net10.PromptedTextBox
	Friend WithEvents txtFile2Name As PromptedTextBox_Net10.PromptedTextBox
	Friend WithEvents btnBrowse1 As Button
	Friend WithEvents btnBrowse2 As Button
	Friend WithEvents btnCompare As Button
	Friend WithEvents btnClose As Button
End Class
