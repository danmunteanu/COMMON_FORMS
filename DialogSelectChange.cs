using RealityFrameworks;
using System.Windows.Forms;

namespace CommonForms
{
    public partial class DialogSelectChange : Form
    {

        //	The active Condition editor
        private EditorBase? mSelCondEditor = null;

        //	The active Action editor
        private EditorBase? mSelActionEditor = null;

        public FilesProcessor? Processor { get; set; }

        //  States the Editor can be in (Add or Edit)
        public enum EditorState { Add, Edit };

        //	Editor's state
        public EditorState State { get; set; }

        private Change Change { get; set; }

        //  The callback for when something has been modified
        public delegate void OnModifiedCallback();
        public OnModifiedCallback? OnModified { get; set; }

        public DialogSelectChange()
        {
            InitializeComponent();
        }

        //	Load Condition Names
        public void LoadConditionNames(List<string> conditionNames)
        {
            cmbCondition.Items.Clear();
            foreach (var condition in conditionNames)
                cmbCondition.Items.Add(condition);
            cmbCondition.SelectedIndex = 0;
        }

        //	Load Action Names
        public void LoadActionNames(List<string> actionNames)
        {
            cmbAction.Items.Clear();
            foreach (var action in actionNames)
                cmbAction.Items.Add(action);
            cmbAction.SelectedIndex = 0;
        }

        private void LoadAddState()
        {
            //  get these strings from localization
            btnSubmit.Text = "ADD";
            Text = "Add Change";

            //  Clear Editor Condition
            panelCondition.Controls.Clear();

            //  Clear Editor Action
            panelAction.Controls.Clear();

            //  Select first Condition
            if (cmbCondition.Items.Count > 0)
            {
                cmbCondition.SelectedIndex = -1;
                cmbCondition.SelectedIndex = 0;
            }

            //  Select first Action
            if (cmbAction.Items.Count > 0)
            {
                cmbAction.SelectedIndex = -1;
                cmbAction.SelectedIndex = 0;
            }

            txtDesc.Clear();
            chkDesc.Checked = true;

            chkEnabled.Checked = true;
        }

        private void LoadEditState(Change ch)
        {
            btnSubmit.Text = "UPDATE";
            Text = "Edit Change";

            if (ch == null)
                return;

            //  CONDITION editor
            try
            {
                //  Try to FIND Condition Editor INSTEAD of Creating it
                //  If it's not found, Create it and Store it in a Dictionary
                string condName = ch.Condition.GetType().Name;
                mSelCondEditor = GenericFactory<EditorBase>.CreateByName(condName);
                mSelCondEditor.LoadState(ch.Condition);

                int condIndex = cmbCondition.Items.IndexOf(condName);
                if (condIndex != -1)
                {
                    cmbCondition.SelectedIndexChanged -= cmbCondition_SelectedIndexChanged;
                    cmbCondition.SelectedIndex = condIndex;
                    cmbCondition.SelectedIndexChanged += cmbCondition_SelectedIndexChanged;
                }

                Utils.AddUserControl(panelCondition, mSelCondEditor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //  ACTION Editor
            try
            {
                string actName = ch.Action.GetType().Name;
                mSelActionEditor = GenericFactory<EditorBase>.CreateByName(actName);
                mSelActionEditor.LoadState(ch.Action);

                int actIndex = cmbAction.Items.IndexOf(actName);
                if (actIndex != -1)
                {
                    cmbAction.SelectedIndexChanged -= cmbAction_SelectedIndexChanged;
                    cmbAction.SelectedIndex = actIndex;
                    cmbAction.SelectedIndexChanged += cmbAction_SelectedIndexChanged;
                }

                Utils.AddUserControl(panelAction, mSelActionEditor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //  Fill-in remaining change fields
            lblConditionDesc.Text = ch.Condition.Name;
            lblActionDesc.Text = ch.Action.Description;
            
            chkEnabled.Checked = ch.Enabled;
            
            chkDesc.Checked = false;
            txtDesc.Text = ch.Description;
        }

        public void LoadState(EditorState state, Change change = null)
        {
            State = state;
            Change = change;

            if (State == EditorState.Add)
                LoadAddState();
            else if (State == EditorState.Edit)
                LoadEditState(Change);

            mSelCondEditor?.Select();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCondition.SelectedIndex == -1 || cmbCondition.SelectedItem == null)
            {
                mSelCondEditor = null;
                return;
            }

            string condName = cmbCondition.SelectedItem.ToString();

            try
            {
                //  EditorFactory.FindOrCreateActionEditor
                mSelCondEditor = GenericFactory<EditorBase>.CreateByName(condName);
                Utils.AddUserControl(panelCondition, mSelCondEditor);
            }
            catch (Exception ex)
            {
                panelCondition.Controls.Clear();
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cmbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAction.SelectedIndex == -1 || cmbAction.SelectedItem == null)
            {
                mSelActionEditor = null;
                return;
            }

            string actionName = cmbAction.SelectedItem.ToString();

            try
            {
                mSelActionEditor = GenericFactory<EditorBase>.CreateByName(actionName);
                Utils.AddUserControl(panelAction, mSelActionEditor);
            }
            catch (Exception ex)
            {
                panelAction.Controls.Clear();
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void HandleAdd()
        {
            //  Condition to be created
            RealityFrameworks.Condition? cond = null;

            //  Action to be created
            RealityFrameworks.Action? action = null;

            string errTitle = string.Empty;
            string errMsg = string.Empty;

            if (mSelCondEditor == null)
            {
                errTitle = "Heads up!";
                errMsg = "Please select a condition first!";
                MessageBox.Show(errMsg, errTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (mSelActionEditor == null)
            {
                errTitle = "Heads up!";
                errMsg = "Please select an action first!";
                MessageBox.Show(errMsg, errTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool conditionIsValid = mSelCondEditor.ValidateState();
            if (conditionIsValid && cmbCondition.SelectedItem != null)
            {
                //  Create New Condition by Name
                cond = GenericFactory<Condition>.CreateByName(cmbCondition.SelectedItem.ToString());
                mSelCondEditor.SaveState(cond);

            }
            else
            {
                errTitle = "Condition not valid";
                errMsg = string.Empty;
                while (mSelCondEditor.HasErrors())
                {
                    if (!string.IsNullOrEmpty(errMsg))
                        errMsg += "\n\n";
                    errMsg += mSelCondEditor.PopError();
                }
                MessageBox.Show(errMsg, errTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bool actionIsValid = false;
            if (conditionIsValid)
            {
                actionIsValid = mSelActionEditor.ValidateState();
                if (actionIsValid && cmbAction.SelectedItem != null)
                {
                    action = GenericFactory<RealityFrameworks.Action>.CreateByName(cmbAction.SelectedItem.ToString());
                    mSelActionEditor.SaveState(action);
                }
                else
                {
                    errTitle = "Action not valid";
                    errMsg = string.Empty;
                    while (mSelActionEditor.HasErrors())
                    {
                        if (!string.IsNullOrEmpty(errMsg))
                            errMsg += "\n\n";
                        errMsg += mSelActionEditor.PopError();
                    }
                    MessageBox.Show(errMsg, errTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (conditionIsValid && actionIsValid && cond != null && action != null)
            {
                Processor?.AddChange(cond, action);

                //  Notify tab to reload and update ui
                CallModifiedCallback();

                this.Close();
            }
        }

        private void HandleEdit()
        {
            //  Edit Stuff

            if (Change == null || Change.Condition == null || Change.Action == null)
            {
                MessageBox.Show("Something has gone wrong with the Change! - it's not valid");
                return;
            }

            if (mSelCondEditor != null && mSelCondEditor.ValidateState())
                mSelCondEditor?.SaveState(Change.Condition);
            else
                MessageBox.Show("Invalid Condition Editor State or no Condition Editor selected");

            if (mSelActionEditor != null && mSelActionEditor.ValidateState())
                mSelActionEditor?.SaveState(Change.Action);
            else
                MessageBox.Show("Invalid Action Editor State or no Action editor selected");

            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (State == DialogSelectChange.EditorState.Add)
                HandleAdd();
            else if (State == DialogSelectChange.EditorState.Edit)
                HandleEdit();
        }

        private void CallModifiedCallback()
        {
            if (OnModified != null)
                OnModified();
        }

        private void chkDesc_CheckedChanged(object sender, EventArgs e)
        {
            txtDesc.Enabled = chkDesc.Checked;
            if (chkDesc.Checked)
                txtDesc.Select();
        }
    }
}
