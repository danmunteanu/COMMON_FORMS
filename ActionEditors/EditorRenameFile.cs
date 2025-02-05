using RealityFrameworks.Actions;
using System.ComponentModel;

namespace CommonForms
{
    public partial class EditorRenameFile : EditorBase<string>
    {
        public EditorRenameFile()
        {
            InitializeComponent();

            chkAddPrefix.Checked = false;
            txtPrefix.Enabled = false;

            chkExtension.Checked = false;
            txtExtension.Enabled = false;

            chkCustom.Checked = false;
            txtCustom.Enabled = false;

            UpdateUI();
        }

        public override void LoadState(RealityFrameworks.Actions.Action<string> action)
        {
            if (action is ActionRenameFile arf)
            {
                txtExtension.Text = arf.Extension;
                txtPrefix.Text = arf.Prefix;
                txtCustom.Text = arf.NewFileName;
            }
        }

        public override void SaveState(RealityFrameworks.Actions.Action<string> action)
        {
            if (action is ActionRenameFile arf)
            {
                arf.Extension = txtExtension.Text;
                arf.Prefix = txtPrefix.Text;
                arf.NewFileName = txtCustom.Text;
            }
        }

        public override bool ValidateState()
        {
            bool hasRename =
                (chkAddPrefix.Checked && (!string.IsNullOrEmpty(txtPrefix.Text))) ||
                (chkExtension.Checked && (!string.IsNullOrEmpty(txtExtension.Text)) ||
                (chkCustom.Checked && (!string.IsNullOrEmpty(txtCustom.Text))));

            return hasRename;
        }

        private void UpdateUI()
        {
            //  Add Prefix
            txtPrefix.Enabled = chkAddPrefix.Checked;
            dpDate.Enabled = chkAddPrefix.Checked;
            btnUseDate.Enabled = chkAddPrefix.Checked;

            //  Extension
            txtExtension.Enabled = chkExtension.Checked;
            btnTxt.Enabled = chkExtension.Checked;
            btnMD.Enabled = chkExtension.Checked;
            btnClearExt.Enabled = chkExtension.Checked;

            if (chkAddPrefix.Checked)
                chkCustom.Checked = false;
        }

        private void chkAddPrefix_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();

            if (chkAddPrefix.Checked)
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
                chkAddPrefix.Checked = false;
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
