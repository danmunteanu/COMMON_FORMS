using RealityFrameworks.Actions;
using System.ComponentModel;

namespace CommonForms
{
    public partial class EditorRenameFile : EditorBase
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
        }

        public override void LoadState(RealityFrameworks.Actions.Action action)
        {
            if (action is ActionRenameFile arf)
            {
                txtExtension.Text = arf.Extension;
                txtPrefix.Text = arf.Prefix;
                txtCustom.Text = arf.NewFileName;
            }
        }

        public override void SaveState(RealityFrameworks.Actions.Action action)
        {
            if (action is ActionRenameFile arf)
            {
                arf.Extension = txtExtension.Text;
                arf.Prefix = txtPrefix.Text;
                arf.NewFileName = txtCustom.Text;
            }
        }

        private void chkAddPrefix_CheckedChanged(object sender, EventArgs e)
        {
            txtPrefix.Enabled = chkAddPrefix.Checked;

            if (chkAddPrefix.Checked)
                chkCustom.Checked = false;
        }

        private void chkNewExt_CheckedChanged(object sender, EventArgs e)
        {
            txtExtension.Enabled = chkExtension.Checked;

            if (chkExtension.Checked)
                chkCustom.Checked = false;
        }

        private void chkCustom_CheckedChanged(object sender, EventArgs e)
        {
            txtCustom.Enabled = chkCustom.Checked;

            if (chkCustom.Checked)
            {
                chkAddPrefix.Checked = false;
                chkExtension.Checked = false;
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
