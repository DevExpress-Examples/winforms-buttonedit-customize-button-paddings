Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository

Namespace ButtonEditWithPadding
	<UserRepositoryItem("Register")> _
	Public Class RepositoryItemPaddingButtonEdit
		Inherits RepositoryItemButtonEdit
		Friend Const EditorName As String = "PaddingButtonEdit"
		Private _padding As Padding

		Shared Sub New()
			Register()
		End Sub
		Public Sub New()
		End Sub

		Public Shared Sub Register()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(PaddingButtonEdit), GetType(RepositoryItemPaddingButtonEdit), GetType(PaddingButtonEditViewInfo), New PaddingButtonEditPainter(), True))
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property
		Public Property Padding() As Padding
			Get
				Return _padding
			End Get
			Set(ByVal value As Padding)
				_padding = value
				Me.OnPropertiesChanged()
			End Set
		End Property
	End Class
End Namespace