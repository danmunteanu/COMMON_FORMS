using RealityFrameworks;
using CommonForms;

namespace CS_Yaml_Parser.UserControls
{
    public partial class TAB_Processor : TAB_Base
    {
        List<RealityFrameworks.Condition> mConditionsAvailable = new List<RealityFrameworks.Condition>();
        List<RealityFrameworks.Action> mActionsAvailable = new List<RealityFrameworks.Action>();

        RealityFrameworks.Action mSelAction = null;
        RealityFrameworks.Condition mSelCond = null;

        public TAB_Processor()
        {
            InitializeComponent();

            lstProcessor.HorizontalScrollbar = true;

            //  Load Available Conditions
            mConditionsAvailable.Add(new ConditionHasExtension(".pdf"));
            //mConditionsAvailable.Add(new ConditionHasExtension(".txt"));
            mConditionsAvailable.Add(new ConditionIsFolder());

            //  Load Available Actions
            mActionsAvailable.Add(new ActionCopyFile(@"TEMP"));
            mActionsAvailable.Add(new ActionMergeFiles());
            mActionsAvailable.Add(new ActionRenameFile());

            foreach (var condition in mConditionsAvailable)
                cmbCondition.Items.Add(condition.Name);
            cmbCondition.SelectedIndex = 0;

            foreach (var action in mActionsAvailable)
                cmbAction.Items.Add(action.Name);
            cmbAction.SelectedIndex = 0;


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

        private void lstProcessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProcessor.SelectedIndex == -1)
                return;

            if (Processor == null)
                return;

            Change ch = Processor.GetChangeAt(lstProcessor.SelectedIndex);

            UserControl editCond = EditorFactory.CreateConditionEditor(ch.Condition);
            AddUserControl(panelCondition, editCond);

            try
            {
                UserControl editAction = EditorFactory.CreateActionEditor(ch.Action);
                AddUserControl(panelAction, editAction);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddUserControl(Panel panel, UserControl editor)
        {
            editor.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(editor);
            editor.BringToFront();
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

        private void cmbCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            mSelCond = mConditionsAvailable.ElementAt(cmbCondition.SelectedIndex);
        }

        private void cmbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            mSelAction = mActionsAvailable.ElementAt(cmbAction.SelectedIndex);
        }

        public void ToggleUI()
        {
            bool addPair = (cmbCondition.SelectedIndex != -1 && cmbAction.SelectedIndex != -1);
            btnAddPair.Enabled = addPair;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            //  process all files in the list
        }
    }
}
