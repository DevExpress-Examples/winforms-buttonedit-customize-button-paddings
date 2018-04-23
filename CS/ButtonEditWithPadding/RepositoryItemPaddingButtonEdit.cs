using System.Windows.Forms;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;

namespace ButtonEditWithPadding
{
    [UserRepositoryItem("Register")]
    public class RepositoryItemPaddingButtonEdit : RepositoryItemButtonEdit
    {
        internal const string EditorName = "PaddingButtonEdit";
        private Padding _padding;

        static RepositoryItemPaddingButtonEdit()
        {
            Register();
        }
        public RepositoryItemPaddingButtonEdit()
        {
        }

        public static void Register()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(PaddingButtonEdit),
                typeof(RepositoryItemPaddingButtonEdit), typeof(PaddingButtonEditViewInfo),
                    new PaddingButtonEditPainter(), true, null));
        }

        public override string EditorTypeName
        {
            get { return EditorName; }
        }
        public Padding Padding
        {
            get { return _padding; }
            set
            {
                _padding = value;
                this.OnPropertiesChanged();
            }
        }
    }
}