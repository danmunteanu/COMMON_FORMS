using RealityFrameworks;
using CommonForms.Components;

namespace CommonForms
{
    public partial class TAB_Processor : ApplicationPageBase
    {
        private DialogSelectChange mDlgEditChange = new();

        List<string> _conditionNames = new();
        List<string> _actionNames = new();

        public List<string> ConditionNames
        {
            get { return _conditionNames; }
            set
            {
                _conditionNames = value;
                mDlgEditChange.LoadConditionNames(value);
            }
        }

        public List<string> ActionNames
        {
            get { return _actionNames; }
            set
            {
                _actionNames = value;
                mDlgEditChange.LoadActionNames(value);
            }
        }

        public TAB_Processor()
        {
            InitializeComponent();

            lstProcessor.HorizontalScrollbar = true;

            mDlgEditChange.OnModified = () => { ReloadProcessor(); UpdateUI(); };

            //mFilesProcessor.AddFolder(@"E:\EXILE_3.25", true);
            //mFilesProcessor.AddFolder(@"e:\Path of Building\Data\", true);

            UpdateLocalizations();
        }

        protected override void OnProcessorSet()
        {
            mDlgEditChange.Processor = this.Processor;

            ReloadProcessor();

            UpdateUI();
        }

		private void UpdateLocalizations()
		{
			//	reload localization strings
		}

        private void lstProcessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProcessor.SelectedIndex == -1)
                return;

            if (Processor == null)
                return;

            bool haveSelection = lstProcessor.SelectedIndex != -1;

            btnEdit.Enabled = haveSelection;
            btnDel.Enabled = haveSelection;
        }

		//	Reloads Changes from Processor
        private void ReloadProcessor()
        {
			//	TODO: Rename to ReloadList or ReloadChanges
            lstProcessor.Items.Clear();
            for (int idx = 0; idx < mFilesProcessor.CountChanges(); idx++)
            {
                var item = mFilesProcessor.GetChangeAt(idx);
                lstProcessor.Items.Add(item.Description);
            }
        }

		//	Updates the UI state based on the Processor state
        public override void UpdateUI()
        {
            bool hasFiles = Processor.CountFileNames() > 0;
            bool hasChanges = Processor.CountChanges() > 0;
            bool hasSelection = lstProcessor.SelectedIndex != -1;

            //	btnProcess.Enabled = hasFiles;
            btnProcess.Enabled = false;

            btnAdd.Enabled = true;
            btnEdit.Enabled = hasSelection;
            btnDel.Enabled = hasSelection;
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

		//	Displays the Edit Change dialog for the selected Change
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
    }
}
