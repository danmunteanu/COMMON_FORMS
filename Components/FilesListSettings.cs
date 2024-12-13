namespace CommonForms.Components
{
    public partial class FilesListSettings : Form
    {
        FilesListControl? _listControl = null;

        public FilesListControl? ListControl
        {
            get { return _listControl; }
            set { _listControl = value; LoadListSettings(); }
        }

        public FilesListSettings(FilesListControl listControl)
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
                chkAddFolders.Checked = _listControl.AddFolders;
                chkParseSubfolders.Enabled = chkAddFolders.Checked;
                chkParseSubfolders.Checked = _listControl.ParseSubfolders;
            }
        }

        private void chkAddFolders_CheckedChanged(object sender, EventArgs e)
        {
            if (_listControl != null)
                _listControl.AddFolders = chkAddFolders.Checked;

            chkParseSubfolders.Enabled = chkAddFolders.Checked;
        }

        private void chkParseSubfolders_CheckedChanged(object sender, EventArgs e)
        {
            if (_listControl != null)
                _listControl.ParseSubfolders = chkParseSubfolders.Checked;
        }
    }
}
