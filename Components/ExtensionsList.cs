namespace CommonForms.Components
{
    public partial class ExtensionsList : UserControl
    {
        private const string KExtensionSeparator = ";";

        private static string[] _docExt = [
            "doc", "docx", "pdf"
        ];

        public bool FreeEditExtensions { 
            get { return txtExtensions.ReadOnly; }
            set { txtExtensions.ReadOnly = !value; }
        }

        public string[] Extensions
        {
            get {
                return txtExtensions.Text.Split(KExtensionSeparator, StringSplitOptions.RemoveEmptyEntries);
            }
        }

        public ExtensionsList()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtExtensions.Clear();
        }

        public bool HasExtensions()
        {
            List<string> listExt = txtExtensions.Text.Split(KExtensionSeparator, StringSplitOptions.RemoveEmptyEntries).ToList();

            return listExt.Count > 0;
        }

        public void AddExtensions(string[] _extensions)
        {
            int arrCount = _extensions.Count();

            //  Tokenize extensions
            List<string> listExt = txtExtensions.Text.Split(KExtensionSeparator, StringSplitOptions.RemoveEmptyEntries).ToList();

            //  Add each extensions if it's not already added
            for (int i = 0; i < arrCount; i++)
            {
                string whatToAdd = _extensions[i] + KExtensionSeparator;

                if (!listExt.Contains(_extensions[i]))
                    txtExtensions.Text = txtExtensions.Text.Insert(txtExtensions.Text.Length, whatToAdd);
            }
        }

        private void btnImages_Click(object sender, EventArgs e)
        {
            AddExtensions(Utils.ImageFileExtensions);
        }

        private void btnDocExt_Click(object sender, EventArgs e)
        {
            AddExtensions(_docExt);
        }

        private void btnYamlExt_Click(object sender, EventArgs e)
        {
            AddExtensions(Utils.YamlFileExtensions);
        }

        private void btnArchives_Click(object sender, EventArgs e)
        {
            AddExtensions(Utils.ArchiveFileExtensions);
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            AddExtensions(Utils.AudioFileExtensions);
        }

        private void btnClearExt_Click(object sender, EventArgs e)
        {
            //  Clear Extensions
            txtExtensions.Clear();
        }
    }
}
