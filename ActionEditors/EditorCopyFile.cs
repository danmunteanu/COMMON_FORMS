using System.ComponentModel;

namespace CommonForms
{
    public partial class EditorCopyFile : EditorBase
    {
        public EditorCopyFile()
        {
            InitializeComponent();
        }

        public EditorCopyFile(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public override void SaveState()
        {
            //base.SaveState();

            //  UI -> Condition
        }
    }
}
