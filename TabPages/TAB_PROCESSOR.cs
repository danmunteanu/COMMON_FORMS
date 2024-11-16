using RealityFrameworks;

namespace CommonForms
{
    public partial class TAB_Processor : ApplicationPageBase
    {
        List<string> mConditionNames = new();
        List<string> mActionNames = new();

        List<string> mConditions = new();

        RealityFrameworks.Action mSelAction = null;
        RealityFrameworks.Condition mSelCond = null;

        private DialogSelectChange mDlgEditChange = new();

        public TAB_Processor()
        {
            InitializeComponent();

            lstProcessor.HorizontalScrollbar = true;

            //  THESE SHOULD BE LOADED OUTSIDE OF TAB_PROCESSOR

            //  Load Available Conditions
            mConditionNames.Add(typeof(ConditionHasExtension).Name);
            mConditionNames.Add(typeof(ConditionIsFolder).Name);

            //  Load Available Actions
            mActionNames.Add(typeof(ActionCopyFile).Name);
            mActionNames.Add(typeof(ActionMergeFiles).Name);
            mActionNames.Add(typeof(ActionRenameFile).Name);

            mDlgEditChange.LoadConditionNames(mConditionNames);
            mDlgEditChange.LoadActionNames(mActionNames);

            /*****************************/
            /*** PROCESSOR STATE Stuff ***/
            /*****************************/

            //mFilesProcessor.AddFolder(@"E:\EXILE_3.25", true);
            //mFilesProcessor.AddFolder(@"e:\Path of Building\Data\", true);

        }

        protected override void OnProcessorSet()
        {
            ReloadListOfChanges();

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
        }

        private void ReloadListOfChanges()
        {
            lstProcessor.Items.Clear();
            for (int idx = 0; idx < mFilesProcessor.CountChanges(); idx++)
            {
                var item = mFilesProcessor.GetChangeAt(idx);
                lstProcessor.Items.Add(item.Description);
            }
        }

        private void btnAddPair_Click(object sender, EventArgs e)
        {
            if (!(mSelCond != null && mSelAction != null))
                return;

            mFilesProcessor.AddChange(mSelCond, mSelAction);

            ReloadListOfChanges();

            //ToggleMassAddUI();
        }

        public override void UpdateUI()
        {
            bool hasFiles = Processor.CountFileNames() > 0;

            btnProcess.Enabled = hasFiles;
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
    }
}
