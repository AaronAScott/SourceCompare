Public Class frmMain
	'*************************************************************

	' Main Form
	' SC_MAIN.VB
	' Written: February 2026
	' Programmer: Aaron Scott
	' Copyright 2026 Sirius software all rights reserved.

	' This software is made available under a "Do Anything You Want" license.

	'*************************************************************

	Private LeftPanel As DiffPanel
	Private RightPanel As DiffPanel
	Private L(,) As Integer
	Private File1Length As Integer
	Private File2Length As Integer
	Private File1Lines() As String
	Private File2Lines() As String
	Private Diff() As String
	Private fT As New Font("Courier New", 10)

	'*************************************************************

	' The form is loaded.

	'*************************************************************
	Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

		' Create a left and right DiffPanel and add them to the
		' splitcontainer's left and right panels.

		LeftPanel = New DiffPanel
		LeftPanel.ShowInserts = True ' The left panel will only show lines marked as insertions.
		LeftPanel.Location = New Point(0, lblPane1.Height + 1)
		LeftPanel.Size = New Size(SplitContainer1.Panel1.Width, SplitContainer1.Panel1.Height - lblPane1.Height - HScrollBar1.Height)
		LeftPanel.Font = fT
		SplitContainer1.Panel1.Controls.Add(LeftPanel)

		RightPanel = New DiffPanel
		RightPanel.ShowDeletes = True ' The right panel will only show lines marked a deletions.
		RightPanel.Location = New Point(0, lblPane2.Height + 1)
		RightPanel.Size = New Size(SplitContainer1.Panel2.Width, SplitContainer1.Panel2.Height - lblPane2.Height - HScrollBar2.Height)
		LeftPanel.Font = fT
		RightPanel.Font = fT
		SplitContainer1.Panel2.Controls.Add(RightPanel)

		' Set the font size for our replacement MsgBox.

		MsgBoxTheme.FontSize = 12 ' Configure messagebox

		' Now that we've created the DiffPanels, we can safely connect
		' the event handlers for the split container events.

		AddHandler SplitContainer1.Resize, AddressOf SplitContainer1_Resize
		AddHandler SplitContainer1.SplitterMoved, AddressOf SplitContainer1_SplitterMoved

		' Set the program name

		ProgramName = "Source Compare"
		ProgramPath = Application.ExecutablePath

	End Sub
	'*************************************************************

	' The form is closed.

	'*************************************************************
	Private Sub frmMain_Closed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

		' Remove the handlers for the split containers.

		RemoveHandler SplitContainer1.Resize, AddressOf SplitContainer1_Resize
		RemoveHandler SplitContainer1.SplitterMoved, AddressOf SplitContainer1_SplitterMoved

	End Sub
	'*************************************************************

	' The Select Files menu option is clicked.

	'*************************************************************
	Private Sub mnuSelect_Click(sender As Object, e As EventArgs) Handles mnuSelect.Click

		' Show the select files dialog and test the result.

		If frmSelectFiles.ShowDialog() = DialogResult.OK Then

			' Display the file names.

			lblPane1.Text = frmSelectFiles.txtFile1Name.Text
			lblPane2.Text = frmSelectFiles.txtFile2Name.Text

			' Compare the two files.

			CompareFiles()

		End If

	End Sub
	'*************************************************************

	' The Exit menu option is clicked.

	'*************************************************************
	Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
		Me.Close()
	End Sub
	'*************************************************************

	' The About File Compare menu option is clicked.

	'*************************************************************
	Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
		About.ShowDialog()
	End Sub
	'*************************************************************

	' One of the horizontal scroll bars is moved.

	'*************************************************************
	Private Sub HScrollBar_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll, HScrollBar2.Scroll

		' Remove handlers to prevent cascading events.

		RemoveHandler HScrollBar1.Scroll, AddressOf HScrollBar_Scroll
		RemoveHandler HScrollBar2.Scroll, AddressOf HScrollBar_Scroll

		' Determine which scroll bar was moved and sync the other.

		If sender Is HScrollBar1 Then
			HScrollBar2.Value = HScrollBar1.Value
		Else
			HScrollBar1.Value = HScrollBar2.Value
		End If

		' Set the LeftIndex property of the two DiffPanels,
		' and force them to redraw.

		LeftPanel.LeftIndex = HScrollBar1.Value
		RightPanel.LeftIndex = HScrollBar2.Value
		LeftPanel.Invalidate()
		RightPanel.Invalidate()

		' Reconnect the handlers.

		AddHandler HScrollBar1.Scroll, AddressOf HScrollBar_Scroll
		AddHandler HScrollBar2.Scroll, AddressOf HScrollBar_Scroll

	End Sub
	'*************************************************************

	' The vertical scroll bar has moved.

	'*************************************************************
	Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll

		' Set the TopIndex property of the two DiffPanels,
		' and force them to redraw.

		LeftPanel.TopIndex = VScrollBar1.Value
		RightPanel.TopIndex = VScrollBar1.Value
		LeftPanel.Invalidate()
		RightPanel.Invalidate()

	End Sub
	'*************************************************************

	' Event handler for the SplitContainer resize event.
	' This is attached at run time.

	'*************************************************************
	Private Sub SplitContainer1_Resize(sender As Object, e As EventArgs)

		LeftPanel.Size = New Size(SplitContainer1.Panel1.Width, SplitContainer1.Panel1.Height - lblPane1.Height - HScrollBar1.Height)
		RightPanel.Size = New Size(SplitContainer1.Panel2.Width, SplitContainer1.Panel2.Height - lblPane2.Height - HScrollBar2.Height)

	End Sub
	'*************************************************************

	' Event handler for the SplitContainer splittermoved event.
	' This is attached at run time.

	'*************************************************************
	Private Sub SplitContainer1_SplitterMoved(sender As Object, e As EventArgs)

		LeftPanel.Size = New Size(SplitContainer1.Panel1.Width, SplitContainer1.Panel1.Height - lblPane1.Height - HScrollBar1.Height)
		RightPanel.Size = New Size(SplitContainer1.Panel2.Width, SplitContainer1.Panel2.Height - lblPane2.Height - HScrollBar2.Height)

	End Sub
	'*************************************************************

	' Sub to compare two files: the workhorse of the program.

	'*************************************************************
	Private Sub CompareFiles()

		' Read in the two files to be compared.

		ReadAndPreprocess()

		' Build the Longest Common Subsequence table, which
		' maps the differences between files.

		BuildLCSLengthTable()

		If File1Length = File2Length AndAlso L(File1Length, File2Length) = File1Length Then

			' Files are identical
			MsgBox("The two files are indentical.", MsgBoxStyle.Information, "File Compare")

		ElseIf L(File1Length, File2Length) = 0 Then

			MsgBox("The two files contain no matching lines.", MsgBoxStyle.Information, "File Compare")

		Else

			' Files differ — show the diff
			ExtractDiffSequence()
			DisplayCompare()

		End If
	End Sub
	'*************************************************************

	' Sub to read in the two files to be compared.

	'*************************************************************
	Private Sub ReadAndPreprocess()

		' Declare variables.

		Dim zx As String

		' Extract all lines from File1. Convert all possible
		' line ends (Cr, CrLf, Lf) to Lf so we can be sure
		' where to split the lines.

		Try
			zx = My.Computer.FileSystem.ReadAllText(lblPane1.Text)
			File1Lines = zx.Replace(vbCrLf, vbLf).Replace(vbCr, vbLf).Split(vbLf)
		Catch ex As Exception
			MsgBox("Error opening file '" & lblPane1.Text & "'." & vbCrLf & ex.Message, MsgBoxStyle.Information, "File Compare")
		End Try

		' Extract all lines from File2.

		Try
			zx = My.Computer.FileSystem.ReadAllText(lblPane2.Text)
			File2Lines = zx.Replace(vbCrLf, vbLf).Replace(vbCr, vbLf).Split(vbLf)
		Catch ex As Exception
			MsgBox("Error opening file '" & lblPane2.Text & "'." & vbCrLf & ex.Message, MsgBoxStyle.Information, "File Compare")
		End Try

		' Get the lengths of each file.

		File1Length = File1Lines.Length
		File2Length = File2Lines.Length


	End Sub
	'*************************************************************

	' Sub to build the Longest Common Subsequence table, which
	' maps where the two compared files differ.

	' If you can understand this algorithm, congratulations!
	' I coded it; I don't pretend to understand it.

	'*************************************************************
	Private Sub BuildLCSLengthTable()

		' Declare variables

		Dim i As Integer
		Dim j As Integer
		ReDim L(File1Length + 1, File2Length + 1)

		' Initialize length tables.

		For i = 0 To File1Length
			L(i, 0) = 0
		Next i

		For j = 0 To File2Length
			L(0, j) = 0
		Next j

		' What this section does
		' It fills in the dynamic‑programming table  by comparing every line of File 1 against
		' every line of File 2 And computing the length of the longest common subsequence up to each point.
		' Think of it as building a topographic map of “how similar the files are so far.”

		' • 	Walk through the DP table row by row.
		' • 	 i corresponds to line i-1 of File 1.
		' • 	 j corresponds to line j-1 of File 2.
		' • 	We start at 1 because row 0 And column 0 are the padded base cases.

		For i = 1 To File1Length
			For j = 1 To File2Length

				' If the current lines match, we’ve extended the common subsequence by one matching line.

				If File1Lines(i - 1) = File2Lines(j - 1) Then
					L(i, j) = L(i - 1, j - 1) + 1

					'If the lines don't match, the LCS up to this point is the longer of:
					'• 	the LCS without File 1's current line (), or
					'• 	the LCS without File 2's current line ()
					'This propagates the “best so far” value across the table.	
				Else
					L(i, j) = Math.Max(L(i - 1, j), L(i, j - 1))
				End If
			Next j
		Next i


	End Sub
	'*************************************************************

	' Sub to extract the differing lines using the LCS table.
	' Each line is added to our table of lines with a prefix
	' that indicates if the lines match, or if one is an insert
	' or a delete.  These depend on which file is which.  This
	' program assumes the newer file (on the left viewport)shows
	' inserted lines, and the older file shows deleted lines.

	'*************************************************************
	Private Sub ExtractDiffSequence()

		' Declare variables

		Dim i As Integer = File1Length
		Dim j As Integer = File2Length
		Dim FirstLineIndex As Integer
		ReDim Diff(File1Length + File2Length)
		Dim Idx As Integer = Diff.Length - 1

		Debug.WriteLine($"Starting at L({i},{j}) = {L(i, j)}")
		Debug.WriteLine($"Expected LCS length = {L(File1Lines.Length, File2Lines.Length)}")
		' Work backward through the LCS table, determining which lines are matches,
		' inserts (shown on the left panel) or deletions (shown on the right panel).

		Do While i > 0 Or j > 0
			If i > 0 And j > 0 AndAlso File1Lines(i - 1) = File2Lines(j - 1) Then
				Diff(Idx) = "MATCH—" & File1Lines(i - 1)
				i -= 1
				j -= 1
				Idx -= 1
			ElseIf j > 0 AndAlso (i = 0 OrElse L(i, j - 1) > L(i - 1, j)) Then
				Diff(Idx) = "DELETE—" & File2Lines(j - 1)
				j -= 1
				Idx -= 1
			Else
				Diff(Idx) = "INSERT—" & File1Lines(i - 1)
				i -= 1
				Idx -= 1

			End If
		Loop

		' Since the Diff array fills from the bottom up, we need to find
		' where the lines actually begin.

		For i = 0 To Diff.Length - 1
			If Diff(i) <> "" Then
				FirstLineIndex = i
				Exit For
			End If
		Next i

		' Set the vertical scrollbar's maximum to allow the last line of the
		' differences to appear at the top of the viewport.

		VScrollBar1.Maximum = Diff.Length - FirstLineIndex

	End Sub
	'*************************************************************

	' Sub to show the compared files.

	'*************************************************************
	Private Sub DisplayCompare()

		' Assign the list of lines marked as matches, insertions
		' or deletions, to each of the two panels.  The "ShowInserts"
		' and "ShowDeletes" properties will determine which they display, but
		' both panels show matches.

		LeftPanel.TextLines = Diff
		RightPanel.TextLines = Diff

		' Force the panels to redraw.

		LeftPanel.Invalidate()
		RightPanel.Invalidate()
	End Sub

End Class

