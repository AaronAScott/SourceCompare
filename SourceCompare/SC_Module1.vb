Module SC_Module1


	Public ProgramName As String
	Public ProgramPath As String
	Public UserName As String
	Public DBVersion As String
	Public LicenseInfo As String


	'***************************************************************************
	'
	' Function to return the workstation ID, used for networking applications.
	' Input : None
	' Output: workstation ID 001-999.  If none is defined, "001" is the default
	'
	'***************************************************************************
	Public Function WSID() As String

		' Declare variables

		Dim zx As String

		zx = System.Environment.GetEnvironmentVariable("WSID", EnvironmentVariableTarget.User)
		If zx <> "" Then
			If Val(zx) > 0 Then
				zx = "000" & zx
				zx = zx.Substring(zx.Length - 3, 3)
			Else
				zx = "001"
			End If
			Return zx
		Else
			Return "001"
		End If

	End Function
End Module
