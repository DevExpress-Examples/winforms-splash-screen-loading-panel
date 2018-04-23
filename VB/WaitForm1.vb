Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraWaitForm

Namespace WaitForm_SetDescription
	Partial Public Class WaitForm1
		Inherits WaitForm
		Public Sub New()
			InitializeComponent()
			Me.progressPanel1.AutoSize = True
		End Sub

		#Region "Overrides"

		Public Overrides Sub SetCaption(ByVal caption As String)
			MyBase.SetCaption(caption)
			Me.progressPanel1.Caption = caption
		End Sub
		Public Overrides Sub SetDescription(ByVal description As String)
			MyBase.SetDescription(description)
			Me.progressPanel1.Description = description
		End Sub
		Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
			MyBase.ProcessCommand(cmd, arg)
		End Sub

		#End Region

	End Class
End Namespace