using System.Windows.Forms;

namespace CommonForms
{
    public partial class FilesListControl : ApplicationPageBase
    {
        //  TYPES
        public delegate void UpdateUIDelegate();
        public delegate void UpdateProgressDelegate(int progress);
        public delegate void SelectionChangedDelegate(string item);

        //  DELEGATES
        //  this will be called when pages have to update their UI
        public UpdateUIDelegate? UpdateUICallback { get; set; } = null;

        //  this is called when the progress bar needs to be updated
        //  the list component updates the local progress bar first 
        //  but if you need to update progress somewhere else, be my guest
        public UpdateProgressDelegate? UpdateProgressCallback { get; set; } = null;

        //  this is called everytime the list selection is changed
        public SelectionChangedDelegate? SelectionChangedCallback { get; set; } = null;

        /// <summary>
        /// Should enable or disable usage of the progress bar - later.
        /// </summary>
        /// 
        private bool _useProgressBar = true;
        public bool UseProgressBar
        {
            get { return _useProgressBar; }
            set { _useProgressBar = value; OnUseProgressBarSet(); }
        }

        private bool _useStatus = true;
        public bool UseStatus
        {
            get { return _useStatus; }
            set { _useStatus = value; OnUseStatusSet(); }
        }

        /// <summary>
        /// Sets the status string
        /// </summary>
        public string Status
        {
            get { return lblStatus.Text; }
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
        private List<string> mFileFilters = new();
        public List<string> FileFilters
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
            UpdateStatusCallback = this.UpdateStatusLocal;

            //  empty the status
            CallUpdateStatus(string.Empty);

            UpdateUILocal();
        }

        /// <summary>
        /// A default status updater, updates the local status label with the message.
        /// </summary>
        /// <param name="message">The message will be set as the status</param>
        private void UpdateStatusLocal(string message)
        {
            lblStatus.Text = message;
        }

        public void UpdateUILocal()
        {
            bool selectAllVisible = (
                lstFiles.SelectionMode == SelectionMode.MultiSimple ||
                lstFiles.SelectionMode == SelectionMode.MultiExtended
            );
            btnSelectDesel.Visible = selectAllVisible;
            btnSelectDesel.Enabled = selectAllVisible && lstFiles.Items.Count > 0;
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
                btnAdd.Text = Locale.FILE_LIST_BUTTON_ADD;
                btnRem.Text = Locale.FILE_LIST_BUTTON_REM;
                btnClear.Text = Locale.FILE_LIST_BUTTON_CLEAR;
            }
        }

        private void OnUseProgressBarSet()
        {
            if (!UseProgressBar)
            {
                //  remove the progress bar;
                RemoveRow(tableLayoutFiles, 3);
            }
        }

        private void OnUseStatusSet()
        {
            if (!UseStatus)
            {
                RemoveRow(tableLayoutFiles, 2);
            }
        }

        private void RemoveRow(TableLayoutPanel tableLayoutPanel, int rowIndex)
        {
            // Remove controls from the specified row
            for (int column = 0; column < tableLayoutPanel.ColumnCount; column++)
            {
                var control = tableLayoutPanel.GetControlFromPosition(column, rowIndex);
                if (control != null)
                {
                    tableLayoutPanel.Controls.Remove(control);
                    control.Dispose();
                }
            }

            // Shift all rows after the removed row up by one
            for (int row = rowIndex + 1; row < tableLayoutPanel.RowCount; row++)
            {
                for (int column = 0; column < tableLayoutPanel.ColumnCount; column++)
                {
                    var control = tableLayoutPanel.GetControlFromPosition(column, row);
                    if (control != null)
                    {
                        tableLayoutPanel.SetRow(control, row - 1);
                    }
                }
            }

            // Remove the last row style
            if (rowIndex < tableLayoutPanel.RowStyles.Count)
            {
                tableLayoutPanel.RowStyles.RemoveAt(tableLayoutPanel.RowStyles.Count - 1);
            }

            // Decrement the row count
            tableLayoutPanel.RowCount--;
        }


        private void AddFilesFromFolder(string folder)
        {
            if (folder == null || folder == "")
                return;

            //  clear the list 
            lstFiles.Items.Clear();
            Processor.ClearFileNames();

            //  folder must exist
            if (!Directory.Exists(folder))
                return;

            //  Add file names to mFilesToProcess
            DirectoryInfo di = new(folder);
            IEnumerable<FileInfo> files = di.GetFilesByExtensions(mFileFilters.ToArray());
            foreach (FileInfo fi in files)
            {
                Processor.AddFileName(fi.FullName);
            }

            //  reload mFilesToProcess into the list
            ReloadFilesList();

            //  Forces all listeners to update their UI
            UpdateUILocal();
            CallUpdateUI();
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
                CallUpdateStatus(Locale.STATUS_FOLDER_ADDED);
            }
            else
            {
                CallUpdateStatus(Locale.STATUS_FOLDER_NOT_ADDED);
            }

            //  Reset progress bar
            CallUpdateProgress(0);

            UpdateUILocal();
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
            Processor.ClearFileNames();
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
                    IEnumerable<FileInfo> files = di.GetFilesByExtensions(mFileFilters.ToArray());
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
                CallUpdateUI();
            }

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

        private bool _selectAll = true;     //  true = select all, false = deselect all

        private void btnSelectDesel_Click(object sender, EventArgs e)
        {
            if (lstFiles.SelectionMode == SelectionMode.MultiSimple ||
                lstFiles.SelectionMode == SelectionMode.MultiExtended)
            {
                for (int idx = 0; idx < lstFiles.Items.Count; idx++)
                {
                    lstFiles.SetSelected(idx, _selectAll);
                }

                btnSelectDesel.Text = _selectAll ? "DESELECT ALL" : "SELECT ALL";
                _selectAll = !_selectAll;                
            }
        }
    }
}
