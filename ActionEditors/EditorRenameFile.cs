using RealityFrameworks;
using System.ComponentModel;

namespace CommonForms
{
    public partial class EditorRenameFile : EditorBase
    {
        ActionRenameFile _action = null;

        //  Every Editor should contain:
        //  - concrete action (member)
        //  - setter / getter 
        //  - load from action (concrete)
        //  - save to action (concrete)
        //  - save()

        ActionRenameFile Action
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

        public EditorRenameFile(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void LoadState(ActionRenameFile arf)
        {
            txtExtension.Text = arf.Extension;
            txtPrefix.Text = arf.Prefix;
            txtCustom.Text = arf.NewFileName;
        }

        public override void SaveState()
        {
            _action.Extension = txtExtension.Text;
            _action.Prefix = txtPrefix.Text;
            _action.NewFileName = txtCustom.Text;
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
