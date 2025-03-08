namespace CommonForms
{
    public partial class TAB_Action : ApplicationPageBase
    {
        private EditorBase? mSelectedEditor = null;

        //  Cache of Editors
        Dictionary<string, EditorBase> mEditorCache = new();

        public TAB_Action() 
            => InitializeComponent();

        public void AddAction(string actionName)
            => cmbActions.Items.Add(actionName);

        public void LoadIndex(int idx)
        {
            cmbActions.SelectedIndex = idx;
        }

        //  Tries to find an editor in the cache, if not found, it creates the editor
        private EditorBase? FindOrCreateEditor(string? name)
        {
            EditorBase? editor = null;
            if (name == null)
                return editor;

            if (!mEditorCache.TryGetValue(name, out editor))
            {
                editor = EditorFactory.Create(name);
                mEditorCache.Add(name, editor);
            }
            return editor;
        }

        private void cmbActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbActions.SelectedIndex == -1)
                return;

            //string actionName = (new ActionCopyFile as object).GetType().Name.ToString();

            try
            {
                if (cmbActions.SelectedItem != null && 
                    !string.IsNullOrEmpty(cmbActions.SelectedItem.ToString()))
                {
                    mSelectedEditor = FindOrCreateEditor(cmbActions.SelectedItem.ToString());
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            

            if (mSelectedEditor != null)
            {
                if (panelEditor.Controls.Contains(mSelectedEditor))
                    return;

                Utils.AddUserControlToPanel(panelEditor, mSelectedEditor);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (cmbActions.SelectedItem == null || mSelectedEditor == null)
                return;

            FileAction action = FileActionFactory.Create(cmbActions.SelectedItem.ToString());

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
