using RealityFrameworks.Conditions;
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
                PushError(errmsg);
                return false;
            }

            return true;
        }

        public override void LoadState(Condition cond)
        {
            if (cond is ConditionHasExtension hasExt)
            {
                lstExtensions.Items.Clear();
                for (int idx = 0; idx < hasExt.CountExtensions(); ++idx)
                {
                    lstExtensions.Items.Add(hasExt.GetExtensionAt(idx));
                }
            }
        }

        public override void SaveState(Condition cond)
        {
            if (cond is ConditionHasExtension hasExt)
            {
                hasExt.ClearExtensions();
                foreach (string ext in lstExtensions.Items)
                {
                    hasExt.AddExtension(ext);
                }
            }
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

        private void btnTxt_Click(object sender, EventArgs e)
        {
            string ext = "txt";
            if (!lstExtensions.Items.Contains(ext))
                lstExtensions.Items.Add(ext);
        }

        private void btnMd_Click(object sender, EventArgs e)
        {
            string ext = "md";
            if (!lstExtensions.Items.Contains(ext))
                lstExtensions.Items.Add(ext);
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            string ext = "pdf";
            if (!lstExtensions.Items.Contains(ext))
                lstExtensions.Items.Add(ext);
        }
    }
}
