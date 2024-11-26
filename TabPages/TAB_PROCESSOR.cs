using RealityFrameworks;

namespace CommonForms
{
    public partial class TAB_Processor : ApplicationPageBase
    {
        private DialogSelectChange? mDlgEditChange = new();

        List<string> _conditionNames = new();
        List<string> _actionNames = new();

        public List<string> ConditionNames
        {
            get { return _conditionNames; }
            set
            {
                _conditionNames = value;
                mDlgEditChange?.LoadConditionNames(value);
            }
        }

        public List<string> ActionNames
        {
            get { return _actionNames; }
            set
            {
                _actionNames = value;
                mDlgEditChange?.LoadActionNames(value);
            }
        }

        public TAB_Processor()
        {
            InitializeComponent();

            lstProcessor.HorizontalScrollbar = true;

            mDlgEditChange.Reload = () => { ReloadProcessor(); UpdateUI(); };

            //mFilesProcessor.AddFolder(@"E:\EXILE_3.25", true);
            //mFilesProcessor.AddFolder(@"e:\Path of Building\Data\", true);
        }

        protected override void OnProcessorSet()
        {
            mDlgEditChange.Processor = this.Processor;

            ReloadProcessor();

            UpdateUI();
        }

        protected override void OnResourceSet()
        {
            //  Update Localizations
        }

        private void lstProcessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProcessor.SelectedIndex == -1)
                return;

            if (Processor == null)
                return;

            btnEdit.Enabled = lstProcessor.SelectedIndex != -1;
        }

        private void ReloadProcessor()
        {
            lstProcessor.Items.Clear();
            for (int idx = 0; idx < mFilesProcessor.CountChanges(); idx++)
            {
                var item = mFilesProcessor.GetChangeAt(idx);
                lstProcessor.Items.Add(item.Description);
            }
        }

        public override void UpdateUI()
        {
            bool hasFiles = Processor.CountFileNames() > 0;
            bool hasChanges = Processor.CountChanges() > 0;
            bool hasChangeSelected = lstProcessor.SelectedIndex != -1;

            btnProcess.Enabled = hasFiles;

            btnAdd.Enabled = true;
            btnEdit.Enabled = hasChangeSelected;
            btnClear.Enabled = hasChanges;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            //  process all files in the list
            //Processor.Process();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mDlgEditChange.LoadState(DialogSelectChange.EditorState.Add);
            mDlgEditChange.ShowDialog(this);
        }

        private void OnEditSelection()
        {
            if (lstProcessor.SelectedIndex < 0) return;

            //  get current change
            Change change = mFilesProcessor.GetChangeAt(lstProcessor.SelectedIndex);
            mDlgEditChange.LoadState(DialogSelectChange.EditorState.Edit, change);
            mDlgEditChange.ShowDialog(this);
        }

        private void lstProcessor_DoubleClick(object sender, EventArgs e)
        {
            OnEditSelection();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OnEditSelection();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string title = "Heads up!";
            string msg = string.Format("You are about to remove {0} change(s) from the processor.\n\nAre you sure you want to continue?", Processor.CountChanges());
            DialogResult res = MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Processor.ClearChanges();
                ReloadProcessor();
                UpdateUI();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ReloadProcessor();
            UpdateUI();
        }
    }
}
