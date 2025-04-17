using RealityFrameworks.Actions;

namespace CommonForms
{
    public partial class EditorAppendToFile : EditorBase2
    {
        private ActionAppendToFile? _action = null;

        public ActionAppendToFile? Action
        {
            get { return _action; }
            set { _action = value; LoadState(_action); }
        }

        public EditorAppendToFile()
        {
            InitializeComponent();
        }

        public override void SaveState(object action)
        {
            if (action is ActionAppendToFile amf)
            {
                amf.AppendFileName = txtFileNameAppend.Text;
            }
        }

        public override void LoadState(object action)
        {
            if (action is ActionAppendToFile amf)
            {
                txtFileNameAppend.Text = amf.AppendFileName;
            }
        }

        public override bool ValidateState()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtFileNameAppend.Text))
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
                txtFileNameAppend.Text = dlgSaveFile.FileName;
            }
        }
    }
}
