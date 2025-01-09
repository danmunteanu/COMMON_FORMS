namespace CommonForms.Components
{
    public partial class FilesListComponent : ApplicationPageBase
    {
        //  Settings dialog
        private FilesListSettingsDialog mDlgSettings;

        //  Keeps track of the Select All/Deselect All state
        private bool mSelectAll = true;

        //  The file filters used to add files to the list.
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

            mDlgSettings = new FilesListSettingsDialog(this);

            //  provide a default local status updater
            UpdateStatusCallback = this.UpdateStatusLocal;

            //  empty the status
            CallUpdateStatus(string.Empty);

            UpdateUI();
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
        private void UpdateStatusLocal(string message)
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
            ReloadFilesList();

            //  Forces all listeners to update their UI
            UpdateUI();
            CallUpdateUI();
        }

        /// <summary>
        /// Clears the list and reloads the list of file names from the Processor
        /// </summary>
        public void ReloadFilesList()
        {
            lstFiles.Items.Clear();
            for (int idx = 0; idx < Processor?.CountFileNames(); idx++)
            {
                var item = Processor.GetFileNameAt(idx);
                lstFiles.Items.Add(item);
            }
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

        /// <summary>
        /// Handler for button Clear.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object? sender, EventArgs e)
        {
            //clear inner list and list ui
            Processor?.ClearFileNames();
            lstFiles.Items.Clear();
            CallUpdateStatus(Locale.STATUS_LIST_CLEARED);

            CallUpdateUI();
        }

        /// <summary>
        /// Handler for changing list selection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstFiles_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lstFiles.SelectedItem == null)
                return;

            CallOnSelectionChanged(lstFiles?.SelectedItem.ToString());
        }

        private void listFiles_DragEnter(object? sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;

            string[] dropItems = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            bool isFolder = false;
            foreach (string item in dropItems)
            {
                isFolder = Directory.Exists(item);
                if (!isFolder)
                {
                    string ext = Path.GetExtension(item).ToLower();

                    //  check if extension is allowed
                    if (!mFileFilters.Contains(ext))
                        e.Effect = DragDropEffects.None;
                }
            }
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
                ReloadFilesList();
                CallUpdateUI();
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

                btnSelectAll.Text = mSelectAll ? "DESELECT ALL" : "SELECT ALL";
                mSelectAll = !mSelectAll;
            }
        }

        private void btnSettings_Click(object? sender, EventArgs e)
        {
            //  List's state might have changed, reload them and then display
            mDlgSettings.LoadListSettings();
            mDlgSettings.ShowDialog(this);
        }

        private TableLayoutPanel CreateTopLine()
        {
            //  setup the table layout for the top line
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();

            // BORDER for debugging
            //tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            //  table columns
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // Label
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F)); // Empty space
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // Button 1 (fixed width)
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // Button 2 (fixed width)

            //  label Add Files
            lblAddFiles.Name = "lblAddFiles";
            lblAddFiles.AutoSize = true;
            lblAddFiles.Text = Settings.TopLabel;
            lblAddFiles.TextAlign = ContentAlignment.MiddleLeft;
            lblAddFiles.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            lblAddFiles.Font = new Font(lblAddFiles.Font.FontFamily, 9);

            //  button Select All
            btnSelectAll.Text = "SELECT ALL";
            btnSelectAll.Font = new Font(btnSelectAll.Font.FontFamily, 8);
            btnSelectAll.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSelectAll.AutoSize = true;
            btnSelectAll.Height = 23;
            btnSelectAll.TextAlign = ContentAlignment.MiddleCenter;
            btnSelectAll.Anchor = AnchorStyles.Right;
            Size textSize = TextRenderer.MeasureText(btnSelectAll.Text, btnSelectAll.Font);
            btnSelectAll.Width = textSize.Width + 5;
            btnSelectAll.Height = textSize.Height + 5;
            btnSelectAll.Click -= btnSelectAll_Click;   //  remove prev handler
            btnSelectAll.Click += btnSelectAll_Click;   //  make sure it's only once

            //  button Settings
            btnSettings.Text = "SETTINGS";
            btnSettings.Visible = Settings.SettingsButtonVisible;
            btnSettings.Font = new Font(btnSettings.Font.FontFamily, 8);
            btnSettings.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSettings.AutoSize = true;
            btnSettings.TextAlign = ContentAlignment.MiddleCenter;
            btnSettings.Click -= btnSettings_Click;
            btnSettings.Click += btnSettings_Click;

            //  Add the controls to the layout
            tableLayoutPanel.Controls.Add(lblAddFiles, 0, 0);
            tableLayoutPanel.Controls.Add(btnSelectAll, 2, 0);
            tableLayoutPanel.Controls.Add(btnSettings, 3, 0);

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

            lstFiles.DragEnter -= listFiles_DragEnter;
            lstFiles.DragEnter += listFiles_DragEnter;
            lstFiles.DragDrop -= listFiles_DragDrop;
            lstFiles.DragDrop += listFiles_DragDrop;
            lstFiles.SelectedIndexChanged -= lstFiles_SelectedIndexChanged;
            lstFiles.SelectedIndexChanged += lstFiles_SelectedIndexChanged;

            return lstFiles;
        }

        private Label CreateStatus()
        {
            lblStatus = new Label();
            lblStatus.Text = "Status:";
            lblStatus.Font = new Font(lblStatus.Font.FontFamily, 8);
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            return lblStatus;
        }

        private ProgressBar CreateProgressBar()
        {
            progressBar = new ();
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.Dock = DockStyle.Fill;

            return progressBar;
        }

        private TableLayoutPanel CreateBottomLayout()
        {
            TableLayoutPanel layoutBottomLine = new TableLayoutPanel();
            layoutBottomLine.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            
            // BORDER for debugging
            //layoutBottomLine.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            layoutBottomLine.Dock = DockStyle.Fill;
            layoutBottomLine.AutoSize = true;
            layoutBottomLine.ColumnCount = 5;
            layoutBottomLine.RowCount = 1;

            // Set row style to fill the available height
            layoutBottomLine.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            // Add the column styles
            layoutBottomLine.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // btnAdd
            layoutBottomLine.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // btnReload (square)
            layoutBottomLine.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // btnRem (square)
            layoutBottomLine.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));  // Empty space
            layoutBottomLine.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // btnClear

            // btnAddFolder
            btnAddFiles.Text = Settings.ButtonAddLabel;
            btnAddFiles.Font = new Font(btnAddFiles.Font.FontFamily, 8);
            btnAddFiles.Dock = DockStyle.Fill;
            btnAddFiles.Click -= btnAdd_Click;
            btnAddFiles.Click += btnAdd_Click;
            
            // btnReload
            btnReload.Text = "↻";
            btnReload.Font = new Font(btnReload.Font.FontFamily, 8);
            btnReload.Width = 35;
            btnReload.Dock = DockStyle.Fill; // Ensure it fills the height
            btnReload.Click -= btnReloadFolder_Click;
            btnReload.Click += btnReloadFolder_Click;

            // btnRem
            btnRem.Text = "-";
            btnRem.Font = new Font(btnRem.Font.FontFamily, 8);
            btnRem.Width = 35;
            btnRem.Dock = DockStyle.Fill; // Ensure it fills the height
            
            // btnClear
            btnClear.Text = "CLEAR";
            btnClear.Font = new Font(btnClear.Font.FontFamily, 8);
            btnClear.AutoSize = false;
            btnClear.Dock = DockStyle.Fill;
            btnClear.Click -= btnClear_Click;
            btnClear.Click += btnClear_Click;

            //  Remove padding from all components
            Control[] controls = { btnAddFiles, btnReload, btnRem, btnClear };
            foreach (Control control in controls)
            {
                control.Padding = new Padding(0);
                control.Margin = new Padding(0);
            }

            layoutBottomLine.Controls.Add(btnAddFiles, 0, 0);
            layoutBottomLine.Controls.Add(btnReload, 1, 0);
            layoutBottomLine.Controls.Add(btnRem, 2, 0);
            layoutBottomLine.Controls.Add(btnClear, 4, 0);

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
            masterTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));

            //  ListBox
            lstFiles = CreateListBox();
            lstFiles.Dock = DockStyle.Fill;
            masterTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            //  Status line
            if (Settings.UseStatus)
            {
                lblStatus = CreateStatus();
                lblStatus.Dock = DockStyle.Fill;
                masterTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            }

            //  Progress Bar    
            if (Settings.UseProgressBar)
            {
                progressBar = CreateProgressBar();
                masterTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));
            }

            //  Bottom Buttons
            TableLayoutPanel bottomLayout = CreateBottomLayout();
            masterTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            bottomLayout.Dock = DockStyle.Fill;

            //  Add all controls to the master layout
            int rowIdx = 0;
            masterTableLayout.Controls.Add(topLineLayout, 0, rowIdx++);
            masterTableLayout.Controls.Add(lstFiles, 0, rowIdx++);
            if (Settings.UseStatus && lblStatus != null) masterTableLayout.Controls.Add(lblStatus, 0, rowIdx++);
            if (Settings.UseProgressBar && progressBar != null) masterTableLayout.Controls.Add(progressBar, 0, rowIdx++);
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
        private Label? lblStatus;

        //  Progress bar
        private ProgressBar? progressBar;
        
        //  Bottom
        private Button btnAddFiles = new();
        private Button btnReload = new();
        private Button btnRem = new();
        private Button btnClear = new();
    }
}
