<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
		Panel1 = New Panel()
		lblTitle = New Label()
		lblVersion = New Label()
		lblCopyright = New Label()
		lblWSID = New Label()
		lblUser = New Label()
		lblExpiration = New Label()
		lblLicensee = New Label()
		btnNotes = New Button()
		lblDBVersion = New Label()
		btnClose = New Button()
		SuspendLayout()
		' 
		' Panel1
		' 
		Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
		Panel1.BackgroundImageLayout = ImageLayout.Zoom
		Panel1.Location = New Point(7, 10)
		Panel1.Name = "Panel1"
		Panel1.Size = New Size(317, 317)
		Panel1.TabIndex = 0
		' 
		' lblTitle
		' 
		lblTitle.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblTitle.Location = New Point(346, 10)
		lblTitle.Name = "lblTitle"
		lblTitle.Size = New Size(300, 23)
		lblTitle.TabIndex = 1
		lblTitle.TextAlign = ContentAlignment.MiddleCenter
		' 
		' lblVersion
		' 
		lblVersion.Location = New Point(346, 45)
		lblVersion.Name = "lblVersion"
		lblVersion.Size = New Size(300, 23)
		lblVersion.TabIndex = 2
		lblVersion.TextAlign = ContentAlignment.MiddleCenter
		' 
		' lblCopyright
		' 
		lblCopyright.Location = New Point(346, 80)
		lblCopyright.Name = "lblCopyright"
		lblCopyright.Size = New Size(300, 23)
		lblCopyright.TabIndex = 3
		lblCopyright.TextAlign = ContentAlignment.MiddleCenter
		' 
		' lblWSID
		' 
		lblWSID.Location = New Point(346, 150)
		lblWSID.Name = "lblWSID"
		lblWSID.Size = New Size(300, 23)
		lblWSID.TabIndex = 4
		lblWSID.TextAlign = ContentAlignment.MiddleCenter
		' 
		' lblUser
		' 
		lblUser.Location = New Point(346, 185)
		lblUser.Name = "lblUser"
		lblUser.Size = New Size(300, 23)
		lblUser.TabIndex = 5
		lblUser.TextAlign = ContentAlignment.MiddleCenter
		' 
		' lblExpiration
		' 
		lblExpiration.Location = New Point(346, 220)
		lblExpiration.Name = "lblExpiration"
		lblExpiration.Size = New Size(300, 23)
		lblExpiration.TabIndex = 6
		lblExpiration.TextAlign = ContentAlignment.MiddleCenter
		' 
		' lblLicensee
		' 
		lblLicensee.Location = New Point(346, 255)
		lblLicensee.Name = "lblLicensee"
		lblLicensee.Size = New Size(300, 23)
		lblLicensee.TabIndex = 7
		lblLicensee.TextAlign = ContentAlignment.MiddleCenter
		' 
		' btnNotes
		' 
		btnNotes.Location = New Point(346, 306)
		btnNotes.Name = "btnNotes"
		btnNotes.Size = New Size(125, 23)
		btnNotes.TabIndex = 8
		btnNotes.Text = "View Release Notes"
		btnNotes.UseVisualStyleBackColor = True
		' 
		' lblDBVersion
		' 
		lblDBVersion.Location = New Point(345, 115)
		lblDBVersion.Name = "lblDBVersion"
		lblDBVersion.Size = New Size(300, 23)
		lblDBVersion.TabIndex = 9
		lblDBVersion.TextAlign = ContentAlignment.MiddleCenter
		' 
		' btnClose
		' 
		btnClose.Location = New Point(520, 306)
		btnClose.Name = "btnClose"
		btnClose.Size = New Size(125, 23)
		btnClose.TabIndex = 10
		btnClose.Text = "&Close"
		btnClose.UseVisualStyleBackColor = True
		' 
		' About
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(665, 346)
		Controls.Add(btnClose)
		Controls.Add(lblDBVersion)
		Controls.Add(btnNotes)
		Controls.Add(lblLicensee)
		Controls.Add(lblExpiration)
		Controls.Add(lblUser)
		Controls.Add(lblWSID)
		Controls.Add(lblCopyright)
		Controls.Add(lblVersion)
		Controls.Add(lblTitle)
		Controls.Add(Panel1)
		Name = "About"
		StartPosition = FormStartPosition.CenterParent
		Text = "About"
		ResumeLayout(False)
	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents lblTitle As Label
	Friend WithEvents lblVersion As Label
	Friend WithEvents lblCopyright As Label
	Friend WithEvents lblWSID As Label
	Friend WithEvents lblUser As Label
	Friend WithEvents lblExpiration As Label
	Friend WithEvents lblLicensee As Label
	Friend WithEvents btnNotes As Button
	Friend WithEvents lblDBVersion As Label
	Friend WithEvents btnClose As Button
End Class
