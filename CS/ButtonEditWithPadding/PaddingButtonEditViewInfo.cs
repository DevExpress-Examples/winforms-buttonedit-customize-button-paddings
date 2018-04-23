using System.Drawing;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;

namespace ButtonEditWithPadding
{
    class PaddingButtonEditViewInfo : ButtonEditViewInfo
    {
        public PaddingButtonEditViewInfo(RepositoryItem item)
            : base(item)
        {
        }

        public Rectangle AdjustBoundsWithMargins(Rectangle boundsToAdjust)
        {
            boundsToAdjust.X += ((RepositoryItemPaddingButtonEdit)Item).Padding.Left;
            boundsToAdjust.Y += ((RepositoryItemPaddingButtonEdit)Item).Padding.Top;
            boundsToAdjust.Width -= ((RepositoryItemPaddingButtonEdit)Item).Padding.Right * 2;
            boundsToAdjust.Height -= ((RepositoryItemPaddingButtonEdit)Item).Padding.Bottom * 2;

            return boundsToAdjust;
        }
        public Rectangle RevertMarginedBounds(Rectangle boundsToRevert)
        {
            boundsToRevert.X -= ((RepositoryItemPaddingButtonEdit)Item).Padding.Left;
            boundsToRevert.Y -= ((RepositoryItemPaddingButtonEdit)Item).Padding.Top;
            boundsToRevert.Width += ((RepositoryItemPaddingButtonEdit)Item).Padding.Right * 2;
            boundsToRevert.Height += ((RepositoryItemPaddingButtonEdit)Item).Padding.Bottom * 2;

            return boundsToRevert;
        }

        protected override void OnBeforeButtonStateChanged(EditorButtonObjectInfoArgs info, ObjectState newState, int buttonId)
        {
            if ( Item is RepositoryItemPaddingButtonEdit )
            {
                info.Bounds = AdjustBoundsWithMargins(info.Bounds);

                base.OnBeforeButtonStateChanged(info, newState, buttonId);
                info.Bounds = RevertMarginedBounds(info.Bounds);
            }
            else
                base.OnBeforeButtonStateChanged(info, newState, buttonId);
        }
    }
}