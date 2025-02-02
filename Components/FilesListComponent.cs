using System.Globalization;

namespace CommonForms.Components
{
    public partial class FilesListComponent : ApplicationPageBase
    {
        //  Settings dialog
        private FilesListSettingsDialog mDialolgSettings;

        //  Keeps track of the Select All/Deselect All state
        private bool mSelectAll = true;

        //  The file filters used to add files to the list
        //  via btnAddFiles and drag & drop
        private List<string> mFileFilters = new();
        public List<string> FileFilters
        {
            get { return mFileFilters; }
            set { mFileFilters = value; }
        }

        public FilesListComponent()
        {
            InitializeComponent();

            //  creates all the components - labels, buttons, listbox
            CreateMasterLayout();

            mDialolgSettings = new FilesListSettingsDialog(this);

            //  provide a default local status updater
            UpdateStatusCallback = this.UpdateLocalStatus;

            //  empty the status
            CallUpdateStatus(Locale.FILES_LIST_STATUS_READY);

            UpdateUI();
        }

        public string Status
        {
            get { return lblStatus.Text; }
            set { lblStatus.Text = value; }
        }

        // Sets the progress bar value
        public int Progress
        {
            get
            {
                if (progressBar != null)
                    return progressBar.Value;
                else
                    return 0;
            }
            set
            {
                if (progressBar != null)
                    progressBar.Value = value;
            }
        }

        public void RebuildLayout()
        {
            Controls.Clear();
            CreateMasterLayout();
        }

        /// <summary>
        /// A default status updater, updates the local status label with the message.
        /// </summary>
        /// <param name="message">The message will be set as the status</param>
        private void UpdateLocalStatus(string message)
        {
            if (lblStatus != null)
                lblStatus.Text = message;
        }

        public override void UpdateUI()
        {
            bool selectAllVisible = (
                lstFiles.SelectionMode == SelectionMode.MultiSimple ||
                lstFiles.SelectionMode == SelectionMode.MultiExtended
            );
            btnSelectAll.Visible = selectAllVisible;
            btnSelectAll.Enabled = selectAllVisible && lstFiles.Items.Count > 0;

            bool haveFiles = mFilesProcessor?.CountFileNames() > 0;

            btnClear.Enabled = haveFiles;
            btnReload.Enabled = haveFiles;
            btnRem.Enabled = haveFiles && lstFiles.SelectedIndex != -1;
        }

        private void UpdateLocalizations()
        {
            lblAddFiles.Text = Locale.FILES_LIST_LABEL_ADD;
            btnAddFiles.Text = Locale.FILES_LIST_BUTTON_ADD;
            btnRem.Text = Locale.FILES_LIST_BUTTON_REM;
            btnClear.Text = Locale.FILES_LIST_BUTTON_CLEAR;
        }

        public override void SaveSettings(ref Dictionary<string, string> iniKeys)
        {
            //  Dump settings to iniKeys

        }

        private void AddFilesFromFolder(string folder)
        {
            if (string.IsNullOrWhiteSpace(folder))
                return;

            // Check if folder exists before proceeding
            if (!Directory.Exists(folder))
                return;

            //  clear the list 
            lstFiles.Items.Clear();
            Processor?.ClearFileNames();

            //  Add file names to mFilesToProcess
            DirectoryInfo di = new(folder);
            IEnumerable<FileInfo> files = di.GetFilesByExtensions(mFileFilters.ToArray());
            foreach (FileInfo fi in files)
            {
                Processor?.AddFileName(fi.FullName);
            }

            //  reload mFilesToProcess into the list
            ReloadFiles();

            //  Forces all listeners to update their UI
            UpdateUI();
            CallUpdateUI();
        }

        /// <summary>
        /// Clears the list and reloads the list of file names from the Processor
        /// </summary>
        public void ReloadFiles()
        {
            lstFiles.Items.Clear();
            for (int idx = 0; idx < Processor?.CountFileNames(); idx++)
            {
                var item = Processor.GetFileNameAt(idx);
                lstFiles.Items.Add(item);
            }
        }

        public override void UpdateLocale()
        {
            //  top
            lblAddFiles.Text = Locale.FILES_LIST_LABEL_ADD;
            btnSelectAll.Text = Locale.FILES_LIST_BUTTON_SELECT_ALL;

            //  bottom
            btnAddFiles.Text = Locale.FILES_LIST_BUTTON_ADD;
            //btnReload.Text = Locale.FILES_LIST_BUTTON_RELOAD;
            btnRem.Text = Locale.FILES_LIST_BUTTON_REM;
            btnClear.Text = Locale.FILES_LIST_BUTTON_CLEAR;
        }

        // Handler for the Add button.
        private void btnAdd_Click(object? sender, EventArgs e)
        {
            //  show dialog to select folder
            DialogResult res = mFolderBrowserDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (!string.IsNullOrWhiteSpace(mFolderBrowserDialog.SelectedPath))
                {
                    AddFilesFromFolder(mFolderBrowserDialog.SelectedPath);
                    CallUpdateStatus(Locale.STATUS_FOLDER_ADDED);
                }
            }
            else
            {
                CallUpdateStatus(Locale.STATUS_FOLDER_NOT_ADDED);
            }

            //  Reset progress bar
            CallUpdateProgress(0);

            UpdateUI();
        }

        /// <summary>
        /// Handler for button Reload.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReloadFolder_Click(object? sender, EventArgs e)
        {
            AddFilesFromFolder(mFolderBrowserDialog.SelectedPath);
            CallUpdateStatus(Locale.STATUS_FOLDER_RELOADED);

            CallUpdateUI();
        }

        // Handler for button Clear.
        private void btnClear_Click(object? sender, EventArgs e)
        {
            //clear inner list and list ui
            Processor?.ClearFileNames();
            lstFiles.Items.Clear();
            CallUpdateStatus(Locale.STATUS_LIST_CLEARED);
            
            CallOnSelectionChanged(string.Empty);   //  force a deselect
            CallUpdateUI();
        }

        /// <summary>
        /// Handler for changing list selection.
        private void lstFiles_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lstFiles.SelectedItem == null)
                return;

            if (lstFiles.SelectedItem != null)
                CallOnSelectionChanged(lstFiles.SelectedItem.ToString());
        }

        private void listFiles_DragEnter(object? sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;

            string[] dropItems = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            bool allow = false;
            foreach (string item in dropItems)
            {
                //  need at least one allowed file type in the list
                if (allow)
                    break;

                //  Allow folders
                if (Directory.Exists(item))
                {
                    allow = true;
                    continue;
                }

                string ext = Path.GetExtension(item).ToLower();

                //  check if extension is allowed
                if (mFileFilters.Contains(ext))
                    allow = true;
            }
            if (!allow)
                e.Effect = DragDropEffects.None;
        }

        private void listFiles_DragDrop(object? sender, DragEventArgs e)
        {
            string[]? dropItems = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            bool added = false;
            foreach (string item in dropItems)
            {
                //  is the file a folder?
                if (Directory.Exists(item))
                {
                    //  ADD the folder to the Processor's list of folders
                    //  this way, on reload, it should reload the folder's contents
                    //  not just the files
                    //Processor?.AddFolder(item);
                    if (AddFolderToProcessor(item))
                        added = true;
                }
                else
                {
                    if (AddFileNameToProcessor(item))
                        added = true;
                }
            }

            if (added)
            {
                ReloadFiles();
                CallUpdateUI();

                //  TOOD:
                //  Count how many files were added
                //  Add to Locale STATUS_FILES_ADDED with {0} replaced by the count
                CallUpdateStatus($"Files added.");
            }

        }

        //  call this only on folders
        private bool AddFolderToProcessor(string folder)
        {
            bool added = false;

            DirectoryInfo dirInfo = new(folder);
            IEnumerable<FileInfo> files = dirInfo.GetFilesByExtensions(mFileFilters.ToArray());
            foreach (FileInfo fi in files)
            {
                //  is file, add if we can
                if (AddFileNameToProcessor(fi.FullName))
                    added = true;
            }


            if (Settings.ParseSubfolders)
            {
                //  get all subfolders in current folder
                var subfolders = Directory.GetDirectories(folder);

                foreach (string dir in subfolders)
                {
                    if (AddFolderToProcessor(dir))
                        added = true;
                }
            }

            return added;
        }

        private bool AddFileNameToProcessor(string item)
        {
            if (mFilesProcessor == null)
                return false;

            //  Get Extension
            string ext = Path.GetExtension(item).ToLower();

            //  check if extension is allowed
            if (mFileFilters.Contains(ext))
            {
                if (!mFilesProcessor.Contains(item))
                {
                    mFilesProcessor.AddFileName(item);
                    return true;
                }
            }

            return false;
        }

        public void UpdateList(SelectionMode selMode, bool enableList)
        {
            lstFiles.SelectionMode = selMode;
            lstFiles.Enabled = enableList;
        }

        public void UpdateSelectedItem(string item)
        {
            if (lstFiles.SelectedIndex == -1)
                return;

            //  disable update handler
            lstFiles.Click -= lstFiles_SelectedIndexChanged;
            lstFiles.Items[lstFiles.SelectedIndex] = item;
            lstFiles.Click += lstFiles_SelectedIndexChanged;
        }

        private void btnSelectAll_Click(object? sender, EventArgs e)
        {
            if (lstFiles.SelectionMode == SelectionMode.MultiSimple ||
                lstFiles.SelectionMode == SelectionMode.MultiExtended)
            {
                for (int idx = 0; idx < lstFiles.Items.Count; idx++)
                {
                    lstFiles.SetSelected(idx, mSelectAll);
                }

                if (mSelectAll)
                    btnSelectAll.Text = Locale.FILES_LIST_BUTTON_DESELECT_ALL;
                else
                    btnSelectAll.Text = Locale.FILES_LIST_BUTTON_SELECT_ALL;

                mSelectAll = !mSelectAll;
            }
        }

        private void btnSettings_Click(object? sender, EventArgs e)
        {
            //  List's state might have changed, reload them and then display
            mDialolgSettings.LoadListSettings();
            mDialolgSettings.ShowDialog(this);
        }

        private TableLayoutPanel CreateTopLine()
        {
            //  setup the table layout for the top line
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();

            // BORDER for debugging
            //tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            //  table columns
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // Label
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F)); // Empty space
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // Button 1 (fixed width)

            //  label Add Files
            lblAddFiles.Name = "lblAddFiles";
            lblAddFiles.AutoSize = true;
            lblAddFiles.Text = Settings.TopLabel;
            lblAddFiles.TextAlign = ContentAlignment.MiddleLeft;
            lblAddFiles.Anchor = AnchorStyles.Left; // | AnchorStyles.Bottom;
            lblAddFiles.Font = new Font(lblAddFiles.Font.FontFamily, 9);

            //  button Select All
            btnSelectAll.Text = Locale.FILES_LIST_BUTTON_SELECT_ALL ;
            btnSelectAll.Font = new Font(btnSelectAll.Font.FontFamily, Settings.FontSize);
            btnSelectAll.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSelectAll.AutoSize = true;
            btnSelectAll.Dock = DockStyle.Fill;
            //btnSelectAll.Height = 23;
            btnSelectAll.TextAlign = ContentAlignment.MiddleCenter;
            btnSelectAll.Anchor = AnchorStyles.Right;
            Size textSize = TextRenderer.MeasureText(btnSelectAll.Text, btnSelectAll.Font);
            btnSelectAll.Width = textSize.Width + 5;
            btnSelectAll.Height = textSize.Height + 5;
            btnSelectAll.Click -= btnSelectAll_Click;   //  remove prev handler
            btnSelectAll.Click += btnSelectAll_Click;   //  make sure it's only once

            //  Add the controls to the layout
            tableLayoutPanel.Controls.Add(lblAddFiles, 0, 0);
            tableLayoutPanel.Controls.Add(btnSelectAll, 2, 0);

            return tableLayoutPanel;
        }

        private ListBox CreateListBox()
        {
            lstFiles.Dock = DockStyle.Fill;
            lstFiles.SelectionMode = SelectionMode.None;
            lstFiles.Font = new Font("Arial", 10);
            lstFiles.HorizontalScrollbar = true;
            lstFiles.SelectionMode = SelectionMode.None;
            lstFiles.Margin = new Padding(0);

            lstFiles.AllowDrop = true;
            lstFiles.DragEnter -= listFiles_DragEnter;
            lstFiles.DragEnter += listFiles_DragEnter;
            lstFiles.DragDrop -= listFiles_DragDrop;
            lstFiles.DragDrop += listFiles_DragDrop;
            lstFiles.SelectedIndexChanged -= lstFiles_SelectedIndexChanged;
            lstFiles.SelectedIndexChanged += lstFiles_SelectedIndexChanged;

            return lstFiles;
        }

        private Label SetupStatusLine()
        {
            lblStatus.Font = new Font(Settings.FontFamily, 10);
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            return lblStatus;
        }

        private void SetupProgressBar()
        {
            progressBar.Value = 0;
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.Dock = DockStyle.Fill;
        }

        private void CreateSearchBar()
        {
            //  Search bar
            
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Margin = new Padding(0);
            txtSearch.Padding = new Padding(0);
            txtSearch.Font = new Font(txtSearch.Font.FontFamily, 10);
            txtSearch.TextChanged += (sender, e) =>
            {
                string search = txtSearch.Text;

                //  remove items matching the text
            };
        }

        private TableLayoutPanel CreateBottomLayout()
        {
            TableLayoutPanel layoutBottomLine = new TableLayoutPanel();
            layoutBottomLine.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            
            // BORDER for debugging
            //layoutBottomLine.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            layoutBottomLine.Dock = DockStyle.Fill;
            layoutBottomLine.AutoSize = true;
            layoutBottomLine.ColumnCount = 6;
            layoutBottomLine.RowCount = 1;

            // Set row style to fill the available height
            layoutBottomLine.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            // Add the column styles
            layoutBottomLine.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // btnAdd
            layoutBottomLine.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // btnReload (square)
            layoutBottomLine.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // btnRem (square)
            layoutBottomLine.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // btnSettings
            layoutBottomLine.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));  // Empty space
            layoutBottomLine.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // btnClear

            // btnAddFolder
            btnAddFiles.Text = Settings.ButtonAddLabel;
            btnAddFiles.Font = new Font(btnAddFiles.Font.FontFamily, Settings.FontSize);
            btnAddFiles.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            //btnAddFiles.Dock = DockStyle.Fill;
            btnAddFiles.Padding = new Padding(3);
            btnAddFiles.AutoSize = true;
            btnAddFiles.Height = Settings.BottomLineHeight;
            btnAddFiles.Click -= btnAdd_Click;
            btnAddFiles.Click += btnAdd_Click;
            
            // btnReload
            btnReload.Text = "↻";
            btnReload.Font = new Font(btnReload.Font.FontFamily, Settings.FontSize);
            btnReload.Width = 35;
            btnReload.AutoSize = true;
            btnReload.Padding = new Padding(3);
            btnReload.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnReload.Height = Settings.BottomLineHeight;
            btnReload.Click -= btnReloadFolder_Click;
            btnReload.Click += btnReloadFolder_Click;

            // btnRem
            btnRem.Text = "-";
            btnRem.Font = new Font(btnRem.Font.FontFamily, Settings.FontSize);
            btnRem.Width = 35;
            btnRem.AutoSize = true;
            btnRem.Padding = new Padding(3);
            btnRem.TextAlign = ContentAlignment.MiddleCenter;
            btnRem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnRem.Height = Settings.BottomLineHeight;
            //btnRem.Dock = DockStyle.Fill; // Ensure it fills the height

            //  button Settings
            btnSettings.Text = "⚙"; // Gear emoji
            btnSettings.Visible = Settings.SettingsButtonVisible;
            btnSettings.Font = new Font(btnSettings.Font.FontFamily, Settings.FontSize);
            btnSettings.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSettings.Width = 35;
            btnSettings.AutoSize = true;
            btnSettings.Padding = new Padding(3);
            btnSettings.TextAlign = ContentAlignment.MiddleCenter;
            btnSettings.Height = Settings.BottomLineHeight;
            btnSettings.Click -= btnSettings_Click;
            btnSettings.Click += btnSettings_Click;

            // btnClear
            btnClear.Text = Locale.FILES_LIST_BUTTON_CLEAR;
            btnClear.Font = new Font(btnClear.Font.FontFamily, Settings.FontSize);
            btnClear.AutoSize = true;
            btnClear.Height = Settings.BottomLineHeight;
            //btnClear.Dock = DockStyle.Fill;
            btnClear.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnClear.Height = Settings.BottomLineHeight;
            btnClear.Click -= btnClear_Click;
            btnClear.Click += btnClear_Click;

            //  Remove padding from all components (except btnSettings)
            Control[] controls = { btnAddFiles, btnReload, btnRem, btnClear };
            foreach (Control control in controls)
            {
                control.Padding = new Padding(0);
                control.Margin = new Padding(0);
            }

            int idx = 0;
            layoutBottomLine.Controls.Add(btnAddFiles, idx++, 0);
            layoutBottomLine.Controls.Add(btnReload, idx++, 0);
            layoutBottomLine.Controls.Add(btnRem, idx++, 0);
            layoutBottomLine.Controls.Add(btnSettings, idx++, 0);
            idx++; // Skip Empty space
            layoutBottomLine.Controls.Add(btnClear, idx++, 0);

            return layoutBottomLine;
        }


        private void CreateMasterLayout()
        {
            TableLayoutPanel masterTableLayout = new TableLayoutPanel();
            masterTableLayout.Dock = DockStyle.Fill;
            masterTableLayout.ColumnCount = 1;
            masterTableLayout.RowCount = 5;

            //  Top Line
            TableLayoutPanel topLineLayout = CreateTopLine();
            topLineLayout.Dock = DockStyle.Fill;
            masterTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, Settings.TopLineHeight));

            //  ListBox
            lstFiles = CreateListBox();
            lstFiles.Dock = DockStyle.Fill;
            masterTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            //  Status line
            if (Settings.UseStatus)
            {
                lblStatus = SetupStatusLine();
                lblStatus.Dock = DockStyle.Fill;
                masterTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, Settings.StatusBarLineHeight));
            }

            //  Progress Bar    
            if (Settings.UseProgressBar)
            {
                SetupProgressBar();
                masterTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, Settings.ProgressBarLineHeight));
            }

            //  Search bar
            //CreateSearchBar();
            //masterTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));

            //  Bottom Buttons
            TableLayoutPanel bottomLayout = CreateBottomLayout();
            masterTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, Settings.BottomLineHeight));
            bottomLayout.Dock = DockStyle.Fill;

            //  some bottom border
            masterTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 5));

            //  Add all controls to the master layout
            int rowIdx = 0;
            masterTableLayout.Controls.Add(topLineLayout, 0, rowIdx++);
            masterTableLayout.Controls.Add(lstFiles, 0, rowIdx++);
            if (Settings.UseStatus && lblStatus != null) masterTableLayout.Controls.Add(lblStatus, 0, rowIdx++);
            if (Settings.UseProgressBar && progressBar != null) masterTableLayout.Controls.Add(progressBar, 0, rowIdx++);
            //masterTableLayout.Controls.Add(txtSearch, 0, rowIdx++);
            masterTableLayout.Controls.Add(bottomLayout, 0, rowIdx++);

            this.Controls.Add(masterTableLayout);
        }

        //  The dialog to select folders
        private FolderBrowserDialog mFolderBrowserDialog = new FolderBrowserDialog();

        //  Top bar
        private Label lblAddFiles = new();
        private Button btnSelectAll = new();
        private Button btnSettings = new();
        
        //  Listbox
        private ListBox lstFiles = new();
        
        //  Status
        private Label lblStatus = new();

        //  Progress bar
        private ProgressBar progressBar = new();

        //  Search bar
        TextBox txtSearch = new();

        //  Bottom
        private Button btnAddFiles = new();
        private Button btnReload = new();
        private Button btnRem = new();
        private Button btnClear = new();
    }
}
