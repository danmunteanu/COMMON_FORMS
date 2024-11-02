using RealityFrameworks;
using System.ComponentModel;
using System.Windows.Forms;

namespace CommonForms
{
    public partial class EditorCopyFile : EditorBase
    {
        ActionCopyFile _action = null;

        public ActionCopyFile Action
        {
            get { return _action; } set { _action = value; LoadState(_action); }
        }

        public EditorCopyFile()
        {
            InitializeComponent();
        }

        private void LoadState(ActionCopyFile action)
        {

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
