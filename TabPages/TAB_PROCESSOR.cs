using RealityFrameworks;
using CommonForms.Components;

namespace CommonForms
{
    public partial class TAB_Processor : ApplicationPageBase
    {
        private DialogSelectTransform mDlgSelTrans = new();

        List<string> _conditionNames = new();
        List<string> _actionNames = new();

        public List<string> ConditionNames
        {
            get { return _conditionNames; }
            set
            {
                _conditionNames = value;
                mDlgSelTrans.LoadConditionNames(value);
            }
        }

        public List<string> ActionNames
        {
            get { return _actionNames; }
            set
            {
                _actionNames = value;
                mDlgSelTrans.LoadActionNames(value);
            }
        }

        public TAB_Processor()
        {
            InitializeComponent();

            lstProcessor.HorizontalScrollbar = true;

            mDlgSelTrans.OnModified = () => 
            { 
                ReloadProcessor(); 
                UpdateUI(); 
            };

            //mFilesProcessor.AddFolder(@"E:\EXILE_3.25", true);
            //mFilesProcessor.AddFolder(@"e:\Path of Building\Data\", true);

            UpdateLocalizations();
        }

        protected override void OnProcessorSet()
        {
            mDlgSelTrans.Processor = this.Processor;

            ReloadProcessor();

            UpdateUI();
        }

        private void UpdateLocalizations()
        {
            //	reload localization strings
        }

        private void lstProcessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Processor == null) return;

            if (lstProcessor.SelectedIndex == -1)
                return;

            bool haveSelection = lstProcessor.SelectedIndex != -1;

            btnEdit.Enabled = haveSelection;
            btnEnableDisable.Enabled = haveSelection;
            btnEnableDisable.Text = Processor.GetTransformAt(lstProcessor.SelectedIndex).Enabled ? "D" : "E";
            btnDel.Enabled = haveSelection;
        }

        //	Reloads Changes from Processor
        private void ReloadProcessor()
        {
            if (Processor == null) return;
            lstProcessor.Items.Clear();
            for (int idx = 0; idx < Processor.CountChanges(); idx++)
            {
                var item = Processor.GetTransformAt(idx);
                lstProcessor.Items.Add(item.Description);
            }
        }

        //	Updates the UI state based on the Processor state
        public override void UpdateUI()
        {
            if (Processor == null)
                return;

            bool hasFiles = Processor.CountFileNames() > 0;
            bool hasChanges = Processor.CountChanges() > 0;
            bool hasSelection = lstProcessor.SelectedIndex != -1;

            btnProcess.Enabled = hasFiles;

            btnAdd.Enabled = true;
            btnEdit.Enabled = hasSelection;
            btnEnableDisable.Enabled = hasSelection;
            btnDel.Enabled = hasSelection;
            btnClear.Enabled = hasChanges;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (Processor == null)
                return;

            //  process all files in the list
            Processor.Process();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mDlgSelTrans.LoadState(DialogSelectTransform.EditorState.Add);
            mDlgSelTrans.ShowDialog(this);
        }

        //	Displays the Edit Change dialog for the selected Change
        private void OnEditSelection()
        {
            if (Processor == null) return;
            if (lstProcessor.SelectedIndex < 0) return;

            //  get current change
            Transform<string> transform = Processor.GetTransformAt(lstProcessor.SelectedIndex);
            mDlgSelTrans.LoadState(DialogSelectTransform.EditorState.Edit, transform);
            mDlgSelTrans.ShowDialog(this);
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
            //	TODO: Localize strings
            string title = "Heads up!";
            string msg = string.Format("You are about to remove {0} change(s) from the processor.\n\nAre you sure you want to continue?", Processor.CountChanges());
            DialogResult answer = MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                //	TODO: Link Clear changes to a delegate? 
                //	Maybe call ReloadProcessor and UpdateUI automatically when ClearChanges is Called
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            //  OnDelSelection();
        }

        private void btnEnableDisable_Click(object sender, EventArgs e)
        {
            if (Processor == null) return;
            if (lstProcessor.SelectedIndex < 0) return;

            //  get current transform
            Transform<string> tr = Processor.GetTransformAt(lstProcessor.SelectedIndex);
            tr.Enabled = !tr.Enabled;

            btnEnableDisable.Text = tr.Enabled ? "D" : "E";
        }
    }
}
