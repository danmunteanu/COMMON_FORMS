using RealityFrameworks;

namespace CommonForms
{
    public partial class DialogSelectChange : Form
    {
        public enum EditorState { Add, Edit };

		//	The active Condition editor
        private EditorBase mSelCondEditor = null;
		
		//	The active Action editor
        private EditorBase mSelActionEditor = null;

		//	Editor's state
        public EditorState State { get; set; }

        public DialogSelectChange()
        {
            InitializeComponent();
        }

		//	Load Condition Names
        public void LoadConditionNames(List<string> conditionNames)
        {
            foreach (var condition in conditionNames)
                cmbCondition.Items.Add(condition);
            cmbCondition.SelectedIndex = 0;
        }
		
		//	Load Action Names
        public void LoadActionNames(List<string> actionNames)
        {
            foreach (var action in actionNames)
                cmbAction.Items.Add(action);
            cmbAction.SelectedIndex = 0;
        }


        public void LoadState(EditorState state, Change change = null)
        {
            if (state == EditorState.Add)
            {
                btnSubmit.Text = "ADD";
                Text = "Add Change";
            }
            if (state == EditorState.Edit)
            {
                btnSubmit.Text = "UPDATE";
                Text = "Edit Change";

                //  CONDITION editor
                try
                {
                    //  Try to FIND Condition Editor
                    //  If it's not found, Create it and Store it in a Dictionary

                    mSelCondEditor = GenericFactory<EditorBase>.CreateConditionEditor(change.Condition.GetType().Name);
                    mSelCondEditor.LoadState(change.Condition);
                    //mSelectedConditionEditor.LoadState(ch.Condition);
                    Utils.AddUserControl(panelCondition, mSelCondEditor);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //  ACTION Editor
                try
                {
                    mSelActionEditor = GenericFactory<EditorBase>.CreateActionEditor(change.Action.GetType().Name);
                    mSelActionEditor.LoadState(change.Action);
                    Utils.AddUserControl(panelAction, mSelActionEditor);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            mSelCondEditor?.Select();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCondition.SelectedIndex == -1)
                return;

            string condName = cmbCondition.SelectedItem.ToString();

            try
            {
                //  EditorFactory.FindOrCreateActionEditor
                mSelCondEditor = GenericFactory<EditorBase>.CreateActionEditor(condName);
                Utils.AddUserControl(panelCondition, mSelCondEditor);
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
                mSelActionEditor = GenericFactory<EditorBase>.CreateActionEditor(actionName);
                Utils.AddUserControl(panelAction, mSelActionEditor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            RealityFrameworks.Condition? cond = null;    //  create condition
            RealityFrameworks.Action? action = null;   //  create action

            if (State == DialogSelectChange.EditorState.Add)
            {
                bool conditionIsValid = mSelCondEditor.ValidateState();
                if (conditionIsValid)
                {
                    //  Create New Condition by Name
                    //  try {
                    //  FactoryCondition.Create(cmbCondition.SelectedItem);
                    //  } catch (Exception ex) {}
                    //  get editorCond
                    //  editorCond.Condition = cond;
                    //  condEditor.SaveState(); //  ui to condition
                } else
                {
                    //  FOR some reason, stack is empty; TO FIX later
                    //MessageBox.Show(mSelectedActionEditor.PopError());

                    //  Update Status on Condition Editor
                    //while (mSelectedConditionEditor.HasErrors())
                    //{
                    //    MessageBox.Show(mSelectedActionEditor.PopError());
                    //}
                }

                bool actionIsValid = false;
                if (conditionIsValid)
                {
                    actionIsValid = mSelActionEditor.Validate();
                    if (actionIsValid)
                    {
                        //  Create New action by name
                        //  try {
                        //  FactoryAction.Create(cmbAction.SelectedItem);
                        //  } catch (Exception ex) {}
                        //  get editorAction
                        //  actionEditor.Action = action
                        //  actionEditor.SaveState ();  //  ui to action
                    }
                    else
                    {
                        //  Update status on Action editor
                    }
                }

                if (conditionIsValid && actionIsValid)
                {
                    //  Change ch = new Change (cond, action);
                    //  FilesProcessor.add (ch);
                }
            }
            else if (State == DialogSelectChange.EditorState.Edit)
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
