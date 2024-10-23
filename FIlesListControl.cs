using RealityFrameworks;
using System.Data;
using System.Resources;
using System.Text;

namespace CommonForms
{   
    public partial class FilesListControl : UserControl
    {
        public delegate void UpdateStatusDelegate(string message);
        public delegate void ToggleUIDelegate();
        public delegate void UpdateProgressDelegate(int progress);

        public UpdateStatusDelegate UpdateStatus { get; set; } = null;
        public ToggleUIDelegate ToggleUI { get; set; } = null;
        public UpdateProgressDelegate UpdateProgress { get; set; } = null;

        public bool UseProgressBar { get; set; } = true;

        private void CallUpdateStatus(string message)
        {
            if (UpdateStatus != null) 
                UpdateStatus(message);
        }

        private void CallToggleUI()
        {
            if (ToggleUI != null)
                ToggleUI();
        }

        private void CallUpdateProgress(int percent)
        {
            if (UpdateProgress != null)
                UpdateProgress(percent);
        }

        public FilesProcessor Processor { get; set; } = null;
        public ResourceManager Resource { get; set; } = null;

        private string[] mFileFilters = [".md", ".txt"];

        public string[] FileFilters
        {
            get { return mFileFilters; }

            //  is this the right way? shouldn't we be copying the array instead?
            set { mFileFilters = value; }
        }

        public FilesListControl()
        {
            InitializeComponent();

            lstFiles.HorizontalScrollbar = true;
            lstFiles.SelectionMode = SelectionMode.None;

            UpdateStatus = this.UpdateStatusLocal;

            CallUpdateStatus(string.Empty);
        }

        private void UpdateStatusLocal(string message)
        {
            lblStatus.Text = message;
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

            //  enable mass update button
            //btnMassAddYaml.Enabled = true;

            CallToggleUI();
        }
        private void ReloadFilesList()
        {
            lstFiles.Items.Clear();
            for (int idx = 0; idx < Processor.CountFileNames(); idx++)
            {
                var item = Processor.GetFileNameAt(idx);
                lstFiles.Items.Add(item);
            }
        }

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
                    CallUpdateStatus(string.Format(Resource?.GetString("STATUS_FOLDER_NOT_ADDED")));
            }
            //  Reset progress bar
            CallUpdateProgress(0);
        }

        private void btnClearFiles_Click(object sender, EventArgs e)
        {
            //  clear inner list and list ui
            Processor.ClearFileNames();
            lstFiles.Items.Clear();
            CallUpdateStatus(Resource?.GetString("STATUS_LIST_CLEARED"));

            CallToggleUI();
        }

        private void btnReloadFolder_Click(object sender, EventArgs e)
        {
            AddFilesFromFolder(mFolderBrowserDialog.SelectedPath);
            if (Resource != null)
                CallUpdateStatus(Resource.GetString("STATUS_FOLDER_RELOADED"));

            CallToggleUI();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear inner list and list ui
            Processor.ClearFileNames();
            lstFiles.Items.Clear();
            CallUpdateStatus(Resource?.GetString("STATUS_LIST_CLEARED"));

            CallToggleUI();
        }

        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFiles.SelectedItem == null)
                return;

            //mTabUpdateYaml.SelectedFile = lstFiles.SelectedItem.ToString();
        }
    }
}
