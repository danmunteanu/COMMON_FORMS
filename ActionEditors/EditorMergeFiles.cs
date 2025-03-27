using RealityFrameworks.Actions;
using SharpCompress;

namespace CommonForms
{
    public partial class EditorMergeFiles : EditorBase<string>
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

        public override void SaveState(RealityFrameworks.Actions.Action<string> action)
        {
            if (action is ActionMergeTextFiles amf)
            {
                amf.OutputFile = txtMergeName.Text;
            }
        }

        public override void LoadState(FileAction action)
        {
            if (action is ActionMergeTextFiles amf)
            {
                txtMergeName.Text = amf.OutputFile;
            }
        }

        public override bool ValidateState()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtMergeName.Text))
            {
                PushError("Merge file name cannot be missing. Please select a file name.");
                isValid = false;
            }

            return isValid;
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
