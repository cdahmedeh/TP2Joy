'
' Created by SharpDevelop.
' User: Ahmed El-Hajjar
' Date: 11/7/2013
' Time: 13:33
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.pointerTimer = New System.Windows.Forms.Timer(Me.components)
		Me.joystickTimer = New System.Windows.Forms.Timer(Me.components)
		Me.chkEnabled = New System.Windows.Forms.CheckBox()
		Me.SuspendLayout
		'
		'pointerTimer
		'
		Me.pointerTimer.Enabled = true
		Me.pointerTimer.Interval = 10
		AddHandler Me.pointerTimer.Tick, AddressOf Me.PointerTimerTick
		'
		'joystickTimer
		'
		Me.joystickTimer.Enabled = true
		Me.joystickTimer.Interval = 125
		AddHandler Me.joystickTimer.Tick, AddressOf Me.JoystickTimerTick
		'
		'chkEnabled
		'
		Me.chkEnabled.Enabled = false
		Me.chkEnabled.Location = New System.Drawing.Point(13, 13)
		Me.chkEnabled.Name = "chkEnabled"
		Me.chkEnabled.Size = New System.Drawing.Size(104, 24)
		Me.chkEnabled.TabIndex = 0
		Me.chkEnabled.Text = "Enabled"
		Me.chkEnabled.UseVisualStyleBackColor = true
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(191, 47)
		Me.Controls.Add(Me.chkEnabled)
		Me.Name = "MainForm"
		Me.Text = "TP2JoyV2"
		Me.ResumeLayout(false)
	End Sub
	Private chkEnabled As System.Windows.Forms.CheckBox
	Private joystickTimer As System.Windows.Forms.Timer
	Private pointerTimer As System.Windows.Forms.Timer
End Class
