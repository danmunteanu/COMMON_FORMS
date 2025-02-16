namespace CommonForms.Components
{
    //  Everything List Settings related
    public partial class FilesListComponent : ApplicationPageBase
    {
        //  LIST SETTINGS Structure
        public struct ListSettings
        {
            //  The label above the list
            public string TopLabel { get; set; } = Locale.FILES_LIST_LABEL_ADD;

            //  The text on button add
            public string ButtonAddLabel { get; set; } = Locale.FILES_LIST_BUTTON_ADD;

            //  Shows/hides the Settings button
            public bool SettingsButtonVisible { get; set; } = true;

            //  Allows adding of subfolders
            public bool AllowAddFolders { get; set; } = true;

            //  Allow parsing subfolders when adding folders
            public bool ParseSubfolders { get; set; } = false;

            //  Enable/Disable use of status
            public bool UseStatus { get; set; } = true;

            //  Enables/Disable use of the progress bar
            public bool UseProgressBar { get; set; } = true;

            //  Enable/Disable search bar
            public bool UseSearchBar {  get; set; } = false;

            //  LINE HEIGHTS
            public int TopLineHeight { get; set; } = 45;

            public int BottomLineHeight { get; set; } = 55;

            public int StatusBarLineHeight { get; set; } = 33;

            public int SearchBarHeight { get; set; } = 55;

            public int ProgressBarLineHeight { get; set; } = 45;

            //  FONT SETTINGS
            public string FontFamily { get; set; } = "Segoe UI";

            public int FontSize { get; set; } = 8;

            //  CTOR
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
                //  rebuild only if necessary
                mRebuildLayout = 
                    Settings.UseStatus != value.UseStatus ||
                    Settings.UseProgressBar != value.UseProgressBar ||
                    Settings.ProgressBarLineHeight != value.ProgressBarLineHeight ||
                    Settings.BottomLineHeight != value.BottomLineHeight;

                mSettings = value;

                OnSettingsSet();
            }
        }

        private bool mRebuildLayout = false;

        private void OnSettingsSet()
        {
            if (!(lblAddFiles != null && btnAddFiles != null && btnSettings != null))
                return;

            //  Update UI elements based on new settings
            lblAddFiles.Text = mSettings.TopLabel;
            btnAddFiles.Text = mSettings.ButtonAddLabel;

            btnSettings.Visible = mSettings.SettingsButtonVisible;

            if (mRebuildLayout)
            {
                RebuildLayout();
                mRebuildLayout = false;
            }
        }

        //  The list must always have a settings instance
        private ListSettings mSettings = new();
    }
}