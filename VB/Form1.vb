Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen
Imports System.Threading
Imports DevExpress.XtraWaitForm

Namespace WaitForm_SetDescription
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub OnBtnShowWaitFormClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowWaitForm.Click
			'Open Wait Form
			SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
			Try
				LoadData()
			Finally
				'Close Wait Form
				SplashScreenManager.CloseForm(False)
			End Try
		End Sub
		Private Sub LoadData()
			gridControl1.DataSource = DataSource.Source
			Thread.Sleep(4000) ' fake delay
		End Sub
	End Class

	Public Class DataSource
		Private Shared source_Renamed As BindingList(Of Person) = Nothing
		Public Shared ReadOnly Property Source() As BindingList(Of Person)
			Get
				If source_Renamed Is Nothing Then
					source_Renamed = New BindingList(Of Person)()
					source_Renamed.Add(New Person("John", 10))
					source_Renamed.Add(New Person("Jane", 12))
					source_Renamed.Add(New Person("Stan", 11))
					source_Renamed.Add(New Person("Dan", 13))
					source_Renamed.Add(New Person("Molly", 25))
				End If
				Return source_Renamed
			End Get
		End Property
	End Class

	Public Class Person
		Public Sub New(ByVal name As String, ByVal age As Integer)
			Me.Name = name
			Me.Age = age
		End Sub
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
		Private privateAge As Integer
		Public Property Age() As Integer
			Get
				Return privateAge
			End Get
			Set(ByVal value As Integer)
				privateAge = value
			End Set
		End Property
	End Class

End Namespace
