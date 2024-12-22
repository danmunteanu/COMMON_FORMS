using RealityFrameworks.Conditions;
using SharpCompress;
using System.ComponentModel;

namespace CommonForms
{
    public partial class EditorHasExtension : EditorBase
    {
        private const string KExtensionSeparator = ";";

        private static string[] _imgExt = [
            "png", "jpg", "jpeg", "bmp"
        ];

        private static string[] _docExt = [
            "doc", "docx", "pdf"
        ];

        private static string[] _txtExt = [
            "txt", "md"
        ];

        public EditorHasExtension()
        {
            InitializeComponent();

            txtAddExt.Select();
        }

        public override bool ValidateState()
        {
            List<string> listExt = txtExtensions.Text.Split(KExtensionSeparator).ToList();

            if (listExt.Count <= 0)
            {
                const string errmsg = "Must add at least one extension.";
                PushError(errmsg);
                return false;
            }

            return true;
        }

        public override void LoadState(Condition cond)
        {
            //if (cond is ConditionHasExtension hasExt)
            //{
            //    lstExtensions.Items.Clear();
            //    for (int idx = 0; idx < hasExt.CountExtensions(); ++idx)
            //    {
            //        lstExtensions.Items.Add(hasExt.GetExtensionAt(idx));
            //    }
            //}
        }

        public override void SaveState(Condition cond)
        {
            //if (cond is ConditionHasExtension hasExt)
            //{
            //    hasExt.ClearExtensions();
            //    foreach (string ext in lstExtensions.Items)
            //    {
            //        hasExt.AddExtension(ext);
            //    }
            //}
        }

        private void btnAddExt_Click(object sender, EventArgs e)
        {
            //  Add Extension
            if (txtAddExt.Text.Length > 0)
            {
                string[] tokens = txtAddExt.Text.Split(KExtensionSeparator);

                AddExtensions(tokens);
            }
        }

        private void btnClearExt_Click(object sender, EventArgs e)
        {
            //  Clear Extensions
            txtExtensions.Clear();
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            AddExtensions(["txt"]);            
        }

        private void btnMd_Click(object sender, EventArgs e)
        {
            AddExtensions(["md"]);
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            AddExtensions(["pdf"]);
        }

        private void AddExtensions(string[] _arrayExt)
        {
            int arrCount = _arrayExt.Count();

            //  Tokenize extensions
            List<string> listExt = txtExtensions.Text.Split(KExtensionSeparator).ToList();

            //  Add each extensions if it's not already added
            for (int i = 0; i < arrCount; i++)
            {
                string whatToAdd = _arrayExt[i] + KExtensionSeparator;

                if (!listExt.Contains(_arrayExt[i]))
                    txtExtensions.Text = txtExtensions.Text.Insert(txtExtensions.Text.Length, whatToAdd);
            }
        }

        private void btnImages_Click(object sender, EventArgs e)
        {
            AddExtensions(_imgExt);
        }

        private void btnDocExt_Click(object sender, EventArgs e)
        {
            AddExtensions(_docExt);
        }

        private void btnTextExt_Click(object sender, EventArgs e)
        {
            AddExtensions(_txtExt);
        }
    }
}
