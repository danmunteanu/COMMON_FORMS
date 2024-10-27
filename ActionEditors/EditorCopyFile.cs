using System.ComponentModel;
using System.Windows.Forms;

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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //  show dialog to select folder
            DialogResult res = mFolderBrowserDialog.ShowDialog();
            if (res == DialogResult.OK && !string.IsNullOrWhiteSpace(mFolderBrowserDialog.SelectedPath))
            {
                txtPath.Text = mFolderBrowserDialog.SelectedPath;
            }
            else
            {
                txtPath.Text = string.Empty;
            }
        }
    }
}
