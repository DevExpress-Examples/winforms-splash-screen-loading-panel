Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen
Imports System.Threading

Namespace WaitForm_SetDescription

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub OnBtnShowWaitFormClick(ByVal sender As Object, ByVal e As EventArgs)
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

        Private Shared sourceField As BindingList(Of Person) = Nothing

        Public Shared ReadOnly Property Source As BindingList(Of Person)
            Get
                If sourceField Is Nothing Then
                    sourceField = New BindingList(Of Person)()
                    Call sourceField.Add(New Person("John", 10))
                    Call sourceField.Add(New Person("Jane", 12))
                    Call sourceField.Add(New Person("Stan", 11))
                    Call sourceField.Add(New Person("Dan", 13))
                    Call sourceField.Add(New Person("Molly", 25))
                End If

                Return sourceField
            End Get
        End Property
    End Class

    Public Class Person

        Public Sub New(ByVal name As String, ByVal age As Integer)
            Me.Name = name
            Me.Age = age
        End Sub

        Public Property Name As String

        Public Property Age As Integer
    End Class
End Namespace
