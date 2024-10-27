using RealityFrameworks;

namespace CommonForms
{
    public partial class TAB_Processor : ControlBase
    {
        List<RealityFrameworks.Condition> mConditionsAvailable = new();
        List<RealityFrameworks.Action> mActionsAvailable = new();

        RealityFrameworks.Action mSelAction = null;
        RealityFrameworks.Condition mSelCond = null;

        private DialogChangeForm mDlgEditChange = new();

        public TAB_Processor()
        {
            InitializeComponent();

            lstProcessor.HorizontalScrollbar = true;

            //  Setup Add Dialog
            mDlgEditChange.Parent = this.Parent;


            //  Load Available Conditions
            mConditionsAvailable.Add(new ConditionHasExtension(".pdf"));
            //mConditionsAvailable.Add(new ConditionHasExtension(".txt"));
            mConditionsAvailable.Add(new ConditionIsFolder());

            //  Load Available Actions
            mActionsAvailable.Add(new ActionCopyFile(@"TEMP"));
            mActionsAvailable.Add(new ActionMergeFiles());
            mActionsAvailable.Add(new ActionRenameFile());

            mDlgEditChange.LoadConditions(mConditionsAvailable);
            mDlgEditChange.LoadActions(mActionsAvailable);




            /*****************************/
            /*** PROCESSOR STATE Stuff ***/
            /*****************************/

            //mFilesProcessor.AddFolder(@"E:\EXILE_3.25", true);
            //mFilesProcessor.AddFolder(@"e:\Path of Building\Data\", true);

        }

        protected override void OnProcessorSet()
        {
            ReloadChangeList();
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

            Change ch = Processor.GetChangeAt(lstProcessor.SelectedIndex);

            UserControl editCond = EditorFactory.CreateConditionEditor(ch.Condition);
            //AddUserControl(panelCondition, editCond);

            //try
            //{
            //    UserControl editAction = EditorFactory.CreateActionEditor(ch.Action);
            //    AddUserControl(panelAction, editAction);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void ReloadChangeList()
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

            ReloadChangeList();

            //ToggleMassAddUI();
        }

        public override void UpdateUI()
        {
            //bool addPair = (cmbCondition.SelectedIndex != -1 && cmbAction.SelectedIndex != -1);
            //btnAddPair.Enabled = addPair;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            //  process all files in the list
            //Processor.Process();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mDlgEditChange.LoadState(DialogChangeForm.EditorState.Add);
            mDlgEditChange.ShowDialog(this);
        }

        private void OnEditSelection()
        {
            if (lstProcessor.SelectedIndex < 0) return;

            //  get current change
            Change ch = mFilesProcessor.GetChangeAt(lstProcessor.SelectedIndex);
            mDlgEditChange.LoadState(DialogChangeForm.EditorState.Edit, ch);
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
