using RealityFrameworks.Actions;

namespace CommonForms
{
    public partial class EditorCopyFile : EditorBase2
    {
        public EditorCopyFile()
        {
            InitializeComponent();

            cmbDuplicates.SelectedIndex = 0;
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

        public override void LoadState(object action)
        {
            if (action is ActionCopyFile acp)
            {
                txtFolder.Text = acp.DestinationFolder;
                if (acp.DuplicateFilesPolicy == ActionCopyFile.EDuplicateFilesPolicy.AutoRename)
                    cmbDuplicates.SelectedIndex = 1;
                if (acp.DuplicateFilesPolicy == ActionCopyFile.EDuplicateFilesPolicy.Overwrite)
                    cmbDuplicates.SelectedIndex = 0;
            }
        }

        public override void SaveState(object action)
        {
            if (action is ActionCopyFile acp)
            {
                acp.DestinationFolder = txtFolder.Text;
                acp.DuplicateFilesPolicy = (cmbDuplicates.SelectedIndex == 0) ? ActionCopyFile.EDuplicateFilesPolicy.Overwrite : ActionCopyFile.EDuplicateFilesPolicy.AutoRename;
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
