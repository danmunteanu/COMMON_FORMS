using RealityFrameworks.Actions;
using System.Text;
using static CommonForms.Utils;

/*
 *  Editor for a group of actions
 */
namespace CommonForms
{
    using ActionEditorPair = Tuple<string, CommonForms.EditorBase>;

    public partial class EditorActionGroup : EditorBase
    {
        //  The ActionGroup instance we're editing
        private ActionGroup<string>? mActionGroup = null;

        //  Index of the current action in _actionGroup
        private int mEditorIndex = -1;

        //  List of editors we've already created
        private List<ActionEditorPair> mEditors = new();

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

            LoadUIState();
        }

        public EditorActionGroup()
        {
            InitializeComponent();

            LoadUIState();

            ConfigureStartPanel();
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

            // Add the panel to the form
            AddUserControlToPanel(panelActiveAction, mStartPanel);
        }

        public override bool ValidateState()
        {
            //  have at least one action
            if (mEditors.Count == 0)
            {
                PushError("Must add at least one Action");
                return false;
            }

            bool isValid = true;

            //  each editor must be valid
            foreach (var editorPair in mEditors)
            {
                if (!editorPair.Item2.ValidateState())
                {
                    StringBuilder sb = new();
                    sb.Append(editorPair.GetType().Name);
                    sb.Append(": ");
                    while (editorPair.Item2.HasErrors())
                    {
                        sb.Append(editorPair.Item2.PopError());
                        PushError(sb.ToString());
                    }

                    //  bail out
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

        public void UpdateUI()
        {
            btnPrev.Enabled = mEditors.Count > 1;
            btnNext.Enabled = mEditors.Count > 1;

            btnDel.Enabled =
                //  don't delete when there's only one action
                mEditors.Count > 1
                //  make sure index is valid
                && mEditorIndex >= 0 && mEditorIndex < mEditors.Count;

            btnAdd.Enabled = menuStripActions.Items.Count > 0;
        }

        public override void LoadState(FileAction action)
        {
            if (action is ActionGroup<string> ag)
            {
                mActionGroup = ag;
                mEditorIndex = mActionGroup.CountActions() > 0 ? 0 : -1;

                LoadActiveAction();
            }
        }

        public override void SaveState(FileAction action)
        {
            if (action is ActionGroup<string> ag)
            {
                //  for each editor, call editor's SaveState
                foreach (var editorPair in mEditors)
                {
                    string name = editorPair.Item2.Name;

                    //  get the action name

                    //  create the action

                    //  editor.save_state(action)
                }
            }
        }

        public override void ClearState()
        {
            //  reset the inner state
            mEditorIndex = -1;
            mActionGroup = null;
            mEditors.Clear();

            //  reload the state
            LoadActiveAction();

            //  add start panel
            AddUserControlToPanel(panelActiveAction, mStartPanel);
        }

        private void LoadActiveAction()
        {
            //  count actions
            int count = mActionGroup != null ? mActionGroup.CountActions() : 0;

            //  can the buttons be enabled?
            btnPrev.Enabled = mEditorIndex > 0;
            btnNext.Enabled = mEditorIndex < count - 1;
            btnDel.Enabled = mEditorIndex >= 0 && mEditorIndex < count;

            //  update label count
            if (count > 0)
                lblCountActions.Text = string.Format("{0}/{1}", mEditorIndex + 1, count);
            else
                lblCountActions.Text = "-";

            if (mActionGroup == null || mEditorIndex == -1 || count == 0)
            {
                lblActionName.Text = string.Empty;

                AddUserControlToPanel(panelActiveAction, mStartPanel);

                return;
            }

            if (count > 0)
            {
                //  get current action
                FileAction currentAction = mActionGroup.GetActionAt(mEditorIndex);

                string actionName = currentAction.GetType().Name;
                lblActionName.Text = string.Format("({0})", actionName);

                EditorBase? editor = null;
                if (mEditorIndex >= 0 && mEditorIndex < mEditors.Count)
                {
                    //  get the editor from the list, but do not load the action's state
                    editor = mEditors[mEditorIndex].Item2;
                }
                else
                {
                    //  Create the Editor
                    editor = EditorFactory.Create(actionName);

                    //  Insert editor in list
                    mEditors.Insert(mEditorIndex, new ActionEditorPair(actionName, editor));

                    //  Load the action state, but only when creating editor
                    editor.LoadState(currentAction);
                }

                //  add editor
                Utils.AddUserControlToPanel(panelActiveAction, editor);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (mEditorIndex > 0 && mEditorIndex < mEditors.Count())
            {
                mEditorIndex--;
                Utils.AddUserControlToPanel(panelActiveAction, mEditors.ElementAt(mEditorIndex).Item2);
                LoadUIState();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (mEditorIndex >= 0 && mEditorIndex < mEditors.Count() - 1)
            {
                mEditorIndex++;
                Utils.AddUserControlToPanel(panelActiveAction, mEditors.ElementAt(mEditorIndex).Item2);
                LoadUIState();
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

                if (!(mEditorIndex >= 0 && mEditorIndex < count))
                    //  add start panel
                    AddUserControlToPanel(panelActiveAction, mStartPanel);
                else
                    //  add the corresponding editor for the new index
                    AddUserControlToPanel(panelActiveAction, mEditors.ElementAt(mEditorIndex).Item2);

                LoadUIState();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            menuStripActions.Show(btnAdd, new Point(0, btnAdd.Height));
        }

        private void LoadUIState()
        {
            int count = mEditors.Count();

            btnPrev.Enabled = mEditorIndex > 0 && count > 1;
            btnNext.Enabled = mEditors.Count > 1 && mEditorIndex < count - 1;
            btnDel.Enabled = mEditorIndex >= 0 && mEditorIndex < count;

            //  update Action name
            if (mEditorIndex >= 0 && mEditorIndex < mEditors.Count())
                lblActionName.Text = string.Format("({0})", mEditors[mEditorIndex].Item1);
            else
                lblActionName.Text = string.Empty;

            //  update label count
            if (count > 0)
                lblCountActions.Text = string.Format("{0}/{1}", mEditorIndex + 1, count);
            else
                lblCountActions.Text = "-";

            //  enable add button
            btnAdd.Enabled = menuStripActions.Items.Count > 0;
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
                mEditors.Insert(mEditors.Count(), new ActionEditorPair(actionName, editor));
                mEditorIndex = mEditors.Count() - 1;

                //  add editor
                AddUserControlToPanel(panelActiveAction, editor);
            
                LoadUIState();
            }
        }

        private void MenuItem_Click2(object? sender, EventArgs e)
        {
            ToolStripMenuItem? menuItem = sender as ToolStripMenuItem;
            if (menuItem == null || string.IsNullOrEmpty(menuItem.Text))
                return;

            string actionName = menuItem.Text;

            try
            {
                FileAction action = FileActionFactory.Create(actionName);
                
                //  must create the action group?
                if (mActionGroup == null)
                    mActionGroup = new();

                //  add action to group
                mActionGroup.AddAction(action);
                
                //  set the index, load active action
                mEditorIndex = mActionGroup.CountActions() - 1;
                
                LoadActiveAction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
