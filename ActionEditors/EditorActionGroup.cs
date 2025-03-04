using RealityFrameworks.Actions;
using System.Text;

/*
 *  Editor for a group of actions
 */
namespace CommonForms
{

    public partial class EditorActionGroup : EditorBase
    {
        //  The ActionGroup instance we're editing
        private ActionGroup<string>? mActionGroup = null;

        //  Index of the current action in _actionGroup
        private int mActionIndex = -1;

        //  List of editors we've already created
        private List<CommonForms.EditorBase> mEditors = new();

        //  Panel to display when there's no editor selected
        private UserControl? mStartPanel;

        public void LoadActionNames(List<string> actionNames)
        {
            menuStripActions.Items.Clear();

            if (actionNames == null)
                return;

            //  Add action names to menu strip
            foreach (string item in actionNames)
                menuStripActions.Items.Add(item, null, MenuItem_Click);

            UpdateUI();
        }

        public EditorActionGroup()
        {
            InitializeComponent();

            //  gets called for the first time in when LoadActionNames is called
            //  leave here for reference
            //UpdateUI();

            CreateStartPanel();
        }

        private void CreateStartPanel()
        {
            mStartPanel = new UserControl
            {
                Dock = DockStyle.Fill // Panel will fill the form
            };

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
            CommonForms.Utils.AddUserControlToPanel(panelActiveAction, mStartPanel);
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
            foreach (var editor in mEditors)
            {
                if (!editor.ValidateState())
                {
                    StringBuilder sb = new();
                    sb.Append(editor.GetType().Name);
                    sb.Append(": ");
                    while (editor.HasErrors())
                    {
                        sb.Append(editor.PopError());
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
                && mActionIndex >= 0 && mActionIndex < mEditors.Count;

            btnAdd.Enabled = menuStripActions.Items.Count > 0;
        }

        public override void LoadState(FileAction action)
        {
            if (action is ActionGroup<string> ag)
            {
                mActionGroup = ag;
                mActionIndex = 0;

                LoadActiveAction();
            }
        }

        public override void SaveState(FileAction action)
        {
            if (action is ActionGroup<string> ag)
            {
                //  for each editor, call editor's SaveState
                foreach (var editor in mEditors)
                {
                    string name = editor.Name;
                }
            }
        }

        public override void ClearState()
        {
            mActionIndex = -1;
            mEditors.Clear();
            UpdateUI();
            CommonForms.Utils.AddUserControlToPanel(panelActiveAction, mStartPanel);
        }

        private void LoadActiveAction()
        {
            if (mActionGroup == null)
                return;

            //  count actions
            int count = mActionGroup.CountActions();

            btnPrev.Enabled = mActionIndex > 0;
            btnNext.Enabled = mActionIndex < count - 1;
            btnDel.Enabled = mActionIndex >= 0 && mActionIndex < count && count > 1;

            if (count > 0)
            {
                lblCountActions.Text = string.Format("{0}/{1}", mActionIndex + 1, count);

                //  get current action
                FileAction currentAction = mActionGroup.GetActionAt(mActionIndex);

                string actionTypeName = currentAction.GetType().Name;
                lblActionName.Text = string.Format("({0})", actionTypeName);

                CommonForms.EditorBase? editor = null;
                if (mActionIndex >= 0 && mActionIndex < mEditors.Count)
                {
                    //  get the editor from the list, but do not load the action's state
                    editor = mEditors[mActionIndex];
                }
                else
                {
                    //  Create the Editor
                    editor = EditorFactory.Create(actionTypeName);

                    //  Insert editor in list
                    mEditors.Insert(mActionIndex, editor);

                    //  Load the action state, but only when creating editor
                    editor.LoadState(currentAction);
                }

                //  add editor
                Utils.AddUserControlToPanel(panelActiveAction, editor);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (mActionGroup == null)
                return;

            if (mActionIndex > 0)
            {
                mActionIndex--;
                LoadActiveAction();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (mActionGroup == null)
                return;

            if (mActionIndex < mActionGroup.CountActions() - 1)
            {
                mActionIndex++;
                LoadActiveAction();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (mActionGroup == null)
                return;

            string msg = string.Format("Delete {0}?", mActionGroup.GetActionAt(mActionIndex).GetType().Name);
            string title = "Confirmation";
            DialogResult answer = MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                int count = mActionGroup.CountActions();
                if (count == 1)
                {
                    MessageBox.Show("Must leave at least one action in group.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                mActionGroup.RemoveActionAt(mActionIndex);

                //  have next?
                if (mActionIndex >= mActionGroup.CountActions())
                    mActionIndex--;

                LoadActiveAction();

                //  Reload the processor list
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            menuStripActions.Show(btnAdd, new Point(0, btnAdd.Height));
        }

        private void MenuItem_Click(object? sender, EventArgs e)
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
                mActionIndex = mActionGroup.CountActions() - 1;
                LoadActiveAction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
