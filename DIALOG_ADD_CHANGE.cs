using RealityFrameworks;

namespace CommonForms
{
    public partial class DIALOG_ADD_CHANGE : Form
    {
        public DIALOG_ADD_CHANGE()
        {
            InitializeComponent();
        }
        private void AddUserControl(Panel panel, UserControl editor)
        {
            editor.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(editor);
            editor.BringToFront();
        }

        public void LoadConditions(List<RealityFrameworks.Condition> conditions)
        {
            foreach (var condition in conditions)
                cmbCondition.Items.Add(condition.Name);
            cmbCondition.SelectedIndex = 0;
        }
        public void LoadActions(List<RealityFrameworks.Action> actions)
        {
            foreach (var action in actions)
                cmbAction.Items.Add(action.Name);
            cmbAction.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conditionName = cmbCondition.SelectedItem.ToString();

            try
            {
                UserControl editAction = EditorFactory.CreateActionEditor(conditionName);
                AddUserControl(panelCondition, editAction);
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
                UserControl editAction = EditorFactory.CreateActionEditor(actionName);
                AddUserControl(panelAction, editAction);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
