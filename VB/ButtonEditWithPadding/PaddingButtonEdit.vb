Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing

Namespace ButtonEditWithPadding
	Public Class PaddingButtonEdit
		Inherits ButtonEdit
		Shared Sub New()
			RepositoryItemPaddingButtonEdit.Register()
		End Sub
		Public Sub New()
		End Sub

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemPaddingButtonEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemPaddingButtonEdit)
			End Get
		End Property

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemPaddingButtonEdit.EditorName
			End Get
		End Property


		Protected Overrides Sub OnClickButton(ByVal buttonInfo As EditorButtonObjectInfoArgs)
			ShowPopupForm()
			MyBase.OnClickButton(buttonInfo)
		End Sub
		Protected Overridable Sub ShowPopupForm()
			Using form As New Form()
				form.StartPosition = FormStartPosition.Manual
				form.Location = Me.PointToScreen(New Point(0, Height))
				form.ShowDialog()
			End Using
		End Sub
	End Class
End Namespace
