using RealityFrameworks.Actions;
using System.Text;
using static CommonForms.Utils;

/*
 *  Editor for a group of actions
 */
namespace CommonForms
{
    using ActionNameAndEditorPair = Tuple<string, CommonForms.EditorBase>;

    public partial class EditorActionGroup : EditorBase
    {
        //  Index of the current action in _actionGroup
        private int mEditorIndex = -1;

        //  List of editors we've already created
        private List<ActionNameAndEditorPair> mEditors = new();

        //  Panel to display when there's no editor selected
        private UserControl mStartPanel = new UserControl();

        public void LoadActionNames(List<string> actionNames)
        {
            menuStripActions.Items.Clear();

            if (actionNames == null)
                return;

            //  Add action names to menu strip
            foreach (string item in actionNames)
                menuStripActions.Items.Add(item, null, MenuItem_Click);

            RefreshUI();
        }

        public EditorActionGroup()
        {
            InitializeComponent();

            ConfigureStartPanel();

            RefreshUI();
        }

        private void ConfigureStartPanel()
        {
            mStartPanel.Dock = DockStyle.Fill; 

            // Create a Label
            Label label = new Label
            {
                Text = "Start by adding an action to the group",
                AutoSize = true, // Automatically adjust size based on text
                TextAlign = ContentAlignment.MiddleCenter, // Center the text
                Dock = DockStyle.Fill // Fill the entire panel
            };

            // Add the label to the panel
            mStartPanel.Controls.Add(label);
        }

        public override bool ValidateState()
        {
            //  have at least one action
            if (mEditors.Count == 0)
            {
                PushError("Must add at least one Action to the group");
                return false;
            }

            bool isValid = true;

            //  each editor must be valid
            for (int idx = 0; idx < mEditors.Count(); ++idx)
            {
                var editorPair = mEditors.ElementAt(idx);
                if (!editorPair.Item2.ValidateState())
                {
                    StringBuilder sb = new();
                    sb.Append(string.Format("{0}_[{1}]: ", editorPair.Item1, idx + 1));
                    while (editorPair.Item2.HasErrors())
                    {
                        sb.Append(editorPair.Item2.PopError());
                        PushError(sb.ToString());
                    }

                    //  bail out
                    isValid = false;
                    
                    //break;    //  uncomment to break at first error
                }
            }

            return isValid;
        }

        public override void LoadState(FileAction action)
        {
            if (!(action is ActionGroup<string> ag))
                return;

            ClearState();

            for (int idx = 0; idx < ag.CountActions(); ++idx)
            {
                //  get the action from the group
                FileAction fileAction = ag.GetActionAt(idx);
                
                //  make sure there's an action
                if (fileAction == null)
                    continue;

                string actionName = fileAction.GetType().Name;

                //  create an editor
                EditorBase editor = EditorFactory.Create(actionName);

                //  make sure we have an editor
                if (editor == null)
                    continue;

                //  Load state from action
                editor.LoadState(fileAction);

                //  Cache the actionName and editor
                mEditors.Insert (
                    mEditors.Count(), 
                    new ActionNameAndEditorPair (actionName, editor)
                );
            }
            
            //  set the editor index
            mEditorIndex = mEditors.Count() > 0 ? 0 : -1;

            //  Reload the stat of the UI
            RefreshUI();
        }

        public override void SaveState(FileAction action)
        {
            if (!(action is ActionGroup<string> actionGroup))
                return;

            actionGroup.ClearActions();

            foreach (var editorPair in mEditors)
            {
                //  get the action name
                string actionName = editorPair.Item1;

                //  get the editor
                EditorBase editor = editorPair.Item2;

                //  create the action
                FileAction oneGroupAction = FileActionFactory.Create(actionName);
                
                //  make sure group action was created
                if (oneGroupAction == null)
                    continue;

                //  save the state
                editor.SaveState(oneGroupAction);

                //  add action to group
                actionGroup.AddAction(oneGroupAction);
            }
        }

        public override void ClearState()
        {
            //  Clear the editors
            mEditors.Clear();

            //  Reset the index
            mEditorIndex = -1;

            //  Refresh!
            RefreshUI();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (mEditorIndex > 0 && mEditorIndex < mEditors.Count())
            {
                mEditorIndex--;
                RefreshUI();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (mEditorIndex >= 0 && mEditorIndex < mEditors.Count() - 1)
            {
                mEditorIndex++;
                RefreshUI();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int count = mEditors.Count();

            //  make sure editor index is within bounds
            if (!(mEditorIndex >= 0 && mEditorIndex < count))
                return;
            
            string msg = string.Format("Delete {0}?", mEditors.ElementAt(mEditorIndex).Item1);
            string title = "Confirmation";
            DialogResult answer = MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                mEditors.RemoveAt(mEditorIndex);
                mEditorIndex = mEditors.Count() - 1;

                RefreshUI();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            menuStripActions.Show(btnAdd, new Point(0, btnAdd.Height));
        }

        /*
         * RefreshUI reloads the UI state
         *  - sets the current action name,
         *  - enables or disables the prev/next buttons
         *  - sets the current editor index and editor count
         *  - reloads the appropriate editor based on current editor index
         *      - if it's -1, it loads the start panel
         *      - else it loads the stored editor
         */
        private void RefreshUI()
        {
            int count = mEditors.Count();

            //  Buttons
            btnPrev.Enabled = mEditorIndex > 0 && count > 1;
            btnNext.Enabled = mEditors.Count > 1 && mEditorIndex < count - 1;
            btnDel.Enabled = mEditorIndex >= 0 && mEditorIndex < count;

            //  Add button
            btnAdd.Enabled = menuStripActions.Items.Count > 0;

            //  Action name
            if (mEditorIndex >= 0 && mEditorIndex < mEditors.Count())
                lblActionName.Text = string.Format("({0})", mEditors[mEditorIndex].Item1);
            else
                lblActionName.Text = string.Empty;

            //  Count actions
            if (count > 0)
                lblCountActions.Text = string.Format("{0}/{1}", mEditorIndex + 1, count);
            else
                lblCountActions.Text = "-";

            //  Reset the editor
            if (count == 0)
                AddUserControlToPanel(panelActiveAction, mStartPanel);
            else
            {
                if (mEditorIndex >= 0 && mEditorIndex < count)
                    AddUserControlToPanel(panelActiveAction, mEditors.ElementAt(mEditorIndex).Item2);
                else
                    //  WTF? Wrong mEditorIndex state
                    AddUserControlToPanel(panelActiveAction, mStartPanel);
            }
        }

        private void MenuItem_Click(object? sender, EventArgs e)
        {
            ToolStripMenuItem? menuItem = sender as ToolStripMenuItem;
            if (menuItem == null || string.IsNullOrEmpty(menuItem.Text))
                return;

            string actionName = menuItem.Text;

            //  create the editor with the action name
            lblActionName.Text = string.Format("({0})", actionName);

            //  Create the Editor
            EditorBase? editor;
            editor = EditorFactory.Create(actionName);
            if (editor != null)
            {
                //  Insert editor in list
                mEditors.Insert(mEditors.Count(), new ActionNameAndEditorPair(actionName, editor));
                mEditorIndex = mEditors.Count() - 1;

                RefreshUI();
            }
        }
    }
}
