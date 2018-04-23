Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo

Namespace ButtonEditWithPadding
	Friend Class PaddingButtonEditViewInfo
		Inherits ButtonEditViewInfo
		Public Sub New(ByVal item As RepositoryItem)
			MyBase.New(item)
		End Sub

		Public Function AdjustBoundsWithMargins(ByVal boundsToAdjust As Rectangle) As Rectangle
			boundsToAdjust.X += (CType(Item, RepositoryItemPaddingButtonEdit)).Padding.Left
			boundsToAdjust.Y += (CType(Item, RepositoryItemPaddingButtonEdit)).Padding.Top
			boundsToAdjust.Width -= (CType(Item, RepositoryItemPaddingButtonEdit)).Padding.Right * 2
			boundsToAdjust.Height -= (CType(Item, RepositoryItemPaddingButtonEdit)).Padding.Bottom * 2

			Return boundsToAdjust
		End Function
		Public Function RevertMarginedBounds(ByVal boundsToRevert As Rectangle) As Rectangle
			boundsToRevert.X -= (CType(Item, RepositoryItemPaddingButtonEdit)).Padding.Left
			boundsToRevert.Y -= (CType(Item, RepositoryItemPaddingButtonEdit)).Padding.Top
			boundsToRevert.Width += (CType(Item, RepositoryItemPaddingButtonEdit)).Padding.Right * 2
			boundsToRevert.Height += (CType(Item, RepositoryItemPaddingButtonEdit)).Padding.Bottom * 2

			Return boundsToRevert
		End Function

		Protected Overrides Sub OnBeforeButtonStateChanged(ByVal info As EditorButtonObjectInfoArgs, ByVal newState As ObjectState, ByVal buttonId As Integer)
			If TypeOf Item Is RepositoryItemPaddingButtonEdit Then
				info.Bounds = AdjustBoundsWithMargins(info.Bounds)

				MyBase.OnBeforeButtonStateChanged(info, newState, buttonId)
				info.Bounds = RevertMarginedBounds(info.Bounds)
			Else
				MyBase.OnBeforeButtonStateChanged(info, newState, buttonId)
			End If
		End Sub
	End Class
End Namespace