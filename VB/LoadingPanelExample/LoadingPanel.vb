Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors

Namespace LoadingPanelExample
	Public Class LoadingPanel
		Inherits MarqueeProgressBarControl
		Private fParent As Control

        Public Sub New(ByVal _parent As Control, ByVal _lookAndFeel As UserLookAndFeel)
            MyBase.New()
            If _lookAndFeel IsNot Nothing Then
                LookAndFeel.Assign(_lookAndFeel)
            ElseIf TypeOf parent Is ISupportLookAndFeel Then
                LookAndFeel.Assign(CType(_parent, ISupportLookAndFeel).LookAndFeel)
            End If
            Location = New Point(_parent.Location.X + _parent.Width / 4, _parent.Location.Y + _parent.Height / 3)
            Width = _parent.Width / 2
            Height = _parent.Height / 3
            Parent = _parent.FindForm()
            BringToFront()
            _parent.Enabled = False
            fParent = _parent
        End Sub

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			MyBase.Dispose(disposing)
			If fParent IsNot Nothing AndAlso disposing Then
				fParent.Enabled = True
			End If
		End Sub
	End Class
End Namespace