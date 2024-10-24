namespace CommonForms
{
    public partial class FilesListControl : ControlBase
    {
        //  TYPES
        public delegate void ToggleUIDelegate();
        public delegate void UpdateProgressDelegate(int progress);
        public delegate void SelectionChangedDelegate(string item);

        //  DELEGATES
        //  this will be called when pages have to update their UI
        public ToggleUIDelegate DelegateUpdateUI { get; set; } = null;

        //  this is called when the progress bar needs to be updated
        //  the list component updates the local progress bar first 
        //  but if you need to update progress somewhere else, be my guest
        public UpdateProgressDelegate DelegateUpdateProgress { get; set; } = null;

        //  this is called everytime the list selection is changed
        public SelectionChangedDelegate DelegateSelectionChanged { get; set; } = null;

        /// <summary>
        /// Should enable or disable usage of the progress bar - later.
        /// </summary>
        public bool UseProgressBar { get; set; } = true;

        /// <summary>
        /// Sets the status string
        /// </summary>
        public string Status
        {
            set { lblStatus.Text = value; }
        }

        /// <summary>
        /// Sets the progress bar value
        /// </summary>
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

        /// <summary>
        /// The file filters used to add files to the list.
        /// </summary>
        private string[] mFileFilters = [];
        public string[] FileFilters
        {
            get { return mFileFilters; }
            set { mFileFilters = value; }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public FilesListControl()
        {
            InitializeComponent();

            lstFiles.HorizontalScrollbar = true;
            lstFiles.SelectionMode = SelectionMode.None;

            //  provide a default local status updater
            UpdateStatus = this.UpdateStatusLocal;

            //  empty the status
            CallUpdateStatus(string.Empty);
        }

        /// <summary>
        /// A default status updater, updates the local status label with the message.
        /// </summary>
        /// <param name="message">The message will be set as the status</param>
        private void UpdateStatusLocal(string message)
        {
            lblStatus.Text = message;
        }

        /// <summary>
        /// Wraps the call to <c>UpdateStatus</c> performs a null value check
        /// </summary>
        /// <param name="message">The message passed to the call</param>
        private void CallUpdateStatus(string message)
        {
            if (UpdateStatus != null)
                UpdateStatus(message);
        }

        private void CallToggleUI()
        {
            if (DelegateUpdateUI != null)
                DelegateUpdateUI();
        }

        /// <summary>
        /// This is called when the list's selection changes to pass the 
        /// selected item's value as string to the assigned delegate.
        /// </summary>
        /// <param name="item"></param>
        private void CallOnSelectionChanged(string item)
        {
            if (DelegateSelectionChanged != null)
                DelegateSelectionChanged(item);
        }

        /// <summary>
        /// A wrapper to the UpdateProgress call, checking for null before the call.
        /// </summary>
        /// <param name="percent"></param>
        private void CallUpdateProgress(int percent)
        {
            if (DelegateUpdateProgress != null)
                DelegateUpdateProgress(percent);
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
                lblAddFiles.Text = Resource.GetString("FILE_LIST_LABEL_ADD");
                btnAdd.Text = Resource.GetString("FILE_LIST_BUTTON_ADD");
                btnRem.Text = Resource.GetString("FILE_LIST_BUTTON_REM");
                btnClear.Text = Resource.GetString("FILE_LIST_BUTTON_CLEAR");
            }
        }

        private void AddFilesFromFolder(string folder)
        {
            //  clear the list 
            lstFiles.Items.Clear();
            Processor.ClearFileNames();

            if (folder == null || folder == "")
                return;

            //  folder must exist
            if (!Directory.Exists(folder))
                return;

            //  Add file names to mFilesToProcess
            DirectoryInfo di = new(folder);
            IEnumerable<FileInfo> files = di.GetFilesByExtensions(mFileFilters);
            foreach (FileInfo fi in files)
            {
                Processor.AddFileName(fi.FullName);
            }

            //  reload mFilesToProcess into the list
            ReloadFilesList();

            //  Forces all listeners to update their UI
            CallToggleUI();
        }

        /// <summary>
        /// Clears the list and reloads the list of file names from the Processor
        /// </summary>
        public void ReloadFilesList()
        {
            lstFiles.Items.Clear();
            for (int idx = 0; idx < Processor.CountFileNames(); idx++)
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
                if (Resource != null)
                    CallUpdateStatus(string.Format(Resource.GetString("STATUS_FOLDER_ADDED")));
            }
            else
            {
                if (Resource != null)
                    CallUpdateStatus(string.Format(Resource.GetString("STATUS_FOLDER_NOT_ADDED")));
            }

            //  Reset progress bar
            CallUpdateProgress(0);
        }

        /// <summary>
        /// Handler for button Reload.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReloadFolder_Click(object sender, EventArgs e)
        {
            AddFilesFromFolder(mFolderBrowserDialog.SelectedPath);
            if (Resource != null)
                CallUpdateStatus(Resource.GetString("STATUS_FOLDER_RELOADED"));

            CallToggleUI();
        }

        /// <summary>
        /// Handler for button Clear.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear inner list and list ui
            Processor.ClearFileNames();
            lstFiles.Items.Clear();
            if (Resource != null)
                CallUpdateStatus(Resource.GetString("STATUS_LIST_CLEARED"));

            CallToggleUI();
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
            if (dropItems.Length == 1)
            {
                //  Just 1 File

                //  Get Extension
                string ext = Path.GetExtension(dropItems[0]);

                //  check if extension is allowed
                if (!mFileFilters.Contains(ext.ToLower()))
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        private void listFiles_DragDrop(object sender, DragEventArgs e)
        {
            string[] dropItems = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            bool added = false;
            foreach (string item in dropItems)
            {
                //  is the file a folder?
                if (Directory.Exists(item))
                {
                    //  Get allowed files from this directory
                    DirectoryInfo di = new(item);
                    IEnumerable<FileInfo> files = di.GetFilesByExtensions(mFileFilters);
                    foreach (FileInfo fi in files)
                    {
                        if (!mFilesProcessor.Contains(fi.FullName))
                        {
                            mFilesProcessor.AddFileName(fi.FullName);
                            added = true;
                        }
                    }
                }
                else
                {
                    //  Get Extension
                    string ext = Path.GetExtension(item);

                    //  check if extension is allowed
                    if (mFileFilters.Contains(ext.ToLower()))
                    {
                        if (!mFilesProcessor.Contains(item))
                        {
                            mFilesProcessor.AddFileName(item);
                            added = true;
                        }
                    }
                }
            }

            if (added)
            {
                ReloadFilesList();
            }

        }

        public void UpdateList(SelectionMode selMode, bool enableList)
        {
            lstFiles.SelectionMode = selMode;
            lstFiles.Enabled = enableList;
        }
    }
}
