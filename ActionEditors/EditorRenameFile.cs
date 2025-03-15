using RealityFrameworks.Actions;

namespace CommonForms
{
    public partial class EditorRenameFile : EditorBase
    {
        public EditorRenameFile()
        {
            InitializeComponent();

            chkAddPrefix.Checked = false;
            txtPrefix.Enabled = false;

            chkChangeExtension.Checked = false;
            txtExtension.Enabled = false;

            chkCustomName.Checked = false;
            txtCustom.Enabled = false;

            LoadExtensions();

            UpdateUI();
        }

        private void LoadExtensions()
        {
            menuStripExtensions.Items.Clear();

            var yamlItem = new ToolStripMenuItem("YAML");
            var imageItem = new ToolStripMenuItem("IMAGE");
            var audioItem = new ToolStripMenuItem("AUDIO");

            //  yaml
            foreach (var ext in Utils.YamlFileExtensions)
                yamlItem.DropDownItems.Add(ext, null, MenuItem_Click);

            foreach (var ext in Utils.ImageFileExtensions)
                imageItem.DropDownItems.Add(ext, null, MenuItem_Click);

            foreach (var ext in Utils.AudioFileExtensions)
                audioItem.DropDownItems.Add(ext, null, MenuItem_Click);

            menuStripExtensions.Items.Add(yamlItem);
            menuStripExtensions.Items.Add(imageItem);
            menuStripExtensions.Items.Add(audioItem);
        }

        public override void LoadState(FileAction action)
        {
            if (action is ActionRenameFile arf)
            {
                chkAddPrefix.Checked = arf.RenameType.HasFlag(ActionRenameFile.ERenameType.AddPrefix);
                chkRemovePrefix.Checked = arf.RenameType.HasFlag(ActionRenameFile.ERenameType.RemovePrefix);
                txtPrefix.Text = arf.Prefix;

                chkChangeExtension.Checked = arf.RenameType.HasFlag(ActionRenameFile.ERenameType.ChangeExtension);
                txtExtension.Text = arf.Extension;

                chkCustomName.Checked = arf.RenameType.HasFlag(ActionRenameFile.ERenameType.CustomName);
                txtCustom.Text = arf.CustomName;
            }
        }

        public override void SaveState(FileAction action)
        {
            if (action is ActionRenameFile arf)
            {
                arf.Extension = txtExtension.Text;

                arf.RenameType = ActionRenameFile.ERenameType.Undefined;

                if (chkAddPrefix.Checked)
                    arf.RenameType |= ActionRenameFile.ERenameType.AddPrefix;

                if (chkRemovePrefix.Checked)
                    arf.RenameType |= ActionRenameFile.ERenameType.RemovePrefix;

                //  ADD SUFFIX: LATER

                if (chkChangeExtension.Checked)
                    arf.RenameType |= ActionRenameFile.ERenameType.ChangeExtension;

                if (chkCustomName.Checked)
                    arf.RenameType |= ActionRenameFile.ERenameType.CustomName;

                //  set the fields
                arf.Prefix = txtPrefix.Text;
                arf.Extension = txtExtension.Text;
                arf.CustomName = txtCustom.Text;
            }
        }

        public override void ClearState()
        {
            chkAddPrefix.Checked = false;
            txtPrefix.Text = string.Empty;

            chkChangeExtension.Checked = false;
            txtExtension.Text = string.Empty;

            chkCustomName.Checked = false;
            txtCustom.Text = string.Empty;
        }

        public override bool ValidateState()
        {
            bool hasRename =
                ((chkAddPrefix.Checked || chkRemovePrefix.Checked) && (!string.IsNullOrEmpty(txtPrefix.Text))) ||
                (chkChangeExtension.Checked && (!string.IsNullOrEmpty(txtExtension.Text)) ||
                (chkCustomName.Checked && (!string.IsNullOrEmpty(txtCustom.Text))));

            if ((chkAddPrefix.Checked || chkRemovePrefix.Checked) && string.IsNullOrEmpty(txtPrefix.Text))
            {
                PushError("Prefix cannot be empty when adding or removing a prefix");
                return false;
            }

            if (chkChangeExtension.Checked && string.IsNullOrEmpty(txtExtension.Text))
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
            txtPrefix.Enabled = chkAddPrefix.Checked || chkRemovePrefix.Checked;
            dpDate.Enabled = chkAddPrefix.Checked || chkRemovePrefix.Checked;
            btnUseDate.Enabled = chkAddPrefix.Checked || chkRemovePrefix.Checked;

            //  Extension
            txtExtension.Enabled = chkChangeExtension.Checked;
            btnClearExt.Enabled = chkChangeExtension.Checked;
            btnExtensions.Enabled = chkChangeExtension.Checked;

            if (chkAddPrefix.Checked)
                chkCustomName.Checked = false;
        }

        private void chkAddPrefix_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddPrefix.Checked)
            {
                txtPrefix.Focus();
                chkRemovePrefix.Checked = false;
            }

            UpdateUI();
        }

        private void chkNewExt_CheckedChanged(object sender, EventArgs e)
        {
            txtExtension.Enabled = chkChangeExtension.Checked;

            if (chkChangeExtension.Checked)
            {
                chkCustomName.Checked = false;
                txtExtension.Focus();
            }

            UpdateUI();
        }

        private void chkCustom_CheckedChanged(object sender, EventArgs e)
        {
            txtCustom.Enabled = chkCustomName.Checked;

            if (chkCustomName.Checked)
            {
                chkAddPrefix.Checked = false;
                chkChangeExtension.Checked = false;

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

        private void btnUseDate_Click(object sender, EventArgs e)
        {
            txtPrefix.Text = dpDate.Value.ToString(Utils.K_PREFIX_DATE_MASK);
        }

        private void chkRemovePrefix_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();

            if (chkRemovePrefix.Checked)
            {
                txtPrefix.Focus();
                chkAddPrefix.Checked = false;
            }
        }

        private void btnExtensions_Click(object sender, EventArgs e)
        {
            menuStripExtensions.Show(btnExtensions, new Point(0, btnExtensions.Height));
        }

        private void MenuItem_Click(object? sender, EventArgs e)
        {
            ToolStripMenuItem? menuItem = sender as ToolStripMenuItem;
            if (menuItem == null || string.IsNullOrEmpty(menuItem.Text))
                return;

            string ext = menuItem.Text;
            txtExtension.Text = ext;
        }
    }
}
