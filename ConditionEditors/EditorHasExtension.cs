using System.ComponentModel;

namespace CommonForms
{
    public partial class EditorHasExtension : EditorBase
    {
        public EditorHasExtension()
        {
            InitializeComponent();

            txtExt.Select();
        }

        public override bool ValidateState()
        {
            if (lstExtensions.Items.Count <= 0)
            {
                const string errmsg = "Must add at least one extension.";
                mErrors.Push(errmsg);
                return false;
            }

            return true;
        }

        public override void SaveState()
        {
            //base.SaveState();

            //  UI -> Condition
        }

        private void btnAddExt_Click(object sender, EventArgs e)
        {
            //  Add Extension
            if (txtExt.Text.Length > 0)
            {
                string[] tokens = txtExt.Text.Split(';');
                foreach (var token in tokens)
                {
                    string trimToken = token.Trim(); // Trim spaces around the input

                    if (!lstExtensions.Items.Contains(trimToken))
                        lstExtensions.Items.Add(trimToken);
                }
            }
        }

        private void btnClearExt_Click(object sender, EventArgs e)
        {
            //  Clear Extensions
            lstExtensions.Items.Clear();
        }
    }
}
