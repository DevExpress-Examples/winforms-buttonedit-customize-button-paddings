using System.Drawing;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;

namespace ButtonEditWithPadding
{
    class PaddingButtonEditPainter : ButtonEditPainter
    {
        public PaddingButtonEditPainter()
        {
        }

        protected override void DrawButton(ButtonEditViewInfo viewInfo, EditorButtonObjectInfoArgs info)
        {
            if ( viewInfo is PaddingButtonEditViewInfo )
            {
                Brush b = viewInfo.PaintAppearance.GetBackBrush(info.Cache);
                info.Graphics.FillRectangle(b, info.Bounds);

                info.Bounds = ((PaddingButtonEditViewInfo)viewInfo).AdjustBoundsWithMargins(info.Bounds);
                base.DrawButton(viewInfo, info);
                info.Bounds = ((PaddingButtonEditViewInfo)viewInfo).RevertMarginedBounds(info.Bounds);
            }
            else
                base.DrawButton(viewInfo, info);
        }
    }
}
