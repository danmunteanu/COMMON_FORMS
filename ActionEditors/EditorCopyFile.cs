using RealityFrameworks.Actions;

namespace CommonForms
{
    public partial class EditorCopyFile : EditorBase<string>
    {
        public EditorCopyFile()
        {
            InitializeComponent();
        }

        public override bool ValidateState()
        {
            //  must be set
            if (string.IsNullOrWhiteSpace(txtFolder.Text))
            {                
                PushError(Locale.EDITOR_COPYFILE_ERROR_SELECT_FOLDER);
                return false;
            }

            if (!Path.Exists(txtFolder.Text))
            {
                PushError(Locale.EDITOR_COPYFILE_ERROR_FOLDER_NOT_EXIST);
                return false;
            }

            return true;
        }

        public override void LoadState(RealityFrameworks.Actions.Action<string> action)
        {
            if (action is ActionCopyFile actionCopyFile)
            {
                txtFolder.Text = actionCopyFile.DestinationFolder;
            }
        }

        public override void SaveState(RealityFrameworks.Actions.Action<string> action)
        {
            if (action is ActionCopyFile actionCopyFile)
            {
                actionCopyFile.DestinationFolder = txtFolder.Text;
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
