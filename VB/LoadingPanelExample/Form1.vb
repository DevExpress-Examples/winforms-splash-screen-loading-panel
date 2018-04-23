Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports System.Windows.Forms

Namespace LoadingPanelExample
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private pos As Integer = 0
		Private fLoadingPanel As LoadingPanel
		Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs) Handles timer.Tick
			Select Case pos
				Case 0
					ShowLoadingPanel(listBox)
				Case 1
					ShowLoadingPanel(radioGroup)
				Case 2
					ShowLoadingPanel(picture)
				Case 3
					ShowLoadingPanel(memo)
			End Select
		End Sub

		Private Sub ShowLoadingPanel(ByVal control As Control)
			If fLoadingPanel IsNot Nothing Then
				fLoadingPanel.Dispose()
			End If
			fLoadingPanel = New LoadingPanel(control, Nothing)
			If pos = 3 Then
				pos = 0
			Else
				pos = pos + 1
			End If
		End Sub

		Private Sub OnLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			timer.Start()
		End Sub
	End Class
End Namespace