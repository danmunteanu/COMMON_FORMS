using RealityFrameworks;
using RealityFrameworks.Actions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CommonForms
{
    /*
     * Editor for a group of actions
     */
    public partial class EditorActionGroup : EditorBase
    {
        //  The ActionGroup instance we're editing
        private ActionGroup<string>? mActionGroup = null;

        //  Index of the current action in _actionGroup
        private int mActionIndex = -1;

        //  List of editors we've already created
        private List<CommonForms.EditorBase> mEditorList = new();

        private List<string>? mActionNames;

        public List<string>? ActionNames
        {
            get { return mActionNames; }
            set 
            {
                if (mActionNames != value)
                {
                    mActionNames = value;
                    LoadAddMenuItems();
                }
            }
        }

        public EditorActionGroup()
        {
            InitializeComponent();
        }

        private void LoadAddMenuItems()
        {
            menuStripActions.Items.Clear();
            
            if (mActionNames == null)
                return;
            
            //  Add action names to menu strip
            foreach (string item in mActionNames)
                menuStripActions.Items.Add(item, null, MenuItem_Click);
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

        public override void SaveState(RealityFrameworks.Actions.Action<string> action)
        {
            if (action is ActionGroup<string> ag)
            {
                //  for each editor, call editor's SaveState
                MessageBox.Show("Please implement SaveState() in EditorActionGroup", "Method Not Implemented!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                RealityFrameworks.Actions.Action<string> currentAction = mActionGroup.GetActionAt(mActionIndex);

                string actionTypeName = currentAction.GetType().Name;
                lblActionName.Text = string.Format("({0})", actionTypeName);

                CommonForms.EditorBase? editor = null;
                if (mActionIndex >= 0 && mActionIndex < mEditorList.Count)
                {
                    //  get the editor from the list, but do not load the action's state
                    editor = mEditorList[mActionIndex];
                }
                else
                {
                    //  Create the Editor
                    editor = GenericFactory<CommonForms.EditorBase>.Create(actionTypeName);

                    //  Insert editor in list
                    mEditorList.Insert(mActionIndex, editor);

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

        private void MenuItem_Click(object sender, EventArgs e)
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
