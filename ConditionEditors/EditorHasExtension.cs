using System.ComponentModel;

namespace CommonForms
{
    public partial class EditorHasExtension : EditorBase
    {
        public EditorHasExtension()
        {
            InitializeComponent();
        }

        public EditorHasExtension(IContainer container)
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
