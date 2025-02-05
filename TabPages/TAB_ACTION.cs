using RealityFrameworks;

namespace CommonForms
{
    public partial class TAB_Action : ApplicationPageBase
    {
        private EditorBase<string>? mSelectedEditor = null;

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

            mSelectedEditor = GenericFactory<EditorBase<string>>.Create(cmbActions.SelectedItem.ToString());

            if (panelEditor.Controls.Contains(mSelectedEditor))
                return;

            Utils.AddUserControlToPanel(panelEditor, mSelectedEditor);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (cmbActions.SelectedItem == null) 
                return;

            if (mSelectedEditor == null)
                return;

            RealityFrameworks.Actions.Action<string> action;
            action = GenericFactory<RealityFrameworks.Actions.Action<string>>.Create(cmbActions.SelectedItem.ToString());

            try
            {
                mSelectedEditor.SaveState(action);
            }
            catch (Exception ex)
            {
                string title = "Exception";
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //  foreach file in list, action.Execute();
        }
    }
}
