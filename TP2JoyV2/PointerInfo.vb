'
' Created by SharpDevelop.
' User: Ahmed El-Hajjar
' Date: 11/7/2013
' Time: 14:56
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Class PointerInfo
	Public CursorX As Integer = 0
	Public CursorY As Integer = 0
	Public ScreenHeight As Integer = 0
	Public ScreenWidth As Integer = 0
	Public ScreenMinDimension As Integer = 0
	Public CursorXCenter As Integer = 0
	Public CursorYCenter As Integer = 0
	
	Public Sub New()
		ScreenHeight = Screen.PrimaryScreen.Bounds.Height
		ScreenWidth = Screen.PrimaryScreen.Bounds.Width
		
		ScreenMinDimension = Math.Min(ScreenWidth, ScreenHeight)
	End Sub
	
	Public Sub Update(Cursor As Cursor)
		CursorX = Cursor.Position.X
		CursorY = Cursor.Position.Y
		
		CursorXCenter = Cursor.Position.X - ScreenWidth/2
		CursorYCenter = Cursor.Position.Y - ScreenHeight/2
	End Sub
	
	Public Function CalculateCenterPoint As Point
		Return New Point(ScreenWidth/2, ScreenHeight/2)
	End Function
	
	Public Function CalculateXAxis(Cursor As Cursor) As Short
		Dim XAxisNormalized = 2 * CursorXCenter/ScreenMinDimension * Short.MaxValue
		Dim XAxis As Short = Math.Max(Short.MinValue, Math.Min(Short.MaxValue, XAxisNormalized))
		Return XAxis
	End Function
	
	Public Function CalculateYAxis(Cursor As Cursor) As Short
		Dim YAxisNormalized = 2 * CursorYCenter/ScreenMinDimension * Short.MaxValue
		Dim YAxis As Short = Math.Max(Short.MinValue, Math.Min(Short.MaxValue, YAxisNormalized))
		Return YAxis
	End Function
End Class
