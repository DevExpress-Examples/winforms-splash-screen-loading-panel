Imports Microsoft.VisualBasic
Imports System
Namespace WaitForm_SetDescription
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
			Me.btnShowWaitForm = New DevExpress.XtraEditors.SimpleButton()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' btnShowWaitForm
			' 
			Me.btnShowWaitForm.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnShowWaitForm.Location = New System.Drawing.Point(694, 9)
			Me.btnShowWaitForm.Name = "btnShowWaitForm"
			Me.btnShowWaitForm.Size = New System.Drawing.Size(128, 31)
			Me.btnShowWaitForm.TabIndex = 0
			Me.btnShowWaitForm.Text = "Show Wait Form"
'			Me.btnShowWaitForm.Click += New System.EventHandler(Me.OnBtnShowWaitFormClick);
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.gridControl1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(825, 280)
			Me.panelControl1.TabIndex = 2
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(825, 280)
			Me.gridControl1.TabIndex = 2
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl2.Controls.Add(Me.btnShowWaitForm)
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl2.Location = New System.Drawing.Point(0, 280)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(825, 47)
			Me.panelControl2.TabIndex = 2
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(825, 327)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.panelControl2)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents btnShowWaitForm As DevExpress.XtraEditors.SimpleButton
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace

