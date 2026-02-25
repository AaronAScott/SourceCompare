Imports System.ComponentModel

Public Class DiffPanel
	'*************************************************************

	' The DiffPanel class
	' DIFFPANEL.VB
	' Written: February 2026
	' Programmer: Aaron Scott
	' Copyright 2026 Sirius software all rights reserved.

	' This software is made available under a "Do Anything You Want" license.

	'*************************************************************

	Inherits Panel

	' Declare local variables.

	Dim mShowInserts As Boolean = True
	Dim mShowDeletes As Boolean = False
	Dim PanelHeight As Integer
	Dim PanelWidth As Integer
	Dim LineHeight As Integer
	Dim CharacterWidth As Integer
	Dim FirstLineIndex As Integer = -1
	Dim yy As Integer = 0
	Dim DisplayLines() As String
	Dim fT As Font

	' Declare public properties.  These are used to scroll the text in the panel.

	<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
	Public Property TopIndex As Integer  ' First line to display in panel
	<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
	Public Property LeftIndex As Integer ' First character to display in line.


	'*************************************************************

	' The class constructor.  Set initial properties.

	'*************************************************************
	Public Sub New()

		Me.DoubleBuffered = True
		Me.Font = New Font("Courier New", 10)
		fT = Me.Font
		CharacterWidth = TextRenderer.MeasureText("X", fT).Width

	End Sub

	'*************************************************************

	' Replacement for the PaintBackground event.

	'*************************************************************
	Protected Overrides Sub OnPaintBackground(pevent As PaintEventArgs)
		pevent.Graphics.Clear(Color.Beige)
	End Sub

	'*************************************************************

	' Replacement for the Resize event

	'*************************************************************
	Protected Overrides Sub OnResize(eventargs As EventArgs)
		MyBase.OnResize(eventargs)
		PanelHeight = Me.Height
		PanelWidth = Me.ClientRectangle.Width
		Me.Invalidate()
	End Sub

	'*************************************************************

	' Replacement for the Paint event.

	'*************************************************************
	Protected Overrides Sub OnPaint(e As PaintEventArgs)
		MyBase.OnPaint(e)

		' If the TextLines property has not yet been set, do nothing.

		If TextLines Is Nothing Then Exit Sub

		' Declare variables

		Dim ii As Integer
		Dim p() As String
		Dim g As Graphics = e.Graphics

		yy = 0

		' Determine the first non-blank line in the array of differences.
		' This array is filled from the bottom up, so we have to determine
		' where the list begins.

		If FirstLineIndex < 0 Then
			For ii = 0 To DisplayLines.Length - 1
				If DisplayLines(ii) <> "" Then
					FirstLineIndex = ii
					Exit For
				End If
			Next ii
		End If

		' Get the line height.

		LineHeight = fT.GetHeight

		' Get the panel width

		PanelWidth = Me.ClientRectangle.Width

		' draw visible lines for THIS panel

		For ii = FirstLineIndex + TopIndex To DisplayLines.Count - 1

			' Get operator and line.

			p = Split(DisplayLines(ii), "—")

			' Protect against insanely-long lines the GDI just can't handle:

			If p(1).Length > 4096 Then p(1) = p(1).Substring(0, 4096)

			' Check the length of the line so as to not trigger an error
			' when scolling horizontally.

			If p(1).Length > LeftIndex Then

				' Determine what kind of line we are to draw.

				Select Case p(0)
					Case "MATCH"
						g.DrawString(p(1).Substring(LeftIndex), fT, Brushes.Black, 0, yy)
					Case "INSERT"
						If mShowInserts Then g.DrawString(p(1).Substring(LeftIndex), fT, Brushes.Green, 0, yy)
					Case "DELETE"
						If mShowDeletes Then g.DrawString(p(1).Substring(LeftIndex), fT, Brushes.Red, 0, yy)
				End Select
			End If
			yy += LineHeight
		Next ii

	End Sub
	'*************************************************************

	' The TextLines property contains the list of lines
	' we are to display.

	'*************************************************************
	<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
	Public Property TextLines() As String()
		Get
			Return DisplayLines
		End Get
		Set(value() As String)
			DisplayLines = value
		End Set
	End Property
	'*************************************************************

	' The ShowInserts property causes this panel to show inserted
	' lines, but not deleted lines.  Mutually exclusive with
	' ShowDeletes, so turning one on turns the other off.

	'*************************************************************
	<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
	Public Property ShowInserts() As Boolean
		Get
			Return mShowInserts
		End Get
		Set(value As Boolean)
			mShowInserts = value
			mShowDeletes = Not value
		End Set
	End Property

	'*************************************************************

	' The ShowDeletes property causes this panel to show deleted
	' lines, but not inserted lines.  Mutually exclusive with
	' ShowInserts, so turning one on turns the other off.

	'*************************************************************
	<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
	Public Property ShowDeletes() As Boolean
		Get
			Return mShowDeletes
		End Get
		Set(value As Boolean)
			mShowDeletes = value
			mShowInserts = Not value
		End Set
	End Property
End Class
