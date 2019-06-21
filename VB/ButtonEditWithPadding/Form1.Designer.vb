Namespace ButtonEditWithPadding
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
			Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
			Me.paddingButtonEdit1 = New ButtonEditWithPadding.PaddingButtonEdit()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.repositoryItemPaddingButtonEdit1 = New ButtonEditWithPadding.RepositoryItemPaddingButtonEdit()
			Me.repositoryItemPaddingButtonEdit2 = New ButtonEditWithPadding.RepositoryItemPaddingButtonEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.paddingButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPaddingButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPaddingButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' spinEdit1
			' 
			Me.spinEdit1.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEdit1.Location = New System.Drawing.Point(361, 12)
			Me.spinEdit1.Name = "spinEdit1"
			Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.spinEdit1.Properties.Mask.EditMask = "d"
			Me.spinEdit1.Size = New System.Drawing.Size(100, 20)
			Me.spinEdit1.TabIndex = 0
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.spinEdit1.EditValueChanged += new System.EventHandler(this.spinEdit1_EditValueChanged);
			' 
			' paddingButtonEdit1
			' 
			Me.paddingButtonEdit1.Location = New System.Drawing.Point(12, 12)
			Me.paddingButtonEdit1.Name = "paddingButtonEdit1"
			Me.paddingButtonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {
				New DevExpress.XtraEditors.Controls.EditorButton(),
				New DevExpress.XtraEditors.Controls.EditorButton()
			})
			Me.paddingButtonEdit1.Properties.Padding = New System.Windows.Forms.Padding(0)
			Me.paddingButtonEdit1.Size = New System.Drawing.Size(151, 20)
			Me.paddingButtonEdit1.TabIndex = 2
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.gridControl1.Location = New System.Drawing.Point(0, 38)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPaddingButtonEdit1, Me.repositoryItemPaddingButtonEdit2})
			Me.gridControl1.Size = New System.Drawing.Size(473, 407)
			Me.gridControl1.TabIndex = 3
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
            'Me.gridView1.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
            ' 
            ' repositoryItemPaddingButtonEdit1
            ' 
            Me.repositoryItemPaddingButtonEdit1.AutoHeight = False
			Me.repositoryItemPaddingButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemPaddingButtonEdit1.Name = "repositoryItemPaddingButtonEdit1"
			Me.repositoryItemPaddingButtonEdit1.Padding = New System.Windows.Forms.Padding(0)
			' 
			' repositoryItemPaddingButtonEdit2
			' 
			Me.repositoryItemPaddingButtonEdit2.AutoHeight = False
			Me.repositoryItemPaddingButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {
				New DevExpress.XtraEditors.Controls.EditorButton(),
				New DevExpress.XtraEditors.Controls.EditorButton()
			})
			Me.repositoryItemPaddingButtonEdit2.Name = "repositoryItemPaddingButtonEdit2"
			Me.repositoryItemPaddingButtonEdit2.Padding = New System.Windows.Forms.Padding(0)
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(284, 15)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(71, 13)
			Me.labelControl1.TabIndex = 4
			Me.labelControl1.Text = "Padding value:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(473, 445)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.paddingButtonEdit1)
			Me.Controls.Add(Me.spinEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.paddingButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPaddingButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPaddingButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents spinEdit1 As DevExpress.XtraEditors.SpinEdit
		Private paddingButtonEdit1 As PaddingButtonEdit
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private repositoryItemPaddingButtonEdit1 As RepositoryItemPaddingButtonEdit
		Private repositoryItemPaddingButtonEdit2 As RepositoryItemPaddingButtonEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace

