using RealityFrameworks;

namespace CommonForms.TabPages
{
    public partial class TAB_Action : ApplicationPageBase
    {
        private EditorBase? mSelectedEditor = null;

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

            mSelectedEditor = GenericFactory<EditorBase>.CreateByName(cmbActions.SelectedItem.ToString());

            if (panelEditor.Controls.Contains(mSelectedEditor))
                return;

            Utils.AddUserControl(panelEditor, mSelectedEditor);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (cmbActions.SelectedItem == null) 
                return;

            if (mSelectedEditor == null)
                return;

            RealityFrameworks.Action action;
            action = GenericFactory<RealityFrameworks.Action>.CreateByName(cmbActions.SelectedItem.ToString());

            mSelectedEditor.SaveState(action);

            //  foreach file in list, action.Execute();
        }
    }
}
