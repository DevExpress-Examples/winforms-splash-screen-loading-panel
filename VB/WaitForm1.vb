Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraWaitForm

Namespace WaitForm_SetDescription

    Public Partial Class WaitForm1
        Inherits WaitForm

        Public Sub New()
            InitializeComponent()
            progressPanel1.AutoSize = True
        End Sub

'#Region "Overrides"
        Public Overrides Sub SetCaption(ByVal caption As String)
            MyBase.SetCaption(caption)
            progressPanel1.Caption = caption
        End Sub

        Public Overrides Sub SetDescription(ByVal description As String)
            MyBase.SetDescription(description)
            progressPanel1.Description = description
        End Sub

        Public Overrides Sub ProcessCommand(ByVal cmd As [Enum], ByVal arg As Object)
            MyBase.ProcessCommand(cmd, arg)
        End Sub

'#End Region
        Public Enum WaitFormCommand
        End Enum
    End Class
End Namespace
