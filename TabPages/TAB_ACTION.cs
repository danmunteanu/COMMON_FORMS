using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonForms.TabPages
{
    public partial class TAB_Action : ApplicationPageBase
    {
        public TAB_Action()
        {
            InitializeComponent();
        }

        public void AddAction(string actionName)
        {
            cmbActions.Items.Add(actionName);
        }

        private void cmbActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbActions.SelectedIndex == -1)
                return;

            var editor = EditorFactory.CreateActionEditor(cmbActions.SelectedItem.ToString());

            if (panelEditor.Controls.Contains(editor))
                return;

            editor.Dock = DockStyle.Fill;
            panelEditor.Controls.Clear();
            panelEditor.Controls.Add(editor);
            editor.BringToFront();
        }
    }
}
