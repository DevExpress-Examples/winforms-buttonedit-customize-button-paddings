using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;

namespace ButtonEditWithPadding
{
    public class PaddingButtonEdit : ButtonEdit
    {
        static PaddingButtonEdit()
        {
            RepositoryItemPaddingButtonEdit.Register();
        }
        public PaddingButtonEdit()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemPaddingButtonEdit Properties
        {
            get { return base.Properties as RepositoryItemPaddingButtonEdit; }
        }

        public override string EditorTypeName
        {
            get { return RepositoryItemPaddingButtonEdit.EditorName; }
        }


        protected override void OnClickButton(EditorButtonObjectInfoArgs buttonInfo)
        {
            ShowPopupForm();
            base.OnClickButton(buttonInfo);
        }
        protected virtual void ShowPopupForm()
        {
            using ( Form form = new Form() )
            {
                form.StartPosition = FormStartPosition.Manual;
                form.Location = this.PointToScreen(new Point(0, Height));
                form.ShowDialog();
            }
        }
    }
}
