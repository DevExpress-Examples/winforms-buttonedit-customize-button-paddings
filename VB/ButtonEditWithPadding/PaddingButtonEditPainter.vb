Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo

Namespace ButtonEditWithPadding
	Friend Class PaddingButtonEditPainter
		Inherits ButtonEditPainter
		Public Sub New()
		End Sub

		Protected Overrides Sub DrawButton(ByVal viewInfo As ButtonEditViewInfo, ByVal info As EditorButtonObjectInfoArgs)
			If TypeOf viewInfo Is PaddingButtonEditViewInfo Then
				Dim b As Brush = viewInfo.PaintAppearance.GetBackBrush(info.Cache)
				info.Graphics.FillRectangle(b, info.Bounds)

				info.Bounds = (CType(viewInfo, PaddingButtonEditViewInfo)).AdjustBoundsWithMargins(info.Bounds)
				MyBase.DrawButton(viewInfo, info)
				info.Bounds = (CType(viewInfo, PaddingButtonEditViewInfo)).RevertMarginedBounds(info.Bounds)
			Else
				MyBase.DrawButton(viewInfo, info)
			End If
		End Sub
	End Class
End Namespace
