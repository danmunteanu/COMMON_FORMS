using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonForms
{
    public partial class EditorCopyFile : UserControl
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
    }
}
