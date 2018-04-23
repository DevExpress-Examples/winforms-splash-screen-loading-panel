Imports Microsoft.VisualBasic
Imports System
Namespace LoadingPanelExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.listBox = New DevExpress.XtraEditors.ListBoxControl()
			Me.picture = New DevExpress.XtraEditors.PictureEdit()
			Me.radioGroup = New DevExpress.XtraEditors.RadioGroup()
			Me.memo = New DevExpress.XtraEditors.MemoEdit()
			Me.timer = New System.Windows.Forms.Timer(Me.components)
			CType(Me.listBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.picture.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.memo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' listBox
			' 
			Me.listBox.Location = New System.Drawing.Point(12, 12)
			Me.listBox.LookAndFeel.SkinName = "Money Twins"
			Me.listBox.LookAndFeel.UseDefaultLookAndFeel = False
			Me.listBox.Name = "listBox"
			Me.listBox.Size = New System.Drawing.Size(493, 487)
			Me.listBox.TabIndex = 0
			' 
			' picture
			' 
			Me.picture.Location = New System.Drawing.Point(172, 507)
			Me.picture.Name = "picture"
			Me.picture.Properties.LookAndFeel.SkinName = "The Asphalt World"
			Me.picture.Properties.LookAndFeel.UseDefaultLookAndFeel = False
			Me.picture.Size = New System.Drawing.Size(100, 96)
			Me.picture.TabIndex = 1
			' 
			' radioGroup
			' 
			Me.radioGroup.Location = New System.Drawing.Point(529, 12)
			Me.radioGroup.Name = "radioGroup"
			Me.radioGroup.Properties.LookAndFeel.SkinName = "Lilian"
			Me.radioGroup.Properties.LookAndFeel.UseDefaultLookAndFeel = False
			Me.radioGroup.Size = New System.Drawing.Size(252, 179)
			Me.radioGroup.TabIndex = 2
			' 
			' memo
			' 
			Me.memo.Location = New System.Drawing.Point(543, 275)
			Me.memo.Name = "memo"
			Me.memo.Properties.LookAndFeel.SkinName = "iMaginary"
			Me.memo.Properties.LookAndFeel.UseDefaultLookAndFeel = False
			Me.memo.Size = New System.Drawing.Size(368, 293)
			Me.memo.TabIndex = 3
			' 
			' timer
			' 
			Me.timer.Interval = 3000
'			Me.timer.Tick += New System.EventHandler(Me.OnTimerTick);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(969, 615)
			Me.Controls.Add(Me.memo)
			Me.Controls.Add(Me.radioGroup)
			Me.Controls.Add(Me.picture)
			Me.Controls.Add(Me.listBox)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.OnLoad);
			CType(Me.listBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.picture.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.memo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private listBox As DevExpress.XtraEditors.ListBoxControl
		Private picture As DevExpress.XtraEditors.PictureEdit
		Private radioGroup As DevExpress.XtraEditors.RadioGroup
		Private memo As DevExpress.XtraEditors.MemoEdit
		Private WithEvents timer As System.Windows.Forms.Timer

	End Class
End Namespace

