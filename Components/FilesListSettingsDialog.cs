namespace CommonForms.Components
{
    public partial class FilesListSettingsDialog : Form
    {
        FilesListComponent? _listControl = null;

        public FilesListComponent? ListControl
        {
            get { return _listControl; }
            set { _listControl = value; LoadListSettings(); }
        }

        public FilesListSettingsDialog(FilesListComponent listControl)
        {
            InitializeComponent();

            this.MaximizeBox = false;

            //  use the setter to trigger OnListControlSet
            ListControl = listControl;

            this.CenterToParent();
        }

        public void LoadListSettings()
        {
            if (_listControl != null)
            {
                chkAddFolders.Checked = _listControl.Settings.AllowAddFolders;
                chkParseSubfolders.Enabled = chkAddFolders.Checked;
                chkParseSubfolders.Checked = _listControl.Settings.ParseSubfolders;
                chkShowStatus.Checked = _listControl.Settings.UseStatus;
                chkShowProgressBar.Checked = _listControl.Settings.UseProgressBar;
            }
            this.CenterToParent();
        }

        private void chkAddFolders_CheckedChanged(object sender, EventArgs e)
        {
            chkParseSubfolders.Enabled = chkAddFolders.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_listControl != null)
            {
                FilesListComponent.ListSettings settings = _listControl.Settings;
                settings.AllowAddFolders = chkAddFolders.Checked;
                settings.ParseSubfolders = chkParseSubfolders.Checked;
                settings.UseStatus = chkShowStatus.Checked;
                settings.UseProgressBar = chkShowProgressBar.Checked;
                _listControl.Settings = settings;
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
