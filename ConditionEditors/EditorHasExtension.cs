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

            txtAddExtension.Select();
        }

        public override bool ValidateState()
        {
            //  clear previous errors
            mErrorStack.Clear();

            if (!compListExtensions.HasExtensions())
            {
                PushError(Locale.EDITOR_HAS_EXTENSION_ERR_MSG_MUST_ADD_EXT);
                return false;
            }

            return true;
        }

        public override void LoadState(Condition<string> cond)
        {
            if (cond is ConditionHasExtension hasExt)
            {
                compListExtensions.AddExtensions(hasExt.GetExtensionsArray());
            }
        }

        public override void SaveState(Condition<string> cond)
        {
            if (cond is ConditionHasExtension hasExt)
            {
                hasExt.ClearExtensions();
                hasExt.AddExtensions(compListExtensions.Extensions);
            }
        }

        public override void ClearState()
        {
            //  just clear the list and the add field
            compListExtensions.Clear();
            txtAddExtension.Clear();
        }

        private void btnAddExt_Click(object sender, EventArgs e)
        {
            //  Add Extension
            if (txtAddExtension.Text.Length > 0)
            {
                string[] tokens = txtAddExtension.Text.Split(KExtensionSeparator, StringSplitOptions.RemoveEmptyEntries);

                compListExtensions.AddExtensions(tokens);

                txtAddExtension.Clear();
            }
        }
    }
}
