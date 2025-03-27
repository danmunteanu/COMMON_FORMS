using CommonForms.Components;
using RealityFrameworks.Actions;
using RealityFrameworks.Conditions;

namespace CommonForms
{
    public partial class TAB_Processor : ApplicationPageBase
    {
        private DialogSelectTransform mDlgSelTrans = new();

        List<string> _conditionNames = new();
        List<string> _actionNames = new();

        List<Func<FileTransform>> mTemplates = new();

        public List<string> ConditionNames
        {
            get { return _conditionNames; }
            set
            {
                _conditionNames = value;
                mDlgSelTrans.LoadConditionNames(value);
            }
        }

        public List<string> ActionNames
        {
            get { return _actionNames; }
            set
            {
                _actionNames = value;
                mDlgSelTrans.LoadActionNames(value);
            }
        }

        public TAB_Processor()
        {
            InitializeComponent();

            lstTransforms.HorizontalScrollbar = true;

            mDlgSelTrans.OnModified = () =>
            {
                ReloadProcessor();
                UpdateUI();
            };

            LoadTooltips();
            LoadTemplates();

            //mFilesProcessor.AddFolder(@"E:\EXILE_3.25", true);
            //mFilesProcessor.AddFolder(@"e:\Path of Building\Data\", true);

            UpdateLocalizations();
        }

        private void LoadTooltips()
        {
            toolTip.SetToolTip(btnAdd, "Add a new Transform");
            toolTip.SetToolTip(btnEdit, "Edit selected Transform");
            toolTip.SetToolTip(btnEnableDisable, "Disable selected Transform");
            toolTip.SetToolTip(btnDel, "Delete selected transform");
            toolTip.SetToolTip(btnReload, "Reloads list of transforms");
            toolTip.SetToolTip(btnTemplates, "Show templates list");
            toolTip.SetToolTip(btnClear, "Clear transforms list");

        }

        private void LoadTemplates()
        {
            //  load the menu items
            menuStripTemplates.Items.Clear();
            menuStripTemplates.Items.Add("YAML/PREFIX: ADD", null, MenuItem_Click);
            menuStripTemplates.Items.Add("YAML/PREFIX: REMOVE", null, MenuItem_Click);

            //  create the templates
            mTemplates.Clear();
            mTemplates.Add(
                //  YAML, ADD PREFIX
                () =>
                {
                    ConditionHasExtension isYaml = new();
                    isYaml.AddExtensions(Utils.YamlFileExtensions.ToArray());

                    ActionRenameFile addPrefix = new()
                    {
                        RenameType = ActionRenameFile.ERenameType.AddPrefix,
                        Prefix = "PREFIX-"
                    };

                    var trans = new FileTransform(isYaml, addPrefix);
                    trans.Description = "ADD PREFIX TO YAML FILES";

                    return trans;
                }
            );

            mTemplates.Add(
                //  YAML, REMOVE PREFIX
                () =>
                {
                    ConditionHasExtension isYaml = new();

                    ActionRenameFile remPrefix = new()
                    {
                        RenameType = ActionRenameFile.ERenameType.RemovePrefix,
                        Prefix = "PREFIX-"
                    };

                    var tr = new FileTransform(isYaml, remPrefix);
                    tr.Description = "REMOVE PREFIX FROM YAML FILES";

                    return tr;
                }
            );
        }

        protected override void OnProcessorSet()
        {
            mDlgSelTrans.Processor = this.Processor;

            ReloadProcessor();

            UpdateUI();
        }

        private void UpdateLocalizations()
        {
            //	reload localization strings
        }

        private void lstProcessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Processor == null) return;

            if (lstTransforms.SelectedIndex == -1)
                return;

            bool haveSelection = lstTransforms.SelectedIndex != -1;

            btnEdit.Enabled = haveSelection;
            btnEnableDisable.Enabled = haveSelection;
            btnEnableDisable.Text = Processor.GetTransformAt(lstTransforms.SelectedIndex).Enabled ? "🚫" : "✅";
            btnDel.Enabled = haveSelection;
        }

        //	Reloads Changes from Processor
        private void ReloadProcessor()
        {
            if (Processor == null) return;
            lstTransforms.Items.Clear();
            for (int idx = 0; idx < Processor.CountTransforms(); idx++)
            {
                var item = Processor.GetTransformAt(idx);
                lstTransforms.Items.Add(item.Description);
            }
        }

        //	Updates the UI state based on the Processor state
        public override void UpdateUI()
        {
            if (Processor == null)
                return;

            bool hasFiles = Processor.CountFileNames() > 0;
            bool hasChanges = Processor.CountTransforms() > 0;
            bool hasSelection = lstTransforms.SelectedIndex != -1;

            btnProcess.Enabled = hasFiles;

            btnAdd.Enabled = true;
            btnEdit.Enabled = hasSelection;
            btnEnableDisable.Enabled = hasSelection;
            btnDel.Enabled = hasSelection;
            btnClear.Enabled = hasChanges;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (Processor == null)
                return;

            //  process all files in the list
            Processor.Process();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mDlgSelTrans.LoadState(DialogSelectTransform.EditorState.Add);
            mDlgSelTrans.ShowDialog(this);
        }

        //	Displays the Edit Change dialog for the selected Change
        private void OnEditSelection()
        {
            if (Processor == null) return;
            if (lstTransforms.SelectedIndex < 0) return;

            //  get current change
            FileTransform trans = Processor.GetTransformAt(lstTransforms.SelectedIndex);
            mDlgSelTrans.LoadState(DialogSelectTransform.EditorState.Edit, trans);
            mDlgSelTrans.ShowDialog(this);
        }

        private void lstProcessor_DoubleClick(object sender, EventArgs e)
        {
            OnEditSelection();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OnEditSelection();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //	TODO: Localize strings
            string title = "Heads up!";
            string msg = string.Format("You are about to remove {0} change(s) from the processor.\n\nAre you sure you want to continue?", Processor.CountTransforms());
            DialogResult answer = MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                //	TODO: Link Clear changes to a delegate? 
                //	Maybe call ReloadProcessor and UpdateUI automatically when ClearChanges is Called
                Processor.ClearTransforms();
                ReloadProcessor();
                UpdateUI();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ReloadProcessor();
            UpdateUI();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lstTransforms.SelectedIndex == -1 || Processor == null)
                return;

            int idx = lstTransforms.SelectedIndex;

            var tr = Processor.GetTransformAt(idx);

            string msg = string.Format("Delete {0}?", tr.Description);
            var res = MessageBox.Show(msg, "Delete confirmation",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            if (res != DialogResult.OK)
                return;

            Processor.RemoveTransformAt(idx);
            
            ReloadProcessor();
            UpdateUI();

            //  repaint
            lstTransforms.Invalidate();
        }

        private void btnEnableDisable_Click(object sender, EventArgs e)
        {
            if (Processor == null) return;
            if (lstTransforms.SelectedIndex < 0) return;

            //  get current transform
            FileTransform tr = Processor.GetTransformAt(lstTransforms.SelectedIndex);
            tr.Enabled = !tr.Enabled;

            if (tr.Enabled)
            {
                btnEnableDisable.Text = "🚫";
                toolTip.SetToolTip(btnEnableDisable, "Disable selected Transform");
            } 
            else
            {
                btnEnableDisable.Text = "✅";
                toolTip.SetToolTip(btnEnableDisable, "Enable selected Transform");
            }

            lstTransforms.Invalidate();
        }

        private void btnTemplates_Click(object sender, EventArgs e)
        {
            //  show a menu
            menuStripTemplates.Show(btnTemplates, new Point(0, btnAdd.Height));
        }

        private void MenuItem_Click(object? sender, EventArgs e)
        {
            ToolStripMenuItem? menuItem = sender as ToolStripMenuItem;
            if (menuItem == null || string.IsNullOrEmpty(menuItem.Text))
                return;

            //  get the index for the item
            int idx = menuStripTemplates.Items.IndexOf(menuItem);

            //  valid index?
            if (idx == -1)
            {
                string title = "Template Error";
                string message = string.Format("Menu item \"{0}\" has returned and invalid index: {1}", menuItem.Text, idx);
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  within bounds
            if (!(idx >= 0 && idx < mTemplates.Count()))
            {
                string title = "Template Error";
                string message = string.Format("There is no template registered for \"{0}\" at position {1}", menuItem.Text, idx);
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  create the FileTransform
            FileTransform tr = mTemplates.ElementAt(idx)();
            Processor?.AddTransform(tr);

            ReloadProcessor();
        }

        private void lstProcessor_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return; // Avoid errors for empty list
            if (Processor == null) return;

            e.DrawBackground();
            e.DrawFocusRectangle();
            
            string? text = lstTransforms.Items[e.Index].ToString();
            Font font = lstTransforms.Font;

            //  make sure index is valid in Processor
            if (e.Index >= 0 && e.Index < Processor.CountTransforms()) 
            {
                if (!Processor.GetTransformAt(e.Index).Enabled)
                    font = new Font(font, FontStyle.Strikeout);
            }

            using (Brush textBrush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(text, font, textBrush, e.Bounds);
            }
        }
    }
}
