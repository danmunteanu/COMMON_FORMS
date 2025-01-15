using RealityFrameworks.Conditions;

namespace CommonForms
{
    public partial class EditorHasExtension : EditorBase
    {
        private const string KExtensionSeparator = ";";

        private static string[] _docExt = [
            "doc", "docx", "pdf"
        ];

        public EditorHasExtension()
        {
            InitializeComponent();

            txtAddExt.Select();
        }

        public override bool ValidateState()
        {
            List<string> listExt = txtExtensions.Text.Split(KExtensionSeparator, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (listExt.Count <= 0)
            {
                PushError(Locale.EDITOR_HAS_EXTENSION_ERR_MSG_MUST_ADD_EXT);
                return false;
            }

            return true;
        }

        public override void LoadState(Condition cond)
        {
            if (cond is ConditionHasExtension hasExt)
            {
                txtExtensions.Clear();
                AddExtensions(hasExt.GetExtensionsArray());
            }
        }

        public override void SaveState(Condition cond)
        {
            if (cond is ConditionHasExtension hasExt)
            {
                string[] tokens = txtExtensions.Text.Split(KExtensionSeparator, StringSplitOptions.RemoveEmptyEntries);

                hasExt.ClearExtensions();
                foreach (string ext in tokens)
                    hasExt.AddExtension(ext);
            }
        }

        private void btnAddExt_Click(object sender, EventArgs e)
        {
            //  Add Extension
            if (txtAddExt.Text.Length > 0)
            {
                string[] tokens = txtAddExt.Text.Split(KExtensionSeparator, StringSplitOptions.RemoveEmptyEntries);

                AddExtensions(tokens);

                txtAddExt.Clear();
            }
        }

        private void btnClearExt_Click(object sender, EventArgs e)
        {
            //  Clear Extensions
            txtExtensions.Clear();
        }

        private void AddExtensions(string[] _arrayExt)
        {
            int arrCount = _arrayExt.Count();

            //  Tokenize extensions
            List<string> listExt = txtExtensions.Text.Split(KExtensionSeparator, StringSplitOptions.RemoveEmptyEntries).ToList();

            //  Add each extensions if it's not already added
            for (int i = 0; i < arrCount; i++)
            {
                string whatToAdd = _arrayExt[i] + KExtensionSeparator;

                if (!listExt.Contains(_arrayExt[i]))
                    txtExtensions.Text = txtExtensions.Text.Insert(txtExtensions.Text.Length, whatToAdd);
            }
        }

        private void btnImages_Click(object sender, EventArgs e)
        {
            AddExtensions(Utils.ImageFileExtensions);
        }

        private void btnDocExt_Click(object sender, EventArgs e)
        {
            AddExtensions(_docExt);
        }

        private void btnTextExt_Click(object sender, EventArgs e)
        {
            AddExtensions(Utils.YamlFileExtensions);
        }

        private void btnArchives_Click(object sender, EventArgs e)
        {
            AddExtensions(Utils.ArchiveFileExtensions);
        }
    }
}
