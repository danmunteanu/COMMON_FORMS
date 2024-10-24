namespace CommonForms
{
    public partial class TAB_ExtractPDF : ControlBase
    {
        public ActionExtractPDFPages Action { get; set; }

        private string DESKTOP_PATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";

        public const string K_DATE_MASK = "yyyy-MM-dd hh:mm tt";

        public TAB_ExtractPDF()
        {
            InitializeComponent();

            ToggleUI();
            UpdateStatus("");
        }

        private void UpdateStatus(string message)
        {
            lblStatus.Text = message;
        }

        private void txtPages_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;

            // Allow control characters (backspace, delete, etc.)
            if (char.IsControl(keyChar))
            {
                //ReloadUI();
                return;
            }

            // Allow digits
            if (char.IsDigit(keyChar))
            {
                //ReloadUI();
                return;
            }

            // Allow comma, but ensure it's not the first character or after another comma
            if (keyChar == ',')
            {
                // Prevent a comma from being added at the start or after another comma
                if (txtPages.Text.Length == 0 || txtPages.Text.EndsWith(",") || txtPages.Text.EndsWith(", "))
                {
                    e.Handled = true; // Block the input
                }
                //ReloadUI();
                return;
            }

            // Allow space, but only if it's immediately after a comma
            if (char.IsWhiteSpace(keyChar))
            {
                // Allow space only after a comma, not at the start or after another space
                if (txtPages.Text.EndsWith(","))
                {
                    //ReloadUI();
                    return;
                }
                else
                {
                    e.Handled = true; // Block spaces that are not after a comma
                }
            }
            else
            {
                // Block any other non-digit, non-comma, non-space characters
                e.Handled = true;
            }
        }

        private void ToggleUI()
        {
            bool pdfSelected = !string.IsNullOrEmpty(txtSource.Text);
            bool outputSelected = !string.IsNullOrEmpty(txtDest.Text);
            bool pagesEntered = !string.IsNullOrEmpty(txtPages.Text);

            btnSelectOutput.Enabled = pdfSelected;
            txtPages.Enabled = pdfSelected;
            btnClearPages.Enabled = pdfSelected;

            if (!pdfSelected)
            {
                lblPageCount.Text = "No document loaded.";
            }
            else
            {
                int pageCount = ActionExtractPDFPages.CountPages(txtSource.Text);
                lblPageCount.Text = string.Format("Has {0} page(s).", pageCount);
                txtPages.PlaceholderText = string.Format("Enter page numbers (or intervals) between 1 and {0}", pageCount);
            }


            btnExtract.Enabled = pdfSelected && outputSelected /* && pagesEntered */;
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            // Step 1: Trim trailing commas and spaces
            string input = txtPages.Text.TrimEnd(',', ' ');

            // Step 2: Split the input by commas
            string[] parts = input.Split(',');

            // Step 3: Parse the parts into a list of integers, ignoring empty or invalid parts
            List<int> numbers = new List<int>();
            foreach (var part in parts)
            {
                string trimmedPart = part.Trim(); // Trim any spaces around the number
                if (int.TryParse(trimmedPart, out int number))
                {
                    numbers.Add(number); // Add the valid number to the list
                }
            }

            Action.Pages = numbers.ToArray();
            Action.Destination = txtDest.Text;
            Action.Execute(txtSource.Text);

            UpdateStatus("Selected pages extracted.");
            btnExtract.Enabled = false;
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            //  Select Source
            using (OpenFileDialog dlgOpen = new OpenFileDialog())
            {
                dlgOpen.Filter = "PDF files (*.pdf)|*.pdf";// mResourceManager.GetString("SAVE_DIALOG_FILTER");
                dlgOpen.DefaultExt = "PDF";// mResourceManager.GetString("SAVE_DIALOG_EXT");
                dlgOpen.AddExtension = true;
                dlgOpen.Title = "Select Source (PDF)";// mResourceManager.GetString("SAVE_DIALOG_TITLE");
                dlgOpen.InitialDirectory = DESKTOP_PATH;

                if (dlgOpen.ShowDialog() == DialogResult.OK)
                {
                    txtSource.Text = dlgOpen.FileName;

                    //  clear the fields
                    txtPages.Clear();
                    txtDest.Clear();

                    UpdateStatus("Source document selected.");

                    ToggleUI();
                }
            }
        }

        private string GenerateDestinationFileName(string sourceName)
        {
            string outputName = string.Empty;
            if (string.IsNullOrEmpty(sourceName))
            {
                //  EXTRACT + DATE
                outputName = string.Format("EXTRACT-PAGES-{0}", DateTime.Now.ToString(K_DATE_MASK));
            }
            else
            {
                //  Get Name

                string simpleFileName = Path.GetFileName(sourceName);

                //  Append EXTRACT-{FileName}
                outputName = string.Format("ExtractPages-{1}", DateTime.Now.ToString(K_DATE_MASK), simpleFileName);
            }



            return outputName;
        }

        private void btnDest_Click(object sender, EventArgs e)
        {
            //  Select Destination
            //  Select Source
            using (SaveFileDialog dlgSave = new SaveFileDialog())
            {
                dlgSave.Filter = "PDF files (*.pdf)|*.pdf";// mResourceManager.GetString("SAVE_DIALOG_FILTER");
                dlgSave.DefaultExt = "PDF";// mResourceManager.GetString("SAVE_DIALOG_EXT");
                dlgSave.AddExtension = true;
                dlgSave.Title = "Select Source PDF";// mResourceManager.GetString("SAVE_DIALOG_TITLE");
                dlgSave.FileName = GenerateDestinationFileName(txtSource.Text);
                dlgSave.InitialDirectory = DESKTOP_PATH;

                if (dlgSave.ShowDialog() == DialogResult.OK)
                {
                    txtDest.Text = dlgSave.FileName;

                    UpdateStatus("Destination file selected.");

                    ToggleUI();
                }
            }
        }

        private void btnClearPages_Click(object sender, EventArgs e)
        {
            txtPages.Clear();
        }
    }
}
