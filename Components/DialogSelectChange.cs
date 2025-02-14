using RealityFrameworks;
using RealityFrameworks.Conditions;

namespace CommonForms.Components
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

        private FileTransform? Transform { get; set; } = null;

        //  Cache of Editors
        Dictionary<string, EditorBase> mEditorCache = new();

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

        //  Tries to find an editor in the cache, if not found, creates it
        private EditorBase? FindOrCreateEditor(string name)
        {
            EditorBase? editor = null;
            if (!mEditorCache.TryGetValue(name, out editor))
            {
                editor = GenericFactory<EditorBase>.Create(name);
                mEditorCache.Add(name, editor);
            }
            return editor;
        }

        private void LoadStateAdd()
        {
            //  get these strings from localization
            btnSubmit.Text = Locale.DLG_CHANGE_BUTTON_ADD_LABEL;
            Text = Locale.DLG_CHANGE_TITLE_ADD;

            //  Clear Editor Condition
            panelCondition.Controls.Clear();

            //  Clear Editor Action
            panelAction.Controls.Clear();

            ComboBox[] comboBoxes = { cmbCondition, cmbAction };
            foreach (ComboBox comboBox in comboBoxes)
            {
                if (comboBox.Items.Count > 0)
                {
                    comboBox.SelectedIndex = -1;
                    comboBox.SelectedIndex = 0;  // Select first item
                }
            }
            txtDesc.Clear();
            chkDesc.Checked = false;
            btnResetDesc.Enabled = false;

            //  reset the editors
            foreach (var kvPair in mEditorCache)
                kvPair.Value.ClearState();

            chkEnabled.Checked = true;
        }

        private void LoadStateEdit(Transform<string> trans)
        {
            //  Make sure Condition and Action are not null
            if (trans.Condition == null || trans.Action == null)
            {
                MessageBox.Show(
                    Locale.DLG_CHANGE_ERR_MSG_CHANGE_WRONG,
                    Locale.DLG_CHANGE_ERR_TITLE_ERROR,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            btnSubmit.Text = Locale.DLG_CHANGE_BUTTON_UPDATE_LABEL;
            Text = Locale.DLG_CHANGE_TITLE_EDIT;

            if (trans == null)
            {
                return;
            }

            //  reset the editors
            foreach (var kvPair in mEditorCache)
                kvPair.Value.ClearState();

            //  CONDITION editor
            try
            {
                //  Try to FIND Condition Editor INSTEAD of Creating it
                //  If it's not found, Create it and Store it in a Dictionary
                string condName = trans.Condition.GetType().Name;
                mSelCondEditor = FindOrCreateEditor(condName);
                if (mSelCondEditor != null)
                {
                    mSelCondEditor.LoadState(trans.Condition);

                    int condIndex = cmbCondition.Items.IndexOf(condName);
                    if (condIndex != -1)
                    {
                        cmbCondition.SelectedIndexChanged -= cmbCondition_SelectedIndexChanged;
                        cmbCondition.SelectedIndex = condIndex;
                        cmbCondition.SelectedIndexChanged += cmbCondition_SelectedIndexChanged;
                    }

                    Utils.AddUserControlToPanel(panelCondition, mSelCondEditor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message, 
                    Locale.DLG_CHANGE_ERR_TITLE_WARNING, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning
                );
            }

            //  ACTION Editor
            try
            {
                string actName = trans.Action.GetType().Name;
                mSelActionEditor = FindOrCreateEditor(actName);
                if (mSelActionEditor != null)
                {
                    mSelActionEditor.LoadState(trans.Action);

                    int actIndex = cmbAction.Items.IndexOf(actName);
                    if (actIndex != -1)
                    {
                        cmbAction.SelectedIndexChanged -= cmbAction_SelectedIndexChanged;
                        cmbAction.SelectedIndex = actIndex;
                        cmbAction.SelectedIndexChanged += cmbAction_SelectedIndexChanged;
                    }

                    Utils.AddUserControlToPanel(panelAction, mSelActionEditor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Locale.DLG_CHANGE_ERR_TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panelAction.Controls.Clear();

                //  TODO: Deselect Action Editor or something.
            }

            chkDesc.Checked = trans.HasCustomDescription;
            txtDesc.Enabled = trans.HasCustomDescription;
            txtDesc.Text = trans.Description;
            btnResetDesc.Enabled = trans.HasCustomDescription;

            //  Fill-in remaining change fields
            lblConditionDesc.Text = trans.Condition.Description();
            lblActionDesc.Text = trans.Action.Description;

            chkEnabled.Checked = trans.Enabled;
        }

        public void LoadState(EditorState state, Transform<string> transform = null)
        {
            State = state;
            Transform = transform;

            if (State == EditorState.Add)
                LoadStateAdd();
            else if (State == EditorState.Edit)
                LoadStateEdit(Transform);

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
                mSelCondEditor = FindOrCreateEditor(condName);
                if (mSelCondEditor != null)
                    Utils.AddUserControlToPanel(panelCondition, mSelCondEditor);
            }
            catch (Exception ex)
            {
                panelCondition.Controls.Clear();
                MessageBox.Show(ex.Message, Locale.DLG_CHANGE_ERR_TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cmbAction_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbAction.SelectedIndex == -1 || cmbAction.SelectedItem == null)
            {
                mSelActionEditor = null;
                return;
            }

            string actionName = cmbAction.SelectedItem.ToString();
            try
            {
                mSelActionEditor = FindOrCreateEditor(actionName);
                if (mSelActionEditor != null)
                    Utils.AddUserControlToPanel(panelAction, mSelActionEditor);
            }
            catch (Exception ex)
            {
                panelAction.Controls.Clear();
                MessageBox.Show(ex.Message, Locale.DLG_CHANGE_ERR_TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void HandleAdd()
        {
            //  Condition to be created
            Condition<string>? cond = null;

            //  Action to be created
            FileAction? action = null;

            string errTitle = string.Empty;
            string errMsg = string.Empty;
            
            if (mSelCondEditor == null)
            {
                errTitle = "Heads up!";
                MessageBox.Show(errMsg, Locale.DLG_CHANGE_ERR_MSG_SELECT_CONDITION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (mSelActionEditor == null)
            {
                errTitle = "Heads up!";
                MessageBox.Show(errMsg, Locale.DLG_CHANGE_ERR_MSG_SELECT_ACTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool conditionIsValid = mSelCondEditor.ValidateState();
            if (conditionIsValid && cmbCondition.SelectedItem != null)
            {
                //  Create New Condition by Name
                try
                {
                    cond = FileConditionFactory.Create(cmbCondition.SelectedItem.ToString());
                    mSelCondEditor.SaveState(cond);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message, "Failed to create Condition",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                errMsg = string.Empty;
                while (mSelCondEditor.HasErrors())
                {
                    if (!string.IsNullOrEmpty(errMsg))
                        errMsg += "\n\n";
                    errMsg += mSelCondEditor.PopError();
                }
                MessageBox.Show(errMsg, Locale.DLG_CHANGE_ERR_TITLE_CONDITION_NOT_VALID, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bool actionIsValid = false;
            if (conditionIsValid)
            {
                actionIsValid = mSelActionEditor.ValidateState();
                if (actionIsValid && cmbAction.SelectedItem != null)
                {
                    try
                    {
                        //  Try to create the Action
                        action = FileActionFactory.Create(cmbAction.SelectedItem.ToString());
                        mSelActionEditor.SaveState(action);
                    } 
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message, "Failed to create Action", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //  Collect the Action validation errors (from the editor)
                    errMsg = string.Empty;
                    while (mSelActionEditor.HasErrors())
                    {
                        if (!string.IsNullOrEmpty(errMsg))
                            errMsg += "\n\n";
                        errMsg += mSelActionEditor.PopError();
                    }
                    MessageBox.Show(errMsg, Locale.DLG_CHANGE_ERR_TITLE_ACTION_NOT_VALID, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void HandleUpdate()
        {
            //  UPDATE            
            if (Transform == null || Transform.Condition == null || Transform.Action == null)
            {
                MessageBox.Show(
                    Locale.DLG_CHANGE_ERR_MSG_CHANGE_WRONG,
                    Locale.DLG_CHANGE_ERR_TITLE_ERROR,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            string errMsg;

            //  CONDITION Validation
            if (mSelCondEditor != null && mSelCondEditor.ValidateState())
                mSelCondEditor?.SaveState(Transform.Condition);
            else
            {
                if (mSelCondEditor == null)
                    errMsg = Locale.DLG_CHANGE_ERR_MSG_SELECT_CONDITION;
                else
                {
                    errMsg = string.Empty;
                    while (mSelCondEditor.HasErrors())
                    {
                        if (!string.IsNullOrEmpty(errMsg))
                            errMsg += "\n\n";
                        errMsg += mSelCondEditor.PopError();
                    }
                    
                }                 
                MessageBox.Show(
                    errMsg,
                    Locale.DLG_CHANGE_ERR_TITLE_WARNING,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            //  ACTION Validation
            errMsg = string.Empty;
            if (mSelActionEditor != null && mSelActionEditor.ValidateState())
                mSelActionEditor?.SaveState(Transform.Action);
            else
            {
                if (mSelActionEditor == null)
                    errMsg = Locale.DLG_CHANGE_ERR_MSG_SELECT_ACTION;
                else
                {
                    errMsg = string.Empty;
                    while (mSelActionEditor.HasErrors())
                    {
                        if (!string.IsNullOrEmpty(errMsg))
                            errMsg += "\n\n";
                        errMsg += mSelActionEditor.PopError();
                    }

                }
                MessageBox.Show(
                    errMsg,
                    Locale.DLG_CHANGE_ERR_TITLE_WARNING,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (chkDesc.Checked)
            {
                if (string.IsNullOrEmpty(txtDesc.Text))
                {
                    MessageBox.Show(
                        Locale.DLG_CHANGE_ERR_MSG_DESC, 
                        Locale.DLG_CHANGE_ERR_TITILE_DESC, 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                    return;
                }

                Transform.Description = txtDesc.Text;
            }

            Transform.Enabled = chkEnabled.Checked;

            CallModifiedCallback();

            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (State == DialogSelectChange.EditorState.Add)
                HandleAdd();
            else if (State == DialogSelectChange.EditorState.Edit)
                HandleUpdate();
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
            btnResetDesc.Enabled = chkDesc.Checked;
        }

        private void btnResetDesc_Click(object sender, EventArgs e)
        {
            if (Transform != null)
            {
                Transform.ResetDescription();
                txtDesc.Text = Transform.Description;
                chkDesc.Checked = false;

                CallModifiedCallback();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;    //  consume the key press event
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
