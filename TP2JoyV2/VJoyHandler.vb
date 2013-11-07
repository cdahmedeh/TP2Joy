'
' Created by SharpDevelop.
' User: Ahmed El-Hajjar
' Date: 11/7/2013
' Time: 14:34
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Class VJoyHandler
	Private VJoy As VJoy
	
	Public Sub New()
		' Initialize VJoy Handling		
		VJoy = New VJoy()
        VJoy.Initialize()
        VJoy.Reset()
        VJoy.Update(0)
        VJoy.Update(1)
	End Sub
	
	Public Sub SetXAxis(Value As Short)		
		VJoy.SetXAxis(0, Value)
		VJoy.Update(0)
	End Sub
	
	Public Sub SetYAxis(Value As Short)
		VJoy.SetYAxis(0, Value)
		VJoy.Update(0)
	End Sub
End Class
