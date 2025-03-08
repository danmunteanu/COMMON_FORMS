using RealityFrameworks.Actions;

namespace CommonForms
{
    public partial class EditorRenameFile : EditorBase
    {
        public EditorRenameFile()
        {
            InitializeComponent();

            chkPrefix.Checked = false;
            txtPrefix.Enabled = false;

            chkExtension.Checked = false;
            txtExtension.Enabled = false;

            chkCustom.Checked = false;
            txtCustom.Enabled = false;

            UpdateUI();
        }

        public override void LoadState(FileAction action)
        {
            if (action is ActionRenameFile arf)
            {
                chkPrefix.Checked = !string.IsNullOrEmpty(arf.Prefix);
                txtPrefix.Text = arf.Prefix;

                chkExtension.Checked = !string.IsNullOrEmpty(arf.Extension);
                txtExtension.Text = arf.Extension;

                chkCustom.Checked = !string.IsNullOrEmpty(arf.CustomName);
                txtCustom.Text = arf.CustomName;
            }
        }

        public override void SaveState(FileAction action)
        {
            if (action is ActionRenameFile arf)
            {
                arf.Extension = txtExtension.Text;
                arf.Prefix = txtPrefix.Text;
                arf.CustomName = txtCustom.Text;
            }
        }

        public override void ClearState()
        {
            chkPrefix.Checked = false;
            txtPrefix.Text = string.Empty;

            chkExtension.Checked = false;
            txtExtension.Text = string.Empty;

            chkCustom.Checked = false;
            txtCustom.Text = string.Empty;
        }

        public override bool ValidateState()
        {
            bool hasRename =
                (chkPrefix.Checked && (!string.IsNullOrEmpty(txtPrefix.Text))) ||
                (chkExtension.Checked && (!string.IsNullOrEmpty(txtExtension.Text)) ||
                (chkCustom.Checked && (!string.IsNullOrEmpty(txtCustom.Text))));

            if (chkPrefix.Checked && string.IsNullOrEmpty(txtPrefix.Text))
            {
                PushError("Prefix cannot be empty when adding a prefix");
                return false;
            }

            if (chkExtension.Checked && string.IsNullOrEmpty(txtExtension.Text))
            {
                PushError("Select a valid extension when changing a file's extension");
                return false;
            }

            if (!hasRename)
            {
                PushError("Select one way to rename the file");
                return false;
            }

            return hasRename;
        }

        private void UpdateUI()
        {
            //  Add Prefix
            txtPrefix.Enabled = chkPrefix.Checked;
            dpDate.Enabled = chkPrefix.Checked;
            btnUseDate.Enabled = chkPrefix.Checked;

            //  Extension
            txtExtension.Enabled = chkExtension.Checked;
            btnTxt.Enabled = chkExtension.Checked;
            btnMD.Enabled = chkExtension.Checked;
            btnClearExt.Enabled = chkExtension.Checked;

            if (chkPrefix.Checked)
                chkCustom.Checked = false;
        }

        private void chkAddPrefix_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();

            if (chkPrefix.Checked)
            {
                txtPrefix.Focus();
            }
        }

        private void chkNewExt_CheckedChanged(object sender, EventArgs e)
        {
            txtExtension.Enabled = chkExtension.Checked;

            if (chkExtension.Checked)
            {
                chkCustom.Checked = false;
                txtExtension.Focus();
            }
            
            UpdateUI();
        }

        private void chkCustom_CheckedChanged(object sender, EventArgs e)
        {
            txtCustom.Enabled = chkCustom.Checked;

            if (chkCustom.Checked)
            {
                chkPrefix.Checked = false;
                chkExtension.Checked = false;

                txtCustom.Focus();
            }
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            string ext = "txt";
            if (!txtExtension.Text.Contains(ext))
                txtExtension.Text = ext;
        }

        private void btnMD_Click(object sender, EventArgs e)
        {
            string ext = "md";
            if (!txtExtension.Text.Contains(ext))
                txtExtension.Text = ext;
        }

        private void btnClearExt_Click(object sender, EventArgs e)
        {
            txtExtension.Clear();
        }
    }
}
