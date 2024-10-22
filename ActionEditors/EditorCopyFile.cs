using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
