using RealityFrameworks;
using System.ComponentModel;

namespace CommonForms
{
    public partial class EditorRenameFile : EditorBase
    {
        private ActionRenameFile _action = null;

        //  Every Editor should contain:
        //  - concrete action (member)
        //  - setter / getter 
        //  - load from action (concrete)
        //  - save to action (concrete)
        //  - save()

        public ActionRenameFile Action
        {
            get { return _action; }
            set
            {
                _action = value;
                LoadState(_action);
            }
        }

        public EditorRenameFile()
        {
            InitializeComponent();
        }

        private void LoadState(ActionRenameFile arf)
        {
            txtExtension.Text = arf.Extension;
            txtPrefix.Text = arf.Prefix;
            txtCustom.Text = arf.NewFileName;
        }

        public override void SaveState(RealityFrameworks.Action action)
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
            chkCustom.Checked = !chkAddPrefix.Checked;
        }

        private void chkNewExt_CheckedChanged(object sender, EventArgs e)
        {
            txtExtension.Enabled = chkExtension.Checked;
            chkCustom.Checked = !chkExtension.Checked;
        }

        private void chkCustom_CheckedChanged(object sender, EventArgs e)
        {
            chkAddPrefix.Checked = !chkCustom.Checked;
            chkExtension.Checked = !chkCustom.Checked;
        }
    }
}
