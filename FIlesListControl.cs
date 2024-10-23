using RealityFrameworks;
using System.Data;
using System.Resources;
using System.Text;

namespace CommonForms
{   
    public partial class FIlesListControl : UserControl
    {
        public delegate void UpdateStatusDelegate(string message);
        public delegate void ToggleUIDelegate();
        public delegate void UpdateProgressDelegate(int progress);

        public UpdateStatusDelegate UpdateStatus { get; set; } = null;
        public ToggleUIDelegate ToggleUI { get; set; } = null;

        public UpdateProgressDelegate UpdateProgress { get; set; } = null;

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

        public FilesProcessor FilesProcessor { get; set; } = null;
        public ResourceManager Resource { get; set; } = null;

        private string[] mFileFilters = [".md", ".txt"];

        public string[] FileFilters
        {
            get { return mFileFilters; }

            //  is this the right way? shouldn't we be copying the array instead?
            set { mFileFilters = value; }
        }

        public FIlesListControl()
        {
            InitializeComponent();
        }

        private void AddFilesFromFolder(string folder)
        {
            //  clear the list 
            lstFiles.Items.Clear();
            FilesProcessor.ClearFileNames();

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
                FilesProcessor.AddFileName(fi.FullName);
            }

            //  reload mFilesToProcess into the list
            ReloadFilesList();

            //  enable mass update button
            //btnMassAddYaml.Enabled = true;
            CallUpdateStatus(string.Empty);

            CallToggleUI();
        }
        private void ReloadFilesList()
        {
            lstFiles.Items.Clear();
            for (int idx = 0; idx < FilesProcessor.CountFileNames(); idx++)
            {
                var item = FilesProcessor.GetFileNameAt(idx);
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
            FilesProcessor.ClearFileNames();
            lstFiles.Items.Clear();
            CallUpdateStatus(Resource?.GetString("STATUS_LIST_CLEARED"));

            CallToggleUI();
        }

        private void btnReloadFolder_Click(object sender, EventArgs e)
        {
            //  Reload the folder
            //  Or the files?
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear inner list and list ui
            FilesProcessor.ClearFileNames();
            lstFiles.Items.Clear();
            CallUpdateStatus(Resource?.GetString("STATUS_LIST_CLEARED"));

            CallToggleUI();
        }
    }
}
