namespace CommonForms.Components
{
    public partial class FilesListComponent : ApplicationPageBase
    {
        //  LIST SETTINGS Structure
        public struct ListSettings
        {
            //  The label above the list
            public string TopLabel { get; set; } = Locale.FILES_LIST_LABEL_ADD;

            //  The text on button add
            public string ButtonAddLabel { get; set; } = Locale.FILES_LIST_BUTTON_ADD;

            public bool SettingsButtonVisible { get; set; } = true;

            //  Disables use of status
            public bool UseStatus { get; set; } = true;

            //  Disables use of the progress bar
            public bool UseProgressBar { get; set; } = true;

            //  Allows adding of subfolders
            public bool AllowAddFolders { get; set; } = true;

            //  Allow parsing subfolders when adding folders
            public bool ParseSubfolders { get; set; } = false;

            public ListSettings()
            {
            }
        }

        //  setter/getter for settings
        public ListSettings Settings
        {
            get { return mSettings; }
            set
            {
                mSettings = value;
                OnSettingsSet();
            }
        }

        private void OnSettingsSet()
        {
            if (!(lblAddFiles != null && btnAddFiles != null && btnSettings != null))
                return;

            //  Update UI elements based on new settings
            lblAddFiles.Text = mSettings.TopLabel;
            btnAddFiles.Text = mSettings.ButtonAddLabel;

            btnSettings.Visible = mSettings.SettingsButtonVisible;

            RebuildLayout();
        }

        //  The list must always have a settings instance
        private ListSettings mSettings = new();
    }
}