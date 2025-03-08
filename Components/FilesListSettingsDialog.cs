namespace CommonForms.Components
{
    public partial class FilesListSettingsDialog : Form
    {
        FilesListComponent? mListControl = null;

        public FilesListComponent? ListControl
        {
            get { return mListControl; }
            set { mListControl = value; LoadListSettings(); }
        }

        public FilesListSettingsDialog(FilesListComponent listControl)
        {
            InitializeComponent();

            this.MaximizeBox = false;
            compListExt.FreeEditExtensions = false;

            //  use the setter to trigger LoadListSettings
            ListControl = listControl;

            this.CenterToParent();
        }

        public void LoadListSettings()
        {
            if (mListControl != null)
            {
                chkAddFolders.Checked = mListControl.Settings.AllowAddFolders;
                chkParseSubfolders.Enabled = chkAddFolders.Checked;
                chkParseSubfolders.Checked = mListControl.Settings.ParseSubfolders;
                chkShowStatus.Checked = mListControl.Settings.UseStatus;
                chkShowProgressBar.Checked = mListControl.Settings.UseProgressBar;

                //  Load file filters
                compListExt.Clear();
                compListExt.AddExtensions(mListControl.FileFilters.ToArray());
            }
            this.CenterToParent();
        }

        private void chkAddFolders_CheckedChanged(object sender, EventArgs e)
        {
            chkParseSubfolders.Enabled = chkAddFolders.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mListControl != null)
            {
                FilesListComponent.ListSettings settings = mListControl.Settings;
                settings.AllowAddFolders = chkAddFolders.Checked;
                settings.ParseSubfolders = chkParseSubfolders.Checked;
                settings.UseStatus = chkShowStatus.Checked;
                settings.UseProgressBar = chkShowProgressBar.Checked;

                mListControl.FileFilters = compListExt.Extensions.ToList();
                mListControl.Settings = settings;
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;    //  consume the key press event
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
