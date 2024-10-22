using RealityFrameworks;

namespace CommonForms
{
    public partial class DialogChangeForm : Form
    {
        public enum EditorState { Add, Edit };

        private UserControl mSelectedConditionEditor = null;
        private UserControl mSelectedActionEditor = null;

        public EditorState State { get; set; }

        public DialogChangeForm()
        {
            InitializeComponent();
        }

        private void AddUserControl(Panel panel, UserControl editor)
        {
            editor.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(editor);
            editor.BringToFront();
        }

        public void LoadConditions(List<RealityFrameworks.Condition> conditions)
        {
            foreach (var condition in conditions)
                cmbCondition.Items.Add(condition.Name);
            cmbCondition.SelectedIndex = 0;
        }
        public void LoadActions(List<RealityFrameworks.Action> actions)
        {
            foreach (var action in actions)
                cmbAction.Items.Add(action.Name);
            cmbAction.SelectedIndex = 0;
        }

        public void LoadState(EditorState state, Change ch = null)
        {
            if (state == EditorState.Add)
            {

            }
            if (state == EditorState.Edit)
            {
                //  Condition editor
                try
                {
                    mSelectedActionEditor = EditorFactory.CreateActionEditor(ch.Condition.Name);
                    AddUserControl(panelCondition, mSelectedActionEditor);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                try
                {
                    mSelectedActionEditor = EditorFactory.CreateActionEditor(ch.Action.Name);
                    AddUserControl(panelAction, mSelectedActionEditor);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conditionName = cmbCondition.SelectedItem.ToString();

            try
            {
                mSelectedActionEditor = EditorFactory.CreateActionEditor(conditionName);
                AddUserControl(panelCondition, mSelectedActionEditor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cmbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            string actionName = cmbAction.SelectedItem.ToString();

            try
            {
                mSelectedConditionEditor = EditorFactory.CreateActionEditor(actionName);
                AddUserControl(panelAction, mSelectedConditionEditor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddOrEdit_Click(object sender, EventArgs e)
        {
            RealityFrameworks.Condition cond = null;    //  create condition
            RealityFrameworks.Action action = null;   //  create action

            if (State == DialogChangeForm.EditorState.Add)
            {
                //  Add stuff
                //cmbCondition.SelectedItem;


                //  Create New Condition by Name
                //  try {
                //  FactoryCondition.Create(cmbCondition.SelectedItem);
                //  } catch (Exception ex) {}
                //  get editorCond
                //  editorCond.Condition = cond;
                //  condEditor.SaveState(); //  ui to condition

                //  Create New action by name
                //  try {
                //  FactoryAction.Create(cmbAction.SelectedItem);
                //  } catch (Exception ex) {}
                //  get editorAction
                //  actionEditor.Action = action
                //  actionEditor.SaveState ();  //  ui to action

                //  Change ch = new Change (cond, action);
                //  FilesProcessor.add (ch);
            }
            else if (State == DialogChangeForm.EditorState.Edit)
            {
                //  Edit Stuff
                
                //  editor already has a Condition set
                //  get editorCondition -> editorCond
                //  editorCond.Condition = condition
                //  editorCond.SaveState(); //  UI fields to condition

                //  editor already has an action set
                //  get editorAction -> editorAct
                //  editorAct.Action = action
                //  editorAct.SaveState(); //   UI fields to action

                //  Done! no need to save the change

                //  maybe update description of the change?
            }
        }
    }
}
