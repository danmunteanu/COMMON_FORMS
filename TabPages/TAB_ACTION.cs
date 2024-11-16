using RealityFrameworks;

namespace CommonForms.TabPages
{
    public partial class TAB_Action : ApplicationPageBase
    {
        public TAB_Action()
        {
            InitializeComponent();
        }

        public void AddAction(string actionName)
        {
            //  NAME - Name for the Action
            //  ACTION_CREATOR - Action Factory
            //  EDITOR_CREATOR - Editor Factory
            cmbActions.Items.Add(actionName);
        }

        private void cmbActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbActions.SelectedIndex == -1)
                return;

            //string actionName = (new ActionCopyFile as object).GetType().Name.ToString();

            var editor = GenericFactory<EditorBase>.CreateActionEditor(cmbActions.SelectedItem.ToString());

            if (panelEditor.Controls.Contains(editor))
                return;

            editor.Dock = DockStyle.Fill;
            panelEditor.Controls.Clear();
            panelEditor.Controls.Add(editor);
            editor.BringToFront();
        }
    }
}
