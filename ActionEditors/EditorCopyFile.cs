using RealityFrameworks;

namespace CommonForms
{
    public partial class EditorCopyFile : EditorBase
    {
        public EditorCopyFile()
        {
            InitializeComponent();
        }

        public override void LoadState(RealityFrameworks.Action action)
        {
            if (action is ActionCopyFile actionCopyFile)
            {
                txtFolder.Text = actionCopyFile.Folder;
            }
        }

        public override void SaveState(RealityFrameworks.Action action)
        {
            if (action is ActionCopyFile actionCopyFile)
            {
                actionCopyFile.Folder = txtFolder.Text;
            }    
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //  show dialog to select folder
            DialogResult res = mFolderBrowserDialog.ShowDialog();
            if (res == DialogResult.OK && !string.IsNullOrWhiteSpace(mFolderBrowserDialog.SelectedPath))
            {
                txtFolder.Text = mFolderBrowserDialog.SelectedPath;
            }
            else
            {
                txtFolder.Text = string.Empty;
            }
        }
    }
}
