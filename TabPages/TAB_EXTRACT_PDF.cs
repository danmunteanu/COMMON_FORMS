using SharpCompress;

namespace CommonForms
{
    //public abstract class ActionSetter<TAction>
    //{
    //    private TAction? _action;

    //    public abstract void OnActionSet();
       
    //    TAction? Action {  
    //        get { return _action; } 
    //        set { _action = value; OnActionSet(); }
    //    }
    //}

    public partial class TAB_EXTRACT_PDF : ApplicationPageBase
    {
        public ActionExtractPDFPages? Action { get; set; } = null;

        private string DESKTOP_PATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";

        public const string K_DATE_MASK = "yyyy-MM-dd hh:mm tt";

        public int mPageCount = 0;

        public TAB_EXTRACT_PDF()
        {
            InitializeComponent();

            UpdateUI();
            UpdateStatus(string.Empty);
        }

        private void UpdateStatus(string message)
        {
            lblStatus.Text = message;
        }

        private void txtPages_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;

            // Replace selected text if there is a selection
            if (txtPages.SelectionLength > 0 && !char.IsControl(keyChar))
            {
                int selectionStart = txtPages.SelectionStart;
                int selectionLength = txtPages.SelectionLength;

                // Remove the selected text and insert the new character
                txtPages.Text = txtPages.Text.Remove(selectionStart, selectionLength)
                                              .Insert(selectionStart, keyChar.ToString());

                // Move cursor to the position after the inserted character
                txtPages.SelectionStart = selectionStart + 1;
                e.Handled = true; // Mark event as handled to prevent further processing
                return;
            }

            // Allow control characters (backspace, delete, etc.)
            if (char.IsControl(keyChar))
            {
                return;
            }

            // Allow digits and validate range
            if (char.IsDigit(keyChar))
            {
                string currentText = txtPages.Text + keyChar;
                if (!IsValidPageRange(currentText))
                {
                    e.Handled = true;
                }
                return;
            }

            // Allow comma with specific rules
            if (keyChar == ',')
            {
                if (txtPages.Text.Length == 0 || txtPages.Text.EndsWith(",") || txtPages.Text.EndsWith(", "))
                {
                    e.Handled = true;
                }
                return;
            }

            // Allow hyphen for page ranges with specific rules
            if (keyChar == '-')
            {
                if (txtPages.Text.Length == 0 || !char.IsDigit(txtPages.Text[^1]) || txtPages.Text.EndsWith("-") || txtPages.Text.EndsWith(","))
                {
                    e.Handled = true;
                }
                return;
            }

            // Allow space only if it's immediately after a comma
            if (char.IsWhiteSpace(keyChar) && !txtPages.Text.EndsWith(","))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }


        // Helper method to check if each page/range is within the allowed limits
        private bool IsValidPageRange(string input)
        {
            string[] parts = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var part in parts)
            {
                if (part.Contains("-"))
                {
                    var range = part.Split('-');
                    if (range.Length == 2 &&
                        int.TryParse(range[0], out int start) &&
                        int.TryParse(range[1], out int end))
                    {
                        // Ensure both start and end are within page limits
                        if (start < 1 || start > mPageCount || end < 1 || end > mPageCount)
                        {
                            return false; // Page numbers must be within valid range
                        }
                    }
                    else
                    {
                        return false; // Invalid range format
                    }
                }
                else if (int.TryParse(part, out int page))
                {
                    // Check if the single page number is within limits
                    if (page < 1 || page > mPageCount)
                    {
                        return false;
                    }
                }
                else
                {
                    return false; // Non-numeric entry
                }
            }
            return true;
        }

        public override void UpdateUI()
        {
            bool pdfSelected = !string.IsNullOrEmpty(txtSource.Text);
            bool pagesEntered = !string.IsNullOrEmpty(txtPages.Text);

            txtPages.Enabled = pdfSelected;
            btnClearPages.Enabled = pdfSelected;

            if (!pdfSelected)
            {
                lblPageCount.Text = "No document loaded.";
            }
            else
            {
                mPageCount = ActionExtractPDFPages.CountPages(txtSource.Text);
                lblPageCount.Text = string.Format("Has {0} page(s).", mPageCount);
                txtPages.PlaceholderText = string.Format("Enter page numbers (or intervals) between 1 and {0}", mPageCount);
            }

            chkAllowDuplicates.Enabled = pdfSelected;
            btnExtract.Enabled = pdfSelected /* && pagesEntered */;
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            if (Action == null)
            {
                UpdateStatus("Action not set.");
                return;
            }

            string input = txtPages.Text.TrimEnd(',', ' ');

            if (input.Length <= 0)
            {
                UpdateStatus("Please enter one or more page numbers.");
                return;
            }

            using (SaveFileDialog dlgSave = new SaveFileDialog())
            {
                dlgSave.Filter = "PDF files (*.pdf)|*.pdf";
                dlgSave.DefaultExt = "PDF";
                dlgSave.AddExtension = true;
                dlgSave.Title = "Select Destination PDF";
                dlgSave.FileName = GenerateDestinationFileName(txtSource.Text);
                dlgSave.InitialDirectory = DESKTOP_PATH;

                if (dlgSave.ShowDialog() == DialogResult.OK)
                {
                    string[] parts = input.Split(',');

                    List<int> numbers = new List<int>();
                    foreach (var part in parts)
                    {
                        string trimmedPart = part.Trim();

                        if (trimmedPart.Contains("-"))
                        {
                            // Handle page range
                            var range = trimmedPart.Split('-');
                            if (int.TryParse(range[0], out int start) && int.TryParse(range[1], out int end))
                            {
                                if (start <= end)
                                {
                                    // Ascending range, e.g., 1-5
                                    for (int i = start; i <= end; i++)
                                        numbers.Add(i);
                                }
                                else
                                {
                                    // Descending range, e.g., 200-193
                                    for (int i = start; i >= end; i--)
                                        numbers.Add(i);
                                }
                            }
                        }
                        else if (int.TryParse(trimmedPart, out int page))
                        {
                            // Single page entry
                            numbers.Add(page);
                        }
                    }

                    // Pass required fields to action
                    Action.Pages = numbers.ToArray();
                    Action.Destination = dlgSave.FileName;
                    Action.Execute(txtSource.Text);

                    UpdateStatus("Selected pages have been extracted.");
                    UpdateUI();

                    btnExtract.Enabled = false;
                }
            }
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

                    UpdateStatus("Source document selected.");

                    UpdateUI();

                    txtPages.Select();
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

        private void btnClearPages_Click(object sender, EventArgs e)
        {
            txtPages.Clear();
            txtPages.Select();
        }

        public override void UpdateLocale()
        {
            //  update string localizations
        }
    }
}
