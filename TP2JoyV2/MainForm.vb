'
' Created by SharpDevelop.
' User: Ahmed El-Hajjar
' Date: 11/7/2013
' Time: 13:33
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Dim ModeEnabled As Boolean = False
	
	Dim VJoyHandler As New VJoyHandler()	
	Dim PointerInfo As New PointerInfo()
	Dim CursorHandle As New Cursor(Cursor.Current.Handle)
	
	Public Sub New()
		Me.InitializeComponent()
	End Sub
	
	Sub PointerTimerTick(sender As Object, e As EventArgs)
		' Update Pointer Information
		PointerInfo.Update(CursorHandle)
	End Sub
	
	Sub JoystickTimerTick(sender As Object, e As EventArgs)
		'F10 toggles this tool
		If GetKeyPress(Keys.F10) Then
			ModeEnabled = Not ModeEnabled
			chkEnabled.Checked = ModeEnabled
		End If
		
		If ModeEnabled Then
			' Update X and Y Axis based on Position
			VJoyHandler.SetXAxis(PointerInfo.CalculateXAxis(CursorHandle))
			VJoyHandler.SetYAxis(PointerInfo.CalculateYAxis(CursorHandle))
			
			' Put Pointer Back in Center of Screen
			CursorHandle.Position = PointerInfo.CalculateCenterPoint()
		End If
	End Sub
		
	Private Declare Function GetKeyPress Lib "user32" Alias "GetAsyncKeyState" (ByVal key As Integer) As Integer	
End Class
