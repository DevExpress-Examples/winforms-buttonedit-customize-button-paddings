Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace ButtonEditWithPadding
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.carsTableAdapter.Fill(Me.carsDBDataSet.Cars)
		End Sub

		Private Sub spinEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinEdit1.EditValueChanged
			Dim buttonPadding As New Padding(Convert.ToInt32((CType(sender, SpinEdit)).EditValue))

			paddingButtonEdit1.Properties.Padding = buttonPadding
			CType(gridView1.Columns(0).ColumnEdit, RepositoryItemPaddingButtonEdit).Padding = buttonPadding
			CType(gridView1.Columns(1).ColumnEdit, RepositoryItemPaddingButtonEdit).Padding = buttonPadding
		End Sub
	End Class
End Namespace
