using RealityFrameworks;

namespace CommonForms.Components
{
    public class DialogSelectTransform<T> : DialogSelectTransformBase
    {
        //	The active Condition editor
        private EditorBase2? mSelCondEditor = null;

        //	The active Action editor
        private EditorBase2? mSelActionEditor = null;

        public TransformsContainer<T>? Processor { get; set; }

        //  The FileTransform we're editing
        private Transform<T>? Transform { get; set; } = null;

        //  Cache of Editors
        Dictionary<string, EditorBase2> mEditorCache = new();

        //  Tries to find an editor in the cache,
        //  if not found, it creates the editor
        //  if found, returns the instance
        private EditorBase2? FindOrCreateEditor(string name)
        {
            EditorBase2? editor = null;
            if (!mEditorCache.TryGetValue(name, out editor))
            {
                editor = GenericFactory<EditorBase2>.Create(name);
                mEditorCache.Add(name, editor);
            }
            return editor;
        }

        private void LoadStateAdd()
        {
            //  get these strings from localization
            btnSubmit.Text = Locale.DLG_CHANGE_BUTTON_ADD_LABEL;
            Text = Locale.DLG_CHANGE_TITLE_ADD;

            foreach (var keyValuePair in mEditorCache)
                keyValuePair.Value.ResetState();

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

            chkEnabled.Checked = true;
        }

        private void LoadStateEdit(Transform<T> trans)
        {
            //  Make sure Condition and Action are not null
            if (trans == null ||
                trans.Condition == null ||
                trans.Action == null)
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
                return;

            //  reset the editors
            foreach (var keyValuePair in mEditorCache)
                keyValuePair.Value.ResetState();

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
            catch (NotImplementedException ex)
            {
                MessageBox.Show(
                    string.Format("{0}: {1}", mSelCondEditor?.GetType().Name, ex.Message),
                    Locale.DLG_CHANGE_ERR_TITLE_WARNING,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                panelCondition.Controls.Clear();
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
            catch (NotImplementedException ex)
            {
                MessageBox.Show(
                    string.Format("{0}: {1}", mSelActionEditor?.GetType().Name, ex.Message), 
                    Locale.DLG_CHANGE_ERR_TITLE_WARNING, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning
                );
                panelAction.Controls.Clear();
            }

            chkDesc.Checked = trans.HasCustomDescription;
            txtDesc.Enabled = trans.HasCustomDescription;
            txtDesc.Text = trans.Description;
            btnResetDesc.Enabled = trans.HasCustomDescription;

            //  Fill-in remaining change fields
            lblConditionDesc.Text = trans.Condition.Description();
            lblActionDesc.Text = trans.Action.Description;

            chkEnabled.Checked = trans.Enabled;
            chkPrevOutput.Checked = trans.UseLastOutput;
        }

        public void LoadState(EditorState state, Transform<T>? transform = null)
        {
            State = state;
            Transform = transform;

            if (State == EditorState.Add)
                LoadStateAdd();
            else if (State == EditorState.Edit && Transform != null)
                LoadStateEdit(Transform);

            mSelCondEditor?.Select();
        }

        private void HandleAdd()
        {
            //  Condition to be created
            RealityFrameworks.Conditions.Condition<T>? cond = null;

            //  Action to be created
            RealityFrameworks.Actions.Action<T>? action = null;

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

            bool isConditionValid = mSelCondEditor.ValidateState();
            if (isConditionValid && cmbCondition.SelectedItem != null)
            {
                //  Create New Condition by Name
                try
                {
                    cond = GenericFactory<RealityFrameworks.Conditions.Condition<T>>.Create(cmbCondition.SelectedItem.ToString());
                    mSelCondEditor.SaveState(cond);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message, "Failed to create Condition",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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

            bool isActionValid = false;
            if (isConditionValid)
            {
                isActionValid = mSelActionEditor.ValidateState();
                if (isActionValid && cmbAction.SelectedItem != null)
                {
                    try
                    {
                        //  Try to create the Action

                        action = RealityFrameworks.GenericFactory<RealityFrameworks.Actions.Action<T>>.Create(cmbAction.SelectedItem.ToString());
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

            if (isConditionValid && isActionValid && cond != null && action != null)
            {
                Processor?.AddTransform(cond, action);

                //  Notify tab to reload and update ui
                OnModified?.Invoke();

                this.Close();
            }
        }

        private void HandleUpdate()
        {
            //  UPDATE            
            if (Transform == null || 
                Transform.Condition == null || 
                Transform.Action == null)
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
            {
                //  Must update Condition?
                string condName = cmbCondition.SelectedItem?.ToString() ?? string.Empty;
                if (!string.IsNullOrEmpty(condName) && condName != Transform.Condition.GetType().Name)
                    Transform.Condition = RealityFrameworks.GenericFactory<RealityFrameworks.Conditions.Condition<T>>.Create(condName);

                //  Save State: Editor -> Condition
                mSelCondEditor?.SaveState(Transform.Condition);
            }
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
            {
                //  Must update Action?
                string actionName = cmbAction.SelectedItem?.ToString() ?? string.Empty;

                if (!string.IsNullOrEmpty(actionName) && actionName != Transform.Action.GetType().Name)
                    Transform.Action = RealityFrameworks.GenericFactory<RealityFrameworks.Actions.Action<T>>.Create(actionName);

                //  Save State: Editor -> Action
                mSelActionEditor?.SaveState(Transform.Action);
            }
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
            else
                Transform.ResetDescription();

            Transform.Enabled = chkEnabled.Checked;
            Transform.UseLastOutput = chkPrevOutput.Checked;

            //  notify tab of changes so it can reload
            OnModified?.Invoke();

            this.Close();
        }

        protected override void OnHandleSubmit()
        {
            if (State == EditorState.Add)
                HandleAdd();
            else if (State == EditorState.Edit)
                HandleUpdate();
        }

        protected override void OnResetDescription()
        {
            if (Transform != null)
            {
                Transform.ResetDescription();
                txtDesc.Text = Transform.Description;
                chkDesc.Checked = false;

                OnModified?.Invoke();
            }
        }

        protected override void OnConditionIndexChanged()
        {
            if (cmbCondition.SelectedIndex == -1 || cmbCondition.SelectedItem == null)
            {
                mSelCondEditor = null;
                return;
            }

            string? condName = cmbCondition.SelectedItem.ToString();

            if (condName == null)
            {
                MessageBox.Show("condName is null in OnConditionIndexChanged()");
                return;
            }

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

        protected override void OnActionIndexChanged()
        {
            if (cmbAction.SelectedIndex == -1 || cmbAction.SelectedItem == null)
            {
                mSelActionEditor = null;
                return;
            }

            string? actionName = cmbAction.SelectedItem.ToString();
            if (actionName == null)
            {
                MessageBox.Show("actionName null in OnActionIndexChanged()");
                return;
            }

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
    }

    public partial class DialogSelectTransformBase : Form
    {
        //  States the Editor can be in (Add or Edit)
        public enum EditorState { Add, Edit };

        //	Editor's state
        public EditorState State { get; set; }

        //  The callback for when something has been modified
        public delegate void OnModified_Callback();

        public OnModified_Callback? OnModified { get; set; }

        //  Handlers that all well-behaved derived classes
        //  should implement to ensure proper functionality
        protected virtual void OnHandleSubmit() { }

        protected virtual void OnResetDescription() { }

        protected virtual void OnConditionIndexChanged() { }

        protected virtual void OnActionIndexChanged() { }

        public DialogSelectTransformBase()
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void cmbCondition_SelectedIndexChanged(object? sender, EventArgs e)
        {
            OnConditionIndexChanged();
        }

        protected void cmbAction_SelectedIndexChanged(object? sender, EventArgs e)
        {
            OnActionIndexChanged();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            OnHandleSubmit();
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
            OnResetDescription();
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
