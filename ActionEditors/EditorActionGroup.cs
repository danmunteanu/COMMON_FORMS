
using RealityFrameworks;

namespace CommonForms.ActionEditors
{
    public partial class EditorActionGroup : EditorBase
    {
        private int _actionIndex = -1;

        private ActionGroup? _actionGroup = null;

        public EditorActionGroup()
        {            
            InitializeComponent();
        }

        public override void LoadState(RealityFrameworks.Action action)
        {
            if (action is ActionGroup ag)
            {
                _actionGroup = ag;

                _actionIndex = 0;
                LoadActiveAction();
            }
        }

        private void LoadActiveAction()
        {
            if (_actionGroup == null)
                return;

            //  count actions
            int count = _actionGroup.CountActions();

            btnPrev.Enabled = _actionIndex > 0;
            btnNext.Enabled = _actionIndex < count - 1;
            btnDel.Enabled = _actionIndex >= 0 && _actionIndex < count && count > 1;

            if (count > 0)
            {
                lblCountActions.Text = string.Format("{0}/{1}", _actionIndex + 1, count);

                //  get current action
                RealityFrameworks.Action currentAction = _actionGroup.GetActionAt(_actionIndex);

                string actionTypeName = currentAction.GetType().Name;
                lblActionName.Text = string.Format("({0})", actionTypeName);

                //  create the editor
                CommonForms.EditorBase editor = GenericFactory<CommonForms.EditorBase>.CreateByName(actionTypeName);

                //  add editor
                Utils.AddUserControl(panelActiveAction, editor);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_actionGroup == null) 
                return;

            if (_actionIndex > 0)
            {
                _actionIndex--;
                LoadActiveAction();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_actionGroup == null)
                return;

            if (_actionIndex < _actionGroup.CountActions() - 1)
            {
                _actionIndex++;
                LoadActiveAction();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (_actionGroup == null)
                return;

            string msg = string.Format("Delete {0}?", _actionGroup.GetActionAt(_actionIndex).GetType().Name);
            string title = "Confirmation";
            DialogResult answer = MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                int count = _actionGroup.CountActions();
                if (count == 1)
                {
                    MessageBox.Show("Must leave at least one action in group.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                _actionGroup.RemoveActionAt(_actionIndex);
                
                //  have next?
                if (_actionIndex < _actionGroup.CountActions())
                {
                    //  keep unchanged
                } 
                else
                {
                    _actionIndex--;
                }

                LoadActiveAction();

                //  Reload the processor list
            }
        }
    }
}
