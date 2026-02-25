

Public Class frmSelectFiles
	'*************************************************************

	' Select files for comparison
	' FC_SELECTFILES.VB
	' Written: February 2026
	' Programmer: Aaron Scott
	' Copyright 2026 Sirius software all rights reserved.

	' This software is made available under a "Do Anything You Want" license.

	'*************************************************************

	'*************************************************************

	' The Browse button is clicked.  Show an open file dialog.

	'*************************************************************
	Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse1.Click, btnBrowse2.Click

		Dim d As New OpenFileDialog
		d.Title = "Select File to Compare"
		d.FileName = ""
		d.Filter = "All Files (*.*)|*.*"
		If d.ShowDialog = DialogResult.OK Then
			If sender Is btnBrowse1 Then txtFile1Name.Text = d.FileName Else txtFile2Name.Text = d.FileName
		End If

		d.Dispose()

	End Sub
	'*************************************************************

	' The compare button is clicked.

	'*************************************************************
	Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub
	'*************************************************************

	' The Close button is clicked.

	'*************************************************************
	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub


End Class