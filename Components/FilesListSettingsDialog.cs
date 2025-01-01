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
                chkAddFolders.Checked = _listControl.Settings.AddFolders;
                chkParseSubfolders.Enabled = chkAddFolders.Checked;
                chkParseSubfolders.Checked = _listControl.Settings.ParseSubfolders;
            }
        }

        private void chkAddFolders_CheckedChanged(object sender, EventArgs e)
        {
            chkParseSubfolders.Enabled = chkAddFolders.Checked;
        }

        private void chkParseSubfolders_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_listControl != null)
            {
                FilesListComponent.ListSettings settings = _listControl.Settings;
                settings.AddFolders = chkAddFolders.Checked;
                settings.ParseSubfolders = chkParseSubfolders.Checked;
                _listControl.Settings = settings;
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
