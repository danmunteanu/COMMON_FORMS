using System.Windows.Forms;

namespace CommonForms.Components
{
    public partial class FilesList2 : ApplicationPageBase
    {
        public struct ListSettings
        {
            //  The label above the list
            public string TopLabel { get; set; } = ""; //  FILESLIST_COMPONENT_DEFAULT_ADD_LABEL

            //  The text on button add
            public string ButtonAddLabel { get; set; } = "";   //  FILESLIST_COMPONENT_BTN_ADD_LABEL

            public bool ButtonSettingsVisible { get; set; } = true;

            //  Disables use of status
            public bool UseStatus { get; set; } = false;

            //  Disables use of the progress bar
            public bool UseProgressBar { get; set; } = true;

            //  Allows adding of subfolders
            public bool AddFolders { get; set; } = true;

            //  Allow parsing subfolders when adding folders
            public bool ParseSubfolders { get; set; } = false;

            public ListSettings()
            {
            }
        }

        //  DELEGATE TYPES
        public delegate void UpdateUIDelegate();
        public delegate void UpdateProgressDelegate(int progress);
        public delegate void SelectionChangedDelegate(string item);
        
        //  true = select all, false = deselect all
        private bool mSelectAll = true;

        //  DELEGATES
        //  this will be called when pages have to update their UI
        public UpdateUIDelegate? UpdateUICallback { get; set; } = null;

        //  this is called when the progress bar needs to be updated
        //  the list component updates the local progress bar first 
        //  but if you need to update progress somewhere else, be my guest
        public UpdateProgressDelegate? UpdateProgressCallback { get; set; } = null;

        //  this is called everytime the list selection is changed
        public SelectionChangedDelegate? SelectionChangedCallback { get; set; } = null;

        private ListSettings mSettings = new();
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
            //  Update UI elements based on new settings
            lblAddFiles.Text = mSettings.TopLabel;
            btnAddFiles.Text = mSettings.ButtonAddLabel;

            btnSettings.Visible = mSettings.ButtonSettingsVisible;

            RebuildLayout();
        }

        // Sets the progress bar value
        public int Progress
        {
            get { return progressBar.Value; }
            set
            {
                progressBar.Value = value;

                //progressBar.Invoke((MethodInvoker)delegate {
                //    // Running on the UI thread
                //    progressBar.Value = value;
                //});
            }
        }

        //  The file filters used to add files to the list.
        private List<string> mFileFilters = new();
        public List<string> FileFilters
        {
            get { return mFileFilters; }
            set { mFileFilters = value; }
        }

        private FilesListSettingsDialog _dlgSettings;

        public FilesList2()
        {
            InitializeComponent();

            //  creates all the buttons and components
            CreateMasterLayout();

            _dlgSettings = new FilesListSettingsDialog(this);

            lstFiles.HorizontalScrollbar = true;
            lstFiles.SelectionMode = SelectionMode.None;

            //  provide a default local status updater
            UpdateStatusCallback = this.UpdateStatusLocal;

            //  empty the status
            CallUpdateStatus(string.Empty);

            UpdateUI();

        }

        private void FilesList2_Load(object sender, EventArgs e)
        {
            RebuildLayout();
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
        }

        private void CallUpdateUI()
        {
            if (UpdateUICallback != null)
                UpdateUICallback();
        }

        /// <summary>
        /// This is called when the list's selection changes to pass the 
        /// selected item's value as string to the assigned delegate.
        /// </summary>
        /// <param name="item"></param>
        private void CallOnSelectionChanged(string item)
        {
            if (SelectionChangedCallback != null)
                SelectionChangedCallback(item);
        }

        /// <summary>
        /// A wrapper to the UpdateProgress call, checking for null before the call.
        /// </summary>
        /// <param name="percent"></param>
        private void CallUpdateProgress(int percent)
        {
            if (UpdateProgressCallback != null)
                UpdateProgressCallback(percent);
        }

        /// <summary>
        /// Overrides <c>OnResourceSet</c> from the base class <c>ControlBase</c>
        /// Loads this list's localization strings.
        /// </summary>
        protected override void OnResourceSet()
        {
            //  Load file list localisations
            if (Resource != null)
            {
                //  load topmost string
                lblAddFiles.Text = Locale.FILE_LIST_LABEL_ADD;
                btnAddFiles.Text = Locale.FILE_LIST_BUTTON_ADD;
                btnRem.Text = Locale.FILE_LIST_BUTTON_REM;
                btnClear.Text = Locale.FILE_LIST_BUTTON_CLEAR;
            }
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

        /// <summary>
        /// Handler for the Add button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //  show dialog to select folder
            DialogResult res = mFolderBrowserDialog.ShowDialog();
            if (res == DialogResult.OK && !string.IsNullOrWhiteSpace(mFolderBrowserDialog.SelectedPath))
            {
                AddFilesFromFolder(mFolderBrowserDialog.SelectedPath);
                CallUpdateStatus(Locale.STATUS_FOLDER_ADDED);
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
        private void btnReloadFolder_Click(object sender, EventArgs e)
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
        private void btnClear_Click(object sender, EventArgs e)
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
        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFiles.SelectedItem == null)
                return;

            CallOnSelectionChanged(lstFiles?.SelectedItem.ToString());
        }

        private void listFiles_DragEnter(object sender, DragEventArgs e)
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

        private void listFiles_DragDrop(object sender, DragEventArgs e)
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

        private void btnSelectDeselect_Click(object sender, EventArgs e)
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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //  List's state might have changed, reload them and then display
            _dlgSettings.LoadListSettings();
            _dlgSettings.ShowDialog(this);
        }


        private TableLayoutPanel CreateTopLine()
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.RowCount = 1;

            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // Label
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100)); // Empty space
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // Button 1 (fixed width)
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // Button 2 (fixed width)

            lblAddFiles = new Label();
            lblAddFiles.Text = "↓↓ Add Files To Merge ↓↓";
            lblAddFiles.TextAlign = ContentAlignment.MiddleLeft;
            lblAddFiles.Padding = new Padding(10, 0, 0, 0);
            lblAddFiles.Font = new Font(lblAddFiles.Font.FontFamily, 8);
            lblAddFiles.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;

            btnSelectAll = new ();
            btnSelectAll.Text = "SELECT ALL";
            btnSelectAll.Font = new Font(btnSelectAll.Font.FontFamily, 8);
            btnSelectAll.AutoSize = false;
            btnSelectAll.Height = 23;
            btnSelectAll.TextAlign = ContentAlignment.MiddleCenter;
            btnSelectAll.Anchor = AnchorStyles.Right;
            Size textSize = TextRenderer.MeasureText(btnSelectAll.Text, btnSelectAll.Font);
            btnSelectAll.Width = textSize.Width + 5;
            btnSelectAll.Height = textSize.Height + 5;
            btnSelectAll.Click += btnSelectDeselect_Click;

            btnSettings = new System.Windows.Forms.Button();
            btnSettings.Text = "LIST SETTINGS";
            btnSettings.Font = new Font(btnSettings.Font.FontFamily, 8);
            btnSettings.AutoSize = false;
            btnSettings.Height = 23;
            btnSettings.TextAlign = ContentAlignment.MiddleCenter;
            btnSettings.Anchor = AnchorStyles.Right;
            textSize = TextRenderer.MeasureText(btnSettings.Text, btnSettings.Font);
            btnSettings.Click += btnSettings_Click;

            // Set the button size
            btnSettings.Width = textSize.Width + 5;
            btnSettings.Height = textSize.Height + 5;

            tableLayoutPanel.Controls.Add(lblAddFiles, 0, 0);
            tableLayoutPanel.Controls.Add(btnSelectAll, 2, 0);
            tableLayoutPanel.Controls.Add(btnSettings, 3, 0);

            return tableLayoutPanel;
        }

        private ListBox CreateListBox()
        {
            lstFiles = new ListBox();
            lstFiles.Dock = DockStyle.Fill;
            lstFiles.SelectionMode = SelectionMode.MultiExtended;
            lstFiles.Font = new Font("Arial", 10);

            lstFiles.DragEnter += listFiles_DragEnter;
            lstFiles.DragDrop += listFiles_DragDrop;
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
            TableLayoutPanel buttonTableLayout = new TableLayoutPanel();
            buttonTableLayout.Dock = DockStyle.Fill;
            buttonTableLayout.ColumnCount = 5;
            buttonTableLayout.RowCount = 1;

            buttonTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // btnAdd
            buttonTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40));  // btnReload (square)
            buttonTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40));  // btnRem (square)
            buttonTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70));  // Empty space
            buttonTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // btnClear

            btnAddFiles = new System.Windows.Forms.Button();
            btnAddFiles.Text = "ADD";
            btnAddFiles.Font = new Font(btnAddFiles.Font.FontFamily, 8);
            btnAddFiles.AutoSize = true;
            btnAddFiles.Anchor = AnchorStyles.Left;
            btnAddFiles.Click += btnAdd_Click;

            btnReload = new System.Windows.Forms.Button();
            btnReload.Text = "↻";
            btnReload.Font = new Font(btnReload.Font.FontFamily, 8);
            btnReload.Size = new Size(27, 27);
            btnReload.Anchor = AnchorStyles.Left;
            btnReload.Click += btnReloadFolder_Click;

            btnRem = new System.Windows.Forms.Button();
            btnRem.Text = "-";
            btnRem.Font = new Font(btnRem.Font.FontFamily, 8);
            btnRem.Size = new Size(27, 27);
            btnRem.Anchor = AnchorStyles.Left;

            btnClear = new System.Windows.Forms.Button();
            btnClear.Text = "CLEAR";
            btnClear.Font = new Font(btnClear.Font.FontFamily, 8);
            btnClear.AutoSize = true;
            btnClear.Anchor = AnchorStyles.Left;
            btnClear.Click += btnClear_Click;

            buttonTableLayout.Controls.Add(btnAddFiles, 0, 0);
            buttonTableLayout.Controls.Add(btnReload, 1, 0);
            buttonTableLayout.Controls.Add(btnRem, 2, 0);
            buttonTableLayout.Controls.Add(btnClear, 4, 0);

            return buttonTableLayout;
        }

        private void CreateMasterLayout()
        {
            TableLayoutPanel masterTableLayout = new TableLayoutPanel();
            masterTableLayout.Dock = DockStyle.Fill;
            masterTableLayout.ColumnCount = 1;
            masterTableLayout.RowCount = 5;

            masterTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));
            masterTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            masterTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            masterTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));
            masterTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45));

            TableLayoutPanel topLineLayout = CreateTopLine();
            lstFiles = CreateListBox();
            lblStatus = CreateStatus();
            progressBar = CreateProgressBar();
            TableLayoutPanel buttonLayout = CreateBottomLayout();

            topLineLayout.Dock = DockStyle.Fill;
            lstFiles.Dock = DockStyle.Fill;
            lblStatus.Dock = DockStyle.Fill;
            buttonLayout.Dock = DockStyle.Fill;

            masterTableLayout.Controls.Add(topLineLayout, 0, 0);
            masterTableLayout.Controls.Add(lstFiles, 0, 1);
            masterTableLayout.Controls.Add(lblStatus, 0, 2);
            masterTableLayout.Controls.Add(progressBar, 0, 3);
            masterTableLayout.Controls.Add(buttonLayout, 0, 4);

            this.Controls.Add(masterTableLayout);
        }

        //  The dialog to select folders
        private FolderBrowserDialog mFolderBrowserDialog = new FolderBrowserDialog();

        //  Top bar
        private Label? lblAddFiles;
        private Button? btnSelectAll;
        private Button? btnSettings;
        
        //  Listbox
        private ListBox? lstFiles;
        
        //  Status
        private Label? lblStatus;

        //  Progress bar
        private ProgressBar? progressBar;
        
        //  Bottom
        private Button? btnAddFiles;
        private Button? btnReload;
        private Button? btnRem;
        private Button? btnClear;
    }
}
