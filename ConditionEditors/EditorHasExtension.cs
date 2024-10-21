using System.ComponentModel;

namespace CommonForms
{
    public partial class EditorHasExtension : UserControl
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
    }
}
