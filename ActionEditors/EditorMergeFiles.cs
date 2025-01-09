using RealityFrameworks.Actions;

namespace CommonForms
{
    public partial class EditorMergeFiles : EditorBase
    {
        private ActionMergeTextFiles _action = null;

        public ActionMergeTextFiles Action
        {
            get { return _action; }
            set { _action = value; LoadState(_action); }
        }

        public EditorMergeFiles()
        {
            InitializeComponent();
        }

        public override void SaveState(RealityFrameworks.Actions.Action action)
        {
            if (action is ActionMergeTextFiles amf)
            {
                amf.OutputFile = txtMergeName.Text;
            }
        }

        public override void LoadState(RealityFrameworks.Actions.Action action)
        {
            if (action is ActionMergeTextFiles amf)
            {
                txtMergeName.Text = amf.OutputFile;
            }
        }

        private void LoadState(ActionMergeTextFiles amf)
        {
            //  Load Stuff from amf
        }

        public override bool ValidateState()
        {
            return true;
        }

        private void btnSelectMergeName_Click(object sender, EventArgs e)
        {
            dlgSaveFile.FileName = "MERGE_FILE.txt";
            dlgSaveFile.DefaultExt = "txt";
            dlgSaveFile.Filter = "Text files|*.txt";
            DialogResult res = dlgSaveFile.ShowDialog();
            if (res == DialogResult.OK)
            {
                txtMergeName.Text = dlgSaveFile.FileName;
            }
        }
    }
}
